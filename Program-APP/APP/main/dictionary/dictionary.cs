using System;

namespace dictionary
{
    public class Dictionary
    {
        private  long w_id;
        private string word;
        private string means;
        private string pro;
        
        public Dictionary()
        {

        }
        public Dictionary(long id,string word,string means,string pro)
        {
            w_id = id;
            this.word = word;
            this.means = means;
            this.pro = pro;
        }
        public void setW_id(long id)
        {
            w_id = id;
        }
        public void setWord(string word)
        {
            this.word = word;
        }
        public void setMeans(string means)
        {
            this.means = means;
        }
        public void setPro(string pro)
        {
            this.pro = pro;
        }
        public long getW_id()
        {
            return w_id;
        }
        public string getWord()
        {
            return word;
        }
        public string getMeans()
        {
            return means;
        }
        public string getPro()
        {
            return pro;
        }
        public void tostring()
        {
            Console.WriteLine(" w_id: " + w_id + " word: " + word + " means: " + means + " pro: " + pro );
        }
    }
}
