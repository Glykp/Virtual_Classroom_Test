using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cinemachine;
using UnityEngine;

namespace Test
{

    [RequireComponent(typeof(CinemachineFreeLook))]
    class ZoomingFunction : MonoBehaviour
    {
        static float t = 0.0f;

        private CinemachineFreeLook freelook;
        private CinemachineFreeLook.Orbit[] originalOrbits;

        public float ScrollScale = 0.0001f;
        //[Range(0.0F, 1F)]
        public float zoomPercent = 0.0f;
        //public float zoomPercentOld = 0.0f;
        //public float zoomPercentNew = 0.0f;
        public void Awake()
        {
            zoomPercent = 1.0f;

        freelook = GetComponentInChildren<CinemachineFreeLook>();
            originalOrbits = new CinemachineFreeLook.Orbit[freelook.m_Orbits.Length];


            for (int i = 0; i < freelook.m_Orbits.Length; i++)
            {
                originalOrbits[i].m_Height = freelook.m_Orbits[i].m_Height;
                originalOrbits[i].m_Radius = freelook.m_Orbits[i].m_Radius;
            }
        }

        public void Update()
        {
            //zoomPercentOld = zoomPercent;

            zoomPercent -= Input.mouseScrollDelta.y * ScrollScale;

            //zoomPercent = Mathf.Lerp(zoomPercentOld, zoomPercentNew, t);

            for (int i = 0; i < freelook.m_Orbits.Length; i++)
            {
                //freelook.m_Orbits[i].m_Height = originalOrbits[i].m_Height * zoomPercent;
                freelook.m_Orbits[i].m_Radius = originalOrbits[i].m_Radius * zoomPercent;
            }

            t += 0.5f * Time.deltaTime;

        }
    }
}