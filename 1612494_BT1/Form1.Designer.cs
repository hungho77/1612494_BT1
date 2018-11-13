namespace _1612494_BT1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Line = new System.Windows.Forms.Button();
            this.bt_Circle = new System.Windows.Forms.Button();
            this.bt_BangMau = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openGLControl = new SharpGL.OpenGLControl();
            this.bt_Rectangle = new System.Windows.Forms.Button();
            this.bt_Eclipse = new System.Windows.Forms.Button();
            this.bt_EquilateralTriangle = new System.Windows.Forms.Button();
            this.bt_equilateralPentagonal = new System.Windows.Forms.Button();
            this.bt_equilateralHexagonal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Line
            // 
            this.bt_Line.Location = new System.Drawing.Point(36, 28);
            this.bt_Line.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Line.Name = "bt_Line";
            this.bt_Line.Size = new System.Drawing.Size(48, 40);
            this.bt_Line.TabIndex = 0;
            this.bt_Line.Text = "Line";
            this.bt_Line.UseVisualStyleBackColor = true;
            this.bt_Line.Click += new System.EventHandler(this.bt_Line_Click);
            // 
            // bt_Circle
            // 
            this.bt_Circle.Location = new System.Drawing.Point(99, 28);
            this.bt_Circle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Circle.Name = "bt_Circle";
            this.bt_Circle.Size = new System.Drawing.Size(49, 40);
            this.bt_Circle.TabIndex = 1;
            this.bt_Circle.Text = "Circle";
            this.bt_Circle.UseVisualStyleBackColor = true;
            this.bt_Circle.Click += new System.EventHandler(this.bt_Circle_Click);
            // 
            // bt_BangMau
            // 
            this.bt_BangMau.Location = new System.Drawing.Point(609, 28);
            this.bt_BangMau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_BangMau.Name = "bt_BangMau";
            this.bt_BangMau.Size = new System.Drawing.Size(92, 40);
            this.bt_BangMau.TabIndex = 2;
            this.bt_BangMau.Text = "Bang Mau";
            this.bt_BangMau.UseVisualStyleBackColor = true;
            this.bt_BangMau.Click += new System.EventHandler(this.bt_BangMau_Click);
            // 
            // openGLControl
            // 
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(29, 73);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(662, 500);
            this.openGLControl.TabIndex = 4;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.Load += new System.EventHandler(this.openGLControl_Load_1);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_OpenGLControl_MouseDown);
            this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctrl_OpenGLControl_MouseMove);
            this.openGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ctrl_OpenGLControl_MouseUp);
            // 
            // bt_Rectangle
            // 
            this.bt_Rectangle.Location = new System.Drawing.Point(164, 28);
            this.bt_Rectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Rectangle.Name = "bt_Rectangle";
            this.bt_Rectangle.Size = new System.Drawing.Size(64, 40);
            this.bt_Rectangle.TabIndex = 5;
            this.bt_Rectangle.Text = "Rectangle";
            this.bt_Rectangle.UseVisualStyleBackColor = true;
            this.bt_Rectangle.Click += new System.EventHandler(this.bt_Rectangle_Click);
            // 
            // bt_Eclipse
            // 
            this.bt_Eclipse.Location = new System.Drawing.Point(242, 28);
            this.bt_Eclipse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Eclipse.Name = "bt_Eclipse";
            this.bt_Eclipse.Size = new System.Drawing.Size(52, 40);
            this.bt_Eclipse.TabIndex = 6;
            this.bt_Eclipse.Text = "Eclipse";
            this.bt_Eclipse.UseVisualStyleBackColor = true;
            this.bt_Eclipse.Click += new System.EventHandler(this.bt_Eclipse_click);
            // 
            // bt_EquilateralTriangle
            // 
            this.bt_EquilateralTriangle.Location = new System.Drawing.Point(311, 28);
            this.bt_EquilateralTriangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_EquilateralTriangle.Name = "bt_EquilateralTriangle";
            this.bt_EquilateralTriangle.Size = new System.Drawing.Size(69, 40);
            this.bt_EquilateralTriangle.TabIndex = 7;
            this.bt_EquilateralTriangle.TabStop = false;
            this.bt_EquilateralTriangle.Text = "equilateral triangle";
            this.bt_EquilateralTriangle.UseVisualStyleBackColor = true;
            this.bt_EquilateralTriangle.Click += new System.EventHandler(this.bt_EquilateralTriangle_Click);
            // 
            // bt_equilateralPentagonal
            // 
            this.bt_equilateralPentagonal.Location = new System.Drawing.Point(400, 28);
            this.bt_equilateralPentagonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_equilateralPentagonal.Name = "bt_equilateralPentagonal";
            this.bt_equilateralPentagonal.Size = new System.Drawing.Size(70, 40);
            this.bt_equilateralPentagonal.TabIndex = 8;
            this.bt_equilateralPentagonal.Text = "equilateral pentagonal";
            this.bt_equilateralPentagonal.UseVisualStyleBackColor = true;
            this.bt_equilateralPentagonal.Click += new System.EventHandler(this.bt_equilateralPentagonal_Click);
            // 
            // bt_equilateralHexagonal
            // 
            this.bt_equilateralHexagonal.Location = new System.Drawing.Point(494, 28);
            this.bt_equilateralHexagonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_equilateralHexagonal.Name = "bt_equilateralHexagonal";
            this.bt_equilateralHexagonal.Size = new System.Drawing.Size(71, 40);
            this.bt_equilateralHexagonal.TabIndex = 9;
            this.bt_equilateralHexagonal.TabStop = false;
            this.bt_equilateralHexagonal.Text = "equilateral hexagonal";
            this.bt_equilateralHexagonal.UseVisualStyleBackColor = true;
            this.bt_equilateralHexagonal.Click += new System.EventHandler(this.bt_equilateralHexagonal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 596);
            this.Controls.Add(this.bt_equilateralHexagonal);
            this.Controls.Add(this.bt_equilateralPentagonal);
            this.Controls.Add(this.bt_EquilateralTriangle);
            this.Controls.Add(this.bt_Eclipse);
            this.Controls.Add(this.bt_Rectangle);
            this.Controls.Add(this.openGLControl);
            this.Controls.Add(this.bt_BangMau);
            this.Controls.Add(this.bt_Circle);
            this.Controls.Add(this.bt_Line);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Line;
        private System.Windows.Forms.Button bt_Circle;
        private System.Windows.Forms.Button bt_BangMau;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.Button bt_Rectangle;
        private System.Windows.Forms.Button bt_Eclipse;
        private System.Windows.Forms.Button bt_EquilateralTriangle;
        private System.Windows.Forms.Button bt_equilateralPentagonal;
        private System.Windows.Forms.Button bt_equilateralHexagonal;
    }
}

