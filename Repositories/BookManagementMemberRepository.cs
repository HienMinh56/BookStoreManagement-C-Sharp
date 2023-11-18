using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookManagementMemberRepository
    {
        public BookManagementMember? Get(string email)
        {
            BookManagement2023DbContext db = new BookManagement2023DbContext();
            return db.BookManagementMembers.FirstOrDefault(x => x.Email == email);             
        }

    }
}
