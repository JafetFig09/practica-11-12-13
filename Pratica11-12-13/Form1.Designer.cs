namespace Pratica11_12_13
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
            panel1 = new Panel();
            btUno = new Button();
            listBox1 = new ListBox();
            rb1 = new RadioButton();
            panel2 = new Panel();
            btnDos = new Button();
            listBox2 = new ListBox();
            rb2 = new RadioButton();
            panel3 = new Panel();
            btnTres = new Button();
            listBox3 = new ListBox();
            rb3 = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btUno);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(29, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 492);
            panel1.TabIndex = 0;
            // 
            // btUno
            // 
            btUno.BackColor = SystemColors.ActiveCaption;
            btUno.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btUno.ForeColor = SystemColors.ControlLightLight;
            btUno.Location = new Point(236, 406);
            btUno.Name = "btUno";
            btUno.Size = new Size(199, 46);
            btUno.TabIndex = 1;
            btUno.Text = "Resolver";
            btUno.UseVisualStyleBackColor = false;
            btUno.Click += btUno_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(0, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(632, 324);
            listBox1.TabIndex = 0;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(134, 47);
            rb1.Name = "rb1";
            rb1.Size = new Size(102, 24);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Practica 11";
            rb1.UseVisualStyleBackColor = true;
            rb1.CheckedChanged += rb1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDos);
            panel2.Controls.Add(listBox2);
            panel2.Location = new Point(742, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 480);
            panel2.TabIndex = 2;
            // 
            // btnDos
            // 
            btnDos.BackColor = SystemColors.ActiveCaption;
            btnDos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDos.ForeColor = SystemColors.ControlLightLight;
            btnDos.Location = new Point(90, 417);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(218, 44);
            btnDos.TabIndex = 1;
            btnDos.Text = "Resolver";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += btnDos_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(18, 17);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(435, 284);
            listBox2.TabIndex = 0;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(815, 47);
            rb2.Name = "rb2";
            rb2.Size = new Size(102, 24);
            rb2.TabIndex = 3;
            rb2.TabStop = true;
            rb2.Text = "Practica 12";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb2_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTres);
            panel3.Controls.Add(listBox3);
            panel3.Location = new Point(1278, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 486);
            panel3.TabIndex = 4;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.ActiveCaption;
            btnTres.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTres.ForeColor = SystemColors.ControlLightLight;
            btnTres.Location = new Point(146, 417);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(212, 34);
            btnTres.TabIndex = 1;
            btnTres.Text = "Resolver";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(24, 30);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(397, 304);
            listBox3.TabIndex = 0;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(1248, 47);
            rb3.Name = "rb3";
            rb3.Size = new Size(102, 24);
            rb3.TabIndex = 5;
            rb3.TabStop = true;
            rb3.Text = "Practica 13";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += rb3_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1741, 713);
            Controls.Add(rb3);
            Controls.Add(panel3);
            Controls.Add(rb2);
            Controls.Add(panel2);
            Controls.Add(rb1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private RadioButton rb1;
        private Button btUno;
        private Panel panel2;
        private ListBox listBox2;
        private RadioButton rb2;
        private Button btnDos;
        private Panel panel3;
        private ListBox listBox3;
        private RadioButton rb3;
        private Button btnTres;
    }
}