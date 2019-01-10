
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public partial class Money
    {
        private int _faceValue;
        private int _numberBills;
        private int _summaNumbers;
        private int _tenge;


        public Money(int faceValue, int numberBills, int summaNumbers)
        {
            _faceValue = faceValue;
            _numberBills = numberBills;
            summaNumbers = faceValue + numberBills;


        }

        #region Getters and Setters
        public int GetFaceValue()
        {
            return _faceValue;
        }

        public void SetFaceValue(int faceValue)
        {
            _faceValue = faceValue;

        }

        public int GetNumberBillss()
        {
            return _numberBills;
        }

        public void SetNumberBills(int numberBills)
        {
            _numberBills = numberBills;
        }

        public int GetSummaNumbers()
        {
            return _summaNumbers;
        }

        public void SetSummaNumbers(int summaNumbers)
        {
            _summaNumbers = summaNumbers;
        }

        public int GetTenge()
        {
            return _tenge;
        }

        public void SetTenge(int tenge)
        {
            _tenge = tenge;
        }




        #endregion

        public void Show()
        {
            Console.WriteLine("Номинал купюры {0}", _faceValue, "Количество купюр {1}", _numberBills, "Тенге {2}", _tenge);
        }

        public void Buy()
        {
            if (_tenge < _summaNumbers)
            {
                Console.WriteLine("У вас не достаточно денег");
            }
            else
            {
                Console.WriteLine("Вы купили купюры");
            }
        }

        public void isEnoughMoney(int mod)
        {
            if (_tenge != 0)
            {
                mod = _tenge / _summaNumbers;
                Console.WriteLine("можно купить {0}", mod);
            }
            else
            {
                Console.WriteLine("No money no fanny");
            }

        }
    }


}