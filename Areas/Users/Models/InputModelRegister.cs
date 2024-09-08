using System.ComponentModel.DataAnnotations;

namespace SalesSystem.Areas.Users.Models
{
	public class InputModelRegister
	{
		[Required (ErrorMessage ="El campo Nombre es obligatorio")]
		public string Name { get; set; }
		[Required(ErrorMessage = "El campo Apellido es obligatorio")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "El campo nid es obligatorio")]
		public string NID { get; set; }
		[Required(ErrorMessage = "El campo Telefono es obligatorio")]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"(^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{5})$" , ErrorMessage ="El formato de telefono ingresado no es valido")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "El campo Email es obligatorio")]
		[EmailAddress (ErrorMessage ="El correo en el campo correo electronico no es valido")]
		public string Email { get; set; }
		[Display(Name ="Contraseña")]
		[StringLength(100,ErrorMessage ="El numero de caracteres {0} debe ser al menos de {2} ", MinimumLength =6)]
		[Required(ErrorMessage = "El campo contrasaña es obligatorio")]
		public string PassWord { get; set; }
		public string AvatarImagePath { get; set; }
		[Required]
		public string Role { get; set; }
	}
}
