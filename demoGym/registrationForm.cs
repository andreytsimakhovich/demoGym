using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace demoGym
{
    public partial class registrationForm : Form
    {
        public object MysqlCommand { get; private set; }

        public registrationForm()
        {
            InitializeComponent();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            startForm startForm = new startForm();
            startForm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`lastName`, `firstName`) VALUES (@lN, @fN)", db.getConnection());

            command.Parameters.Add("@lN", MySqlDbType.VarChar).Value = lastNameTextBox.Text;
            command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = firstNameTextBox.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Клиент добавлен в базу!");
                this.Hide();
                startForm startForm = new startForm();
                startForm.Show();
            }
            else
                MessageBox.Show("Ошибка регистрации!");
            db.closeConnection();
        }
    }
}
