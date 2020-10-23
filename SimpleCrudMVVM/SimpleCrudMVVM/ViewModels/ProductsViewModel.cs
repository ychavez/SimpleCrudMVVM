using SimpleCrudMVVM.Data;
using SimpleCrudMVVM.Models;
using SimpleCrudMVVM.ViewModels.Base;
using SimpleCrudMVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleCrudMVVM.ViewModels
{
   public class ProductsViewModel : BaseViewModel
    {
        public ICommand AddCommand { get; set; }

        private Context _Context;
        public ProductsViewModel()
        {
            _Context = new Context();
            LoadProducts();
            AddCommand = new Command(Add);
        }
        private ObservableCollection<Product> _Products;
        public ObservableCollection<Product> Products
        {
            get => _Products;

            set
            {

                SetProperty(ref _Products, value);
            }
        }

        public async void LoadProducts()
        {

            Products = new ObservableCollection<Product>(await _Context.GetProducts());
        }

        public void Add()
        {
            Navigation.PushAsync(new ProductItemView());

        }

    }
}
