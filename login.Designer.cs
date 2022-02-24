namespace Matrimony_System_ii
{
    partial class login
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
            this.login2 = new System.Windows.Forms.Button();
            this.forgot_password = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login2
            // 
            this.login2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.login2.FlatAppearance.BorderSize = 0;
            this.login2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login2.Location = new System.Drawing.Point(30, 428);
            this.login2.Name = "login2";
            this.login2.Size = new System.Drawing.Size(128, 41);
            this.login2.TabIndex = 0;
            this.login2.Text = "Login";
            this.login2.UseVisualStyleBackColor = false;
            this.login2.Click += new System.EventHandler(this.login2_Click);
            // 
            // forgot_password
            // 
            this.forgot_password.AutoSize = true;
            this.forgot_password.BackColor = System.Drawing.Color.Transparent;
            this.forgot_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.forgot_password.Location = new System.Drawing.Point(164, 440);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(109, 16);
            this.forgot_password.TabIndex = 1;
            this.forgot_password.Text = "Forgot Password";
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.user_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_name.ForeColor = System.Drawing.Color.Black;
            this.user_name.Location = new System.Drawing.Point(63, 350);
            this.user_name.Multiline = true;
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(203, 20);
            this.user_name.TabIndex = 2;
            this.user_name.TextChanged += new System.EventHandler(this.user_name_TextChanged);
            // 
            // user_password
            // 
            this.user_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.user_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_password.ForeColor = System.Drawing.Color.Black;
            this.user_password.Location = new System.Drawing.Point(63, 388);
            this.user_password.Multiline = true;
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(203, 20);
            this.user_password.TabIndex = 3;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Matrimony_System_ii.Properties.Resources.login_bg;
            this.ClientSize = new System.Drawing.Size(299, 501);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.forgot_password);
            this.Controls.Add(this.login2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login2;
        private System.Windows.Forms.Label forgot_password;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_password;
    }
}