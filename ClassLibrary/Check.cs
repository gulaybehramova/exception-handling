using System;

namespace ClassLibrary
{
    public class Check
    {
        public bool HasDigit(string soz)
        {
            bool has = false;
            foreach (var item in soz)
            {
                if (char.IsDigit(item))
                {
                    has = true;
                }
            }
            return has;
        }


        public bool HasUpper(string soz)
        {
            bool has = false;
            foreach (var item in soz)
            {
                if (char.IsUpper(item))
                {
                    has = true;
                }
            }
            return has;
        }

        public bool HasLower(string soz)
        {
            bool has = false;
            foreach (var item in soz)
            {
                if (char.IsLower(item))
                {
                    has = true;
                }
            }
            return has;
        }

    }   
}
