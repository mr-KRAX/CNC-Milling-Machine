﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CNC_Milling_Machine
{
    class Machine
    {
        private int[,] blank = new int[Constants.BlankSizeX, 
            Constants.BlankSizeY];
        private int pos_x = 0, pos_y = 0, pos_z = Constants.BlankSizeZ;

        Machine()
        {
            for(var i = 0; i < 10; i++)
            for (var j = 0; j < 20; j++)
                blank[i, j] = Constants.BlankSizeZ;
        }

        public int[,] GetBlank()
        {
            return blank;
        }

        public void GetPos(out int xPos, out int yPos, out int zPos)
        {
            xPos = pos_x;
            yPos = pos_y;
            zPos = pos_z;
        }

        public void StepXPos()
        {
            // todo
        }

        public void StepXNeg()
        {
            // todo
        }

        public void StepYPos()
        {
            if (pos_y >= Constants.BlankSizeY)
            {
                pos_y = Constants.BlankSizeY;
                return;
            }

            pos_y++;
        }

        public void StepYNeg()
        {
            if (pos_y <= 0)
            {
                pos_y = 0;
                return;
            }

            pos_y--;
        }

        public void StepZPos()
        {
            if (pos_z >= Constants.BlankSizeZ)
            {
                pos_z = Constants.BlankSizeZ;
                return;
            }

            pos_z++;
        }

        public void StepZNeg()
        {
            if (pos_z <= 0)
            {
                pos_z = 0;
                return;
            }

            pos_z--;
        }
    }

    static class Constants
    {
        public static int BlankSizeX = 10;
        public static int BlankSizeY = 20;
        public static int BlankSizeZ = 5;
    } 
}