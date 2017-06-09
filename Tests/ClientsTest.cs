// using Xunit;
// using System;
// using System.Collections.Generic;
// using System.Data;
// using System.Data.SqlClient;
//
// namespace Salon
// {
//   // [Collection("hair_salon_test")]
//   public class ClientTest : IDisposable
//   {
//     public ClientTest()
//     {
//       DBConfiguration.ConnectionString  = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
//     }
//
//       // [Collection("hair_salon_test")]
//       [Fact]
//       public void Test_Save_SavesToDatabase()
//         {
//          Client testClient = new Client("Steve", 1);
//           testClient.Save();
//           List<Client> result =Client.GetAll();
//           List<Client> testList = new List<Client>{testClient};
//           Assert.Equal(testList[0], result[0]);
//         }
//         public void Dispose()
//         {
//          Client.DeleteAll();
//         }
//
//   }
// }
