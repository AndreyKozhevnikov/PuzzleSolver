using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver.Classes {
    [TestFixture]
    public class SolverTests {
        [Test]
        public void TestCalculateEnumPositionTrue() {
            //arrange
            var s = new Solver();
            Colors[] enumData = new Colors[] { Colors.Blue, Colors.Green, Colors.Red, Colors.Yellow };
            //act
            var res = s.CalculateEnumPosition(enumData);
            //assert
            Assert.AreEqual(true, res);

        }
        [Test]
        public void TestCalculateEnumPositionTrue1() {
            //arrange
            var s = new Solver();
            Colors[] enumData = new Colors[] { Colors.Red, Colors.Green, Colors.Blue, Colors.Yellow };
            //act
            var res = s.CalculateEnumPosition(enumData);
            //assert
            Assert.AreEqual(true, res);

        }
        [Test]
        public void TestCalculateEnumPositionFalse() {
            //arrange
            var s = new Solver();
            Colors[] enumData = new Colors[] { Colors.Blue, Colors.Blue, Colors.Red, Colors.Yellow };
            //act
            var res = s.CalculateEnumPosition(enumData);
            //assert
            Assert.AreEqual(false, res);
        }

        [Test]
        public void TestCalculateEnumPositionException() {
            //arrange
            var s = new Solver();
            Colors[] enumData = new Colors[] { Colors.Blue, Colors.Blue, Colors.Red };
            //act

            //assert
            Assert.Throws<Exception>(delegate { s.CalculateEnumPosition(enumData); });
        }
        [Test]
        public void ConvertPositionToStringTest() {
            //arrange
            var s = new Solver();
            Colors[] enumData = new Colors[] { Colors.Blue, Colors.Blue, Colors.Red, Colors.Yellow };
            //act
            var res = s.ConvertPositionToString(enumData);
            //assert
            Assert.AreEqual("Blue,Blue,Red,Yellow", res);
        }
        [Test]
        public void ConvertPositionstoStringTest() {
            //arrange
            var s = new Solver();
            Colors[] enumData = new Colors[] { Colors.Blue, Colors.Blue, Colors.Red, Colors.Yellow };
            Colors[] enumData1 = new Colors[] { Colors.Blue, Colors.Blue, Colors.Yellow, Colors.Yellow };

            Colors[][] arr = new Colors[2][];
            arr[0] = enumData;
            arr[1] = enumData1;

            //act
            var res = s.ConvertPositionsToString(arr);
            var expected = "Blue,Blue,Red,Yellow" + Environment.NewLine + "Blue,Blue,Yellow,Yellow";
            //assert
            Assert.AreEqual(expected, res);
        }
    }
}
