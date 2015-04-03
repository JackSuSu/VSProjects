using System;
using System.Collections.Generic;
using System.Text;

namespace _24收银台
{
    class SupperMarket
    {

        CangKu cangku = new CangKu();

        /// <summary>
        /// 
        /// 创建超市对象的时候给超市货架导入货物
        /// 
        /// </summary>

        public SupperMarket()
        {
            cangku.JinPros("1", 1000);

            cangku.JinPros("2", 2000);

            cangku.JinPros("3", 4500);

            cangku.JinPros("4", 500);
        }

        public void AskBuying()
        {

            Console.WriteLine("欢迎光临，请问您需要什么？");

            Console.WriteLine("我们有宏基，三星，酱油和香蕉");

            cangku.ShowPros();

            string inputdata = Console.ReadLine();

            Console.WriteLine("您需要几个？");

            //超市取货

            int count = Convert.ToInt32(Console.ReadLine());

            ProductFather[] getpros = cangku.QuPros(inputdata, count);

            //下面开始取钱了

            double sumonye = GetMoney(getpros);

            Console.WriteLine("您总共需要付:{0}", sumonye);


            // 今天打折，明天可能也打折，提取出父类


            Console.WriteLine("选择打折方式：1--不打折 2--打九折 3--八五折 4--满500送50");

            CalFather disocunt = null;

            string inpudata1 = Console.ReadLine();

            int data1 = Convert.ToInt32(inpudata1);

            double discountMoney = 0;

            switch (data1)
            {
                case 1:

                    disocunt = new NoDiscount();

                   discountMoney= disocunt.GetTotalMoney(sumonye);

                    break;

                case 2:

                    disocunt = new RateDiscount(0.9);

                    discountMoney = disocunt.GetTotalMoney(sumonye);



                    break;

                case 3:

                      disocunt = new RateDiscount(0.85);

                    discountMoney = disocunt.GetTotalMoney(sumonye);


                    break;

                case 4:

                    disocunt = new BuyMSN(500, 50);

                    discountMoney = disocunt.GetTotalMoney(sumonye);

                    break;
            }

            Console.WriteLine("打折后，您实际应付：{0}", discountMoney);


        }


        /// <summary>
        /// 
        /// 获取价格
        /// 
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>

        public double GetMoney(ProductFather[] pros)
        {
            double sum = 0;

            for (int i = 0; i < pros.Length; i++)
            {
                sum += pros[i].Price;
            }

            return sum;
        }


    }
}
