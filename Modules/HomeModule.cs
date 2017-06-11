// using System;
// using System.Collections.Generic;
// using Salon;
// using System.Data;
// using System.Data.SqlClient;
// using Nancy;
//
// namespace Salon
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//       Get["/"] = _ => {
//         List<Stylist> allStylists = Stylist.GetAll();
//         return View["index.cshtml", allStylists];
//       };
//
//       Post["/stylist/new"] = _ => {
//
//       }
//
//     }
//   }
// }
