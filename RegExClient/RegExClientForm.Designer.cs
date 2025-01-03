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
            this.tpRegex = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbRegEx = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.cbWrap = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMultiline = new System.Windows.Forms.CheckBox();
            this.cbIgnoreCase = new System.Windows.Forms.CheckBox();
            this.tpGroups = new System.Windows.Forms.TabPage();
            this.rtbGroups = new System.Windows.Forms.RichTextBox();
            this.tpReplace = new System.Windows.Forms.TabPage();
            this.pbToggleOrientation = new System.Windows.Forms.PictureBox();
            this.cbReplaceMultiline = new System.Windows.Forms.CheckBox();
            this.cbWordWrap = new System.Windows.Forms.CheckBox();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.tbReplaceInput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReplaceResult = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReplaceString = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbReplaceRegex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openRegExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRegExAndTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveRegExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tcForm.SuspendLayout();
            this.tpRegex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tpGroups.SuspendLayout();
            this.tpReplace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbToggleOrientation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcForm
            // 
            this.tcForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcForm.Controls.Add(this.tpRegex);
            this.tcForm.Controls.Add(this.tpGroups);
            this.tcForm.Controls.Add(this.tpReplace);
            this.tcForm.Location = new System.Drawing.Point(2, 53);
            this.tcForm.Name = "tcForm";
            this.tcForm.SelectedIndex = 0;
            this.tcForm.Size = new System.Drawing.Size(986, 462);
            this.tcForm.TabIndex = 10;
            this.tcForm.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnTabSelect);
            // 
            // tpRegex
            // 
            this.tpRegex.BackColor = System.Drawing.SystemColors.Control;
            this.tpRegex.Controls.Add(this.splitContainer2);
            this.tpRegex.Location = new System.Drawing.Point(4, 22);
            this.tpRegex.Name = "tpRegex";
            this.tpRegex.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegex.Size = new System.Drawing.Size(978, 436);
            this.tpRegex.TabIndex = 0;
            this.tpRegex.Text = "Regular Expression";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbRegEx);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbInput);
            this.splitContainer2.Panel2.Controls.Add(this.cbWrap);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.cbMultiline);
            this.splitContainer2.Panel2.Controls.Add(this.cbIgnoreCase);
            this.splitContainer2.Size = new System.Drawing.Size(978, 436);
            this.splitContainer2.SplitterDistance = 51;
            this.splitContainer2.TabIndex = 19;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitterMoved);
            // 
            // tbRegEx
            // 
            this.tbRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegEx.Location = new System.Drawing.Point(3, 22);
            this.tbRegEx.Multiline = false;
            this.tbRegEx.Name = "tbRegEx";
            this.tbRegEx.Size = new System.Drawing.Size(969, 26);
            this.tbRegEx.TabIndex = 18;
            this.tbRegEx.Text = "";
            this.tbRegEx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Regular Expression:";
            // 
            // tbInput
            // 
            this.tbInput.AcceptsTab = true;
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(3, 28);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(961, 349);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "";
            this.tbInput.WordWrap = false;
            this.tbInput.TextChanged += new System.EventHandler(this.OnInputTextChanged);
            this.tbInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            this.tbInput.Validated += new System.EventHandler(this.OnTextToTestValidated);
            // 
            // cbWrap
            // 
            this.cbWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWrap.AutoSize = true;
            this.cbWrap.Location = new System.Drawing.Point(728, 7);
            this.cbWrap.Name = "cbWrap";
            this.cbWrap.Size = new System.Drawing.Size(81, 17);
            this.cbWrap.TabIndex = 17;
            this.cbWrap.Text = "Word Wrap";
            this.cbWrap.UseVisualStyleBackColor = true;
            this.cbWrap.CheckedChanged += new System.EventHandler(this.OnWrapChange);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text to Test:";
            // 
            // cbMultiline
            // 
            this.cbMultiline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMultiline.Checked = true;
            this.cbMultiline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMultiline.Location = new System.Drawing.Point(815, 7);
            this.cbMultiline.Name = "cbMultiline";
            this.cbMultiline.Size = new System.Drawing.Size(69, 19);
            this.cbMultiline.TabIndex = 16;
            this.cbMultiline.Text = "Multiline";
            this.cbMultiline.CheckedChanged += new System.EventHandler(this.OnOptionsChange);
            // 
            // cbIgnoreCase
            // 
            this.cbIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIgnoreCase.Checked = true;
            this.cbIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreCase.Location = new System.Drawing.Point(886, 7);
            this.cbIgnoreCase.Name = "cbIgnoreCase";
            this.cbIgnoreCase.Size = new System.Drawing.Size(84, 19);
            this.cbIgnoreCase.TabIndex = 1;
            this.cbIgnoreCase.Text = "Ignore Case";
            this.cbIgnoreCase.CheckedChanged += new System.EventHandler(this.OnOptionsChange);
            // 
            // tpGroups
            // 
            this.tpGroups.Controls.Add(this.rtbGroups);
            this.tpGroups.Location = new System.Drawing.Point(4, 22);
            this.tpGroups.Name = "tpGroups";
            this.tpGroups.Size = new System.Drawing.Size(978, 436);
            this.tpGroups.TabIndex = 2;
            this.tpGroups.Text = "Capture Groups";
            this.tpGroups.UseVisualStyleBackColor = true;
            // 
            // rtbGroups
            // 
            this.rtbGroups.AcceptsTab = true;
            this.rtbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGroups.Location = new System.Drawing.Point(0, 0);
            this.rtbGroups.Name = "rtbGroups";
            this.rtbGroups.ReadOnly = true;
            this.rtbGroups.Size = new System.Drawing.Size(975, 433);
            this.rtbGroups.TabIndex = 2;
            this.rtbGroups.Text = "";
            this.rtbGroups.WordWrap = false;
            // 
            // tpReplace
            // 
            this.tpReplace.BackColor = System.Drawing.SystemColors.Control;
            this.tpReplace.Controls.Add(this.pbToggleOrientation);
            this.tpReplace.Controls.Add(this.cbReplaceMultiline);
            this.tpReplace.Controls.Add(this.cbWordWrap);
            this.tpReplace.Controls.Add(this.spContainer);
            this.tpReplace.Controls.Add(this.label7);
            this.tpReplace.Controls.Add(this.tbReplaceString);
            this.tpReplace.Controls.Add(this.button2);
            this.tpReplace.Controls.Add(this.tbReplaceRegex);
            this.tpReplace.Controls.Add(this.label5);
            this.tpReplace.Location = new System.Drawing.Point(4, 22);
            this.tpReplace.Name = "tpReplace";
            this.tpReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tpReplace.Size = new System.Drawing.Size(978, 436);
            this.tpReplace.TabIndex = 1;
            this.tpReplace.Text = "Regex Replace";
            // 
            // pbToggleOrientation
            // 
            this.pbToggleOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbToggleOrientation.Image = global::RegExClient.Properties.Resources.OrientToggle;
            this.pbToggleOrientation.Location = new System.Drawing.Point(930, 393);
            this.pbToggleOrientation.Name = "pbToggleOrientation";
            this.pbToggleOrientation.Size = new System.Drawing.Size(40, 36);
            this.pbToggleOrientation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbToggleOrientation.TabIndex = 18;
            this.pbToggleOrientation.TabStop = false;
            this.pbToggleOrientation.Click += new System.EventHandler(this.OnToggleOrientation);
            // 
            // cbReplaceMultiline
            // 
            this.cbReplaceMultiline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReplaceMultiline.Checked = true;
            this.cbReplaceMultiline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReplaceMultiline.Location = new System.Drawing.Point(901, 110);
            this.cbReplaceMultiline.Name = "cbReplaceMultiline";
            this.cbReplaceMultiline.Size = new System.Drawing.Size(69, 17);
            this.cbReplaceMultiline.TabIndex = 8;
            this.cbReplaceMultiline.Text = "Multiline";
            // 
            // cbWordWrap
            // 
            this.cbWordWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWordWrap.AutoSize = true;
            this.cbWordWrap.Location = new System.Drawing.Point(844, 393);
            this.cbWordWrap.Name = "cbWordWrap";
            this.cbWordWrap.Size = new System.Drawing.Size(81, 17);
            this.cbWordWrap.TabIndex = 7;
            this.cbWordWrap.Text = "Word Wrap";
            this.cbWordWrap.UseVisualStyleBackColor = true;
            this.cbWordWrap.CheckedChanged += new System.EventHandler(this.OnToggleWordWrap);
            // 
            // spContainer
            // 
            this.spContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spContainer.Location = new System.Drawing.Point(6, 133);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.tbReplaceInput);
            this.spContainer.Panel1.Controls.Add(this.label4);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.Controls.Add(this.label2);
            this.spContainer.Panel2.Controls.Add(this.tbReplaceResult);
            this.spContainer.Size = new System.Drawing.Size(964, 254);
            this.spContainer.SplitterDistance = 456;
            this.spContainer.TabIndex = 17;
            // 
            // tbReplaceInput
            // 
            this.tbReplaceInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplaceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReplaceInput.Location = new System.Drawing.Point(0, 16);
            this.tbReplaceInput.Name = "tbReplaceInput";
            this.tbReplaceInput.Size = new System.Drawing.Size(456, 238);
            this.tbReplaceInput.TabIndex = 4;
            this.tbReplaceInput.Text = "";
            this.tbReplaceInput.WordWrap = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Input Text:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output Text:";
            // 
            // tbReplaceResult
            // 
            this.tbReplaceResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplaceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReplaceResult.Location = new System.Drawing.Point(1, 16);
            this.tbReplaceResult.Name = "tbReplaceResult";
            this.tbReplaceResult.Size = new System.Drawing.Size(494, 238);
            this.tbReplaceResult.TabIndex = 6;
            this.tbReplaceResult.Text = "";
            this.tbReplaceResult.WordWrap = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Replacement String:";
            // 
            // tbReplaceString
            // 
            this.tbReplaceString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplaceString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReplaceString.Location = new System.Drawing.Point(6, 81);
            this.tbReplaceString.Name = "tbReplaceString";
            this.tbReplaceString.Size = new System.Drawing.Size(964, 26);
            this.tbReplaceString.TabIndex = 3;
            this.tbReplaceString.TextChanged += new System.EventHandler(this.OnReplacementStringChanged);
            this.tbReplaceString.Validated += new System.EventHandler(this.OnReplaceStringValidated);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(434, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Replace";
            this.button2.Click += new System.EventHandler(this.OnRegexReplace);
            // 
            // tbReplaceRegex
            // 
            this.tbReplaceRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplaceRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReplaceRegex.Location = new System.Drawing.Point(8, 31);
            this.tbReplaceRegex.Name = "tbReplaceRegex";
            this.tbReplaceRegex.Size = new System.Drawing.Size(962, 26);
            this.tbReplaceRegex.TabIndex = 2;
            this.tbReplaceRegex.TextChanged += new System.EventHandler(this.OnReplaceRegExValidated);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Regular Expression:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
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
            this.saveAsToolStripMenuItem,
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
            this.clearInputToolStripMenuItem.Text = "&New";
            this.clearInputToolStripMenuItem.Click += new System.EventHandler(this.OnNew);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // saveRegExToolStripMenuItem
            // 
            this.saveRegExToolStripMenuItem.Name = "saveRegExToolStripMenuItem";
            this.saveRegExToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveRegExToolStripMenuItem.Text = "&Save";
            this.saveRegExToolStripMenuItem.Click += new System.EventHandler(this.OnSaveRegEx);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.OnSaveAs);
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.helpToolStripMenuItem1.Text = "RegEx Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.OnHelp);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAbout);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(988, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.OnNew);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OnOpenRegex);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.OnSaveRegEx);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.OnHelp);
            // 
            // RegExClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(988, 516);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tcForm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(590, 398);
            this.Name = "RegExClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reggie (RegEx Client)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.tcForm.ResumeLayout(false);
            this.tpRegex.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tpGroups.ResumeLayout(false);
            this.tpReplace.ResumeLayout(false);
            this.tpReplace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbToggleOrientation)).EndInit();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TabControl tcForm;
        private System.Windows.Forms.TabPage tpRegex;
        private System.Windows.Forms.RichTextBox tbInput;
        private System.Windows.Forms.CheckBox cbIgnoreCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpReplace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReplaceString;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbReplaceRegex;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.CheckBox cbMultiline;
        private System.Windows.Forms.CheckBox cbWordWrap;
        private System.Windows.Forms.CheckBox cbReplaceMultiline;
        private System.Windows.Forms.RichTextBox tbReplaceInput;
        private System.Windows.Forms.RichTextBox tbReplaceResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.CheckBox cbWrap;
        private System.Windows.Forms.RichTextBox tbRegEx;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbToggleOrientation;
        private System.Windows.Forms.TabPage tpGroups;
        private System.Windows.Forms.RichTextBox rtbGroups;
    }
}

