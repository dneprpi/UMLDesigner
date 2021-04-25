﻿using System.Drawing;
using System.Drawing.Drawing2D;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner.Figures.Arrows
{
    public class AgregationArrow : AbstractArrow
    {
        public AgregationArrow()
        {
            FigurePen = new Pen(_painter.PainterPen.Color, _painter.PainterPen.Width);

            GraphicsPath hPath = new GraphicsPath();
            Point[] filledRhombus = new Point[] { new Point(0, -8),
                                                    new Point(2, -4),
                                                    new Point(0, 1),
                                                    new Point(-2, -4)
                                                  };

            hPath.AddPolygon(filledRhombus);
            FigurePen.CustomEndCap = new CustomLineCap(hPath, null);
            Type = "AgregationArrow";
        }
    }
}
