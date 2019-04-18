using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlEditor
{
    public partial class MainForm : Form
    {
        Editor Editor;

        /* handlers */
        void AnyClick(object sender, EventArgs ea)
        {
            if (btnExit == sender)
            {
                Close();
                return;
            }

            else if (btnNew == sender)
            {
                Editor.CreateNew();
            }
            else if (btnOpen == sender)
            {
                Editor.Open();
            }



            else if (mnuSave == sender || btnSave == sender)
            {
                Editor.SaveChanges();
            }
            else if (mnuCloseEditor == sender || btnCloseEditor == sender)
            {
                if (MessageBox.Show(this, "Close editor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Editor.ClearBrowser();
                }
            }
            else if (mnuCopyHtmlText == sender)
            {
                Editor.CopyHtmlText();
            }
        }

        /* private */
        void FormInitialize()
        {
            Browser.IsWebBrowserContextMenuEnabled = false;
            Browser.WebBrowserShortcutsEnabled = true;
            Browser.ScriptErrorsSuppressed = true;
            Browser.AllowWebBrowserDrop = false;

            btnExit.Click += AnyClick; 
            btnNew.Click += AnyClick;
            btnOpen.Click += AnyClick;
            btnSave.Click += AnyClick;
            btnCloseEditor.Click += AnyClick;

            mnuCloseEditor.Click += AnyClick;
            mnuSave.Click += AnyClick;
            mnuCopyHtmlText.Click += AnyClick;

            Editor = new Editor(this.Browser);
        }
 

        /* overrides */
        protected override void OnShown(EventArgs e)
        {
            if (!DesignMode)
                FormInitialize();
            base.OnShown(e);
        }

        /* construction */
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
