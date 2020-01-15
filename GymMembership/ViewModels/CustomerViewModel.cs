using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymMembership.Models;

namespace GymMembership.ViewModels
{
    public class CustomerViewModel : Controller
    {
        public List<Customer> Customers { get; set; }
    }
}