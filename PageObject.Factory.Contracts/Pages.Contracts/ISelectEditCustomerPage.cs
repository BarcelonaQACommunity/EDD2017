using System;
using PageObject.Factory.Contracts.Base.Contracts;

namespace PageObject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// The select edit customer page interface.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface ISelectEditCustomerPage : IPageObjectBase
    {
        /// <summary>
        /// Inserts the user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        void InsertUserId(string userId);

        /// <summary>
        /// Clicks the submit button.
        /// </summary>
        void ClickSubmitButton();
    }
}
