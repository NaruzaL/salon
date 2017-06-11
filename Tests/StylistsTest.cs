using Xunit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Salon
{
  [Collection("hair_salon_test")]
  public class StylistTest : IDisposable
  {
    public StylistTest()
    {
      DBConfiguration.ConnectionString  = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_Equal_ReturnsTrueIfStylistsAreTheSame()
    {
      Stylist firstStylist = new Stylist("Mary");
      Stylist secondStylist = new Stylist("Mary");
      Assert.Equal(firstStylist, secondStylist);
    }

    [Fact]
    public void Test_Save_SavesToDatabase()
      {
        Stylist testStylist = new Stylist("Steve");
        testStylist.Save();
        List<Stylist> result = Stylist.GetAll();
        List<Stylist> testList = new List<Stylist>{testStylist};
        Assert.Equal(testList[0], result[0]);
      }

      [Fact]
      public void Test_Save_AssignsIdToObject()
      {
        Stylist testStylist = new Stylist("Sue");
        testStylist.Save();
        int testId = testStylist.GetId();
        int savedStylistId = Stylist.GetAll()[0].GetId();
        Assert.Equal(testId, savedStylistId);
      }

      [Fact]
      public void Test_Find_FindsStylistInDatabase()
      {
        Stylist testStylist = new Stylist("Jessica");
        testStylist.Save();
        Stylist foundStylist = Stylist.Find(testStylist.GetId());
        Assert.Equal(testStylist, foundStylist);
      }

      [Fact]
      public void Test_GetClients_RetrievesAllClientssWithCategory()
      {
        Stylist testStylist = new Stylist("Bob", 1);
        testStylist.Save();

        Client firstClient = new Client("Joe", testStylist.GetId());
        firstClient.Save();
        Client secondClient = new Client("Betsy", testStylist.GetId());
        secondClient.Save();


        List<Client> testClientList = new List<Client> {firstClient, secondClient};
        List<Client> resultClientList = testStylist.GetClients();

        Assert.Equal(testClientList, resultClientList);
      }

    public void Dispose()
    {
      Stylist.DeleteAll();
      Client.DeleteAll();
    }
  }
}
