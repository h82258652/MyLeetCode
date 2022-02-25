namespace LeetCode537
{
    public class Solution
    {
        public struct ComplexNumber
        {
            public int Real { get; set; }

            public int UnReal { get; set; }

            public static ComplexNumber FromString(string str)
            {
                var number = new ComplexNumber();
                var temp = str.Split('+');
                var real = int.Parse(temp[0]);
                var unreal = int.Parse(temp[1].TrimEnd('i'));
                number.Real = real;
                number.UnReal = unreal;
                return number;
            }

            public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
            {
                var real = num1.Real * num2.Real - num1.UnReal * num2.UnReal;
                var unreal = num1.Real * num2.UnReal + num1.UnReal * num2.Real;
                return new ComplexNumber
                {
                    Real = real,
                    UnReal = unreal
                };
            }

            public override string ToString()
            {
                return Real + "+" + UnReal + "i";
            }
        }

        public string ComplexNumberMultiply(string num1, string num2)
        {
            var number1 = ComplexNumber.FromString(num1);
            var number2 = ComplexNumber.FromString(num2);
            var result = number1 * number2;
            return result.ToString();
        }
    }
}
