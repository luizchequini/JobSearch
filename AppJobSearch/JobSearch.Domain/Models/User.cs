using JobSearch.Domain.Utility.Language;
using System.ComponentModel.DataAnnotations;

namespace JobSearch.Domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        //[Required(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E001")]
        //[MinLength(5, ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E003")]
        //[Display(Name = "Name", ResourceType = typeof(Fields))]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        //[Required(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E001")]
        //[EmailAddress(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E002")]
        //[Display(Name = "Email", ResourceType = typeof(Fields))]
        public string Email { get; set; }


        [Required]
        [MinLength(5)]
        //[Required(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E001")]
        //[MinLength(5, ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E003")]
        //[Display(Name = "Password", ResourceType = typeof(Fields))]
        public string Password { get; set; }
    }
}
