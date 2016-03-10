using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlMarkupBuilderLibrary
{
    public class XmlMarkupBuilder
    {
        public string Tag { get; set; }

        public XmlMarkupBuilder openTag(String tagName) {
            if (tagName != null) {
                Tag = tagName;
                return this;
            } else {
                throw new NotFiniteNumberException("Tag cannot be null");
            }
            
        }
        //XmlMarkupBuilder addAttr(String attrName, String attrValue); // valid only when you have a tag opened!
        //XmlMarkupBuilder addText(String text);
        //XmlMarkupBuilder closeTag(); //close the last opened tag.
        //XmlMarkupBuilder finish(); //close all tags and finelize your object. Any open,addAttr or other calls to your object, should throw an Exception.
        //String getResult(); //let's stay close to http://en.wikipedia.org/wiki/Builder_pattern 
    }
}
