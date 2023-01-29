using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AnimeImageTagger.Classes
{
    public class Image
    {
        public string filePath = String.Empty;
        public Caption caption = null;

        public Image(String filePath, String imgExtension, List<String> tags, Boolean fromScratch = false)
        {
            this.filePath = filePath;

            this.caption = new Caption(filePath.Replace(imgExtension, ".txt"),
                tags, fromScratch);
        }
    }

    public class Caption
    {
        public string filePath = String.Empty;
        public List<string> tagsUse = new List<string>();
        public List<string> tagsSuggest = new List<string>();

        public Caption(String filePath, List<String> tags, Boolean fromScratch)
        {
            this.filePath = filePath;
            
            if (!fromScratch)
            {
                this.tagsUse = tags;
            }
            else
            {
                this.tagsSuggest = tags;
            }
        }

        public string getCaption()
        {
            return String.Join(", ", tagsUse);
        }

        public void removeTag(string toRemove)
        {
            tagsUse.RemoveAll(tag => tag == toRemove);
        }
    }

    public class tagGroup
    {
        public string groupName = string.Empty;
        public List<String> tags = new List<String>();

        public tagGroup(string groupName, List<string> tags)
        {
            this.groupName = groupName;
            this.tags = tags;
        }
    }

    public class tagCombo
    {
        public string comboName = string.Empty;
        public List<String> tags = new List<String>();

        public tagCombo(string comboName, List<string> tags)
        {
            this.comboName = comboName;
            this.tags = tags;
        }

        public tagCombo()
        {

        }
    }

    public class Dataset
    {
        public String directory = String.Empty;
        
        public List<Image> images = new List<Image>();

        public List<tagGroup> tagGroups = new List<tagGroup>();
        public List<tagCombo> tagCombos = new List<tagCombo>();

        public List<String> startWith = new List<String>();
        public List<String> endWith = new List<String>();

        public List<String> tagsTemplate = new List<String>();

        public Dataset(string datasetDirectory, List<string> startWith, List<string> endWith, List<string> removeTags, List<tagGroup> tagGroups, List<tagCombo> tagCombos, List<String> tagsTemplate, Boolean fromScratch = false)
        {
            this.directory = datasetDirectory;

            this.tagGroups = tagGroups;
            this.tagCombos = tagCombos;
            this.startWith = startWith;
            this.endWith = endWith;

            this.tagsTemplate = tagsTemplate;

            // Add images to list:
            foreach (String file in Directory.GetFiles(directory))
            {
                //check if file is image
                String[] imgExtensions = { ".jpg", ".jpeg", ".png" };
                String extension = "";
                foreach (String imgExtension in imgExtensions)
                {
                    if (file.EndsWith(imgExtension))
                    {
                        extension = imgExtension;
                        break;
                    }
                }
                if (extension == "") { continue; }

                String textFile = file.Replace(extension, ".txt");
                if (File.Exists(textFile))
                {
                    List<String> newTags = File.ReadAllText(textFile).Trim().Replace(", ", ",").Split(',').ToList();

                    foreach (String removeTag in removeTags)
                    {
                        newTags.RemoveAll(tag => tag == removeTag);
                    }

                    foreach (String startTag in startWith)
                    {
                        newTags.RemoveAll(tag => tag == startTag);
                    }
                    foreach (String endTag in endWith)
                    {
                        if (endTag != "")
                        {
                            newTags.RemoveAll(tag => tag == endTag);
                            //newTags.Add(endTag);
                        }
                    }

                    //startWith.Reverse();
                    foreach (String startTag in startWith)
                    {
                        if (startTag != "")
                        {
                            //newTags = newTags.Prepend(startTag).ToList();
                        }
                    }

                    Image newImage = new Image(file, extension, newTags, fromScratch);

                    this.images.Add(newImage);
                }            
            }

            Console.WriteLine();
        }
    }
}
