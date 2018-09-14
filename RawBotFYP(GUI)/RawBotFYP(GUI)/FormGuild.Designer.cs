namespace RawBotFYP_GUI_
{
    partial class FormGuild
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
            this.components = new System.ComponentModel.Container();
            this.lb_Guilds = new System.Windows.Forms.ListBox();
            this.lv_Users = new System.Windows.Forms.ListView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.contextMS_Options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSM_Kick = new System.Windows.Forms.ToolStripMenuItem();
            this.tSM_Ban = new System.Windows.Forms.ToolStripMenuItem();
            this.tSM_PM = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMS_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Guilds
            // 
            this.lb_Guilds.FormattingEnabled = true;
            this.lb_Guilds.ItemHeight = 18;
            this.lb_Guilds.Location = new System.Drawing.Point(12, 12);
            this.lb_Guilds.Name = "lb_Guilds";
            this.lb_Guilds.Size = new System.Drawing.Size(120, 418);
            this.lb_Guilds.TabIndex = 0;
            this.lb_Guilds.SelectedIndexChanged += new System.EventHandler(this.lb_Guilds_SelectedIndexChanged);
            // 
            // lv_Users
            // 
            this.lv_Users.Location = new System.Drawing.Point(138, 12);
            this.lv_Users.Name = "lv_Users";
            this.lv_Users.Size = new System.Drawing.Size(823, 365);
            this.lv_Users.TabIndex = 1;
            this.lv_Users.UseCompatibleStateImageBehavior = false;
            this.lv_Users.SelectedIndexChanged += new System.EventHandler(this.lv_Users_SelectedIndexChanged);
            this.lv_Users.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_Users_MouseClick_1);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(876, 402);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // contextMS_Options
            // 
            this.contextMS_Options.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMS_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSM_Kick,
            this.tSM_Ban,
            this.tSM_PM});
            this.contextMS_Options.Name = "contextMS_Options";
            this.contextMS_Options.Size = new System.Drawing.Size(213, 94);
            // 
            // tSM_Kick
            // 
            this.tSM_Kick.Name = "tSM_Kick";
            this.tSM_Kick.Size = new System.Drawing.Size(212, 30);
            this.tSM_Kick.Text = "Kick";
            this.tSM_Kick.Click += new System.EventHandler(this.tSM_Kick_Click);
            // 
            // tSM_Ban
            // 
            this.tSM_Ban.Name = "tSM_Ban";
            this.tSM_Ban.Size = new System.Drawing.Size(212, 30);
            this.tSM_Ban.Text = "Ban";
            this.tSM_Ban.Click += new System.EventHandler(this.tSM_Ban_Click);
            // 
            // tSM_PM
            // 
            this.tSM_PM.Name = "tSM_PM";
            this.tSM_PM.Size = new System.Drawing.Size(212, 30);
            this.tSM_PM.Text = "Private Message";
            this.tSM_PM.Click += new System.EventHandler(this.tSM_PM_Click);
            // 
            // FormGuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lv_Users);
            this.Controls.Add(this.lb_Guilds);
            this.Name = "FormGuild";
            this.Text = "Guilds";
            this.Load += new System.EventHandler(this.FormGuild_Load);
            this.contextMS_Options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Guilds;
        private System.Windows.Forms.ListView lv_Users;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ContextMenuStrip contextMS_Options;
        private System.Windows.Forms.ToolStripMenuItem tSM_Kick;
        private System.Windows.Forms.ToolStripMenuItem tSM_Ban;
        private System.Windows.Forms.ToolStripMenuItem tSM_PM;
    }
}