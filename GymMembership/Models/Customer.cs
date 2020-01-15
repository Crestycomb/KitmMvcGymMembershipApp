using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GymMembership.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Prašome įrašyti vardą")]
        [StringLength(255)]
        [Display(Name = "Vardas")]
        public string Name { get; set; }

        [Display(Name = "Naujienų prenumerata")]
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Required(ErrorMessage = "Prašome pasirinkti abonemento tipą")]
        [Display(Name = "Abonemento tipas")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Gimimo data")]
        public DateTime? Birthdate { get; set; }

        [Required(ErrorMessage = "Prašome įvesti datą")]
        [Display(Name = "Abonementas nuo")]
        public DateTime CustomerSinceDate { get; set; }
        
        [Display(Name = "Pirkti vienkartiniai bilietėliai")]
        public int? SingleTicketsBought { get; set; }
    }
}
