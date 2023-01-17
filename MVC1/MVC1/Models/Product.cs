namespace MVC1.Models
{
	public enum category { electronic, wood,cloths,plastic,iron,steel,vehicle}
	public class Product
	{
		
		public int ProductId { get; set; }
		public string ProductName { get; set; }

		public int ProductPrice { get; set; }
		public category proCate;
	}
}
