using System;
using System.Collections.Generic;
using System.Text;

namespace _24收银台
{

    /// <summary>
    /// 
    /// 打折的父类
    /// 
    /// </summary>

   public abstract class CalFather
    {

       /// <summary>
       /// 
       /// 计算打折后应付多少钱
       /// 
       /// </summary>
       /// <param name="realmoney"></param>
       /// <returns></returns>

        public abstract double GetTotalMoney(double realmoney);


    }

    /// <summary>
    /// 
    /// 不打折
    /// 
    /// 该多少钱就多少钱
    /// 
    /// </summary>


   public class NoDiscount:CalFather
   {

       public override double GetTotalMoney(double realmoney)
       {

           return realmoney;
          // throw new NotImplementedException();
       }
   }



   public class RateDiscount : CalFather
   {

       private double rate;

       public double Rate
       {
           get { return rate; }
           set { rate = value; }
       }

       public RateDiscount(double rate)
       {
           this.Rate = rate;
       
       }


       public override double GetTotalMoney(double realmoney)
       {
           return this.Rate * realmoney;
       }
   }

    /// <summary>
    /// 
    /// 买500送100
    /// 
    /// </summary>

   public class BuyMSN : CalFather
   {

       public double M { get; set; }

       public double N { get; set; }

       public BuyMSN(double m, double n)
       {
           this.M = m;

           this.N = n;
       }

       public override double GetTotalMoney(double realmoney)
       {

           if (realmoney >= this.M)
           {
               return realmoney - (int)(realmoney/this.M)*this.N;
           }
           else
           {
               return realmoney;
           }
          // throw new NotImplementedException();
       }
   }




}
