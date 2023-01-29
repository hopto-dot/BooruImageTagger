namespace AnimeImageTagger.Forms
{
    partial class ImageTagger
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPreviousImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelImageNo = new System.Windows.Forms.Label();
            this.btnPreviousTagGroup = new System.Windows.Forms.Button();
            this.btnNextTagGroup = new System.Windows.Forms.Button();
            this.labelTagGroupNo = new System.Windows.Forms.Label();
            this.tbxAddCustom = new System.Windows.Forms.TextBox();
            this.btnAddCustom = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 401);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPreviousImage
            // 
            this.btnPreviousImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousImage.Location = new System.Drawing.Point(957, 13);
            this.btnPreviousImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreviousImage.Name = "btnPreviousImage";
            this.btnPreviousImage.Size = new System.Drawing.Size(34, 40);
            this.btnPreviousImage.TabIndex = 1;
            this.btnPreviousImage.TabStop = false;
            this.btnPreviousImage.Text = "<";
            this.btnPreviousImage.UseVisualStyleBackColor = true;
            this.btnPreviousImage.Click += new System.EventHandler(this.btnPreviousImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(422, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(689, 236);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suggested tags";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(683, 208);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(422, 308);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(689, 176);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tags";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(683, 148);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnNextImage
            // 
            this.btnNextImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextImage.Location = new System.Drawing.Point(1068, 13);
            this.btnNextImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(34, 40);
            this.btnNextImage.TabIndex = 2;
            this.btnNextImage.TabStop = false;
            this.btnNextImage.Text = ">";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(396, 204);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // labelImageNo
            // 
            this.labelImageNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImageNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImageNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelImageNo.Location = new System.Drawing.Point(993, 20);
            this.labelImageNo.Name = "labelImageNo";
            this.labelImageNo.Size = new System.Drawing.Size(72, 31);
            this.labelImageNo.TabIndex = 4;
            this.labelImageNo.Text = "__ / ___";
            this.labelImageNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousTagGroup
            // 
            this.btnPreviousTagGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousTagGroup.Location = new System.Drawing.Point(425, 500);
            this.btnPreviousTagGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreviousTagGroup.Name = "btnPreviousTagGroup";
            this.btnPreviousTagGroup.Size = new System.Drawing.Size(34, 40);
            this.btnPreviousTagGroup.TabIndex = 3;
            this.btnPreviousTagGroup.TabStop = false;
            this.btnPreviousTagGroup.Text = "<";
            this.btnPreviousTagGroup.UseVisualStyleBackColor = true;
            this.btnPreviousTagGroup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNextTagGroup
            // 
            this.btnNextTagGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextTagGroup.Location = new System.Drawing.Point(592, 500);
            this.btnNextTagGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextTagGroup.Name = "btnNextTagGroup";
            this.btnNextTagGroup.Size = new System.Drawing.Size(34, 40);
            this.btnNextTagGroup.TabIndex = 4;
            this.btnNextTagGroup.TabStop = false;
            this.btnNextTagGroup.Text = ">";
            this.btnNextTagGroup.UseVisualStyleBackColor = true;
            this.btnNextTagGroup.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelTagGroupNo
            // 
            this.labelTagGroupNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTagGroupNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTagGroupNo.Location = new System.Drawing.Point(463, 505);
            this.labelTagGroupNo.Name = "labelTagGroupNo";
            this.labelTagGroupNo.Size = new System.Drawing.Size(126, 31);
            this.labelTagGroupNo.TabIndex = 4;
            this.labelTagGroupNo.Text = "Tag group __ / ___";
            this.labelTagGroupNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxAddCustom
            // 
            this.tbxAddCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAddCustom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxAddCustom.Location = new System.Drawing.Point(633, 505);
            this.tbxAddCustom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAddCustom.Name = "tbxAddCustom";
            this.tbxAddCustom.Size = new System.Drawing.Size(359, 29);
            this.tbxAddCustom.TabIndex = 5;
            // 
            // btnAddCustom
            // 
            this.btnAddCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustom.Location = new System.Drawing.Point(998, 503);
            this.btnAddCustom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCustom.Name = "btnAddCustom";
            this.btnAddCustom.Size = new System.Drawing.Size(113, 33);
            this.btnAddCustom.TabIndex = 6;
            this.btnAddCustom.TabStop = false;
            this.btnAddCustom.Text = "Add custom";
            this.btnAddCustom.UseVisualStyleBackColor = true;
            this.btnAddCustom.Click += new System.EventHandler(this.btnAddCustom_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.flowLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(14, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 230);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tag combinations";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel5);
            this.groupBox4.Location = new System.Drawing.Point(422, 547);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(689, 104);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tag groups";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(683, 78);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // ImageTagger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1123, 666);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxAddCustom);
            this.Controls.Add(this.btnAddCustom);
            this.Controls.Add(this.labelTagGroupNo);
            this.Controls.Add(this.labelImageNo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNextTagGroup);
            this.Controls.Add(this.btnPreviousTagGroup);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.btnPreviousImage);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1011, 684);
            this.Name = "ImageTagger";
            this.Text = "ImageTagger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImageTagger_FormClosed);
            this.Load += new System.EventHandler(this.ImageTagger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageTagger_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox1;
        private Button btnPreviousImage;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnNextImage;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label labelImageNo;
        private Button btnPreviousTagGroup;
        private Button btnNextTagGroup;
        private Label labelTagGroupNo;
        private TextBox tbxAddCustom;
        private Button btnAddCustom;
        private Button btnSave;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel5;

        #endregion

        //private PictureBox pictureBox1;
        //private Button btnPreviousImage;
        //private Button btnNextImage;
        //private GroupBox groupBox1;
        //private FlowLayoutPanel flowLayoutPanel1;
        //private GroupBox groupBox2;
        //private FlowLayoutPanel flowLayoutPanel2;
    }
}