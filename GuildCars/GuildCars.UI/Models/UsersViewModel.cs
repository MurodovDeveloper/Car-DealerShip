﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.UI.Models
{
    public class UsersViewModel
    {
        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}