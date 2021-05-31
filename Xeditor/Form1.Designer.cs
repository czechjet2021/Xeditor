namespace Xeditor
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NactiSoubor = new System.Windows.Forms.Button();
            this.Ulozit = new System.Windows.Forms.Button();
            this.UlozitJako = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnfont = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnpreklepy = new System.Windows.Forms.Button();
            this.btnKeyPhrases = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NactiSoubor
            // 
            this.NactiSoubor.BackColor = System.Drawing.SystemColors.Control;
            this.NactiSoubor.FlatAppearance.BorderSize = 0;
            this.NactiSoubor.Location = new System.Drawing.Point(0, 0);
            this.NactiSoubor.Margin = new System.Windows.Forms.Padding(4);
            this.NactiSoubor.Name = "NactiSoubor";
            this.NactiSoubor.Size = new System.Drawing.Size(235, 26);
            this.NactiSoubor.TabIndex = 1;
            this.NactiSoubor.Text = "       OtevřítSoubor   (Ctrl+O)";
            this.NactiSoubor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NactiSoubor.UseVisualStyleBackColor = false;
            this.NactiSoubor.Click += new System.EventHandler(this.NactiSoubor_Click);
            // 
            // Ulozit
            // 
            this.Ulozit.BackColor = System.Drawing.SystemColors.Control;
            this.Ulozit.Location = new System.Drawing.Point(0, 49);
            this.Ulozit.Margin = new System.Windows.Forms.Padding(4);
            this.Ulozit.Name = "Ulozit";
            this.Ulozit.Size = new System.Drawing.Size(235, 26);
            this.Ulozit.TabIndex = 2;
            this.Ulozit.Text = "       Uložit                (Ctrl+S)";
            this.Ulozit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ulozit.UseVisualStyleBackColor = false;
            this.Ulozit.Click += new System.EventHandler(this.Ulozit_Click);
            // 
            // UlozitJako
            // 
            this.UlozitJako.BackColor = System.Drawing.SystemColors.Control;
            this.UlozitJako.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UlozitJako.FlatAppearance.BorderSize = 0;
            this.UlozitJako.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.UlozitJako.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.UlozitJako.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UlozitJako.Location = new System.Drawing.Point(0, 25);
            this.UlozitJako.Margin = new System.Windows.Forms.Padding(4);
            this.UlozitJako.Name = "UlozitJako";
            this.UlozitJako.Size = new System.Drawing.Size(235, 26);
            this.UlozitJako.TabIndex = 3;
            this.UlozitJako.Text = "       Uložit Jako        (Ctrl+Shift+S)";
            this.UlozitJako.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UlozitJako.UseVisualStyleBackColor = false;
            this.UlozitJako.Click += new System.EventHandler(this.UlozitJako_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1067, 529);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stisk);
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(0, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Změnit Barvu Pozadí";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(0, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Změnit Barvu Textu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.NactiSoubor);
            this.panel1.Controls.Add(this.UlozitJako);
            this.panel1.Controls.Add(this.Ulozit);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 75);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Soubor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(67, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 27);
            this.button4.TabIndex = 11;
            this.button4.Text = "Styl";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnfont);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(66, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 76);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // btnfont
            // 
            this.btnfont.BackColor = System.Drawing.SystemColors.Control;
            this.btnfont.Location = new System.Drawing.Point(0, 0);
            this.btnfont.Margin = new System.Windows.Forms.Padding(4);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(161, 28);
            this.btnfont.TabIndex = 10;
            this.btnfont.Text = "Změnit Font Textu";
            this.btnfont.UseVisualStyleBackColor = false;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(201, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 27);
            this.button5.TabIndex = 13;
            this.button5.Text = "Tisk";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(134, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 27);
            this.button6.TabIndex = 14;
            this.button6.Text = "Azure";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btnpreklepy);
            this.panel3.Controls.Add(this.btnKeyPhrases);
            this.panel3.Location = new System.Drawing.Point(134, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 75);
            this.panel3.TabIndex = 11;
            this.panel3.Visible = false;
            // 
            // btnpreklepy
            // 
            this.btnpreklepy.BackColor = System.Drawing.SystemColors.Control;
            this.btnpreklepy.Location = new System.Drawing.Point(0, 25);
            this.btnpreklepy.Margin = new System.Windows.Forms.Padding(4);
            this.btnpreklepy.Name = "btnpreklepy";
            this.btnpreklepy.Size = new System.Drawing.Size(189, 28);
            this.btnpreklepy.TabIndex = 12;
            this.btnpreklepy.Text = "opravit překlepy";
            this.btnpreklepy.UseVisualStyleBackColor = false;
            this.btnpreklepy.Click += new System.EventHandler(this.btnpreklepy_Click);
            // 
            // btnKeyPhrases
            // 
            this.btnKeyPhrases.BackColor = System.Drawing.SystemColors.Control;
            this.btnKeyPhrases.Location = new System.Drawing.Point(0, -1);
            this.btnKeyPhrases.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeyPhrases.Name = "btnKeyPhrases";
            this.btnKeyPhrases.Size = new System.Drawing.Size(189, 28);
            this.btnKeyPhrases.TabIndex = 11;
            this.btnKeyPhrases.Text = "Extrahovat Key Phrases";
            this.btnKeyPhrases.UseVisualStyleBackColor = false;
            this.btnKeyPhrases.Click += new System.EventHandler(this.btnKeyPhrases2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Xeditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.textBox1_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stisk);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NactiSoubor;
        private System.Windows.Forms.Button Ulozit;
        private System.Windows.Forms.Button UlozitJako;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnKeyPhrases;
        private System.Windows.Forms.Button btnpreklepy;
    }
}

