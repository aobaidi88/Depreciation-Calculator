using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ObaidiP4.Shared
{
    public class DepreciationDoubleDeclining:DepreciationStraightLine
    {
        public DepreciationDoubleDeclining(double startValue, double salvageValue, int lifeTime, int age)
        {
            this.startValue = startValue;
            this.salvageValue = salvageValue;
            this.lifeTime = lifeTime;
            this.age = age;
            Calc();
        }

        public DepreciationDoubleDeclining() : this(0, 0, 0, 0)
        {
        }
        public override void Calc()
        {
            double rate, balance;
            rate = ((1.0 / lifeTime) * 2);
            balance = rate * startValue;
            EndValue = startValue;
             
            for (int i = 0; i < age; i++)
            {
                EndValue -= balance;
                balance = (EndValue*rate);
            }
        }

        public override string ToString() => base.ToString();
    }
  }
