**Font Linking**

Any font that is linked in the rendered PDF is restricted to Windows code page 1252, often called the "Windows ANSI" encoding.  Please visit the following link to view a listing of Windows Code Page 1252. 

When an attempt is made to use a variant of a font that does not exist in the Windows Font directory, FO.NET will instruct Adobe Acrobat to synthesise the font.  For example, if an FO document uses "SuperFont Bold" but only a regular variant is available, Acrobat will attempt to synthesise a bold font when it renders the PDF.  Synthesising relies on the operating system making concerted "guesses" regarding the layout of each glyph and, therefore, will not always produce acceptable results.  Wherever possible, use only fonts that are fully installed.

**Font Embedding**

FO.NET does not support font synthesising when embedding fonts. 

**Font Subsetting**

FO.NET does not support font synthesising when subsetting fonts.

Editing a PDF with a subsetted font may not be possible since it contains only a selection of the overall number of glyphs. Merging two PDFs that contain a different subset of the same font can lead to missing characters. 