namespace FitX_Editor_GUI
{
    partial class Command_List
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdList = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.argTypes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.argCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.args = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.generator = new System.Windows.Forms.DataGridView();
            this.genCmd = new System.Windows.Forms.Button();
            this.genArgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generator)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdList);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // cmdList
            // 
            this.cmdList.Location = new System.Drawing.Point(7, 19);
            this.cmdList.Name = "cmdList";
            this.cmdList.Size = new System.Drawing.Size(245, 429);
            this.cmdList.TabIndex = 0;
            this.cmdList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.cmdList_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.desc);
            this.groupBox2.Controls.Add(this.argTypes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.argCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.args);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmdName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmdID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(277, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 454);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.SystemColors.Control;
            this.desc.ForeColor = System.Drawing.Color.Black;
            this.desc.Location = new System.Drawing.Point(10, 192);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Size = new System.Drawing.Size(352, 255);
            this.desc.TabIndex = 11;
            // 
            // argTypes
            // 
            this.argTypes.BackColor = System.Drawing.SystemColors.Control;
            this.argTypes.ForeColor = System.Drawing.Color.Black;
            this.argTypes.Location = new System.Drawing.Point(10, 114);
            this.argTypes.Name = "argTypes";
            this.argTypes.ReadOnly = true;
            this.argTypes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.argTypes.Size = new System.Drawing.Size(352, 20);
            this.argTypes.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Argument Types";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // argCount
            // 
            this.argCount.BackColor = System.Drawing.SystemColors.Control;
            this.argCount.ForeColor = System.Drawing.Color.Black;
            this.argCount.Location = new System.Drawing.Point(10, 75);
            this.argCount.Name = "argCount";
            this.argCount.ReadOnly = true;
            this.argCount.Size = new System.Drawing.Size(100, 20);
            this.argCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Argument Count";
            // 
            // args
            // 
            this.args.BackColor = System.Drawing.SystemColors.Control;
            this.args.ForeColor = System.Drawing.Color.Black;
            this.args.Location = new System.Drawing.Point(10, 153);
            this.args.Name = "args";
            this.args.ReadOnly = true;
            this.args.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.args.Size = new System.Drawing.Size(352, 20);
            this.args.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arguments";
            // 
            // cmdName
            // 
            this.cmdName.BackColor = System.Drawing.SystemColors.Control;
            this.cmdName.ForeColor = System.Drawing.Color.Black;
            this.cmdName.Location = new System.Drawing.Point(105, 36);
            this.cmdName.Name = "cmdName";
            this.cmdName.ReadOnly = true;
            this.cmdName.Size = new System.Drawing.Size(257, 20);
            this.cmdName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // cmdID
            // 
            this.cmdID.BackColor = System.Drawing.SystemColors.Control;
            this.cmdID.ForeColor = System.Drawing.Color.Black;
            this.cmdID.Location = new System.Drawing.Point(10, 36);
            this.cmdID.Name = "cmdID";
            this.cmdID.ReadOnly = true;
            this.cmdID.Size = new System.Drawing.Size(72, 20);
            this.cmdID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.genCmd);
            this.groupBox3.Controls.Add(this.generator);
            this.groupBox3.Location = new System.Drawing.Point(651, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 454);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generator";
            // 
            // generator
            // 
            this.generator.AllowUserToAddRows = false;
            this.generator.AllowUserToDeleteRows = false;
            this.generator.AllowUserToOrderColumns = true;
            this.generator.AllowUserToResizeColumns = false;
            this.generator.AllowUserToResizeRows = false;
            this.generator.BackgroundColor = System.Drawing.Color.White;
            this.generator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genArgs,
            this.genParam});
            this.generator.Location = new System.Drawing.Point(6, 19);
            this.generator.MultiSelect = false;
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(268, 391);
            this.generator.TabIndex = 0;
            // 
            // genCmd
            // 
            this.genCmd.Location = new System.Drawing.Point(6, 417);
            this.genCmd.Name = "genCmd";
            this.genCmd.Size = new System.Drawing.Size(268, 30);
            this.genCmd.TabIndex = 1;
            this.genCmd.Text = "Generate Command";
            this.genCmd.UseVisualStyleBackColor = true;
            this.genCmd.Click += new System.EventHandler(this.genCmd_Click);
            // 
            // genArgs
            // 
            this.genArgs.Frozen = true;
            this.genArgs.HeaderText = "Arguments";
            this.genArgs.Name = "genArgs";
            this.genArgs.ReadOnly = true;
            this.genArgs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genArgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.genArgs.Width = 125;
            // 
            // genParam
            // 
            this.genParam.Frozen = true;
            this.genParam.HeaderText = "Values";
            this.genParam.Name = "genParam";
            this.genParam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genParam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Command_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 474);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Command_List";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command List";
            this.Load += new System.EventHandler(this.Command_List_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cmdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmdID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView cmdList;
        private System.Windows.Forms.TextBox argCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox argTypes;
        private System.Windows.Forms.TextBox args;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView generator;
        private System.Windows.Forms.Button genCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn genArgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn genParam;
    }
}