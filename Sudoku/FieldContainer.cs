using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class FieldContainer
    {
        private Field[] fields;

        public FieldContainer(Field field1, Field field2, Field field3, Field field4, Field field5, Field field6, Field field7, Field field8, Field field9)
        {
            fields = new Field[9];
            fields[0] = field1;
            fields[1] = field2;
            fields[2] = field3;
            fields[3] = field4;
            fields[4] = field5;
            fields[5] = field6;
            fields[6] = field7;
            fields[7] = field8;
            fields[8] = field9;

            foreach(Field field in fields)
            {
                field.ValueFoundCallback += ValueFoundCallback;
            }
        }

        private void ValueFoundCallback(int valueFound)
        {
            foreach(Field field in fields)
            {
                field.RemovePossibleValue(valueFound);
            }
        }

        public Field[] GetFields()
        {
            return fields;
        }
    }
}
