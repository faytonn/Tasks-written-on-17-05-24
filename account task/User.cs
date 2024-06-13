namespace account_task
{
    public class User : Account
    {
        private static int id;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }

        private string _password;
        public string Password {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }


        public User(string fullName, string email, string password)
        {
            Id = ++id;
            FullName = fullName;
            Email = email;
            Password = password;
        }

        public override bool PasswordChecker(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            if (password.Length < 8)
            {
                Console.WriteLine("Invalid character length");
                return false;
            }
            else if (password.Length >= 8)
            {
                return true;
            }


            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit;
        }

        public override string showInfo() 
        {
            return $"ID: {Id} \tFull Name: {FullName} \tEmail: {Email}";

        }



    }
}
