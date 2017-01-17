using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Movement
    {
        private Panel[,] area = new Panel[6,3];
        private int areaX = 0, areaY = 0;
        
        void Update()
        {
            
            if (Input.GetKey(KeyCode.W))
            {
                areaY++;
            }
            if (Input.GetKey(KeyCode.S))
            {
                areaY--;
            }

            if (Input.GetKey(KeyCode.D))
            {
                areaX++;
            }
            if (Input.GetKey(KeyCode.A))
            {
                areaX--;
            }
        }
    }
}


