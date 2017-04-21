//Eric Smith
//Compass angle calculation


using System;

class CompassAngle
{

    public static void Main()
    {
        double distance; 
        double angle;

        double y = userLat - savedLat;
        double x = userLong - savedLong;
        distance = Math.Pow(y,2.0) + Math.Pow(x,2.0);

        double dLat = Math.Abs(userLat - savedLat);
        
        dLat = Math.Pow(dLat,2.0);  //remove this line if sqrt is used in distance calc
        //maintains the ratio for arcsin

        double ratio = dLat / distance;
        angle = Math.Asin(ratio);
        angle = angle * 180/Math.PI;    //convert from radians to degrees
    }
}
