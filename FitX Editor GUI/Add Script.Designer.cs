namespace FitX_Editor_GUI
{
    partial class Add_Script
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
            this.addScript = new System.Windows.Forms.Button();
            this.newScript = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addScript
            // 
            this.addScript.Location = new System.Drawing.Point(104, 61);
            this.addScript.Name = "addScript";
            this.addScript.Size = new System.Drawing.Size(75, 23);
            this.addScript.TabIndex = 5;
            this.addScript.Text = "Continue";
            this.addScript.UseVisualStyleBackColor = true;
            this.addScript.Click += new System.EventHandler(this.addScript_Click);
            // 
            // newScript
            // 
            this.newScript.Location = new System.Drawing.Point(4, 32);
            this.newScript.Name = "newScript";
            this.newScript.Size = new System.Drawing.Size(275, 20);
            this.newScript.TabIndex = 4;
            this.newScript.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Script Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_Script
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 90);
            this.Controls.Add(this.addScript);
            this.Controls.Add(this.newScript);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Script";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Script";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addScript;
        private System.Windows.Forms.TextBox newScript;
        private System.Windows.Forms.Label label1;
    }
}