using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using CSAF.CVRF12;
using CSAF.CVRF20;

namespace TestAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deserialize a CISCO CVRF Security Advisory
            cvrfdoc doc;            
            using (TextReader tr = new StreamReader("cisco.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(cvrfdoc));
                doc = (cvrfdoc)serializer.Deserialize(tr);
            }

            // Serialize it to a demo XML-File
            using (TextWriter tw = new StreamWriter("cvrfdoc.xml"))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(doc.GetType());
                x.Serialize(tw, doc);
            }


            Rootobject docroot;
            using (TextReader tr = new StreamReader("CVE-2018-0171-modified.json"))
            {                
                string json = tr.ReadToEnd();
                byte[] utf8bytes = Encoding.UTF8.GetBytes(json);
                var utf8Reader = new Utf8JsonReader(utf8bytes);
                var options = new JsonSerializerOptions
                {
                    IgnoreNullValues = true
                };

                docroot = JsonSerializer.Deserialize<Rootobject>(ref utf8Reader, options);
            }

            // Serialization with System.Text.Json --> https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-overview
            using (TextWriter tw = new StreamWriter("cvrfdoc.json"))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IgnoreNullValues = true
                };

                tw.Write(JsonSerializer.Serialize(docroot, docroot.GetType(), options));
            }
        }
    }
}
