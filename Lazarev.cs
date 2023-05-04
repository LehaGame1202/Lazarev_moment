using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lazarev_moment.Models;

namespace Lazarev_moment
{
    public partial class Form1 : Form
    {
        BindingList<Customer> customers = new BindingList<Customer>();
        public Form1()
        {
            InitializeComponent();
            customers.Add(new Customer("Alex", "GNing", "Gdgsa"));
            customers.Add(new Customer("Alex", "GNing", "Gdgsa"));
            customers.Add(new Customer("Alex", "GNing", "Gdgsa"));
            listbox_customers.DataSource = customers;
            listbox_orders.DataBindings;
        }
        Customer selectedCustomer;
        Order selectedOrder;
        private Customer SelectedCustomer { get { return selectedCustomer; } set { selectedCustomer = value; } }
        private Order SelectedOrder { get { return selectedOrder; } set {  selectedOrder = value; } }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listbox_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listbox_customers.SelectedItem != null) 
                SelectedCustomer = listbox_customers.SelectedItem as Customer;
        }

        private void listbox_orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_orders.SelectedItem != null)
                SelectedOrder = listbox_orders.SelectedItem as Order;
        }

        private void dataGridView_products_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
