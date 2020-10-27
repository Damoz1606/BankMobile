using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Mobile.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public double _amount { get; set; }
        public string _type { get; set; }
        public DateTime _transaction_date { get; set; }
        public override string ToString()
        {
            return _type + ": $" + _amount + "\t\t" + _transaction_date.ToString();
        }
        [ForeignKey(typeof(Bank_Account))]
        public int BankID { get; set; }
    }
}
