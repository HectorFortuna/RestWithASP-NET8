﻿using RestWithASPNET8.Model;

namespace RestWithASPNET8.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {   
            List<Person> persons = new List<Person> ();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Isadora",
                LastName = "Fortuna",
                Address = "Rio de Janeiro - RJ - Brasil",
                Gender = "Female"
            };
        }

        public Person Update(Person person)
        {
            
            return person;
        }
        
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Isadora" + i,
                LastName = "Fortuna" + i,
                Address = "Rio de Janeiro - RJ - Brasil" + i,
                Gender = "Female"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
