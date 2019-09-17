using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductID = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductID { get; private set; }
        public string ProductName { get; set; }

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product.

            return new Product();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves defined product

            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                isValid = false;

            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }
    }
}
