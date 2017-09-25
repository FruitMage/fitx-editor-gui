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
    public partial class Project_Confirm : Form
    {

        public Project_Confirm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editor mainform = new Editor();
            mainform.directory = outputDir.Text;
            mainform.Decompile();
            this.Close();
        }
    }
}
