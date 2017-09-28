using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitX_Editor_GUI
{
    public partial class Decompile_Selector : Form
    {
        public Decompile_Selector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project_Confirm confirmBox = new Project_Confirm();
            confirmBox.Show();
            this.Close();
        }

        private void Decompile_Selector_Load(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            if (editor.weapons.Count > 0)
            {
                for (int i = 0; i < editor.weapons.Count; i++)
                {
                    scripts.Nodes[1].Nodes.Add(editor.weapons[i]);
                    scripts.Nodes[1].Nodes[i].Checked = true;
                }
                scripts.Nodes[1].Checked = true;
            }
            if (editor.weapons.Count == 0)
            {
                scripts.Nodes[1].Checked = false;
            }
        }
    }
}
