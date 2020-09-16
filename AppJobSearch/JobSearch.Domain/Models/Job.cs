using JobSearch.Domain.Utility.Language;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearch.Domain.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessageResourceType =typeof(Mensages), ErrorMessageResourceName ="MSG_E001")]
        [MinLength(5, ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E003")]
        [Display(Name = "Company", ResourceType = typeof(Fields))]
        public string Company { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(5, ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E003")]
        [Display(Name = "JobTitle", ResourceType = typeof(Fields))]
        public string JobTitle { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(5, ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E003")]
        [Display(Name = "CityState", ResourceType = typeof(Fields))]
        public string CityState { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E001")]
        [Display(Name = "Salary", ResourceType = typeof(Fields))]
        public double Salary { get; set; }

        [Required]
        [MinLength(2, ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E003")]
        [Display(Name = "ContractType", ResourceType = typeof(Fields))]
        public string ContractType { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(5, ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E003")]
        [Display(Name = "TecnologyTools", ResourceType = typeof(Fields))]
        public string TecnologyTools { get; set; }

        [Display(Name = "CompanyDescription", ResourceType = typeof(Fields))]
        public string CompanyDescription { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(5, ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E003")]
        [Display(Name = "JobDescription", ResourceType = typeof(Fields))]
        public string JobDescription { get; set; }

        [Display(Name = "Benefits", ResourceType = typeof(Fields))]
        public string Benefits { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(Mensages), ErrorMessageResourceName = "MSG_E002")]
        [Display(Name = "InterestedSendEmailTo", ResourceType = typeof(Fields))]
        public string InterestedSendEmailTo { get; set; }

        [Display(Name = "PublicationDate", ResourceType = typeof(Fields))]
        public DateTime PublicationDate { get; set; }

        [Display(Name = "UserId", ResourceType = typeof(Fields))]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }




    }
}
