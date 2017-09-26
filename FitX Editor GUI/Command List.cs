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
using SALT;

namespace FitX_Editor_GUI
{
    public partial class Command_List : Form
    {
        Dictionary<uint, string> commandNames = SALT.Moveset.AnimCMD.ACMD_INFO.CMD_NAMES;
        Dictionary<uint, string> commandDescriptions = SALT.Moveset.AnimCMD.ACMD_INFO.CMD_DESC;
        Dictionary<uint, int> commandArgCount = SALT.Moveset.AnimCMD.ACMD_INFO.CMD_SIZES;
        Dictionary<uint, string> commandArgTypes = SALT.Moveset.AnimCMD.ACMD_INFO.PARAM_FORMAT;
        Dictionary<uint, string> commandArgs = SALT.Moveset.AnimCMD.ACMD_INFO.PARAM_SYNTAX;

        public Command_List()
        {
            InitializeComponent();
        }

        private void Command_List_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<uint, string> pair in commandNames)
            {
                cmdList.Nodes.Add(pair.Value).Name = pair.Key.ToString();
            }
            cmdList.Sort();
        }

        private void cmdList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cmdName.Text = cmdList.SelectedNode.Text;
            cmdID.Text = "0x" + UInt32.Parse(cmdList.SelectedNode.Name).ToString("X8");
            argCount.Text = commandArgCount[UInt32.Parse(cmdList.SelectedNode.Name)].ToString();
            argTypes.Text = commandArgTypes[UInt32.Parse(cmdList.SelectedNode.Name)].Replace("0", "Int").Replace("1", "Decimal").Replace("2", "Float").Replace(",", ", ");
            args.Text = commandArgs[UInt32.Parse(cmdList.SelectedNode.Name)].ToString().Replace(",", ", ");
            desc.Text = commandDescriptions[UInt32.Parse(cmdList.SelectedNode.Name)].ToString();
            string[] argList = commandArgs[UInt32.Parse(cmdList.SelectedNode.Name)].ToString().Split(',');
            string[] argTypeList = commandArgTypes[UInt32.Parse(cmdList.SelectedNode.Name)].Split(',');
            generator.Rows.Clear();
            try
            {
                if (args.Text != "")
                {
                    for (int i = 0; i < argList.Length; i++)
                    {
                        generator.Rows.Add(argList[i]);
                        generator.Rows[i].Cells[1].Value = 0;
                        if (argTypeList[i] == "0")
                        {
                            generator.Rows[i].Cells[1].Tag = "Int";
                        }
                        if (argTypeList[i] == "1" || argTypeList[i] == "2")
                        {
                            generator.Rows[i].Cells[1].Tag = "Float";
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void genCmd_Click(object sender, EventArgs e)
        {
            string command = cmdName.Text + "(";
            if (args.Text != "")
            {
                for (int i = 0; i < generator.Rows.Count; i++)
                {
                    command = command + generator.Rows[i].Cells[0].Value.ToString() + "=";
                    if (generator.Rows[i].Cells[1].Tag.ToString() == "Int")
                    {
                        command = command + "0x" + UInt32.Parse(generator.Rows[i].Cells[1].Value.ToString()).ToString("X");
                    }
                    if (generator.Rows[i].Cells[1].Tag.ToString() == "Float")
                    {
                        command = command + generator.Rows[i].Cells[1].Value;
                    }
                    if (i < generator.Rows.Count - 1)
                    {
                        command = command + ",";
                    }
                }
            }
            command = command + ")";
            Clipboard.SetText(command);
            MessageBox.Show("Command copied to clipboard", "FitX Text Editor");
        }
    }
}
