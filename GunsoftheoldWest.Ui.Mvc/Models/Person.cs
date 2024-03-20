using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GunsoftheoldWest.Ui.Mvc.Models
{
    public class Person
    {
        public int Id { get; set; }

        [DisplayName("First name")]
        public required string FirstName { get; set; }

        [DisplayName("Last name")]
        public required string LastName { get; set; }

        [DisplayName("Email address")]
        [EmailAddress]
        public string? Email { get; set; }

        [DisplayName("Phone number")]
        public string? Phone { get; set; }

        [Display(Name = "Submission Date")]
        [DataType(DataType.Date)]
        public DateTime SubmissionDate { get; set; }
    }
}
