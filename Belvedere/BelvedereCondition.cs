using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belvedere
{
    class BelvedereCondition
    {
        //Attribute
        //Conditional
        public BelvedereAttribute attribute {get;set;}
        private Delegate Test {get;set;}
        private Panel p;

        public Boolean FullFillsCondition(String path, object[] parameters = null)
        {
            object[] newParams;
            if(parameters != null){
                newParams = new object[parameters.Length+1];
                newParams[0]=path;
                parameters.CopyTo(newParams,1);
            }
            else
            {
                newParams = new object[]{path};
            }
            
            return Test.DynamicInvoke(newParams);
        }
    }

    class ConditionalFactory
    {

        /// <summary>
        /// Text Attribute predicates
        /// </summary>
        Predicate<TextAttribute,string> isPredicate = new Predicate<TextAttribute,string>(delegate(TextAttribute attrName, string textTyped) { attrName.name == textTyped});
        //is not
        //contains
        //does not contain
        Predicate<TextAttribute,string>



    }

    public class BelvedereAttribute
    {

    }
}
