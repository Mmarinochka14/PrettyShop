using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db3
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.PassBox.AutoSize = false;
            this.PassBox.Size = new Size(this.PassBox.Size.Width, 64);

            PhoneBox.Text = "Enter phone";
            PhoneBox.ForeColor = Color.Gray;

            AddressBox.Text = "Enter address";
            AddressBox.ForeColor = Color.Gray;

            LogBox.Text = "Enter name";
            LogBox.ForeColor = Color.Gray;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void regPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void regPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PhoneBox_Enter(object sender, EventArgs e)
        {
            if (PhoneBox.Text == "Enter phone") 
            {
                PhoneBox.Text = "";
                PhoneBox.ForeColor = Color.Black;
            }

        }

        private void PhoneBox_Leave(object sender, EventArgs e)
        {
            if (PhoneBox.Text == "")
            {
                PhoneBox.Text = "Enter phone";
                PhoneBox.ForeColor = Color.Gray;
            }
        }


        private void AddressBox_Enter(object sender, EventArgs e)
        {
            if (AddressBox.Text == "Enter address")
            {
                AddressBox.Text = "";
                AddressBox.ForeColor = Color.Black;
            }

        }

        private void AddressBox_Leave(object sender, EventArgs e)
        {
            if (AddressBox.Text == "")
            {
                AddressBox.Text = "Enter address";
                AddressBox.ForeColor = Color.Gray;
            }
        }

        private void LogBox_Enter(object sender, EventArgs e)
        {
            if (LogBox.Text == "Enter name")
            {
                LogBox.Text = "";
                LogBox.ForeColor = Color.Black;
            }

        }

        private void LogBox_Leave(object sender, EventArgs e)
        {
            if (LogBox.Text == "")
            {
                LogBox.Text = "Enter name";
                LogBox.ForeColor = Color.Gray;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(LogBox.Text == "Enter name")
            {
                MessageBox.Show("Enter name");
                return;
            }

            if (PhoneBox.Text == "Enter phone")
            {
                MessageBox.Show("Enter phone");
                return;
            }

            if (PassBox.Text == "Enter password")
            {
                MessageBox.Show("Enter password");
                return;
            }

            if (AddressBox.Text == "Enter address")
            {
                MessageBox.Show("Enter address");
                return;
            }

            DbConnector db = new DbConnector();
            MySqlCommand command = new MySqlCommand("INSERT INTO customer (customer_id, nickname, phone, address, password) VALUES (@id, @nickname, @phone, @address, @pass)", db.GetConnection());
            
            Random rand = new Random();
            int randomNumber = rand.Next(1, 10000);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = randomNumber;
            command.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = LogBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassBox.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = PhoneBox.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = AddressBox.Text;

            db.OpenConnection();

            if (CheckUserExistence())
                return;

            if(command.ExecuteNonQuery() ==1) 
            {
                MessageBox.Show("Account has been successfuly created");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
                MessageBox.Show("Try again");

            db.CloseConnection();

            
        }


        public Boolean CheckUserExistence()
        {
            DbConnector db = new DbConnector();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM customer WHERE nickname = @ul", db.GetConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LogBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("You already have an account");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void LogiBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}