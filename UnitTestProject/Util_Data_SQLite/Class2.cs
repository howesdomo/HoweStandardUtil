using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace View.BuBuGao
{
    public class Question
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }
        
        [Ignore]
        public List<Word> Words { get; set; }
    }

    public class Word
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Content { get; set; }

        [Indexed]
        public int QuestionID { get; set; }
    }
}
