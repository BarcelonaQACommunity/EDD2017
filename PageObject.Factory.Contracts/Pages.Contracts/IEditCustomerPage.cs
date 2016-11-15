using PageObject.Factory.Contracts.Base.Contracts;
using PageObject.Models;

namespace PageObject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// The edit customer page.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface IEditCustomerPage : IPageObjectBase
    {
        void EditCustomer(Customer customer);
    }
}
