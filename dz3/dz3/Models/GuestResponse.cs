using System.ComponentModel.DataAnnotations;

namespace dz3.Models {
	public class GuestResponse {
		[Required(ErrorMessage ="Будь ласка, введіть своє ім'я")]
		public string Name { get; set; }
        [Required(ErrorMessage = "Будь ласка, введіть email")]
		[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Ви ввели некоректний email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Будь ласка, введіть телефон")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Будь ласка, вкажіть, чи приймите участь у вечірці")]
        public bool? WillAttend { get; set; }
	}
}
