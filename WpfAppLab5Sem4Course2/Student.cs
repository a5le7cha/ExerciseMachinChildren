using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLab5Sem4Course2
{
    public class Student
    {
        //public List<string> Answers = new List<string>();

        public string fio;
        public string Class;

        private int _summMark = 0;

        public int SummMark
        {
            get { return _summMark; }
        }

        public int SumMark(int mark)
        {
            return _summMark += mark;
        }

        public override string ToString()
        {
            return String.Format($"ФИО: {fio}  Класс: {Class}  Сумма очков: {SummMark}");
        }
    }
}
