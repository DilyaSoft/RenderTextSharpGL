using SharpGL;
using SharpGL.SceneGraph.Assets;
using System.Configuration;
using System.Globalization;

namespace RenderTextSharpGL
{
    unsafe public partial class Main : Form
    {
        private RectangleF textBounds; // Store the text bounds for click detection
        private FontLoader fontLoader;

        public Main()
        {
            string path = ConfigurationManager.AppSettings["ttfPath"];

            InitializeComponent();
            openglControl1.MouseClick += OpenGLControl1_MouseClick;
            fontLoader = new FontLoader(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RenderTextUsingBitmap(textBox1.Text, int.Parse(textBox2.Text), 
                float.Parse(textBox3.Text, CultureInfo.InvariantCulture), 
                float.Parse(textBox4.Text, CultureInfo.InvariantCulture), 
                float.Parse(textBox5.Text, CultureInfo.InvariantCulture));
        }

        private void OpenGLControl1_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the mouse click is within the text bounds
            if (textBounds.Contains(e.Location))
            {
                MessageBox.Show("Alert");
            }
        }

        private void RenderTextUsingBitmap(string textToRender, int size, float r, float g, float b)
        {
            // Create a high-resolution bitmap
            int scaleFactor = 4;  // Increase the scale factor to increase sharpness
            int bitmapWidth = openglControl1.Width * scaleFactor;
            int bitmapHeight = openglControl1.Height * scaleFactor;

            // Create a bitmap with GDI+
            using (Bitmap bitmap = new Bitmap(bitmapWidth, bitmapHeight))
            {
                using (Graphics gr = Graphics.FromImage(bitmap))
                {
                    gr.Clear(Color.Black);

                    // Enable anti-aliasing
                    gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                    // Set text rendering options
                    using Font font = fontLoader.GetFont(size * scaleFactor);
                    using Brush brush = new SolidBrush(Color.White);

                    // Measure the text size
                    SizeF textSize = gr.MeasureString(textToRender, font);

                    // Create the rectangle based on the size and desired position
                    textBounds = new RectangleF(new PointF(10 * scaleFactor, 10 * scaleFactor), textSize);

                    // Draw the text on the bitmap
                    gr.DrawString(textToRender, font, brush, textBounds.Location);
                }

                // Scale down the text bounds to match the original scale
                textBounds = new RectangleF(textBounds.X / scaleFactor, textBounds.Y / scaleFactor,
                                            textBounds.Width / scaleFactor, textBounds.Height / scaleFactor);

                // Upload the bitmap as a texture to OpenGL
                OpenGL gl = openglControl1.OpenGL;

                // Clear the screen and depth buffer
                gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

                // Enable 2D textures
                gl.Enable(OpenGL.GL_TEXTURE_2D);

                // Generate a texture ID and bind it
                var texture = new Texture();
                texture.Create(gl, bitmap);
                texture.Bind(gl);

                // Set up projection and modelview matrices
                gl.MatrixMode(OpenGL.GL_PROJECTION);
                gl.LoadIdentity();
                gl.Ortho2D(0, openglControl1.Width, 0, openglControl1.Height);

                gl.MatrixMode(OpenGL.GL_MODELVIEW);
                gl.LoadIdentity();

                // Make sure blending is enabled for transparency
                gl.Enable(OpenGL.GL_BLEND);
                gl.BlendFunc(OpenGL.GL_SRC_ALPHA, OpenGL.GL_ONE_MINUS_SRC_ALPHA);

                // Draw the textured quad
                gl.Color(r, g, b, 1.0f);  // Set the color to white to ensure proper texture rendering
                gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(0, 0);                                        // Bottom-left
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(openglControl1.Width, 0);                     // Bottom-right
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(openglControl1.Width, openglControl1.Height); // Top-right
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(0, openglControl1.Height);                    // Top-left
                gl.End();

                // Disable 2D textures
                gl.Disable(OpenGL.GL_TEXTURE_2D);

                // Flush and refresh the OpenGL control
                gl.Flush();
                openglControl1.Refresh();
            }
        }
    }
}
