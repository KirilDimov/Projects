using System;
using System.Collections.Generic;
using System.Text;

namespace Switch_Lights
{
    class GoldDiscountCard : DiscountCard
    {
        public GoldDiscountCard(float turnover, float purchase) : base(turnover, purchase)
        {
        }

        public override void calculateDiscount()
        {
            if (this.Turnover <100)
            {
                this.DiscountRate = (float)2.0;
                this.Turnover += this.DiscountRate * this.Purchase;
                this.Discount = this.Purchase * (this.DiscountRate / 100);
                this.Total = this.Purchase - this.Discount;
            }
            else if (this.Turnover >= 800)
            {
                this.Discount = (float)10.0;
                this.Turnover += this.DiscountRate * this.Purchase;
                this.Discount = this.Purchase * (this.DiscountRate / 100);
                this.Total = this.Purchase - this.Discount;
            }
            else
            {
                this.Discount = (float)((this.Turnover/100)%10+2);
                this.Turnover += this.DiscountRate * this.Purchase;
                this.Discount = this.Purchase * (this.DiscountRate / 100);
                this.Total = this.Purchase - this.Discount;
            }
        }
    }
}
