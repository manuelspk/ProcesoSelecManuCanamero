using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame.KartSystems
{
    /// <summary>
    /// A basic touchscreen implementation of the IInput interface for all the input information a kart needs.
    /// </summary>
    public class TouchInput : MonoBehaviour, IInput
    {
        public float Acceleration
        {
            get { return m_Acceleration; }
        }
        public float Steering
        {
            get { return m_Steering; }
        }
        public bool BoostPressed
        {
            get { return m_BoostPressed; }
        }
        public bool FirePressed
        {
            get { return m_FirePressed; }
        }
        public bool HopPressed
        {
            get { return m_HopPressed; }
        }
        public bool HopHeld
        {
            get { return m_HopHeld; }
        }

        float m_Acceleration;
        float m_Steering;
        bool m_HopPressed;
        bool m_HopHeld;
        bool m_BoostPressed;
        bool m_FirePressed;

        bool m_FixedUpdateHappened;

        public Joystick joystick;

        void Update()
        {

            m_Acceleration = joystick.Vertical;

            m_Steering = joystick.Horizontal;

            m_HopHeld = Input.GetButton("Hop");

            m_HopHeld = Input.GetKey(KeyCode.Space);

            if (m_FixedUpdateHappened)
            {
                m_FixedUpdateHappened = false;

                m_HopPressed = false;
                m_BoostPressed = false;
                m_FirePressed = false;
            }

            m_HopPressed |= Input.GetKeyDown(KeyCode.Space);
            m_BoostPressed |= Input.GetKeyDown(KeyCode.RightShift);
            m_FirePressed |= Input.GetKeyDown(KeyCode.RightControl);
        }

        void FixedUpdate()
        {
            m_FixedUpdateHappened = true;
        }


    }
}