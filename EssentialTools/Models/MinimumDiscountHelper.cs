using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class MinimumDiscountHelper :Discount.IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
           if(totalParam < 0)
            { throw new NotImplementedException();}
           else if (totalParam > 100)
           {
               return totalParam *0.9M;
           }
           else if (totalParam >= 10 && totalParam <= 100)
           {
               return totalParam - 5;
           }
           else
           {
               return totalParam;
           }
        }
    }
}