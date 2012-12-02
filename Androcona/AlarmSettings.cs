using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Androcona
{
    class AlarmSettings
    {
        public aType type;
        public enum aType
        {
            Alarm,
            Chime
        }
        public DateTime time;
        public string description;
        public bool notifyMessageBox;
        public TimeSpan chimeInterval;
        public DateTime chimeEndTime;
        public string soundPath;
        public bool playSound;
    }
}
