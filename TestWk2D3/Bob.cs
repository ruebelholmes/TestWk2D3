using System.Linq;

namespace TestWk2D3
{
    public class Bob
    {
        public string hey(string remark)
        {
            if (Yelling(remark))
                return "Whoa, chill out!";


            if (Silence(remark))
                return "Fine. Be that way!";

            if (Question(remark))
                return "Sure.";


            return "Whatever.";
        }

        private bool Silence(string remark) => string.IsNullOrWhiteSpace(remark);

        private bool Question(string remark) => remark.EndsWith("?");

        private bool Yelling(string remark)
        {
            var lettersOnly = remark.Where(char.IsLetter).ToList();
            return lettersOnly.Any() && lettersOnly.All(char.IsUpper);
        }
    }
}