namespace FitX_Editor_GUI
{
    partial class Editor
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Body");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Weapons");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.compiledFighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompiledFighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandListButton = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsContainer = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sortAlphabet = new System.Windows.Forms.RadioButton();
            this.sortAcmd = new System.Windows.Forms.RadioButton();
            this.animcmd = new System.Windows.Forms.TreeView();
            this.textEditorContainer = new System.Windows.Forms.GroupBox();
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.scriptsContainer.SuspendLayout();
            this.textEditorContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveFile});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(37, 20);
            this.file.Text = "File";
            // 
            // openFile
            // 
            this.openFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compiledFighterToolStripMenuItem,
            this.decompiledFighterToolStripMenuItem});
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(146, 22);
            this.openFile.Text = "Open";
            // 
            // compiledFighterToolStripMenuItem
            // 
            this.compiledFighterToolStripMenuItem.Name = "compiledFighterToolStripMenuItem";
            this.compiledFighterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.compiledFighterToolStripMenuItem.Text = "Compiled Fighter";
            this.compiledFighterToolStripMenuItem.Click += new System.EventHandler(this.openFile_Click);
            // 
            // decompiledFighterToolStripMenuItem
            // 
            this.decompiledFighterToolStripMenuItem.Name = "decompiledFighterToolStripMenuItem";
            this.decompiledFighterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.decompiledFighterToolStripMenuItem.Text = "Decompiled Fighter";
            this.decompiledFighterToolStripMenuItem.Click += new System.EventHandler(this.decompiledFighterToolStripMenuItem_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFile.Size = new System.Drawing.Size(146, 22);
            this.saveFile.Text = "Save";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandListButton});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // commandListButton
            // 
            this.commandListButton.Name = "commandListButton";
            this.commandListButton.Size = new System.Drawing.Size(152, 22);
            this.commandListButton.Text = "Command List";
            this.commandListButton.Click += new System.EventHandler(this.commandListButton_Click);
            // 
            // scriptsContainer
            // 
            this.scriptsContainer.Controls.Add(this.button2);
            this.scriptsContainer.Controls.Add(this.button1);
            this.scriptsContainer.Controls.Add(this.label1);
            this.scriptsContainer.Controls.Add(this.sortAlphabet);
            this.scriptsContainer.Controls.Add(this.sortAcmd);
            this.scriptsContainer.Controls.Add(this.animcmd);
            this.scriptsContainer.Enabled = false;
            this.scriptsContainer.Location = new System.Drawing.Point(968, 28);
            this.scriptsContainer.Name = "scriptsContainer";
            this.scriptsContainer.Size = new System.Drawing.Size(228, 609);
            this.scriptsContainer.TabIndex = 1;
            this.scriptsContainer.TabStop = false;
            this.scriptsContainer.Text = "Scripts";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 575);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove Script";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Script";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sorting Style:";
            // 
            // sortAlphabet
            // 
            this.sortAlphabet.AutoSize = true;
            this.sortAlphabet.Location = new System.Drawing.Point(9, 581);
            this.sortAlphabet.Name = "sortAlphabet";
            this.sortAlphabet.Size = new System.Drawing.Size(83, 17);
            this.sortAlphabet.TabIndex = 2;
            this.sortAlphabet.Text = "Alphabetical";
            this.sortAlphabet.UseVisualStyleBackColor = true;
            this.sortAlphabet.CheckedChanged += new System.EventHandler(this.sortAlphabet_CheckedChanged);
            // 
            // sortAcmd
            // 
            this.sortAcmd.AutoSize = true;
            this.sortAcmd.Checked = true;
            this.sortAcmd.Location = new System.Drawing.Point(9, 560);
            this.sortAcmd.Name = "sortAcmd";
            this.sortAcmd.Size = new System.Drawing.Size(91, 17);
            this.sortAcmd.TabIndex = 1;
            this.sortAcmd.TabStop = true;
            this.sortAcmd.Text = "Motion.mtable";
            this.sortAcmd.UseVisualStyleBackColor = true;
            // 
            // animcmd
            // 
            this.animcmd.Location = new System.Drawing.Point(7, 19);
            this.animcmd.Name = "animcmd";
            treeNode1.Name = "bodyEntries";
            treeNode1.Text = "Body";
            treeNode2.Name = "weaponEntries";
            treeNode2.Text = "Weapons";
            this.animcmd.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.animcmd.Size = new System.Drawing.Size(215, 518);
            this.animcmd.TabIndex = 0;
            this.animcmd.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.animcmd_AfterSelect);
            // 
            // textEditorContainer
            // 
            this.textEditorContainer.Controls.Add(this.textEditor);
            this.textEditorContainer.Enabled = false;
            this.textEditorContainer.Location = new System.Drawing.Point(13, 28);
            this.textEditorContainer.Name = "textEditorContainer";
            this.textEditorContainer.Size = new System.Drawing.Size(949, 609);
            this.textEditorContainer.TabIndex = 2;
            this.textEditorContainer.TabStop = false;
            this.textEditorContainer.Text = "Editor";
            // 
            // textEditor
            // 
            this.textEditor.AcceptsTab = true;
            this.textEditor.DetectUrls = false;
            this.textEditor.Location = new System.Drawing.Point(7, 19);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(936, 584);
            this.textEditor.TabIndex = 1;
            this.textEditor.Text = "";
            this.textEditor.WordWrap = false;
            this.textEditor.TextChanged += new System.EventHandler(this.textEditor_TextChanged);
            // 
            // Editor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 649);
            this.Controls.Add(this.textEditorContainer);
            this.Controls.Add(this.scriptsContainer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitX Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scriptsContainer.ResumeLayout(false);
            this.scriptsContainer.PerformLayout();
            this.textEditorContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.GroupBox scriptsContainer;
        private System.Windows.Forms.TreeView animcmd;
        private System.Windows.Forms.GroupBox textEditorContainer;
        private System.Windows.Forms.RichTextBox textEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sortAlphabet;
        private System.Windows.Forms.RadioButton sortAcmd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem compiledFighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompiledFighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandListButton;
    }
}

