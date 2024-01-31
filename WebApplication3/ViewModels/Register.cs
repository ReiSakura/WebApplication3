using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebApplication3.ViewModels
{
    public class Register
    {
		[Required]
		//[StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public string Gender { get; set; }

		[Required]
		[RegularExpression(@"^[STFG]\d{7}[A-Z]$", ErrorMessage = "Invalid NRIC format.")]
		public string NRIC { get; set; }

		[Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password and confirmation password does not match")]
        public string ConfirmPassword { get; set; }

		[Required]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime DateOfBirth { get; set; }

		//[Required/*(ErrorMessage = "Resume file is required.")*/]
		//[DataType(DataType.Upload)]
		//[AllowedFileExtensions(new string[] { ".docx", ".pdf" }, ErrorMessage = "Invalid file format. Only .docx and .pdf are allowed.")]
		//public IFormFile Resume { get; set; }

		[Required]
		//[RegularExpression(@"^[^\r\n]+$", ErrorMessage = "Invalid characters in 'Who Am I' field.")]
		public string WhoAmI { get; set; }
	}
}
