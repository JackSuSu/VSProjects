using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace LINQTOClass
{
    class Program
    {

        //private static LINQTOClass.LINQDataContext ddd = new LINQDataContext();

        static void Main(string[] args)
        {

            int[] nums = { 1,2,3,4,5,6,7,8,9};

            var num = from i in nums

                      where i < 3

                      select i;

            Console.WriteLine(num.First<int>());

          


            int[] nums2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var num2 = from i in nums2

                       where i < 7

                       select new { data1 = i, data2 = i + 10 };

            Console.WriteLine(num2.ToArray()[1].data2);


            //公共属性赋值

            DataB db = new DataB() { a = 1, b = 1 };



            //序列化 和 反序列化

            MemoryStream ms = new MemoryStream();

            BinaryFormatter bf = new BinaryFormatter();

            HelloClass hc = new HelloClass();

            hc.A = 10;

            bf.Serialize(ms, hc);

            string str = System.Convert.ToBase64String(ms.ToArray());

            Console.WriteLine(str);

            try
            {

                ms.Position = 0;

                HelloClass hc2 = bf.Deserialize(ms) as HelloClass;

                Console.WriteLine(hc2.A);

            }
            catch {

                Console.Write("Bad!"); 

            }


            //LINQ GROUP 用法

            User[] users = new User[3];

            users[0] = new User(lastname: "Liu", firstname: "Andy");
            users[1] = new User(lastname: "Gao", firstname: "Shan");
            users[2] = new User(lastname: "Liu", firstname: "Patrick");

            //LINQ 按照对象Group对象进行分组 写入到usergroup 然后返回给 selectusers

            //把LastName 当成组筛选到 数组里面

            var selectusers = from u in users group u by u.LastName into usergroup  select usergroup;

            List<int> intdata = new List<int>();

            intdata.AddRange(new int[] { 1, 3, 15, 20, 55, 15, 20, 11 });

            List<int> finddata = intdata.FindAll(i => i > 15);


            Console.ReadKey();

            //LINQTOClass.TbUser tbuser = new TbUser();

           

       

            
        }

        class DataB
        {
            public int a { get; set; }

            public int b { get; set; }

            private const string constr = @"Data Source=192.168.102.244;Initial Catalog=TestDb;User ID=sa;Password=123456788";


        }




        [Serializable]
        public class HelloClass
        {

            private int a;

            public int A
            {
                get { return a; }

                set { a = value; }
            }

            public void Add()
            {
                A = A + 10;
            }


        }


        class User
        {
            private string firstName;

            private string lastName;

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }

                set { lastName = value; }
            }

            public User(string firstname,string lastname)
            {

                FirstName = firstname;

                LastName = lastname;
 
            }




        }


    }
}
