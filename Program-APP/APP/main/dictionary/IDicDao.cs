using System.Collections.Generic;


namespace dictionary
{
    public interface IDicDao
    {
        Dictionary get(long id);//根据id查询某一个单词
        List<Dictionary> listAll(long id);//查询生词本所有单词
        List<Dictionary> foundByChinese(string str);
        List<Dictionary> foundByEnglish(string str);
        List<comment> getComment();
        int saveComment(comment comment);
    }
}
