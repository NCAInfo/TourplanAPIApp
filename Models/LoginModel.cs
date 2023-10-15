

using System.ComponentModel.DataAnnotations;

public class LoginModel
	{
		public LoginModel()
		{
		}
    [Required]
    public virtual string Username { get; set; }
    [Required]
    public virtual string Password { get; set; }
	[Required]
	public virtual string Country { get; set; }

	public virtual int SEC { get; set; }
}


