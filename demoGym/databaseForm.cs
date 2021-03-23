using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoGym
{
    public partial class databaseForm : Form
    {
        public databaseForm()
        {
            InitializeComponent();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            startForm startForm = new startForm();
            startForm.Show();
        }

        public SD.DataSet dataSet;

        private void updateButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());


            db.openConnection();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            SD.DataTable table = new SD.DataTable();
            mySqlDataAdapter.Fill(table);
            dataGridView.DataSource = table;

            db.closeConnection();
        }
    }
}
