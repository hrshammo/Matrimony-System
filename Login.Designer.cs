namespace MM_2._0
{
    partial class Login
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.user_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.user_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_btn = new Guna.UI2.WinForms.Guna2TileButton();
            this.forgot_password_label = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.checkBox1show = new System.Windows.Forms.CheckBox();
            this.close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // user_name
            // 
            this.user_name.BorderRadius = 20;
            this.user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_name.DefaultText = "";
            this.user_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.user_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.user_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_name.DisabledState.Parent = this.user_name;
            this.user_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_name.FocusedState.Parent = this.user_name;
            this.user_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_name.HoverState.Parent = this.user_name;
            this.user_name.Location = new System.Drawing.Point(511, 174);
            this.user_name.Name = "user_name";
            this.user_name.PasswordChar = '\0';
            this.user_name.PlaceholderText = "";
            this.user_name.SelectedText = "";
            this.user_name.ShadowDecoration.Parent = this.user_name;
            this.user_name.Size = new System.Drawing.Size(213, 36);
            this.user_name.TabIndex = 0;
            // 
            // user_password
            // 
            this.user_password.BorderRadius = 20;
            this.user_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_password.DefaultText = "";
            this.user_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.user_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.user_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_password.DisabledState.Parent = this.user_password;
            this.user_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_password.FocusedState.Parent = this.user_password;
            this.user_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_password.HoverState.Parent = this.user_password;
            this.user_password.Location = new System.Drawing.Point(511, 255);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '\0';
            this.user_password.PlaceholderText = "";
            this.user_password.SelectedText = "";
            this.user_password.ShadowDecoration.Parent = this.user_password;
            this.user_password.Size = new System.Drawing.Size(213, 36);
            this.user_password.TabIndex = 1;
            this.user_password.TextChanged += new System.EventHandler(this.user_password_TextChanged);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username_label.Location = new System.Drawing.Point(508, 148);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(43, 16);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Email";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password_label.Location = new System.Drawing.Point(508, 226);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(67, 16);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.BorderRadius = 20;
            this.login_btn.CheckedState.Parent = this.login_btn;
            this.login_btn.CustomImages.Parent = this.login_btn;
            this.login_btn.FillColor = System.Drawing.Color.Fuchsia;
            this.login_btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.HoverState.Parent = this.login_btn;
            this.login_btn.Location = new System.Drawing.Point(511, 338);
            this.login_btn.Name = "login_btn";
            this.login_btn.ShadowDecoration.Parent = this.login_btn;
            this.login_btn.Size = new System.Drawing.Size(213, 50);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // forgot_password_label
            // 
            this.forgot_password_label.AutoSize = true;
            this.forgot_password_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_password_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password_label.ForeColor = System.Drawing.SystemColors.Control;
            this.forgot_password_label.Location = new System.Drawing.Point(663, 308);
            this.forgot_password_label.Name = "forgot_password_label";
            this.forgot_password_label.Size = new System.Drawing.Size(111, 16);
            this.forgot_password_label.TabIndex = 8;
            this.forgot_password_label.Text = "Forgot Password";
            this.forgot_password_label.Click += new System.EventHandler(this.forgot_password_label_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(578, 414);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(89, 16);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back to Start";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // checkBox1show
            // 
            this.checkBox1show.AutoSize = true;
            this.checkBox1show.Checked = true;
            this.checkBox1show.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1show.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1show.Location = new System.Drawing.Point(512, 306);
            this.checkBox1show.Name = "checkBox1show";
            this.checkBox1show.Size = new System.Drawing.Size(123, 20);
            this.checkBox1show.TabIndex = 11;
            this.checkBox1show.Text = "Show Password";
            this.checkBox1show.UseVisualStyleBackColor = true;
            this.checkBox1show.CheckedChanged += new System.EventHandler(this.checkBox1show_CheckedChanged);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Image = global::MM_2._0.Properties.Resources.cancel;
            this.close.Location = new System.Drawing.Point(761, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(27, 26);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 7;
            this.close.TabStop = false;
            this.close.UseTransparentBackground = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::MM_2._0.Properties.Resources.mm;
            this.guna2PictureBox2.Location = new System.Drawing.Point(511, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(228, 122);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::MM_2._0.Properties.Resources.bg;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(438, 426);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1show);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.forgot_password_label);
            this.Controls.Add(this.close);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label username_label;
        private Guna.UI2.WinForms.Guna2TextBox user_password;
        private System.Windows.Forms.Label password_label;
        private Guna.UI2.WinForms.Guna2TileButton login_btn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox close;
        private System.Windows.Forms.Label forgot_password_label;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.CheckBox checkBox1show;
        public Guna.UI2.WinForms.Guna2TextBox user_name;
    }
}