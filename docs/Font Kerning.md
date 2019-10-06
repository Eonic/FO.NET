**Font Kerning**

Kerning permits FO.NET to adjust the inter-character spacing between pairs of characters depending on context to make them more visually appealing.  Note that by default kerning is disabled since it adds a minor processing overhead.

**Enabling Kerning via Command Line**

To enable kerning via the command line tool, specify the "-kerning" switch.  For example:

fonet -kerning -fo document.fo -pdf document.pdf 

**Enabling Kerning in Code**

The following code snippet illustrates enabling kerning support using the PdfRendererOptions class.

{code:c#}
void Example()
{
    FonetDriver driver = FonetDriver.Make();
    driver.Renderer = RendererEngine.PDF;

    // Enable kerning by setting the Kerning property to true
    PdfRendererOptions options = new PdfRendererOptions();
    options.Kerning = true;

    driver.Options = options;
}
{code:c#}
