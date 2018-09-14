using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawBotFYP_GUI_
{
    public partial class LoginForm : Form
    {
        public static List<string> iUserList = new List<string>();
        public static List<string> iPassList = new List<string>();
        public static List<string> iKeyStoreList = new List<string>();

        public LoginForm()
        {
            InitializeComponent();

            iUserList.Add("admin");
            iPassList.Add("adminPW");
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < iUserList.Count(); i++)
            {
                if (iUserList.Count == 0)
                {
                    MessageBox.Show("No user registed. please register.");
                    break;
                }
                if (txt_USER.Text == iUserList[i])
                {
                    if (txt_PW.Text == iPassList[i])
                    {
                        RawBotGUI rawBotform = new RawBotGUI();
                        this.Hide();
                        rawBotform.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Username/Password Incorrect");
                        break;
                    }
                }
                else if (txt_USER.Text != iUserList[i])
                {
                    MessageBox.Show("User not found");
                    break;
                }
            }
        }
    }
}
