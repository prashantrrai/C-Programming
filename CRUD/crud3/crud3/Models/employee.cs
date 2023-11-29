namespace crud3.Models
{
	public class employee
	{
		public int employeeId { get; set; }
		public string? username { get; set; }
		public string? password { get; set; }

		public employee()
		{
			username = "prashantrai";
			password = "12345678";
		}
	}


}
