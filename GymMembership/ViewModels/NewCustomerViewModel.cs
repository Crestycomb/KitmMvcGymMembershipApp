using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GymMembership.Models;

namespace GymMembership.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Keisti kliento informaciją";

                return "Naujas klientas";
            }
        }
    }
}