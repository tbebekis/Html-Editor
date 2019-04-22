namespace EditTools
{
    partial class MainForm
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
            this.Pager = new System.Windows.Forms.TabControl();
            this.tabComments = new System.Windows.Forms.TabPage();
            this.tabEncode = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCommentsExecute = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEncodeExecute = new System.Windows.Forms.Button();
            this.splitComments = new System.Windows.Forms.SplitContainer();
            this.splitEncode = new System.Windows.Forms.SplitContainer();
            this.edtCommentsInput = new System.Windows.Forms.TextBox();
            this.edtCommentsOutput = new System.Windows.Forms.TextBox();
            this.edtEncodeInput = new System.Windows.Forms.TextBox();
            this.edtEncodeOutput = new System.Windows.Forms.TextBox();
            this.Pager.SuspendLayout();
            this.tabComments.SuspendLayout();
            this.tabEncode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitComments)).BeginInit();
            this.splitComments.Panel1.SuspendLayout();
            this.splitComments.Panel2.SuspendLayout();
            this.splitComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEncode)).BeginInit();
            this.splitEncode.Panel1.SuspendLayout();
            this.splitEncode.Panel2.SuspendLayout();
            this.splitEncode.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pager
            // 
            this.Pager.Controls.Add(this.tabComments);
            this.Pager.Controls.Add(this.tabEncode);
            this.Pager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pager.Location = new System.Drawing.Point(0, 0);
            this.Pager.Name = "Pager";
            this.Pager.SelectedIndex = 0;
            this.Pager.Size = new System.Drawing.Size(1008, 729);
            this.Pager.TabIndex = 0;
            // 
            // tabComments
            // 
            this.tabComments.Controls.Add(this.splitComments);
            this.tabComments.Controls.Add(this.panel1);
            this.tabComments.Location = new System.Drawing.Point(4, 22);
            this.tabComments.Name = "tabComments";
            this.tabComments.Padding = new System.Windows.Forms.Padding(3);
            this.tabComments.Size = new System.Drawing.Size(1000, 703);
            this.tabComments.TabIndex = 0;
            this.tabComments.Text = "Comments";
            this.tabComments.UseVisualStyleBackColor = true;
            // 
            // tabEncode
            // 
            this.tabEncode.Controls.Add(this.splitEncode);
            this.tabEncode.Controls.Add(this.panel2);
            this.tabEncode.Location = new System.Drawing.Point(4, 22);
            this.tabEncode.Name = "tabEncode";
            this.tabEncode.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncode.Size = new System.Drawing.Size(1000, 703);
            this.tabEncode.TabIndex = 1;
            this.tabEncode.Text = "Encode";
            this.tabEncode.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnCommentsExecute);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 32);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(100, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 32);
            this.panel5.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(976, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 32);
            this.panel3.TabIndex = 11;
            // 
            // btnCommentsExecute
            // 
            this.btnCommentsExecute.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCommentsExecute.Location = new System.Drawing.Point(0, 0);
            this.btnCommentsExecute.Name = "btnCommentsExecute";
            this.btnCommentsExecute.Size = new System.Drawing.Size(100, 32);
            this.btnCommentsExecute.TabIndex = 0;
            this.btnCommentsExecute.Text = "Execute";
            this.btnCommentsExecute.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnEncodeExecute);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 32);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(100, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 32);
            this.panel4.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(976, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(18, 32);
            this.panel6.TabIndex = 11;
            // 
            // btnEncodeExecute
            // 
            this.btnEncodeExecute.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEncodeExecute.Location = new System.Drawing.Point(0, 0);
            this.btnEncodeExecute.Name = "btnEncodeExecute";
            this.btnEncodeExecute.Size = new System.Drawing.Size(100, 32);
            this.btnEncodeExecute.TabIndex = 0;
            this.btnEncodeExecute.Text = "Execute";
            this.btnEncodeExecute.UseVisualStyleBackColor = true;
            // 
            // splitComments
            // 
            this.splitComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitComments.Location = new System.Drawing.Point(3, 35);
            this.splitComments.Name = "splitComments";
            // 
            // splitComments.Panel1
            // 
            this.splitComments.Panel1.Controls.Add(this.edtCommentsInput);
            // 
            // splitComments.Panel2
            // 
            this.splitComments.Panel2.Controls.Add(this.edtCommentsOutput);
            this.splitComments.Size = new System.Drawing.Size(994, 665);
            this.splitComments.SplitterDistance = 483;
            this.splitComments.TabIndex = 4;
            // 
            // splitEncode
            // 
            this.splitEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEncode.Location = new System.Drawing.Point(3, 35);
            this.splitEncode.Name = "splitEncode";
            // 
            // splitEncode.Panel1
            // 
            this.splitEncode.Panel1.Controls.Add(this.edtEncodeInput);
            // 
            // splitEncode.Panel2
            // 
            this.splitEncode.Panel2.Controls.Add(this.edtEncodeOutput);
            this.splitEncode.Size = new System.Drawing.Size(994, 665);
            this.splitEncode.SplitterDistance = 483;
            this.splitEncode.TabIndex = 5;
            // 
            // edtCommentsInput
            // 
            this.edtCommentsInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtCommentsInput.Font = new System.Drawing.Font("Courier New", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtCommentsInput.Location = new System.Drawing.Point(0, 0);
            this.edtCommentsInput.Multiline = true;
            this.edtCommentsInput.Name = "edtCommentsInput";
            this.edtCommentsInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edtCommentsInput.Size = new System.Drawing.Size(483, 665);
            this.edtCommentsInput.TabIndex = 0;
            // 
            // edtCommentsOutput
            // 
            this.edtCommentsOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtCommentsOutput.Font = new System.Drawing.Font("Courier New", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtCommentsOutput.Location = new System.Drawing.Point(0, 0);
            this.edtCommentsOutput.Multiline = true;
            this.edtCommentsOutput.Name = "edtCommentsOutput";
            this.edtCommentsOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edtCommentsOutput.Size = new System.Drawing.Size(507, 665);
            this.edtCommentsOutput.TabIndex = 1;
            // 
            // edtEncodeInput
            // 
            this.edtEncodeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtEncodeInput.Font = new System.Drawing.Font("Courier New", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtEncodeInput.Location = new System.Drawing.Point(0, 0);
            this.edtEncodeInput.Multiline = true;
            this.edtEncodeInput.Name = "edtEncodeInput";
            this.edtEncodeInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edtEncodeInput.Size = new System.Drawing.Size(483, 665);
            this.edtEncodeInput.TabIndex = 1;
            // 
            // edtEncodeOutut
            // 
            this.edtEncodeOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtEncodeOutput.Font = new System.Drawing.Font("Courier New", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtEncodeOutput.Location = new System.Drawing.Point(0, 0);
            this.edtEncodeOutput.Multiline = true;
            this.edtEncodeOutput.Name = "edtEncodeOutut";
            this.edtEncodeOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edtEncodeOutput.Size = new System.Drawing.Size(507, 665);
            this.edtEncodeOutput.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Pager);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Code Tools";
            this.Pager.ResumeLayout(false);
            this.tabComments.ResumeLayout(false);
            this.tabEncode.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitComments.Panel1.ResumeLayout(false);
            this.splitComments.Panel1.PerformLayout();
            this.splitComments.Panel2.ResumeLayout(false);
            this.splitComments.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitComments)).EndInit();
            this.splitComments.ResumeLayout(false);
            this.splitEncode.Panel1.ResumeLayout(false);
            this.splitEncode.Panel1.PerformLayout();
            this.splitEncode.Panel2.ResumeLayout(false);
            this.splitEncode.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEncode)).EndInit();
            this.splitEncode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Pager;
        private System.Windows.Forms.TabPage tabComments;
        private System.Windows.Forms.TabPage tabEncode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCommentsExecute;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEncodeExecute;
        private System.Windows.Forms.SplitContainer splitComments;
        private System.Windows.Forms.SplitContainer splitEncode;
        private System.Windows.Forms.TextBox edtCommentsInput;
        private System.Windows.Forms.TextBox edtCommentsOutput;
        private System.Windows.Forms.TextBox edtEncodeInput;
        private System.Windows.Forms.TextBox edtEncodeOutput;
    }
}

