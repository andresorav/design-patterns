using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TemplateMethodPattern
{
    public class User : AbstractRecord
    {
        private const int MinUsernameLength = 3;
        private const int MaxUsernameLength = 25;
        private const int MinPasswordLength = 8;
        private const int MaxPasswordLength = 25;

        public User(IDictionary<string, string> fields) : base(fields)
        {
        }

        protected override void Validate()
        {
            if (!Fields.ContainsKey("username") || !IsValidUsername(Fields["username"]))
            {
                throw new FieldValidationException("Username is not valid");
            }

            if (!Fields.ContainsKey("password") || !IsValidPassword(Fields["password"]))
            {
                throw new FieldValidationException("Password is not valid");
            }

            Console.WriteLine("User data is valid");
        }

        protected override void FailedSave(FieldValidationException exception)
        {
            Console.WriteLine("User validation failed: {0}", exception.Message);
        }

        protected override void BeforeSave()
        {
            Console.WriteLine("Before we save user, let's hash password");
            Fields["password"] = HashPassword(Fields["password"]);
        }

        protected override void AfterSave()
        {
            Console.WriteLine("User {0} successfully saved", Fields["username"]);
        }

        private string HashPassword(string password)
        {
            var crypt = new SHA256Managed();
            var hash = new StringBuilder();

            var crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password));
            foreach (var theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }

            return hash.ToString();
        }

        private bool IsValidUsername(string username)
        {
            return !string.IsNullOrEmpty(username) &&
                   username.Length >= MinUsernameLength &&
                   username.Length <= MaxUsernameLength;
        }

        private bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password) &&
                   password.Length >= MinPasswordLength &&
                   password.Length <= MaxPasswordLength;
        }
    }
}