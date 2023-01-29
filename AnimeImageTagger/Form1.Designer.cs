namespace AnimeImageTagger
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "shot",
            "full body, cowboy shot, upper body, profile, close-up"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "background",
            "outdoors, indoors, white background, simple background"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStartTags = new System.Windows.Forms.TextBox();
            this.tbxRemoveTags = new System.Windows.Forms.TextBox();
            this.tbxEndTags = new System.Windows.Forms.TextBox();
            this.rbFromTemplate = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTagsFormatTemplate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTagGroupTags = new System.Windows.Forms.TextBox();
            this.tbxTagGroupName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxTagComboTags = new System.Windows.Forms.TextBox();
            this.tbxTagComboName = new System.Windows.Forms.TextBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnCreateDataset = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caption Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caption End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remove Tags";
            // 
            // tbxStartTags
            // 
            this.tbxStartTags.Location = new System.Drawing.Point(94, 36);
            this.tbxStartTags.Name = "tbxStartTags";
            this.tbxStartTags.Size = new System.Drawing.Size(141, 23);
            this.tbxStartTags.TabIndex = 1;
            // 
            // tbxRemoveTags
            // 
            this.tbxRemoveTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxRemoveTags.Location = new System.Drawing.Point(12, 121);
            this.tbxRemoveTags.Multiline = true;
            this.tbxRemoveTags.Name = "tbxRemoveTags";
            this.tbxRemoveTags.Size = new System.Drawing.Size(223, 226);
            this.tbxRemoveTags.TabIndex = 1;
            // 
            // tbxEndTags
            // 
            this.tbxEndTags.Location = new System.Drawing.Point(94, 69);
            this.tbxEndTags.Name = "tbxEndTags";
            this.tbxEndTags.Size = new System.Drawing.Size(141, 23);
            this.tbxEndTags.TabIndex = 1;
            // 
            // rbFromTemplate
            // 
            this.rbFromTemplate.AutoSize = true;
            this.rbFromTemplate.Checked = true;
            this.rbFromTemplate.Enabled = false;
            this.rbFromTemplate.Location = new System.Drawing.Point(257, 38);
            this.rbFromTemplate.Name = "rbFromTemplate";
            this.rbFromTemplate.Size = new System.Drawing.Size(128, 19);
            this.rbFromTemplate.TabIndex = 2;
            this.rbFromTemplate.TabStop = true;
            this.rbFromTemplate.Text = "Start from template";
            this.rbFromTemplate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Template";
            // 
            // tbxTagsFormatTemplate
            // 
            this.tbxTagsFormatTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTagsFormatTemplate.Location = new System.Drawing.Point(472, 36);
            this.tbxTagsFormatTemplate.Name = "tbxTagsFormatTemplate";
            this.tbxTagsFormatTemplate.Size = new System.Drawing.Size(316, 23);
            this.tbxTagsFormatTemplate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tag group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tags";
            // 
            // tbxTagGroupTags
            // 
            this.tbxTagGroupTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTagGroupTags.Location = new System.Drawing.Point(472, 69);
            this.tbxTagGroupTags.Name = "tbxTagGroupTags";
            this.tbxTagGroupTags.Size = new System.Drawing.Size(235, 23);
            this.tbxTagGroupTags.TabIndex = 1;
            // 
            // tbxTagGroupName
            // 
            this.tbxTagGroupName.Location = new System.Drawing.Point(326, 69);
            this.tbxTagGroupName.Name = "tbxTagGroupName";
            this.tbxTagGroupName.Size = new System.Drawing.Size(107, 23);
            this.tbxTagGroupName.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(257, 98);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(531, 109);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tag group";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tags";
            this.columnHeader2.Width = 450;
            // 
            // btnAdd1
            // 
            this.btnAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd1.Location = new System.Drawing.Point(713, 69);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(75, 23);
            this.btnAdd1.TabIndex = 4;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tag combination";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tags";
            // 
            // tbxTagComboTags
            // 
            this.tbxTagComboTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTagComboTags.Location = new System.Drawing.Point(518, 217);
            this.tbxTagComboTags.Name = "tbxTagComboTags";
            this.tbxTagComboTags.Size = new System.Drawing.Size(189, 23);
            this.tbxTagComboTags.TabIndex = 1;
            // 
            // tbxTagComboName
            // 
            this.tbxTagComboName.Location = new System.Drawing.Point(365, 217);
            this.tbxTagComboName.Name = "tbxTagComboName";
            this.tbxTagComboName.Size = new System.Drawing.Size(107, 23);
            this.tbxTagComboName.TabIndex = 1;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd2.Location = new System.Drawing.Point(713, 216);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 4;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnCreateDataset
            // 
            this.btnCreateDataset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateDataset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateDataset.Location = new System.Drawing.Point(12, 353);
            this.btnCreateDataset.Name = "btnCreateDataset";
            this.btnCreateDataset.Size = new System.Drawing.Size(779, 26);
            this.btnCreateDataset.TabIndex = 4;
            this.btnCreateDataset.Text = "Start!";
            this.btnCreateDataset.UseVisualStyleBackColor = true;
            this.btnCreateDataset.Click += new System.EventHandler(this.btnCreateDataset_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Location = new System.Drawing.Point(257, 246);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(531, 101);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tag Combination";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tags";
            this.columnHeader6.Width = 350;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnCreateDataset);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rbFromTemplate);
            this.Controls.Add(this.tbxEndTags);
            this.Controls.Add(this.tbxRemoveTags);
            this.Controls.Add(this.tbxTagComboName);
            this.Controls.Add(this.tbxTagComboTags);
            this.Controls.Add(this.tbxTagGroupName);
            this.Controls.Add(this.tbxTagGroupTags);
            this.Controls.Add(this.tbxTagsFormatTemplate);
            this.Controls.Add(this.tbxStartTags);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Anime Image Tagger";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxStartTags;
        private TextBox tbxRemoveTags;
        private TextBox tbxEndTags;
        private RadioButton rbFromTemplate;
        private Label label4;
        private TextBox tbxTagsFormatTemplate;
        private Label label5;
        private Label label6;
        private TextBox tbxTagGroupTags;
        private TextBox tbxTagGroupName;
        private ListView listView1;
        private Button btnAdd1;
        private Label label7;
        private Label label8;
        private TextBox tbxTagComboTags;
        private TextBox tbxTagComboName;
        private Button btnAdd2;
        private Button btnCreateDataset;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}