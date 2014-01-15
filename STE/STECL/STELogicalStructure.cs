using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STECL
{
    interface ISTETest { }
    interface ISTEAnswerValue { }

    public class STESimpleTest:ISTETest 
    {
        private int id;
        public List<STETaskBlock> TaskBlock;
        public STETestNote Note;
        
        public int Id 
        {
            get { return id; }
            set { id = value ; } 
        }

        public STESimpleTest()
        {
            TaskBlock = new List<STETaskBlock>();
            Note = new STETestNote();
        }
    }


    public class STETestNote 
    {
        public string TestNote;
    }

    public class STETaskBlock 
    {
        private int id;
        public List<STETask> Task;
       
        public int Id 
        {
            get { return id; }
            set { id = value; } 
        }

        public STETaskBlock()
        {
            Task = new List<STETask>();
        }
    }

    public class STETask 
    {
        private int id;
        public STEQuestion Question;
        public List<STEAnswer> Answer;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public STETask()
        {
            Answer =  new List<STEAnswer>();
        }
    }

    public class STEQuestion 
    {
        string questionText;

        public string QuestionText
        {
            get { return questionText; }
            set { questionText = value; }
        }
    }

//Вопрос пока не очень понимаю как что там работает. Позже подробнее его сделаю
    public class STEAnswer  
    {
        private int id;
        public int Id { get; set; }
       // public ISTEAnswerValue GetUserAnswer();
    }

#region STEAnswer region
    public class STEAnswerOption 
    {
        private int id;
        public int Id { get; set; }
    
    }
    public class STEAnswerSingleChoice : STEAnswer { }
    public class STEAnswerMultipleChoice : STEAnswer { }
    public class STEAnswerMatching : STEAnswer { }
    public class STEAnswerOpenText : STEAnswer { }
#endregion
#region STEAnswerValue region
    public class STEAnswerValueSingleChoice : ISTEAnswerValue { }
    public class STEAnswerValueMultipleChoice : ISTEAnswerValue { }
    public class STEAnswerValueMatching : ISTEAnswerValue { }
    public class STEAnswerValueOpenText : ISTEAnswerValue { }
#endregion
}
