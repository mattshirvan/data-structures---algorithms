using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab6
{
    class Problem1
    {
        /*
         * Your new online banking app has five rules for a valid, strong password. Write a program to
            determine whether a given password is valid according to these five rules. Report any rules
            violated on an invalid password.

                Rule 1. The minimum length is 6 and the maximum length is 20.
                Rule 2. At least one uppercase and lowercase letter is used.
                Rule 3. At least one digit is used.
                Rule 4. At least one printable symbol other than $ is used.
                Rule 5. There cannot be any blank spaces

        Input
        The first line of input will contain a single integer n, which will indicate the number of test cases.
        You may assume that 1 ≤ n ≤ 100. This will be followed by n strings, one per line, for checking
        validity of as a password. Each input string may contain letters, digits, printable symbols, and
        blank spaces.

        Output
        For each test case, your program needs to print one of the following statements:
             Password <number>: is valid
             Password <number>: is invalid by rule(s) <x>
        The <number> is number of the test case and <x> is rule number(s) violated. Test case numbers
        begin at 1. The output should be in the exact format seen below with a single space after any rule
        numbers violated. If more than one rule number is violated, they should be printed in ascending
        order by rule number
         */

        public int n { get; private set; }
        public Dictionary<int, String> passwords { get; private set; }

        public void GetPasswords()
        {
            // Get number of passwords to check
            if (n <= 0)
            {
                Console.WriteLine("There must be at least one password to be validated");
                Console.WriteLine("Enter the number of passwords to be validated");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            // Store passwords in a dictionary<int, String> 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a password to validate:");
                passwords.Add(i+1, Console.ReadLine());
                Console.WriteLine();
            }
            
        }

        public string Rules(String password)
        {
            // Store the rules violated
            string rules = "";

            // Rule 1.The minimum length is 6 and the maximum length is 20.
            if (password.Length < 6 || password.Length > 20)
            {
                rules += " 1";
            }

            // Rule 2.At least one uppercase and lowercase letter is used.
            if (!(password.Any(Char.IsUpper) && password.Any(Char.IsLower)))
            {
                rules += " 2";
            }

            // Rule 3.At least one digit is used.
            if (!password.Any(Char.IsDigit))
            {
                rules += " 3";
            }

            // Rule 4.At least one printable symbol other than $ is used.
            if (password.Contains('$') || !password.Any(Char.IsSymbol))
            {
                rules += " 4";
            }

            // Rule 5.There cannot be any blank spaces.
            if (password.Any(Char.IsWhiteSpace))
            {
                rules += " 5";
            }

            return rules;
        }

        public void PasswordValidator()
        {
            // Ensure we have passwords
            GetPasswords();

            // Validate passwords
            foreach (var password in passwords)
            {
                // Get the rules violated (if any)
                string rule = Rules(password.Value);

                // No rules violated
                if (rule == "")
                {
                    Console.WriteLine($"Password {password.Key} is valid");
                }
                
                // Display violations
                else
                {
                    Console.WriteLine($"Password {password.Key}  is invalid by rule(s){rule}");
                }
            }
        }

        public void Display()
        {
            // Output all passwords in dictionary (Testing input)
            foreach (var password in passwords)
            {
                Console.WriteLine($"Password {password.Key} is {password.Value}");
            }
        }

        public Problem1()
        {
            this.n = 0;
            this.passwords = new Dictionary<int, string>();
        }

        public Problem1(int n)
        {
            this.n = n;
            this.passwords = new Dictionary<int, string>();
        }
    }
}
