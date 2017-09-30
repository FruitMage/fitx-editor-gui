using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FitX_Editor_GUI
{
    public partial class Editor : Form
    {
        public string directory = "";
        string motion = "";
        public List<string> weapons = new List<string>();
        public string bodyAcmd = "";
        public string decompiledFighterDir = "";

        public Editor()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFighter = new CommonOpenFileDialog();
            openFighter.IsFolderPicker = true;
            openFighter.EnsurePathExists = true;
            if (openFighter.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (Directory.Exists(openFighter.FileName + "\\motion") && Directory.Exists(openFighter.FileName + "\\script\\animcmd\\body"))
                {
                    if (Directory.Exists(openFighter.FileName + "\\script\\animcmd\\weapon"))
                    {
                        for (int i = 0; i < Directory.GetDirectories(openFighter.FileName + "\\script\\animcmd\\weapon").Length; i++)
                        {
                            weapons.Add(Directory.GetDirectories(openFighter.FileName + "\\script\\animcmd\\weapon")[i] + "\\motion.mtable");
                            Console.WriteLine(weapons[i]);
                        }
                    }
                    bodyAcmd = openFighter.FileName + "\\script\\animcmd\\body\\motion.mtable";
                    motion = openFighter.FileName + "\\motion";
                    Decompile_Selector decomp = new Decompile_Selector();
                    decomp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Not a valid folder", "FitX Text Editor");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool fitd_exists = false;
            bool fitc_exists = false;
            foreach (string file in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                if (file.ToLower() == Directory.GetCurrentDirectory().ToLower() + "\\fitd.exe")
                {
                    fitd_exists = true;
                }
                if (file.ToLower() == Directory.GetCurrentDirectory().ToLower() + "\\fitc.exe")
                {
                    fitc_exists = true;
                }
            }
            if (fitd_exists == false)
            {
                MessageBox.Show("FitD.exe does not exist!", "FitX Text Editor");
            }
            if (fitc_exists == false)
            {
                MessageBox.Show("FitC.exe does not exist!", "FitX Text Editor");
            }
            if (fitd_exists == false || fitc_exists == false)
            {
                MessageBox.Show("Due to FitX not being present in this folder, the application will now close.", "FitX Text Editor");
                Application.Exit();
            }
        }

        public void Decompile()
        {
            foreach (string acmd in weapons)
            {
                Process.Start("FITD.exe", "-m \"" + motion + "\" -o \"" + directory + "\\weapons\\" + acmd + "\" \"" + acmd + "\"");
                Console.WriteLine("FITD.exe -m \"" + motion + "\" -o \"" + directory + "\\weapons\\" + acmd + "\" \"" + acmd + "\"");
            }
            Process.Start("FITD.exe", "-m \"" + motion + "\" -o \"" + directory + "\\" + bodyAcmd + "\" \"" + bodyAcmd + "\"");
        }

        public void GetScripts(string directory)
        {
            animcmd.Nodes[0].Nodes.Clear();
            string[] entries = File.ReadAllLines(directory + "\\fighter.mlist");
            for (int i = 0; i < entries.Length; i++)
            {
                animcmd.Nodes[0].Nodes.Add(i.ToString("X") + " - " + entries[i]);
                animcmd.Nodes[0].Nodes[i].Name = entries[i];
            }
            animcmd.Nodes[0].Expand();
            scriptsContainer.Enabled = true;
            textEditorContainer.Enabled = true;
        }

        private void decompiledFighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFighter = new CommonOpenFileDialog();
            openFighter.IsFolderPicker = true;
            openFighter.EnsurePathExists = true;
            if (openFighter.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (File.Exists(openFighter.FileName + "\\fighter.mlist") && Directory.Exists(openFighter.FileName + "\\animcmd"))
                {
                    decompiledFighterDir = openFighter.FileName;
                    GetScripts(openFighter.FileName);
                }
                else
                {
                    MessageBox.Show("Not a valid folder", "FitX Text Editor");
                }
            }
        }

        private void animcmd_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!animcmd.SelectedNode.Name.EndsWith("Entries"))
            {
                if (File.Exists(decompiledFighterDir + "\\animcmd\\" + animcmd.SelectedNode.Name + ".acm"))
                {
                    Console.WriteLine(decompiledFighterDir + "\\animcmd\\" + animcmd.SelectedNode.Name + ".acm");
                    textEditor.Lines = File.ReadAllLines(decompiledFighterDir + "\\animcmd\\" + animcmd.SelectedNode.Name + ".acm");
                }
                else
                {
                    MessageBox.Show("Script does not exist!", "FitX Text Editor");
                }
            }
        }

        private void sortAlphabet_CheckedChanged(object sender, EventArgs e)
        {
            if (sortAlphabet.Checked == true)
            {
                animcmd.Nodes[0].Nodes.Clear();
                for (int i = 0; i < Directory.GetFiles(decompiledFighterDir + "\\animcmd").Length; i++)
                {
                    animcmd.Nodes[0].Nodes.Add(Directory.GetFiles(decompiledFighterDir + "\\animcmd")[i].Replace(".acm", "").Replace(decompiledFighterDir + "\\animcmd\\", ""));
                    animcmd.Nodes[0].Nodes[i].Name = Directory.GetFiles(decompiledFighterDir + "\\animcmd")[i].Replace(".acm", "").Replace(decompiledFighterDir + "\\animcmd\\", "");
                }
            }
            if (sortAlphabet.Checked == false)
            {
                GetScripts(decompiledFighterDir);
            }
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllLines(decompiledFighterDir + "\\animcmd\\" + animcmd.SelectedNode.Name + ".acm", textEditor.Lines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Script addScript = new Add_Script();
            addScript.Show();
        }

        private void commandListButton_Click(object sender, EventArgs e)
        {
            Command_List cmdList = new Command_List();
            cmdList.Show();
        }

        public void AddScript()
        {
            Console.WriteLine(decompiledFighterDir);
            Add_Script addScript = new Add_Script();
            List<string> mlist = File.ReadAllLines(decompiledFighterDir + "\\fighter.mlist").ToList<string>();
            mlist.Add(addScript.newScript.Text);
            string[] script = {"MoveDef " + addScript.newScript.Text,
                    "   Main()",
                    "   {",
                    "   }\n",
                    "   Effect()",
                    "   {",
                    "   }\n",
                    "   Sound()",
                    "   {",
                    "   }\n",
                    "   Expression()",
                    "   {",
                    "   }"};
            File.WriteAllLines(Directory.GetCurrentDirectory() + decompiledFighterDir + "\\fighter.mlist", mlist);
            File.Create(Directory.GetCurrentDirectory() + decompiledFighterDir + "\\animcmd\\" + addScript.newScript.Text + ".acm");
            File.WriteAllLines(Directory.GetCurrentDirectory() + decompiledFighterDir + "\\animcmd\\" + addScript.newScript.Text + ".acm", script);
            GetScripts(decompiledFighterDir);
            addScript.Close();
        }
    }
}
