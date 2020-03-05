using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Tests
{
    [TestClass()]
    public class FieldContainerTests
    {
        [TestMethod()]
        public void FieldContainerTest()
        {
            int testValue = 5;
            Field field1 = new Field(1);
            Field field2 = new Field(2);
            Field field3 = new Field(3);
            Field field4 = new Field(4);
            Field field5 = new Field(5);
            Field field6 = new Field(6);
            Field field7 = new Field(7);
            Field field8 = new Field(8);
            Field field9 = new Field(9);
            FieldContainer row1 = new FieldContainer(field1, field2, field3, field4, field5, field6, field7, field8, field9);
            Field field12 = new Field(12);
            Field field13 = new Field(13);
            Field field14 = new Field(14);
            Field field15 = new Field(15);
            Field field16 = new Field(16);
            Field field17 = new Field(17);
            Field field18 = new Field(18);
            Field field19 = new Field(19);
            FieldContainer column1 = new FieldContainer(field1, field12, field13, field14, field15, field16, field17, field18, field19);
            field1.FieldValue = testValue;
            Assert.IsFalse(field14.IsValuePossible(testValue));
        }
    }
}