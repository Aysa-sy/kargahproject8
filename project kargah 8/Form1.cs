using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kargah_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBINFORMATION1DataSet.person_information' table. You can move, or remove it, as needed.
            this.person_informationTableAdapter.Fill(this.dBINFORMATION1DataSet.person_information);
            // TODO: This line of code loads data into the 'dB_patientDataSet.patient' table. You can move, or remove it, as needed.
            this.person_informationTableAdapter.Fill(this.dBINFORMATION1DataSet.person_information);

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtdoctor.Text = "";
            txtfathername.Text = "";
            txtlastname.Text = "";
            txtname.Text = "";
            mstbirthday.Text = "";
            mstcode.Text = "";
            mstfilenumber.Text="";
            mstphone.Text = "";
            txtname.Focus();
            mstphone.Enabled = true;
        }

        private void btezafe_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != string.Empty && txtlastname.Text != string.Empty && mstphone.Text != string.Empty && txtfathername.Text != string.Empty && mstcode.Text != string.Empty && mstfilenumber.Text != string.Empty)
                {
                    DataTable dd = new DataTable();
                    dd = person_informationTableAdapter.selectmobile(mstphone.Text);
                    if (dd.Rows.Count > 0)
                    {
                        MessageBox.Show("این شماره موبایل برای شخص دیگری ثبت شده است");
                    }
                    else
                    {
                        person_informationTableAdapter.InsertQuery(txtname.Text, txtfathername.Text, mstphone.Text, txtfathername.Text, txtdoctor.Text, txtaddress.Text, cmbgener.Text, mstbirthday.Text, mstcode.Text, mstfilenumber.Text);
                        person_informationTableAdapter.Fill(dBINFORMATION1DataSet.person_information);
                        MessageBox.Show("اطلاعات با موفقیت اضافه شد");
                    }
                }
                else
                {
                    MessageBox.Show("لطفا مقادیر مورد نیاز را وارد نمایید");
                }
            }
            catch
            {
                MessageBox.Show("عملیات ناموفق بود");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtlastname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mstphone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtfathername.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtdoctor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtaddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbgener.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mstbirthday.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            mstcode.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            mstfilenumber.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void btedite_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != string.Empty && txtlastname.Text != string.Empty && mstphone.Text != string.Empty && txtfathername.Text != string.Empty && mstcode.Text != string.Empty && mstfilenumber.Text != string.Empty)
                {
                        person_informationTableAdapter.UpdateQuery(txtname.Text, txtfathername.Text, mstphone.Text, txtfathername.Text, txtdoctor.Text, txtaddress.Text, cmbgener.Text, mstbirthday.Text, mstcode.Text, mstfilenumber.Text ,mstphone.Text);
                        person_informationTableAdapter.Fill(dBINFORMATION1DataSet.person_information);
                        MessageBox.Show("اطلاعات با موفقیت اضافه شد");
                }
                else
                {
                    MessageBox.Show("لطفا مقادیر مورد نیاز را وارد نمایید");
                }
            }
            catch
            {
                MessageBox.Show("عملیات ناموفق بود");
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                person_informationTableAdapter.DeleteQuery(mstphone.Text);
                person_informationTableAdapter.Fill(dBINFORMATION1DataSet.person_information);
                MessageBox.Show("اطلاعات با موفقیت اضافه شد");
                btadd_Click(null, null);
            }
            catch
            {
                MessageBox.Show("عملیات ناموفق بود");
            }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                if (cmbderch.Text == "نام" && txtsearch.Text != string.Empty)
                {
                    DataTable dd = new DataTable();
                    dd = person_informationTableAdapter.selectname(txtsearch.Text);
                    dataGridView1.DataSource = dd;
                }
                else if (cmbderch.Text == "نام خانوادگی" && txtsearch.Text != string.Empty)
                {
                    DataTable dd = new DataTable();
                    dd = person_informationTableAdapter.selectlastname(txtsearch.Text);
                    dataGridView1.DataSource = dd;
                }
                else if (cmbderch.Text == "شماره تلفن" && txtsearch.Text != string.Empty)
                {
                    DataTable dd = new DataTable();
                    dd = person_informationTableAdapter.selectmobile(txtsearch.Text);
                    dataGridView1.DataSource = dd;
                }
                else if (cmbderch.Text == "نام پزشک" && txtsearch.Text != string.Empty)
                {
                    DataTable dd = new DataTable();
                    dd = person_informationTableAdapter.selectdoctor(txtsearch.Text);
                    dataGridView1.DataSource = dd;
                }
                else if (cmbderch.Text == "کدملی" && txtsearch.Text != string.Empty)
                {
                    DataTable dd = new DataTable();
                    dd = person_informationTableAdapter.selectcode(txtsearch.Text);
                    dataGridView1.DataSource = dd;
                }
                else if (cmbderch.Text == "شماره پرونده" && txtsearch.Text != string.Empty)
                {
                    DataTable dd = new DataTable();
                    dd = person_informationTableAdapter.selectfilenumber(txtsearch.Text);
                    dataGridView1.DataSource = dd;
                }
                else
                {
                    MessageBox.Show("مقداری را برای جستجو مشخص نکردید");
                }
            }
            catch
            {
                MessageBox.Show("عملیات ناموفق بود");
            }

        }

        private void btall_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                DataTable dd = new DataTable();
                dd = person_informationTableAdapter.selectall();
                dataGridView1.DataSource = dd;
            }
            catch
            {
                MessageBox.Show("عملیات ناموفق بود");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
