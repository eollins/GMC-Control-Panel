namespace GMCCIT_Control_Panel
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.identifier = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.consignments = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gross = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.owed = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rec = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.net = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cName = new System.Windows.Forms.TextBox();
            this.skuMax = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.skuMin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.sku = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.iConID = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.userPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "User";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Consignment";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 61);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Item";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // identifier
            // 
            this.identifier.Location = new System.Drawing.Point(116, 13);
            this.identifier.Name = "identifier";
            this.identifier.Size = new System.Drawing.Size(137, 20);
            this.identifier.TabIndex = 3;
            this.identifier.Text = "Username";
            this.identifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retrieve Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(259, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(343, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.label1);
            this.userPanel.Controls.Add(this.label7);
            this.userPanel.Controls.Add(this.consignments);
            this.userPanel.Controls.Add(this.label5);
            this.userPanel.Controls.Add(this.name);
            this.userPanel.Controls.Add(this.label6);
            this.userPanel.Controls.Add(this.email);
            this.userPanel.Controls.Add(this.label4);
            this.userPanel.Controls.Add(this.password);
            this.userPanel.Controls.Add(this.label3);
            this.userPanel.Controls.Add(this.username);
            this.userPanel.Location = new System.Drawing.Point(13, 84);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(485, 182);
            this.userPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Consignments";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consignments
            // 
            this.consignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consignments.FormattingEnabled = true;
            this.consignments.ItemHeight = 16;
            this.consignments.Location = new System.Drawing.Point(336, 49);
            this.consignments.Name = "consignments";
            this.consignments.Size = new System.Drawing.Size(137, 100);
            this.consignments.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(170, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(146, 24);
            this.name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(170, 51);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(146, 24);
            this.email.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(12, 126);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(146, 24);
            this.password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(12, 51);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(146, 24);
            this.username.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.gross);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.owed);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.rec);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.net);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cName);
            this.panel1.Controls.Add(this.skuMax);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.skuMin);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cUser);
            this.panel1.Location = new System.Drawing.Point(13, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 182);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 9);
            this.label13.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(316, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Gross Sales";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gross
            // 
            this.gross.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gross.Location = new System.Drawing.Point(316, 144);
            this.gross.Name = "gross";
            this.gross.Size = new System.Drawing.Size(146, 29);
            this.gross.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(316, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Money Owed";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // owed
            // 
            this.owed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owed.Location = new System.Drawing.Point(316, 87);
            this.owed.Name = "owed";
            this.owed.Size = new System.Drawing.Size(146, 29);
            this.owed.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(316, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 23);
            this.label16.TabIndex = 19;
            this.label16.Text = "Money Received";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rec
            // 
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec.Location = new System.Drawing.Point(316, 29);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(146, 29);
            this.rec.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Net Sales";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // net
            // 
            this.net.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net.Location = new System.Drawing.Point(164, 144);
            this.net.Name = "net";
            this.net.Size = new System.Drawing.Size(146, 29);
            this.net.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total Value";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(164, 87);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(146, 29);
            this.total.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(164, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cName
            // 
            this.cName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName.Location = new System.Drawing.Point(164, 29);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(146, 29);
            this.cName.TabIndex = 12;
            // 
            // skuMax
            // 
            this.skuMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuMax.Location = new System.Drawing.Point(12, 121);
            this.skuMax.Name = "skuMax";
            this.skuMax.Size = new System.Drawing.Size(146, 20);
            this.skuMax.TabIndex = 11;
            this.skuMax.Text = "SKUMax";
            this.skuMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(12, 144);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(146, 29);
            this.textBox9.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "SKUMin";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skuMin
            // 
            this.skuMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuMin.Location = new System.Drawing.Point(12, 87);
            this.skuMin.Name = "skuMin";
            this.skuMin.Size = new System.Drawing.Size(146, 29);
            this.skuMin.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "User";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cUser
            // 
            this.cUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cUser.Location = new System.Drawing.Point(12, 29);
            this.cUser.Name = "cUser";
            this.cUser.Size = new System.Drawing.Size(146, 29);
            this.cUser.TabIndex = 0;
            this.cUser.Click += new System.EventHandler(this.cUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.sku);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.iConID);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.number);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(13, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 182);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(241, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 23);
            this.label22.TabIndex = 13;
            this.label22.Text = "SKU";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sku
            // 
            this.sku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sku.Location = new System.Drawing.Point(241, 114);
            this.sku.Multiline = true;
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(146, 29);
            this.sku.TabIndex = 12;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(241, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 20);
            this.label23.TabIndex = 11;
            this.label23.Text = "Consignment";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iConID
            // 
            this.iConID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConID.Location = new System.Drawing.Point(241, 56);
            this.iConID.Multiline = true;
            this.iConID.Name = "iConID";
            this.iConID.Size = new System.Drawing.Size(146, 28);
            this.iConID.TabIndex = 10;
            this.iConID.Click += new System.EventHandler(this.iConID_Click);
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(83, 91);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(146, 20);
            this.label24.TabIndex = 3;
            this.label24.Text = "Item Number";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(83, 114);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(146, 29);
            this.number.TabIndex = 2;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(83, 33);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(146, 23);
            this.label25.TabIndex = 1;
            this.label25.Text = "Item Title";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(83, 56);
            this.title.Multiline = true;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(146, 28);
            this.title.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(343, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 29);
            this.button4.TabIndex = 25;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 277);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.identifier);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox identifier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ListBox consignments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox skuMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cUser;
        private System.Windows.Forms.Label skuMax;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox gross;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox owed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox rec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox net;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox sku;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox iConID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button4;
    }
}

