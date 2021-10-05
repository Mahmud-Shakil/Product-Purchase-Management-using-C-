using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Product_Purchase_Management
{
  public class ViewModel : INotifyPropertyChanged
    {
        private List<Product> products;
        private int currentProduct;
        public Command NextProduct { get; private set; }
        public Command PreviousProduct { get; private set; }
        public ViewModel()
        {
            this.currentProduct = 0;
            this.IsAtstart = true;
            this.IsAtEnd = false;
            this.NextProduct = new Command(this.Next, () => this.products.Count > 1 && !this.IsAtEnd);
            this.PreviousProduct = new Command(this.Previous, () => this.products.Count > 0 && !this.IsAtstart);
            this.products = new List<Product>
            {
                new Product
                {ProductCode = 101,
                ProductName = "Xbox One",
                ProductType = "Video Game Consoles",
                ProductQuantity = 2,
                Supplier="Microsoft",
                Price=40000
                },
                new Product
                {
                    ProductCode = 102,
                ProductName = "Play Station 5",
                ProductType = "Video Game Consoles",
                ProductQuantity = 3,
                Supplier="Sony",
                Price=72000
                },
                new Product
                {
                    ProductCode = 103,
                ProductName = "Ps Vita",
                ProductType = "Video Game Consoles",
                ProductQuantity = 3,
                Supplier="Sony",
                Price=50000
                },
                new Product
                {
                    ProductCode = 104,
                ProductName = "Joystick",
                ProductType = "Video Game Controller",
                ProductQuantity = 5,
                Supplier="Sony",
                Price=50000
                },
                new Product
                {
                    ProductCode = 105,
                ProductName = "Z1R Premium",
                ProductType = "Headphone",
                ProductQuantity = 10,
                Supplier="Microsoft",
                Price=100000
                }
            };
        }
        private bool _isAtstart;
        public bool IsAtstart
        {
            get => this._isAtstart;
            set
            {
                this._isAtstart = value;
                this.Onpropertychanged(nameof(IsAtstart));
            }
        }
        private bool _isAtEnd;
        public bool IsAtEnd
        {
            get => this._isAtEnd;
            set
            {
                this._isAtEnd = value;
                this.Onpropertychanged(nameof(IsAtEnd));
            }
        }

        public Product Current
        {
            get => this.products.Count > 0 ? this.products[currentProduct] : null;
        }
        private void Next()
        {
            if (this.products.Count -1> this.currentProduct)
            {
                this.currentProduct++;
                this.Onpropertychanged(nameof(Current));
                this.IsAtstart = false;
                this.IsAtEnd = (this.products.Count - 1 == this.currentProduct);
            }
        }

        private void Previous()
        {
            if (this.currentProduct>0)
            {
                this.currentProduct--;
                this.Onpropertychanged(nameof(Current));
                this.IsAtEnd = false;
                this.IsAtstart = (this.currentProduct == 0);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void Onpropertychanged(string propertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
   }
  
}
