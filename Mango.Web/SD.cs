namespace Mango.Web
{
    public static class SD
    {
        public static string ServerAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
