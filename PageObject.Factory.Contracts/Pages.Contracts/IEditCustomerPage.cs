using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject.Factory.Contracts.Pages.Contracts
{
    using PageObject.Factory.Contracts.Base.Contracts;
    using PageObject.Models;

    public interface IEditCustomerPage : IPageObjectBase
    {
        void EditCustomer(Customer customer);
    }
}
