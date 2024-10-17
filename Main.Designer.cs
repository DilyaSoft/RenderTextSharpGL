using SharpGL;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace RenderTextSharpGL
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            openglControl1 = new OpenGLControl();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)openglControl1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(581, 9);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 0;
            button1.Text = "Render 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(566, 23);
            textBox1.TabIndex = 1;
            // 
            // openglControl1
            // 
            openglControl1.DrawFPS = false;
            openglControl1.Location = new Point(9, 90);
            openglControl1.Margin = new Padding(4, 3, 4, 3);
            openglControl1.Name = "openglControl1";
            openglControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            openglControl1.RenderContextType = RenderContextType.DIBSection;
            openglControl1.RenderTrigger = RenderTrigger.TimerBased;
            openglControl1.Size = new Size(798, 323);
            openglControl1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "12";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 38);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(104, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "0.5";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(350, 38);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(104, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "0.1";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(501, 38);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(104, 23);
            textBox5.TabIndex = 6;
            textBox5.Text = "0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 7;
            label1.Text = "Size";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 41);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 8;
            label2.Text = "R";
            label2.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 41);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 9;
            label3.Text = "G";
            label3.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 41);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 10;
            label4.Text = "B";
            label4.UseMnemonic = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 423);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(openglControl1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)openglControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private SharpGL.OpenGLControl openglControl1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
