using Xunit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Salon
{
  [Collection("hair_salon_test")]
  public class ClientTest : IDisposable
  {
    public ClientTest()
    {
      DBConfiguration.ConnectionString  = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
    }

  [Fact]
    public void Test_Equal_ReturnsTrueIfDescriptionsAreTheSame()
    {
      Client firstClient = new Client("Pete", 1);
      Client secondClient = new Client("Pete", 1);
      Assert.Equal(firstClient, secondClient);
    }


  [Fact]
  public void Test_Save_SavesClientToDatabase()
    {
      Client testClient = new Client("Steve", 1);
      testClient.Save();
      List<Client> result = Client.GetAll();
      List<Client> testList = new List<Client>{testClient};
      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_Save_AssignsIdToObject()
    {
      Client testClient = new Client("Joe", 1);
      testClient.Save();
      int testId = testClient.GetId();
      int savedClientId = Client.GetAll()[0].GetId();
      Assert.Equal(testId, savedClientId);
    }

    [Fact]
    public void Test_Find_FindsClientInDatabase()
    {
      Client testClient = new Client("James", 1);
      testClient.Save();
      Client foundClient = Client.Find(testClient.GetId());
      Assert.Equal(testClient, foundClient);
    }

    [Fact]
    public void Test_Update_UpdatesClientInDatabase()
    {
      string name = "Billy Joe";
      int id = 1;
      Client testClient = new Client(name, id);
      testClient.Save();
      string newName = "Billy Joel";
      testClient.Update(newName);
      string result = testClient.GetName();

      Assert.Equal(newName, result);
    }

    [Fact]
    public void Test_Delete_DeletesClientFromDatabase()
    {
      string name1 = "Steve";
      int id1 = 1;
      Client testClient1 = new Client(name1, id1);
      testClient1.Save();
      string name2 = "Joe";
      int id2 = 2;
      Client testClient2 = new Client(name2, id2);
      testClient2.Save();

      testClient1.Delete();
      List<Client> resultClient = Client.GetAll();
      List<Client> testClientList = new List<Client> {testClient2};

      Assert.Equal(testClientList, resultClient);
    }


    public void Dispose()
    {
     Client.DeleteAll();
    }

  }
}
