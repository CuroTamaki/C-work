using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class GlobalVar
    {
        public static string 訂購人資訊 = "";
        public static string 訂購人電話 = "";
        public static int ID = 0;
        public static int 權限 = 0;
        public static List<ArrayList> list訂購開胃菜列表 = new List<ArrayList>();
        public static List<ArrayList> list訂購主餐列表 = new List<ArrayList>();
        public static List<ArrayList> list訂購排餐列表 = new List<ArrayList>();
        public static List<ArrayList> list訂購甜點列表 = new List<ArrayList>();
        public static List<ArrayList> list訂購飲料列表 = new List<ArrayList>();

        public static List<ArrayList> list訂購套餐 = new List<ArrayList>();

    }
}
