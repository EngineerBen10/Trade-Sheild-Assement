namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {   
        int n = points.Length;

        //check if pit is found
         if(n < 3) { return -1; }

        int depestpit = -1;
        int P = 0; //above ground
        int Q = -1;
        int R = -1;

        for(int i = 0; i < points.Length; i++)
        {
             // start decreasing 
             if (Q == -1 && points[i] < points[i - 1])
            {
                Q = i;
            }

             //start increasing
             if (R == -1 && points[i]> points[i -1])
            {
                R = i;
            }
        }


        throw new NotImplementedException("Not completed yet");
    }
}
