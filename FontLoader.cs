using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenderTextSharpGL
{
    public class FontLoader
    {
        private readonly PrivateFontCollection fontCollection;

        public FontLoader(string fontPath)
        {
            fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile(fontPath);
        }

        public Font GetFont(float size, FontStyle style = FontStyle.Regular)
        {
            return new Font(fontCollection.Families[0], size, style);
        }
    }
}
