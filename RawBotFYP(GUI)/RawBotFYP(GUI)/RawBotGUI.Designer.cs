namespace RawBotFYP_GUI_
{
    partial class RawBotGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawBotGUI));
            this.lb_Token = new System.Windows.Forms.Label();
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.txt_Token = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.pb_LOGO = new System.Windows.Forms.PictureBox();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.lbl_moto3 = new System.Windows.Forms.Label();
            this.lbl_moto2 = new System.Windows.Forms.Label();
            this.lbl_Moto1 = new System.Windows.Forms.Label();
            this.lbl_Connected = new System.Windows.Forms.Label();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.lbl_Minimize = new System.Windows.Forms.Label();
            this.pb_Eye = new System.Windows.Forms.PictureBox();
            this.btn_ShowGuild = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LOGO)).BeginInit();
            this.pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eye)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Token
            // 
            this.lb_Token.AutoSize = true;
            this.lb_Token.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Token.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_Token.Location = new System.Drawing.Point(471, 17);
            this.lb_Token.Name = "lb_Token";
            this.lb_Token.Size = new System.Drawing.Size(68, 23);
            this.lb_Token.TabIndex = 7;
            this.lb_Token.Text = "Token";
            // 
            // rtb_Output
            // 
            this.rtb_Output.BackColor = System.Drawing.Color.Gainsboro;
            this.rtb_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Output.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.rtb_Output.Location = new System.Drawing.Point(488, 85);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.ReadOnly = true;
            this.rtb_Output.Size = new System.Drawing.Size(483, 304);
            this.rtb_Output.TabIndex = 6;
            this.rtb_Output.Text = "";
            this.rtb_Output.TextChanged += new System.EventHandler(this.rtb_Output_TextChanged);
            // 
            // txt_Token
            // 
            this.txt_Token.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Token.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_Token.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Token.Location = new System.Drawing.Point(525, 14);
            this.txt_Token.Name = "txt_Token";
            this.txt_Token.Size = new System.Drawing.Size(366, 32);
            this.txt_Token.TabIndex = 5;
            this.txt_Token.Text = "Please Insert Your Bot Token Number Here!";
            this.txt_Token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Token.Enter += new System.EventHandler(this.txt_Token_Enter);
            this.txt_Token.Leave += new System.EventHandler(this.txt_Token_Leave);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Connect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Connect.FlatAppearance.BorderSize = 0;
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btn_Connect.ForeColor = System.Drawing.Color.Black;
            this.btn_Connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_Connect.Image")));
            this.btn_Connect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Connect.Location = new System.Drawing.Point(449, 497);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(503, 110);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "CONNECT";
            this.btn_Connect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Connect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // pb_LOGO
            // 
            this.pb_LOGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pb_LOGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_LOGO.Image = ((System.Drawing.Image)(resources.GetObject("pb_LOGO.Image")));
            this.pb_LOGO.InitialImage = null;
            this.pb_LOGO.Location = new System.Drawing.Point(0, 0);
            this.pb_LOGO.Name = "pb_LOGO";
            this.pb_LOGO.Size = new System.Drawing.Size(449, 607);
            this.pb_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_LOGO.TabIndex = 14;
            this.pb_LOGO.TabStop = false;
            // 
            // pn_Left
            // 
            this.pn_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pn_Left.Controls.Add(this.lbl_moto2);
            this.pn_Left.Controls.Add(this.lbl_Moto1);
            this.pn_Left.Controls.Add(this.lbl_moto3);
            this.pn_Left.Controls.Add(this.pb_LOGO);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(449, 607);
            this.pn_Left.TabIndex = 15;
            // 
            // lbl_moto3
            // 
            this.lbl_moto3.AutoSize = true;
            this.lbl_moto3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moto3.ForeColor = System.Drawing.Color.White;
            this.lbl_moto3.Location = new System.Drawing.Point(37, 487);
            this.lbl_moto3.Name = "lbl_moto3";
            this.lbl_moto3.Size = new System.Drawing.Size(556, 94);
            this.lbl_moto3.TabIndex = 17;
            this.lbl_moto3.Text = "The Smallest Deed Is Better \r\nThan The Greatest Intention";
            // 
            // lbl_moto2
            // 
            this.lbl_moto2.AutoSize = true;
            this.lbl_moto2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moto2.ForeColor = System.Drawing.Color.White;
            this.lbl_moto2.Location = new System.Drawing.Point(182, 58);
            this.lbl_moto2.Name = "lbl_moto2";
            this.lbl_moto2.Size = new System.Drawing.Size(85, 70);
            this.lbl_moto2.TabIndex = 16;
            this.lbl_moto2.Text = "UI";
            // 
            // lbl_Moto1
            // 
            this.lbl_Moto1.AutoSize = true;
            this.lbl_Moto1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lbl_Moto1.ForeColor = System.Drawing.Color.White;
            this.lbl_Moto1.Location = new System.Drawing.Point(133, 9);
            this.lbl_Moto1.Name = "lbl_Moto1";
            this.lbl_Moto1.Size = new System.Drawing.Size(253, 74);
            this.lbl_Moto1.TabIndex = 15;
            this.lbl_Moto1.Text = "RawBot";
            // 
            // lbl_Connected
            // 
            this.lbl_Connected.AutoSize = true;
            this.lbl_Connected.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Connected.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Connected.Location = new System.Drawing.Point(534, 41);
            this.lbl_Connected.Name = "lbl_Connected";
            this.lbl_Connected.Size = new System.Drawing.Size(0, 38);
            this.lbl_Connected.TabIndex = 9;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Exit.Location = new System.Drawing.Point(935, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(24, 23);
            this.lbl_Exit.TabIndex = 16;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // lbl_Minimize
            // 
            this.lbl_Minimize.AutoSize = true;
            this.lbl_Minimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Minimize.Location = new System.Drawing.Point(917, -3);
            this.lbl_Minimize.Name = "lbl_Minimize";
            this.lbl_Minimize.Size = new System.Drawing.Size(20, 23);
            this.lbl_Minimize.TabIndex = 17;
            this.lbl_Minimize.Text = "_";
            this.lbl_Minimize.Click += new System.EventHandler(this.lbl_Minimize_Click);
            // 
            // pb_Eye
            // 
            this.pb_Eye.Image = ((System.Drawing.Image)(resources.GetObject("pb_Eye.Image")));
            this.pb_Eye.Location = new System.Drawing.Point(895, 16);
            this.pb_Eye.Name = "pb_Eye";
            this.pb_Eye.Size = new System.Drawing.Size(27, 20);
            this.pb_Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Eye.TabIndex = 18;
            this.pb_Eye.TabStop = false;
            this.pb_Eye.Click += new System.EventHandler(this.pb_Eye_Click);
            this.pb_Eye.MouseHover += new System.EventHandler(this.pb_Eye_MouseHover);
            // 
            // btn_ShowGuild
            // 
            this.btn_ShowGuild.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btn_ShowGuild.ForeColor = System.Drawing.Color.Teal;
            this.btn_ShowGuild.Location = new System.Drawing.Point(550, 410);
            this.btn_ShowGuild.Name = "btn_ShowGuild";
            this.btn_ShowGuild.Size = new System.Drawing.Size(310, 47);
            this.btn_ShowGuild.TabIndex = 19;
            this.btn_ShowGuild.Text = "Guilds and Users";
            this.btn_ShowGuild.UseVisualStyleBackColor = true;
            this.btn_ShowGuild.Click += new System.EventHandler(this.btn_ShowGuild_Click);
            // 
            // RawBotGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(952, 607);
            this.Controls.Add(this.btn_ShowGuild);
            this.Controls.Add(this.pb_Eye);
            this.Controls.Add(this.lbl_Minimize);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.lbl_Connected);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.rtb_Output);
            this.Controls.Add(this.pn_Left);
            this.Controls.Add(this.lb_Token);
            this.Controls.Add(this.txt_Token);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RawBotGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RawBot (Discord Bot)";
            ((System.ComponentModel.ISupportInitialize)(this.pb_LOGO)).EndInit();
            this.pn_Left.ResumeLayout(false);
            this.pn_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Token;
        private System.Windows.Forms.TextBox txt_Token;
        private System.Windows.Forms.PictureBox pb_LOGO;
        private System.Windows.Forms.Panel pn_Left;
        private System.Windows.Forms.Label lbl_moto3;
        private System.Windows.Forms.Label lbl_moto2;
        private System.Windows.Forms.Label lbl_Moto1;
        private System.Windows.Forms.Label lbl_Connected;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label lbl_Minimize;
        private System.Windows.Forms.PictureBox pb_Eye;
        public System.Windows.Forms.RichTextBox rtb_Output;
        public System.Windows.Forms.Button btn_Connect;
        public System.Windows.Forms.Button btn_ShowGuild;
    }
}

