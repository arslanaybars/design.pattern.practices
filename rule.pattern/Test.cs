using System;
using System.Collections.Generic;
using Xunit;

namespace rule.pattern
{
    public class Test
    {

        private DiscountCalculator _calculator;

        public Test()
        {
            _calculator = new DiscountCalculator();
        }

        [Fact]
        public void Return15PctcForNewCustomer()
        {
            // Arrange
            var customer = new Customer();

            // Act
            decimal discount = _calculator.CalculateDiscountPercentage(customer);

            // Assert
            Assert.Equal(0.15m, discount);
        }

        [Fact]
        public void Return10PctForVeteran()
        {
            // Arrange
            var customer = new Customer
            {
                IsVeteran = true,
                DateOfFistPurchase = DateTime.Today.AddDays(-1)
            };

            // Act
            decimal discount = _calculator.CalculateDiscountPercentage(customer);

            // Assert
            Assert.Equal(0.1m, discount);
        }

        [Fact]
        public void Return1PctForSenior()
        {
            // Arrange
            var customer = new Customer
            {
                DateOfBirth = DateTime.Today.AddYears(-65).AddDays(-5),
                DateOfFistPurchase = DateTime.Today.AddDays(-1)
            };

            // Act
            decimal discount = _calculator.CalculateDiscountPercentage(customer);

            // Assert
            Assert.Equal(0.05m, discount);
        }


        [Fact]
        public void Return1PctForBirthday()
        {
            // Arrange
            var customer = new Customer
            {
                DateOfBirth = DateTime.Today,
                DateOfFistPurchase = DateTime.Today.AddDays(-1)
            };

            // Act
            decimal discount = _calculator.CalculateDiscountPercentage(customer);

            // Assert
            Assert.Equal(0.10m, discount);
        }

        [Fact]
        public void Return12PctFor5YearLoyalCustomer()
        {
            // Arrange
            var customer = new Customer
            {
                DateOfBirth = DateTime.Today.AddDays(-5),
                DateOfFistPurchase = DateTime.Today.AddYears(-5)
            };

            // Act
            decimal discount = _calculator.CalculateDiscountPercentage(customer);

            // Assert
            Assert.Equal(0.12m, discount);
        }

        [Fact]
        public void Return22PctFor5YearLoyalCustomerOnBirthday()
        {
            // Arrange
            var customer = new Customer
            {
                DateOfBirth = DateTime.Today.AddYears(-15),
                DateOfFistPurchase = DateTime.Today.AddYears(-5)
            };

            // Act
            decimal discount = _calculator.CalculateDiscountPercentage(customer);

            // Assert
            Assert.Equal(0.22m, discount);
        }

          [Fact]
        public void Return15PctForFirstTimeCustomer()
        {
            // Arrange
            var customer = new Customer
            {
                DateOfBirth = DateTime.Today.AddDays(-5),
                DateOfFistPurchase = null
            };

            // Act
            decimal discount = _calculator.CalculateDiscountPercentage(customer);

            // Assert
            Assert.Equal(0.15m, discount);
        }
    }
}