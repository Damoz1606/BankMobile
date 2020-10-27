using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Bank_Mobile.Models
{
    [Table("Client")]
    public class Client
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string _id_number { get; set; }
        public string _name { get; set; }
        public string _surname { get; set; }
        public string FullName
        {
            get => _name + " " + _surname;
        }
        [ForeignKey(typeof(Bank_Account))]
        public int BankID { get; set; }
    }
}
