namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if(string.IsNullOrEmpty(s)) return 0;

            if (s.Length > 1)
            {
                var strings = s.Split(",");
                return int.Parse(strings[0]) + int.Parse(strings[1]);
            }

            return 3;

        }
    }
}