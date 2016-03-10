using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlMarkupBuilderLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlMarkupBuilderLibrary.Tests {
    [TestClass()]
    public class XmlMarkupBuilderTests {
        [TestMethod()]
        public void openTagTest() {
            //Arrange
            var builder = new XmlMarkupBuilder();

            //Act
            string tag = "alabala";
            builder.openTag(tag);

            //Assert
            Assert.IsTrue(tag == builder.Tag);
        }
        [TestMethod(), ExpectedException(typeof(NullReferenceException))]
        public void openTagNullTest() {
            //Arrange
            var builder = new XmlMarkupBuilder();

            //Act
            string tag = "alabala";
            builder.openTag(tag);

            //Assert
            Assert.IsTrue(tag == builder.Tag);
        }
    }
}