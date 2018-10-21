using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygonEditor
{
    public static class ExtensionsMethods
    {
        public static IEnumerable<T> FindAllChildrenByType<T>(this Control control)
        {
            IEnumerable<Control> controls = control.Controls.Cast<Control>();
            return controls.OfType<T>().Concat(controls.SelectMany(ctrl => FindAllChildrenByType<T>(ctrl)));
        }
    }
}
