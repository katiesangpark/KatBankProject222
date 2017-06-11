using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    
    /// <summary>
    /// 
    /// This calss represents a bank account
    /// Here you can deposit/withdraw.
    /// </summary>
    class Account
    {
        #region Variables

        private static int lastAccountNum = 0;


        #endregion

        #region Constructors
        public Account()
        {
            AccountNumber = ++lastAccountNum;
        }

        public Account(string emailAddress) : this()
         {
            EmailAddress = emailAddress;
         }

        public Account(string emailAddress, string typeOfAccount): this(emailAddress)
        {
            TypeOfAccount = typeOfAccount;
        }


        #endregion


        #region Properties
        /// <summary>
        /// 
        /// Email Address of the account owner
        /// </summary>
        //prop tabtab
        public string EmailAddress { get; set; }

        public int AccountNumber { get; private set; }

        public decimal Balance { get; private set; }

        public string TypeOfAccount { get; set; }

        #endregion
   

        #region Methods
   
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        /// <returns>The updated balance</returns>
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion
    }
}
