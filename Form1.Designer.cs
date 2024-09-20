namespace koncerjegy_20240917
{
    partial class form
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
            this.gbulohely = new System.Windows.Forms.GroupBox();
            this.lbulo = new System.Windows.Forms.Label();
            this.cbulo = new System.Windows.Forms.ComboBox();
            this.gballohely = new System.Windows.Forms.GroupBox();
            this.lballo = new System.Windows.Forms.Label();
            this.cballo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jegyvásárlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újVásárlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbulo1 = new System.Windows.Forms.RadioButton();
            this.rbulo2 = new System.Windows.Forms.RadioButton();
            this.rballo2 = new System.Windows.Forms.RadioButton();
            this.rballo1 = new System.Windows.Forms.RadioButton();
            this.kiiratas = new System.Windows.Forms.Label();
            this.gbulohely.SuspendLayout();
            this.gballohely.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbulohely
            // 
            this.gbulohely.Controls.Add(this.rbulo2);
            this.gbulohely.Controls.Add(this.rbulo1);
            this.gbulohely.Controls.Add(this.lbulo);
            this.gbulohely.Controls.Add(this.cbulo);
            this.gbulohely.Location = new System.Drawing.Point(15, 42);
            this.gbulohely.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbulohely.Name = "gbulohely";
            this.gbulohely.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbulohely.Size = new System.Drawing.Size(335, 100);
            this.gbulohely.TabIndex = 1;
            this.gbulohely.TabStop = false;
            this.gbulohely.Text = "Ülőhely";
            // 
            // lbulo
            // 
            this.lbulo.AutoSize = true;
            this.lbulo.Location = new System.Drawing.Point(205, 22);
            this.lbulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbulo.Name = "lbulo";
            this.lbulo.Size = new System.Drawing.Size(93, 13);
            this.lbulo.TabIndex = 1;
            this.lbulo.Text = "Mennyiség (db)";
            // 
            // cbulo
            // 
            this.cbulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbulo.FormattingEnabled = true;
            this.cbulo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbulo.Location = new System.Drawing.Point(183, 38);
            this.cbulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbulo.Name = "cbulo";
            this.cbulo.Size = new System.Drawing.Size(140, 21);
            this.cbulo.TabIndex = 0;
            this.cbulo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gballohely
            // 
            this.gballohely.Controls.Add(this.rballo2);
            this.gballohely.Controls.Add(this.lballo);
            this.gballohely.Controls.Add(this.rballo1);
            this.gballohely.Controls.Add(this.cballo);
            this.gballohely.Location = new System.Drawing.Point(15, 165);
            this.gballohely.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gballohely.Name = "gballohely";
            this.gballohely.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gballohely.Size = new System.Drawing.Size(335, 100);
            this.gballohely.TabIndex = 2;
            this.gballohely.TabStop = false;
            this.gballohely.Text = "Állóhely";
            // 
            // lballo
            // 
            this.lballo.AutoSize = true;
            this.lballo.Location = new System.Drawing.Point(205, 20);
            this.lballo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lballo.Name = "lballo";
            this.lballo.Size = new System.Drawing.Size(93, 13);
            this.lballo.TabIndex = 2;
            this.lballo.Text = "Mennyiség (db)";
            // 
            // cballo
            // 
            this.cballo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cballo.FormattingEnabled = true;
            this.cballo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cballo.Location = new System.Drawing.Point(183, 36);
            this.cballo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cballo.Name = "cballo";
            this.cballo.Size = new System.Drawing.Size(140, 21);
            this.cballo.TabIndex = 1;
            this.cballo.SelectedIndexChanged += new System.EventHandler(this.cballo_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jegyvásárlásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jegyvásárlásToolStripMenuItem
            // 
            this.jegyvásárlásToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újVásárlásToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.jegyvásárlásToolStripMenuItem.Name = "jegyvásárlásToolStripMenuItem";
            this.jegyvásárlásToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.jegyvásárlásToolStripMenuItem.Text = "Jegyvásárlás";
            // 
            // újVásárlásToolStripMenuItem
            // 
            this.újVásárlásToolStripMenuItem.Name = "újVásárlásToolStripMenuItem";
            this.újVásárlásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újVásárlásToolStripMenuItem.Text = "Új vásárlás";
            this.újVásárlásToolStripMenuItem.Click += new System.EventHandler(this.újVásárlásToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click_1);
            // 
            // rbulo1
            // 
            this.rbulo1.AutoSize = true;
            this.rbulo1.Location = new System.Drawing.Point(8, 20);
            this.rbulo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbulo1.Name = "rbulo1";
            this.rbulo1.Size = new System.Drawing.Size(159, 17);
            this.rbulo1.TabIndex = 2;
            this.rbulo1.TabStop = true;
            this.rbulo1.Text = "1. árkategória - 1990 Ft";
            this.rbulo1.UseVisualStyleBackColor = true;
            this.rbulo1.CheckedChanged += new System.EventHandler(this.rbulo1_CheckedChanged);
            // 
            // rbulo2
            // 
            this.rbulo2.AutoSize = true;
            this.rbulo2.Location = new System.Drawing.Point(8, 54);
            this.rbulo2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbulo2.Name = "rbulo2";
            this.rbulo2.Size = new System.Drawing.Size(159, 17);
            this.rbulo2.TabIndex = 3;
            this.rbulo2.TabStop = true;
            this.rbulo2.Text = "2. árkategória - 2990 Ft";
            this.rbulo2.UseVisualStyleBackColor = true;
            this.rbulo2.CheckedChanged += new System.EventHandler(this.rbulo2_CheckedChanged);
            // 
            // rballo2
            // 
            this.rballo2.AutoSize = true;
            this.rballo2.Location = new System.Drawing.Point(8, 54);
            this.rballo2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rballo2.Name = "rballo2";
            this.rballo2.Size = new System.Drawing.Size(159, 17);
            this.rballo2.TabIndex = 5;
            this.rballo2.TabStop = true;
            this.rballo2.Text = "2. árkategória - 2190 Ft";
            this.rballo2.UseVisualStyleBackColor = true;
            this.rballo2.CheckedChanged += new System.EventHandler(this.rballo2_CheckedChanged);
            // 
            // rballo1
            // 
            this.rballo1.AutoSize = true;
            this.rballo1.Location = new System.Drawing.Point(8, 20);
            this.rballo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rballo1.Name = "rballo1";
            this.rballo1.Size = new System.Drawing.Size(159, 17);
            this.rballo1.TabIndex = 4;
            this.rballo1.TabStop = true;
            this.rballo1.Text = "1. árkategória - 1490 Ft";
            this.rballo1.UseVisualStyleBackColor = true;
            this.rballo1.CheckedChanged += new System.EventHandler(this.rballo1_CheckedChanged);
            // 
            // kiiratas
            // 
            this.kiiratas.AutoSize = true;
            this.kiiratas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kiiratas.ForeColor = System.Drawing.Color.Blue;
            this.kiiratas.Location = new System.Drawing.Point(20, 297);
            this.kiiratas.Name = "kiiratas";
            this.kiiratas.Size = new System.Drawing.Size(144, 22);
            this.kiiratas.TabIndex = 4;
            this.kiiratas.Text = "Fizetendő: 0 Ft";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 337);
            this.Controls.Add(this.kiiratas);
            this.Controls.Add(this.gballohely);
            this.Controls.Add(this.gbulohely);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "form";
            this.Text = "Koncertjegy vásárlás";
            this.Load += new System.EventHandler(this.form_Load);
            this.gbulohely.ResumeLayout(false);
            this.gbulohely.PerformLayout();
            this.gballohely.ResumeLayout(false);
            this.gballohely.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbulohely;
        private System.Windows.Forms.GroupBox gballohely;
        private System.Windows.Forms.ComboBox cbulo;
        private System.Windows.Forms.Label lbulo;
        private System.Windows.Forms.Label lballo;
        private System.Windows.Forms.ComboBox cballo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jegyvásárlásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újVásárlásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbulo2;
        private System.Windows.Forms.RadioButton rbulo1;
        private System.Windows.Forms.RadioButton rballo2;
        private System.Windows.Forms.RadioButton rballo1;
        private System.Windows.Forms.Label kiiratas;
    }
}

