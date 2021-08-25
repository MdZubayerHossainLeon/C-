namespace medicineManagement
{
    partial class doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.group = new System.Windows.Forms.ComboBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Gname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Dose = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.root = new System.Windows.Forms.ComboBox();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.full = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.findg = new System.Windows.Forms.TextBox();
            this.findt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TradeName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Information Here";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(187, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(419, 306);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // group
            // 
            this.group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.group.FormattingEnabled = true;
            this.group.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Pregnent"});
            this.group.Location = new System.Drawing.Point(187, 196);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(133, 21);
            this.group.TabIndex = 3;
            // 
            // Insert
            // 
            this.Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Insert.Location = new System.Drawing.Point(28, 418);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 32);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Gname
            // 
            this.Gname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gname.AutoSize = true;
            this.Gname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gname.Location = new System.Drawing.Point(58, 85);
            this.Gname.Name = "Gname";
            this.Gname.Size = new System.Drawing.Size(97, 17);
            this.Gname.TabIndex = 5;
            this.Gname.Text = "Generic name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trade name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Patient group";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dose limit";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Root of administration";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Price";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(187, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 11;
            // 
            // Dose
            // 
            this.Dose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dose.Location = new System.Drawing.Point(187, 256);
            this.Dose.Name = "Dose";
            this.Dose.Size = new System.Drawing.Size(133, 20);
            this.Dose.TabIndex = 12;
            // 
            // Price
            // 
            this.Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Price.Location = new System.Drawing.Point(187, 369);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(133, 20);
            this.Price.TabIndex = 13;
            // 
            // root
            // 
            this.root.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.root.FormattingEnabled = true;
            this.root.Items.AddRange(new object[] {
            "Oral",
            "Anal",
            "Liquid",
            "Inject",
            "Normal"});
            this.root.Location = new System.Drawing.Point(187, 314);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(133, 21);
            this.root.TabIndex = 14;
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(138, 418);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 32);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(262, 418);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 32);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(386, 418);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 32);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // full
            // 
            this.full.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.full.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full.Location = new System.Drawing.Point(500, 418);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(87, 32);
            this.full.TabIndex = 18;
            this.full.Text = "Full Screen";
            this.full.UseVisualStyleBackColor = true;
            this.full.Click += new System.EventHandler(this.Full_Click);
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Red;
            this.logout.Location = new System.Drawing.Point(688, 427);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 32);
            this.logout.TabIndex = 19;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // findg
            // 
            this.findg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findg.Location = new System.Drawing.Point(361, 386);
            this.findg.Name = "findg";
            this.findg.Size = new System.Drawing.Size(133, 20);
            this.findg.TabIndex = 21;
            this.findg.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // findt
            // 
            this.findt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findt.Location = new System.Drawing.Point(586, 386);
            this.findt.Name = "findt";
            this.findt.Size = new System.Drawing.Size(133, 20);
            this.findt.TabIndex = 22;
            this.findt.TextChanged += new System.EventHandler(this.Findt_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Search by Generic name";
            // 
            // TradeName
            // 
            this.TradeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TradeName.AutoSize = true;
            this.TradeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradeName.Location = new System.Drawing.Point(583, 352);
            this.TradeName.Name = "TradeName";
            this.TradeName.Size = new System.Drawing.Size(153, 17);
            this.TradeName.TabIndex = 24;
            this.TradeName.Text = "Search by Trade name";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "(Per day)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(725, 386);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 20);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(500, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 20);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 58);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 462);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TradeName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.findt);
            this.Controls.Add(this.findg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.full);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.root);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Dose);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gname);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.group);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Doctor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label Gname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Dose;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.ComboBox root;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button full;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox findg;
        private System.Windows.Forms.TextBox findt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TradeName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
    }
}