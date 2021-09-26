using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy
{
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhay\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {

            con.Open();
            String Myquery = "Select * from Employee_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            empgridview.ReadOnly = true;
            empgridview.DataSource = ds.Tables[0];
            con.Close();

        }
        public Employee()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(empid.Text==" "|| empname.Text==" "||empage.Text==" "|| empsalary.Text==" "||empnumber.Text==" "|| emppasswor.Text==" ")
            {
                MessageBox.Show("Please Eneter all the details Below");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee_tbl values('" + empid.Text + "','" + empname.Text + "', " + empsalary.Text + ", " + empage.Text + ", '" + empnumber.Text + "', '"+emppasswor.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added.");
                con.Close();
                populate();
            }
        
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            String Myquery = "UPDATE Employee_tbl SET Empname = '" + empname.Text + "', Empage = " + empage.Text + ", Empsalary = " + empsalary.Text + ",Empphone='" + empnumber.Text + "', Emppassword = '" + emppasswor.Text + "'WHERE EmpId = '" + empid.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Updated successfully.");
            con.Close();
            populate();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (empname.Text == " ")
            {
                MessageBox.Show("Wrong Operation. Click on the Employee to be deleted....");
            }
            else
            {
                con.Open();
                String Myquery = "DELETE Employee_tbl WHERE EmpId = '" + empid.Text + "';";
                SqlCommand cmd = new SqlCommand(Myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted successfully.");
                con.Close();
                populate();
            }
        }

        private void empage_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empnumber_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empid.Text = empgridview.SelectedRows[0].Cells[0].Value.ToString();
            empname.Text = empgridview.SelectedRows[0].Cells[1].Value.ToString();
            empsalary.Text = empgridview.SelectedRows[0].Cells[2].Value.ToString();
            empage.Text = empgridview.SelectedRows[0].Cells[3].Value.ToString();
            empnumber.Text = empgridview.SelectedRows[0].Cells[4].Value.ToString();
            emppasswor.Text = empgridview.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage m = new HomePage();
            m.Show();
        }
    }
}
