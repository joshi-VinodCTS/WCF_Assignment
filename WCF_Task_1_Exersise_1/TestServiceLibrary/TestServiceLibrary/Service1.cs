using System;

namespace TestServiceLibrary
{
    public class Service1 : IService1
    {
        public string SayHello(string name)
        {
            string greet = string.Empty;

            if (DateTime.Now.Hour < 12)
            {
                greet = "Good Morning";
            }
            else if (DateTime.Now.Hour < 17)
            {
                greet = "Good Afternoon";
            }
            else
            {
                greet = "Good Evening";
            }
            return string.Concat(greet, "\t", name);
        }

        public string TodayProgram(string name)
        {
            string greet = string.Empty;
            DayOfWeek dayofWeek = DateTime.Now.DayOfWeek;

            switch(dayofWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    {
                        greet = "Happy weekend";
                        break;
                    }
                default:
                    {
                        greet = "Enjoy Working day";
                        break;
                    }
            }
            return string.Concat(greet, "\t", name);
        }
    }
}
