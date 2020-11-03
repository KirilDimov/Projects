using System;
using System.Collections.Generic;
using System.Text;

namespace Switch_Lights
{
    abstract class DiscountCard
    {
        private float turnover;
        private float purchase;
        private float discountRate;
        private float discount;
        private float total;

        public DiscountCard(float turnover, float purchase)
        {
            this.turnover = turnover;
            this.purchase = purchase;
        }

        public float Turnover { get => turnover; set => turnover = value; }
        public float Purchase { get => purchase; set => purchase = value; }
        public float DiscountRate { get => discountRate; set => discountRate = value; }
        public float Discount { get => discount; set => discount = value; }
        public float Total { get => total; set => total = value; }

        public abstract void calculateDiscount();

        public override string ToString()
        {
            return "Purchase value: $"+Math.Round(this.purchase,2) +"\n"+ "Discount rate: "+Math.Round(this.discountRate,2)+"%"+"\n"
                + "Discount: $" + Math.Round(this.discount,2) + "\n" + "Total: $" + Math.Round(this.total,2)+"\n";
        }

    }
}
