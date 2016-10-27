using PageObject.Factory.Contracts.Base.Contracts;
using PageObject.Models;

namespace PageObject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// The INewCustomer page.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface INewCustomerPage : IPageObjectBase
    {
        /// <summary>
        /// Adds the new customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void AddNewCustomer(Customer customer);

        /// <summary>
        /// Clicks the submit button.
        /// </summary>
        void ClickSubmitButton();
    }
}
