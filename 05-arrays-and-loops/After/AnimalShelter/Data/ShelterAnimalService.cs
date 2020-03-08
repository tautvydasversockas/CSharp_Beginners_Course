using System;
using System.Collections.Generic;

namespace AnimalShelter.Data
{
    public class ShelterAnimalService
    {
        public readonly int AnimalCapacity = 20;
        private readonly ShelterCalendarService _calendarService;
        private List<string> _animals = new List<string>();

        public string[] Animals { get { return _animals.ToArray(); }}

        public ShelterAnimalService(ShelterCalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        public void AddAnimal(string name)
        {
            if (!_calendarService.IsShelterOpen())
                return;

            if (_animals.Count == AnimalCapacity)
                return;

            if (_animals.Contains(name))
                return;

            _animals.Add(name);
        }
    }
}
