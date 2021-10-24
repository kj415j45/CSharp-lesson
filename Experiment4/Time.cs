using System;

namespace CSharp.Experiemnt4
{
    class Time
    {
        private int _hour;
        public int hour { get => _hour; private set => _hour = value; }
        private int _minute;
        public int minute { get => _minute; private set => _minute = value; }

        private int _second;
        public int second { get => _second; private set => _second = value; }

        public Time()
        {
            DateTime now = DateTime.Now;
            this.hour = now.Hour;
            this.minute = now.Minute;
            this.second = now.Second;
        }

        public Time(int h, int i, int s)
        {
            this.hour = h;
            this.minute = i;
            this.second = s;
        }

        public void Plus1Second()
        {
            this.second++;
            if (this.second == 60)
            {
                this.minute++;
                this.second = 0;
            }
            if (this.minute == 60)
            {
                this.hour++;
                this.minute = 0;
            }
            if (this.hour == 24)
            {
                this.hour = 0;
            }
        }
    }
}