using System;
using System.Collections.Generic;
using System.Text;

namespace _24收银台
{
    class ProductFather
    {
       

        private double myVar;

        public double Price
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        private string  _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        

        public ProductFather(string id,double price,int count,string name)
        {
            this.ID=id;

            this.Price=price;

            this.Count=count;

            this.Name = name;

        }


    }


    class Sumngs:ProductFather
    {
        public Sumngs(string id, double price, int count,string name)
            : base(id, price, count,name)
        {
 
        }
    }


    /// <summary>
    /// 
    /// 宏基
    /// 
    /// </summary>

    class Acer : ProductFather
    {
        public Acer(string id, double price, int count,string name)
            : base(id, price, count,name)
        {

        }
    }

    /// <summary>
    /// 
    /// 香蕉
    /// 
    /// </summary>

    class Banana : ProductFather
    {
        public Banana(string id, double price, int count, string name)
            : base(id, price, count, name)
        {

        }
    }


    /// <summary>
    /// 
    /// 酱油
    /// 
    /// </summary>

    class JiangYou : ProductFather
    {
        public JiangYou(string id, double price, int count,string name)
            : base(id, price, count, name)
        {

        }
    }



}
