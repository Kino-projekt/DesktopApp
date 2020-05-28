namespace DesktopApp.Backend.Configuration
{
    public class AdressList
    {
        public static readonly string Server = "https://afternoon-waters-37189.herokuapp.com";

        public static readonly string SingUp = "/api/auth/signup";
        public static readonly string SingIn = "/api/auth/signin";

        public static readonly string Articles = "/api/articles";
        public static readonly string Movies = "/api/movies";
        public static readonly string Halls = "/api/halls";
        public static readonly string Seances = "/api/seances";
        public static readonly string Users = "/api/users";

        public static readonly string ArticlesAdmin = "/api/admin/articles";
        public static readonly string MoviesAdmin = "/api/admin/movies";
        public static readonly string HallsAdmin = "/api/admin/halls";
        public static readonly string SeancesAdmin = "/api/admin/seances";
        public static readonly string UsersAdmin = "/api/admin/users/";
    }
}