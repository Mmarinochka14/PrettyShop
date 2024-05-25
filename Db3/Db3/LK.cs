using Db3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db3
{
    public partial class LK : Form
    {
        public Customer currentCustomer;
        public LK()
        {
            InitializeComponent();
        }

        public LK(Customer customer)
        {
            InitializeComponent();
            this.currentCustomer = customer;

            NameBox.Text = currentCustomer.Name;
            PassBox.Text = currentCustomer.Password;
            AddressBox.Text = currentCustomer.Address;
            PhoneBox.Text = currentCustomer.Phone;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DbConnector db = new DbConnector();
            db.UpdateUserData(NameBox.Text, PassBox.Text, AddressBox.Text, currentCustomer.Phone);
            MessageBox.Show("Done!");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DbConnector db = new DbConnector();
            db.DeleteUserData(currentCustomer.Name);
            MessageBox.Show("Account have been successfully deleted");

            this.Hide();
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm(currentCustomer);
            shopForm.Show();
        }
    }
}
