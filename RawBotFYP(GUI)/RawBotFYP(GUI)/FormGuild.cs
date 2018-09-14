using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Discord.WebSocket;
using Discord.Net;
using Discord.Commands;

namespace RawBotFYP_GUI_
{
    public partial class FormGuild : Form
    {
        #region StartUp
        public FormGuild()
        {
            InitializeComponent();
            lb_Guilds.Items.Clear();
            foreach (var Guild in RawBotGUI.Client.Guilds)
            {
                lb_Guilds.Items.Add(Guild.Name);
            }
        }
        #endregion

        #region lb_Guilds onSelected
        private void lb_Guilds_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_Users.Items.Clear();

            foreach (var Guild in RawBotGUI.Client.Guilds)
            {
                int i = 0;
                if (Guild.Name == lb_Guilds.Text)
                {
                    foreach (var User in Guild.Users)
                    {
                        lv_Users.Items.Add(User.ToString());

                        if (User.GuildPermissions.KickMembers == true)
                        {
                            lv_Users.Items[i].SubItems.Add("✓");
                        }
                        else
                        {
                            lv_Users.Items[i].SubItems.Add(string.Empty);
                        }

                        if (User.GuildPermissions.BanMembers == true)
                        {
                            lv_Users.Items[i].SubItems.Add("✓");
                        }
                        else
                        {
                            lv_Users.Items[i].SubItems.Add(string.Empty);
                        }

                        if (User.GuildPermissions.Administrator == true)
                        {
                            lv_Users.Items[i].SubItems.Add("✓");
                        }
                        else
                        {
                            lv_Users.Items[i].SubItems.Add(string.Empty);
                        }

                        lv_Users.Items[i].SubItems.Add(User.Status.ToString());
                        lv_Users.Items[i].SubItems.Add(User.JoinedAt.ToString());

                        i++;
                    }

                }
            }
            
        }
        #endregion

        #region FormLoad
        private void FormGuild_Load(object sender, EventArgs e)
        {
            lv_Users.View = View.Details;
            lv_Users.Columns.Add("Username",120, HorizontalAlignment.Center);
            lv_Users.Columns.Add("Kick",40);
            lv_Users.Columns.Add("Ban & Unban",80);
            lv_Users.Columns.Add("Administrator", 90);
            lv_Users.Columns.Add("Status", 60);
            lv_Users.Columns.Add("Joined Date",160);
        }
        #endregion

        #region lv_Users onSelected
        private void lv_Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void lv_Users_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lv_Users.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMS_Options.Show(Cursor.Position);
                }
            }
        }

        private async void tSM_Kick_Click(object sender, EventArgs e)
        {

        }

        private void tSM_Ban_Click(object sender, EventArgs e)
        {

        }

        private void tSM_PM_Click(object sender, EventArgs e)
        {

        }
    }
}
