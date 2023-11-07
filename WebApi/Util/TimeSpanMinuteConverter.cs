namespace WebApi.Util
{
    public static class TimeSpanMinuteConverter
    {
        public static int TotalMinutes(this TimeSpan time)
        {
            return time.Minutes + time.Hours * 60;
        }
    }
}
