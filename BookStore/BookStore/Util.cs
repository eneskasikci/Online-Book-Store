using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Net.Mail;

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

        public static void SendSms(string msg, string number)
        {
            const string accountSid = "ACe78dee08a57ea35e2e4507fb8dbac202";
            const string authToken = "86b14d10705beb72c9b79e58a1e1f292";
            TwilioClient.Init(accountSid, authToken);
            try
            {
                var message = MessageResource.Create(
                    body: msg,
                    from: new Twilio.Types.PhoneNumber("+18588341704"),
                    to: new Twilio.Types.PhoneNumber(number)
                );
                Console.WriteLine(message.Sid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while sending SMS ; " + ex.Message);
            }

        }
        private static void SendEmail(string message, string subject, string mail)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-mail.outlook.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("ooplab2_23@outlook.com", "BoburshohEnesMurat");
            MailMessage eposta = new MailMessage();
            eposta.From = new MailAddress("ooplab2_23@outlook.com");
            eposta.To.Add(mail);
            eposta.Subject = subject;
            eposta.Body = message;
            int sent = 0;
            try
            {
                smtp.Send(eposta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while sending email." + ex.Message);
                sent = -1;
            }
            if (sent == 0)
            {
                MessageBox.Show("Email sent succesfully");
            }
        }
    }
}
