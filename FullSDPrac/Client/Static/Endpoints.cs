namespace FullSDPrac.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";
        public static readonly string TaskItemsEndpoint = $"{Prefix}/taskitems";
        public static readonly string UsersEndpoint = $"{Prefix}/users";
        public static readonly string ManagersEndpoint = $"{Prefix}/managers";
    }
}
