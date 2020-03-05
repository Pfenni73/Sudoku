using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace UnitTestProjectSudoku
{
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void TestSetPropertyFirstTime()
        {
            Field field = new Field(1);
            field.FieldValue = 5;
            Assert.AreEqual(5, field.FieldValue);
        }

        [TestMethod]
        public void TestSetPropertySecondTime()
        {
            Field field = new Field(1);
            field.FieldValue = 5;
            field.FieldValue = 6;
            Assert.AreNotEqual(6, field.FieldValue);
        }

        [TestMethod]
        public void TestGetPropertyWithoutSet()
        {
            Field field = new Field(1);
            Assert.IsNull(field.FieldValue);
        }

        [TestMethod]
        public void TestRemovePossibleNumbers()
        {
            Field field = new Field(1);
            field.RemovePossibleValue(2);
            field.RemovePossibleValue(4);
            field.RemovePossibleValue(6);
            field.RemovePossibleValue(8);
            field.RemovePossibleValue(1);
            field.RemovePossibleValue(3);
            field.RemovePossibleValue(5);
            field.RemovePossibleValue(7);
            Assert.AreEqual(9, field.FieldValue);
        }

        [TestMethod]
        public void TestRemoveNotAllPossibleNumbers()
        {
            Field field = new Field(1);
            field.RemovePossibleValue(2);
            field.RemovePossibleValue(4);
            field.RemovePossibleValue(6);
            field.RemovePossibleValue(8);
            field.RemovePossibleValue(1);
            field.RemovePossibleValue(3);
            field.RemovePossibleValue(5);
            Assert.IsNull(field.FieldValue);
        }

        [TestMethod]
        public void TestCallback()
        {
            bool calledback = false;
            bool calledBack1 = false;
            int valueSet = 0;
            int valueSet1 = 0;
            Field field = new Field(1);
            field.ValueFoundCallback = (valueFound) => { calledback = true; valueSet = valueFound; };
            field.ValueFoundCallback += (valueFound) => { calledBack1 = true;  valueSet1 = valueFound; };
            field.RemovePossibleValue(2);
            field.RemovePossibleValue(4);
            field.RemovePossibleValue(6);
            field.RemovePossibleValue(8);
            field.RemovePossibleValue(1);
            field.RemovePossibleValue(3);
            field.RemovePossibleValue(5);
            field.RemovePossibleValue(7);
            Assert.AreEqual(true, calledback);
            Assert.AreEqual(9, valueSet);
            Assert.AreEqual(true, calledBack1);
            Assert.AreEqual(9, valueSet1);
        }

        [TestMethod]
        public void TestFieldCount()
        {
            Field field = new Field(1);
            field.RemovePossibleValue(2);
            field.RemovePossibleValue(4);
            Assert.AreEqual(7, field.CountPossibleValues());
        }
    }
}
