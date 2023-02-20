using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class VIN
    {
        public char[] vinSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public string GetVINCountry(String vinNumber)
        {
            if (CheckVIN(vinNumber))
            {
                for (int i = 10; i <= 17; i++)
                {
                    if (vinNumber[11] == vinSymbols[i])
                    {
                        return "Африка";
                    }
                }
                for (int i = 18; i <= 24; i++)
                {
                    if (vinNumber[11] == vinSymbols[i])
                    {
                        return "Азия";
                    }
                }
                for (int i = 25; i <= 32; i++)
                {
                    if (vinNumber[11] == vinSymbols[i])
                    {
                        return "Европа";
                    }
                }
                for (int i = 1; i <= 5; i++)
                {
                    if (vinNumber[11] == vinSymbols[i])
                    {
                        return "Северная Америка";
                    }
                }
                for (int i = 6; i <= 7; i++)
                {
                    if (vinNumber[11] == vinSymbols[i])
                    {
                        return "Океания";
                    }
                }
                for (int i = 8; i <= 9; i++)
                {
                    if (vinNumber[11] == vinSymbols[i])
                    {
                        return "Южная Америка";
                    }
                }
            }

            return "";

        }
        public Boolean CheckVIN(String vinNumber)
        {
            int counter = 0;
            if (vinNumber.Length == 17)
            {
                for (int i = 0; i < 17; i++)
                {
                    for (int j = 0; j < vinSymbols.Length; j++)
                    {
                        if (vinNumber[i] == vinSymbols[j])
                        {
                            counter++;
                        }
                    }
                }
                if (counter == 17)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
