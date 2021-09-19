using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Person
    {
        public static List<string> maleFirstNameList = new List<string> { "Андрей", "Александр", "Владимир", "Алексей", "Дмитрий", "Семён", "Валерий", "Василий", "Степан", "Павел"};
        public static List<string> femaleFirstNameList = new List<string> { "Алина", "Светлана", "Валентина", "Анастасия", "Юлия", "Катерина", "Полина", "Ангелина", "Александра", "Олёна" };
        public static List<string> lastNameList = new List<string> { "Кац", "Фисштех", "Баул", "Саргарос", "Карп", "Осгуд", "Ремарк", "Паульс" };
        private byte id;
        private string firstName;
        private string lastName;
        private char gender;
        private double height;
        public byte ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public Person(int genderRandNumb, int firstNameRandNumb, int lastNameRandNumb, double heightRandNumb)
        {
            char idLastChar = ID.ToString()[ID.ToString().Length - 1];
            int randomizer = (int)Char.GetNumericValue(idLastChar);
            gender = (genderRandNumb == 0)? 'М' : 'Ж';
            firstName = (genderRandNumb == 0) ? maleFirstNameList[firstNameRandNumb] : femaleFirstNameList[firstNameRandNumb];
            lastName = lastNameList[lastNameRandNumb];
            height = Math.Round((heightRandNumb * 2), 2);
        }
    }
}
