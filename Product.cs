using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Product_Purchase_Management
{
   public class Product : INotifyPropertyChanged
    {
        public int _productCode;
        public int ProductCode
        {
            get => this._productCode;
            set
            {
                this._productCode = value;
                this.OnpropertyChnged(nameof(ProductType));
            }
        }
        public string _productName;
        public string ProductName
        {
            get => this._productName;
            set
            {
                this._productName = value;
                this.OnpropertyChnged(nameof(ProductName));
            }
        }
        public string _productType;
        public string ProductType
        {
            get => this._productType;
            set
            {
                this._productType = value;
                this.OnpropertyChnged(nameof(ProductType));
            }
        }
        public int _productQuantity;
        public int ProductQuantity
        {
            get => this._productQuantity;
            set
            {
                this._productQuantity = value;
                this.OnpropertyChnged(nameof(ProductQuantity));
            }
        }
        public string _supplier;
        public string Supplier
        {
            get => this._supplier;
            set
            {
                this._supplier = value;
                this.OnpropertyChnged(nameof(Supplier));
            }
        }
        public double _price;
        public double Price
        {
            get => this._price;
            set
            {
                this._price = value;
                this.OnpropertyChnged(nameof(Price));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnpropertyChnged(string provertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(provertyName));
            }
        }

    }
}
