using System;
using System.Text;
using System.Threading.Tasks;

namespace MongoDb
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var db = new MongoClass("AddressBook");

            /**  Insert a record to db **/

            //var person2 = new PersonModel
            //{
            //    FirstName = "Ahmed",
            //    LastName = "Alouche",
            //    Address = new AddressModel
            //    {
            //        City = "Oujda",
            //        State = "Oriental",
            //        ZipCode = "60000",
            //        Address = "B45, Lot le fath, N18 Lazaret"
            //    }
            //};

            //db.InsertRecord("Users",person2);




            /** get all records from db **/

            //var list = db.GetAllRecords<PersonModel>("Users");

            //foreach(var record in list)
            //{
            //    Console.WriteLine($"FirstName: {record.FirstName} LastName: {record.LastName}");
            //    if(record.Address != null)
            //        Console.WriteLine(record.Address.City);
            //}

            //Console.ReadLine();


            /** Get record by id **/
            //var person = db.GetRecordById<PersonModel>("Users", new Guid("1995f2ff-0e7f-4d2a-a7f7-858e99ab2c6a"));
            //Console.WriteLine($"User firstname: {person.FirstName}");


            /** update a record in database **/
            //var person = db.GetRecordById<PersonModel>("Users", new Guid("1995f2ff-0e7f-4d2a-a7f7-858e99ab2c6a"));
            //person.BirthDate = new DateTime(2000, 04, 29);

            //db.UpsertRecord<PersonModel>("Users", person.Id, person);


            /** delete a record from database **/
            // db.DeleteRecord<PersonModel>("Users", new Guid("1995f2ff-0e7f-4d2a-a7f7-858e99ab2c6a"));


            /** map result to another model **/

            //var list = db.GetAllRecords<NamesModel>("Users");

            //foreach (var record in list)
            //{
            //    Console.WriteLine($"FirstName: {record.FirstName} LastName: {record.LastName}");
            //}

            //Console.ReadLine();


        }
    }
}
