using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Boxes
{
    class Answer
    {
        public List<string> list { get; set; }
        foreach(var figure in Enum.GetValues(typeof(CardFigure)))
        {
            comboBox1.Items.Add(((CardFigure)figure).ToString());
        }
    }
}

