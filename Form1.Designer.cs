namespace punto_venta_isrrael
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ventas = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Cortes = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Ventas.SuspendLayout();
            this.Cortes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ventas);
            this.tabControl1.Controls.Add(this.Cortes);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(1077, 788);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Ventas
            // 
            this.Ventas.Controls.Add(this.button1);
            this.Ventas.Location = new System.Drawing.Point(4, 29);
            this.Ventas.Name = "Ventas";
            this.Ventas.Padding = new System.Windows.Forms.Padding(3);
            this.Ventas.Size = new System.Drawing.Size(1069, 755);
            this.Ventas.TabIndex = 0;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            this.Ventas.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cortes
            // 
            this.Cortes.Controls.Add(this.button2);
            this.Cortes.Location = new System.Drawing.Point(4, 29);
            this.Cortes.Name = "Cortes";
            this.Cortes.Padding = new System.Windows.Forms.Padding(3);
            this.Cortes.Size = new System.Drawing.Size(1069, 755);
            this.Cortes.TabIndex = 1;
            this.Cortes.Text = "Cortes";
            this.Cortes.UseVisualStyleBackColor = true;
            this.Cortes.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 59);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 784);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Ventas.ResumeLayout(false);
            this.Cortes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ventas;
        private System.Windows.Forms.TabPage Cortes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

