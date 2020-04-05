using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTest
{
    [TestClass]
    public class PasswordTest
    {
        Password testPassword = new Password();

        #region Hash MD5
        [TestMethod]
        public void TestHashMD5()
        {
            string expectedResult = "54A9EC734B13E3F133218090993B49C4";
            string result = testPassword.HashMD5("Hello my friends!");

            Assert.AreEqual(expectedResult, result);
        }
        #endregion

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

        #region Test Weak Password Requirements
        [TestMethod]
        public void TestCheckPasswordWeak01()
        {
            var weakPassword = GetWeakPasswordReq();

            try
            {
                weakPassword.CheckPassword("HelloFriend");
            }
            catch (Exception ex)
            {
                Assert.Fail("expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "password does not contain a upper case character")]
        public void TestCheckPasswordWeak02()
        {
            var weakPassword = GetWeakPasswordReq();
            weakPassword.CheckPassword("hellofriend");
        }
        #endregion

        #region Test Regular Password Requirements
        [TestMethod]
        public void TestCheckPasswordRegular01()
        {
            var regularPassword = GetRegularPasswordReq();

            try
            {
                regularPassword.CheckPassword("HelloFriend01");
            }
            catch (Exception ex)
            {
                Assert.Fail("expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "password does not contain a digit")]
        public void TestCheckPasswordRegular02()
        {
            var regularPassword = GetRegularPasswordReq();
            regularPassword.CheckPassword("HelloFriend");
        }
        #endregion

        #region Test Strong Password Requirements
        [TestMethod]
        public void TestCheckPasswordStrong01()
        {
            var strongPassword = GetStrongPasswordReq();

            try
            {
                strongPassword.CheckPassword("HelloMyFriends01!");
            }
            catch (Exception ex)
            {
                Assert.Fail("expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "password does not contain a special character")]
        public void TestCheckPasswordStrong02()
        {
            var strongPassword = GetStrongPasswordReq();
            strongPassword.CheckPassword("HelloMyFriends01");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "password contains a forbidden sql phrase ';'")]
        public void TestCheckPasswordStrong03()
        {
            var strongPassword = GetStrongPasswordReq();
            strongPassword.CheckPassword("HelloMyFriends01!;--");
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
