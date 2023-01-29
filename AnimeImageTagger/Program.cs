using AnimeImageTagger;
using AnimeImageTagger.Forms;
using AnimeImageTagger.Classes;

namespace AnimeImageTagger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form1 form1 = new Form1(); // Place this var out of the constructor

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            //form1.IsMdiContainer = true;
            Application.Run(form1);
        }
    }
}
