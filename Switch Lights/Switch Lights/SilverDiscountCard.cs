using System;
using System.Collections.Generic;
using System.Text;

namespace Switch_Lights
{
    class SilverDiscountCard : DiscountCard
    {
        public SilverDiscountCard(float turnover, float purchase) : base(turnover, purchase)
        {

        }

        public override void calculateDiscount()
        {
            if (this.Turnover > 300)
            {
                this.DiscountRate = (float)3.5;
                this.Turnover += this.DiscountRate * this.Purchase;
                this.Discount = this.Purchase * (this.DiscountRate / 100);
                this.Total = this.Purchase - this.Discount;
            }
            else
            {
                this.Discount = (float)2.0;
                this.Turnover += this.DiscountRate * this.Purchase;
                this.Discount = this.Purchase * (this.DiscountRate / 100);
                this.Total = this.Purchase - this.Discount;
            }
        }
    }
}
