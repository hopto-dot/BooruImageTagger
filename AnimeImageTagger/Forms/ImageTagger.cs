using AnimeImageTagger.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimeImageTagger;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace AnimeImageTagger.Forms
{
    public partial class ImageTagger : Form
    {
        public ImageTagger()
        {
            InitializeComponent();
        }
        Dataset dataset = null;
        int currentImage = 0;
        int currentTagGroup = 0;

        public void LoadDataset(Dataset dataset)
        {
            this.dataset = dataset;
        }

        private void ImageTagger_Load(object sender, EventArgs e)
        {
            updateImage();
            updateTagGroup();

            foreach (tagCombo comboTag in Program.form1.imageTagger.dataset.tagCombos)
            {
                Program.form1.imageTagger.flowLayoutPanel3.Controls.Add(new tagButton(comboTag.comboName, false, 3));
            }
        }

        class tagButton : Button
        {
            public string tag = "";
            public int origin = -1;
            public bool useTag = false;

            public tagButton(String tag, Boolean useTag, int origin = 2)
            {
                this.tag = tag;
                this.Text = tag;
                this.useTag = useTag;
                this.TabStop = false;

                if (tag.Length <= 6)
                {
                    Width = 75;
                }
                else if (tag.Length <= 13)
                {
                    Width = 125;
                }
                else
                {
                    Width = 160;
                }

                Height = 30;

                this.Click += TagButton_Click;
                this.origin = origin;
            }

            private void TagButton_Click(object sender, EventArgs e)
            {
                tagButton tagButton = (tagButton)sender;
                if (tagButton.origin != 3)
                {
                    tagButton.useTag = !tagButton.useTag;
                }

                if (tagButton.origin == 3)
                {
                    tagCombo toAdd = new tagCombo();
                    foreach (tagCombo tagCombo in Program.form1.imageTagger.dataset.tagCombos)
                    {
                        if (tagButton.tag == tagCombo.comboName)
                        {
                            toAdd = tagCombo;
                            break;
                        }
                    }

                    int currentImage = Program.form1.imageTagger.currentImage;
                    foreach (String tag in toAdd.tags)
                    {
                        bool alreadyInUse = false;
                        foreach (var inUse in Program.form1.imageTagger.dataset.images[currentImage].caption.tagsUse)
                        {
                            if (tag == inUse)
                            {
                                alreadyInUse = true;
                            }
                        }
                        if (!alreadyInUse)
                        {
                            Program.form1.imageTagger.flowLayoutPanel2.Controls.Add(new tagButton(tag, true, 0));
                            Program.form1.imageTagger.dataset.images[currentImage].caption.tagsUse.Add(tag);
                        }
                    }
                    return;
                }

                if (tagButton.useTag) // Moving from suggested tags to in-use
                {
                    Program.form1.imageTagger.flowLayoutPanel2.Controls.Add(tagButton);

                    int currentImage = Program.form1.imageTagger.currentImage;
                    Program.form1.imageTagger.dataset.images[currentImage].caption.tagsUse.Add(tagButton.tag);
                    Program.form1.imageTagger.dataset.images[currentImage].caption.tagsSuggest.Remove(tagButton.tag);
                }
                else
                {
                    if (tagButton.origin == 1) // Moving from in-use tags to suggested
                    {
                        Program.form1.imageTagger.flowLayoutPanel1.Controls.Add(tagButton);

                        int currentImage = Program.form1.imageTagger.currentImage;
                        Program.form1.imageTagger.dataset.images[currentImage].caption.tagsUse.Remove(tagButton.tag);
                        Program.form1.imageTagger.dataset.images[currentImage].caption.tagsSuggest.Add(tagButton.tag);
                    }
                    else if (tagButton.origin == 3) // Moving from in-use tags to suggested
                    {
                        Program.form1.imageTagger.flowLayoutPanel1.Controls.Add(tagButton);

                        int currentImage = Program.form1.imageTagger.currentImage;
                        Program.form1.imageTagger.dataset.images[currentImage].caption.tagsUse.Remove(tagButton.tag);
                        Program.form1.imageTagger.dataset.images[currentImage].caption.tagsSuggest.Add(tagButton.tag);
                    }
                    else if (tagButton.origin == 4) // Moving from in-use tags to tag groups
                    {
                        Program.form1.imageTagger.flowLayoutPanel5.Controls.Add(tagButton);

                        int currentImage = Program.form1.imageTagger.currentImage;
                        Program.form1.imageTagger.dataset.images[currentImage].caption.tagsUse.Remove(tagButton.tag);
                    }
                    else if (tagButton.origin == 0) // Moving from in-use tags to nowhere (deleting)
                    {
                        Program.form1.imageTagger.flowLayoutPanel2.Controls.Remove(tagButton);

                        int currentImage = Program.form1.imageTagger.currentImage;
                        Program.form1.imageTagger.dataset.images[currentImage].caption.tagsUse.Remove(tagButton.tag);
                    }
                }

                Console.WriteLine();
            }
        }

        #region next/previous image click
        void updateImage()
        {            
            if (currentImage < 0) { currentImage = dataset.images.Count - 1; }
            if (currentImage >= dataset.images.Count) { currentImage = 0; }

            pictureBox1.Image = pictureBox1.Image = new Bitmap(dataset.images[currentImage].filePath);
            labelImageNo.Text = $"{currentImage + 1} / {dataset.images.Count}";

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            foreach (String suggestedTag in dataset.images[currentImage].caption.tagsSuggest)
            {
                bool inTagGroup = false;
                foreach (tagGroup tagGroup in dataset.tagGroups)
                {
                    foreach (String tag in tagGroup.tags)
                    {
                        if (tag == suggestedTag)
                        { inTagGroup = true; break; }
                    }
                }

                if (!inTagGroup)
                {
                    flowLayoutPanel1.Controls.Add(new tagButton(suggestedTag, false, 1));
                }
                else { }
            }
            foreach (String useTag in dataset.images[currentImage].caption.tagsUse)
            {
                //bool inTagGroup = false;
                //foreach (tagGroup tagGroup in dataset.tagGroups)
                //{
                //    foreach (String tag in tagGroup.tags)
                //    {
                //        if (tag == useTag)
                //        { inTagGroup = true; break; }
                //    }
                //}

                //if (inTagGroup)
                //{
                //    flowLayoutPanel5.Controls.Add(new tagButton(useTag, false, 4));
                //}
                //else
                //{
                //    
                //}
                flowLayoutPanel2.Controls.Add(new tagButton(useTag, true, 1));
            }

            updateTagGroup();
        }

        private void btnPreviousImage_Click(object sender, EventArgs e)
        {
            currentImage -= 1;
            updateImage();
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            currentImage += 1;
            updateImage();
        }
        #endregion

        #region Tag group switch
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentTagGroup <= 0) { return; }
            
            currentTagGroup -= 1;
            updateTagGroup();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (currentTagGroup + 1 >= dataset.tagGroups.Count) { return; }

            currentTagGroup += 1;
            updateTagGroup();
        }

        private void updateTagGroup()
        {
            flowLayoutPanel5.Controls.Clear();
            labelTagGroupNo.Text = $"Tag group {currentTagGroup + 1} / {dataset.tagGroups.Count}";

            tagGroup newTagGroup = dataset.tagGroups[currentTagGroup];
            int currentImage = Program.form1.imageTagger.currentImage;
            foreach (String tag in newTagGroup.tags)
            {
                bool alreadyUsed = false;
                foreach (string usedTag in Program.form1.imageTagger.dataset.images[currentImage].caption.tagsUse)
                {
                    if (usedTag == tag)
                    {
                        alreadyUsed = true;
                    }
                }
                if (!alreadyUsed)
                {
                    flowLayoutPanel5.Controls.Add(new tagButton(tag, false, 4));
                }
            }
        }
        #endregion

        private void ImageTagger_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.form1.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<List<String>> finalTemplate = new List<List<string>>();
            foreach (string templateTag in dataset.tagsTemplate)
            {
                // Check if the template tag is a reference to a tag group
                foreach (tagGroup tagGroup in dataset.tagGroups)
                {
                    if (templateTag == tagGroup.groupName)
                    {
                        // It is! Now loop through all tags in the group and add them to the finalTemplate
                        List<String> toFinaltemplate = new List<string>();
                        foreach (string groupTag in tagGroup.tags)
                        {
                            toFinaltemplate.Add(groupTag);
                        }
                        finalTemplate.Add(toFinaltemplate);
                    }
                }

                // Check if the template tag is a reference to a group combination
                foreach (tagCombo tagCombo in dataset.tagCombos)
                {
                    if (templateTag == tagCombo.comboName)
                    {
                        // It is! Now loop through all tags in the combination and add them to the finalTemplate
                        List<String> toFinaltemplate = new List<string>();
                        foreach (string groupTag in tagCombo.tags)
                        {
                            toFinaltemplate.Add(groupTag);
                        }
                        finalTemplate.Add(toFinaltemplate);
                    }
                }


            }
            

            string newFolder = dataset.directory + "_new";
            Directory.CreateDirectory(newFolder);
            foreach (var image in dataset.images)
            {
                //check which extension the image uses
                String[] imgExtensions = { ".jpg", ".jpeg", ".png" };
                String extension = "";
                foreach (String imgExtension in imgExtensions)
                {
                    if (image.filePath.EndsWith(imgExtension))
                    {
                        extension = imgExtension;
                        break;
                    }
                }
                if (extension == "") { continue; }

                string imgFilename = image.filePath.Replace(dataset.directory + "\\", "");
                if (!File.Exists(newFolder + $"\\{imgFilename}"))
                {
                    File.Copy(image.filePath, newFolder + $"\\{imgFilename}");
                }

                string txtFilename = imgFilename.Replace(extension, ".txt");
                if (!File.Exists(newFolder + $"\\{txtFilename}"))
                {
                    File.Create(newFolder + $"\\{txtFilename}").Dispose();
                }

                List<String> finalCaption = new List<string>();
                #region Build full caption
                foreach (string addStart in dataset.startWith)
                {
                    finalCaption.Add(addStart);
                }

                foreach (List<String> templateGroup in finalTemplate)
                {
                    foreach (String templateTag in templateGroup)
                    {
                        foreach (String usedTag in image.caption.tagsUse)
                        {
                            if (templateTag == usedTag)
                            {
                                finalCaption.Add(templateTag);
                            }
                        }
                    }
                }

                foreach (String usedTag in image.caption.tagsUse)
                {
                    bool isTemplate = false; // not template until proven so
                    foreach (List<String> templateGroup in finalTemplate)
                    {
                        foreach (String templateTag in templateGroup)
                        {
                            if (templateTag == usedTag)
                            {
                                isTemplate = true;
                            }
                        }
                    }
                    if (!isTemplate)
                    {
                        finalCaption.Add(usedTag);
                    }
                }

                foreach (string addAfter in dataset.endWith)
                {
                    finalCaption.Add(addAfter);
                }
                #endregion

                File.WriteAllText(newFolder + $"\\{txtFilename}", String.Join(", ", finalCaption));
            }

            Console.WriteLine();
        }

        private void btnAddCustom_Click(object sender, EventArgs e)
        {
            string newTag = Program.form1.imageTagger.tbxAddCustom.Text;
            Program.form1.imageTagger.tbxAddCustom.Text = "";

            Program.form1.imageTagger.flowLayoutPanel2.Controls.Add(new tagButton(newTag, true, 0));
            Program.form1.imageTagger.dataset.images[currentImage].caption.tagsUse.Add(newTag);
        }

        private void ImageTagger_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("You pressed " + e.KeyCode);
            if (e.KeyCode == Keys.Right)
            {
                currentImage += 1;
                updateImage();
            }
            else if (e.KeyCode == Keys.Left)
            {
                currentImage -= 1;
                updateImage();
            }
        }


    }
}
