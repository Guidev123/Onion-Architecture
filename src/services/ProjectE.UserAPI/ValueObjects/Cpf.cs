﻿namespace ProjectE.UserAPI.ValueObjects
{
    public class Cpf
    {
        public Cpf(string number)
        {
            Number = number;
        }
        public string? Number { get; private set; }

        // To EF
        protected Cpf() { }

        public bool Validar()
        {
            if (Number?.Length > 11)
                return false;

            while (Number?.Length != 11)
                Number = '0' + Number;

            var Equal = true;
            for (var i = 1; i < 11 && Equal; i++)
                if (Number[i] != Number[0])
                    Equal = false;

            if (Equal || Number == "12345678909")
                return false;

            var numbers = new int[11];

            for (var i = 0; i < 11; i++)
                numbers[i] = int.Parse(Number[i].ToString());

            var sum = 0;
            for (var i = 0; i < 9; i++)
                sum += (10 - i) * numbers[i];

            var result = sum % 11;

            if (result == 1 || result == 0)
            {
                if (numbers[9] != 0)
                    return false;
            }
            else if (numbers[9] != 11 - result)
                return false;

            sum = 0;
            for (var i = 0; i < 10; i++)
                sum += (11 - i) * numbers[i];

            result = sum % 11;

            if (result == 1 || result == 0)
            {
                if (numbers[10] != 0)
                    return false;
            }
            else if (numbers[10] != 11 - result)
                return false;

            return true;
        }
    }
}
