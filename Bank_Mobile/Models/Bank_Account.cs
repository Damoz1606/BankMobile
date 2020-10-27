using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Mobile.Models
{
    [Table("BankAccount")]
    public class Bank_Account
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string _id_account { get; set; }
        public double _balance { get; set; }
        public DateTime _creation { get; set; }
        public Bank_Account()
        {
            _transactions = new List<Transaction>();
        }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Transaction> _transactions { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Client _client { get; set; }
    }
}
