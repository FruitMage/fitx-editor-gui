﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FitX_Editor_GUI
{
    public partial class Add_Script : Form
    {
        public string dir;

        public Add_Script()
        {
            InitializeComponent();
        }

        private void addScript_Click(object sender, EventArgs e)
        {
            if (newScript.Text != "")
            {
                Editor editor = new Editor();
                List<string> mlist = File.ReadAllLines(dir + "\\fighter.mlist").ToList<string>();
                if (!mlist.Contains(newScript.Text))
                {
                    mlist.Add(newScript.Text);
                    string[] script = {"MoveDef " + newScript.Text,
                    "{",
                    "	Main()",
                    "   	{",
                    "   	}\n",
                    "   	Effect()",
                    "   	{",
                    "   	}\n",
                    "   	Sound()",
                    "   	{",
                    "   	}\n",
                    "   	Expression()",
                    "   	{",
                    "   	}",
                    "}"};
                    File.WriteAllLines(dir + "\\fighter.mlist", mlist);
                    File.WriteAllLines(dir + "\\animcmd\\" + newScript.Text + ".acm", script);
                    editor.GetScripts(dir);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Script already exists!", "FitX Text Editor");
                }
            }
            else
            {
                MessageBox.Show("Script Name cannot be empty.", "FitX Text Editor");
            }
        }
    }
}
