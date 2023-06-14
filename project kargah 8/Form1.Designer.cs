
namespace project_kargah_8
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mstfilenumber = new System.Windows.Forms.MaskedTextBox();
            this.btezafe = new System.Windows.Forms.Button();
            this.cmbgener = new System.Windows.Forms.ComboBox();
            this.mstbirthday = new System.Windows.Forms.MaskedTextBox();
            this.mstcode = new System.Windows.Forms.MaskedTextBox();
            this.mstphone = new System.Windows.Forms.MaskedTextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtdoctor = new System.Windows.Forms.TextBox();
            this.txtfathername = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btedite = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblfile = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.lblbirthday = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblfathername = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cmbderch = new System.Windows.Forms.ComboBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.btall = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBINFORMATION1DataSet = new project_kargah_8.DBINFORMATION1DataSet();
            this.person_informationTableAdapter = new project_kargah_8.DBINFORMATION1DataSetTableAdapters.person_informationTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBINFORMATION1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mstfilenumber);
            this.panel1.Controls.Add(this.btezafe);
            this.panel1.Controls.Add(this.cmbgener);
            this.panel1.Controls.Add(this.mstbirthday);
            this.panel1.Controls.Add(this.mstcode);
            this.panel1.Controls.Add(this.mstphone);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtdoctor);
            this.panel1.Controls.Add(this.txtfathername);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.btedite);
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.lblphone);
            this.panel1.Controls.Add(this.lblfile);
            this.panel1.Controls.Add(this.lblcode);
            this.panel1.Controls.Add(this.lblbirthday);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.lbldoctor);
            this.panel1.Controls.Add(this.lblfathername);
            this.panel1.Controls.Add(this.lbllastname);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 213);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(46, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(663, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(937, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(937, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(932, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "*";
            // 
            // mstfilenumber
            // 
            this.mstfilenumber.Location = new System.Drawing.Point(75, 79);
            this.mstfilenumber.Mask = "00000";
            this.mstfilenumber.Name = "mstfilenumber";
            this.mstfilenumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mstfilenumber.Size = new System.Drawing.Size(151, 34);
            this.mstfilenumber.TabIndex = 29;
            this.mstfilenumber.ValidatingType = typeof(int);
            // 
            // btezafe
            // 
            this.btezafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btezafe.Location = new System.Drawing.Point(232, 161);
            this.btezafe.Name = "btezafe";
            this.btezafe.Size = new System.Drawing.Size(99, 38);
            this.btezafe.TabIndex = 28;
            this.btezafe.Text = "اضافه";
            this.btezafe.UseVisualStyleBackColor = true;
            this.btezafe.Click += new System.EventHandler(this.btezafe_Click);
            // 
            // cmbgener
            // 
            this.cmbgener.FormattingEnabled = true;
            this.cmbgener.Items.AddRange(new object[] {
            "خانم",
            "اقا"});
            this.cmbgener.Location = new System.Drawing.Point(441, 18);
            this.cmbgener.Name = "cmbgener";
            this.cmbgener.Size = new System.Drawing.Size(121, 37);
            this.cmbgener.TabIndex = 27;
            // 
            // mstbirthday
            // 
            this.mstbirthday.Location = new System.Drawing.Point(401, 76);
            this.mstbirthday.Mask = "0000/00/00";
            this.mstbirthday.Name = "mstbirthday";
            this.mstbirthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mstbirthday.Size = new System.Drawing.Size(161, 34);
            this.mstbirthday.TabIndex = 26;
            this.mstbirthday.ValidatingType = typeof(System.DateTime);
            // 
            // mstcode
            // 
            this.mstcode.Location = new System.Drawing.Point(31, 16);
            this.mstcode.Mask = "0000000000";
            this.mstcode.Name = "mstcode";
            this.mstcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mstcode.Size = new System.Drawing.Size(195, 34);
            this.mstcode.TabIndex = 25;
            this.mstcode.ValidatingType = typeof(int);
            // 
            // mstphone
            // 
            this.mstphone.Location = new System.Drawing.Point(961, 140);
            this.mstphone.Mask = "(9999) 000-0000";
            this.mstphone.Name = "mstphone";
            this.mstphone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mstphone.Size = new System.Drawing.Size(185, 34);
            this.mstphone.TabIndex = 23;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtaddress.Location = new System.Drawing.Point(520, 144);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(334, 30);
            this.txtaddress.TabIndex = 18;
            // 
            // txtdoctor
            // 
            this.txtdoctor.Location = new System.Drawing.Point(693, 82);
            this.txtdoctor.Name = "txtdoctor";
            this.txtdoctor.Size = new System.Drawing.Size(161, 34);
            this.txtdoctor.TabIndex = 17;
            // 
            // txtfathername
            // 
            this.txtfathername.Location = new System.Drawing.Point(692, 21);
            this.txtfathername.Name = "txtfathername";
            this.txtfathername.Size = new System.Drawing.Size(161, 34);
            this.txtfathername.TabIndex = 16;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(961, 73);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(185, 34);
            this.txtlastname.TabIndex = 14;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(961, 18);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(185, 34);
            this.txtname.TabIndex = 13;
            // 
            // btedite
            // 
            this.btedite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btedite.Location = new System.Drawing.Point(22, 161);
            this.btedite.Name = "btedite";
            this.btedite.Size = new System.Drawing.Size(99, 38);
            this.btedite.TabIndex = 12;
            this.btedite.Text = "ویرایش";
            this.btedite.UseVisualStyleBackColor = true;
            this.btedite.Click += new System.EventHandler(this.btedite_Click);
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btdelete.Location = new System.Drawing.Point(127, 161);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(99, 38);
            this.btdelete.TabIndex = 11;
            this.btdelete.Text = "حذف";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btadd.Location = new System.Drawing.Point(337, 161);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(99, 38);
            this.btadd.TabIndex = 10;
            this.btadd.Text = "جدید";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(860, 140);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(71, 29);
            this.lbladdress.TabIndex = 9;
            this.lbladdress.Text = "آدرس :";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(1165, 143);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(105, 29);
            this.lblphone.TabIndex = 8;
            this.lblphone.Text = "تلفن همراه :";
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfile.Location = new System.Drawing.Point(253, 73);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(127, 29);
            this.lblfile.TabIndex = 7;
            this.lblfile.Text = "شماره پرونده :";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.Location = new System.Drawing.Point(253, 21);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(76, 29);
            this.lblcode.TabIndex = 6;
            this.lblcode.Text = "کد ملی :";
            // 
            // lblbirthday
            // 
            this.lblbirthday.AutoSize = true;
            this.lblbirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthday.Location = new System.Drawing.Point(568, 74);
            this.lblbirthday.Name = "lblbirthday";
            this.lblbirthday.Size = new System.Drawing.Size(103, 29);
            this.lblbirthday.TabIndex = 5;
            this.lblbirthday.Text = "تاریخ تولد :";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(568, 21);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(80, 29);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "جنسیت :";
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctor.Location = new System.Drawing.Point(859, 82);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(96, 29);
            this.lbldoctor.TabIndex = 3;
            this.lbldoctor.Text = "نام پزشک :\r\n";
            // 
            // lblfathername
            // 
            this.lblfathername.AutoSize = true;
            this.lblfathername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfathername.Location = new System.Drawing.Point(860, 21);
            this.lblfathername.Name = "lblfathername";
            this.lblfathername.Size = new System.Drawing.Size(83, 29);
            this.lblfathername.TabIndex = 2;
            this.lblfathername.Text = "  نام پدر:";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(1148, 79);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(122, 29);
            this.lbllastname.TabIndex = 1;
            this.lbllastname.Text = "نام خانوادگی :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(1225, 16);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 29);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "نام :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.cmbderch);
            this.panel2.Controls.Add(this.btsearch);
            this.panel2.Controls.Add(this.btall);
            this.panel2.Controls.Add(this.lblsearch);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel2.Location = new System.Drawing.Point(11, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 74);
            this.panel2.TabIndex = 1;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(410, 22);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(202, 34);
            this.txtsearch.TabIndex = 16;
            // 
            // cmbderch
            // 
            this.cmbderch.FormattingEnabled = true;
            this.cmbderch.Items.AddRange(new object[] {
            "نام",
            "نام خانوادگی",
            "تلفن همراه",
            "نام پزشک",
            "کدملی",
            "شماره پرونده"});
            this.cmbderch.Location = new System.Drawing.Point(634, 21);
            this.cmbderch.Name = "cmbderch";
            this.cmbderch.Size = new System.Drawing.Size(202, 37);
            this.cmbderch.TabIndex = 15;
            // 
            // btsearch
            // 
            this.btsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btsearch.Location = new System.Drawing.Point(127, 18);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(99, 38);
            this.btsearch.TabIndex = 13;
            this.btsearch.Text = "جستجو";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // btall
            // 
            this.btall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btall.Location = new System.Drawing.Point(22, 18);
            this.btall.Name = "btall";
            this.btall.Size = new System.Drawing.Size(99, 38);
            this.btall.TabIndex = 14;
            this.btall.Text = "همه";
            this.btall.UseVisualStyleBackColor = true;
            this.btall.Click += new System.EventHandler(this.btall_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(914, 21);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(153, 29);
            this.lblsearch.TabIndex = 0;
            this.lblsearch.Text = "جستجو بر حسب :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.fatherDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.generDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.nationalCodeDataGridViewTextBoxColumn,
            this.fileNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personInformationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 230);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.familyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "تلفن همراه";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // fatherDataGridViewTextBoxColumn
            // 
            this.fatherDataGridViewTextBoxColumn.DataPropertyName = "Father";
            this.fatherDataGridViewTextBoxColumn.HeaderText = "نام پدر";
            this.fatherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fatherDataGridViewTextBoxColumn.Name = "fatherDataGridViewTextBoxColumn";
            this.fatherDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "نام پزشک";
            this.doctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.Width = 130;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 140;
            // 
            // generDataGridViewTextBoxColumn
            // 
            this.generDataGridViewTextBoxColumn.DataPropertyName = "Gener";
            this.generDataGridViewTextBoxColumn.HeaderText = "جنسیت";
            this.generDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generDataGridViewTextBoxColumn.Name = "generDataGridViewTextBoxColumn";
            this.generDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "تاریخ تولد";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // nationalCodeDataGridViewTextBoxColumn
            // 
            this.nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "National code";
            this.nationalCodeDataGridViewTextBoxColumn.HeaderText = "کدملی";
            this.nationalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
            this.nationalCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fileNumberDataGridViewTextBoxColumn
            // 
            this.fileNumberDataGridViewTextBoxColumn.DataPropertyName = "File number";
            this.fileNumberDataGridViewTextBoxColumn.HeaderText = "شماره پرونده";
            this.fileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fileNumberDataGridViewTextBoxColumn.Name = "fileNumberDataGridViewTextBoxColumn";
            this.fileNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // personInformationBindingSource
            // 
            this.personInformationBindingSource.DataMember = "person information";
            this.personInformationBindingSource.DataSource = this.dBINFORMATION1DataSet;
            // 
            // dBINFORMATION1DataSet
            // 
            this.dBINFORMATION1DataSet.DataSetName = "DBINFORMATION1DataSet";
            this.dBINFORMATION1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // person_informationTableAdapter
            // 
            this.person_informationTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1296, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم  اطلاعات پزشکی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBINFORMATION1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblfathername;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label lblbirthday;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.MaskedTextBox mstbirthday;
        private System.Windows.Forms.MaskedTextBox mstcode;
        private System.Windows.Forms.MaskedTextBox mstphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtdoctor;
        private System.Windows.Forms.TextBox txtfathername;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btedite;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button btall;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cmbderch;
        private System.Windows.Forms.ComboBox cmbgener;
        private System.Windows.Forms.Button btezafe;
        private System.Windows.Forms.MaskedTextBox mstfilenumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBINFORMATION1DataSet dBINFORMATION1DataSet;
        private System.Windows.Forms.BindingSource personInformationBindingSource;
        private DBINFORMATION1DataSetTableAdapters.person_informationTableAdapter person_informationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

