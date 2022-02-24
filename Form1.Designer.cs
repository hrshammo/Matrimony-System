namespace Matrimony_System_ii
{
    partial class Form1
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
            this.Login = new System.Windows.Forms.Button();
            this.Regestation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AccessibleName = "Login";
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(33, 381);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(234, 42);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Regestation
            // 
            this.Regestation.AccessibleName = "Regestation";
            this.Regestation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Regestation.FlatAppearance.BorderSize = 0;
            this.Regestation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regestation.Font = new System.Drawing.Font("Lucida Bright", 15.75F);
            this.Regestation.Location = new System.Drawing.Point(33, 430);
            this.Regestation.Name = "Regestation";
            this.Regestation.Size = new System.Drawing.Size(234, 42);
            this.Regestation.TabIndex = 1;
            this.Regestation.Text = "Regestation";
            this.Regestation.UseVisualStyleBackColor = false;
            this.Regestation.Click += new System.EventHandler(this.Regestation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Matrimony_System_ii.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(299, 501);
            this.Controls.Add(this.Regestation);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Regestation;
    }
}

