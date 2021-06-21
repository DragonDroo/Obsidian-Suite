using System.Threading.Tasks;
using Slats.Models;

namespace Slats.DAL
{
    public class PersonService : IPersonService
    {
        IPersonsRepository _personsRepository;

        public PersonService(IPersonsRepository personsRepository)
        {
            _personsRepository = personsRepository;
        }

        public Task Hire()
        {
            throw new System.NotImplementedException();
        }

        public async Task Seperate(Person person)
        {
            var APerson = await _personsRepository.GetByID(person.Id);
            APerson.Deleted = true;
            await _personsRepository.SaveChanges();
        }

        public Task Seperate()
        {
            throw new System.NotImplementedException();
        }


    }
}




//        public Task GetGridDataAsync()
//        {
//            throw new System.NotImplementedException();
//        }

//        public async Task MoveSalesPersonToGroup(int salesPersonId, int groupId)
//        {
//            var person = await _salesRepo.GetByID(salesPersonId);
//            var group = await _salesGroupRepo.GetByID(groupId);
//            person.SalesGroup = group;
//            _salesRepo.Save(person);
//            await _salesRepo.SaveChanges();
//        }

//        public async Task UpdateSalesPersonContact(Salesperson person)
//        {
//            var existingSalesperson = await _salesRepo.GetByID(person.Id);

//            existingSalesperson.FirstName = person.FirstName;
//            existingSalesperson.LastName = person.LastName;
//            existingSalesperson.Email = person.Email;
//            existingSalesperson.Phone = person.Phone;

//            _salesRepo.Save(existingSalesperson);
//            await _salesRepo.SaveChanges();
//        }

//    }
//}
