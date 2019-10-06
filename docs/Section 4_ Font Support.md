**Font Support**

FO.NET includes arbitrary font support allowing XSL-FO developers to utilise any font present in the Windows Font directory.  Individual fonts may be referenced in FO documents via their family name without the necessity for additional configuration and metrics generation.

FO.NET also allows you to control how the font should be handled in the generated PDF file.  For more information please see the section [Font Linking, Embedding and Subsetting](Font-Linking,-Embedding-and-Subsetting).
 
Additional information regarding fonts can be found in the sections [Private Fonts](Private-Fonts), [Font Kerning](Font-Kerning) and [Font Limitations](Font-Limitations).

**XSL-FO Font Example:**

{code:xml}
<?xml version="1.0" encoding="utf-8"?>
<fo:root xmlns:fo="http://www.w3.org/1999/XSL/Format">

  <!-- layout-master-set removed intentionally for readability -->

  <fo:page-sequence master-reference="simple">
    <fo:flow flow-name="xsl-region-body">

      <!-- Regular -->
      <fo:block font-size="18pt" font-family="Verdana">
        This is Verdana Regular
      </fo:block>

      <!-- Bold -->
      <fo:block font-size="18pt" font-family="Verdana" font-weight="bold">
        This is Verdana Bold
      </fo:block>

      <!-- Italic -->
      <fo:block font-size="18pt" font-family="Verdana" font-style="italic">
        This is Verdana Italic.
      </fo:block>

    </fo:flow>
  </fo:page-sequence>

</fo:root>
{code:xml}