
# CSAF
The official OASIS Common Security Advisory Framework GitHub 
https://github.com/oasis-tcs/csaf

## Generate C# classes from json-schemas
  1. Generate a valid JSON file from the JSON-Schema using for example https://www.liquid-technologies.com/online-schema-to-json-converter
  2. Save the converted content to a file
  3. Copy the content to the clipboard
  4. Add a new Class.cs to your C#-Project
  5. Remove 
  

    class Class1
    {
    }
from the Namespace
  7. Select EDIT -> Paste Special -> Paste JSON As Classes
  8. Add .CVRF20 to the end of your Namespace

