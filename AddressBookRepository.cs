﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookRepository.cs" company="Bridgelabz">
//  Copyright © 2018 Company
// </copyright>
// <creator Name="Aryav Tiwari"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookProblemLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    public class AddressBookRepository
    {
        /// <summary>
        /// List to store the instances of address book model or records of address book
        /// </summary>
        public static List<AddressBookModel> addressBookModels = new List<AddressBookModel>();
        /// <summary>
        /// Creating the instance of the Address Book Model Class
        /// </summary>
        public AddressBookModel bookModel = new AddressBookModel();
        /// <summary>
        /// Parameterised constructor intended to add the data to the DB Model
        /// </summary>
        public AddressBookRepository()
        {
            /// Inserting the data into the list using add operation
            addressBookModels.Add(new AddressBookModel { firstName = "Mohan", secondName = "Yadav", address = "Sec-1", city = "Dwarka", state = "Gujarat", zip = 110245, phoneNumber = 9895656235, emailId = "mohan@gmail.com", contactType = "Friends", addressBookName = "MyRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Arjun", secondName = "Rajput", address = "Sec-2", city = "Hastinapur", state = "Haryana", zip = 110022, phoneNumber = 9789556235, emailId = "arjun@gmail.com", contactType = "Family", addressBookName = "MyRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Bheem", secondName = "Rajput", address = "Sec-3", city = "Hastinapur", state = "Haryana", zip = 256123, phoneNumber = 7895656235, emailId = "bheem@gmail.com", contactType = "Family", addressBookName = "MyRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Nakul", secondName = "Rajput", address = "Sec-4", city = "Hastinapur", state = "Haryana", zip = 274365, phoneNumber = 9963656235, emailId = "nakul@gmail.com", contactType = "Family", addressBookName = "MyRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Sehdeva", secondName = "Rajput", address = "Sec-4", city = "Hastinapur", state = "Haryana", zip = 116445, phoneNumber = 7206656235, emailId = "sehdeva@gmail.com", contactType = "Family", addressBookName = "MyRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Rukmini", secondName = "Vaidarbhi", address = "Sec-3", city = "Vidarbh", state = "UP", zip = 274304, phoneNumber = 9450656235, emailId = "rukmini@gmail.com", contactType = "Friends", addressBookName = "MyRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Sandipani", secondName = "Chaturvedi", address = "Sec-8", city = "Mumbai", state = "Maharastra", zip = 160030, phoneNumber = 7645656235, emailId = "sandipani@gmail.com", contactType = "Profession", addressBookName = "MyRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Satyiki", secondName = "Sharma", address = "Sec-7", city = "Delhi", state = "Delhi", zip = 110235, phoneNumber = 9658741200, emailId = "satyiki@gmail.com", contactType = "Friends", addressBookName = "MyRecord" });
        }
        /// <summary>
        /// UC3 -- Method to add more ocntacts later
        /// </summary>
        public void AddMoreContacts()
        {
            Console.WriteLine("Enter the First Name :");
            bookModel.firstName = Console.ReadLine();
            Console.WriteLine("Enter the Second Name :");
            bookModel.secondName = Console.ReadLine();
            Console.WriteLine("Enter the Address :");
            bookModel.address = Console.ReadLine();
            Console.WriteLine("Enter the City :");
            bookModel.city = Console.ReadLine();
            Console.WriteLine("Enter the State :");
            bookModel.state = Console.ReadLine();
            Console.WriteLine("Enter the Zip :");
            bookModel.zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Phone Number :");
            bookModel.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the email-id :");
            bookModel.emailId = Console.ReadLine();
            Console.WriteLine("Enter the contact type :");
            bookModel.contactType = Console.ReadLine();
            Console.WriteLine("Enter the address book name :");
            bookModel.addressBookName = Console.ReadLine();

            addressBookModels.Add(bookModel);
        }
        /// <summary>
        /// Method to print the entire details stored in the contact DB Model
        /// </summary>
        public void DisplayAllContact()
        {
            foreach (var record in addressBookModels)
            {
                Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.secondName}\n" +
                                    $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                    $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
                Console.WriteLine("\n \n");
            }
        }
        /// <summary>
        /// UC4 -- To Update the data stored in the DB Model
        /// </summary>
        public void UpdateContactUsingName()
        {
            /// Getting the input for the name
            Console.WriteLine("Enter the First Name for contact you want to update :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Second Name for contact you want to update :");
            string secondName = Console.ReadLine();
            /// Data variable for modification
            string address;
            string city;
            string state;
            long zip;
            long phoneNumber;
            string emailId;
            string contactType;
            string addressBookName;
            /// LINQ to get the data matching the name
            /// Getting the first data or default data
            var matchedData = (from record in addressBookModels
                               where record.firstName == firstName && record.secondName == secondName
                               select record).FirstOrDefault();
            Console.WriteLine("Enter the choice you want to update the data ===>");
            Console.WriteLine("1.Address.");
            Console.WriteLine("2.City.");
            Console.WriteLine("3.State.");
            Console.WriteLine("4.Zip.");
            Console.WriteLine("5.Phone Number.");
            Console.WriteLine("6.email-id.");
            Console.WriteLine("7.contact type.");
            Console.WriteLine("8.address book name.");
            int choice = Convert.ToInt32(Console.ReadLine());
            /// Matching the case to update the record
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the Address :");
                    address = Console.ReadLine();
                    matchedData.address = address;
                    break;
                case 2:
                    Console.WriteLine("Enter the City :");
                    city = Console.ReadLine();
                    matchedData.city = city;
                    break;
                case 3:
                    Console.WriteLine("Enter the State :");
                    state = Console.ReadLine();
                    matchedData.state = state;
                    break;
                case 4:
                    Console.WriteLine("Enter the Zip :");
                    zip = Convert.ToInt64(Console.ReadLine());
                    matchedData.zip = zip;
                    break;
                case 5:
                    Console.WriteLine("Enter the Phone Number :");
                    phoneNumber = Convert.ToInt64(Console.ReadLine());
                    matchedData.phoneNumber = phoneNumber;
                    break;
                case 6:
                    Console.WriteLine("Enter the email-id :");
                    emailId = Console.ReadLine();
                    matchedData.emailId = emailId;
                    break;
                case 7:
                    Console.WriteLine("Enter the contact type :");
                    contactType = Console.ReadLine();
                    matchedData.contactType = contactType;
                    break;
                case 8:
                    Console.WriteLine("Enter the address book name :");
                    addressBookName = Console.ReadLine();
                    matchedData.addressBookName = addressBookName;
                    break;
            }
            /// Printing the updated records
            Console.WriteLine($"First Name:{matchedData.firstName}\nSecond Name:{matchedData.secondName}\n" +
                                    $"Address:{matchedData.address}, City:{matchedData.city}, State:{matchedData.state} PinCode: {matchedData.zip}\n" +
                                    $"Phone Number: {matchedData.phoneNumber}\nContact Type: {matchedData.contactType}\nAddress Book Name : {matchedData.addressBookName}");
            Console.WriteLine("\n \n");
        }
        /// <summary>
        /// UC5 -- Delete A Contact Using the name
        /// </summary>
        public void DeleteContact()
        {
            /// Getting the input for the name
            Console.WriteLine("Enter the First Name for contact you want to update :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Second Name for contact you want to update :");
            string secondName = Console.ReadLine();
            /// LINQ to get the data matching the name
            /// Getting the first data or default data
            var matchedData = (from record in addressBookModels
                               where record.firstName == firstName && record.secondName == secondName
                               select record).FirstOrDefault();
            addressBookModels.Remove(matchedData);
            DisplayAllContact();
        }
        /// <summary>
        /// UC5 -- Get the contact detail by the city name or state name
        /// </summary>
        public void GetContactUsingCityOrStateName()
        {
            Console.WriteLine("Enter the choice you want to retrieve data ===>");
            Console.WriteLine("1.City.");
            Console.WriteLine("2.State.");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of City or State by which you want the data -");
            string cityOrState = Console.ReadLine();
            if (choice == 1)
            {
                /// Query to implement the retrieval of the data from the address book based on city
                var matchedRecord = from record in addressBookModels.AsEnumerable()
                                    where record.city == cityOrState
                                    select record;
                /// Printing the retrieved data
                foreach (var record in matchedRecord)
                {
                    Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.secondName}\n" +
                                    $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                    $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
                    Console.WriteLine("\n \n");
                }
            }
            else
            {
                /// Query to implement the retrieval of the data from the address book based on state
                var matchedRecord = from record in addressBookModels.AsEnumerable()
                                    where record.state == cityOrState
                                    select record;
                /// Printing the retrieved data
                foreach (var record in matchedRecord)
                {
                    Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.secondName}\n" +
                                    $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                    $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
                    Console.WriteLine("\n \n");
                }
            }
        }
        /// <summary>
        /// UC6 -- Get the count of number of contacts as per the state or city
        /// </summary>
        public void GetCountByCityOrState()
        {
            Console.WriteLine("========================CountByCity========================");
            ///Query to get number of contact details grouped by same city name
            var countAsPerCity = (from records in addressBookModels.AsEnumerable()
                                  group records by records.city into Group
                                  select new { City = Group.Key, NumberOfContacts = Group.Count() });
            /// Iterating over the entire stored value with count and city
            /// Displaying the reviews count
            foreach (var record in countAsPerCity)
            {
                Console.WriteLine($"City : {record.City}, Number Of Contacts : {record.NumberOfContacts}");
            }
            Console.WriteLine("========================CountByState========================");
            ///Query to get number of contact details grouped by same state name
            var countAsPerState = (from records in addressBookModels.AsEnumerable()
                                   group records by records.state into Group
                                   select new { State = Group.Key, NumberOfContacts = Group.Count() });
            /// Iterating over the entire stored value with count and city
            /// Displaying the reviews count
            foreach (var record in countAsPerState)
            {
                Console.WriteLine($"State : {record.State}, Number Of Contacts : {record.NumberOfContacts}");
            }
        }
        /// <summary>
        /// UC7 -- Sort the data base model alphabetically by the name for a particular city
        /// </summary>
        public void SortedDetailsAlphabeticallyByNameForACity()
        {
            Console.WriteLine("Enter the name of City by which you want to sort the data alphabetically by name -");
            string city = Console.ReadLine();
            ///Query to get the sorted order of name for a particualr city
            var sortByName = (from record in addressBookModels.AsEnumerable()
                              orderby record.firstName
                              where (record.city == city)
                              select record);
            /// Iterating over the entire list
            /// Displaying the contact details
            foreach (var record in sortByName)
            {
                Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.secondName}\n" +
                                $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
                Console.WriteLine("\n \n");
            }

        }
        /// <summary>
        /// UC9 -- Display the contact count grouped by contact type for the address book
        /// </summary>
        public void DisplayCountOfContactAsPerContactType()
        {
            Console.WriteLine("========================CountByContactType========================");
            ///Query to get number of contact details grouped by contact type
            var countAsPerCity = (from records in addressBookModels.AsEnumerable()
                                  group records by records.contactType into Group
                                  select new { ContactType = Group.Key, NumberOfContacts = Group.Count() });
            /// Iterating over the entire stored value with count and contact type
            /// Displaying the reviews count
            foreach (var record in countAsPerCity)
            {
                Console.WriteLine($"City : {record.ContactType}, Number Of Contacts : {record.NumberOfContacts}");
            }
        }
    }
}