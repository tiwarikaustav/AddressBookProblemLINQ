// --------------------------------------------------------------------------------------------------------------------
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
    public class AddressBookRepository
    {
        /// <summary>
        /// List to store the instances of address book model or records of address book
        /// </summary>
        public static List<AddressBookModel> addressBookModels = new List<AddressBookModel>();
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
    }
}