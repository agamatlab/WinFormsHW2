namespace WinFormsHW2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbox_Current = new MyControls.CustomTextBox();
            this.lbl_Previous = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn_Number2 = new System.Windows.Forms.Button();
            this.btn_Number3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Number1 = new System.Windows.Forms.Button();
            this.btn_Number5 = new System.Windows.Forms.Button();
            this.btn_Number6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_Number4 = new System.Windows.Forms.Button();
            this.btn_Number8 = new System.Windows.Forms.Button();
            this.btn_Number9 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btn_Number7 = new System.Windows.Forms.Button();
            this.btn_Number0 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WinFormsHW2.Properties.Resources._1divx;
            this.button1.Location = new System.Drawing.Point(15, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 70);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1/x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Operator_Click);
            // 
            // tbox_Current
            // 
            this.tbox_Current.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbox_Current.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbox_Current.ForeColor = System.Drawing.Color.White;
            this.tbox_Current.Location = new System.Drawing.Point(12, 83);
            this.tbox_Current.MaxLength = 32765;
            this.tbox_Current.Multiline = true;
            this.tbox_Current.Name = "tbox_Current";
            this.tbox_Current.ReadOnly = true;
            this.tbox_Current.Size = new System.Drawing.Size(410, 78);
            this.tbox_Current.TabIndex = 4;
            this.tbox_Current.Text = "0";
            this.tbox_Current.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_Current.WordWrap = false;
            this.tbox_Current.TextChanged += new System.EventHandler(this.tbox_Current_TextChanged);
            // 
            // lbl_Previous
            // 
            this.lbl_Previous.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Previous.Location = new System.Drawing.Point(12, 51);
            this.lbl_Previous.Name = "lbl_Previous";
            this.lbl_Previous.Size = new System.Drawing.Size(410, 26);
            this.lbl_Previous.TabIndex = 5;
            this.lbl_Previous.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(323, 173);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 34);
            this.button10.TabIndex = 14;
            this.button10.Tag = "del";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = global::WinFormsHW2.Properties.Resources.sqrpng;
            this.button11.Location = new System.Drawing.Point(220, 216);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 70);
            this.button11.TabIndex = 15;
            this.button11.Tag = "²";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(118, 216);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 70);
            this.button12.TabIndex = 16;
            this.button12.Tag = "√";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_Number2
            // 
            this.btn_Number2.BackColor = System.Drawing.Color.Black;
            this.btn_Number2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number2.FlatAppearance.BorderSize = 0;
            this.btn_Number2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number2.ForeColor = System.Drawing.Color.White;
            this.btn_Number2.Location = new System.Drawing.Point(118, 294);
            this.btn_Number2.Name = "btn_Number2";
            this.btn_Number2.Size = new System.Drawing.Size(100, 70);
            this.btn_Number2.TabIndex = 20;
            this.btn_Number2.Tag = "2";
            this.btn_Number2.Text = "2";
            this.btn_Number2.UseVisualStyleBackColor = false;
            this.btn_Number2.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_Number3
            // 
            this.btn_Number3.BackColor = System.Drawing.Color.Black;
            this.btn_Number3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number3.FlatAppearance.BorderSize = 0;
            this.btn_Number3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number3.ForeColor = System.Drawing.Color.White;
            this.btn_Number3.Location = new System.Drawing.Point(220, 294);
            this.btn_Number3.Name = "btn_Number3";
            this.btn_Number3.Size = new System.Drawing.Size(100, 70);
            this.btn_Number3.TabIndex = 19;
            this.btn_Number3.Tag = "3";
            this.btn_Number3.Text = "3";
            this.btn_Number3.UseVisualStyleBackColor = false;
            this.btn_Number3.Click += new System.EventHandler(this.Number_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::WinFormsHW2.Properties.Resources.multiply_52px;
            this.button4.Location = new System.Drawing.Point(323, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 70);
            this.button4.TabIndex = 18;
            this.button4.Tag = "*";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_Number1
            // 
            this.btn_Number1.BackColor = System.Drawing.Color.Black;
            this.btn_Number1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number1.FlatAppearance.BorderSize = 0;
            this.btn_Number1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number1.ForeColor = System.Drawing.Color.White;
            this.btn_Number1.Location = new System.Drawing.Point(15, 294);
            this.btn_Number1.Name = "btn_Number1";
            this.btn_Number1.Size = new System.Drawing.Size(100, 70);
            this.btn_Number1.TabIndex = 17;
            this.btn_Number1.Tag = "1";
            this.btn_Number1.Text = "1";
            this.btn_Number1.UseVisualStyleBackColor = false;
            this.btn_Number1.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_Number5
            // 
            this.btn_Number5.BackColor = System.Drawing.Color.Black;
            this.btn_Number5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number5.FlatAppearance.BorderSize = 0;
            this.btn_Number5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number5.ForeColor = System.Drawing.Color.White;
            this.btn_Number5.Location = new System.Drawing.Point(118, 374);
            this.btn_Number5.Name = "btn_Number5";
            this.btn_Number5.Size = new System.Drawing.Size(100, 70);
            this.btn_Number5.TabIndex = 24;
            this.btn_Number5.Tag = "5";
            this.btn_Number5.Text = "5";
            this.btn_Number5.UseVisualStyleBackColor = false;
            this.btn_Number5.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_Number6
            // 
            this.btn_Number6.BackColor = System.Drawing.Color.Black;
            this.btn_Number6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number6.FlatAppearance.BorderSize = 0;
            this.btn_Number6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number6.ForeColor = System.Drawing.Color.White;
            this.btn_Number6.Location = new System.Drawing.Point(220, 374);
            this.btn_Number6.Name = "btn_Number6";
            this.btn_Number6.Size = new System.Drawing.Size(100, 70);
            this.btn_Number6.TabIndex = 23;
            this.btn_Number6.Tag = "6";
            this.btn_Number6.Text = "6";
            this.btn_Number6.UseVisualStyleBackColor = false;
            this.btn_Number6.Click += new System.EventHandler(this.Number_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(323, 374);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 70);
            this.button8.TabIndex = 22;
            this.button8.Tag = "-";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_Number4
            // 
            this.btn_Number4.BackColor = System.Drawing.Color.Black;
            this.btn_Number4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number4.FlatAppearance.BorderSize = 0;
            this.btn_Number4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number4.ForeColor = System.Drawing.Color.White;
            this.btn_Number4.Location = new System.Drawing.Point(15, 374);
            this.btn_Number4.Name = "btn_Number4";
            this.btn_Number4.Size = new System.Drawing.Size(100, 70);
            this.btn_Number4.TabIndex = 21;
            this.btn_Number4.Tag = "4";
            this.btn_Number4.Text = "4";
            this.btn_Number4.UseVisualStyleBackColor = false;
            this.btn_Number4.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_Number8
            // 
            this.btn_Number8.BackColor = System.Drawing.Color.Black;
            this.btn_Number8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number8.FlatAppearance.BorderSize = 0;
            this.btn_Number8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number8.ForeColor = System.Drawing.Color.White;
            this.btn_Number8.Location = new System.Drawing.Point(118, 452);
            this.btn_Number8.Name = "btn_Number8";
            this.btn_Number8.Size = new System.Drawing.Size(100, 70);
            this.btn_Number8.TabIndex = 28;
            this.btn_Number8.Tag = "8";
            this.btn_Number8.Text = "8";
            this.btn_Number8.UseVisualStyleBackColor = false;
            this.btn_Number8.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_Number9
            // 
            this.btn_Number9.BackColor = System.Drawing.Color.Black;
            this.btn_Number9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number9.FlatAppearance.BorderSize = 0;
            this.btn_Number9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number9.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number9.ForeColor = System.Drawing.Color.White;
            this.btn_Number9.Location = new System.Drawing.Point(220, 452);
            this.btn_Number9.Name = "btn_Number9";
            this.btn_Number9.Size = new System.Drawing.Size(100, 70);
            this.btn_Number9.TabIndex = 27;
            this.btn_Number9.Tag = "9";
            this.btn_Number9.Text = "9";
            this.btn_Number9.UseVisualStyleBackColor = false;
            this.btn_Number9.Click += new System.EventHandler(this.Number_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(323, 452);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 70);
            this.button15.TabIndex = 26;
            this.button15.Tag = "+";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_Number7
            // 
            this.btn_Number7.BackColor = System.Drawing.Color.Black;
            this.btn_Number7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number7.FlatAppearance.BorderSize = 0;
            this.btn_Number7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number7.ForeColor = System.Drawing.Color.White;
            this.btn_Number7.Location = new System.Drawing.Point(15, 452);
            this.btn_Number7.Name = "btn_Number7";
            this.btn_Number7.Size = new System.Drawing.Size(100, 70);
            this.btn_Number7.TabIndex = 25;
            this.btn_Number7.Tag = "7";
            this.btn_Number7.Text = "7";
            this.btn_Number7.UseVisualStyleBackColor = false;
            this.btn_Number7.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_Number0
            // 
            this.btn_Number0.BackColor = System.Drawing.Color.Black;
            this.btn_Number0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Number0.FlatAppearance.BorderSize = 0;
            this.btn_Number0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Number0.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Number0.ForeColor = System.Drawing.Color.White;
            this.btn_Number0.Location = new System.Drawing.Point(118, 526);
            this.btn_Number0.Name = "btn_Number0";
            this.btn_Number0.Size = new System.Drawing.Size(100, 70);
            this.btn_Number0.TabIndex = 32;
            this.btn_Number0.Tag = "0";
            this.btn_Number0.Text = "0";
            this.btn_Number0.UseVisualStyleBackColor = false;
            this.btn_Number0.Click += new System.EventHandler(this.Number_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.Location = new System.Drawing.Point(220, 526);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 70);
            this.button18.TabIndex = 31;
            this.button18.Tag = ".";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.DimGray;
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Image = global::WinFormsHW2.Properties.Resources.equal_sign_52px;
            this.button19.Location = new System.Drawing.Point(323, 526);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 70);
            this.button19.TabIndex = 30;
            this.button19.Tag = "=";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.Location = new System.Drawing.Point(15, 526);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 70);
            this.button20.TabIndex = 29;
            this.button20.Tag = "+-";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(394, 10);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(28, 29);
            this.btn_Exit.TabIndex = 33;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(323, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 70);
            this.button2.TabIndex = 34;
            this.button2.Tag = "/";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(118, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 35;
            this.button3.Tag = "clearPrevious";
            this.button3.Text = "CE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(222, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 34);
            this.button5.TabIndex = 36;
            this.button5.Tag = "clear";
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(15, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 34);
            this.button6.TabIndex = 37;
            this.button6.Tag = "round";
            this.button6.Text = "Round";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(434, 606);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Number0);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btn_Number8);
            this.Controls.Add(this.btn_Number9);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btn_Number7);
            this.Controls.Add(this.btn_Number5);
            this.Controls.Add(this.btn_Number6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btn_Number4);
            this.Controls.Add(this.btn_Number2);
            this.Controls.Add(this.btn_Number3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Number1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.lbl_Previous);
            this.Controls.Add(this.tbox_Current);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "v";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private MyControls.CustomTextBox tbox_Current;
        private Label lbl_Previous;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button btn_Number2;
        private Button btn_Number3;
        private Button button4;
        private Button btn_Number1;
        private Button btn_Number5;
        private Button btn_Number6;
        private Button button8;
        private Button btn_Number4;
        private Button btn_Number8;
        private Button btn_Number9;
        private Button button15;
        private Button btn_Number7;
        private Button btn_Number0;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button btn_Exit;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
    }
}