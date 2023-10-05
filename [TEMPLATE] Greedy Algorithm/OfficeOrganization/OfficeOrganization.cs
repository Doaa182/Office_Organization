using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    public static class OfficeOrganization
    {
        #region YOUR CODE IS HERE
        /// <summary>
        /// find the minimum costs in MOST EFFICIENT WAY to organize your office to meet your father needs.
        /// </summary>
        /// <param name="N">initial load</param>
        /// <param name="M">target load required by your father</param>
        /// <param name="A">cost of reducing the load by half</param>
        /// <param name="B">cost of reducing the load by 1</param>
        /// <returns>Min total cost to reduce the load from N to M</returns>
        public static int OrganizeTheOffice(int N, int M, int A, int B)
        {
            //REMOVE THIS LINE BEFORE START CODING
            //throw new NotImplementedException();




                double remainSteps = (double)N, min = 0, minn = 0, minnn = 0, steps = 0, oo = 0, s = 0, rr = 0, ctr = 0;

                if (M != 0) { steps = Math.Floor(Math.Log(N / M, 2)); }
                else if (M == 0) { steps = Math.Ceiling(Math.Log(N, 2)); }

                while (A <= (remainSteps - Math.Floor(remainSteps / 2)) * B && remainSteps > M /*&& steps > 0*/)
                {


                    double floor = (remainSteps / 2);


                    remainSteps = Math.Floor(remainSteps / 2);
                    if (remainSteps >= M) { min = min + A; }
                    //steps--;
                    //Console.WriteLine("steps  " + steps);
                    //Console.WriteLine("min in method1  " + min);

                    if (remainSteps < M)
                    {
                        min = min + ((floor * 2) - M) * B;
                        //Console.WriteLine("min in method11  " + min);
                    }

                }
               

                if (A > (remainSteps - Math.Floor(remainSteps / 2)) * B && remainSteps > M)
                {

                    min = min + (remainSteps - M) * B;
                    //Console.WriteLine("min in method2  " + min);
                    //Console.WriteLine("remainSteps  " + (remainSteps - M) * B);

                }


            //Console.WriteLine((int)min);
           return (int)min;
        }



















        
    







        #endregion
    }
}

















