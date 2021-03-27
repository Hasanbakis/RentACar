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
        internal static readonly User UserNotFound;
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
        internal static string CarDeliverTheCar;
        internal static string GetSucccesRentalMessage;
        internal static List<RentalDetailDto> GetErrorRentalMesssage;
        public static string SuccessfullyPaid = "Payment transaction completed";
    }
}
