using MyDiary.Data_Access_Layer;
using MyDiary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Business_Logic_layer
{
    class PersonService
    {
        PersonDataAccess personDataAccess;
        public PersonService()
        {
            this.personDataAccess = new PersonDataAccess();
        }

        public bool LoginValidation(string personName, string password)
        {
            return personDataAccess.LoginValidation(personName, password);
        }

        public int AddNewPerson(string personName, string password)
        {
            Person person = new Person()
            {
                PersonName = personName,
                Password = password
            };

            return personDataAccess.AddNewPerson(person);
        }
    }
}
