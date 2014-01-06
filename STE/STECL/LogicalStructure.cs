using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STECL
{
    interface ISTETest { }
    interface ISTEAnswerValue { }

    public class STESimpleTest:ISTETest {}

    public class STETestNote { }

    public class STETaskBlock { }

    public class STETask { }

    public class STEQuestion { }

    public class STEAnswer : ISTEAnswerValue { }
#region STEAnswer region
    public class STEAnswerOption { }
    public class STEAnswerSingleChoice : STEAnswer { }
    public class STEAnswerMultipleChoice : STEAnswer { }
    public class STEAnswerMatching : STEAnswer { }
    public class STEAnswerOpenText : STEAnswer { }
#endregion
#region STEAnswerValue region
    public class STEAnswerValueSingleChoice : ISTEAnswerValue { }
#endregion
}
