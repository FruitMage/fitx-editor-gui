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

namespace FitX_Editor_GUI
{
    public partial class Add_Script : Form
    {

        public Add_Script()
        {
            InitializeComponent();
        }

        private void addScript_Click(object sender, EventArgs e)
        {
            if (newScript.Text != "")
            {
                Editor editor = new Editor();
                List<string> mlist = File.ReadAllLines(editor.decompiledFighterDir + "\\fighter.mlist").ToList<string>();
                mlist.Add(newScript.Text);
                string[] script = {"MoveDef " + newScript.Text,
                    "   Main() {",
                    "   }\n",
                    "   Effect() {",
                    "   }\n",
                    "   Sound() {",
                    "   }\n",
                    "   Expression() {",
                    "   }"};
                File.WriteAllLines(Directory.GetCurrentDirectory() + editor.decompiledFighterDir + "\\fighter.mlist", mlist);
                File.Create(Directory.GetCurrentDirectory() + editor.decompiledFighterDir + "\\animcmd\\" + newScript.Text + ".acm");
                File.WriteAllLines(Directory.GetCurrentDirectory() + editor.decompiledFighterDir + "\\animcmd\\" + newScript.Text + ".acm", script);
                editor.GetScripts(editor.decompiledFighterDir);
                this.Close();
            }
        }
    }
}
