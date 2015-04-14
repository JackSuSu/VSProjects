using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01SingleTon
{
    class Program
    {

        /// <summary>
        /// 
        /// 单件模式定义：
        /// 
        /// 1.要求一个类只有一个实例，并且提供一个全局的访问节点，同一时刻只能被一个线程访问
        /// 
        /// 2.单件类只有一个实例
        /// 
        /// 3.单件类 必须自身创建唯一实例
        /// 
        /// 4.单件类必须给其他对象提供唯一实例
        /// 
        /// 
        /// 使用频率：中高
        /// 
        /// 应用：同一个World文档只能被一个用户写入，不能同时被两个用户操作。
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
        }
    }
}
