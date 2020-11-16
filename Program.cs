// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aryav Tiwari"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookProblemLINQ
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Welcome to the Address Book Data LINQ Program");
            Console.WriteLine("========================================================");
            /// Creating the instance of the address book repository
            /// Automatically populates the list for LINQ operation
            AddressBookRepository bookRepository = new AddressBookRepository();
            /// UC3 -- Functionality to add more contacts
            //bookRepository.AddMoreContacts();
            /// UC4 -- To edit the data using the name
            bookRepository.UpdateContactUsingName();
        }
    }
}