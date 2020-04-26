using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Data
{
    public class ShelterAnimalService
    {
        public readonly int AnimalCapacity = 20;
        private readonly ShelterCalendarService _calendarService;
        private List<Animal> _animals = new List<Animal>();

        public Animal[] Animals { get { return _animals.ToArray(); }}

        public ShelterAnimalService(ShelterCalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        public void AddAnimal(Animal animal)
        {
            if (!_calendarService.IsShelterOpen())
                return;

            if (_animals.Count == AnimalCapacity)
                return;

            if (_animals.Where(x => x.Name == animal.Name).Any())
                return;

            animal.DateRegistered = DateTime.Now;
            
            _animals.Add(animal);
        }
    }
}
