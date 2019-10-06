**Private Fonts**

In the vast majority of cases no additional programming effort is required to utilise a TrueType/OpenType font.  However, there may be instances where a font is not or cannot be installed in the Windows Fonts directory.  FO.NET is still capable of using this font as a private font.

Private fonts are added via the PdfRendererOptions class as shown below.

{code:c#}
void Example()
{
    // Add private font not installed in Fonts directoryPdfRendererOptions options = new PdfRendererOptions();
    options.AddPrivateFont(new FileInfo(@"\\server\fonts\specialfont.otf"));

    // The driver defaults to a PDF renderer
    FonetDriver driver = FonetDriver.Make();
    driver.Options = options;
    driver.Render("hello.xml", "hello.pdf");
}
{code:c#}