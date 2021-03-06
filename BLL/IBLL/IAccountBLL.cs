using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTO;
namespace BLL.IBLL
{
    interface IAccountBLL
    {
        public void Login(string usuario, string pass);
        public void Create(AccountDTO account);
        public void Delete(long id);
        public void Update(long id, AccountDTO account);
        public void Select();
        public void Select(string usuario);
    }
}
