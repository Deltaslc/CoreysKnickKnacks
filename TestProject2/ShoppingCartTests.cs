using System;
using CoreysKnickKnacks.Models;
using Xunit;
using Xunit.Sdk;

namespace StructuredProject1.Logic.TestsForStudents
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddProductTest_FirstGo()
        {
            try
            {
                // Assemble
                //you have to have the customer portion in to determine what is actually in their shopping cart
                //it also references Customer cust in the shopping cart itself.  Thats what the error is from.
                //you can reference shopping cart in the variable location, in act it is referencing all of getproduct totals not just 1.

                Customer cust = new Customer();
                ShoppingCart shoppingCart = new ShoppingCart(cust);
                var expected = new Product();
                expected.SetId(214);
                shoppingCart.AddProduct(expected, 1);

                // Act
                ShoppingCartItem actual = shoppingCart.GetProduct(1);

                // Assert
                Assert.Equal(214, actual.GetProduct().GetId());
            }
            catch
            {
                // Assert failure
                throw new XunitException("Opps.. you don't know what you are doing!");
            }

        }

        [Fact]
        public void AddProductTest_SecondGo()
        {
            try
            {
                // Assemble
                Customer cust = new Customer();
                ShoppingCart shoppingCart = new ShoppingCart(cust);
                var product1 = new Product();
                var expected = new Product();
                expected.SetId(216);
                shoppingCart.AddProduct(product1);
                shoppingCart.AddProduct(expected, 1);

                // Act
                ShoppingCartItem actual = shoppingCart.GetProduct(2);

                // Assert
                Assert.Equal(216, actual.GetProduct().GetId());
            }
            catch
            {
                // Assert failure
                throw new XunitException("Really, you do not!");
            }
        }

        [Fact]
        public void AddProductTest_ThirdGo()
        {
            try
            {
                // Assemble
                Customer cust = new Customer();
                ShoppingCart shoppingCart = new ShoppingCart(cust);
                var product1 = new Product();
                var product2 = new Product();
                var expected = new Product();
                expected.SetId(218);
                product2.SetId(216);
                shoppingCart.AddProduct(product1);
                shoppingCart.AddProduct(product2);
                shoppingCart.AddProduct(expected, 3);

                // Act
                ShoppingCartItem actual = shoppingCart.GetProduct(3);

                // Assert
                Assert.Equal(218, actual.GetProduct().GetId());
            }
            catch
            {
                // Assert failure
                throw new XunitException("So.. get it together!");
            }
        }

        [Fact]
        public void RemovingProductTest_FirstGo()
        {
            try
            {
                // Assemble
                Customer cust = new Customer();
                ShoppingCart shoppingCart = new ShoppingCart(cust);
                var product1 = new Product();
                shoppingCart.AddProduct(product1);

                // Act
                shoppingCart.RemoveProduct(product1, 1);

                // Assert
                Assert.Null(shoppingCart.RemoveProduct(product1, 1));
            }
            catch
            {
                // Assert failure
                throw new XunitException("What are you doing!");
            }

        }

        [Fact]
        public void RemovingProductTest_SecondGo()
        {
            try
            {
                // Assemble
                Customer cust = new Customer();
                ShoppingCart shoppingCart = new ShoppingCart(cust);
                var product1 = new Product();
                var product2 = new Product();
                shoppingCart.AddProduct(product1);
                shoppingCart.AddProduct(product2);

                // Act
                shoppingCart.RemoveProduct(product2, 1);

                // Assert
                Assert.Null(shoppingCart.RemoveProduct(product2, 1));
            }
            catch
            {
                // Assert failure
                throw new XunitException("Think it through!");
            }

        }

        [Fact]
        public void RemovingProductTest_ThirdGo()
        {
            try
            {
                // Assemble 
                Customer cust = new Customer();
                ShoppingCart shoppingCart = new ShoppingCart(cust);
                var product1 = new Product();
                var product2 = new Product();
                var product3 = new Product();
                product2.SetId(216);
                shoppingCart.AddProduct(product1);
                shoppingCart.AddProduct(product2);
                shoppingCart.AddProduct(product3);

                // Act
                shoppingCart.RemoveProduct(product3, 1);

                // Assert
                Assert.Null(shoppingCart.RemoveProduct(product3, 1));
            }
            catch
            {
                // Assert failure
                throw new XunitException("You can so totally do it!");
            }

        }

        [Fact]
        public void GettingTotal()
        {
            try
            {
                // Assemble
                Customer cust = new Customer();
                ShoppingCart shoppingCart = new ShoppingCart(cust);
                var price = 10m;
                var quantity = 5;
                var expected = 50;
                var product = new Product();
                product.SetPrice(price);
                var shoppingCartItem = new ShoppingCartItem(product, quantity);

                // Act
                var actual = shoppingCartItem.GetTotal();

                // Assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                // Assert failure
                throw new XunitException("You can do this correctly, do not give up!");
            }
        }
    }
}
