using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Androcona
{
    class AlarmSettings
    {
        public DateTime time;
        public string description;
        public enum aType
        {
            Alarm,
            Chime
        }
        public aType type;
    }
}
