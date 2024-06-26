namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        int n = points.Length;

        // Check if pit is found
        if (n < 3)
        {
            return -1;
        }

        int deepestPit = -1;
        int P = 0, Q = -1, R = -1;

        for (int i = 1; i < n; i++)
        {
            // Finding the start of the decreasing sequence
            if (Q == -1 && points[i] < points[i - 1])
            {
                Q = i;
            }
            // Finding the end of the decreasing sequence and the start of the increasing sequence
            else if (Q != -1 && points[i] > points[i - 1])
            {
                R = i;

                if (P < Q && Q < R && points[P] > points[Q] && points[Q] < points[R])
                {
                    int depth = Math.Min(points[P] - points[Q], points[R] - points[Q]);
                    deepestPit = Math.Max(deepestPit, depth);
                }

                P = Q = -1;
                // If pit is found move back to check for more pits
                i--;  
            }
            // set default if pit is invalid
            else if (points[i] >= points[i - 1])
            {
                P = i;
                Q = R = -1; 
            }
        }

        return deepestPit;
    }
}
