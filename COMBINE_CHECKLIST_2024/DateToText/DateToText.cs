using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace COMBINE_CHECKLIST_2024.DateToText
{
    class Datetotext
    {

        public Datetotext() { }

        public string getMonthAsText(DateTime date)
        {
            switch (date.Month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "";
            }
        }
        public string getMonthAsShortText(DateTime date)
        {
            switch (date.Month)
            {
                case 1: return "Jan";
                case 2: return "Feb";
                case 3: return "Mar";
                case 4: return "Apr";
                case 5: return "May";
                case 6: return "Jun";
                case 7: return "Jul";
                case 8: return "Aug";
                case 9: return "Sep";
                case 10: return "Oct";
                case 11: return "Nov";
                case 12: return "Dec";
                default: return "";
            }
        }
        public string getTime12HoursPreset(DateTime date)
        {
            int hour = date.Hour > 12? date.Hour - 12 : date.Hour;
            hour = hour == 0 ? 12 : hour;
            int minute = date.Minute;
            string hourString = hour < 10 ? "0" + hour.ToString() : hour.ToString();
            string minuteString = minute < 10 ? "0" + minute.ToString() : minute.ToString();
            string AMorPM = date.Hour > 11 ? "PM" : "AM";
            return hourString + ":" + minuteString + AMorPM;

        }

        public string getMinutes(DateTime date)
        {
            return date.Minute.ToString();
        }

        public int getMonth(string month)
        {
            switch (month.ToUpper())
            {
                case "JAN":
                    return 1;
                case "FEB":
                    return 2;
                case "MAR":
                    return 3;
                case "APR":
                    return 4;
                case "MAY":
                    return 5;
                case "JUN":
                    return 6;
                case "JUL":
                    return 7;
                case "AUG":
                    return 8;
                case "SEPT":
                    return 9;
                case "OCT":
                    return 10;
                case "NOV":
                    return 11;
                case "DEC":
                    return 12;
            }
            return 1;
        }
        public string getHour_12HoursPreset(DateTime date)
        {
            int hour = date.Hour > 12 ? date.Hour - 12 : date.Hour;
            hour = hour == 0 ? 12 : hour;
            return hour.ToString();
        }
    }
}
