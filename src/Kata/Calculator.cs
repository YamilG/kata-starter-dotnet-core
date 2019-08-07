namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if(string.IsNullOrEmpty(s))
                return 0;

            var strings = s.Split(',');
            var r = int.Parse(strings[0]);
            if (strings.Length>1)
            {
                var y = int.Parse(strings[1]);
                return r + y;
            }

            return r;
        }
    }
}