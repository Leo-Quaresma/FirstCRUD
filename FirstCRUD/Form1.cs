using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radNoDeadline.Checked = true;
            datePicker.Enabled = false;


        }

        SqlConnection con = new SqlConnection("Data Source=LEOZITOS\\MIMIMIDB;Initial Catalog=EisenhowerDb;Integrated Security=True;Encrypt=False");
        private void Form1_Load(object sender, EventArgs e)
        {
            TableShow();
        }

        void TableShow()
        {
            SqlCommand cmd = new SqlCommand("dbo.Tasks_Read", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
        }

        //Search Logic
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            using(SqlCommand cmd = new SqlCommand("dbo.Task_Search", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Task_id", textTaskId.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            }

            con.Close();
        }

        //Task Insert Logic
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            //DateTime type that can be nullable if the deadline isn't picked
            DateTime? deadline = radDeadline.Checked ? (DateTime?)datePicker.Value : null;

            string urgency = radUrgent.Checked ? "Urgent" : "Not Urgent";

            string importancy = radImportant.Checked ? "Important" : "Not Important";

            con.Open();
            using (SqlCommand cmd = new SqlCommand("dbo.Task_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Task_name", textTaskName.Text);
                cmd.Parameters.AddWithValue("@Deadline", deadline);
                cmd.Parameters.AddWithValue("@Urgency", urgency);
                cmd.Parameters.AddWithValue("@Importancy", importancy);
                cmd.Parameters.AddWithValue("@Task_description", textTaskDescription.Text);
                cmd.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Data inserted successfully");

            TableShow();
            textTaskId.Focus();
        }
        //Update Task Logic
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //DateTime type that can be nullable if the deadline isn't picked
            DateTime? deadline = radDeadline.Checked ? (DateTime?)datePicker.Value : null;

            string urgency = radUrgent.Checked ? "Urgent" : "Not Urgent";

            string importancy = radImportant.Checked ? "Important" : "Not Important";

            con.Open();
            using (SqlCommand cmd = new SqlCommand("dbo.Task_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Task_id", textTaskId.Text);
                cmd.Parameters.AddWithValue("@Task_name", textTaskName.Text);
                cmd.Parameters.AddWithValue("@Deadline", deadline);
                cmd.Parameters.AddWithValue("@Urgency", urgency);
                cmd.Parameters.AddWithValue("@Importancy", importancy);
                cmd.Parameters.AddWithValue("@Task_description", textTaskDescription.Text);
                cmd.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Data updated successfully");

            TableShow();
            textTaskId.Focus();
        }

        //Delete Task Logic
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            if (MessageBox.Show("Are you sure you want to delete this task?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               using (SqlCommand cmd = new SqlCommand("dbo.Task_Delete", con))
               {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Task_id", textTaskId.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();
            MessageBox.Show("Deleted Successfully");

            TableShow();
            textTaskId.Focus();
        }

        //Activating or desactivating DateTimePicker
        private void radDeadline_CheckedChanged(object sender, EventArgs e)
        {
            if (radDeadline.Checked)
            {
                datePicker.Enabled = true;
            }
            else
            {
                datePicker.Enabled = false;
            }
        }

        private void textTaskId_MouseDown(object sender, MouseEventArgs e)
        {
            textTaskId.Text = string.Empty;
        }
    }
}
