﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Text;

namespace Fonet.Fo.Properties
{
    internal class PaddingTopMaker : GenericPadding
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new PaddingTopMaker(propName);
        }

        protected PaddingTopMaker(string name) : base(name) { }


        public override Property Compute(PropertyList propertyList)
        {
            FObj parentFO = propertyList.getParentFObj();
            StringBuilder sbExpr = new StringBuilder();
            Property p = null;
            sbExpr.Append("padding-");
            sbExpr.Append(propertyList.wmAbsToRel(PropertyList.TOP));

            p = propertyList.GetExplicitOrShorthandProperty(sbExpr.ToString());

            if (p != null)
            {
                p = ConvertProperty(p, propertyList, parentFO);
            }

            return p;
        }

    }
}