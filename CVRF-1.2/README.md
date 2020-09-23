
# CSAF
The official OASIS Common Security Advisory Framework GitHub 
https://github.com/oasis-tcs/csaf

## Generate C# classes from xml-schemas
  1. Open Developer Prompt to have the XSD utility
  2. Navigate to <PATH>\CSAF-CVRF\CVRF-1.2\schemas\
  3. Execute: xsd /c cvrf.xsd common.xsd cpe-language_2.2a.xsd cvss-v2_0.9.xsd cvss-v3.0.xsd dc.xsd prod.xsd scap-core_0.9.xsd vuln.xsd xml.xsd
  4. Copy the written *.cs file to your C#-Project
  5. Add the *.cs file to you C#-Project

