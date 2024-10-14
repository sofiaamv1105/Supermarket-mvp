using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Presenters;
using static Azure.Core.HttpHeader;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;
        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBindingSource(productBindingSource);
            loadAllProductList();
            this.view.Show();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            loadAllProductList();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();

            if (!string.IsNullOrWhiteSpace(view.ProductId) && int.TryParse(view.ProductId, out int productId))
            {
                product.Product_Id = productId;
            }
            else
            {
                view.Message = "The Id is invalid.";
                return;
            }

            if (!string.IsNullOrWhiteSpace(view.ProductPrice) && decimal.TryParse(view.ProductPrice, out decimal productPrice))
            {
                product.Product_Price = productPrice;
            }
            else
            {
                view.Message = "Product Price Invalid.";
                return;
            }

            if (!string.IsNullOrWhiteSpace(view.ProductStock) && int.TryParse(view.ProductStock, out int productStock))
            {
                product.Product_Stock = productStock;
            }
            else
            {
                view.Message = "Stock Invalid.";
                return;
            }

            if (!string.IsNullOrWhiteSpace(view.CategoryId) && int.TryParse(view.CategoryId, out int categoryId))
            {
                product.Category_Id = categoryId;
            }
            else
            {
                view.Message = "Category Id Invalid.";
                return;
            }

            product.Product_Name = view.ProductName;

            try
            {
                new Common.ModelDataValidation().Validate(product);

                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product Saved.";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product Saved.";
                }

                view.IsSuccessful = true;
                loadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.Product_Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted Succesfully";
                loadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Product_Id.ToString();
            view.ProductName = product.Product_Name;
            view.ProductPrice = product.Product_Price.ToString();
            view.ProductStock = product.Product_Stock.ToString();
            view.CategoryId = product.Category_Id.ToString();


            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            loadAllProductList();
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }

        private void loadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }
    }
}