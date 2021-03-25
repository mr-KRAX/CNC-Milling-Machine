using System;
using System.Collections.Generic;
using System.Text;

namespace CNC_Milling_Machine
{
    class Controller
    {
        Machine machine;
        private int Xstart;
        private int Ystart;
        private int Xsize;
        private int Ysize;
        private int Zlevel;
        Task task;

        public Controller(Machine machine)
        {
            this.machine = machine;
            task = new Task();
            // todo
        }

        // Searching max of array
        // -1 if bounds are bad
        public int getMaxOfArray(int[,] array, int Xbeg, int Ybeg, int Xmax, int Ymax)
        {
            int max = -1;
            int normXmax = Math.Min(Xmax, Constants.BlankSizeX);
            int normYmax = Math.Min(Ymax, Constants.BlankSizeY);

            for (int i = Xbeg; i < normXmax; i++)
                for(int j = Ybeg; j < normYmax; j++)
                    if (array[i, j] > max)
                        max = array[i, j];
            return max;
        }

        // Fills task parameters with right bounds check 
        public void setTask(int Xstart, int Ystart, int Xsize, int Ysize, int Zlevel)
        {
            this.Xstart = Xstart;
            this.Ystart = Ystart;
            this.Xsize = Math.Min(Xsize, Constants.BlankSizeX - Xstart);
            this.Ysize = Math.Min(Ysize, Constants.BlankSizeY - Ystart);
            this.Zlevel = Zlevel;
            task.x = Xstart;
            task.y = Ystart;
            task.z = getMaxOfArray(machine.GetBlank(), Xstart, Ystart, Xsize, Ysize);
        }

        //public void removeTask()
        //{
        //  //may be
        //}

        // runns task, returning false each time, excepting last one
        public bool runTask()
        {
            while (task.z > Zlevel)
            {
                if (task.movingDown)
                {
                    if(task.y < Ysize)
                    {
                        if (task.x < Xsize)
                        {
                            machine.StepXPos();
                            task.x += 1;
                            return false;
                        }
                        machine.ResetXPosition();

                        if (task.y != Ysize - 1)
                            machine.StepYPos();

                        task.x = Xstart;
                        task.y += 1;
                    }
                }
                else
                {
                    if (task.y >= Ystart)
                    {
                        if (task.x < Xsize)
                        {
                            machine.StepXPos();
                            task.x += 1;
                            return false;
                        }
                        machine.ResetXPosition();

                        if(task.y != Ystart)
                            machine.StepYNeg();

                        task.x = Xstart;
                        task.y -= 1;
                    }
                }

                task.movingDown = !task.movingDown;
                if (task.z == Zlevel + 1)
                    return true;
                task.z -= 1;
            }
            return true;
        }

    }
}
