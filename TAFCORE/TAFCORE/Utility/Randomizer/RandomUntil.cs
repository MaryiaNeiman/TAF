using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFCORE.Utility.Randomizer
{
  public class RandomUntil
    {
        private static readonly int COUNT_ICONS = 37;

        public static string generateIconNumber()
        {
           
            String iconNumber = "1f6";
            Random rnd = new Random();
            int number = rnd.Next(COUNT_ICONS);
               if (number / 10 == 0)
                         iconNumber = iconNumber + "0";
               return iconNumber + number;
           }

    }
}
