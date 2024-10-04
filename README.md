# RenderTextSharpGL

This project demonstrates rendering text onto an OpenGL control using a high-resolution bitmap in C#. It uses SharpGL for OpenGL integration and GDI+ for text rendering.

## Features

- **Text Rendering**: Renders sharp, high-resolution text using GDI+.
- **OpenGL Texture**: The rendered text is converted into an OpenGL texture for display.
- **Mouse Click Detection**: Detects mouse clicks within the bounds of the rendered text and triggers an alert.

## Project Structure

- **Main.cs**: Contains the core logic for rendering text onto an OpenGL control. The `RenderTextUsingBitmap` method handles the bitmap creation, text rendering, and texture binding in OpenGL.
  
- **Event Handling**:  
  - `OpenGLControl1_MouseClick`: Detects clicks on the OpenGL control and checks if the click falls within the text bounds.
  - `button1_Click`: Triggers the text rendering when the user inputs text and presses the button.

## Getting Started

### Prerequisites

- **SharpGL**: This project uses the SharpGL library for OpenGL integration in a WinForms application. Ensure that you have installed SharpGL via NuGet or added the necessary references.

### How to Use

1. Enter the text you wish to render in the provided textbox.
2. Click the button to render the text onto the OpenGL control.
3. Click on the rendered text to trigger an alert message.

### Code Highlights

- **Text Rendering**: The `RenderTextUsingBitmap` method creates a bitmap using GDI+ with anti-aliasing for smooth text rendering. It then uploads the bitmap as an OpenGL texture.
  
- **Click Detection**: The text bounds are stored in a `RectangleF`, and the mouse click event checks whether the click falls inside this rectangle to trigger an action.

### Example

When you input the text "Hello World" and click the render button, the text will appear on the OpenGL control. If you click within the text, an alert message will pop up.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- [SharpGL](https://sharpgl.codeplex.com/) - OpenGL for .NET
- GDI+ for text rendering
