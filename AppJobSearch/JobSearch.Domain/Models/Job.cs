using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearch.Domain.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Company { get; set; }

        [Required]
        [MinLength(5)]
        public string JobTitle { get; set; }

        [Required]
        [MinLength(5)]
        public string CityState { get; set; }

        [Required]
        public double Salary { get; set; }

        [Required]
        [MinLength(5)]
        public string ContractType { get; set; }

        [Required]
        [MinLength(5)]
        public string TecnologyTools { get; set; }

        public string CompanyDescription { get; set; }

        [Required]
        [MinLength(5)]
        public string JobDescription { get; set; }

        public string Benefits { get; set; }

        [Required]
        [EmailAddress]
        public string InterestedSendEmailTo { get; set; }


        public DateTime PublicationDate { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }




    }
}
