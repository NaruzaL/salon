using System;
using System.Collections.Generic;
using Salon;
using System.Data;
using System.Data.SqlClient;
using Nancy;

namespace Salon
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Stylist> allStylists = Stylist.GetAll();
        return View["index.cshtml", allStylists];
      };

      Get["/stylist/add"] = _ => View["stylist_form.cshtml"];

      Post["/stylist/new"] = _ => {
        Stylist newStylist = new Stylist(Request.Form["stylistName"]);
        newStylist.Save();
        return View["success.cshtml", newStylist];
      };

      Get["/client/add"] = _ => {
        List<Stylist> allStylists = Stylist.GetAll();
        return View["client_form.cshtml", allStylists];
      };

      Post["/client/new"] = _ => {
        Client newClient = new Client(Request.Form["clientName"], Request.Form["stylist-id"]);
        newClient.Save();
        return View["success.cshtml", newClient];
      };

      Get["/stylist/{id}"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Stylist SelectedStylist = Stylist.Find(parameters.id);
        List<Client> StylistClients = SelectedStylist.GetClients();
        model.Add("stylists", SelectedStylist);
        model.Add("clients", StylistClients);
        return View["clients.cshtml", model];
      };

      Post["/client/delete"] = _ => {
        Client.DeleteAll();
        List<Client> allClients = Client.GetAll();
        return View["index.cshtml", allClients];
      };

      Patch["client/edit/{id}"] = parameters => {
        Client SelectedClient = Client.Find(parameters.id);
        SelectedClient.Update(Request.Form["clientName"]);
        return View["success.cshtml"];
      };
    }
  }
}
