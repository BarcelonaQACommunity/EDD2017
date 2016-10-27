using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObject.Factory.Contracts.Base.Contracts;

namespace PageObject.Factory.Contracts.Pages.Contracts
{
    public interface IManagerPage : IPageObjectBase
    {
        /// <summary>
        /// Gets the welcome user manager.
        /// </summary>
        /// <returns></returns>
        string GetWelcomeUserManager();
    }
}
