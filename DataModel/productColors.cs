using System;
namespace BusyZone.DataModel;

	public class productColors
	{
		public int pro_colorId { get; set; }
	    public int product_id { get; set; }
	    public Color ColorOption { get; set; }
	    public string colorDescr { get; set; }
	    public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
    }

