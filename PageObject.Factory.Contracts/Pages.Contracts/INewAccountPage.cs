using PageObject.Factory.Contracts.Base.Contracts;

namespace PageObject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// The INewAccount page.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface INewAccountPage : IPageObjectBase
    {
        /// <summary>
        /// Creates the saving account.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="initialDeposit">The initial deposit.</param>
        void CreateSavingAccount(string customerId, int initialDeposit);

        /// <summary>
        /// Creates the current account.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="initialDeposit">The initial deposit.</param>
        void CreateCurrentAccount(string customerId, int initialDeposit);

        /// <summary>
        /// Gets the URL.
        /// </summary>
        string GetUrl();

        /// <summary>
        /// Clicks the submit button.
        /// </summary>
        void ClickSubmitButton();
    }
}
