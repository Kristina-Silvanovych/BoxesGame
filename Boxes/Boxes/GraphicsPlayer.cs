using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxes
{
    class GraphicsPlayer:Player
    {

        public GraphicsPlayer(string name, CardSet cardSet, Label labelName):base(name, cardSet)
        {
            LabelName = labelName;
            labelName.Text = name;
        }

        public Label LabelName { get; }
        public override int Point
        {
            get
            {
                return base.Point;
            }
            set
            {
                base.Point = value;
                LabelName.Text = $"{Name}: {base.Point}";                
            }
        }
    }
}
