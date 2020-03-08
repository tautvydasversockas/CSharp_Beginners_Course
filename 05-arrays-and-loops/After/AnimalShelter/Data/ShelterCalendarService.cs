using System;

namespace AnimalShelter.Data
{
    public class ShelterCalendarService
    {
        public bool IsShelterOpen()
        {
            switch (DateTime.Today.DayOfWeek)
            {
                case (DayOfWeek.Monday):
                case (DayOfWeek.Tuesday):
                case (DayOfWeek.Wednesday):
                case (DayOfWeek.Thursday):
                case (DayOfWeek.Friday):
                    if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 17)
                        return true;
                    else
                        return false;
                default:
                    return false;
            }
        }
    }
}
