using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product Name is Invalid!";
        public static string MaintenanceTime = "System is in Maintenance";
        public static string ProductsListed = "Products Listed";
        public static string ProductCountOfCategoryError = "There will be at most 10 different products in a category.";
        public static string ProductNameAlreadyExists = "Product already exists.";
        public static string CategoryLimitExceded = "Can't add new product. Category Limit is Exceded.";
    }
}
