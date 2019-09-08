using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Timer
    {
        private float _time;
        private float _interval;

        public float Interval { get => _interval; set => _interval = value; }
        public float Time { get => _time; set => _time = value; }

        public Timer(float interval)
        {
            _time = 0;
            _interval = interval;
        }

        public void Tick()
        {
            if (_time < _interval)
            {
                _time++;
            }
           
        }

        public bool Check()
        {
            if (_time >= _interval)
            {
                return true;
            }
            else
                return false;
        }

    }
}
