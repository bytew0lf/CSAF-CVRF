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
        public string csaf_version { get; set; }
        public string title { get; set; }
        public Publisher publisher { get; set; }
        public string type { get; set; }
        public Tracking tracking { get; set; }
        public Acknowledgment[] acknowledgments { get; set; }
        public Aggregate_Severity aggregate_severity { get; set; }
        public Distribution distribution { get; set; }
        public string lang { get; set; }
        public string source_lang { get; set; }
        public Note[] notes { get; set; }
        public Reference[] references { get; set; }
    }

    public class Publisher
    {
        public string type { get; set; }
        public string contact_details { get; set; }
        public string issuing_authority { get; set; }
        public string vendor_id { get; set; }
    }

    public class Tracking
    {
        public string current_release_date { get; set; }
        public string id { get; set; }
        public string initial_release_date { get; set; }
        public Revision_History[] revision_history { get; set; }
        public string status { get; set; }
        public string version { get; set; }
        public string[] aliases { get; set; }
        public Generator generator { get; set; }
    }

    public class Generator
    {
        public string engine { get; set; }
        public string date { get; set; }
    }

    public class Revision_History
    {
        public string number { get; set; }
        public string date { get; set; }
        public string description { get; set; }
    }

    public class Aggregate_Severity
    {
        public string text { get; set; }
        public string _namespace { get; set; }
    }

    public class Distribution
    {
        public string text { get; set; }
        public Tlp tlp { get; set; }
    }

    public class Tlp
    {
        public string label { get; set; }
        public string url { get; set; }
    }

    public class Acknowledgment
    {
        public object names { get; set; }
        public float organizations { get; set; }
        public string description { get; set; }
        public string[] urls { get; set; }
    }

    public class Note
    {
        public string type { get; set; }
        public string text { get; set; }
        public string audience { get; set; }
        public string title { get; set; }
    }

    public class Reference
    {
        public string url { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Product_Tree
    {
        public Branch[] branches { get; set; }
        public Full_Product_Names[] full_product_names { get; set; }
        public Product_Groups[] product_groups { get; set; }
        public Relationship[] relationships { get; set; }
    }

    public class Branch
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch1[] branches { get; set; }
        public Product product { get; set; }
    }

    public class Product
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch1
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch2[] branches { get; set; }
        public Product1 product { get; set; }
    }

    public class Product1
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch2
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch3[] branches { get; set; }
        public Product2 product { get; set; }
    }

    public class Product2
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch3
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch4[] branches { get; set; }
        public Product3 product { get; set; }
    }

    public class Product3
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch4
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch5[] branches { get; set; }
        public Product4 product { get; set; }
    }

    public class Product4
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch5
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch6[] branches { get; set; }
        public Product5 product { get; set; }
    }

    public class Product5
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch6
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch7[] branches { get; set; }
        public Product6 product { get; set; }
    }

    public class Product6
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch7
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch8[] branches { get; set; }
        public Product7 product { get; set; }
    }

    public class Product7
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch8
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch9[] branches { get; set; }
        public Product8 product { get; set; }
    }

    public class Product8
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch9
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch10[] branches { get; set; }
        public Product9 product { get; set; }
    }

    public class Product9
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch10
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch11[] branches { get; set; }
        public Product10 product { get; set; }
    }

    public class Product10
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch11
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch12[] branches { get; set; }
        public Product11 product { get; set; }
    }

    public class Product11
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch12
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch13[] branches { get; set; }
        public Product12 product { get; set; }
    }

    public class Product12
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch13
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch14[] branches { get; set; }
        public Product13 product { get; set; }
    }

    public class Product13
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch14
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch15[] branches { get; set; }
        public Product14 product { get; set; }
    }

    public class Product14
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch15
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch16[] branches { get; set; }
        public Product15 product { get; set; }
    }

    public class Product15
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch16
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch17[] branches { get; set; }
        public Product16 product { get; set; }
    }

    public class Product16
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch17
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch18[] branches { get; set; }
        public Product17 product { get; set; }
    }

    public class Product17
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch18
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch19[] branches { get; set; }
        public Product18 product { get; set; }
    }

    public class Product18
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch19
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch20[] branches { get; set; }
        public Product19 product { get; set; }
    }

    public class Product19
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch20
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch21[] branches { get; set; }
        public Product20 product { get; set; }
    }

    public class Product20
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch21
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch22[] branches { get; set; }
        public Product21 product { get; set; }
    }

    public class Product21
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch22
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch23[] branches { get; set; }
        public Product22 product { get; set; }
    }

    public class Product22
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch23
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch24[] branches { get; set; }
        public Product23 product { get; set; }
    }

    public class Product23
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch24
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch25[] branches { get; set; }
        public Product24 product { get; set; }
    }

    public class Product24
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch25
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch26[] branches { get; set; }
        public Product25 product { get; set; }
    }

    public class Product25
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch26
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch27[] branches { get; set; }
        public Product26 product { get; set; }
    }

    public class Product26
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch27
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch28[] branches { get; set; }
        public Product27 product { get; set; }
    }

    public class Product27
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch28
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch29[] branches { get; set; }
        public Product28 product { get; set; }
    }

    public class Product28
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch29
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch30[] branches { get; set; }
        public Product29 product { get; set; }
    }

    public class Product29
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch30
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch31[] branches { get; set; }
        public Product30 product { get; set; }
    }

    public class Product30
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch31
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch32[] branches { get; set; }
        public Product31 product { get; set; }
    }

    public class Product31
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch32
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch33[] branches { get; set; }
        public Product32 product { get; set; }
    }

    public class Product32
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch33
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch34[] branches { get; set; }
        public Product33 product { get; set; }
    }

    public class Product33
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch34
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch35[] branches { get; set; }
        public Product34 product { get; set; }
    }

    public class Product34
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch35
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch36[] branches { get; set; }
        public Product35 product { get; set; }
    }

    public class Product35
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch36
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch37[] branches { get; set; }
        public Product36 product { get; set; }
    }

    public class Product36
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch37
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch38[] branches { get; set; }
        public Product37 product { get; set; }
    }

    public class Product37
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch38
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch39[] branches { get; set; }
        public Product38 product { get; set; }
    }

    public class Product38
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch39
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch40[] branches { get; set; }
        public Product39 product { get; set; }
    }

    public class Product39
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch40
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch41[] branches { get; set; }
        public Product40 product { get; set; }
    }

    public class Product40
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch41
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch42[] branches { get; set; }
        public Product41 product { get; set; }
    }

    public class Product41
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch42
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch43[] branches { get; set; }
        public Product42 product { get; set; }
    }

    public class Product42
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch43
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch44[] branches { get; set; }
        public Product43 product { get; set; }
    }

    public class Product43
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch44
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch45[] branches { get; set; }
        public Product44 product { get; set; }
    }

    public class Product44
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch45
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch46[] branches { get; set; }
        public Product45 product { get; set; }
    }

    public class Product45
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch46
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch47[] branches { get; set; }
        public Product46 product { get; set; }
    }

    public class Product46
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch47
    {
        public string name { get; set; }
        public string type { get; set; }
        public Branch48[] branches { get; set; }
        public Product47 product { get; set; }
    }

    public class Product47
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Branch48
    {
        public string name { get; set; }
        public string type { get; set; }
        public string[] branches { get; set; }
        public Product48 product { get; set; }
    }

    public class Product48
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Full_Product_Names
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Product_Groups
    {
        public string group_id { get; set; }
        public string[] product_ids { get; set; }
        public string description { get; set; }
    }

    public class Relationship
    {
        public string product_reference { get; set; }
        public string relates_to_product_reference { get; set; }
        public string relationship_type { get; set; }
        public Full_Product_Names1[] full_product_names { get; set; }
    }

    public class Full_Product_Names1
    {
        public string product_id { get; set; }
        public string name { get; set; }
        public string cpe { get; set; }
    }

    public class Vulnerability
    {
        public Acknowledgment1[] acknowledgments { get; set; }
        public string cve { get; set; }
        public Cwe cwe { get; set; }
        public Score[] scores { get; set; }
        public string discovery_date { get; set; }
        public Id id { get; set; }
        public Involvement[] involvements { get; set; }
        public Note1[] notes { get; set; }
        public Product_Status product_status { get; set; }
        public Reference1[] references { get; set; }
        public string release_date { get; set; }
        public Remediation[] remediations { get; set; }
        public Threat[] threats { get; set; }
        public string title { get; set; }
    }

    public class Cwe
    {
        public string id { get; set; }
        public string description { get; set; }
    }

    public class Id
    {
        public string system_name { get; set; }
        public string text { get; set; }
    }

    public class Product_Status
    {
        public string[] _fixed { get; set; }
        public string[] first_fixed { get; set; }
        public string[] recommended { get; set; }
        public string[] known_affected { get; set; }
        public string[] first_affected { get; set; }
        public string[] last_affected { get; set; }
        public string[] known_not_affected { get; set; }
        public string[] under_investigation { get; set; }
    }

    public class Acknowledgment1
    {
        public int names { get; set; }
        public object organizations { get; set; }
        public string description { get; set; }
        public string[] urls { get; set; }
    }

    public class Score
    {
    }

    public class Involvement
    {
        public string party { get; set; }
        public string status { get; set; }
        public string description { get; set; }
    }

    public class Note1
    {
        public string type { get; set; }
        public string text { get; set; }
        public string audience { get; set; }
        public string title { get; set; }
    }

    public class Reference1
    {
        public string url { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Remediation
    {
        public string description { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public string[] entitlements { get; set; }
        public string[] group_ids { get; set; }
        public string[] product_ids { get; set; }
        public Restart_Required restart_required { get; set; }
        public string url { get; set; }
    }

    public class Restart_Required
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Threat
    {
        public string description { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public string[] product_ids { get; set; }
        public string[] group_ids { get; set; }
    }

}
