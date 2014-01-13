using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STECL
{
#region Base Part (interface, base abstract classes)
    interface ISTEElementContainer { }
    public abstract class STEPresentationElement { }
    public abstract class STEContentElement { }
#endregion
#region STEContentElement & ISTTEElementContainer Part
    public class STEFormattedText : STEContentElement { }
    public abstract class STEImage : STEContentElement { }
#region STEImage Part
    public class STESimpleImage : STEImage { }
    public class STESlideshow : STEImage { }
    public class STEInteractiveImage : STEImage { }
#endregion
    public abstract class STEMedia : STEContentElement { }
#region STEMedia part
    public class STEVideo : STEMedia { }
    public class STEAudio : STEMedia { }
#endregion
    public class STEContentBlock : STEContentElement,ISTEElementContainer { }
    public class STESpoiler : STEContentBlock { }
    public class STETable : STEContentElement,ISTEElementContainer { }
    public class STETableCell : ISTEElementContainer { }
    public class STEPage : ISTEElementContainer { }
#endregion 
#region STEPresentationElement part
    public abstract class STEInputElement { }
    public abstract class STEActionElement { }
    public class STEActionButton : STEActionElement { }
#region STEInputElement part
    public class STEInputCheckBoxBlock : STEInputElement { }
    public class STEInputRadioButtonBlock : STEInputElement { }
    public class STEInputMatching : STEInputElement { }
    public class STEInputListBox : STEInputElement { }
    public class STEInputEditBox : STEInputElement { }

    public class STECheckBox { }
    public class STERadioButton { }
    public class STEMatchingSpot { }
#endregion
#region DraggableDecorator
#endregion
#endregion

}
