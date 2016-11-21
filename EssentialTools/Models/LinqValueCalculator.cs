using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace EssentialTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private Discount.IDiscountHelper discounter;
        private static int counter = 0;

        public LinqValueCalculator(Discount.IDiscountHelper discountParam)
        {
            discounter = discountParam;
            System.Diagnostics.Debug.WriteLine(string.Format("Instance {0} created", ++counter));
        }
        //uses LINQ sum method to add together the value of the Price property of each Product object
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}