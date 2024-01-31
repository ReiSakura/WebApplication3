using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        //[RegularExpression(@"^[STFG]\d{7}[A-Z]$", ErrorMessage = "Invalid NRIC format.")]
        public string NRIC { get; set; }
        public DateTime DateOfBirth { get; set; }

        //[DataType(DataType.Upload)]
        //[AllowedFileExtensions(new string[] { ".docx", ".pdf" }, ErrorMessage = "Invalid file format. Only .docx and .pdf are allowed.")]
        //public IFormFile Resume { get; set; }

        //[RegularExpression(@"^[^\r\n]+$", ErrorMessage = "Invalid characters in 'Who Am I' field.")]
        public string WhoAmI { get; set; }
    }
}
