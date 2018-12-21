namespace Polygons
{
    public static class PolygonField
    {
        public static float CalculateField(Point pointOne, Point pointTwo)
        {
            /*
             
            1/2 * ( y1 + y2) * ( x1 - x2 ) = SUMA
            
            */
            return (0.5f * ((float) pointOne.Y + (float) pointTwo.Y) * ( (float) pointOne.X - (float) pointTwo.X));
        }
    }
}