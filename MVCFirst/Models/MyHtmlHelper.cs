using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc
{

    /// <summary>
    /// 
    /// 扩展方法三要素
    /// 
    /// 
    /// 1.静态类
    /// 
    /// 2.静态的方法
    /// 
    /// 3.this关键字
    /// 
    /// 
    /// </summary>
    ///  扩展HtmlHelper方法
    /// 扩展方法三个要素：静态类，静态方法，this关键字
    /// </summary>
    public static class MyHtmlHelperExt
    {
        public static string MyLabel(this HtmlHelper helper, string txt)
        {
            return string.Format("<span>{0}</span>", txt);
        }

        public static HtmlString MyHtmlStringLabel(this HtmlHelper helper, string txt)
        {
            return new HtmlString(string.Format("<span>{0}</span>", txt));
        }
    }
}