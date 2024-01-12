using System.Collections.ObjectModel;
using BusyZone.DataModel;
namespace BusyZone.ViewModels;

[QueryProperty(nameof(Products_tab), "Produts")]
public partial class ProductDetailsPageViewModel : BindableObject
{
    private ObservableCollection<productColors> _productColors;
   
    public ProductDetailsPageViewModel()
	{
        LoadColors();

    }
   // [ObservableProperty]
    Products_tab products;

    public ObservableCollection<productColors> ListColors
    {
        get { return _productColors; }
        set
        {
            _productColors = value;
            OnPropertyChanged();
        }
    }

    void LoadColors()
    {
        ListColors = new ObservableCollection<productColors>()
        {
            new productColors
            {
                pro_colorId = 1, 
                product_id = 1, 
                ColorOption = Color.FromRgba("#fdea34"),
                colorDescr = " Warm Color",
            },
            new productColors
            {
                pro_colorId = 2,
                product_id = 2,
                ColorOption = Color.FromRgba("#000000"),
                colorDescr = " Warm Color",
            },
            new productColors
            {
                pro_colorId = 3,
                product_id = 3,
                ColorOption = Color.FromRgba("#FEDAEC"),
                colorDescr = " Warm Color",
            },
            new productColors
            {
                pro_colorId = 4,
                product_id = 4,
                ColorOption = Color.FromRgba("#BBEEFF"),
                colorDescr = " Warm Color",
            },
            new productColors
            {
                pro_colorId = 5,
                product_id = 5,
                ColorOption = Color.FromRgba("#22559C"),
                colorDescr = " Warm Color",
            },
        };
    }
}

