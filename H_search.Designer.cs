namespace MM_2._0
{
    partial class H_search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.place1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tk1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tk2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.hname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Orange;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(596, 183);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(161, 45);
            this.guna2Button1.TabIndex = 90;
            this.guna2Button1.Text = "Seacrh";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(619, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 89;
            this.label5.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Budget";
            // 
            // place1
            // 
            this.place1.Animated = true;
            this.place1.BackColor = System.Drawing.Color.Transparent;
            this.place1.BorderRadius = 20;
            this.place1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.place1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.place1.FocusedColor = System.Drawing.Color.Empty;
            this.place1.FocusedState.Parent = this.place1;
            this.place1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.place1.FormattingEnabled = true;
            this.place1.HoverState.Parent = this.place1;
            this.place1.ItemHeight = 30;
            this.place1.Items.AddRange(new object[] {
            "Any",
            "Barisal",
            "Chittagong",
            "Comilla",
            "Dhaka",
            "Faridpur",
            "Gazipur",
            "Gopalganj",
            "Khulna",
            "Mymensingh",
            "Narayanganj",
            "Rajshahi",
            "Rangpur",
            "Siddhirganj",
            "Sylhet"});
            this.place1.ItemsAppearance.Parent = this.place1;
            this.place1.Location = new System.Drawing.Point(551, 132);
            this.place1.Name = "place1";
            this.place1.ShadowDecoration.Parent = this.place1;
            this.place1.Size = new System.Drawing.Size(206, 36);
            this.place1.Sorted = true;
            this.place1.TabIndex = 86;
            this.place1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tk1
            // 
            this.tk1.BackColor = System.Drawing.Color.Transparent;
            this.tk1.BorderRadius = 20;
            this.tk1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tk1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tk1.FocusedColor = System.Drawing.Color.Empty;
            this.tk1.FocusedState.Parent = this.tk1;
            this.tk1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tk1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tk1.FormattingEnabled = true;
            this.tk1.HoverState.Parent = this.tk1;
            this.tk1.ItemHeight = 30;
            this.tk1.Items.AddRange(new object[] {
            "5000",
            "7500",
            "10000",
            "15000",
            "20000"});
            this.tk1.ItemsAppearance.Parent = this.tk1;
            this.tk1.Location = new System.Drawing.Point(47, 131);
            this.tk1.Name = "tk1";
            this.tk1.ShadowDecoration.Parent = this.tk1;
            this.tk1.Size = new System.Drawing.Size(188, 36);
            this.tk1.TabIndex = 85;
            this.tk1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 84;
            this.label1.Text = "Find your Hotel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Image = global::MM_2._0.Properties.Resources.cancel;
            this.close.Location = new System.Drawing.Point(749, 25);
            this.close.Name = "close";
            this.close.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(27, 26);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 83;
            this.close.TabStop = false;
            this.close.UseTransparentBackground = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // tk2
            // 
            this.tk2.BackColor = System.Drawing.Color.Transparent;
            this.tk2.BorderRadius = 20;
            this.tk2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tk2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tk2.FocusedColor = System.Drawing.Color.Empty;
            this.tk2.FocusedState.Parent = this.tk2;
            this.tk2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tk2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tk2.FormattingEnabled = true;
            this.tk2.HoverState.Parent = this.tk2;
            this.tk2.ItemHeight = 30;
            this.tk2.Items.AddRange(new object[] {
            "7500",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000"});
            this.tk2.ItemsAppearance.Parent = this.tk2;
            this.tk2.Location = new System.Drawing.Point(300, 132);
            this.tk2.Name = "tk2";
            this.tk2.ShadowDecoration.Parent = this.tk2;
            this.tk2.Size = new System.Drawing.Size(211, 36);
            this.tk2.TabIndex = 98;
            this.tk2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OliveDrab;
            this.label8.Location = new System.Drawing.Point(250, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 99;
            this.label8.Text = "To";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 21;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hname,
            this.hplace,
            this.hcost,
            this.hnumber,
            this.hmail,
            this.hDetails});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(47, 234);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(710, 191);
            this.guna2DataGridView1.TabIndex = 100;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);
            this.guna2DataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentDoubleClick);
            // 
            // hname
            // 
            this.hname.DataPropertyName = "Hotel_name";
            this.hname.HeaderText = "Hotel Name";
            this.hname.Name = "hname";
            this.hname.ReadOnly = true;
            // 
            // hplace
            // 
            this.hplace.DataPropertyName = "Place";
            this.hplace.HeaderText = "Place";
            this.hplace.Name = "hplace";
            this.hplace.ReadOnly = true;
            // 
            // hcost
            // 
            this.hcost.DataPropertyName = "Cost";
            this.hcost.HeaderText = "Cost";
            this.hcost.Name = "hcost";
            this.hcost.ReadOnly = true;
            // 
            // hnumber
            // 
            this.hnumber.DataPropertyName = "Number";
            this.hnumber.HeaderText = "Number";
            this.hnumber.Name = "hnumber";
            this.hnumber.ReadOnly = true;
            // 
            // hmail
            // 
            this.hmail.DataPropertyName = "email";
            this.hmail.HeaderText = "Email";
            this.hmail.Name = "hmail";
            this.hmail.ReadOnly = true;
            this.hmail.Visible = false;
            // 
            // hDetails
            // 
            this.hDetails.DataPropertyName = "Details";
            this.hDetails.HeaderText = "Details";
            this.hDetails.Name = "hDetails";
            this.hDetails.ReadOnly = true;
            this.hDetails.Visible = false;
            // 
            // H_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tk2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.place1);
            this.Controls.Add(this.tk1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "H_search";
            this.Text = "H_search";
            this.Load += new System.EventHandler(this.H_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox place1;
        private Guna.UI2.WinForms.Guna2ComboBox tk1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox close;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox tk2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hname;
        private System.Windows.Forms.DataGridViewTextBoxColumn hplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn hcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn hmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDetails;
    }
}