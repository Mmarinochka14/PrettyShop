using Db3.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Db3
{
    public partial class OrderForm : Form
    {
        private Customer currentCustomer;
        public OrderForm(Customer customer)
        {
            InitializeComponent();
            this.currentCustomer = customer;
            LoadProducts();
            addressBox.Text = currentCustomer.Address;
            
        }

        private void LoadProducts()
        {
            using (DbConnector db = new DbConnector())
            {
                db.OpenConnection();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    MySqlCommand command = new MySqlCommand("SELECT p.* FROM product p JOIN cart c ON p.product_id = c.product_id WHERE c.customer_id = @userId", db.GetConnection());
                    command.Parameters.AddWithValue("@userId", currentCustomer.Id);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);

                    Order.Items.Clear();

                   
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string productName = row["name"].ToString();
                        string productPrice = row["price"].ToString();
                        string productDesc = row["description"].ToString();
                       
                        ListViewItem item = new ListViewItem(new string[] { productName, productDesc, productPrice });
                        Order.Items.Add(item);
                    }
                }
                db.CloseConnection();
            }
        }

        // Вспомогательный метод для конвертации байтового массива в изображение
       
       
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LK lK = new LK();
            lK.Show();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        
        private void Cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm cartForm = new CartForm(currentCustomer);
            cartForm.Show();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            /*DbConnector db = new DbConnector();
            MySqlCommand command = new MySqlCommand("INSERT INTO order (product_id, customer_id, nickname, phone, address, password) VALUES (@id, @nickname, @phone, @address, @pass)", db.GetConnection());

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

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account has been successfuly created");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
                MessageBox.Show("Try again");

            db.CloseConnection();

            */
        }
    }
    
}

