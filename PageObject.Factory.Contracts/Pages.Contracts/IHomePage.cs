namespace PageObject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// The home page interface.
    /// </summary>
    public interface IHomePage
    {
        /// <summary>
        /// Logins the user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="password">The password.</param>
        void LoginUser(string userId, string password);
    }
}
