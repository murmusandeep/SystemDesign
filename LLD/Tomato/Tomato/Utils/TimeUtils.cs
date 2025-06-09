namespace Tomato.Utils
{
    public static class TimeUtils
    {
        public static string GetCurrentTime()
        {
            return DateTime.Now.ToString("ddd MMM dd HH:mm:ss yyyy");
        }
    }
}
