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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jegyvásárlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újVásárlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbulohely = new System.Windows.Forms.GroupBox();
            this.gballohely = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbulohely.SuspendLayout();
            this.gballohely.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jegyvásárlásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
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
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // gbulohely
            // 
            this.gbulohely.Controls.Add(this.label2);
            this.gbulohely.Controls.Add(this.comboBox1);
            this.gbulohely.Location = new System.Drawing.Point(13, 42);
            this.gbulohely.Name = "gbulohely";
            this.gbulohely.Size = new System.Drawing.Size(287, 100);
            this.gbulohely.TabIndex = 1;
            this.gbulohely.TabStop = false;
            this.gbulohely.Text = "Ülőhely";
            // 
            // gballohely
            // 
            this.gballohely.Controls.Add(this.label1);
            this.gballohely.Controls.Add(this.comboBox2);
            this.gballohely.Location = new System.Drawing.Point(13, 165);
            this.gballohely.Name = "gballohely";
            this.gballohely.Size = new System.Drawing.Size(287, 100);
            this.gballohely.TabIndex = 2;
            this.gballohely.TabStop = false;
            this.gballohely.Text = "Állóhely";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "0";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mennyiség (db)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mennyiség (db)";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 310);
            this.Controls.Add(this.gballohely);
            this.Controls.Add(this.gbulohely);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form";
            this.Text = "Koncertjegy vásárlás";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbulohely.ResumeLayout(false);
            this.gbulohely.PerformLayout();
            this.gballohely.ResumeLayout(false);
            this.gballohely.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jegyvásárlásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újVásárlásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbulohely;
        private System.Windows.Forms.GroupBox gballohely;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

