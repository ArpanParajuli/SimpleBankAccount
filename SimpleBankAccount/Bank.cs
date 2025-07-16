    using System;
using System.CodeDom;
using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace SimpleBankAccount
    {
        public partial class Bank: Form
        {
        List<Customer> Customers = new List<Customer>();
        public Bank()
            {
              InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e) // create account
            {

            if (float.TryParse(textBox3.Text, out float amount))
            {
                try
                {

                    foreach(var customer in Customers)
                    {
                        if(customer.Customer_name == textBox3.Text)
                        {
                            throw new Exception("Customer Account ID already exists");
                        }

                        if (customer.Customer_name == textBox1.Text)
                        {
                            throw new Exception("Customer name already exists");
                        }
                    }

                    if (amount >= 0 && amount <= 100000)
                    {
                        Customer c = new Customer(textBox1.Text, textBox2.Text, amount);
                        Customers.Add(c);
                        MessageBox.Show("Account created successfully");
                        textBox7.Text += "Account created : " + c.Customer_name + " : " + c.accountNumber + Environment.NewLine;
                    }

                    else
                    {
                        throw new Exception("Amount input exceed");
                    }
                }

                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }

            }

            else
            {
                MessageBox.Show("Please enter a valid number for age.");
            }
            }

            private void Bank_Load(object sender, EventArgs e)
            {
               
            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e) // name
            {

            }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter valid Account number");
            }

            foreach (var customer in Customers)
            {
                if (textBox4.Text == customer.accountNumber)
                {
                    textBox6.Text = customer.Balance.ToString();
                }
                else
                {
                    MessageBox.Show("Incorrect account number!");
                }

            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter valid Account number");
            }

            foreach (var customer in Customers)
            {
                if (textBox4.Text == customer.accountNumber)
                {
                    if ( float.TryParse(textBox5.Text, out float amount))
                    {
                       await customer.DepositAsync(amount);
                        textBox7.Text += "Amount Deposited  : " + customer.Customer_name + " : " + customer.accountNumber + " | " + amount  + Environment.NewLine;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect account number!");
                }

            }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter valid Account number");
            }

            foreach (var customer in Customers)
            {
                if (textBox4.Text == customer.accountNumber)
                {
                    if(float.TryParse(textBox5.Text , out float amount)){
                        await customer.WithdrawAsync(amount);
                        textBox7.Text += "Amount Withdraw  : " + customer.Customer_name + " : " + customer.accountNumber + " | " + amount + Environment.NewLine;

                    }
                }

                else
                {
                    MessageBox.Show("Incorrect account number!");
                }

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }
