using System;
using System.Collections;


namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            int output = 0;

            foreach (char number in num.ToString())
            {
                if (output == 0)
                {
                    output = Int32.Parse(number.ToString());
                }
                else
                {
                    output *= Int32.Parse(number.ToString());
                }
            }
            return output;
        }
    }
}
