namespace Core.Util
{
    public static class TimeSpanDateTimeConverter
    {
        public static DateTime ToDateTime(this TimeSpan time)
        {
            return new DateTime(0, DateTimeKind.Local).Add(time);
        }
    }
}
