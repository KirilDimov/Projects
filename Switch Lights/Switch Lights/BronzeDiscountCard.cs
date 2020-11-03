using System;
using System.Collections.Generic;
using System.Text;

namespace Switch_Lights
{
    class BronzeDiscountCard : DiscountCard
    {
        public BronzeDiscountCard(float turnover, float purchase) : base(turnover, purchase)
        {
        }

        public override void calculateDiscount()
        {
            if (this.Turnover > 300)
            {
                this.DiscountRate = (float)2.5;
                this.Turnover += this.DiscountRate * this.Purchase;
                this.Discount = this.Purchase * (this.DiscountRate/100);
                this.Total = this.Purchase - this.Discount;
            }
            else if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                this.DiscountRate = (float)1.0;
                this.Turnover += this.DiscountRate * this.Purchase;
                this.Discount = this.Purchase * (this.DiscountRate / 100);
                this.Total = this.Purchase - this.Discount;
            }
            else
            {
                this.Discount = (float)0.0;
                this.Turnover += this.DiscountRate * this.Purchase;
                this.Discount = this.Purchase * (this.DiscountRate / 100);
                this.Total = this.Purchase - this.Discount;
            }
               
        }
    }
}
