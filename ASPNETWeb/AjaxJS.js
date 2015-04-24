function GetAjaxData(Method,URL,username,password,onsucess,onfailed)
{

    //创建XMLHTTPRequest 考虑到兼容性

    var xmlhttprequest = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject("Microsoft.XMLHTTP");

    xmlhttprequest.open(Method, URL, true);

    xmlhttprequest.onreadystatechange = function ()
    {
        if (xmlhttprequest.readyState == 4)
        {

            if (xmlhttprequest.status == 200) {
                onsucess(xmlhttprequest.responseText);
            } else {onfailed("数据传输错误啊！") }

            //readyState==4 表示数据传输完成

            //readyState==2 表示数据正在处理中

            //readyState==3 表示数据传输了部分内容，但是还没有完成
        }      


    }

    //var data = new { UserName: 'zhangsan', password: '1234' };

    xmlhttprequest.send();


}



function GetInfo() {
    var xmlhttp = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject('Microsoft.XMLHTTP'); //创建XMLHTTP对象，考虑兼容性
    xmlhttp.open("Post", "Ajax.ashx?action=zan", true); //“准备”向服务器的GetDate1.ashx发出Post请求（GET可能会有缓存问题）。这里还没有发出请求
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4) //readyState == 4 表示服务器返回完成数据了。之前可能会经历2（请求已发送，正在处理中）、3（响应中已有部分数据可用了，但是服务器还没有完成响应的生成）
        {
            if (xmlhttp.status == 200) //如果状态码为200则是成功
            {
                document.getElementById("pinfo").innerHTML = xmlhttp.responseText;
            }
            else {
                alert("AJAX服务器返回错误！");
            }
        }
    }
    //不要以为if (xmlhttp.readyState == 4) {在send之前执行！！！！
    xmlhttp.send(); //这时才开始发送请求
    //发出请求后不等服务器返回数据，就继续向下执行，所以不会阻塞，界面就不卡了，这就是AJAX中“A”的含义“异步”。试着在ashx加一句Thread.Sleep(3000);


}


function ajax(url, onsuccess, onfail) {
    var xmlhttp = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject('Microsoft.XMLHTTP');
    xmlhttp.open("POST", url, true);
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4) {
            if (xmlhttp.status == 200) {
                onsuccess(xmlhttp.responseText);

              

            }
            else {
                onfail(xmlhttp.status);
            }
        }
    }
    xmlhttp.send(); //这时才开始发送请求
}

