using System;

namespace HeadyStudios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of an account == object
            var UserAccount = new UserAccount
            {
                EmailAddress = "Test@test.com"

            };

            UserAccount.Deposit3mm(22);
            UserAccount.Deposit14mm(5);
            UserAccount.DepositAqua(4);

            Console.WriteLine($"Email Address: {UserAccount.EmailAddress}," +
                $"Account Number: {UserAccount.AccountNumber}," +
                $"Created Date: {UserAccount.DateCreated}, " +
                $"Clear Rod 3mm: {UserAccount.ClearRod3mm}," +
                $"Clear Rod 14mm: {UserAccount.ClearRod14mm}, " +
                $"Aqua Azul Rod: {UserAccount.AquaAzulRod} ");

            var UserAccount2 = new UserAccount();


            Console.WriteLine($"Email Address: {UserAccount2.EmailAddress}," +
                $"Account Number: {UserAccount2.AccountNumber}," +
                $"Created Date: {UserAccount2.DateCreated}, " +
                $"Clear Rod 3mm: {UserAccount2.ClearRod3mm}," +
                $"Clear Rod 14mm: {UserAccount2.ClearRod14mm}, " +
                $"Aqua Azul Rod: {UserAccount2.AquaAzulRod} ");

            UserAccount2.Deposit3mm(5);
            UserAccount2.Deposit14mm(56);
            UserAccount2.DepositAqua(34);

            var UserAccount3 = new UserAccount();

            Console.WriteLine($"Email Address: {UserAccount3.EmailAddress}," +
                $"Account Number: {UserAccount3.AccountNumber}," +
                $"Created Date: {UserAccount3.DateCreated}, " +
                $"Clear Rod 3mm: {UserAccount3.ClearRod3mm}," +
                $"Clear Rod 14mm: {UserAccount3.ClearRod14mm}, " +
                $"Aqua Azul Rod: {UserAccount3.AquaAzulRod} ");

            UserAccount3.Deposit3mm(5);
            UserAccount3.Deposit14mm(56);
            UserAccount3.DepositAqua(34);
        }
    }
}
