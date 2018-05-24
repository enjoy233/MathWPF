﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Editor
{
    public class DivMathWithTop : DivMathWithOuterBase
    {
        public DivMathWithTop(EquationContainer parent)
            : base(parent)
        {             
        }       

        protected override void AdjustVertical()
        {
            outerEquation.Top = Top;
            insideEquation.Top = outerEquation.Bottom + VerticalGap;
            divMathSign.Top = outerEquation.Bottom + VerticalGap;
        } 
      
        public override double RefY
        {
            get
            {
                return outerEquation.Height + insideEquation.FirstRow.RefY + VerticalGap;
            }
        }
    }
}
