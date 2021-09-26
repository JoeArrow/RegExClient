﻿
namespace RegExClient
{
    partial class RegExClientForm
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegExClientForm));
            this.tcForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.cbIgnoreCase = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRegEx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReplaceString = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbReplaceResult = new System.Windows.Forms.TextBox();
            this.tbReplaceRegex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReplaceInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openRegExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRegExAndTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRegExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcForm
            // 
            this.tcForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcForm.Controls.Add(this.tabPage1);
            this.tcForm.Controls.Add(this.tabPage2);
            this.tcForm.Location = new System.Drawing.Point(2, 30);
            this.tcForm.Name = "tcForm";
            this.tcForm.SelectedIndex = 0;
            this.tcForm.Size = new System.Drawing.Size(980, 455);
            this.tcForm.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tbInput);
            this.tabPage1.Controls.Add(this.cbIgnoreCase);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbRegEx);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Regular Expression";
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(7, 81);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(959, 341);
            this.tbInput.TabIndex = 15;
            this.tbInput.Text = "";
            this.tbInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            // 
            // cbIgnoreCase
            // 
            this.cbIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIgnoreCase.Checked = true;
            this.cbIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreCase.Location = new System.Drawing.Point(880, 58);
            this.cbIgnoreCase.Name = "cbIgnoreCase";
            this.cbIgnoreCase.Size = new System.Drawing.Size(86, 17);
            this.cbIgnoreCase.TabIndex = 1;
            this.cbIgnoreCase.Text = "Ignore Case";
            this.cbIgnoreCase.CheckedChanged += new System.EventHandler(this.OnOptionsChange);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text to Test:";
            // 
            // tbRegEx
            // 
            this.tbRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegEx.Location = new System.Drawing.Point(6, 23);
            this.tbRegEx.Name = "tbRegEx";
            this.tbRegEx.Size = new System.Drawing.Size(960, 29);
            this.tbRegEx.TabIndex = 2;
            this.tbRegEx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Regular Expression:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbReplaceString);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbReplaceResult);
            this.tabPage2.Controls.Add(this.tbReplaceRegex);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbReplaceInput);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Regex Replace";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Replacement String";
            // 
            // tbReplaceString
            // 
            this.tbReplaceString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplaceString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReplaceString.Location = new System.Drawing.Point(6, 106);
            this.tbReplaceString.Name = "tbReplaceString";
            this.tbReplaceString.Size = new System.Drawing.Size(841, 26);
            this.tbReplaceString.TabIndex = 15;
            this.tbReplaceString.Text = "\"";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(795, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "E&xit";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(358, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "&Process";
            this.button2.Click += new System.EventHandler(this.OnRegexReplace);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Output";
            // 
            // tbReplaceResult
            // 
            this.tbReplaceResult.AcceptsReturn = true;
            this.tbReplaceResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplaceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReplaceResult.Location = new System.Drawing.Point(6, 158);
            this.tbReplaceResult.Multiline = true;
            this.tbReplaceResult.Name = "tbReplaceResult";
            this.tbReplaceResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReplaceResult.Size = new System.Drawing.Size(776, 200);
            this.tbReplaceResult.TabIndex = 11;
            // 
            // tbReplaceRegex
            // 
            this.tbReplaceRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplaceRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReplaceRegex.Location = new System.Drawing.Point(6, 63);
            this.tbReplaceRegex.Name = "tbReplaceRegex";
            this.tbReplaceRegex.Size = new System.Drawing.Size(841, 26);
            this.tbReplaceRegex.TabIndex = 9;
            this.tbReplaceRegex.Text = "\"[\"\"]+\"";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Regular Expression";
            // 
            // tbReplaceInput
            // 
            this.tbReplaceInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplaceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReplaceInput.Location = new System.Drawing.Point(6, 20);
            this.tbReplaceInput.Name = "tbReplaceInput";
            this.tbReplaceInput.Size = new System.Drawing.Size(841, 26);
            this.tbReplaceInput.TabIndex = 5;
            this.tbReplaceInput.Text = "{ \"Test\" : \"\"\"{{Var}}\"\"\"\", \"Test2\" : \"{{OKAY}}\" }";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Text to Test";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideMatchesToolStripMenuItem,
            this.clearInputToolStripMenuItem,
            this.toolStripSeparator2,
            this.openRegExToolStripMenuItem,
            this.openRegExAndTextToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveRegExToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // hideMatchesToolStripMenuItem
            // 
            this.hideMatchesToolStripMenuItem.Name = "hideMatchesToolStripMenuItem";
            this.hideMatchesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hideMatchesToolStripMenuItem.Text = "Hide &Matches";
            this.hideMatchesToolStripMenuItem.Click += new System.EventHandler(this.OnHideMatches);
            // 
            // clearInputToolStripMenuItem
            // 
            this.clearInputToolStripMenuItem.Name = "clearInputToolStripMenuItem";
            this.clearInputToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.clearInputToolStripMenuItem.Text = "C&lear Input";
            this.clearInputToolStripMenuItem.Click += new System.EventHandler(this.ClearInput);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // openRegExToolStripMenuItem
            // 
            this.openRegExToolStripMenuItem.Name = "openRegExToolStripMenuItem";
            this.openRegExToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openRegExToolStripMenuItem.Text = "O&pen RegEx";
            this.openRegExToolStripMenuItem.Click += new System.EventHandler(this.OnOpenRegex);
            // 
            // openRegExAndTextToolStripMenuItem
            // 
            this.openRegExAndTextToolStripMenuItem.Name = "openRegExAndTextToolStripMenuItem";
            this.openRegExAndTextToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openRegExAndTextToolStripMenuItem.Text = "&Open RegEx and Text";
            this.openRegExAndTextToolStripMenuItem.Click += new System.EventHandler(this.OnOpenRegex);
            // 
            // saveRegExToolStripMenuItem
            // 
            this.saveRegExToolStripMenuItem.Name = "saveRegExToolStripMenuItem";
            this.saveRegExToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveRegExToolStripMenuItem.Text = "&Save";
            this.saveRegExToolStripMenuItem.Click += new System.EventHandler(this.OnSaveRegEx);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAbout);
            // 
            // RegExClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(984, 486);
            this.Controls.Add(this.tcForm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegExClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegEx Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.tcForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TabControl tcForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox tbInput;
        private System.Windows.Forms.CheckBox cbIgnoreCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRegEx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReplaceString;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbReplaceResult;
        private System.Windows.Forms.TextBox tbReplaceRegex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReplaceInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMatchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRegExToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRegExToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRegExAndTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

