using System;
using BusyZone.DataModel;

namespace BusyZone.ViewModels;


public partial class AddProductsPageViewModel : BindableObject
{
		public AddProductsPageViewModel()
		{
           InsertProducts = new Command(InsertProductsCommand);

        }
    public Command InsertProducts { get; }
    string productTitle;
    public string ProductTitle
    {
        get => productTitle;
        set
        {
            productTitle = value;
            OnPropertyChanged(nameof(ProductTitle));
        }
    }
    string productDetails;
    public string ProductDetail
    {
        get => productDetails;
        set
        {
            productDetails = value;
            OnPropertyChanged(nameof(ProductDetail));
        }
    }
    string productCat;
    public string ProductCat
    {
        get => productCat;
        set
        {
            productCat = value;
            OnPropertyChanged(nameof(ProductCat));
        }
    }
    string productImagelink;
    public string ProductImageLink
    {
        get => productImagelink;
        set
        {
            productImagelink = value;
            OnPropertyChanged(nameof(ProductImageLink));
        }
    }
    string productStock;
    public string ProductStock
    {
        get => productStock;
        set
        {
            productStock = value;
            OnPropertyChanged(nameof(ProductStock));
        }
    }
    string productPrice;
    public string ProductPrice
    {
        get => productPrice;
        set
        {
            productPrice = value;
            OnPropertyChanged(nameof(ProductPrice));
        }
    }

    async void InsertProductsCommand()
    {
        if (string.IsNullOrEmpty(ProductTitle) ||
            string.IsNullOrEmpty(ProductDetail) ||
            string.IsNullOrEmpty(ProductCat) ||
            string.IsNullOrEmpty(ProductImageLink) )
        {
            await Application.Current.MainPage.DisplayAlert("Empty Field", $"Please Fill the Fields", "OK");
        }
        else
        {
           
              /*   ProductdataService.AddProducts(new Products_tab
                {
                    pro_title = ProductTitle,
                    pro_details = ProductDetail,
                    pro_category = ProductCat,
                    pro_stock = ProductStock,
                    pro_Price = productPrice,
                    imageLink = productImagelink,
                    dateCreated = DateTime.UtcNow,
                });

                ProductTitle = string.Empty;
                ProductDetail = string.Empty;
                ProductCat = string.Empty;
                productImagelink = string.Empty; */
           
           
        }
       
    }


}

