using System;
using SharpGL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1612494_BT1
{
    public partial class Form1 : Form
    {
        Color colorUserColor;
        short shShape; // 0 Nếu muốn vẽ đường thẳng, 1 nếu muốn vẽ đường tròn
        private Point pStart;
        private Point pEnd;
        private int click = 0;

        

        public Form1()
        {
            InitializeComponent();
            colorUserColor = Color.White; // Gán giá trị màu ban đầu
            shShape = 0; // Gán giá trị ban đầu
        }

        private void bt_BangMau_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorUserColor = colorDialog1.Color;
            }
        }

        private void openGLControl_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ctrl_OpenGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            click = 0;
            pEnd = e.Location;
        }

        private void ctrl_OpenGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            click = 1;
            pStart = e.Location;
            pEnd = pStart;

        }

        private void bt_Line_Click(object sender, EventArgs e)
        {
            shShape = 0;
        }

        private void bt_Circle_Click(object sender, EventArgs e)
        {
            shShape = 1;
        }

        private void bt_Rectangle_Click(object sender, EventArgs e)
        {
            shShape = 2;
        }

        private void bt_Eclipse_click(object sender, EventArgs e)
        {
            shShape = 3;
        }

        private void bt_EquilateralTriangle_Click(object sender, EventArgs e)
        {
            shShape = 4;
        }

        private void bt_equilateralPentagonal_Click(object sender, EventArgs e)
        {
            shShape = 5;
        }

        private void bt_equilateralHexagonal_Click(object sender, EventArgs e)
        {
            shShape = 6;
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Load the identity.
            gl.LoadIdentity();
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Load the identity.
            gl.LoadIdentity();
            // Create a perspective transformation.
            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
            gl.Ortho2D(0, openGLControl.Width, 0, openGLControl.Height);
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.Color(colorUserColor.R / 255.0, colorUserColor.G / 255.0, colorUserColor.B / 255.0, 0);

            if (shShape == 0)
            {
                gl.Begin(OpenGL.GL_LINES); // chọn chế độ vẽ

                gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pStart.Y);
                gl.Vertex(pEnd.X, gl.RenderContextProvider.Height - pEnd.Y);

                gl.End();
                gl.Flush();
            }
            else if(shShape == 1)
            {
                gl.Begin(OpenGL.GL_LINE_LOOP);
                double radius = Math.Sqrt(Math.Pow(pStart.X - pEnd.X, 2.0)
                    + Math.Pow(pStart.Y - pEnd.Y, 2.0));
                for (int i = 0; i <= 360; i++)
                {
                    double degInRad = i / 180.0 * Math.PI;
                    gl.Vertex(Math.Cos(degInRad) * radius + pStart.X, 
                        gl.RenderContextProvider.Height - (Math.Sin(degInRad) * radius + pStart.Y));
                }
                gl.End();
                gl.Flush();
            }
            else if(shShape == 2)
            {
                gl.Begin(OpenGL.GL_LINES);
                float delta_x = pEnd.X - pStart.X;
                float delta_y = pEnd.Y - pStart.Y;
                double B_x = pStart.X + delta_x;
                double B_y = pStart.Y;
                double C_x = pStart.X;
                double C_y = pStart.Y + delta_y;
                gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pStart.Y);
                gl.Vertex(B_x, gl.RenderContextProvider.Height - B_y);
                gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pStart.Y);
                gl.Vertex(C_x, gl.RenderContextProvider.Height - C_y);
                gl.Vertex(pEnd.X, gl.RenderContextProvider.Height - pEnd.Y);
                gl.Vertex(C_x, gl.RenderContextProvider.Height - C_y);
                gl.Vertex(B_x, gl.RenderContextProvider.Height - B_y);
                gl.Vertex(pEnd.X, gl.RenderContextProvider.Height - pEnd.Y);
                
                gl.End();
                gl.Flush();
            }
            else if(shShape == 3)
            {
                gl.Begin(OpenGL.GL_LINE_LOOP);

                double a = Math.Abs(pStart.Y - pEnd.Y) / 2;
                double b = Math.Abs(pStart.X - pEnd.X) / 2;
                double x0 = (pStart.X + pEnd.X) / 2;
                double y0 = (pStart.Y + pEnd.Y) / 2;

                double x, y;
                for (int i = 0; i <= 360; i++)
                {
                    x = b * Math.Cos(i * Math.PI / 180) + x0;
                    y = a * Math.Sin(i * Math.PI / 180) + y0;
                    gl.Vertex(x, gl.RenderContextProvider.Height - y);

                    x = b * Math.Cos(i * Math.PI / 180) + x0;
                    y = a * Math.Sin(i * Math.PI / 180) + y0;
                    gl.Vertex(x, gl.RenderContextProvider.Height - y);
                }
                gl.End();
                gl.Flush();
            }
            else if (shShape == 4)
            {
                gl.Begin(OpenGL.GL_LINES); // chọn chế độ vẽ
                double h = Math.Sqrt(Math.Pow(pStart.X - pEnd.X, 2.0)
                    + Math.Pow(pStart.Y - pEnd.Y, 2.0));

                double a = 2 * h / Math.Sqrt(3.0);

                double alpha = Math.Acos((pEnd.X - pStart.X) / h);
                double A_x = Math.Cos(alpha + 30 * Math.PI / 180.0) * a + pStart.X;
                double A_y = Math.Sin(alpha + 30 * Math.PI / 180.0) * a + pStart.Y;
                double B_x = Math.Cos(alpha - 30 * Math.PI / 180.0) * a + pStart.X;
                double B_y = Math.Sin(alpha - 30 * Math.PI / 180.0) * a + pStart.Y;

                gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pStart.Y);
                gl.Vertex(A_x, gl.RenderContextProvider.Height - A_y);
                gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pStart.Y);
                gl.Vertex(B_x, gl.RenderContextProvider.Height - B_y);
                gl.Vertex(A_x, gl.RenderContextProvider.Height - A_y);
                gl.Vertex(B_x, gl.RenderContextProvider.Height - B_y);

                gl.End();
                gl.Flush();
            }
            else if(shShape == 5)
            {
                gl.Begin(OpenGL.GL_LINES);

                double h = Math.Sqrt(Math.Pow(pStart.X - pEnd.X, 2.0)
                    + Math.Pow(pStart.Y - pEnd.Y, 2.0));
                double alpha = Math.Acos((pEnd.X - pStart.X) / h);

                double A_x, A_y;
                for (int i = 0; i < 5; i++)
                {
                    A_x = Math.Cos(alpha) * h + pStart.X;
                    A_y = Math.Sin(alpha) * h + pStart.Y;
                    gl.Vertex(A_x, gl.RenderContextProvider.Height - A_y);
                    alpha += 72 * Math.PI / 180.0;
                    A_x = Math.Cos(alpha) * h + pStart.X;
                    A_y = Math.Sin(alpha) * h + pStart.Y;
                    gl.Vertex(A_x, gl.RenderContextProvider.Height - A_y);
                }

                gl.End();
                gl.Flush();
            }
            else if(shShape == 6)
            {
                gl.Begin(OpenGL.GL_LINES);

                double h = Math.Sqrt(Math.Pow(pStart.X - pEnd.X, 2.0)
                    + Math.Pow(pStart.Y - pEnd.Y, 2.0));
                double alpha = Math.Acos((pEnd.X - pStart.X) / h);

                double A_x, A_y;
                for (int i = 0; i < 6; i++)
                {
                    A_x = Math.Cos(alpha) * h + pStart.X;
                    A_y = Math.Sin(alpha) * h + pStart.Y;
                    gl.Vertex(A_x, gl.RenderContextProvider.Height - A_y);
                    alpha += 60 * Math.PI / 180.0;
                    A_x = Math.Cos(alpha) * h + pStart.X;
                    A_y = Math.Sin(alpha) * h + pStart.Y;
                    gl.Vertex(A_x, gl.RenderContextProvider.Height - A_y);
                }

                gl.End();
                gl.Flush();
            }
        }

        private void ctrl_OpenGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            if(click ==1)
                pEnd = e.Location;
        }

        private void openGLControl_Load_1(object sender, EventArgs e)
        {

        }
    }
}
