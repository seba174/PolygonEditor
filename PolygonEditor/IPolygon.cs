﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonEditor
{
    public interface IPolygon
    {
        IEnumerable<IClickable> GetClickableElements();
        bool HandleClickableMove(IClickable vertice, Point newPosition);
        bool HandlePolygonMove(Point offset);
    }
}
