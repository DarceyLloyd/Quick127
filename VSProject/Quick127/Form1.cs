using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security;
using System.Security.Permissions;
using System.IO;
using System.Data;

namespace Quick127
{
    public partial class Form1 : Form
    {
        string[] args;

        public Form1(string[] args)
        {
            this.args = args;
            InitializeComponent();

            foreach (String s in args)
            {
                rtStatus.AppendText(s + "\n");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            /*
            String MenuName = "Quick127";
            RegistryKey regmenu = null;
            RegistryKey regcmd = null;

            regmenu = Registry.ClassesRoot.CreateSubKey(MenuName);
            if (regmenu != null)
                regmenu.SetValue("", this.txtName.Text);
            regcmd = Registry.ClassesRoot.CreateSubKey(Command);
            if (regcmd != null)
                regcmd.SetValue("", this.txtPath.Text);
            */
        }
    }
}
