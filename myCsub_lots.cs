//Eric Smith
//Senior Seminar
//Filename: myCsub_lots.cs

//ll = left long, rl = right long
//ut = upper lat, lt = lower lat


using System;

namespace RadialProgressDemo
{
    public class myCsub_lots
    {
        enum GPS : float
        {
            llA = -119.105800F,
            rlA = -119.104850F,
            utA = 35.353700F,
            ltA = 35.352700F,

            llB = -119.104850F,
            rlB = -119.104300F,
            utB = 35.353700F,
            ltB = 35.352800F,

            llC = -119.104850F,
            rlC = -119.104300F,
            utC = 35.352800F,
            ltC = 35.351500F,

            llD = -119.103900F,
            rlD = -119.102200F,
            utD = 35.352150F,
            ltD = 35.351650F,

            llE = -119.109700F,
            rlE = -119.108450F,
            utE = 35.350400F,
            ltE = 35.349400F,

            llF = -119.106600F,
            rlF = -119.105300F,
            utF = 35.350400F,
            ltF = 35.349400F,

            llG = -119.105950F,
            rlG = -119.105500F,
            utG = 35.349250F,
            ltG = 35.348000F,

            llH = -119.105150F,
            rlH = -119.103300F,
            utH = 35.347100F,
            ltH = 35.345900F,

            llI = -119.103150F,
            rlI = -119.101600F,
            utI = 35.347100F,
            ltI = 35.345100F,

            llJ = -119.100650F,
            rlJ = -119.100150F,
            utJ = 35.354000F,
            ltJ = 35.352250F,

            llK1 = -119.100700F,
            rlK1 = -119.100200F,
            utK1 = 35.352250F,
            ltK1 = 35.350500F,

            llK2 = -119.100700F,
            rlK2 = -119.098350F,
            utK2 = 35.350950F,
            ltK2 = 35.350450F,

            llL = -119.098300F,
            rlL = -119.097000F,
            utL = 35.351000F,
            ltL = 35.350500F,

            llM = -119.101850F,
            rlM = -119.101200F,
            utM = 35.351250F,
            ltM = 35.350500F,

            lat_1 = 35.350400F,
            lng_01 = -119.102100F,
            lng_11 = -119.105200F
        };  //end GPS enum

        public string LotDetect(float userLat, float userLng)
        {
            //cut the map into sections
            //first cut down kroll (lat_1)
            //lng_01 cut is for group north of kroll
            //lng_11 cut is for group south of kroll

            string result;

            if (userLat < GPS.lat_1)   //lot E F G H I
            {
                if (userLng < GPS.lng_01) //lot E F G
                {
                    if ((userLng >= GPS.llE) && (userLng <= GPS.rlE) &&
                            (userLat >= GPS.ltE) && (userLat <= GPS.utE))
                    {
                        result = "E";
                    }

                    else if ((userLng >= GPS.llF) && (userLng <= GPS.rlF) &&
                            (userLat >= GPS.ltF) && (userLat <= GPS.utF))
                    {
                        result = "F";
                    }

                    else if ((userLng >= GPS.llG) && (userLng <= GPS.rlG) &&
                            (userLat >= GPS.ltG) && (userLat <= GPS.utG))
                    {
                        result = "G";
                    }
                }

                else    //lot H I
                {
                    if ((userLng >= GPS.llH) && (userLng <= GPS.rlH) &&
                            (userLat >= GPS.ltH) && (userLat <= GPS.utH))
                    {
                        result = "H";
                    }

                    else if ((userLng >= GPS.llI) && (userLng <= GPS.rlI) &&
                            (userLat >= GPS.ltI) && (userLat <= GPS.utI))
                    {
                        result = "I";
                    }
                }
            }   //end if (E F G H I)

            else    //lot A B C D J K1 K2 L M
            {
                if (userLng < GPS.lng_11) //lot A B C D
                {
                    if ((userLng >= GPS.llA) && (userLng <= GPS.rlA) &&
                            (userLat >= GPS.ltA) && (userLat <= GPS.utA))
                    {
                        result = "A";
                    }

                    else if ((userLng >= GPS.llB) && (userLng <= GPS.rlB) &&
                            (userLat >= GPS.ltB) && (userLat <= GPS.utB))
                    {
                        result = "B";
                    }

                    else if ((userLng >= GPS.llC) && (userLng <= GPS.rlC) &&
                            (userLat >= GPS.ltC) && (userLat <= GPS.utC))
                    {
                        result = "C";
                    }

                    else if ((userLng >= GPS.llD) && (userLng <= GPS.rlD) &&
                            (userLat >= GPS.ltD) && (userLat <= GPS.utD))
                    {
                        result = "D";
                    }
                }

                else    //lot J K1 K2 L M
                {
                    if ((userLng >= GPS.llJ) && (userLng <= GPS.rlJ) &&
                            (userLat >= GPS.ltJ) && (userLat <= GPS.utJ))
                    {
                        result = "J";
                    }

                    else if ((userLng >= GPS.llK1) && (userLng <= GPS.rlK1) &&
                            (userLat >= GPS.ltK1) && (userLat <= GPS.utK1))
                    {
                        result = "K1";
                    }

                    else if ((userLng >= GPS.llK2) && (userLng <= GPS.rlK2) &&
                            (userLat >= GPS.ltK2) && (userLat <= GPS.utK2))
                    {
                        result = "K2";
                    }

                    else if ((userLng >= GPS.llL) && (userLng <= GPS.rlL) &&
                            (userLat >= GPS.ltL) && (userLat <= GPS.utL))
                    {
                        result = "L";
                    }

                    else if ((userLng >= GPS.llM) && (userLng <= GPS.rlM) &&
                            (userLat >= GPS.ltM) && (userLat <= GPS.utM))
                    {
                        result = "M";
                    }
                }
            }   //end else (A B C D J K1 K2 L M)
            return result;
        }   //end LotDetect function

        static void Main(string[] argc)
        {
            string lot;
            myCsub_lots x = new myCsub_lots();

            float latitude;     //USER LAT HERE
            float longitude;    //USER LNG HERE

            lot = x.LotDetect(latitude, longitude);

        }   //end main
    }   //end class
}   //end namespace
