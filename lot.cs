//Eric Smith
//Senior Seminar
//Section 1 Group 7
//Team: Go Park Yourself!
//Filename: lot.cs

//www.latlong.net  to refine coordinates

float llA = -119.105800F;    //left  longitude lot A
float rlA = -119.104850F;    //right longitude lot A
float utA =   35.353700F;    //upper latitude  lot A
float ltA =   35.352700F;    //lower latitude  lot A

float llB = -119.104850F;    //left  longitude lot B
float rlB = -119.104300F;    //right longitude lot B
float utB =   35.353700F;    //upper latitude  lot B
float ltB =   35.352800F;    //lower latitude  lot B

float llC = -119.104850F;    //left  longitude lot C
float rlC = -119.104300F;    //right longitude lot C
float utC =   35.352800F;    //upper latitude  lot C
float ltC =   35.351500F;    //lower latitude  lot C

float llD = -119.103900F;    //left  longitude lot D
float rlD = -119.102200F;    //right longitude lot D
float utD =   35.352150F;    //upper latitude  lot D
float ltD =   35.351650F;    //lower latitude  lot D

float llE = -119.109700F;    //left  longitude lot E
float rlE = -119.108450F;    //right longitude lot E
float utE =   35.350400F;    //upper latitude  lot E
float ltE =   35.349400F;    //lower latitude  lot E

float llF = -119.106600F;    //left  longitude lot F
float rlF = -119.105300F;    //right longitude lot F
float utF =   35.350400F;    //upper latitude  lot F
float ltF =   35.349400F;    //lower latitude  lot F

float llG = -119.105950F;    //left  longitude lot G
float rlG = -119.105500F;    //right longitude lot G
float utG =   35.349250F;    //upper latitude  lot G
float ltG =   35.348000F;    //lower latitude  lot G

float llH = -119.105150F;    //left  longitude lot H
float rlH = -119.103300F;    //right longitude lot H
float utH =   35.347100F;    //upper latitude  lot H
float ltH =   35.345900F;    //lower latitude  lot H

float llI = -119.103150F;    //left  longitude lot I
float rlI = -119.101600F;    //right longitude lot I
float utI =   35.347100F;    //upper latitude  lot I
float ltI =   35.345100F;    //lower latitude  lot I

float llJ = -119.100650F;    //left  longitude lot J
float rlJ = -119.100150F;    //right longitude lot J
float utJ =   35.354000F;    //upper latitude  lot J
float ltJ =   35.352250F;    //lower latitude  lot J

float llK1 = -119.100700F;   //left  longitude lot K1
float rlK1 = -119.100200F;   //right longitude lot K1
float utK1 =   35.352250F;   //upper latitude  lot K1
float ltK1 =   35.350500F;   //lower latitude  lot K1

float llK2 = -119.100700F;   //left  longitude lot K2
float rlK2 = -119.098350F;   //right longitude lot K2
float utK2 =   35.350950F;   //upper latitude  lot K2
float ltK2 =   35.350450F;   //lower latitude  lot K2

float llL = -119.098300F;    //left  longitude lot L
float rlL = -119.097000F;    //right longitude lot L
float utL =   35.351000F;    //upper latitude  lot L
float ltL =   35.350500F;    //lower latitude  lot L

float llM = -119.101850F;    //left  longitude lot M
float rlM = -119.101200F;    //right longitude lot M
float utM =   35.351250F;    //upper latitude  lot M
float ltM =   35.350500F;    //lower latitude  lot M

//cut the map into sections
float lat_1  =   35.350400F; //first cut
float lng_01 = -119.102100F; //01 is group less than lat_1
float lng_11 = -119.105200F; //11 is group grtr than lat_1


float userLng;  //split user GPS coordinates
float userLat;  //to latitude and longitude


if ( userLat < lat_1)   //lot E F G H I
{
    if ( userLng < lng_01 ) //lot E F G
    {
        if ( (userLng >= llE) && (userLng <= rlE) &&
                (userLat >= ltE) && (userLat <= utE)   ) 
        {
        }

        else if ( (userLng >= llF) && (userLng <= rlF) &&
                (userLat >= ltF) && (userLat <= utF)   ) 
        {
        }

        else if ( (userLng >= llG) && (userLng <= rlG) &&
                (userLat >= ltG) && (userLat <= utG)   ) 
        {
        }
    }

    else    //lot H I
    {
        if ( (userLng >= llH) && (userLng <= rlH) &&
                (userLat >= ltH) && (userLat <= utH)   ) 
        {
        }

        else if ( (userLng >= llI) && (userLng <= rlI) &&
                (userLat >= ltI) && (userLat <= utI)   ) 
        {
        }
    }
}

else    //lot A B C D J K1 K2 L M
{
    if ( userLng < lng_11 ) //lot A B C D
    {
        if ( (userLng >= llA) && (userLng <= rlA) &&
                (userLat >= ltA) && (userLat <= utA)   ) 
        {
        }

        else if ( (userLng >= llB) && (userLng <= rlB) &&
                (userLat >= ltB) && (userLat <= utB)   ) 
        {
        }

        else if ( (userLng >= llC) && (userLng <= rlC) &&
                (userLat >= ltC) && (userLat <= utC)   ) 
        {
        }

        else if ( (userLng >= llD) && (userLng <= rlD) &&
                (userLat >= ltD) && (userLat <= utD)   ) 
        {
        }
    }

    else    //lot J K1 K2 L M
    {
        if ( (userLng >= llJ) && (userLng <= rlJ) &&
                (userLat >= ltJ) && (userLat <= utJ)   ) 
        {
        }

        else if ( (userLng >= llK1) && (userLng <= rlK1) &&
                (userLat >= ltK1) && (userLat <= utK1)   ) 
        {
        }

        else if ( (userLng >= llK2) && (userLng <= rlK2) &&
                (userLat >= ltK2) && (userLat <= utK2)   ) 
        {
        }

        else if ( (userLng >= llL) && (userLng <= rlL) &&
                (userLat >= ltL) && (userLat <= utL)   ) 
        {
        }

        else if ( (userLng >= llM) && (userLng <= rlM) &&
                (userLat >= ltM) && (userLat <= utM)   ) 
        {
        }
    }
}
