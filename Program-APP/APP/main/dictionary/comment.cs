namespace dictionary
{
    public class comment
    {
        private long c_id;
        private string text;
        private long u_id;
        private string time;
        private string name;
        public comment(long c_id,string t,long u_id,string time,string name)
        {
            this.c_id = c_id;
            text = t;
            this.u_id = u_id;
            this.time = time;
            this.name = name;
        }
        public comment(string t, long u_id, string time, string name)
        {
            text = t;
            this.u_id = u_id;
            this.time = time;
            this.name = name;
        }
        public long getC_id()
        {
            return c_id;
        }
        public string getText()
        {
            return text;
        }
        public long getU_id()
        {
            return u_id;
        }
        public string getTime()
        {
            return time;
        }
        public string getName()
        {
            return name;
        }
        public void setC_id(long c_id)
        {
            this.c_id=c_id;
        }
        public void setText(string text)
        {
            this.text = text;
        }
        public void setU_id(long u_id)
        {
            this.u_id = u_id;
        }
        public void setTime(string time)
        {
            this.time = time;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string tostring()
        {
            return "cid：" + c_id + " text：" + text + " uid：" + " time：" + time+" name:"+name;
        }
    }
}
