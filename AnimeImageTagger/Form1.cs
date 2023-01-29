//using AnimeImageTagger;
using AnimeImageTagger.Classes;
using AnimeImageTagger.Forms;
using System.Runtime.CompilerServices;

namespace AnimeImageTagger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string datasetPath = "";
        public ImageTagger imageTagger = new ImageTagger();

        private void Form1_Shown(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog()
            {
                Description = "Select the folder containing your images and caption files",
                ShowNewFolderButton = false,
            })

            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    datasetPath = fbd.SelectedPath;
                    Text = $"{Directory.GetFiles(datasetPath).Count()} files found";
                }
                else { listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); }
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnCreateDataset_Click(object sender, EventArgs e)
        {
            List<String> startTags = toTagList(tbxStartTags.Text);
            List<String> endTags = toTagList(tbxEndTags.Text);
            List<String> removeTags = toTagList(tbxRemoveTags.Text);

            List<tagGroup> tagGroups = new List<tagGroup>();
            List<tagCombo> tagCombos = new List<tagCombo>();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                String tgName = listView1.Items[i].SubItems[0].Text;
                List<String> tgTags = toTagList(listView1.Items[i].SubItems[1].Text);


                tagGroup newTagGroup = new tagGroup(tgName, tgTags);
                tagGroups.Add(newTagGroup);
            }
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                String tcName = listView2.Items[i].SubItems[0].Text;
                List<String> tcTags = toTagList(listView2.Items[i].SubItems[1].Text);


                tagCombo newTagCombo = new tagCombo(tcName, tcTags);
                tagCombos.Add(newTagCombo);
            }

            List<string> tagsTemplate = toTagList(tbxTagsFormatTemplate.Text);
            List<string> toRemove = new List<string>();
            foreach (String tag in tagsTemplate) // Loop through tags in tbxTagsFormatTemplate
            {
                // Loop through tag groups in listView1
                bool isGroup = false;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    String tgName = listView1.Items[i].SubItems[0].Text;
                    if (tag == tgName)
                    {
                        isGroup = true;
                    }
                }
                // Loop through tag groups in listView1
                bool isCombo = false;
                for (int i = 0; i < listView2.Items.Count; i++)
                {
                    String tcName = listView2.Items[i].SubItems[0].Text;
                    if (tag == tcName)
                    {
                        isCombo = true;
                    }
                }


                if (!isGroup && !isCombo)
                {
                    toRemove.Add(tag);
                }
            }
            foreach (String remove in toRemove)
            {
                tagsTemplate.RemoveAll(tag => tag == remove);
            }


            Dataset newDataset = new Dataset(datasetPath, startTags, endTags, removeTags, 
                tagGroups, tagCombos, tagsTemplate, rbFromTemplate.Checked);

            imageTagger = new ImageTagger();
            imageTagger.LoadDataset(newDataset);
            Hide();
            imageTagger.Show();
        }

        #region add button clicks
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            String[] items = new String[] { tbxTagGroupName.Text, tbxTagGroupTags.Text };

            ListViewItem item = new ListViewItem(items);
            item = new ListViewItem(items);
            listView1.Items.Add(item);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            String[] items = new String[] { tbxTagComboName.Text, tbxTagComboTags.Text };

            ListViewItem item = new ListViewItem(items);
            item = new ListViewItem(items);
            listView2.Items.Add(item);
        }
        #endregion


        private List<String> toTagList(string tagsString)
        {
            return tagsString.Trim().Replace(", ", ",").Split(',').ToList();
        }
    }
}