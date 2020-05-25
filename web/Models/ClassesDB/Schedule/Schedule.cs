using System;

namespace Solare.Models
{
    public class Schedule
    {
        public override string ToString()
        {
            return string.Format(
                "ScheduleId={0} Type={1] Date={2} Time={3} CustomerId={4}",
                _scheduleId,
                _type,
                _date,
                _time,
                _customerId);
        }

        int _scheduleId;
        public int ScheduleId
        {
            get => _scheduleId;
            set => _scheduleId = value;
        }

        SchedulingSituation _type;
        public SchedulingSituation Type
        {
            get => _type;
            set => _type = value;
        }

        DateTime _date;
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        DateTime _time;
        public DateTime Time
        {
            get => _time;
            set => _time = value;
        }

        int _customerId;
        public int CustomerId
        {
            get => _customerId;
            set => _customerId = value;
        }
    }
}