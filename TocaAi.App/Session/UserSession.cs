using TocaAi.Domain.Entities;

namespace TocaAi.App.Session
{
    public static class UserSession
    {
        public static UserAccount? CurrentUser { get; private set; }
        public static bool IsAuthenticated =>
            CurrentUser != null;

        public static void Login(UserAccount user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

    }
}
