using Core.Entites.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constantss
{
    public static class Messages
    {
         public static string CustomerFindexZero= "Customer findex point zero";
        public static string FindexListed = "FindexListed";
        public static string UserNotFound = "The user could not found";
        public static string GetErrorRentalMesssage = "Rental error";
        public static string SuccessfullyAdded = "Successfully added";
        public static string SuccessfullyDeleted= "Successfully deleted";
        public static string UpdatedSuccessfully = "Successfully updated";
        public static string CarAdded = "Car added";
        public static string CarNameInvalid = "The car name is invalid";
        public static string CarListed = "Cars listed";
        public static string CarDeleted = "The car was deleted";
        public static string BrandAdded = "Brand added";
        public static string BrandDeleted = "The brand was deleted";
        public static string BrandListed = "Brands listed";
        public static string BrandNameInvalid = "Brand name is invalid";
        public static string RentaCar = "The car rented";
        public static string RentaCarInvalid = "The car has not delivered yet";
        public static string UserAdded = "User added";
        public static string CarUpdated = "The car ";
        public static string ImageLimitExceeded= "Up to 5 images can be added";
        public static string UserDeleted = "User deleted";
        public static string UserUpdated="User updated";
        public static string PasswordError = "Password is wrong";
        public static string SuccesfulLogin = "Successfully logged in";
        public static string UserAlreadyExists = "this user already exists";
        public static string UserRegistered = "User registed";
        public static string AccessTokenCreated = "Token created";
        public static string AuthorizationDenied = "you are not authorized";
        public static string CarNotAvailable = "The car not available";
        public static string SuccessfullyPaid = "Payment transaction completed";
        public static string GetSucccesRentalMessage = "Succes rental message";
        public static string FindexAdded = "FindexAdded";
        public static string FindexDeleted = "FindexDeleted";
        internal static string FindexUpdated;
        internal static string CustomerScoreIsInsufficient = "Customer score is insufficient";
        internal static string UsersLister;
    }
}
