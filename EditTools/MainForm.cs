using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace EditTools
{
    public partial class MainForm : Form
    {
        void AnyClick(object sender, EventArgs ea)
        {
            if (btnCommentsExecute == sender)
            {
                CommentsExecute();
            }
            else if (btnEncodeExecute == sender)
            {
                EncodeExecute();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void EncodeExecute()
        {
            string S = edtEncodeInput.Text;
            S = HttpUtility.HtmlEncode(S);
            edtEncodeOutput.Text = S;
        }
        void CommentsExecute()
        {
            string[] Separator = new string[] { "\r\n" };
            string[] Lines = edtCommentsInput.Text.Split(Separator, StringSplitOptions.None);
            StringBuilder SB = new StringBuilder();

            string S;
            foreach (string Line in Lines)
            {
                S = Line.Trim();
                if (!S.StartsWith(@"//"))
                {
                    SB.AppendLine(Line);
                }
            }

            edtCommentsOutput.Text = SB.ToString();

            
        }
        void FormInitialize()
        {
            btnCommentsExecute.Click += AnyClick;
            btnEncodeExecute.Click += AnyClick;
        }

        protected override void OnShown(EventArgs e)
        {
            if (!DesignMode)
                FormInitialize();
            base.OnShown(e);
        }

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
