using System;

namespace version
{
    public class user
    {
        private long u_id;
        private string name;
        private long last_word4;
        private long last_word6;
        public user()
        {

        }
        public user(long id, string name, long word4, long word6)
        {
            u_id = id;
            this.name = name;
            last_word4 = word4;
            last_word6 = word6;
        }
        public long getU_id()
        {
            return u_id;
        }
        public string getName()
        {
            return name;
        }
        public long getLast_Word4()
        {
            return last_word4;
        }
        public long getLast_Word6()
        {
            return last_word6;
        }
        public void setU_id(long id)
        {
            u_id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setLast_Word4(long id)
        {
            last_word4 = id;
        }
        public void setLast_Word6(long id)
        {
            last_word6 = id;
        }
        public void last_word4Add()
        {
            last_word4++;
        }
        public void last_word4Sub()
        {
            if (u_id > 1)
            {
                last_word4--;
            }
            else
            {
                last_word4 = 1;
            }
        }
        public void last_word6Add()
        {
            last_word6++;
        }
        public void last_word6Sub()
        {
            if (u_id > 1)
            {
                last_word6--;
            }
            else
            {
                last_word6 = 1;
            }
        }
        public string tostring()
        {
            string str = " id:" + u_id + " name:" + name + "  last_word4:" + last_word4 + "  last_word6:" + last_word6;
            //Console.WriteLine(" id:" + u_id + " name:" + name + " last_word4:" + last_word4 + " last_word6" + last_word6);
            return str;
        }
    }
}
