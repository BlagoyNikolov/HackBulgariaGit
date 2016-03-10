using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLLibrary {
    public class XmlMarkupBuilder {
        public StringBuilder builder = new StringBuilder();
        public bool isFinished { get; private set; }
        public Stack<string> tagNamee = new Stack<string>();
        public Stack<int> tagCount = new Stack<int>();
        
        public XmlMarkupBuilder openTag(String tagName) {
            if (isFinished) {
                throw new XMLHasBeenFinalizedException();
            }
     
            builder.Append(new StringBuilder().Append("<" + tagName + ">"));
            Console.WriteLine(builder.ToString());
            tagNamee.Push(tagName);
            tagCount.Push(builder.Capacity - 1);
            return this;
        }

        public XmlMarkupBuilder addAttr(String attrName, String attrValue) {
            if (builder.Length == 0)
                throw new XMLAttributeException();
            else if (isFinished)
                throw new XMLHasBeenFinalizedException();

            string attribute = " " + attrName + "=\"" + attrValue + "\"";
            builder[tagCount.Peek()].Replace(">", attribute + ">");
            return this;
        }

        //public XmlMarkupBuilder addText(String text) {

        //}

        //public XmlMarkupBuilder closeTag() {

        //}
        //public XmlMarkupBuilder finish() {

        //}

        //String getResult() {

        //}

        public class XMLHasBeenFinalizedException : Exception {
            public XMLHasBeenFinalizedException() : base("Object finalized! Exception!") { }
            public XMLHasBeenFinalizedException(string message) : base(message) { }
            public XMLHasBeenFinalizedException(string message, Exception inner) : base(message, inner) { }
            protected XMLHasBeenFinalizedException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        public class NoRootXMLObjectFound : Exception {
            public NoRootXMLObjectFound() : base("You need to have a root XML object, XML is not a list!") { }
            public NoRootXMLObjectFound(string message) : base(message) { }
            public NoRootXMLObjectFound(string message, Exception inner) : base(message, inner) { }
            protected NoRootXMLObjectFound(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        public class XMLAttributeException : Exception {
            public XMLAttributeException() : base("XML empty. Cannot add attributes.") { }
            public XMLAttributeException(string message) : base(message) { }
            public XMLAttributeException(string message, Exception inner) : base(message, inner) { }
            protected XMLAttributeException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        public class XMLAddTextException : Exception {
            public XMLAddTextException() : base("XML empty. Cannot add text.") { }
            public XMLAddTextException(string message) : base(message) { }
            public XMLAddTextException(string message, Exception inner) : base(message, inner) { }
            protected XMLAddTextException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        public class XMLNoOpenedTagException : Exception {
            public XMLNoOpenedTagException() : base("There is no opened tag") { }
            public XMLNoOpenedTagException(string message) : base(message) { }
            public XMLNoOpenedTagException(string message, Exception inner) : base(message, inner) { }
            protected XMLNoOpenedTagException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
