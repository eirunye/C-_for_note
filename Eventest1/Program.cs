using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
///  说明注册事件是最后来决定了委托的调用获取数据的结果
///  
/// </summary>
namespace Eventest1
{


    class Program
    {
        /// <summary>
        /// 定义委托
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public delegate int ShowHandler(int i);
        static ShowHandler showDir;//定义委托实例
        static event ShowHandler onEventDir;//定义事件
        static int ShowNumed(int i)
        {
            i += 5;
            Console.WriteLine("this is delefate info!");
            return i;
        }

        static int ShowOnEventDir(int i)
        {
            i += 10;
            Console.WriteLine("this is event info!");
            return i;
        }


        static void Main(string[] args)
        {
            int i = 10;

            showDir += ShowNumed;//注意：这里是注册委托，不是赋值
            showDir += ShowOnEventDir;//注册委托实例
            Console.WriteLine("输出结果：" + showDir(i).ToString());//输出结果为20，

            Console.WriteLine("#################################################################");
            ////事件注册
            onEventDir += ShowNumed; //注意：这里是注册委托，不是赋值
             onEventDir += ShowOnEventDir;
            Console.WriteLine("输出结果:" + onEventDir(i).ToString());//20
           
        }
    }
}
