using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlessERP.API.Dtos;
using BlessERP.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlessERP.API.Data
{
    public class NursingRepository : INursingRepository
    {
        private readonly BlessERPContext _context;
        public NursingRepository(BlessERPContext context)
        {
            _context = context;

        }
        public IEnumerable<NurseHandoverBook> GetAll()
        {
            return _context.NurseHandoverBook.ToList();
        }
        public void SaveNurseHandOverBook(NurseHandoverBook ObjNurseHandeOverBook)
        {
            _context.NurseHandoverBook.Add(ObjNurseHandeOverBook);
            _context.SaveChanges();

        }
    }
}