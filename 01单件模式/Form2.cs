using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01单件模式
{
    public partial class Form2 : Form
    {

        /// <summary>
        /// 
        /// 全局唯一的Form2
        /// 
        /// </summary>

        public static Form2 frmsingle=null;


        /// <summary>
        /// 
        /// 私有构造函数
        /// 
        /// </summary>

        private Form2()
        {
            InitializeComponent();
        }




        /// <summary>
        /// 
        /// 创建实例（唯一实例）
        /// 
        /// </summary>
        /// <returns></returns>

        public static Form2 GetSingle()
        {

            if (frmsingle==null)
            {
                frmsingle = new Form2();
            }
            
            return frmsingle;
        }

    }
}
