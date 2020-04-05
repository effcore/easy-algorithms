using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Password
    {
        public int MinimumLength = 8;
        public int MaximumLength = 255;
        public bool ContainsSpecialCharacters = true;
        public bool ContainsUpperAndLowerCase = true;
        public bool ContainsDigit = true;
        public bool CheckForSqlPhrases = true;
        public bool CheckForForbiddenCharacters = true;
        public char[] ForbiddenCharacters = new char[] { ' ', '*', '/', '"' };
        public char[] SpecialCharacters = new char[] { '!', '§', '$', '%', '&', '(', ')', '=', '?', '#' };
        public string[] SqlPhrases = new string[] { ";", "--", "//"};

        /// <summary>
        /// Checks if the password fulfills are requirements
        /// </summary>
        /// <param name="password"></param>
        public virtual void CheckPassword(string password)
        {
            bool flagForSpecialChar = false;

            if (string.IsNullOrEmpty(password))
                throw new Exception("password is empty");

            if (password.Length < MinimumLength)
                throw new Exception($"password's minimum length of {MinimumLength} characters not reached");

            if (password.Length > MaximumLength)
                throw new Exception($"password's maximum length of {MaximumLength} characters was reached");

            if (!password.Any(char.IsLower) && ContainsUpperAndLowerCase)
                throw new Exception("password does not contain a lower case character");

            if (!password.Any(char.IsUpper) && ContainsUpperAndLowerCase)
                throw new Exception("password does not contain a upper case character");

            if (!password.Any(char.IsDigit) && ContainsDigit)
                throw new Exception("password does not contain a digit");

            if (CheckForForbiddenCharacters)
            {
                foreach (char passwordChar in password)
                {
                    foreach (char forbiddenChar in ForbiddenCharacters)
                    {
                        if (passwordChar == forbiddenChar)
                        {
                            throw new Exception($"password contains a forbidden character '{forbiddenChar}'");
                        }
                    }
                }
            }

            if (ContainsSpecialCharacters)
            {
                foreach (char passwordChar in password)
                {
                    foreach (char specialChar in SpecialCharacters)
                    {
                        if (passwordChar == specialChar)
                        {
                            flagForSpecialChar = true;
                        }
                    }
                }
            }

            if (ContainsSpecialCharacters && !flagForSpecialChar)
                throw new Exception("password does not contain a special character");

            if (CheckForSqlPhrases)
            {
                foreach(string sqlPhrase in SqlPhrases)
                {
                    if (password.Contains(sqlPhrase))
                        throw new Exception($"password contains a forbidden sql phrase '{sqlPhrase}'");
                }
            }
        }

        /// <summary>
        /// Checks if the given password was already used before.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="oldPasswords"></param>
        /// <returns>returns true it this password was already used</returns>
        public virtual bool IsPasswordUsedMultipleTimes(string password, string[] oldPasswords)
        {
            foreach (string oldPassword in oldPasswords)
            {
                if (password == oldPassword)
                    return true;
            }

            return false;
        }
    }
}
