using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BusyZone.DataModel;
using BusyZone.PageViews;
using CommunityToolkit.Mvvm.Input;

namespace BusyZone.ViewModels
{
	public class MainPageViewModel : BindableObject
	{
        IConnectivity connectivity;
		private ObservableCollection<Products_tab> _productsList;
        public Command GetProductsCommand { get; }
        public ICommand proTapCommand { get; set; }
        public ICommand SearchItems { get; set; }
        readonly IList<Products_tab> productSource;
        public ObservableCollection<Products_tab> itemPreview { get; private set; }
        public ObservableCollection<Products_tab> UsserSearItems { get; set; }


        public MainPageViewModel(IConnectivity connectivity)
		{
            LoadProducts();
            
            // GetProductsCommand = new Command(async () => await GetProducts() );
            GetProductsCommand = new Command(GetProducts);

            proTapCommand = new Command<Products_tab>(ProductSelectedCommand);
            SearchItems = new Command(SearchproductsItems);
            this.connectivity = connectivity;
        }
      

        string productSerach;
        public string searchproducts
        {
            get => productSerach;
            set
            {
                productSerach = value;
                OnPropertyChanged(nameof(searchproducts));
            }
        }

        private async void GetProducts()
        {
            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("No Internet Access", "", "OK","Retry");
                return;
            }
            else
            {
                LoadProducts();
                IsRefresh = false;
            }
        }
        async void ProductSelectedCommand(Products_tab _products)
        {
            await Shell.Current.GoToAsync(nameof(BusyProductDetailsPage));
        }
        void SearchproductsItems()
        {
            if (string.IsNullOrWhiteSpace(searchproducts))
            {
                //LoadProducts();
            }
            else if (!string.IsNullOrWhiteSpace(searchproducts))
            {
                searchproducts = searchproducts.ToLowerInvariant();

                //ListProducts = ListProducts.Get
                var SearItems = ListProducts.Where(products => products.pro_title.Contains(searchproducts)).ToList();
                var UserList = SearItems;
            }
        }

