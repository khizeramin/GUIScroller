namespace GUIController
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.scroller = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.D);
            this.panel1.Controls.Add(this.C);
            this.panel1.Controls.Add(this.B);
            this.panel1.Controls.Add(this.A);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 450);
            this.panel1.TabIndex = 0;
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.Yellow;
            this.D.Dock = System.Windows.Forms.DockStyle.Top;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(0, 285);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(252, 95);
            this.D.TabIndex = 3;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Olive;
            this.C.Dock = System.Windows.Forms.DockStyle.Top;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(0, 190);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(252, 95);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Chartreuse;
            this.B.Dock = System.Windows.Forms.DockStyle.Top;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(0, 95);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(252, 95);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A.Dock = System.Windows.Forms.DockStyle.Top;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(0, 0);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(252, 95);
            this.A.TabIndex = 0;
            this.A.TabStop = false;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = false;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // scroller
            // 
            this.scroller.BackColor = System.Drawing.Color.White;
            this.scroller.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.scroller.Location = new System.Drawing.Point(258, 0);
            this.scroller.Name = "scroller";
            this.scroller.Size = new System.Drawing.Size(23, 95);
            this.scroller.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.scroller);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel scroller;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button C;
    }
}

