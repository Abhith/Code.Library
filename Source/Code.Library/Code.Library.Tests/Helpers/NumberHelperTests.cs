﻿namespace Code.Library.Tests.Helpers
{
    using Code.Library.Helpers;

    using Shouldly;

    using Xunit;

    public class NumberHelperTests
    {
        #region Public Methods

        /// <summary>
        /// The get nth digit tests.
        /// </summary>
        [Fact]
        public void GetNthDigitTests()
        {
            int number = 7654321;

            var firstDigit = number.GetNthDigit(1);
            var thirdDigit = number.GetNthDigit(3);
            var sixthDigit = number.GetNthDigit(6);
            var seventhDigit = number.GetNthDigit(7);

            firstDigit.ShouldBe(1);
            thirdDigit.ShouldBe(3);
            sixthDigit.ShouldBe(6);
            seventhDigit.ShouldBe(7);

            number = 10;

            firstDigit = number.GetNthDigit(1);
            var secondDigit = number.GetNthDigit(2);

            firstDigit.ShouldBe(0);
            secondDigit.ShouldBe(1);
        }

        #endregion Public Methods
    }
}