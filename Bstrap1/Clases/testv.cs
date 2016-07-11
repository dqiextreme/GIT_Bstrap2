using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Transactions;
using Bstrap2.Models;

using System.Web.Mvc;

namespace Bstrap2.Clases
{
public class testv
{
    public int user { get; set; }
    public int view1 { get; set; }
    public string layout { get; set; }
        
    public testv()
    {
            
    }
         
         public static List<Models.test_view2> res1 = new List<test_view2>();
         public static List<Models.test_view1> res2 = new List<test_view1>();
         public static mine_cms_1Entities tent = new mine_cms_1Entities();



         public static void test()
         {
         }


         public static IList<Models.test_view2> all2()
         {
             var test_v_en = new mine_cms_1Entities();

             res1 = test_v_en.test_view2.ToList();
             return res1;
         }

         public static IList<Models.test_view1> all3()
         {
             //var test_v_en = new mine_cms_1Entities();

             //res2 = test_v_en.test_view2.ToList();
             res2 = tent.test_view1.Where(x => x.viewN == 2).ToList();
             return res2;
         }



    }
}

