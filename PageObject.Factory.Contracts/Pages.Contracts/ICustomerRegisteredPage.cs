using PageObject.Factory.Contracts.Base.Contracts;
using PageObject.Models;

namespace PageObject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// The customer registered page interface.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface ICustomerRegisteredPage : IPageObjectBase
    {
        /// <summary>
        /// Determines whether [is customer registered] [the specified customer].
        /// </summary>
        /// <param name="customer">The customer.</param>
        bool IsCustomerRegistered(Customer customer);

        /// <summary>
        /// Determines whether [is customer updated] [the specified customer].
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns></returns>
        bool IsCustomerUpdated(Customer customer);

        /// <summary>
        /// Swiches to alert.
        /// </summary>
        void SwichToAlert();
    }
}