        bool isRefreshing;
        public bool IsRefresh
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefresh));
            }
        }
        public ObservableCollection<Products_tab> ListProducts
		{
			get { return _productsList; }
			set
			{
				_productsList = value;
				OnPropertyChanged();
			}
		}
        void LoadProducts()
        {
            ListProducts = new ObservableCollection<Products_tab>() {
                 new Products_tab
                 {
                     product_id= 1,
                     pro_title = "Steel",
                     imageLink = "https://image.made-in-china.com/44f3j00cFCLngDtEZbP/High-Quality-Wholesale-Reinforcing-Steel-Rebar.jpg",
                     pro_details = "To date, steel is one of the most commonly used materials in construction, from the skeleton of a building to the actual materials found within. Security access panels are also made of steel and can be commonly found in commercial and industrial spaces. Steel offers many advantages, for one it can bend or be manipulated without risking its strength and durability. In areas that experience extreme winds or are prone to earthquakes, steel structures are able to withstand the shaking through its durability and in a way it’s plasticity. ",
                     pro_category = "",
                     pro_stock = "189800",
                     pro_Price = "99.00",

                 },
                new Products_tab
                 {
                     product_id= 2,
                     pro_title = "Cement ",
                     imageLink = "https://res.feednews.com/assets/v2/4e3d361b1e9921c293d274085e8536c3?width=450&height=336&quality=hq&category=ng_News_Politics",
                     pro_details = "Cement is a material that sets, hardens and can bind together all other building materials. The different grades of cement are 53-grade cement, 43-grade cement, PPC cement, PSC cement, etc. All these different grades of cement are manufactured by a number of brands in India. Some well-known cement brands in India are Zuari, ACC cement, Birla super cement, Ramco, Ultratech cement, Dalmia etc. ",
                     pro_category = "",
                     pro_stock = "9879100",
                     pro_Price = "80.00",
                 },
                 new Products_tab
                 {
                     product_id= 3,
                     pro_title = "Wood ",
                     imageLink = "https://5.imimg.com/data5/HI/PE/MY-16269511/gamari-wood-lumber-500x500.jpg",
                     pro_details = "Wood has been used as a construction material for thousands of years and if properly maintained can last for hundred of years. It is a readily available and economically feasible natural resource with a light weight and highly machinable properties. It also provides good insulation from the cold which makes it an excellent building material for homes and residential buildings. ",
                     pro_category = "",
                     pro_stock = "7768900",
                     pro_Price = "23.00",
                 },
                 new Products_tab
                 {
                     product_id= 4,
                     pro_title = "Bamboo ",
                     imageLink = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Farchkidecture.org%2Fwp-content%2Fuploads%2F2015%2F03%2Fbamboo-dry.jpg&f=1&nofb=1 ",
                     pro_details = "used building material as support for concrete and scaffolding. ",
                     pro_category = "",
                     pro_stock = "18979000",
                     pro_Price = " 10.00",
                 },
                 new Products_tab
                 {
                     product_id= 5,
                     pro_title = "Bricks ",
                     imageLink = "https://res.cloudinary.com/fleetnation/image/private/c_fit,w_1120/g_south,l_text:style_gothic2:%C2%A9%20Anton,o_20,y_10/g_center,l_watermark4,o_25,y_50/v1526890502/ao2kbhcwnjf57onveab1.jpg",
                     pro_details = "Bricks and Blocks are used for building walls. They come in different shapes, sizes, and strength based on different construction requirements. High strength bricks and blocks are mainly used for load-bearing walls as they have the capacity to withstand the pressure due to the load.Clay bricks start from Rs 5.8 - 64 per bricks and concrete block start from Rs.27 - 109 per block in Bangalore. ",
                     pro_category = "",
                     pro_stock = "564100",
                     pro_Price = "3.50",
                 },
                 new Products_tab
                 {
                     product_id= 6,
                     pro_title = "Glass ",
                     imageLink = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.glassmanufacturerchina.com%2Fupfile%2Fimages%2Fa6%2F20161009135222616.jpg&f=1&nofb=1 ",
                     pro_details = "To one who is inexperienced in construction might think that glass merely is meant to be used for windows; however, glass is a building material that is both versatile and underrated. One of the most common types of glass used was obsidian for its aesthetic appeal and strength. Considered a luxury in the construction industry as it requires both skill and resources to create it. ",
                     pro_category = "",
                     pro_stock = "100",
                     pro_Price = "459.00",

                 },
                 new Products_tab
                 {
                     product_id= 7,
                     pro_title = "Ceramics ",
                     imageLink = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fcdn.trendir.com%2Fwp-content%2Fuploads%2Fold%2Farchives%2Ffreestanding-oval-ceramic-bath-by-ceramica-cielo-1.jpg&f=1&nofb=1 ",
                     pro_details = "Ceramic products for the construction sector include cements and cement-based materials, interior and exterior tiles, sanitary ware, non-refractory bricks, and other more complex shapes such as drainage, sewer, and chimney pipes and linings. Cements are used to make mortar and concrete. ",
                     pro_category = "",
                     pro_stock = "100",
                     pro_Price = "66.98",
                 },
                 new Products_tab
                 {
                     product_id= 8,
                     pro_title = "Stones ",
                     imageLink = "https://wildapplestone.com/images/galleries/construction-stone/1-stone.jpg",
                     pro_details = "Aesthetically appealing, the stone is a common material choice for flooring and walls. The texture of stone makes it versatile, from a smooth finish to a textured one- stone can also come in many different colours. Some examples of stone used in construction include granite, marble, and sandstone. ",
                     pro_category = "",
                     pro_stock = "19000",
                     pro_Price = "676.98",
                 },
                 new Products_tab
                 {
                     product_id= 10,
                     pro_title = "Concrete ",
                     imageLink = "https://5.imimg.com/data5/SELLER/Default/2022/1/ZK/FD/RE/22777217/m20-grade-ready-mix-concrete-500x500.jpg",
                     pro_details = "Concrete, or as it is better known to contractors and builders, reinforced concrete is composed of steel making it very strong. Typically used in the structure and foundation of a building – once it has been applied, it will take multiple hours before it has settled and hardened. When it comes to concrete, similar to many building materials like access panels, windows, and paints, concrete comes in various types. From high performance to lightweight concrete and water-resistant, a contractor will know which is the ideal concrete to use and recommend on a project. ",
                     pro_category = "",
                     pro_stock = "100",
                     pro_Price = "670.00",
                 },
                 new Products_tab
                 {
                     product_id= 11,
                     pro_title = "Sand ",
                     imageLink = "https://junkmailimages.blob.core.windows.net/large/68fa953d9b9c45b3adf59873e76f5d62.jpg",
                     pro_details = "Used to give bulk, strength, and other properties to construction materials like asphalt and concrete. ",
                     pro_category = "",
                     pro_stock = "102320",
                     pro_Price = "2000.00",
                 },
                 new Products_tab
                 {
                     product_id= 12,
                     pro_title = "Bitumen ",
                     imageLink = "https://www.asphalt.com.au/nkwp/wp-content/uploads/2020/04/bitumen-vs-asphalt-what-is-the-difference.jpg?_t=1591926373",
                     pro_details = "Used for road construction, roofing, waterproofing, and other applications ",
                     pro_category = "",
                     pro_stock = "10234230",
                     pro_Price = "232.23",
                 },
                 new Products_tab
                 {
                     product_id= 13,
                     pro_title = "Binding Wires",
                     imageLink = "https://img2.exportersindia.com/product_images/bc-full/2018/9/5882645/binding-wire-1536821373-4295841.jpeg",
                     pro_details = "Used for tying applications in the field of construction. ",
                     pro_category = "",
                     pro_stock = "107790",
                     pro_Price = "21.99",

                 },
                 new Products_tab
                 {
                     product_id= 14,
                     pro_title = "Nails ",
                     imageLink = "https://5.imimg.com/data5/JP/FT/TJ/SELLER-74141617/ms-wire-nails-scrap-500x500.jpg",
                     pro_details = "Most commonly used to fasten pieces of wood together. ",
                     pro_category = "",
                     pro_stock = "157600",
                     pro_Price = "65.87",
                 },
                 new Products_tab
                 {
                     product_id= 15,
                     pro_title = "Pipes ",
                     imageLink = "https://5.imimg.com/data5/SELLER/Default/2021/7/NJ/TK/VH/41794075/supreme-pvc-pipe-300-mm-500x500.jpg",
                     pro_details = "Used for drainage and wastewater supply system. ",
                     pro_category = "",
                     pro_stock = "187700",
                     pro_Price = "98.98",
                 },
                 new Products_tab
                 {
                     product_id= 16,
                     pro_title = "Tiles",
                     imageLink = "https://i.pinimg.com/originals/d5/c0/fc/d5c0fcaf55a7e7d940892ecd633c4e83.jpg",
                     pro_details = "Used to cover surfaces like roofs, floors, and walls. ",
                     pro_category = "",
                     pro_stock = "17878800",
                     pro_Price = "767.99",
                 },
                 new Products_tab
                 {
                     product_id= 17,
                     pro_title = "Marbles ",
                     imageLink = "https://gzozb48fcbr1xznu03bpew39-wpengine.netdna-ssl.com/wp-content/uploads/2019/07/capital-granite-warehouse-640x427.jpg ",
                     pro_details = "Used principally for buildings and monuments, interior decoration, statuary, tabletops ",
                     pro_category = "",
                     pro_stock = "1799800",
                     pro_Price = "68.98",
                 },
                 new Products_tab
                 {
                     product_id= 19,
                     pro_title = "Chipboard ",
                     imageLink = "https://visionwoodfuels.co.uk/wp-content/uploads/2021/10/recycled-chipboard.jpg",
                     pro_details = " Used for floor decking, shelving, and general building work",
                     pro_category = "",
                     pro_stock = "10898890",
                     pro_Price = "13.78",
                 },
                 new Products_tab
                 {
                     product_id= 20,
                     pro_title = "Rope ",
                     imageLink = "https://www.climbing.com/wp-content/uploads/2016/03/GettyImages-1326903114.jpg ",
                     pro_details = "Used for dragging and lifting. ",
                     pro_category = "",
                     pro_stock = "1787800",
                     pro_Price = "10.00",
                 },
                 new Products_tab
                 {
                     product_id= 22,
                     pro_title = "Straw ",
                     imageLink = "https://www.buildingwithawareness.com/wp-content/uploads/2009/04/straw-bale-house-walls1.jpg ",
                     pro_details = "Used to provide load-bearing structural support to a building. ",
                     pro_category = "",
                     pro_stock = "7667100",
                     pro_Price = "99.89",
                 },
                 new Products_tab
                 {
                     product_id= 23,
                     pro_title = "Gypsum Board ",
                     imageLink = "https://www.sanmecrusher.com/uploadfile/image/solution-img/gypsum-board.jpg",
                     pro_details = "Used as a finish for walls and ceilings. ",
                     pro_category = "",
                     pro_stock = "100866",
                     pro_Price = "465.98",
                 },
                 new Products_tab
                 {
                     product_id= 24,
                     pro_title = "Iron ",
                     imageLink = "https://www.buildusingsteel.org/wp-content/uploads/2021/01/structural-steel-framing.jpg ",
                     pro_details = "Used for lifting the weight of different things at one time. ",
                     pro_category = "",
                     pro_stock = "10067987",
                     pro_Price = "67.98",
                 }
            };
        }
    }
}

