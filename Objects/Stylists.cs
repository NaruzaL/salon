using System;
using System.Colections.Generic;
using System.Data.SqlClient;

namespace Salon
{
  public class Stylist
  {
    private string _name;
    private int _id;

    public Stylist(string Name, int Id = 0)
    {
      _name = Name;
      _id = Id;
    }

    public int GetId()
    {
      return _id;
    }
    public string GetName()
    {
      return _name;
    }

    public override bool Equals(System.Object otherStylist)
    {
      if (!(otherStylist is Stylist))
      {
        return false;
      }
      else
      {
        Stylist newStylists = (Stylist) otherStylist;
        bool idEquality = (this.GetId() == newStylists.GetId());
        bool nameEquality = (this.GetName() == newStylist.GetName());
        return (idEquality && nameEquality);
      }
    }

  }
}
