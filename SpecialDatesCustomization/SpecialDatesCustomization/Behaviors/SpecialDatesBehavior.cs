using Syncfusion.Maui.Calendar;

namespace SpecialDatesCustomization
{
    /// <summary>
    /// Behavior to customize special dates in the SfCalendar control.
    /// </summary>
    internal class SpecialDatesBehavior : Behavior<ContentPage>
    {
        private SfCalendar calendar;

        /// <summary>
        /// Called when the behavior is attached to a ContentPage.
        /// </summary>
        /// <param name="bindable">The ContentPage to which the behavior is attached.</param>
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);

            // Find the SfCalendar control by name.
            calendar = bindable.FindByName<SfCalendar>("calendar");

            // Define the special day predicate to customize icons and colors for specific dates.
            calendar.MonthView.SpecialDayPredicate = (date) =>
            {
                if (date.Date == DateTime.Now.AddDays(2).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails
                    {
                        Icon = CalendarIcon.Dot,
                        Fill = Colors.Red
                    };
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(3).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails
                    {
                        Icon = CalendarIcon.Triangle,
                        Fill = Colors.Blue
                    };
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(4).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails
                    {
                        Icon = CalendarIcon.Square,
                        Fill = Colors.Green
                    };
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(5).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails
                    {
                        Icon = CalendarIcon.Heart,
                        Fill = Colors.Red
                    };
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(6).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails
                    {
                        Icon = CalendarIcon.Diamond,
                        Fill = Colors.Blue
                    };
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(7).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails
                    {
                        Icon = CalendarIcon.Bell,
                        Fill = Colors.Black
                    };
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(8).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails
                    {
                        Icon = CalendarIcon.Star,
                        Fill = Colors.Green
                    };
                    return iconDetails;
                }

                return null;
            };
        }

        /// <summary>
        /// Called when the behavior is detached from a ContentPage.
        /// </summary>
        /// <param name="bindable">The ContentPage from which the behavior is detached.</param>
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);

            // Clean up the special day predicate and release the calendar reference.
            if (calendar != null)
            {
                calendar.MonthView.SpecialDayPredicate = null;
                calendar = null;
            }
        }
    }
}
