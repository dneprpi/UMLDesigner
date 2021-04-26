﻿using UMLDesigner.Figures.Arrows;

namespace UMLDesigner.Figures.Factories
{
    public class CompositionArrowFactory : IFigureFactory
    {
        public IFigure GetFigure()
        {
            return new CompositionArrow();
        }
    }
}