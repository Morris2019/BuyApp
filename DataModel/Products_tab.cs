
using SQLite;

namespace BusyZone.DataModel;

	public class Products_tab
	{
       [PrimaryKey, AutoIncrement]
	   public int product_id { get; set; }
	   public string pro_title { get; set; }
	   public string pro_details { get; set; }
	   public string pro_category { get; set; }
	   public string imageLink { get; set; }
	   public string pro_stock { get; set; }
	   public string pro_Price { get; set; }
       public DateTime dateCreated { get; set; }
       public DateTime dateUpdated { get; set; }

    }

