using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac21
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        public Time(int value)
        {
            hours = value;
            minutes = value;
            seconds = value;
        }

        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = 0;
        }

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public string GetInfo()
        {
            return $"Часы: {hours}, Минуты: {minutes}, Секунды: {seconds}";
        }

        public int CalculateTotalMinutes()
        {
            return hours * 60 + minutes;
        }

        public int CalculateTotalSeconds()
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }
    }
}

