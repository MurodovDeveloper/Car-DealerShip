﻿using GuildCars.Data.RepositoryFactories;
using GuildCars.Models.Queries;
using GuildCars.UI.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.UI.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Details(string id)
        {
            var repo = VehicleRepositoryFactory.GetRepository();
            var model = repo.GetVehicleById(id);

            return View(model);
        }

        public ActionResult New()
        {
            var repo = VehicleRepositoryFactory.GetRepository();
            var model = new SearchInventoryViewModel();
            bool isUsed = false;
            model.Years = repo.GetYearsOfVehiclesInInventory(isUsed);
            model.Prices = repo.GetListPricesOfVehiclesInInventory(isUsed);
            
            return View(model);
        }

        public ActionResult Used()
        {
            var repo = VehicleRepositoryFactory.GetRepository();
            var model = new SearchInventoryViewModel();
            bool isUsed = true;
            model.Years = repo.GetYearsOfVehiclesInInventory(isUsed);
            model.Prices = repo.GetListPricesOfVehiclesInInventory(isUsed);

            return View(model);
        }
    }
}