using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;


class Customer
    {
        public string Customer_name { get; set; }

        public string accountNumber { get; set; }

        public float Balance { get; set;}


    public Customer(string name , string accountNumber , float Balance)
    {
        this.Customer_name = name;
        this.accountNumber = accountNumber;
        this.Balance = Balance;
    }


        public async Task DepositAsync(float amount)
        {

        try
        {
            await Task.Delay(1000);
            if (amount >= 0 && amount <= 100000) // 1 lakh per one time
            {

                if (amount >= 1 && amount <= 100000) // 10lakhs
                {
                    this.Balance += amount;
                }

                else
                {
                    throw new Exception("Invalid Amount");
                }

            }

            else
            {
                throw new Exception("Deposit Amount is more!");
            }
                
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
            
        }

        public async Task WithdrawAsync(float amount)
        {
        try
        {



           await Task.Delay(1000);

            if(amount >= 0 && amount <= 100000) // 1 lakh per one time
            {
                if (amount >= 0 && amount <= this.Balance) // 10lakhs
                {
                    this.Balance -= amount;
                }

                else
                {
                    throw new Exception("Invalid Amount");
                }
            }


            else
            {
                throw new Exception("Withdrawn Amount is more!");
            }
          

        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        }
    }

