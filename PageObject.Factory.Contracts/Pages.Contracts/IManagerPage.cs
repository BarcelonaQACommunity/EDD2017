using PageObject.Factory.Contracts.Base.Contracts;

namespace PageObject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// The IManager page.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface IManagerPage : IPageObjectBase
    {
        /// <summary>
        /// Gets the welcome user manager.
        /// </summary>
        /// <returns></returns>
        string GetWelcomeUserManager();

        /// <summary>
        /// Goes to add new customer page.
        /// </summary>
        void GoToAddNewCustomerPage();

        /// <summary>
        /// Goes to edit customer page.
        /// </summary>
        void GoToEditCustomerPage();
    }
}
