using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sudoku.SolverLogic
{
    public class SolverLogicContainerCompare : ISolverLogic
    {
        private List<FieldContainer> fieldContainers;
        public void SetContainers(List<FieldContainer> fieldContainers)
        {
            this.fieldContainers = fieldContainers;
        }

        public void Solve()
        {
            int iterationCounter = 0;
            int numberOfEmptyFields = 0;
            do
            {
                // Hidden Single Rule
                numberOfEmptyFields = NumberOfEmptyFields();
                for (int num = 1; num < 10; num++)
                {
                    foreach (FieldContainer fc in fieldContainers)
                    {
                        int possibilityCounter = 0;
                        Field tmpField = null;
                        foreach (Field field in fc.GetFields())
                        {
                            if (field.IsValuePossible(num))
                            {
                                possibilityCounter++;
                                tmpField = field;
                            }
                        }
                        if (possibilityCounter == 1)
                        {
                            tmpField.FieldValue = num;
                        }
                    }
                }
                iterationCounter++;
            } while (NumberOfEmptyFields() < numberOfEmptyFields);
            if(NumberOfEmptyFields() == 0)
            {
                MessageBox.Show($"gelöst in {iterationCounter} Iterationen.");
            }
            else
            {
                // Naked Subset
                SolveNakedSubset();
                SolveHiddenPair();
            }
        }

        private void SolveNakedSubset()
        {
            foreach (FieldContainer fieldContainer in fieldContainers)
            {
                for(int i = 2; i < 9; i++)
                {
                    var fieldTuple = fieldContainer.GetFields().Where(field => field.CountPossibleValues() == i);
                    


                    if(fieldTuple.Count() >= i)
                    {
                        Dictionary<string, List<Field>> fieldGrouping = new Dictionary<string, List<Field>>();
                        List<Field> fieldsWithEqualPossible = null;
                        foreach (Field field in fieldTuple)
                        {
                            if (fieldGrouping.TryGetValue(field.PossibleValuesToString(), out fieldsWithEqualPossible))
                            {
                                fieldsWithEqualPossible.Add(field);
                            }
                            else
                            {
                                List<Field> newFieldGroup = new List<Field>();
                                newFieldGroup.Add(field);
                                fieldGrouping.Add(field.PossibleValuesToString(), newFieldGroup);
                            }
                        }
                        // mit Linq aus fieldGrouping diejenigen selektieren, welche i Einträge haben
                        var searchResult = fieldGrouping.Values.Where(group => group.Count == i);
                        if(searchResult.Count() > 0)
                        {
                            HashSet<Field> containerFieldsHS = new System.Collections.Generic.HashSet<Field>(fieldContainer.GetFields());
                            containerFieldsHS.ExceptWith(searchResult.First());
                            foreach (Field field in containerFieldsHS)
                            {
                                field.RemovePossibleValues(searchResult.First().First().GetPossibleValues());
                            }
                        }
                    }

                }
            }
        }

        private void SolveHiddenPair()
        {
            foreach (FieldContainer fieldContainer in fieldContainers)
            {
                List<Field>[] possibleValueOccurence = new List<Field>[9];
                for (int i = 1; i <= 9; i++)
                {
                    possibleValueOccurence[i-1] = fieldContainer.GetFields().Where(field => field.IsValuePossible(i)).ToList();
                }
                var listsWith2Fields = possibleValueOccurence.Where(list => list.Count == 2);
                if(listsWith2Fields.Count() < 2) { continue; }
                if (listsWith2Fields.Count() == 2)
                {
                    // prüfen ob die Listen die selben Felder enthalten
                    HashSet<Field> fieldHS1 = new System.Collections.Generic.HashSet<Field>(listsWith2Fields.First());
                    if (fieldHS1.Equals(listsWith2Fields.Last()))
                    {
                        // aus den möglichen Werten dieser beiden Felder alle Zahlen extrahieren, die auch in anderen Feldern vorkommen
                        // das Resultat sind die beiden Zahlen
                        MessageBox.Show("HiddenPair gefunden");
                    }
                    else
                    {
                        //MessageBox.Show($@"{(Field)(listsWith2Fields.First()).PossibleValuesToString()}");
                        MessageBox.Show("Die Listen enthalten unterschiedliche Felder");
                    }
                }
                else
                {
                    MessageBox.Show("Mehr als 2 Zahlen gefunden, die nur in 2 Feldern sein können.");
                    //string output = string.Empty;
                    //foreach (List<Field> list in listsWith2Fields)
                    //{
                    //    foreach(Field field in list)
                    //    {
                    //        output += $"Nr.{field.FieldNumber} {field.PossibleValuesToString()}\n";
                    //    }
                    //}
                    //MessageBox.Show(output);
                }
            }
            
        }

        private bool AreAllValuesFound()
        {
            foreach (FieldContainer fc in fieldContainers)
            {
                foreach (Field field in fc.GetFields())
                {
                    if (!field.FieldValue.HasValue)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private int NumberOfEmptyFields()
        {
            var numberOfEmptyFields = GetAllFields().Count(n => !n.FieldValue.HasValue);

            return numberOfEmptyFields;
        }

        private HashSet<Field> GetAllFields()
        {
            HashSet<Field> fieldsSet = new HashSet<Field>();
            foreach (FieldContainer fc in fieldContainers)
            {
                foreach (Field field in fc.GetFields())
                {
                        fieldsSet.Add(field);
                }
            }
            return fieldsSet;
        }
    }
}
