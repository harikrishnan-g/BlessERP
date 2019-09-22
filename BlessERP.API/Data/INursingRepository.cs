using System.Collections.Generic;
using System.Threading.Tasks;
using BlessERP.API.Dtos;
using BlessERP.API.Models;

namespace BlessERP.API.Data
{
    public interface INursingRepository
    {
        IEnumerable<NurseHandoverBook> GetAll();
        void SaveNurseHandOverBook(NurseHandoverBook ObjNurseHandeOverBook);
    }
}