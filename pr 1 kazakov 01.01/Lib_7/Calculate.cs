using System;

namespace Lib_7
{
    public class Calculate
    {
        public string GetSum(int n)
        {
            string result;
            Random rnd = new Random();
            int x, sum = 0, counter = 0;
            result = string.Empty;
            do
            {
                x = rnd.Next(n/2, n+1);
                counter++;
                sum += x;
                result += $"{x}  | Ñóììà: {sum} \n";
            } while (counter < n);
            return result;
        }
    }
}
