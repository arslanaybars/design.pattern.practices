using System;
using System.Collections.Generic;

namespace rule.pattern
{
    public interface IDiscountRule
    {
        decimal CalculateCustomerDiscount(Customer customer);
    }

    public class BirthdayDiscountRule : IDiscountRule
    {
        public decimal CalculateCustomerDiscount(Customer customer)
        {
            if (customer.DateOfBirth.Month == DateTime.Today.Month &&
               customer.DateOfBirth.Day == DateTime.Today.Day)
            {
                return 0.10m;
            }

            return 0m;
        }
    }

    public class SeniorDiscountRule : IDiscountRule
    {
        public decimal CalculateCustomerDiscount(Customer customer)
        {
            if (customer.DateOfBirth < DateTime.Now.AddYears(-65))
            {
                return .05m;
            }

            return 0m;
        }
    }

    public class VeteranRule : IDiscountRule
    {
        public decimal CalculateCustomerDiscount(Customer customer)
        {
            if (customer.IsVeteran)
            {
                return .10m;
            }

            return 0m;
        }
    }

    public class LoyalCustomerRule : IDiscountRule
    {
        public int _yearsAsCustomer { get; }
        public decimal _discount { get; }

        public LoyalCustomerRule(int yearsAsCustomer, decimal discount)
        {
            _yearsAsCustomer = yearsAsCustomer;
            _discount = discount;
        }

        public decimal CalculateCustomerDiscount(Customer customer)
        {
            if (customer.DateOfFistPurchase.HasValue)
            {
                if (customer.DateOfFistPurchase.Value.AddYears(_yearsAsCustomer) <= DateTime.Today)
                {
                    var birthdayRule = new BirthdayDiscountRule();
                    return _discount + birthdayRule.CalculateCustomerDiscount(customer);
                }
            }

            return 0m;
        }
    }

    public class FirstTimeRule : IDiscountRule
    {
        public decimal CalculateCustomerDiscount(Customer customer)
        {
            if (!customer.DateOfFistPurchase.HasValue)
            {
                return .15m;
            }

            return 0m;
        }
    }

    public class DiscountCalculator
    {
        List<IDiscountRule> _rules = new List<IDiscountRule>();

        public DiscountCalculator()
        {
            _rules.Add(new BirthdayDiscountRule());
            _rules.Add(new SeniorDiscountRule());
            _rules.Add(new VeteranRule());
            _rules.Add(new LoyalCustomerRule(1, 0.10m));
            _rules.Add(new LoyalCustomerRule(5, 0.12m));
            _rules.Add(new LoyalCustomerRule(10, 0.20m));
            _rules.Add(new FirstTimeRule());
        }

        public decimal CalculateDiscountPercentage(Customer customer)
        {
            decimal discount = 0;

            foreach (var rule in _rules)
            {
                discount = Math.Max(rule.CalculateCustomerDiscount(customer), discount);
            }

            return discount;
        }
    }
}