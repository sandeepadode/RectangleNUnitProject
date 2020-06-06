using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Rectangle.Test
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void GetLength_InputLength3Width5_Return3()
        {
            //Arrange
            int length = 3;
            int width = 5;
            int expectedLength = 3;

            //Assert
            Rectangle rectangle = new Rectangle(length, width);
            int actualLength = rectangle.GetLength();

            //Act
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void GetWidth_InputLength3Width5_Return5()
        {
            int length = 3;
            int width = 5;
            int expectedWidth = 5;
            Rectangle rectangle = new Rectangle(length, width);
            int actualWidth = rectangle.GetWidth();
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void GetPerimeter_InputLength3Width5_Return16()
        {
            int length = 3;
            int width = 5;
            int expectedPerimeter = 16;
            Rectangle rectangle = new Rectangle(length, width);
            int actualPerimeter = rectangle.GetPerimeter();
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void GetArea_InputLength3Width5_Return15()
        {
            int length = 3;
            int width = 5;
            int expectedArea = 15;
            Rectangle rectangle = new Rectangle(length, width);
            int actualArea = rectangle.GetArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void SetLength_UpdatedLength_UpdatesLengthTo4()
        {
            int length = 3;
            int width = 5;
            int expectedLength = 4;
            Rectangle rectangle = new Rectangle(length, width);
            int actualLength = rectangle.SetLength(4);
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void SetWidth_UpdatedWidth_UpdatesWidthTo8()
        {
            int length = 3;
            int width = 5;
            int expectedWidth = 8;
            Rectangle rectangle = new Rectangle(length, width);
            int actualWidth = rectangle.SetWidth(8);
            Assert.AreEqual(expectedWidth, actualWidth);
        }


    }
}
