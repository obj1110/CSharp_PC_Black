using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Party_planner
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        public int NumberOfPeople {
            get { return numberOfPeople; }
            set { numberOfPeople = value; }
        }
        private decimal costOfBeveragesPerPerson;
        public decimal CostOfBeveragesPerPerson
        {
            get { return costOfBeveragesPerPerson; }
            set { costOfBeveragesPerPerson = value; }
        }
        private decimal costOfDecorations = 0;
        public decimal CostOfDecorations
        {
            get { return costOfBeveragesPerPerson; }
            set { costOfBeveragesPerPerson = value; } 
        }


        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations +
                   ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)
                       * NumberOfPeople);

            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
//这个程序一开始出错的原因就是没有及时的进行更新。
//所以我们可以在set里面进行更新，在set里面就更新这个costOfDecoration