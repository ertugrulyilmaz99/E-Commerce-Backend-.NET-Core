using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied = "You are not authorized.";
        public static string UserRegistered = "User is registered.";
        public static string UserNotFound = "User not found.";
        public static string PasswordError = "Password error.";
        public static string SuccessfulLogin = "Login successful.";
        public static string AccessTokenCreated = "Access token is created.";
        public static string UserAlreadyExists = "User already exists.";
    }
}
