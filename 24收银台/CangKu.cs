using System;
using System.Collections.Generic;
using System.Text;

namespace _24收银台
{
    class CangKu
    {

        //存储货物


        /// <summary>
        /// 
        /// 如果有八百种货物就不行
        /// 
        /// 灵活性不高
        /// 
        /// </summary>

        //List<Acer> listAcer = new List<Acer>();

        //List<Sumngs> listSum = new List<Sumngs>();


        /// <summary>
        /// 
        /// 这样存储可以
        /// 
        /// 里氏转换 子类赋值给父类
        /// 
        /// 下面的写法把各种商品 都堆在一起了 
        /// 
        /// 没有体现非门别类 所有的货物都存储在一起
        /// 
        /// 
        /// </summary>


        //List<ProductFather> producntlist = new List<ProductFather>();



        /// <summary>
        /// 
        /// 这种更系统化
        /// 
        /// 1.各种商品分类的加在一起形成一个
        /// 
        /// 2.List<List></List>
        /// 
        /// 思想：仓库-->货架-->商品
        /// 
        /// </summary>

        List<List<ProductFather>> productList = new List<List<ProductFather>>();

        /// <summary>
        /// 
        /// 在创建仓库的时候 向仓库中添加货架
        /// 
        /// 仓库是一个货架的集合
        /// 
        /// 货架是一个集合
        /// 
        /// list<0>存储 Acer电脑
        /// 
        /// list<1>存储 三星手机
        /// 
        /// list<2>存储 香蕉
        ///  
        /// list<3>存储 酱油
        /// 
        /// </summary>

        public CangKu()
        {


            productList.Add(new List<ProductFather>());

            productList.Add(new List<ProductFather>());

            productList.Add(new List<ProductFather>());

            productList.Add(new List<ProductFather>());


        }



        public void ShowPros()
        {

            foreach (var item in productList)
            {

                Console.WriteLine("我们超市有：" + item[0].Name+"|"+item.Count+"个");

                //Console.WriteLine("我们超市有：" + item[1].Name + item[0].Count + "个");

                //Console.WriteLine("我们超市有：" + item[2].Name + item[0].Count + "个");

                //Console.WriteLine("我们超市有：" + item[3].Name + item[0].Count + "个");

            }


        }




        /// <summary>
        /// 
        /// 进货
        /// 
        /// </summary>
        /// 
        /// <param name="type"></param>
        /// 
        /// <param name="count"></param>

        public  void JinPros(string type, int count)
        {

            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "1":

                        productList[0].Add(new Acer(Guid.NewGuid().ToString(), 3000,"宏基笔记本"));

                        break;

                    case "2":

                        productList[1].Add(new Sumngs(Guid.NewGuid().ToString(), 2200, "三星手机"));

                        break;

                    case "3":

                        productList[2].Add(new JiangYou(Guid.NewGuid().ToString(), 10, "酱油"));

                        break;

                    case "4":

                        productList[3].Add(new Banana(Guid.NewGuid().ToString(), 20, "香蕉"));

                        break;
                }
            }

        }


        /// <summary>
        /// 
        /// 取货
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="count"></param>
        /// <returns></returns>

        public ProductFather[] QuPros(string type, int count)
        {

            ProductFather[] getList = new ProductFather[count];

            for (int i = 0; i < count; i++)
            {

                switch (type)
                {
                    case "1":

                       getList[i]= productList[0][0];

                        productList[0].RemoveAt(0);

                        break;

                    case "2":

                           getList[i]= productList[1][0];

                        productList[1].RemoveAt(0);

                        break;

                    case "3":

                           getList[i]= productList[2][0];

                        productList[2].RemoveAt(0);

                        break;

                    case "4":

                           getList[i]= productList[3][0];

                        productList[3].RemoveAt(0);

                        break;
                }
                
            }

            return getList;
        }


    }
}
