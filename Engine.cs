using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELibrary
{

        #region Basis class and interface

        interface ISTEContentElement
        {
            float Left { get; set; }
            float Top { get; set; }
            float Width { get; set; }
            float Height { get; set; }
        }

        interface ISTEElementContainer
        {
            
        }
        
        abstract public class STEBaseContentElement : ISTEContentElement
        {
            private int id;
            private float left, top;
            private float width, height;
            private int zIndex;
            
            
            public float Left 
            { 
             get {return left;}
             set { if ((value >= 0) & (value <= 1)) left = value; } 
            }

            public float Top 
            {
                get { return top; }
                set { if ((value >=0 ) & (value <= 1)) top = value; } 
            }

            public float Width 
            {
                get { return width; }
                set { if (value > 0) width = value; } 
            }
            
            public float Height
            {
                get { return height; }
                set { if (value > 0) height = value; } 
            }
            public int Id 
            { 
                get {return id;}
                set { if (value >= 0) id = value; } 
            }

            public int ZIndex 
            {
                get { return zIndex; }
                set { if (value > 0) zIndex = value; } 
            }
            
        }
        #endregion
        #region Types of information in Test (e.g. Formatted Text)
        public class STEFormattedText : STEBaseContentElement
        { }
        abstract public class STEImage : STEBaseContentElement
        { }
            #region Kind of STEImage
        class STESimpleImage : STEImage
        { }
        class STESlideShow : STEImage
        { }
        class STEInteractiveImage : STEImage
        { }
            #endregion
        abstract public class STEMedia : STEBaseContentElement
        { }
            #region Kind of STEMedia
        public class STEAudio : STEMedia
        { }
        public class STEVideo : STEMedia
        { }
            #endregion
        #endregion
        #region Elements with ISTEElementContainer interface

        public class STEPage : ISTEElementContainer
        { }

        public class STETable : ISTEElementContainer
        { }

        public class STETableCell : ISTEElementContainer
        { }

        public class STEContentBlock : STEBaseContentElement, ISTEElementContainer
        { }

        public class STESpoiler : STEContentBlock
        { }

        #endregion
        #region Elements with ISTEContentElement interface
        abstract public class STEAction : ISTEContentElement
        { }

        abstract public class STEInput : ISTEContentElement
        { }

        public class STEActionButton : STEAction
        { }

            #region STEInput parts
        public class STEInputCheckBoxBlock : STEInput
        { }

        public class STECheckBox
        { }

        public class STEInputRadioButtonBlock : STEInput
        { }

        public class STERadioButton
        { }

        public class STEInputMatching : STEInput
        { }

        public class STEMatchingSpot
        { }

        interface ISTEDraggable
        { }

        public class DraggableDecorator : ISTEDraggable
        { }

        public class STEInputListBox : STEInput
        { }

        public class STEInputEditBox : STEInput
        { }

            #endregion

        #endregion
    
}
