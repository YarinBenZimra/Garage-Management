using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagement_Logic
{
    public class VehicleInGarage
    {
        private Vehicle m_Vehicle = null;
        private eVehicleState m_VehicleState;
        private string m_OwnerName;
        private string m_OwnerPhone;

        public enum eVehicleState
        {
            UnderRepair = 1,
            Repaired,
            Paid
        }

        public Vehicle Vehicle
        {
            get
            {
                return m_Vehicle;
            }

            set
            {
                m_Vehicle = value;
            }
        }

        public string OwnerName
        {
            get { return m_OwnerName; }

            set
            {
                if ((value.ToString())[0] == ' ')
                {
                    throw new Exception(string.Format("Invalid Name!{0}{0}", Environment.NewLine));
                }

                m_OwnerName = value;
            }
        }

        public string OwnerPhone
        {
            get { return m_OwnerPhone; }

            set
            {
                if ((value.ToString())[0] == ' ')
                {
                    throw new Exception(string.Format("Invalid Phone!{0}{0}", Environment.NewLine));
                }

                m_OwnerPhone = value;
            }
        }

        public eVehicleState VehicleState
        {
            get { return m_VehicleState; }

            set
            {
                if (value != eVehicleState.UnderRepair && value != eVehicleState.Repaired && value != eVehicleState.Paid)
                {
                    throw new Exception(string.Format("The vehicle state should be one of the following vehicle states: {1}, {2}, {3}{0}{0}",
                       Environment.NewLine, eVehicleState.Paid, eVehicleState.UnderRepair, eVehicleState.Repaired));
                }

                m_VehicleState = value;
            }
        }


        public VehicleInGarage() { }

        public VehicleInGarage(Vehicle i_Vehicle, string i_OwnerName, string i_OwnerPhone, eVehicleState i_State)
        {
            m_Vehicle = i_Vehicle;
            m_OwnerName = i_OwnerName;
            m_OwnerPhone = i_OwnerPhone;
            m_VehicleState = i_State;
        }

        public override string ToString()
        {
            string message = string.Format("**** Vheicle & Owner Details ****{0}{0}Owner Details:{0}{0}Owner Name: {1}{0}Owner Phone: {2}\nVehicle State: {3}\n\n", Environment.NewLine, m_OwnerName, m_OwnerPhone, m_VehicleState);
            return message;
        }
    }
}
