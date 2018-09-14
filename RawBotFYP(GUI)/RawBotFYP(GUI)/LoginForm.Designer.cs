namespace RawBotFYP_GUI_
{
    partial class LoginForm
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
            this.txt_USER = new System.Windows.Forms.TextBox();
            this.lbl_USER = new System.Windows.Forms.Label();
            this.lbl_PW = new System.Windows.Forms.Label();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_USER
            // 
            this.txt_USER.Location = new System.Drawing.Point(274, 66);
            this.txt_USER.Name = "txt_USER";
            this.txt_USER.Size = new System.Drawing.Size(191, 28);
            this.txt_USER.TabIndex = 0;
            // 
            // lbl_USER
            // 
            this.lbl_USER.AutoSize = true;
            this.lbl_USER.Location = new System.Drawing.Point(148, 76);
            this.lbl_USER.Name = "lbl_USER";
            this.lbl_USER.Size = new System.Drawing.Size(80, 18);
            this.lbl_USER.TabIndex = 1;
            this.lbl_USER.Text = "Username";
            // 
            // lbl_PW
            // 
            this.lbl_PW.AutoSize = true;
            this.lbl_PW.Location = new System.Drawing.Point(148, 130);
            this.lbl_PW.Name = "lbl_PW";
            this.lbl_PW.Size = new System.Drawing.Size(80, 18);
            this.lbl_PW.TabIndex = 2;
            this.lbl_PW.Text = "Password";
            // 
            // txt_PW
            // 
            this.txt_PW.Location = new System.Drawing.Point(274, 127);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.Size = new System.Drawing.Size(191, 28);
            this.txt_PW.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(300, 276);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(105, 40);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_PW);
            this.Controls.Add(this.lbl_PW);
            this.Controls.Add(this.lbl_USER);
            this.Controls.Add(this.txt_USER);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_USER;
        private System.Windows.Forms.Label lbl_USER;
        private System.Windows.Forms.Label lbl_PW;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Button btn_Login;
    }
}