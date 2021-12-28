using System;

namespace Open_Lab_06._01
{
    public class Challenge
    {
        public string MysteryFunc(string str)
        {
            string final = "";
            int repeat = 1;
            string cha = "";
            
            int rep = 0;
            foreach (char c in str)
            {
                repeat++;
                if(repeat % 2 == 0)
                {
                    cha = "";
                    cha = c.ToString();
                    rep = 0;
                }
                else
                {
                   
                    do
                    {
                        rep++;
                        final += cha;

                    } while (rep < int.Parse(c.ToString()));


                }

            }
            return final;
        }
    }
}
