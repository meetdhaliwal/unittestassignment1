using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rectangle_program;
using NUnit.Framework;

namespace testcase_assignment
{
    [TestFixture]
    class testcase
    {
        [Test]
        public void GetLength_input2_expectedLengthEquals2()
        {
            //Arrange
            int l = 2;
            int w = 8;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int length = testrectangle.GetLength();

            //Assert
            Assert.AreEqual(l, length);
        }

        [Test]
        public void SetLength_input6_expectedLengthEquals6()
        {
            //Arrange
            int l = 6;
            int w = 1;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int length = testrectangle.SetLength(l);

            //Assert
            Assert.AreEqual(l, length);
        }



        [Test]
        public void GetWidth_input7_expectedLengthEquals7()
        {
            //Arrange
            int l = 4;
            int w = 7;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int width = testrectangle.GetWidth();

            //Assert
            Assert.AreEqual(w, width);
        }

        [Test]
        public void SetWidth_input8_expectedLengthEquals8()
        {
            //Arrange
            int l = 9;
            int w = 8;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int width = testrectangle.SetWidth(w);

            //Assert
            Assert.AreEqual(w, width);
        }

        [Test]
        public void GetPerimeter_inputlength3andwidth3_expectedperimeterEquals12()
        {
            //Arrange
            int l = 3;
            int w = 3;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int perimeter = testrectangle.GetPerimeter();

            //Assert
            Assert.AreEqual((2*l)+(2*w));
        }

        [Test]
        public void GetArea_inputlength9andwidth4_expectedperimeterEquals36()
        {
            //Arrange
            int l = 9;
            int w = 4;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int area = testrectangle.GetArea();

            //Assert
            Assert.AreEqual(l * w);
        }

    }
}
