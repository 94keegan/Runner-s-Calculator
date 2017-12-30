using System;

namespace Runners_Calculator
{
    class Runner : MainWindow
    {
        // Instance variables
        public double TimeHours { get; set; }
        public double TimeMinutes { get; set; }
        public double TimeSeconds { get; set; }
        public double PaceHours { get; set; }
        public double PaceMinutes { get; set; }
        public double PaceSeconds { get; set; }
        public double Distance { get; set; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public Runner()
        {
            TimeHours = 0;
            TimeMinutes = 0;
            TimeSeconds = 0;
            PaceHours = 0;
            PaceMinutes = 0;
            PaceSeconds = 0;
            Distance = 0;
        }

        /// <summary>
        ///  Calculate the time from hours, minutes, seconds into seconds
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public double CalcSeconds(double hours, double minutes, double seconds)
        {
            hours = hours * 3600;
            minutes *= 60;
            seconds += hours + minutes;
            return seconds;
        }

        /// <summary>
        /// Calculates the time given the distance and pace
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="pace"></param>
        public void CalcTime(double distance, double pace)
        {
            double hours, divisorMinutes, minutes, divisorSeconds, seconds;

            // Convert seconds back into hours, minutes, and seconds
            if(distance == 0)
            {
                hours = 0;
                minutes = 0;
                seconds = 0;
            }
            else
            {
                seconds = pace * distance;
                hours = Math.Floor(seconds / (60 * 60));
                divisorMinutes = seconds % (60 * 60);
                minutes = Math.Floor(divisorMinutes / 60);
                divisorSeconds = divisorMinutes % 60;
                seconds = Math.Ceiling(divisorSeconds);
            }

            TimeHours = hours;
            TimeMinutes = minutes;
            TimeSeconds = seconds;
        }

        /// <summary>
        /// Calculates the distance given the time and pace
        /// </summary>
        /// <param name="time"></param>
        /// <param name="pace"></param>
        public void CalcDistance(double time, double pace)
        {
            if (pace == 0)
            {
                Distance = 0;
            }
            else
            {
                Distance = time / pace;
            }
        }

        /// <summary>
        /// Calculates the pace given the time and distance
        /// </summary>
        /// <param name="time"></param>
        /// <param name="distance"></param>
        public void CalcPace(double time, double distance)
        {
            double hours, divisorMinutes, minutes, divisorSeconds, seconds;

            if (distance == 0)
            {
                distance = 0;
            }
            else
            {
                if(distance < 1)
                {
                    PaceSeconds = time * distance;
                }
                else
                {
                    PaceSeconds = time / distance;
                }
            }

            // Convert seconds back into hours, minutes, and seconds
            seconds = PaceSeconds;
            hours = Math.Floor(seconds / (60 * 60));
            divisorMinutes = seconds % (60 * 60);
            minutes = Math.Floor(divisorMinutes / 60);
            divisorSeconds = divisorMinutes % 60;
            seconds = Math.Ceiling(divisorSeconds);

            PaceHours = hours;
            PaceMinutes = minutes;
            PaceSeconds = seconds;
        }
    }
}