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
        public int Id { get; set; }
        List<STETaskBlock> TaskBlock = new List<STETaskBlock>();
    }

    public class STETestNote { }

    public class STETaskBlock 
    {
        private int id;
        public int Id { get; set; }
        List<STETask> Task = new List<STETask>();
    }

    public class STETask 
    {
        private int id;
        public int Id { get; set; }
        public STEQuestion Question;
        List<STEAnswer> Task = new List<STEAnswer>();
    }

    public class STEQuestion { }

    public class STEAnswer  
    {
        private int id;
        public int Id { get; set; }
        public ISTEAnswerValue GetUserAnswer();
    }
#region STEAnswer region
    public class STEAnswerOption { }
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
