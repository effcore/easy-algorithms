using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTest
{
    [TestClass]
    public class PasswordTest
    {
        #region Test Poor Password Requirements
        [TestMethod]
        public void TestCheckPasswordPoor01()
        {
            var poorPassword = GetPoorPasswordReq();

            try
            {
                poorPassword.CheckPassword("abcd");
            }
            catch (Exception ex)
            {
                Assert.Fail("expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "password's maximum length of 4 characters was reached")]
        public void TestCheckPasswordPoor02()
        {
            var poorPassword = GetPoorPasswordReq();
            poorPassword.CheckPassword("abc32h98");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "password's minimum length of 1 characters not reached")]
        public void TestCheckPasswordPoor03()
        {
            var poorPassword = GetPoorPasswordReq();
            poorPassword.CheckPassword("");
        }
        #endregion

        #region Password Requirements
        internal Password GetPoorPasswordReq()
        {
            Password TestPassword = new Password();
            TestPassword.MinimumLength = 1;
            TestPassword.MaximumLength = 4;
            TestPassword.ContainsDigit = false;
            TestPassword.ContainsSpecialCharacters = false;
            TestPassword.ContainsUpperAndLowerCase = false;
            TestPassword.CheckForForbiddenCharacters = false;
            TestPassword.CheckForSqlPhrases = false;

            return TestPassword;
        }

        internal Password GetWeakPasswordReq()
        {
            Password TestPassword = new Password();
            TestPassword.MinimumLength = 4;
            TestPassword.MaximumLength = 12;
            TestPassword.ContainsDigit = false;
            TestPassword.ContainsSpecialCharacters = false;
            TestPassword.ContainsUpperAndLowerCase = true;
            TestPassword.CheckForForbiddenCharacters = false;
            TestPassword.CheckForSqlPhrases = false;

            return TestPassword;
        }

        internal Password GetRegularPasswordReq()
        {
            Password TestPassword = new Password();
            TestPassword.MinimumLength = 8;
            TestPassword.MaximumLength = 255;
            TestPassword.ContainsDigit = true;
            TestPassword.ContainsSpecialCharacters = false;
            TestPassword.ContainsUpperAndLowerCase = true;
            TestPassword.CheckForForbiddenCharacters = false;
            TestPassword.CheckForSqlPhrases = false;

            return TestPassword;
        }

        internal Password GetStrongPasswordReq()
        {
            Password TestPassword = new Password();
            TestPassword.MinimumLength = 8;
            TestPassword.MaximumLength = 10000;
            TestPassword.ContainsDigit = true;
            TestPassword.ContainsSpecialCharacters = true;
            TestPassword.ContainsUpperAndLowerCase = true;
            TestPassword.CheckForForbiddenCharacters = true;
            TestPassword.CheckForSqlPhrases = true;

            return TestPassword;
        }
        #endregion
    }
}
