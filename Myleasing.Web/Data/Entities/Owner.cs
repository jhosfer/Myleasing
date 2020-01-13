using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Myleasing.Web.Data.Entities
{
    public class Owner

    {
        public string Id { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

       
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

       
        [Display(Name = "Cell Phone")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string CellPhone { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }

        public string Fullname => $"{FirstName} {LastName}";
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }

    }
}
