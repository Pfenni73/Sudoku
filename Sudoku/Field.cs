using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Field
    {
        private int? fieldValue;
        private Collection<int> possibleValues;
        public delegate void ValueFoundEvent(int valueFound);
        public ValueFoundEvent ValueFoundCallback;

        public Field(int fieldNumber)
        {
            FieldNumber = fieldNumber;
            possibleValues = new Collection<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        public int FieldNumber { get; private set; }
        public int? FieldValue
        {
            get { return fieldValue; }
            set
            {
                if(!fieldValue.HasValue)
                { 
                    fieldValue = value;
                    possibleValues.Clear();
                    if (ValueFoundCallback != null)
                    {
                        ValueFoundCallback((int)fieldValue);
                    }
                }
            }
        }

        public void RemovePossibleValue(int noLongerPossible)
        {
            possibleValues.Remove(noLongerPossible);
            if(possibleValues.Count == 1)
            {
                FieldValue = possibleValues.First();
            }
        }

        public bool IsValuePossible(int value)
        {
            return possibleValues.Contains(value);
        }

        public int CountPossibleValues()
        {
            return possibleValues.Count;
        }

        internal string PossibleValuesToString()
        {
            return string.Join(", ", possibleValues);
        }

        public int[] GetPossibleValues()
        {
            return possibleValues.ToArray();
        }

        public void RemovePossibleValues(int[] noLongerPossible)
        {
            if(possibleValues.Count == 0)
            {
                return;
            }
            foreach(int i in noLongerPossible)
            {
                RemovePossibleValue(i);
            }
        }
    }
}
