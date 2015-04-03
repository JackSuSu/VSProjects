using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _20序列化与反序列化
{
    class Program
    {

        /// <summary>
        /// 
        /// 序列化就是将对象转换为二进制
        /// 
        /// 反序列换是将二进制转化为对象
        /// 
        /// 目的：传输数据，传输二进制，接受二进制，反序列化二进制
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            Person p1 = new Person();

            p1.Name = "张三";

            p1.Age = 12;

            p1.Gender='男';

            //p1对象转化成二进制

            //写到本地磁盘 然后 从本地磁盘读取

            //using (FileStream fs = new FileStream(@"C:\Users\jack\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{

            //    BinaryFormatter bf = new BinaryFormatter();

            //    bf.Serialize(fs, p1);

            //}

            //Console.WriteLine("序列化写入OK了！");


            //接受来自硬盘的序列化 二进制数据


            using (FileStream fsread = new FileStream(@"C:\Users\jack\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {

                BinaryFormatter bf = new BinaryFormatter();

                Person p2 = (Person)bf.Deserialize(fsread);

                Console.WriteLine(p2.Name + p2.Age + p2.Gender);




            }



            Console.ReadKey();

        }


        /// <summary>
        /// 
        /// 指示这个类可以被序列化
        /// 
        /// Person 头 
        /// 
        /// </summary>

        [Serializable]
        public class Person
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private int age;

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            private char gender;

            public char Gender
            {
                get { return gender; }
                set { gender = value; }
            }

            

            
        }

    }
}
