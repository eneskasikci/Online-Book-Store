using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace BookStore
{
    public static class Util
    {
        public static void LoadCustomer(List<Customer> customerList)
        {
            if (!File.Exists(@"customer.csv"))
            {
                StreamWriter create = File.CreateText(@"customer.csv");
                create.Close();
            }
            StreamReader reader = new StreamReader(@"customer.csv");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != "")
                {
                    var values = line.Split(',');
                    Customer customer = new Customer();
                    customer.saveCustomer(int.Parse(values[0]), values[1], values[2], 
                                                    values[3], values[4], values[5]);
                    customerList.Add(customer);
                }
            }
            reader.Close();
        }

        public static void SaveCustomer(List<Customer> customerList)
        {
            StreamWriter write = File.CreateText(@"customer.csv");
            foreach (Customer customer in customerList)
                write.WriteLine(customer.printCustomerDetails());
            write.Close();
        }

        public static void LoadBooks(List<Book> booksList)
        {

            StreamReader reader = new StreamReader("../../Content/books.csv");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != "")
                {
                    var values = line.Split(',');
                    booksList.Add(new Book((values[0]), values[1], values[2],
                    values[3], values[4], values[5], values[6]));
                }
            }
            reader.Close();
        }

        public static void LoadMagazines(List<Magazine> magazineList)
        {
            StreamReader reader = new StreamReader("../../Content/magazines.csv");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != "")
                {
                    var values = line.Split(',');
                    magazineList.Add(new Magazine((values[0]), values[1], values[2], values[3], values[4]));
                }
            }
            reader.Close();
        }

        public static void LoadCDs(List<MusicCD> musicCDList)
        {
            StreamReader reader = new StreamReader("../../Content/cds.csv");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != "")
                {
                    var values = line.Split(',');
                    musicCDList.Add(new MusicCD((values[0]), values[1], values[2], values[3], values[4]));
                }
            }
            reader.Close();
        }

        public static bool IsDoubleUsername(string username)
        {
            foreach (Customer customer in Login.customerList)
            {
                if (customer.Username == username)
                    return true;
            }
            return false;
        }
    }
}
