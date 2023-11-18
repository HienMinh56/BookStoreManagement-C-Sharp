using Repositories;
using Repositories.Entities;

namespace Services
{
    public class BookManagementMemberService
    {
        public BookManagementMember? CheckLogin(string email, string password)
        {
            BookManagementMemberRepository repo = new BookManagementMemberRepository();

            BookManagementMember account = repo.Get(email);

            //if (account == null)
            //    return null;
            //if (account.Password == password)
            //    return account;
            //return null;

            return account != null && account.Password == password ? account : null;
        }

    }
}
