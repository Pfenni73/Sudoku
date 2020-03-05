using Sudoku.SolverLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Sudoku
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string windowTitle;
        private ICommand _clickCommandSolve;
        //private ICommand _clickCMShowPossibleValues;
        #region Fields
        private Field field1;
        private Field field2;
        private Field field3;
        private Field field4;
        private Field field5;
        private Field field6;
        private Field field7;
        private Field field8;
        private Field field9;
        private Field field10;
        private Field field11;
        private Field field12;
        private Field field13;
        private Field field14;
        private Field field15;
        private Field field16;
        private Field field17;
        private Field field18;
        private Field field19;
        private Field field20;
        private Field field21;
        private Field field22;
        private Field field23;
        private Field field24;
        private Field field25;
        private Field field26;
        private Field field27;
        private Field field28;
        private Field field29;
        private Field field30;
        private Field field31;
        private Field field32;
        private Field field33;
        private Field field34;
        private Field field35;
        private Field field36;
        private Field field37;
        private Field field38;
        private Field field39;
        private Field field40;
        private Field field41;
        private Field field42;
        private Field field43;
        private Field field44;
        private Field field45;
        private Field field46;
        private Field field47;
        private Field field48;
        private Field field49;
        private Field field50;
        private Field field51;
        private Field field52;
        private Field field53;
        private Field field54;
        private Field field55;
        private Field field56;
        private Field field57;
        private Field field58;
        private Field field59;
        private Field field60;
        private Field field61;
        private Field field62;
        private Field field63;
        private Field field64;
        private Field field65;
        private Field field66;
        private Field field67;
        private Field field68;
        private Field field69;
        private Field field70;
        private Field field71;
        private Field field72;
        private Field field73;
        private Field field74;
        private Field field75;
        private Field field76;
        private Field field77;
        private Field field78;
        private Field field79;
        private Field field80;
        private Field field81;
        #endregion
        #region FieldContainers
        private FieldContainer column1;
        private FieldContainer column2;
        private FieldContainer column3;
        private FieldContainer column4;
        private FieldContainer column5;
        private FieldContainer column6;
        private FieldContainer column7;
        private FieldContainer column8;
        private FieldContainer column9;

        private FieldContainer row1;
        private FieldContainer row2;
        private FieldContainer row3;
        private FieldContainer row4;
        private FieldContainer row5;
        private FieldContainer row6;
        private FieldContainer row7;
        private FieldContainer row8;
        private FieldContainer row9;

        private FieldContainer square1;
        private FieldContainer square2;
        private FieldContainer square3;
        private FieldContainer square4;
        private FieldContainer square5;
        private FieldContainer square6;
        private FieldContainer square7;
        private FieldContainer square8;
        private FieldContainer square9;
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;


        public MainViewModel()
        {
            WindowTitle = "Sudoku Solver";
        }

        #region FieldPorperties
        public Field Field1
        {
            get { return field1;}
            set
            {
                if(value != field1)
                {
                    field1 = value;
                    NotifyPropertyChanged("Field1");
                }
            }
        }
        public Field Field2
        {
            get { return field2; }
            set
            {
                if (value != field2)
                {
                    field2 = value;
                    NotifyPropertyChanged("Field2");
                }
            }
        }
        public Field Field3
        {
            get { return field3; }
            set
            {
                if (value != field3)
                {
                    field3 = value;
                    NotifyPropertyChanged("Field3");
                }
            }
        }
        public Field Field4
        {
            get { return field4; }
            set
            {
                if (value != field4)
                {
                    field4 = value;
                    NotifyPropertyChanged("Field4");
                }
            }
        }
        public Field Field5
        {
            get { return field5; }
            set
            {
                if (value != field5)
                {
                    field5 = value;
                    NotifyPropertyChanged("Field5");
                }
            }
        }
        public Field Field6
        {
            get { return field6; }
            set
            {
                if (value != field6)
                {
                    field6 = value;
                    NotifyPropertyChanged("Field6");
                }
            }
        }
        public Field Field7
        {
            get { return field7; }
            set
            {
                if (value != field7)
                {
                    field7 = value;
                    NotifyPropertyChanged("Field7");
                }
            }
        }
        public Field Field8
        {
            get { return field8; }
            set
            {
                if (value != field8)
                {
                    field8 = value;
                    NotifyPropertyChanged("Field8");
                }
            }
        }
        public Field Field9
        {
            get { return field9; }
            set
            {
                if (value != field9)
                {
                    field9 = value;
                    NotifyPropertyChanged("Field9");
                }
            }
        }
        public Field Field10
        {
            get { return field10; }
            set
            {
                if (value != field10)
                {
                    field10 = value;
                    NotifyPropertyChanged("Field10");
                }
            }
        }
        public Field Field11
        {
            get { return field11; }
            set
            {
                if (value != field11)
                {
                    field11 = value;
                    NotifyPropertyChanged("Field11");
                }
            }
        }
        public Field Field12
        {
            get { return field12; }
            set
            {
                if (value != field12)
                {
                    field12 = value;
                    NotifyPropertyChanged("Field12");
                }
            }
        }
        public Field Field13
        {
            get { return field13; }
            set
            {
                if (value != field13)
                {
                    field13 = value;
                    NotifyPropertyChanged("Field13");
                }
            }
        }
        public Field Field14
        {
            get { return field14; }
            set
            {
                if (value != field14)
                {
                    field14 = value;
                    NotifyPropertyChanged("Field14");
                }
            }
        }
        public Field Field15
        {
            get { return field15; }
            set
            {
                if (value != field15)
                {
                    field15 = value;
                    NotifyPropertyChanged("Field15");
                }
            }
        }
        public Field Field16
        {
            get { return field16; }
            set
            {
                if (value != field16)
                {
                    field16 = value;
                    NotifyPropertyChanged("Field16");
                }
            }
        }
        public Field Field17
        {
            get { return field17; }
            set
            {
                if (value != field17)
                {
                    field17 = value;
                    NotifyPropertyChanged("Field17");
                }
            }
        }
        public Field Field18
        {
            get { return field18; }
            set
            {
                if (value != field18)
                {
                    field18 = value;
                    NotifyPropertyChanged("Field18");
                }
            }
        }
        public Field Field19
        {
            get { return field19; }
            set
            {
                if (value != field19)
                {
                    field19 = value;
                    NotifyPropertyChanged("Field19");
                }
            }
        }
        public Field Field20
        {
            get { return field20; }
            set
            {
                if (value != field20)
                {
                    field20 = value;
                    NotifyPropertyChanged("Field20");
                }
            }
        }
        public Field Field21
        {
            get { return field21; }
            set
            {
                if (value != field21)
                {
                    field21 = value;
                    NotifyPropertyChanged("Field21");
                }
            }
        }
        public Field Field22
        {
            get { return field22; }
            set
            {
                if (value != field22)
                {
                    field22 = value;
                    NotifyPropertyChanged("Field22");
                }
            }
        }
        public Field Field23
        {
            get { return field23; }
            set
            {
                if (value != field23)
                {
                    field23 = value;
                    NotifyPropertyChanged("Field23");
                }
            }
        }
        public Field Field24
        {
            get { return field24; }
            set
            {
                if (value != field24)
                {
                    field24 = value;
                    NotifyPropertyChanged("Field24");
                }
            }
        }
        public Field Field25
        {
            get { return field25; }
            set
            {
                if (value != field25)
                {
                    field25 = value;
                    NotifyPropertyChanged("Field25");
                }
            }
        }
        public Field Field26
        {
            get { return field26; }
            set
            {
                if (value != field26)
                {
                    field26 = value;
                    NotifyPropertyChanged("Field26");
                }
            }
        }
        public Field Field27
        {
            get { return field27; }
            set
            {
                if (value != field27)
                {
                    field27 = value;
                    NotifyPropertyChanged("Field27");
                }
            }
        }
        public Field Field28
        {
            get { return field28; }
            set
            {
                if (value != field28)
                {
                    field28 = value;
                    NotifyPropertyChanged("Field28");
                }
            }
        }
        public Field Field29
        {
            get { return field29; }
            set
            {
                if (value != field29)
                {
                    field29 = value;
                    NotifyPropertyChanged("Field29");
                }
            }
        }
        public Field Field30
        {
            get { return field30; }
            set
            {
                if (value != field30)
                {
                    field30 = value;
                    NotifyPropertyChanged("Field30");
                }
            }
        }
        public Field Field31
        {
            get { return field31; }
            set
            {
                if (value != field31)
                {
                    field31 = value;
                    NotifyPropertyChanged("Field31");
                }
            }
        }
        public Field Field32
        {
            get { return field32; }
            set
            {
                if (value != field32)
                {
                    field32 = value;
                    NotifyPropertyChanged("Field32");
                }
            }
        }
        public Field Field33
        {
            get { return field33; }
            set
            {
                if (value != field33)
                {
                    field33 = value;
                    NotifyPropertyChanged("Field33");
                }
            }
        }
        public Field Field34
        {
            get { return field34; }
            set
            {
                if (value != field34)
                {
                    field34 = value;
                    NotifyPropertyChanged("Field34");
                }
            }
        }
        public Field Field35
        {
            get { return field35; }
            set
            {
                if (value != field35)
                {
                    field35 = value;
                    NotifyPropertyChanged("Field35");
                }
            }
        }
        public Field Field36
        {
            get { return field36; }
            set
            {
                if (value != field36)
                {
                    field36 = value;
                    NotifyPropertyChanged("Field36");
                }
            }
        }
        public Field Field37
        {
            get { return field37; }
            set
            {
                if (value != field37)
                {
                    field37 = value;
                    NotifyPropertyChanged("Field37");
                }
            }
        }
        public Field Field38
        {
            get { return field38; }
            set
            {
                if (value != field38)
                {
                    field38 = value;
                    NotifyPropertyChanged("Field38");
                }
            }
        }
        public Field Field39
        {
            get { return field39; }
            set
            {
                if (value != field39)
                {
                    field39 = value;
                    NotifyPropertyChanged("Field39");
                }
            }
        }
        public Field Field40
        {
            get { return field40; }
            set
            {
                if (value != field40)
                {
                    field40 = value;
                    NotifyPropertyChanged("Field40");
                }
            }
        }
        public Field Field41
        {
            get { return field41; }
            set
            {
                if (value != field41)
                {
                    field41 = value;
                    NotifyPropertyChanged("Field41");
                }
            }
        }
        public Field Field42
        {
            get { return field42; }
            set
            {
                if (value != field42)
                {
                    field42 = value;
                    NotifyPropertyChanged("Field42");
                }
            }
        }
        public Field Field43
        {
            get { return field43; }
            set
            {
                if (value != field43)
                {
                    field43 = value;
                    NotifyPropertyChanged("Field43");
                }
            }
        }
        public Field Field44
        {
            get { return field44; }
            set
            {
                if (value != field44)
                {
                    field44 = value;
                    NotifyPropertyChanged("Field44");
                }
            }
        }
        public Field Field45
        {
            get { return field45; }
            set
            {
                if (value != field45)
                {
                    field45 = value;
                    NotifyPropertyChanged("Field45");
                }
            }
        }
        public Field Field46
        {
            get { return field46; }
            set
            {
                if (value != field46)
                {
                    field46 = value;
                    NotifyPropertyChanged("Field46");
                }
            }
        }
        public Field Field47
        {
            get { return field47; }
            set
            {
                if (value != field47)
                {
                    field47 = value;
                    NotifyPropertyChanged("Field47");
                }
            }
        }
        public Field Field48
        {
            get { return field48; }
            set
            {
                if (value != field48)
                {
                    field48 = value;
                    NotifyPropertyChanged("Field48");
                }
            }
        }
        public Field Field49
        {
            get { return field49; }
            set
            {
                if (value != field49)
                {
                    field49 = value;
                    NotifyPropertyChanged("Field49");
                }
            }
        }
        public Field Field50
        {
            get { return field50; }
            set
            {
                if (value != field50)
                {
                    field50 = value;
                    NotifyPropertyChanged("Field50");
                }
            }
        }
        public Field Field51
        {
            get { return field51; }
            set
            {
                if (value != field51)
                {
                    field51 = value;
                    NotifyPropertyChanged("Field51");
                }
            }
        }
        public Field Field52
        {
            get { return field52; }
            set
            {
                if (value != field52)
                {
                    field52 = value;
                    NotifyPropertyChanged("Field52");
                }
            }
        }
        public Field Field53
        {
            get { return field53; }
            set
            {
                if (value != field53)
                {
                    field53 = value;
                    NotifyPropertyChanged("Field53");
                }
            }
        }
        public Field Field54
        {
            get { return field54; }
            set
            {
                if (value != field54)
                {
                    field54 = value;
                    NotifyPropertyChanged("Field54");
                }
            }
        }
        public Field Field55
        {
            get { return field55; }
            set
            {
                if (value != field55)
                {
                    field55 = value;
                    NotifyPropertyChanged("Field55");
                }
            }
        }
        public Field Field56
        {
            get { return field56; }
            set
            {
                if (value != field56)
                {
                    field56 = value;
                    NotifyPropertyChanged("Field56");
                }
            }
        }
        public Field Field57
        {
            get { return field57; }
            set
            {
                if (value != field57)
                {
                    field57 = value;
                    NotifyPropertyChanged("Field57");
                }
            }
        }
        public Field Field58
        {
            get { return field58; }
            set
            {
                if (value != field58)
                {
                    field58 = value;
                    NotifyPropertyChanged("Field58");
                }
            }
        }
        public Field Field59
        {
            get { return field59; }
            set
            {
                if (value != field59)
                {
                    field59 = value;
                    NotifyPropertyChanged("Field59");
                }
            }
        }
        public Field Field60
        {
            get { return field60; }
            set
            {
                if (value != field60)
                {
                    field60 = value;
                    NotifyPropertyChanged("Field60");
                }
            }
        }
        public Field Field61
        {
            get { return field61; }
            set
            {
                if (value != field61)
                {
                    field61 = value;
                    NotifyPropertyChanged("Field61");
                }
            }
        }
        public Field Field62
        {
            get { return field62; }
            set
            {
                if (value != field62)
                {
                    field62 = value;
                    NotifyPropertyChanged("Field62");
                }
            }
        }
        public Field Field63
        {
            get { return field63; }
            set
            {
                if (value != field63)
                {
                    field63 = value;
                    NotifyPropertyChanged("Field63");
                }
            }
        }
        public Field Field64
        {
            get { return field64; }
            set
            {
                if (value != field64)
                {
                    field64 = value;
                    NotifyPropertyChanged("Field64");
                }
            }
        }
        public Field Field65
        {
            get { return field65; }
            set
            {
                if (value != field65)
                {
                    field65 = value;
                    NotifyPropertyChanged("Field65");
                }
            }
        }
        public Field Field66
        {
            get { return field66; }
            set
            {
                if (value != field66)
                {
                    field66 = value;
                    NotifyPropertyChanged("Field66");
                }
            }
        }
        public Field Field67
        {
            get { return field67; }
            set
            {
                if (value != field67)
                {
                    field67 = value;
                    NotifyPropertyChanged("Field67");
                }
            }
        }
        public Field Field68
        {
            get { return field68; }
            set
            {
                if (value != field68)
                {
                    field68 = value;
                    NotifyPropertyChanged("Field68");
                }
            }
        }
        public Field Field69
        {
            get { return field69; }
            set
            {
                if (value != field69)
                {
                    field69 = value;
                    NotifyPropertyChanged("Field69");
                }
            }
        }
        public Field Field70
        {
            get { return field70; }
            set
            {
                if (value != field70)
                {
                    field70 = value;
                    NotifyPropertyChanged("Field70");
                }
            }
        }
        public Field Field71
        {
            get { return field71; }
            set
            {
                if (value != field71)
                {
                    field71 = value;
                    NotifyPropertyChanged("Field71");
                }
            }
        }
        public Field Field72
        {
            get { return field72; }
            set
            {
                if (value != field72)
                {
                    field72 = value;
                    NotifyPropertyChanged("Field72");
                }
            }
        }
        public Field Field73
        {
            get { return field73; }
            set
            {
                if (value != field73)
                {
                    field73 = value;
                    NotifyPropertyChanged("Field73");
                }
            }
        }
        public Field Field74
        {
            get { return field74; }
            set
            {
                if (value != field74)
                {
                    field74 = value;
                    NotifyPropertyChanged("Field74");
                }
            }
        }
        public Field Field75
        {
            get { return field75; }
            set
            {
                if (value != field75)
                {
                    field75 = value;
                    NotifyPropertyChanged("Field75");
                }
            }
        }
        public Field Field76
        {
            get { return field76; }
            set
            {
                if (value != field76)
                {
                    field76 = value;
                    NotifyPropertyChanged("Field76");
                }
            }
        }
        public Field Field77
        {
            get { return field77; }
            set
            {
                if (value != field77)
                {
                    field77 = value;
                    NotifyPropertyChanged("Field77");
                }
            }
        }
        public Field Field78
        {
            get { return field78; }
            set
            {
                if (value != field78)
                {
                    field78 = value;
                    NotifyPropertyChanged("Field78");
                }
            }
        }
        public Field Field79
        {
            get { return field79; }
            set
            {
                if (value != field79)
                {
                    field79 = value;
                    NotifyPropertyChanged("Field79");
                }
            }
        }
        public Field Field80
        {
            get { return field80; }
            set
            {
                if (value != field80)
                {
                    field80 = value;
                    NotifyPropertyChanged("Field80");
                }
            }
        }
        public Field Field81
        {
            get { return field81; }
            set
            {
                if (value != field81)
                {
                    field81 = value;
                    NotifyPropertyChanged("Field81");
                }
            }
        }

        #endregion

        public string WindowTitle
        {
            get { return windowTitle; }
            set
            {
                if (value != windowTitle)
                {
                    windowTitle = value;
                    NotifyPropertyChanged("WindowTitle");
                }
            }
        }
        
        public void SetFields(List<Field> fields)
        {
            Field[] fieldArr = fields.ToArray();
            Field1 = fieldArr[0];
            Field2 = fieldArr[1];
            Field3 = fieldArr[2];
            Field4 = fieldArr[3];
            Field5 = fieldArr[4];
            Field6 = fieldArr[5];
            Field7 = fieldArr[6];
            Field8 = fieldArr[7];
            Field9 = fieldArr[8];
            Field10 = fieldArr[9];
            Field11 = fieldArr[10];
            Field12 = fieldArr[11];
            Field13 = fieldArr[12];
            Field14 = fieldArr[13];
            Field15 = fieldArr[14];
            Field16 = fieldArr[15];
            Field17 = fieldArr[16];
            Field18 = fieldArr[17];
            Field19 = fieldArr[18];
            Field20 = fieldArr[19];
            Field21 = fieldArr[20];
            Field22 = fieldArr[21];
            Field23 = fieldArr[22];
            Field24 = fieldArr[23];
            Field25 = fieldArr[24];
            Field26 = fieldArr[25];
            Field27 = fieldArr[26];
            Field28 = fieldArr[27];
            Field29 = fieldArr[28];
            Field30 = fieldArr[29];
            Field31 = fieldArr[30];
            Field32 = fieldArr[31];
            Field33 = fieldArr[32];
            Field34 = fieldArr[33];
            Field35 = fieldArr[34];
            Field36 = fieldArr[35];
            Field37 = fieldArr[36];
            Field38 = fieldArr[37];
            Field39 = fieldArr[38];
            Field40 = fieldArr[39];
            Field41 = fieldArr[40];
            Field42 = fieldArr[41];
            Field43 = fieldArr[42];
            Field44 = fieldArr[43];
            Field45 = fieldArr[44];
            Field46 = fieldArr[45];
            Field47 = fieldArr[46];
            Field48 = fieldArr[47];
            Field49 = fieldArr[48];
            Field50 = fieldArr[49];
            Field51 = fieldArr[50];
            Field52 = fieldArr[51];
            Field53 = fieldArr[52];
            Field54 = fieldArr[53];
            Field55 = fieldArr[54];
            Field56 = fieldArr[55];
            Field57 = fieldArr[56];
            Field58 = fieldArr[57];
            Field59 = fieldArr[58];
            Field60 = fieldArr[59];
            Field61 = fieldArr[60];
            Field62 = fieldArr[61];
            Field63 = fieldArr[62];
            Field64 = fieldArr[63];
            Field65 = fieldArr[64];
            Field66 = fieldArr[65];
            Field67 = fieldArr[66];
            Field68 = fieldArr[67];
            Field69 = fieldArr[68];
            Field70 = fieldArr[69];
            Field71 = fieldArr[70];
            Field72 = fieldArr[71];
            Field73 = fieldArr[72];
            Field74 = fieldArr[73];
            Field75 = fieldArr[74];
            Field76 = fieldArr[75];
            Field77 = fieldArr[76];
            Field78 = fieldArr[77];
            Field79 = fieldArr[78];
            Field80 = fieldArr[79];
            Field81 = fieldArr[80];
        }


        //public ICommand ContextMenuShowPossibleValue
        //{
        //    get
        //    {
        //        return _clickCMShowPossibleValues ?? (_clickCMShowPossibleValues = new CommandHandler((sender) => ActionCMShowPossibleValues(sender), () => CanExecute));
        //    }
        //}

        private void ActionCMShowPossibleValues(object sender)
        {
            throw new NotImplementedException();
        }

        public ICommand BtnSolveClickCommand
        {
            get
            {
                return _clickCommandSolve ?? (_clickCommandSolve = new CommandHandler(() => ActionSolve(), () => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                return true;
            }
        }

        public void ActionSolve()
        {
            Solver.Solve();
            for(int fieldCounter = 1; fieldCounter < 82; fieldCounter++)
            {
                NotifyPropertyChanged($"Field{fieldCounter.ToString()}");
            }
            
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public ISolverLogic Solver { get; set; }
    }

    

    public class CommandHandler : ICommand
    {
        //private Action _action;
        private readonly Action _action;
        private Func<bool> _canExecute;

        /// <summary>
        /// Creates instance of the command handler
        /// </summary>
        /// <param name="action">Action to be executed by the command</param>
        /// <param name="canExecute">A bolean property to containing current permissions to execute the command</param>
        public CommandHandler(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Wires CanExecuteChanged event 
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Forcess checking if execute is allowed
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
