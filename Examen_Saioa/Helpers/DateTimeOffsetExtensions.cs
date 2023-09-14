namespace Helpers
{
    public static class DateTimeOffsetExtensions
    {
        public static int GetCurrentAge(this DateTime dateTime)
        {
            int age = 0; // Valor predeterminado

            if (dateTime != null)
            {
                var currentDate = DateTime.UtcNow;
                age = currentDate.Year - dateTime.Year;

                if (currentDate < dateTime.AddYears(age))
                {
                    age--;
                }
            }

            return age;
        }
    }
}

