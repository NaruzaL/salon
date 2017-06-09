// using Xunit;
// using System;
// using System.Collections.Generic;
// using System.Data;
// using System.Data.SqlClient;
//
// namespace Salon
// {
//   // [Collection("hair_salon_test")]
//   public class StylistTest : IDisposable
//   {
//     public StylistTest()
//     {
//       DBConfiguration.ConnectionString  = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
//     }
//
//     // [Collection("hair_salon_test")]
//     [Fact]
//     public void Test_Equal_ReturnsTrueIfStylistsAreTheSame()
//     {
//       Stylist firstStylist = new Stylist("Mary");
//       Stylist secondStylist = new Stylist("Mary");
//       Assert.Equal(firstStylist, secondStylist);
//     }
//
//     // [Collection("hair_salon_test")]
//     [Fact]
//     public void Test_Save_SavesToDatabase()
//       {
//         Stylist testStylist = new Stylist("Steve");
//         testStylist.Save();
//         List<Stylist> result = Stylist.GetAll();
//         List<Stylist> testList = new List<Stylist>{testStylist};
//         Assert.Equal(testList[0], result[0]);
//       }
//
//       [Fact]
//       public void Test_GetClients_RetrievesAllClientssWithCategory()
//       {
//         Stylist testStylist = new Stylist("Bob");
//         testStylist.Save();
//
//         Client firstClient = new Client("Joe", 1);
//         firstClient.Save();
//         Client secondClient = new Client("Betsy", 1);
//         secondClient.Save();
//
//
//         List<Client> testClientList = new List<Client> {firstClient, secondClient};
//         List<Client> resultClientList = testStylist.GetClients();
//
//         Assert.Equal(testClientList, resultClientList);
//       }
//
//     public void Dispose()
//     {
//       Stylist.DeleteAll();
//     }
//   }
// }
