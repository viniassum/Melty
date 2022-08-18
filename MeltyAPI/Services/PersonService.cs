using MeltyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeltyAPI.Services
{
    public class PersonService : IPersonService
    {
        public static List<PersonModel> people = new List<PersonModel>
        {
            new PersonModel() {Id = 1, FirstName = "Vinicius", LastName = "Assum"},
            new PersonModel() {Id = 2, FirstName = "John", LastName = "Doe"},
            new PersonModel() {Id = 3, FirstName = "Jane", LastName = "Doe"}
        };

        public IEnumerable<PersonModel> Get()
        {
            return people;
        }

        public PersonModel GetById(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        public object Save(int id, string FirstName, string LastName)
        {
            PersonModel person = new PersonModel();

            person.Id = id;
            person.FirstName = FirstName;
            person.LastName = LastName;

            people.Add(person);

            return people;
        }


    }
}
