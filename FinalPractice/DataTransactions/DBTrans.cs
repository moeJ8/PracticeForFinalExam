using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using FinalPractice;
using FinalPractice.Models;

namespace FinalPractice.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string dbPath)
        {
            this.dbPath = dbPath;
            Init();
        }
        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<Address>();
            conn.CreateTable<Card>();
            conn.CreateTable<Bills>();
        }

        public List<Address> GetAddresses()
        {
            return conn.Table<Address>().ToList();
        }
        public List<Card> GetCards()
        {
            return conn.Table<Card>().ToList();
        }

        public List<Bills> GetBills()
        {

            return conn.Table<Bills>().ToList();
        }

        public void AddAddress(Address address)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(address);
        }
        public void AddCard(Card card)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(card);
        }
        public void AddBill(Bills bill)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(bill);
        }
        public void DeleteAddress(int Address_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Address { Address_ID = Address_ID });
        }
        public void DeleteCard(int Card_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Card { Card_ID = Card_ID });
        }
        public void DeleteBill(int Bill_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Bills { Bill_ID = Bill_ID });
        }

    }
}
