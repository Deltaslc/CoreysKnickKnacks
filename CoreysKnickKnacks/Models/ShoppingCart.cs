using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreysKnickKnacks.Models
{
    public class ShoppingCart
    {
        //variables for ShoppingCart
        private Customer _Customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;
        private List<ShoppingCartItem> Products;

        //constructor for receiving Customer and List
        public ShoppingCart(Customer cust)
        {
            _Customer = cust;
            Products = new List<ShoppingCartItem>();
        }

        //methods
        public int GetCustomerId()
        {
            return _Customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            //getting product 
            var cartProduct =
                Products.SingleOrDefault(cp => cp.GetProduct().GetId() == prod.GetId() && cp.GetQuantity() = quantity);
                cartProduct.ShoppingCartItem.Add();
            
            if (quantity < 1)
            {
                return null;                 
            }

            if (cartProduct != null)
            {
                cartProduct.SetQuantity(cartProduct.GetQuantity() + quantity);
                return cartProduct;
            }

            if (cartProduct == null)
            {
                cartProduct = new ShoppingCartItem(prod, quantity);
                return cartProduct;
            }

            return null;
        }

        //public ShoppingCartItem AddProduct(Product prod, int quantity)
        //{
            // checks for valid quantity
            //if (quantity < 1)
            //{
                //return null;
            //}

            // checking for product and adds the quantity if its found
            //if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            //{
                //_product1.SetQuantity(_product1.GetQuantity() + quantity);
                //return _product1;
            //}

            //if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            //{
                //_product2.SetQuantity(_product2.GetQuantity() + quantity);
                //return _product2;
            //}

            //if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            //{
                //_product3.SetQuantity(_product3.GetQuantity() + quantity);
                //return _product3;
            //}

            // adding new product if there is none
            //if (_product1 == null)
            //{
                //_product1 = new ShoppingCartItem(prod, quantity);
                //return _product1;
            //}

            //if (_product2 == null)
            //{
                //_product2 = new ShoppingCartItem(prod, quantity);
                //return _product2;
            //}

            //if (_product3 == null)
            //{
                //_product3 = new ShoppingCartItem(prod, quantity);
                //return _product3;
            //}

            //return null;
        //}

        //public ShoppingCartItem AddProduct(Product prod)
        //{
            //return AddProduct(prod, 1);
        //}

        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            // checking for quantity and removes it if found
            if (quantity > 1)
            {
                return null;
            }

            if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
                _product1.SetQuantity(_product1.GetQuantity() - quantity);

                if (_product1.GetQuantity() < 1)
                {
                    return null;
                }

                return _product1;
            }

            if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                _product2.SetQuantity(_product2.GetQuantity() - quantity);

                if (_product2.GetQuantity() < 1)
                {
                    return null;
                }

                return _product2;
            }

            if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                _product3.SetQuantity(_product3.GetQuantity() - quantity);

                if (_product3.GetQuantity() < 1)
                {
                    return null;
                }

                return _product3;
            }

            return null;
        }

        public ShoppingCartItem GetProduct(int id)
        {
            //linq query FirstOrDefault
            Products.FirstOrDefault(x => x.GetProduct().GetId() == id);

            return null;
        }

        //public ShoppingCartItem GetProduct(int id) //Changed from GetProductById as test was failing
        //{
            //if (id == _product1.GetProduct().GetId())
            //{
                //return _product1;
            //}

            //if (id == _product2.GetProduct().GetId())
            //{
                //return _product2;
            //}

            //if (id == _product3.GetProduct().GetId())
            //{
                //return _product3;
            //}

            //return null;
        //}

        public decimal GetTotal()
        {
            //use linq sum query
            decimal _p1 = (_product1.GetQuantity() * _product1.GetProduct().GetPrice());
            decimal _p2 = (_product2.GetQuantity() * _product2.GetProduct().GetPrice());
            decimal _p3 = (_product3.GetQuantity() * _product3.GetProduct().GetPrice());

            return _p1 + _p2 + _p3;
        }

        public List<ShoppingCartItem> GetProducts() //SHOULD THIS BE GETPRODUCT()
        {
            return Products;
        }

        //public ShoppingCartItem GetProduct(int productNum)
        //{
            //if (productNum == 1)
            //{
                //return _product1;
            //}

            //if (productNum == 2)
            //{
                //return _product2;
            //}

            //if (productNum == 3)
            //{
                //return _product3;
            //}

            //return null;
        //}
    }
}
