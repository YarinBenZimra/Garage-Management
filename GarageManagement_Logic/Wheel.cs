using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagement_Logic
{
    public class Wheel
    {

        private string m_ManufacturerName;
        private float m_CurrentAirPressure;
        private float m_MaxAirPressure;

        public string ManufacturerName
        {
            get { return m_ManufacturerName; }

            set
            {
                if ((value.ToString())[0] == ' ')
                {
                    throw new Exception(string.Format("Invalid Name!{0}{0}", Environment.NewLine));
                }

                m_ManufacturerName = value;
            }
        }

        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }

            set
            {
                if (value <= 0)
                {
                    throw new ValueOutOfRangeException(m_MaxAirPressure, 0, string.Format("The value is out of range, the amount of air pressure must be positive.{0}{0}", Environment.NewLine));
                }

                if (value > m_MaxAirPressure)
                {
                    throw new ValueOutOfRangeException(m_MaxAirPressure, 0, string.Format("The amount of the air pressure can not exceed {1}{0}{0}", m_MaxAirPressure));
                }

                m_CurrentAirPressure = value;
            }
        }

        public float MaxAirPressure
        {
            get { return m_MaxAirPressure; }
        }


        public Wheel(string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            m_MaxAirPressure = i_MaxAirPressure;
            ManufacturerName = i_ManufacturerName;
            CurrentAirPressure = i_CurrentAirPressure;
        }

        public void Inflate(float airPressure)
        {
            CurrentAirPressure += airPressure;
        }

        public override string ToString()
        {
            string message = string.Format("Manufacturer Name: {1}{0}Current Air Pressure: {2}{0}Max Air Pressure: {3}{0}{0}"
                                            , Environment.NewLine, m_ManufacturerName, m_CurrentAirPressure, m_MaxAirPressure);
            return message;
        }
    }
}
