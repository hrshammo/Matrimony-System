namespace MM_2._0
{
    partial class P_search
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
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.location = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.age1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.age2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.religion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "to";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(604, 173);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(161, 45);
            this.guna2Button1.TabIndex = 34;
            this.guna2Button1.Text = "Seacrh";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(619, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Living Location";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Religion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Looking For a";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // location
            // 
            this.location.Animated = true;
            this.location.BackColor = System.Drawing.Color.Transparent;
            this.location.BorderRadius = 20;
            this.location.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location.FocusedColor = System.Drawing.Color.Empty;
            this.location.FocusedState.Parent = this.location;
            this.location.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.location.FormattingEnabled = true;
            this.location.HoverState.Parent = this.location;
            this.location.ItemHeight = 30;
            this.location.Items.AddRange(new object[] {
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
            this.location.ItemsAppearance.Parent = this.location;
            this.location.Location = new System.Drawing.Point(573, 121);
            this.location.Name = "location";
            this.location.ShadowDecoration.Parent = this.location;
            this.location.Size = new System.Drawing.Size(192, 36);
            this.location.Sorted = true;
            this.location.TabIndex = 29;
            this.location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.location.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox5_SelectedIndexChanged);
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.BorderRadius = 20;
            this.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FocusedColor = System.Drawing.Color.Empty;
            this.gender.FocusedState.Parent = this.gender;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gender.FormattingEnabled = true;
            this.gender.HoverState.Parent = this.gender;
            this.gender.ItemHeight = 30;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.ItemsAppearance.Parent = this.gender;
            this.gender.Location = new System.Drawing.Point(32, 121);
            this.gender.Name = "gender";
            this.gender.ShadowDecoration.Parent = this.gender;
            this.gender.Size = new System.Drawing.Size(140, 36);
            this.gender.TabIndex = 26;
            this.gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Match Your Partner";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // age1
            // 
            this.age1.BackColor = System.Drawing.Color.Transparent;
            this.age1.BorderRadius = 20;
            this.age1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.age1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.age1.FocusedColor = System.Drawing.Color.Empty;
            this.age1.FocusedState.Parent = this.age1;
            this.age1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.age1.FormattingEnabled = true;
            this.age1.HoverState.Parent = this.age1;
            this.age1.ItemHeight = 30;
            this.age1.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45+"});
            this.age1.ItemsAppearance.Parent = this.age1;
            this.age1.Location = new System.Drawing.Point(182, 122);
            this.age1.Name = "age1";
            this.age1.ShadowDecoration.Parent = this.age1;
            this.age1.Size = new System.Drawing.Size(88, 36);
            this.age1.TabIndex = 49;
            this.age1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.age1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox6_SelectedIndexChanged);
            // 
            // age2
            // 
            this.age2.BackColor = System.Drawing.Color.Transparent;
            this.age2.BorderRadius = 20;
            this.age2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.age2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.age2.FocusedColor = System.Drawing.Color.Empty;
            this.age2.FocusedState.Parent = this.age2;
            this.age2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.age2.FormattingEnabled = true;
            this.age2.HoverState.Parent = this.age2;
            this.age2.ItemHeight = 30;
            this.age2.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45+"});
            this.age2.ItemsAppearance.Parent = this.age2;
            this.age2.Location = new System.Drawing.Point(305, 122);
            this.age2.Name = "age2";
            this.age2.ShadowDecoration.Parent = this.age2;
            this.age2.Size = new System.Drawing.Size(99, 36);
            this.age2.TabIndex = 50;
            this.age2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.age2.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox7_SelectedIndexChanged);
            // 
            // religion
            // 
            this.religion.BackColor = System.Drawing.Color.Transparent;
            this.religion.BorderRadius = 20;
            this.religion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.religion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.religion.FocusedColor = System.Drawing.Color.Empty;
            this.religion.FocusedState.Parent = this.religion;
            this.religion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.religion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.religion.FormattingEnabled = true;
            this.religion.HoverState.Parent = this.religion;
            this.religion.ItemHeight = 30;
            this.religion.Items.AddRange(new object[] {
            "Muslim",
            "Hindu",
            "Christan",
            "Buddhism"});
            this.religion.ItemsAppearance.Parent = this.religion;
            this.religion.Location = new System.Drawing.Point(419, 122);
            this.religion.Name = "religion";
            this.religion.ShadowDecoration.Parent = this.religion;
            this.religion.Size = new System.Drawing.Size(148, 36);
            this.religion.TabIndex = 51;
            this.religion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.religion.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // GridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView1.BackgroundColor = System.Drawing.Color.White;
            this.GridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView1.ColumnHeadersHeight = 30;
            this.GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridView1.EnableHeadersVisualStyles = false;
            this.GridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridView1.Location = new System.Drawing.Point(32, 224);
            this.GridView1.Name = "GridView1";
            this.GridView1.ReadOnly = true;
            this.GridView1.RowHeadersVisible = false;
            this.GridView1.RowTemplate.Height = 30;
            this.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView1.Size = new System.Drawing.Size(733, 204);
            this.GridView1.TabIndex = 52;
            this.GridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.GridView1.ThemeStyle.ReadOnly = true;
            this.GridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridView1.ThemeStyle.RowsStyle.Height = 30;
            this.GridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellContentClick);
            this.GridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellContentDoubleClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Name";
            this.Column5.HeaderText = "Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Age";
            this.Column6.HeaderText = "Age";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Height";
            this.Column1.HeaderText = "Height";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Number";
            this.Column2.HeaderText = "Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Image = global::MM_2._0.Properties.Resources.cancel;
            this.close.Location = new System.Drawing.Point(757, 15);
            this.close.Name = "close";
            this.close.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(27, 26);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 23;
            this.close.TabStop = false;
            this.close.UseTransparentBackground = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // P_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.religion);
            this.Controls.Add(this.age2);
            this.Controls.Add(this.age1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.location);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_search";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.P_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox location;
        private Guna.UI2.WinForms.Guna2ComboBox gender;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox close;
        private Guna.UI2.WinForms.Guna2ComboBox age2;
        private Guna.UI2.WinForms.Guna2ComboBox age1;
        private Guna.UI2.WinForms.Guna2ComboBox religion;
        private Guna.UI2.WinForms.Guna2DataGridView GridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}