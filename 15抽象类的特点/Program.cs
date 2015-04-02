using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15抽象类的特点
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //使用多态求矩形的面积和周长 以及 圆形的面积和周长

            //1.找出一个父类 圆形，矩形都不行 那么只能用Shape 类（抽象类）

            //2.找出共有的方法 即：周长和面积

            //3.抽象方法 多态重载

            //4.定义实例化 显示数据


            Shape sp = new Circle(5);         

            sp = new Square(10,5);

            Console.WriteLine(sp.GetArea() + "|" + sp.GetPerimeter());

            Console.ReadKey();

        }

        public abstract class Shape
        {
            public abstract double GetArea();

            public abstract double GetPerimeter();
            
        }


        public class Circle : Shape
        {

            private double _r;

            public double R
            {
                get { return _r; }
                set { _r = value; }
            }

            public Circle(double rs)
            {
                this.R = rs;
            }


            public override double GetArea()
            {
                return Math.PI * this.R * this.R;
            }

            public override double GetPerimeter()
            {
                return Math.PI * this.R * 2;
            }
        }

        public class Square : Shape
        {

            private double height;

            public double Height
            {
                get { return height; }
                set { height = value; }
            }

            private double witdth;

            public double With
            {
                get { return witdth; }
                set { witdth = value; }
            }

            public Square(double height, double width)
            {

                this.Height = height;

                this.With = width;

            }


            public override double GetArea()
            {

                return this.Height * this.With;
             
            }

            public override double GetPerimeter()
            {

                return (this.Height + this.With) * 2;
           
            }
        }


    }
}
