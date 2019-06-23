using System;
using System.Collections.Generic;
using System.Data;
using dao;
using dictionary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using version;

namespace DAOTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataSet ds = DAO.Qurry("select * from dictionary4");
            DataTable dbl = ds.Tables[0];
            DataRow dr = dbl.Rows[0];
            /*foreach(DataRow dr in dbl.Rows)
            {
                foreach(DataColumn dc in dbl.Columns)
                {
                    Console.WriteLine(dr[dc].ToString());
                }
            }*/
            foreach (DataColumn dc in dbl.Columns)
            {
                Console.WriteLine(dr[dc].ToString());
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            IDicDao idicDao = new DicDao();
            Dictionary dic = idicDao.get(1);
            dic.tostring();
        }
        [TestMethod]
        public void TestMethod3()
        {
            IDicDao idicDao = new DicDao();
            List<Dictionary> ls = idicDao.listAll(1);
            foreach(Dictionary dic in ls)
            {
                dic.tostring();
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            IDicDao idicDao = new DicDao();
            List<Dictionary> ls = idicDao.foundByChinese("1");
            if (ls.Count!=0)
            {
                foreach (Dictionary dic in ls)
                {
                    dic.tostring();
                }
            }
            else
            {
                Console.WriteLine("查询不到");
            }
        }
        [TestMethod]
        public void TestMethod5()
        {
            IDicDao idicDao = new DicDao();
            List<Dictionary> ls = idicDao.foundByEnglish("1");
            if (ls.Count != 0)
            {
                foreach (Dictionary dic in ls)
                {
                    dic.tostring();
                }
            }
            else
            {
                Console.WriteLine("查询不到");
            }
        }
        [TestMethod]
        public void TestMethod6()
        {
            int n = DAO.ExeSql("insert into users (name,username,password,last_word4,last_word6) values('xxx','333','123',1,1)");
        }
        [TestMethod]
        public void TestMethod7()
        {
            IDicDao idicDao = new DicDao();
            List<comment> ls = idicDao.getComment();
            foreach(comment com in ls)
            {
                Console.WriteLine(com.tostring());
            }
        }
        public static void Main(string[] args)
        {

        }
    }
    
}
