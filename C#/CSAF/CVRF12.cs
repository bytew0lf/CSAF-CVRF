using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAF.CVRF12
{
    public class CVRFDocCollection : ICollection<cvrfdoc>
    {
        private List<cvrfdoc> cvrfdocs;

        public CVRFDocCollection()
        {
            cvrfdocs = new List<cvrfdoc>();
        }
        
        public cvrfdoc this[int index]
        {
            get
            {
                if (index >= cvrfdocs.Count)
                {
                    return null;
                }
                return (cvrfdoc)cvrfdocs[index];
            }
            set { cvrfdocs[index] = value; }
        }

        public int Count
        {
            get { return cvrfdocs.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public static bool IsSynchronized
        {
            get { return false; }
        }

        public void Add(cvrfdoc item)
        {
            if (!Contains(item))
            {
                cvrfdocs.Add(item);
            }
            else
            {
                throw new ArgumentException(Resources.Add_ArgumentException, nameof(item));
            }
        }

        public void Clear()
        {
            cvrfdocs.Clear();
        }

        public bool Contains(cvrfdoc item)
        {
            bool found = false;
            foreach (cvrfdoc doc in cvrfdocs)
            {
                if (doc.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(cvrfdoc[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException(string.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.ArgumentNullException, nameof(array)));
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException(Resources.ArgumentOutOfRangeException);
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException(Resources.CopyTo_ArgumentException);

            for (int i = 0; i < cvrfdocs.Count; i++)
            {
                array[i + arrayIndex] = cvrfdocs[i];
            }
        }

        public IEnumerator<cvrfdoc> GetEnumerator()
        {
            return new CVRFDocEnumerator(this);
        }

        public bool Remove(cvrfdoc item)
        {
            bool result = false;

            // Iterate the inner collection to 
            // find the box to be removed.
            for (int i = 0; i < cvrfdocs.Count; i++)
            {
                cvrfdoc curdoc = (cvrfdoc)cvrfdocs[i];

                if (new SameDoc().Equals(curdoc, item))
                {
                    cvrfdocs.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void RemoveAt(int index)
        {
            cvrfdocs.RemoveAt(index);
        }

        public void AddRange(cvrfdoc[] value)
        {
            cvrfdocs.AddRange(value);
        }

        public Array ToArray()
        {
            return cvrfdocs.ToArray();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CVRFDocEnumerator(this);
        }
    }

    public class CVRFDocEnumerator : IEnumerator<cvrfdoc>
    {
        private readonly CVRFDocCollection _collection;
        private int curIndex;
        private cvrfdoc curDoc;
        private bool disposedValue;

        public CVRFDocEnumerator(CVRFDocCollection collection)
        {
            _collection = collection;
            curIndex = -1;
            curDoc = default;
        }

        ~CVRFDocEnumerator()
        {
            Dispose(false);
        }

        public cvrfdoc Current 
        {
            get { return curDoc; }
        }

        object IEnumerator.Current
        {
            get { return curDoc; }
        }

        public bool MoveNext()
        {
            if (++curIndex >= _collection.Count)
            {
                return false;
            }
            else
            {
                curDoc = _collection[curIndex];
            }
            return true;
        }

        public void Reset()
        {
            curIndex = -1;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }
        
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    public class SameDoc : EqualityComparer<cvrfdoc>
    {
        public override bool Equals(cvrfdoc x, cvrfdoc y)
        {
            if (x == null)
            {
                throw new ArgumentNullException(string.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.ArgumentNullException, nameof(x)));
            }

            if (y == null)
            {
                throw new ArgumentNullException(string.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.ArgumentNullException, nameof(y)));
            }

            if (x.Equals(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(cvrfdoc obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(string.Format(System.Globalization.CultureInfo.InvariantCulture, Resources.ArgumentNullException, nameof(obj)));
            }

            return obj.GetHashCode();
        }
    }

    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf", IsNullable = false)]
    public partial class cvrfdoc
    {

        private cvrfdocDocumentTitle documentTitleField;

        private cvrfdocDocumentType documentTypeField;

        private cvrfdocDocumentPublisher documentPublisherField;

        private cvrfdocDocumentTracking documentTrackingField;

        private cvrfdocNote[] documentNotesField;

        private cvrfdocDocumentDistribution documentDistributionField;

        private cvrfdocAggregateSeverity aggregateSeverityField;

        private cvrfdocReference[] documentReferencesField;

        private cvrfdocAcknowledgment[] acknowledgmentsField;

        private ProductTree productTreeField;

        private Vulnerability[] vulnerabilityField;

        /// <remarks/>
        public cvrfdocDocumentTitle DocumentTitle
        {
            get
            {
                return this.documentTitleField;
            }
            set
            {
                this.documentTitleField = value;
            }
        }

        /// <remarks/>
        public cvrfdocDocumentType DocumentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        public cvrfdocDocumentPublisher DocumentPublisher
        {
            get
            {
                return this.documentPublisherField;
            }
            set
            {
                this.documentPublisherField = value;
            }
        }

        /// <remarks/>
        public cvrfdocDocumentTracking DocumentTracking
        {
            get
            {
                return this.documentTrackingField;
            }
            set
            {
                this.documentTrackingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Note", IsNullable = false)]
        public cvrfdocNote[] DocumentNotes
        {
            get
            {
                return this.documentNotesField;
            }
            set
            {
                this.documentNotesField = value;
            }
        }

        /// <remarks/>
        public cvrfdocDocumentDistribution DocumentDistribution
        {
            get
            {
                return this.documentDistributionField;
            }
            set
            {
                this.documentDistributionField = value;
            }
        }

        /// <remarks/>
        public cvrfdocAggregateSeverity AggregateSeverity
        {
            get
            {
                return this.aggregateSeverityField;
            }
            set
            {
                this.aggregateSeverityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable = false)]
        public cvrfdocReference[] DocumentReferences
        {
            get
            {
                return this.documentReferencesField;
            }
            set
            {
                this.documentReferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Acknowledgment", IsNullable = false)]
        public cvrfdocAcknowledgment[] Acknowledgments
        {
            get
            {
                return this.acknowledgmentsField;
            }
            set
            {
                this.acknowledgmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/prod")]
        public ProductTree ProductTree
        {
            get
            {
                return this.productTreeField;
            }
            set
            {
                this.productTreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Vulnerability", Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
        public Vulnerability[] Vulnerability
        {
            get
            {
                return this.vulnerabilityField;
            }
            set
            {
                this.vulnerabilityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentTitle
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentType
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentPublisher
    {

        private cvrfdocDocumentPublisherContactDetails contactDetailsField;

        private cvrfdocDocumentPublisherIssuingAuthority issuingAuthorityField;

        private string typeField;

        private string vendorIDField;

        /// <remarks/>
        public cvrfdocDocumentPublisherContactDetails ContactDetails
        {
            get
            {
                return this.contactDetailsField;
            }
            set
            {
                this.contactDetailsField = value;
            }
        }

        /// <remarks/>
        public cvrfdocDocumentPublisherIssuingAuthority IssuingAuthority
        {
            get
            {
                return this.issuingAuthorityField;
            }
            set
            {
                this.issuingAuthorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorID
        {
            get
            {
                return this.vendorIDField;
            }
            set
            {
                this.vendorIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentPublisherContactDetails
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentPublisherIssuingAuthority
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentTracking
    {

        private cvrfdocDocumentTrackingIdentification identificationField;

        private string statusField;

        private string versionField;

        private cvrfdocDocumentTrackingRevision[] revisionHistoryField;

        private System.DateTime initialReleaseDateField;

        private System.DateTime currentReleaseDateField;

        private cvrfdocDocumentTrackingGenerator generatorField;

        /// <remarks/>
        public cvrfdocDocumentTrackingIdentification Identification
        {
            get
            {
                return this.identificationField;
            }
            set
            {
                this.identificationField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Revision", IsNullable = false)]
        public cvrfdocDocumentTrackingRevision[] RevisionHistory
        {
            get
            {
                return this.revisionHistoryField;
            }
            set
            {
                this.revisionHistoryField = value;
            }
        }

        /// <remarks/>
        public System.DateTime InitialReleaseDate
        {
            get
            {
                return this.initialReleaseDateField;
            }
            set
            {
                this.initialReleaseDateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CurrentReleaseDate
        {
            get
            {
                return this.currentReleaseDateField;
            }
            set
            {
                this.currentReleaseDateField = value;
            }
        }

        /// <remarks/>
        public cvrfdocDocumentTrackingGenerator Generator
        {
            get
            {
                return this.generatorField;
            }
            set
            {
                this.generatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentTrackingIdentification
    {

        private cvrfdocDocumentTrackingIdentificationID idField;

        private cvrfdocDocumentTrackingIdentificationAlias[] aliasField;

        /// <remarks/>
        public cvrfdocDocumentTrackingIdentificationID ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alias")]
        public cvrfdocDocumentTrackingIdentificationAlias[] Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentTrackingIdentificationID
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentTrackingIdentificationAlias
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentTrackingRevision
    {

        private string numberField;

        private System.DateTime dateField;

        private cvrfdocDocumentTrackingRevisionDescription descriptionField;

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public cvrfdocDocumentTrackingRevisionDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentTrackingRevisionDescription
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentTrackingGenerator
    {

        private cvrfdocDocumentTrackingGeneratorEngine engineField;

        private System.DateTime dateField;

        /// <remarks/>
        public cvrfdocDocumentTrackingGeneratorEngine Engine
        {
            get
            {
                return this.engineField;
            }
            set
            {
                this.engineField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentTrackingGeneratorEngine
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocNote
    {

        private string titleField;

        private string audienceField;

        private string typeField;

        private string ordinalField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Audience
        {
            get
            {
                return this.audienceField;
            }
            set
            {
                this.audienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Ordinal
        {
            get
            {
                return this.ordinalField;
            }
            set
            {
                this.ordinalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocDocumentDistribution
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocAggregateSeverity
    {

        private string namespaceField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocReference
    {

        private string uRLField;

        private cvrfdocReferenceDescription descriptionField;

        private string typeField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public cvrfdocReferenceDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocReferenceDescription
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocAcknowledgment
    {

        private cvrfdocAcknowledgmentName[] nameField;

        private cvrfdocAcknowledgmentOrganization[] organizationField;

        private cvrfdocAcknowledgmentDescription descriptionField;

        private string[] uRLField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public cvrfdocAcknowledgmentName[] Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Organization")]
        public cvrfdocAcknowledgmentOrganization[] Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        public cvrfdocAcknowledgmentDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("URL")]
        public string[] URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocAcknowledgmentName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocAcknowledgmentOrganization
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/cvrf")]
    public partial class cvrfdocAcknowledgmentDescription
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/prod")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/prod", IsNullable = false)]
    public partial class ProductTree
    {

        private ProductTreeBranch[] branchField;

        private ProductTreeRelationship[] relationshipField;

        private ProductTreeGroup[] productGroupsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Branch")]
        public ProductTreeBranch[] Branch
        {
            get
            {
                return this.branchField;
            }
            set
            {
                this.branchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Relationship")]
        public ProductTreeRelationship[] Relationship
        {
            get
            {
                return this.relationshipField;
            }
            set
            {
                this.relationshipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Group", IsNullable = false)]
        public ProductTreeGroup[] ProductGroups
        {
            get
            {
                return this.productGroupsField;
            }
            set
            {
                this.productGroupsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/prod")]
    public partial class ProductTreeBranch
    {

        private ProductTreeBranchFullProductName fullProductNameField;

        private string typeField;

        private string nameField;

        /// <remarks/>
        public ProductTreeBranchFullProductName FullProductName
        {
            get
            {
                return this.fullProductNameField;
            }
            set
            {
                this.fullProductNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/prod")]
    public partial class ProductTreeBranchFullProductName
    {

        private string productIDField;

        private string cPEField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CPE
        {
            get
            {
                return this.cPEField;
            }
            set
            {
                this.cPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/prod")]
    public partial class ProductTreeRelationship
    {

        private ProductTreeRelationshipFullProductName[] fullProductNameField;

        private string productReferenceField;

        private string relationTypeField;

        private string relatesToProductReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FullProductName")]
        public ProductTreeRelationshipFullProductName[] FullProductName
        {
            get
            {
                return this.fullProductNameField;
            }
            set
            {
                this.fullProductNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductReference
        {
            get
            {
                return this.productReferenceField;
            }
            set
            {
                this.productReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RelationType
        {
            get
            {
                return this.relationTypeField;
            }
            set
            {
                this.relationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RelatesToProductReference
        {
            get
            {
                return this.relatesToProductReferenceField;
            }
            set
            {
                this.relatesToProductReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/prod")]
    public partial class ProductTreeRelationshipFullProductName
    {

        private string productIDField;

        private string cPEField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CPE
        {
            get
            {
                return this.cPEField;
            }
            set
            {
                this.cPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/prod")]
    public partial class ProductTreeGroup
    {

        private ProductTreeGroupDescription descriptionField;

        private string[] productIDField;

        private string groupIDField;

        /// <remarks/>
        public ProductTreeGroupDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductID")]
        public string[] ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/prod")]
    public partial class ProductTreeGroupDescription
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln", IsNullable = false)]
    public partial class Vulnerability
    {

        private VulnerabilityTitle titleField;

        private VulnerabilityID idField;

        private VulnerabilityNote[] notesField;

        private System.DateTime discoveryDateField;

        private System.DateTime releaseDateField;

        private VulnerabilityInvolvement[] involvementsField;

        private string cVEField;

        private VulnerabilityCWE[] cWEField;

        private VulnerabilityStatus[] productStatusesField;

        private VulnerabilityThreat[] threatsField;

        private VulnerabilityCVSSScoreSets cVSSScoreSetsField;

        private VulnerabilityRemediation[] remediationsField;

        private VulnerabilityReference[] referencesField;

        private VulnerabilityAcknowledgment[] acknowledgmentsField;

        private string ordinalField;

        /// <remarks/>
        public VulnerabilityTitle Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public VulnerabilityID ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Note", IsNullable = false)]
        public VulnerabilityNote[] Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DiscoveryDate
        {
            get
            {
                return this.discoveryDateField;
            }
            set
            {
                this.discoveryDateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ReleaseDate
        {
            get
            {
                return this.releaseDateField;
            }
            set
            {
                this.releaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Involvement", IsNullable = false)]
        public VulnerabilityInvolvement[] Involvements
        {
            get
            {
                return this.involvementsField;
            }
            set
            {
                this.involvementsField = value;
            }
        }

        /// <remarks/>
        public string CVE
        {
            get
            {
                return this.cVEField;
            }
            set
            {
                this.cVEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CWE")]
        public VulnerabilityCWE[] CWE
        {
            get
            {
                return this.cWEField;
            }
            set
            {
                this.cWEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Status", IsNullable = false)]
        public VulnerabilityStatus[] ProductStatuses
        {
            get
            {
                return this.productStatusesField;
            }
            set
            {
                this.productStatusesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Threat", IsNullable = false)]
        public VulnerabilityThreat[] Threats
        {
            get
            {
                return this.threatsField;
            }
            set
            {
                this.threatsField = value;
            }
        }

        /// <remarks/>
        public VulnerabilityCVSSScoreSets CVSSScoreSets
        {
            get
            {
                return this.cVSSScoreSetsField;
            }
            set
            {
                this.cVSSScoreSetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Remediation", IsNullable = false)]
        public VulnerabilityRemediation[] Remediations
        {
            get
            {
                return this.remediationsField;
            }
            set
            {
                this.remediationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable = false)]
        public VulnerabilityReference[] References
        {
            get
            {
                return this.referencesField;
            }
            set
            {
                this.referencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Acknowledgment", IsNullable = false)]
        public VulnerabilityAcknowledgment[] Acknowledgments
        {
            get
            {
                return this.acknowledgmentsField;
            }
            set
            {
                this.acknowledgmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Ordinal
        {
            get
            {
                return this.ordinalField;
            }
            set
            {
                this.ordinalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityTitle
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityID
    {

        private string systemNameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SystemName
        {
            get
            {
                return this.systemNameField;
            }
            set
            {
                this.systemNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityNote
    {

        private string titleField;

        private string audienceField;

        private string typeField;

        private string ordinalField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Audience
        {
            get
            {
                return this.audienceField;
            }
            set
            {
                this.audienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Ordinal
        {
            get
            {
                return this.ordinalField;
            }
            set
            {
                this.ordinalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityInvolvement
    {

        private VulnerabilityInvolvementDescription descriptionField;

        private string partyField;

        private string statusField;

        /// <remarks/>
        public VulnerabilityInvolvementDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityInvolvementDescription
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityCWE
    {

        private string idField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityStatus
    {

        private string[] productIDField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductID")]
        public string[] ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityThreat
    {

        private VulnerabilityThreatDescription descriptionField;

        private string[] productIDField;

        private string[] groupIDField;

        private string typeField;

        private System.DateTime dateField;

        /// <remarks/>
        public VulnerabilityThreatDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductID")]
        public string[] ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GroupID")]
        public string[] GroupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityThreatDescription
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityCVSSScoreSets
    {

        private VulnerabilityCVSSScoreSetsScoreSetV2[] scoreSetV2Field;

        private VulnerabilityCVSSScoreSetsScoreSetV3[] scoreSetV3Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScoreSetV2")]
        public VulnerabilityCVSSScoreSetsScoreSetV2[] ScoreSetV2
        {
            get
            {
                return this.scoreSetV2Field;
            }
            set
            {
                this.scoreSetV2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScoreSetV3")]
        public VulnerabilityCVSSScoreSetsScoreSetV3[] ScoreSetV3
        {
            get
            {
                return this.scoreSetV3Field;
            }
            set
            {
                this.scoreSetV3Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityCVSSScoreSetsScoreSetV2
    {

        private decimal baseScoreV2Field;

        private decimal temporalScoreV2Field;

        private decimal environmentalScoreV2Field;

        private string vectorV2Field;

        private string[] productIDField;

        /// <remarks/>
        public decimal BaseScoreV2
        {
            get
            {
                return this.baseScoreV2Field;
            }
            set
            {
                this.baseScoreV2Field = value;
            }
        }

        /// <remarks/>
        public decimal TemporalScoreV2
        {
            get
            {
                return this.temporalScoreV2Field;
            }
            set
            {
                this.temporalScoreV2Field = value;
            }
        }

        /// <remarks/>
        public decimal EnvironmentalScoreV2
        {
            get
            {
                return this.environmentalScoreV2Field;
            }
            set
            {
                this.environmentalScoreV2Field = value;
            }
        }

        /// <remarks/>
        public string VectorV2
        {
            get
            {
                return this.vectorV2Field;
            }
            set
            {
                this.vectorV2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductID")]
        public string[] ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityCVSSScoreSetsScoreSetV3
    {

        private decimal baseScoreV3Field;

        private decimal temporalScoreV3Field;

        private decimal environmentalScoreV3Field;

        private string vectorV3Field;

        private string[] productIDField;

        /// <remarks/>
        public decimal BaseScoreV3
        {
            get
            {
                return this.baseScoreV3Field;
            }
            set
            {
                this.baseScoreV3Field = value;
            }
        }

        /// <remarks/>
        public decimal TemporalScoreV3
        {
            get
            {
                return this.temporalScoreV3Field;
            }
            set
            {
                this.temporalScoreV3Field = value;
            }
        }

        /// <remarks/>
        public decimal EnvironmentalScoreV3
        {
            get
            {
                return this.environmentalScoreV3Field;
            }
            set
            {
                this.environmentalScoreV3Field = value;
            }
        }

        /// <remarks/>
        public string VectorV3
        {
            get
            {
                return this.vectorV3Field;
            }
            set
            {
                this.vectorV3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductID")]
        public string[] ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityRemediation
    {

        private VulnerabilityRemediationDescription descriptionField;

        private VulnerabilityRemediationEntitlement[] entitlementField;

        private string uRLField;

        private string[] productIDField;

        private string[] groupIDField;

        private string typeField;

        private System.DateTime dateField;

        /// <remarks/>
        public VulnerabilityRemediationDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Entitlement")]
        public VulnerabilityRemediationEntitlement[] Entitlement
        {
            get
            {
                return this.entitlementField;
            }
            set
            {
                this.entitlementField = value;
            }
        }

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductID")]
        public string[] ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GroupID")]
        public string[] GroupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityRemediationDescription
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityRemediationEntitlement
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityReference
    {

        private string uRLField;

        private VulnerabilityReferenceDescription descriptionField;

        private string typeField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public VulnerabilityReferenceDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityReferenceDescription
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityAcknowledgment
    {

        private VulnerabilityAcknowledgmentName[] nameField;

        private VulnerabilityAcknowledgmentOrganization[] organizationField;

        private VulnerabilityAcknowledgmentDescription descriptionField;

        private string[] uRLField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public VulnerabilityAcknowledgmentName[] Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Organization")]
        public VulnerabilityAcknowledgmentOrganization[] Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        public VulnerabilityAcknowledgmentDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("URL")]
        public string[] URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityAcknowledgmentName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityAcknowledgmentOrganization
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/csaf/ns/csaf-cvrf/v1.2/vuln")]
    public partial class VulnerabilityAcknowledgmentDescription
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

}
