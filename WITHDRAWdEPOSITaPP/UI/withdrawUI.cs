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

namespace WITHDRAWdEPOSITaPP
{
    public partial class withdrawUI : Form
    {
        public withdrawUI()
        {
            InitializeComponent();
        }

        private string connectionString =
            @"SERVER=PC-07\SQLEXPRESS; DATABASE = Employedb; Integrated Security = true; providerName= ";

        private void withdrawButton_Click(object sender, EventArgs e)
        {

        }

        private void reportButton_Click(object sender, EventArgs e)
        {

        }

        private void depositButton_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;



            double salary = Convert.ToDouble(salaryTextBox.Text);


            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO employe VALUES ('" + Name + "','" + Email + "','" + address + " ',' " + salary +
                           " ')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}
