namespace CsharpNewFunctions.NewFunctions
{
    public class New_OutVar
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public void GetCoordinate(out int x, out int y)
            {
                x = X;
                y = Y;
            }
        }
    }
}
