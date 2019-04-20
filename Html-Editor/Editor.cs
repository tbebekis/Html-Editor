using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HtmlEditor
{
    class Editor
    {
        const string SFilter = "Html files (*.html;*.htm)|*.html;*.htm|All files (*.*)|*.*";

        /* private */
        WebBrowser Browser;
        string BaseFolder;
        string fFilePath;

        void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (Browser.Document.GetElementById("EditorArea") != null)
            {
                Browser.Document.GetElementsByTagName("base")[0].SetAttribute("href", this.FileProtocolBaseUrl);
                Browser.Document.GetElementById("EditorArea").InnerHtml = this.HtmlText;
                Browser.Document.InvokeScript("prepare");
            }
        }
        void Browser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F5)                   // Prevent refreshing...
                e.IsInputKey = true;

            else if (e.Control && e.KeyCode == Keys.S)  // CTRL+S
            {
                SaveChanges();
                e.IsInputKey = true;
            }
        }

        /* construction */
        public Editor(WebBrowser Browser)
        {
            BaseFolder = Path.GetDirectoryName(this.GetType().Assembly.Location);
            EditorFilePath = Path.Combine(BaseFolder, @"RequiredFiles\Editor.html");

            this.EditorFilePath = EditorFilePath;
            this.Browser = Browser;

            Browser.DocumentCompleted += Browser_DocumentCompleted;
            Browser.PreviewKeyDown += Browser_PreviewKeyDown;
        }

        /* public */
        public void CreateNew()
        {

            using (SaveFileDialog Dlg = new SaveFileDialog())
            {
                //Dlg.InitialDirectory = App.LastArticleFolder;
                Dlg.Filter = SFilter;
                Dlg.RestoreDirectory = true;

                if (Dlg.ShowDialog() == DialogResult.OK)
                {
                    this.FilePath = Dlg.FileName;
                    Browser.Navigate(EditorFilePath);
                }
            }
        }
        public void Open()
        {
            using (OpenFileDialog Dlg = new OpenFileDialog())
            {
                //Dlg.InitialDirectory = App.LastArticleFolder;
 
                Dlg.Filter = SFilter;
                Dlg.Multiselect = false;

                if (Dlg.ShowDialog() == DialogResult.OK)
                { 
                    this.FilePath = Dlg.FileName;
                    Browser.Navigate(EditorFilePath);
                }
            }
        }

        public void SaveChanges()
        {
            if (!string.IsNullOrWhiteSpace(this.FilePath))
            {
                HtmlText = ((string)Browser.Document.InvokeScript("getHTMLData")).Replace(this.FileProtocolBaseUrl, "");
                File.WriteAllText(this.FilePath, this.HtmlText, Encoding.UTF8);
            }
        }
        public void CopyHtmlText()
        {
            if (!string.IsNullOrWhiteSpace(this.FilePath))
            {
                try
                {
                    string S = ((string)Browser.Document.InvokeScript("getHTMLData")).Replace(this.FileProtocolBaseUrl, "");
                    Clipboard.SetText(S);
                }
                catch
                {
                }
            }
        }
        public void ClearBrowser()
        {
            Browser.Navigate("about:blank");

            this.fFilePath = "";
            this.FileName = "";
            this.FileProtocolBaseUrl = "";
            this.HtmlText = "";
        }
        public string GetDocumentHtmlText()
        {
            string Result = Browser.Document.InvokeScript("getHTMLData") as string;
            return Result;
        }
 

        /* properties */
        public string EditorFilePath { get; private set; }
        public string FilePath
        {
            get { return fFilePath; }
            set
            {
                fFilePath = value;
                FileName = Path.GetFileName(fFilePath);
                FileProtocolBaseUrl = Uri.EscapeUriString("file:///" + Path.GetDirectoryName(fFilePath).Replace("\\", "/") + "/");
                HtmlText = string.Empty;

                if (!File.Exists(fFilePath))
                {
                    HtmlText = File.ReadAllText(@"RequiredFiles\Template.html", Encoding.UTF8);
                    File.WriteAllText(fFilePath, HtmlText, Encoding.UTF8);
                }
                else
                {
                    HtmlText = File.ReadAllText(fFilePath, Encoding.UTF8);
                }
            }
        }
        public string FileName { get; private set; }
        public string FileProtocolBaseUrl { get; private set; }
        public string HtmlText { get; private set; }
    }
}
