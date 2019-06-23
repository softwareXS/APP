using System;
using System.Collections.Generic;
using System.Data;
using dao;


namespace dictionary
{
    public class DicDao : IDicDao
    {
        public List<Dictionary> foundByChinese(string str)
        {
            List<Dictionary> ls = new List<Dictionary>();
            Dictionary dic = new Dictionary();
            DataSet ds = DAO.Qurry("select * from dictionary4 where means Like" + "'%" + str + "%'");
                DataTable dbl = ds.Tables[0];
                foreach (DataRow dr in dbl.Rows)
                {
                    ls.Add(new Dictionary(long.Parse(dr["w_id"].ToString()), dr["word"].ToString(), dr["means"].ToString(), dr["pro"].ToString()));
                }
                return ls;
        }

        public List<Dictionary> foundByEnglish(string str)
        {
            List<Dictionary> ls = new List<Dictionary>();
            Dictionary dic = new Dictionary();
            DataSet ds = DAO.Qurry("select * from dictionary4 where word Like" + "'%" + str + "%'");
            DataTable dbl = ds.Tables[0];
            foreach (DataRow dr in dbl.Rows)
            {
                ls.Add(new Dictionary(long.Parse(dr["w_id"].ToString()), dr["word"].ToString(), dr["means"].ToString(), dr["pro"].ToString()));
            }
            return ls;
        }

        public Dictionary get(long id)
        {
            Dictionary dic = new Dictionary();
            try
            {
                DataSet ds = DAO.Qurry("select * from dictionary4 where w_id = " + id);
                DataTable dbl = ds.Tables[0];
                DataRow dr = dbl.Rows[0];
                dic.setW_id(long.Parse(dr["w_id"].ToString()));
                dic.setWord(dr["word"].ToString());
                dic.setMeans(dr["means"].ToString());
                dic.setPro(dr["pro"].ToString());
            }
            catch
            {

            }
            return dic;
        }

        public List<comment> getComment()
        {
            List<comment> ls = new List<comment>();
            DataSet ds = DAO.Qurry("select * from comment order by c_id desc");
            DataTable dbl = ds.Tables[0];
            foreach (DataRow dr in dbl.Rows)
            {
                ls.Add(new comment(long.Parse(dr["c_id"].ToString()), dr["text"].ToString(), long.Parse(dr["u_id"].ToString()), dr["time"].ToString(), dr["name"].ToString()));
            }
            return ls;
        }

        public List<Dictionary> listAll(long id)
        {
            List<Dictionary> ls = new List<Dictionary>();
            DataSet ds = DAO.Qurry("select * from new_word where u_id="+id);
            DataTable dbl = ds.Tables[0];
            foreach(DataRow dr in dbl.Rows)
            {
                ls.Add(new Dictionary(long.Parse(dr["n_id"].ToString()), dr["n_word"].ToString(), dr["n_mean"].ToString(), dr["n_pro"].ToString()));
            }
            return ls;
        }

        public int saveComment(comment comment)
        {
            //string ss = "insert into new_word (n_word,n_mean,n_pro,u_id) values('" + dictionary.getWord() + "','" + dictionary.getMeans() + "','" + dictionary.getPro() + "'," + user.getU_id() + ")";
            string s = "insert into comment (text,u_id,time,name) values('" + comment.getText() + "', " + comment.getU_id() + ", '" + comment.getTime() + "','" + comment.getName() + "')";
            int n = DAO.ExeSql(s);
            return n;
        }
    }
}
