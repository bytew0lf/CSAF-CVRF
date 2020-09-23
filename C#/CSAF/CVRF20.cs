using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAF.CVRF20
{

    public class Rootobject
    {
        public Document document { get; set; }
        public Product_Tree product_tree { get; set; }
        public Vulnerability[] vulnerabilities { get; set; }
    }

    public class Document
    {
        public string title { get; set; }
        public string type { get; set; }
        public string csaf_version { get; set; }
        public Publisher publisher { get; set; }
        public Tracking tracking { get; set; }
        public Note[] notes { get; set; }
        public Reference[] references { get; set; }
    }

    public class Publisher
    {
        public string contact_details { get; set; }
        public string issuing_authority { get; set; }
        public string type { get; set; }
    }

    public class Tracking
    {
        public string id { get; set; }
        public string status { get; set; }
        public string version { get; set; }
        public Revision_History[] revision_history { get; set; }
        public DateTime initial_release_date { get; set; }
        public DateTime current_release_date { get; set; }
        public Generator generator { get; set; }
    }

    public class Generator
    {
        public string engine { get; set; }
    }

    public class Revision_History
    {
        public string number { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
    }

    public class Note
    {
        public string title { get; set; }
        public string type { get; set; }
        public string text { get; set; }
    }

    public class Reference
    {
        public string url { get; set; }
        public string description { get; set; }
    }

    public class Product_Tree
    {
        public Branch[] branches { get; set; }
    }

    public class Branch
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch1[] branches { get; set; }
    }

    public class Branch1
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch2[] branches { get; set; }
    }

    public class Branch2
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch3[] branches { get; set; }
    }

    public class Branch3
    {
        public string name { get; set; }
        public string type { get; set; }
        public Product product { get; set; }
    }

    public class Product
    {
        public string product_id { get; set; }
        public string name { get; set; }
    }

    public class Vulnerability
    {
        public string title { get; set; }
        public Id id { get; set; }
        public Note1[] notes { get; set; }
        public string cve { get; set; }
        public Product_Status product_status { get; set; }
        public Score[] scores { get; set; }
        public Remediation[] remediations { get; set; }
        public Reference1[] references { get; set; }
    }

    public class Id
    {
        public string system_name { get; set; }
        public string text { get; set; }
    }

    public class Product_Status
    {
        public string[] known_affected { get; set; }
    }

    public class Note1
    {
        public string title { get; set; }
        public string type { get; set; }
        public string text { get; set; }
    }

    public class Score
    {
        public Cvss_V30 cvss_v30 { get; set; }
    }

    public class Cvss_V30
    {
        public string version { get; set; }
        public string baseScore { get; set; }
        public string baseSeverity { get; set; }
        public string vectorString { get; set; }
    }

    public class Remediation
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Reference1
    {
        public string url { get; set; }
        public string description { get; set; }
    }

}
