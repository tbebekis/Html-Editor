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
        void AnyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.X:
                        if (tb.SelectionLength > 0)
                        {
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                            tb.Cut();                            
                        }
                            
                        break;
                    case Keys.C:
                        if (tb.SelectionLength > 0)
                        {
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                            tb.Copy();                           
                        }
                        break;
                    case Keys.V:
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        tb.Paste();
                        break;
                    case Keys.Z:
                        if (tb.CanUndo)
                        {
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                            tb.Undo();
                        }
                        break;
                    case Keys.A:
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        tb.SelectAll();
                        break;
                }
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

            edtCommentsInput.KeyDown += AnyTextBox_KeyDown;
            edtCommentsOutput.KeyDown += AnyTextBox_KeyDown;
            edtEncodeInput.KeyDown += AnyTextBox_KeyDown;
            edtEncodeOutput.KeyDown += AnyTextBox_KeyDown;
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
