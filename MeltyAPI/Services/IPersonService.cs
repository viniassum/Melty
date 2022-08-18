using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeltyAPI.Models;

namespace MeltyAPI.Services
{
    public interface IPersonService
    {
        public IEnumerable<PersonModel> Get();

        public PersonModel GetById(int id);

        public object Save(int id, string FirstName, string LastName);
    }
}
