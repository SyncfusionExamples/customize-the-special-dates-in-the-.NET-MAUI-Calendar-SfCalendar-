namespace SpecialDatesCustomization
{
    public class CalendarViewModel
    {
        public List<DateTime> SpecialDatesList { get; set; }

        public CalendarViewModel()
        {
            this.SpecialDatesList = new List<DateTime>()
            {
                DateTime.Now.AddDays(3),
                DateTime.Now.AddDays(6),
                DateTime.Now.AddDays(8),
                DateTime.Now.AddDays(-2),
                DateTime.Now.AddDays(-4),
                DateTime.Now.AddDays(-6),
            };
        }
    }
}
