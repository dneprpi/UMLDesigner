﻿using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDesigner.Figures.Arrows
{
    public class InharitanceArrow : AbstractArrow
    {
        public InharitanceArrow()
        {
            PenWidth = (int)_painter.PainterPen.Width;
            PenColor = _painter.PainterPen.Color;
            FigurePen = new Pen(PenColor, PenWidth);

            GraphicsPath hPath = new GraphicsPath();
            Point[] emptyTriangle = new Point[] { new Point(-6, -12),
                                                    new Point(6, -12),
                                                    new Point(0, 0),
                                                  };

            hPath.AddPolygon(emptyTriangle);
            FigurePen.CustomEndCap = new CustomLineCap(null, hPath);

            figureType = SinglePainter.Painter.FigureType.InharitanceArrow;
        }
    }
}
