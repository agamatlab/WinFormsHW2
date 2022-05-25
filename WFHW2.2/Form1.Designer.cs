namespace WFHW2._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.btn_Load = new System.Windows.Forms.Button();
            this.tBox_FileName = new System.Windows.Forms.TextBox();
            this.pnl_NameCredentials = new System.Windows.Forms.Panel();
            this.tBox_Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_FatherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Location = new System.Windows.Forms.Panel();
            this.tBox_City = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBox_Country = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_PrivateCredentials = new System.Windows.Forms.Panel();
            this.rBtn_Female = new System.Windows.Forms.RadioButton();
            this.rBtn_Male = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtPicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_Top.SuspendLayout();
            this.pnl_NameCredentials.SuspendLayout();
            this.pnl_Location.SuspendLayout();
            this.pnl_PrivateCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.pnl_Top.Controls.Add(this.lbl_Exit);
            this.pnl_Top.Controls.Add(this.btn_Load);
            this.pnl_Top.Controls.Add(this.tBox_FileName);
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(525, 64);
            this.pnl_Top.TabIndex = 0;
            this.pnl_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseDown);
            this.pnl_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseMove);
            this.pnl_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseUp);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.lbl_Exit.Location = new System.Drawing.Point(471, 10);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(38, 41);
            this.lbl_Exit.TabIndex = 2;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.btn_Load.FlatAppearance.BorderSize = 0;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Image = ((System.Drawing.Image)(resources.GetObject("btn_Load.Image")));
            this.btn_Load.Location = new System.Drawing.Point(319, 8);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(50, 42);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // tBox_FileName
            // 
            this.tBox_FileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.tBox_FileName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBox_FileName.ForeColor = System.Drawing.Color.White;
            this.tBox_FileName.Location = new System.Drawing.Point(117, 8);
            this.tBox_FileName.Name = "tBox_FileName";
            this.tBox_FileName.PlaceholderText = "FileName";
            this.tBox_FileName.Size = new System.Drawing.Size(186, 43);
            this.tBox_FileName.TabIndex = 0;
            // 
            // pnl_NameCredentials
            // 
            this.pnl_NameCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.pnl_NameCredentials.Controls.Add(this.tBox_Surname);
            this.pnl_NameCredentials.Controls.Add(this.label3);
            this.pnl_NameCredentials.Controls.Add(this.tBox_FatherName);
            this.pnl_NameCredentials.Controls.Add(this.label2);
            this.pnl_NameCredentials.Controls.Add(this.tBox_Name);
            this.pnl_NameCredentials.Controls.Add(this.label1);
            this.pnl_NameCredentials.Location = new System.Drawing.Point(18, 84);
            this.pnl_NameCredentials.Name = "pnl_NameCredentials";
            this.pnl_NameCredentials.Size = new System.Drawing.Size(487, 271);
            this.pnl_NameCredentials.TabIndex = 1;
            // 
            // tBox_Surname
            // 
            this.tBox_Surname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBox_Surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.tBox_Surname.Location = new System.Drawing.Point(20, 129);
            this.tBox_Surname.Name = "tBox_Surname";
            this.tBox_Surname.Size = new System.Drawing.Size(283, 38);
            this.tBox_Surname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname: ";
            // 
            // tBox_FatherName
            // 
            this.tBox_FatherName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBox_FatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.tBox_FatherName.Location = new System.Drawing.Point(20, 215);
            this.tBox_FatherName.Name = "tBox_FatherName";
            this.tBox_FatherName.Size = new System.Drawing.Size(283, 38);
            this.tBox_FatherName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.label2.Location = new System.Drawing.Point(20, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Father\'s Name: ";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBox_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.tBox_Name.Location = new System.Drawing.Point(20, 38);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(283, 38);
            this.tBox_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name: ";
            // 
            // pnl_Location
            // 
            this.pnl_Location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.pnl_Location.Controls.Add(this.tBox_City);
            this.pnl_Location.Controls.Add(this.label4);
            this.pnl_Location.Controls.Add(this.tBox_PhoneNumber);
            this.pnl_Location.Controls.Add(this.label5);
            this.pnl_Location.Controls.Add(this.tBox_Country);
            this.pnl_Location.Controls.Add(this.label6);
            this.pnl_Location.Location = new System.Drawing.Point(18, 373);
            this.pnl_Location.Name = "pnl_Location";
            this.pnl_Location.Size = new System.Drawing.Size(487, 278);
            this.pnl_Location.TabIndex = 8;
            // 
            // tBox_City
            // 
            this.tBox_City.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBox_City.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.tBox_City.Location = new System.Drawing.Point(20, 134);
            this.tBox_City.Name = "tBox_City";
            this.tBox_City.Size = new System.Drawing.Size(283, 38);
            this.tBox_City.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "City:";
            // 
            // tBox_PhoneNumber
            // 
            this.tBox_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBox_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.tBox_PhoneNumber.Location = new System.Drawing.Point(20, 220);
            this.tBox_PhoneNumber.Name = "tBox_PhoneNumber";
            this.tBox_PhoneNumber.Size = new System.Drawing.Size(283, 38);
            this.tBox_PhoneNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number:";
            // 
            // tBox_Country
            // 
            this.tBox_Country.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBox_Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.tBox_Country.Location = new System.Drawing.Point(20, 43);
            this.tBox_Country.Name = "tBox_Country";
            this.tBox_Country.Size = new System.Drawing.Size(283, 38);
            this.tBox_Country.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.label6.Location = new System.Drawing.Point(20, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Country: ";
            // 
            // pnl_PrivateCredentials
            // 
            this.pnl_PrivateCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.pnl_PrivateCredentials.Controls.Add(this.rBtn_Female);
            this.pnl_PrivateCredentials.Controls.Add(this.rBtn_Male);
            this.pnl_PrivateCredentials.Controls.Add(this.label8);
            this.pnl_PrivateCredentials.Controls.Add(this.label7);
            this.pnl_PrivateCredentials.Controls.Add(this.dtPicker_BirthDate);
            this.pnl_PrivateCredentials.Location = new System.Drawing.Point(18, 668);
            this.pnl_PrivateCredentials.Name = "pnl_PrivateCredentials";
            this.pnl_PrivateCredentials.Size = new System.Drawing.Size(487, 98);
            this.pnl_PrivateCredentials.TabIndex = 9;
            // 
            // rBtn_Female
            // 
            this.rBtn_Female.AutoSize = true;
            this.rBtn_Female.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBtn_Female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.rBtn_Female.Location = new System.Drawing.Point(268, 56);
            this.rBtn_Female.Name = "rBtn_Female";
            this.rBtn_Female.Size = new System.Drawing.Size(111, 35);
            this.rBtn_Female.TabIndex = 11;
            this.rBtn_Female.TabStop = true;
            this.rBtn_Female.Text = "Female";
            this.rBtn_Female.UseVisualStyleBackColor = true;
            // 
            // rBtn_Male
            // 
            this.rBtn_Male.AutoSize = true;
            this.rBtn_Male.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBtn_Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.rBtn_Male.Location = new System.Drawing.Point(162, 56);
            this.rBtn_Male.Name = "rBtn_Male";
            this.rBtn_Male.Size = new System.Drawing.Size(88, 35);
            this.rBtn_Male.TabIndex = 10;
            this.rBtn_Male.TabStop = true;
            this.rBtn_Male.Text = "Male";
            this.rBtn_Male.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.label8.Location = new System.Drawing.Point(19, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 31);
            this.label8.TabIndex = 9;
            this.label8.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.label7.Location = new System.Drawing.Point(15, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Birth Date:";
            // 
            // dtPicker_BirthDate
            // 
            this.dtPicker_BirthDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtPicker_BirthDate.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtPicker_BirthDate.Location = new System.Drawing.Point(152, 12);
            this.dtPicker_BirthDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtPicker_BirthDate.Name = "dtPicker_BirthDate";
            this.dtPicker_BirthDate.Size = new System.Drawing.Size(246, 27);
            this.dtPicker_BirthDate.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.button2.Location = new System.Drawing.Point(153, 784);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(158)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(525, 839);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnl_PrivateCredentials);
            this.Controls.Add(this.pnl_Location);
            this.Controls.Add(this.pnl_NameCredentials);
            this.Controls.Add(this.pnl_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.pnl_NameCredentials.ResumeLayout(false);
            this.pnl_NameCredentials.PerformLayout();
            this.pnl_Location.ResumeLayout(false);
            this.pnl_Location.PerformLayout();
            this.pnl_PrivateCredentials.ResumeLayout(false);
            this.pnl_PrivateCredentials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Top;
        private Button btn_Load;
        private TextBox tBox_FileName;
        private Panel pnl_NameCredentials;
        private TextBox tBox_Name;
        private Label label1;
        private TextBox tBox_Surname;
        private Label label3;
        private TextBox tBox_FatherName;
        private Label label2;
        private Panel pnl_Location;
        private TextBox tBox_City;
        private Label label4;
        private TextBox tBox_PhoneNumber;
        private Label label5;
        private TextBox tBox_Country;
        private Label label6;
        private Panel pnl_PrivateCredentials;
        private RadioButton rBtn_Male;
        private Label label8;
        private Label label7;
        private DateTimePicker dtPicker_BirthDate;
        private Button button2;
        private RadioButton rBtn_Female;
        private Label lbl_Exit;
    }
}