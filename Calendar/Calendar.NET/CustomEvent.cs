using System;
using System.Drawing;

namespace Calendar.NET
{
    /// <summary>
    /// A custom or user-defined event
    /// </summary>
    public class CustomEvent : IEvent
    {
        public int Rank
        {
            get;
            set;
        }

        public float EventLengthInHours
        {
            get;
            set;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public CustomRecurringFrequenciesHandler CustomRecurringFunction
        {
            get;
            set;
        }

        public bool IgnoreTimeComponent
        {
            get;
            set;
        }

        public bool ReadOnlyEvent
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public Color EventColor
        {
            get;
            set;
        }

        public Font EventFont
        {
            get;
            set;
        }

        public string EventText
        {
            get;
            set;
        }

        public Color EventTextColor
        {
            get;
            set;
        }

        public RecurringFrequencies RecurringFrequency
        {
            get;
            set;
        }

        public bool TooltipEnabled
        {
            get;
            set;
        }

        public int ProjectId
        {
            get;
            set;
        }

        public int InsertId
        {
            get;
            set;
        }

        public bool ThisDayForwardOnly
        {
            get;
            set;
        }

        /// <summary>
        /// CustomEvent Constructor
        /// </summary>
        public CustomEvent()
        {
            EventColor = Color.FromArgb(40, 150, 50);
            EventFont = new Font("Arial", 11, FontStyle.Bold);
            EventTextColor = Color.FromArgb(255, 255, 255);
            Rank = 2;
            EventLengthInHours = 1.0f;
            ReadOnlyEvent = false;
            Enabled = true;
            IgnoreTimeComponent = false;
            TooltipEnabled = true;
            ProjectId = 0;
            InsertId = 0;
            ThisDayForwardOnly = true;
            RecurringFrequency = RecurringFrequencies.None;
        }

        public IEvent Clone()
        {
            return new CustomEvent
            {
                CustomRecurringFunction = CustomRecurringFunction,
                Date = Date,
                Enabled = Enabled,
                EventColor = EventColor,
                EventFont = EventFont,
                EventText = EventText,
                EventTextColor = EventTextColor,
                IgnoreTimeComponent = IgnoreTimeComponent,
                Rank = Rank,
                ReadOnlyEvent = ReadOnlyEvent,
                RecurringFrequency = RecurringFrequency,
                ThisDayForwardOnly = ThisDayForwardOnly,
                EventLengthInHours = EventLengthInHours,
                TooltipEnabled = TooltipEnabled
            };
        }
    }
}
