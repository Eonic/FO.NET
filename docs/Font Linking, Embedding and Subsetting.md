**Font Linking, Embedding and Subsetting**

FO.NET supports three different types of font embedding: Link, Embed and Subset. This section will describe each embedding policy, the advantages and disadvantages of each and finish with a comparison matrix which will help you decide which policy best suits your requirements.

**Linking:**

The font program is referenced by name in the rendered PDF.  Anyone who views a rendered PDF with a linked font program must have that font installed on their computer otherwise it will not display correctly. 

**Embedding:**

The entire font program is embedded in the rendered PDF.  Embedding the entire font program guarantees the PDF will display as intended by the author on all computers, however this method does possess several disadvantages:

Font programs can be extremely large and will significantly increase the size of the rendered PDF.  For example, the MS Gothic TrueType collection is 8MB!
 
Certain font programs cannot be embedded due to license restrictions.  If you attempt to embed a font program that disallows embedding, FO.NET will substitute the font with a base 14 font and generate a warning message.

**Subseting:**

Subsetting a font will generate a new font that is embedded in the rendered PDF that contains only the glyphs referenced by the FO document.  For example, if a particular FO document utilised the Verdana font referencing only the character 'A', a subsetted font would be generated at run-time containing only the information necessary to render the character 'A'.  

Subsetting provides the benefits of embedding and significantly reduces the size of the font program.  However, small processing overhead is incurred to generated the subsetted font.

{code:c#}
void Example()
{
    FonetDriver driver = FonetDriver.Make();
    driver.Renderer = RendererEngine.PDF;

    // Font embedding/linking is set via PdfRendererOptions class
    PdfRendererOptions options = new PdfRendererOptions();

    // Use FontType enumeration to specify either Link, Embed or Subset
    options.FontType = FontType.Link;
    //options.FontType = FontType.Embed;
    //options.FontType = FontType.Subset;

    driver.Options = options;
}
{code:c#}

**What Font Embedding Policy Should I Use?**

This section will provides a comparison matrix to help you decide which embedding policy best suits your requirements:
 
|| || Link || Embed || Subset ||
|| Size || Smallest - font is not embedded || Potentially very large since entire font is embedded in PDF || Significantly more efficient than embedding.  Size increases with each character referenced in FO document. ||
|| Performance || Best || Minor overhead incurred to read and embed font data || Minor overhead incurred to read, subset and embed font data ||
|| Any Unicode character || Restricted to code page 1252 || Any character || Any character ||
|| PDF Integrity || Not guaranteed since PDF utilises fonts on host machine || Guaranteed || Guaranteed ||
|| Synthesising || Yes || No || No ||