using System;
using System.Collections.Generic;
using System.Text;

namespace CNC_Milling_Machine
{
    class Machine
    {
        private int[,] blank = new int[Constants.BlankSizeX, 
            Constants.BlankSizeY];
        private int pos_x = 0, pos_y = 0, pos_z = Constants.BlankSizeZ;

        public Machine()
        {
            for(var i = 0; i < 10; i++)
            for (var j = 0; j < 20; j++)
                blank[i, j] = Constants.BlankSizeZ;
        }

        public int[,] GetBlank()
        {
            return blank;
        }

        public void GetPosition(out int xPos, out int yPos, out int zPos)
        {
            xPos = pos_x;
            yPos = pos_y;
            zPos = pos_z;
        }

        public void StepXPos()
        {
            if (pos_x >= Constants.BlankSizeX)
            {
                pos_x = Constants.BlankSizeX;
                return;
            }

            blank[pos_x, pos_y] = Math.Min(pos_z, 
                blank[pos_x, pos_y]);

            if (blank[pos_x, pos_y] < 0)
                blank[pos_x, pos_y] = 0;

            pos_x++;
        }

        public void ResetXPosition(int pos = 0)
        {
            pos_x = pos;
        }

        public void StepYPos()
        {
            if (pos_y >= Constants.BlankSizeY - 1)
            {
                pos_y = Constants.BlankSizeY - 1;
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

        public void SetZPosition(int pos)
        {
            if(pos < 0 || pos > Constants.BlankSizeZ)
                return;

            pos_z = pos;
        }

        public void Reset()
        {
            for(var i = 0; i < Constants.BlankSizeX; i++)
            for(var j = 0; j < Constants.BlankSizeY; j++)
                blank[i, j] = Constants.BlankSizeZ;

            pos_x = 0;
            pos_y = 0;
            pos_z = Constants.BlankSizeZ;
        }

        //public void StepZPos()
        //{
        //    if (pos_z >= Constants.BlankSizeZ)
        //    {
        //        pos_z = Constants.BlankSizeZ;
        //        return;
        //    }

        //    pos_z++;
        //}

        //public void StepZNeg()
        //{
        //    if (pos_z <= 0)
        //    {
        //        pos_z = 0;
        //        return;
        //    }

        //    pos_z--;
        //}
    }

    static class Constants
    {
        public static int BlankSizeX = 10;
        public static int BlankSizeY = 20;
        public static int BlankSizeZ = 5;
    } 
}
