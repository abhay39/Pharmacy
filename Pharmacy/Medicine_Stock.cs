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
    public partial class Medicine_Stock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abhay\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            
                con.Open();
                String Myquery = "Select * from Pharma";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                medgridview.ReadOnly = true;
                medgridview.DataSource = ds.Tables[0];
                con.Close();
            
        }
        public Medicine_Stock()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            medname.Text = medgridview.SelectedRows[0].Cells[0].Value.ToString();
            bptb.Text = medgridview.SelectedRows[0].Cells[1].Value.ToString();
            sptb.Text = medgridview.SelectedRows[0].Cells[2].Value.ToString();
            qttb.Text = medgridview.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (medname.Text == " " || bptb.Text == " " || sptb.Text == " " || qttb.Text == " " || comcb.SelectedItem == null)
            {
                MessageBox.Show("Please enter all the data below...");
            }
            else { 
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Pharma values('" +medname.Text + "'," + bptb.Text + ", " + sptb.Text + ", " + qttb.Text + ", '" + expdate.Text + "', '" + comcb.SelectedItem.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Successfully Added.");
            con.Close();
            populate();
            }
        }

        private void Medicine_Stock_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            String Myquery = "UPDATE Pharma SET BPrice = " + bptb.Text + ", SPrice = " + sptb.Text + ", Qty = " + qttb.Text + ",ExpDate='" + expdate.Text + "', Company = '" + comcb.SelectedItem.ToString() + "'WHERE MedName = '" + medname.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Updated successfully.");
            con.Close();
            populate();
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(medname.Text ==" ")
            {
                MessageBox.Show("Wrong Operation. Click on the Medicine to be deleted....");
            }
            else { 
            con.Open();
            String Myquery = "DELETE Pharma WHERE MedName = '" + medname.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Deleted successfully.");
            con.Close();
            populate();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage m = new HomePage();
            m.Show();
        }
    }
}
