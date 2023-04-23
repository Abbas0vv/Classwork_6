using System;

namespace HRManagementSystem
{
    //custom type
    public class Student
    {
        //fields (data)
        public string _firstName;
        public string _lastName;
        public string _fatherName;
        public int _age;
    }

    public class AddStudentCommand
    {
        public Utility _utility = new Utility();

        public void Handle(List<Student> argStudents)
        {
            string firstName = GetAndValidateFirstName();
            string lastName = GetAndValidateLastName();
            string fatherName = GetAndValidateFatherName();
            int age = GetAndValidateAge();

            Student human = new Student
            {
                _firstName = firstName,
                _lastName = lastName,
                _fatherName = fatherName,
                _age = age,
            };

            argStudents.Add(human);

            //argStudents[lastStudentIdx] = human;
            //lastStudentIdx = lastStudentIdx + 1;

            Console.WriteLine($"Məlumat Sistemə əlavə olundu");
        }

        #region First name

        string GetAndValidateFirstName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter first name : ");
                string firstName = Console.ReadLine()!;

                if (IsValidFirstName(firstName))
                    return firstName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        bool IsValidFirstName(string firstName)
        {
            int MIN_LENGTH = 2;
            int MAX_LENGTH = 20;

            return IsValidName(firstName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Last name

        string GetAndValidateLastName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter last name : ");
                string lastName = Console.ReadLine()!;

                if (IsValidLastName(lastName))
                    return lastName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        bool IsValidLastName(string lastName)
        {
            int MIN_LENGTH = 2;
            int MAX_LENGTH = 30;

            return IsValidName(lastName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Father name

        string GetAndValidateFatherName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter father name : ");
                string fatherName = Console.ReadLine()!;

                if (IsValidFatherName(fatherName))
                    return fatherName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        bool IsValidFatherName(string fatherName)
        {
            int MIN_LENGTH = 2;
            int MAX_LENGTH = 45;

            return IsValidName(fatherName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Age

        int GetAndValidateAge()
        {
            while (true)
            {
                Console.WriteLine("Pls enter age : ");
                var isParsable = _utility.TryParse(Console.ReadLine()!, out int age);
                if (!isParsable)
                {
                    continue;
                }

                //Early return 
                if (_utility.IsLengthBetween(age, 18, 65))
                    return age;

                Console.WriteLine("Some information is not correnct");
            }
        }

        #endregion

        #region Common

        bool IsValidName(string name, int minLength, int maxLenght)
        {
            if (!_utility.IsLengthBetween(name, minLength, maxLenght))
            {
                return false;
            }

            char firstLetter = name[0];

            if (!_utility.IsUpperLetter(firstLetter))
            {
                return false;
            }

            for (int i = 1; i < name.Length; i++)
            {
                if (_utility.IsUpperLetter(name[i]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sutndet's count : ");
            //int count = int.Parse(Console.ReadLine()!);
            //Student[] students = new Student[count];
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Pls enter command : ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "/add-student":
                        AddStudentCommand addStudentCommand = new AddStudentCommand();
                        addStudentCommand.Handle(students);
                        break;

                    case "/exit":
                        break;
                }
            }
        }

        //public static void PrintPersonsInfo(Student[] people)
        //{
        //    for (int k = 0; k < people.Length; k++)
        //    {
        //        Console.WriteLine($"First name : {people[k]._firstName}");
        //        Console.WriteLine($"Last name : {people[k]._lastName}");
        //        Console.WriteLine($"Father name : {people[k]._fatherName}");

        //        //Console.WriteLine($"Age : {persons[k]}");
        //        //Console.WriteLine($"Pin : {persons[k]}");
        //        //Console.WriteLine($"Phone number : {persons[k]}");
        //        //Console.WriteLine($"Position : {persons[k]}");
        //        //Console.WriteLine($"Monthly salary : {persons[k]}");
        //        //Console.WriteLine();
        //    }
        //}
    }

    public class Utility
    {
        public char[] _uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public char[] _numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        #region Utility

        public bool TryParse(string text, out int number)
        {
            try
            {
                number = int.Parse(text);
                return true;
            }
            catch
            {
                number = -1;
                return false;
            }
        }
        public bool IsStartsWith(string text, string startText)
        {
            if (startText.Length > text.Length)
            {
                return false;
            }

            for (int i = 0; i < startText.Length; i++)
            {
                if (text[i] != startText[i])
                {
                    return false;
                }
            }

            return true;
        }
        public string Substring(string text, int startIdx, int endIdx)
        {
            string subString = "";

            for (int i = startIdx; i <= endIdx; i++)
            {
                subString += text[i];
            }

            return subString;
        }
        public string SubstringFromEnd(string text, int length)
        {
            if (text.Length <= length || length < 0)
            {
                return default;
            }

            string subString = "";

            for (int i = text.Length - 1; i >= text.Length - length; i--)
            {
                subString += text[i];
            }

            return Reverse(subString);
        }

        public string Reverse(string text)
        {
            string reversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            return reversed;
        }

        public bool IsLengthBetween(decimal number, decimal min, decimal max)
        {
            return number > min && number < max;
        }
        public bool IsLengthBetween(string text, int min, int max)
        {
            return text.Length > min && text.Length < max;
        }

        //Method overloading ( polymorphism)
        public bool IsLengthBetween(int number, int min, int max)
        {
            return number > min && number < max;
        }
        public bool IsUpperLetter(char letter)
        {
            foreach (char uppercaseLetter in _uppercaseLetters) //while LOOP
            {
                if (uppercaseLetter == letter)
                {
                    return true;
                }
            }

            //for (int i = 0; i < uppercaseLetters.Length; i++)
            //{
            //    if (uppercaseLetters[i] == lette)
            //    {
            //        return true;
            //    }
            //}

            return false;
        }


        public bool IsDigit(string text)
        {
            foreach (char characted in text)
            {
                if (!IsDigit(characted))
                {
                    return false;
                }
            }

            return true;
        }
        public bool IsDigit(char digit)
        {
            foreach (char number in _numbers) //Compiled to while LOOP in IL
            {
                if (digit == number)
                {
                    return true;
                }
            }

            return false;
        }
        public bool IsExactLength(string text, int length)
        {
            return text.Length == length;
        }

        #endregion
    }
}