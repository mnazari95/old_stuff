package com.douglas.skytrainapp.androidproject.util;

/*
    this is guide on the double array
    each station are catogorized by the first [] of the 2d array
    eg. new westminster is [29][], and granville is [17][]

    CANADA-LINE
    0=waterfront, 1=vancouver city centre, 2=yaletown round house,
    3=olympic village, 4=broadway city hall, 5=king edward, 6=oakridge 41 ave,
    7=langara 49 ave, 8=marine dr, 9=bridgeport, 10=alberdeen, 11=lansdowne,
    12=richmond brighouse, 13=templeton, 14=sea island centre, 15=YVR airport,

    EXPO-LINE
    16=burrard, 17=granville, 18=stadium chinatown, 19=main st science world,
    20=commercial broadway, 21=nanaimo, 22=29 ave, 23=joyce collingwood, 24=patterson,
    25=metrotown, 26=royal oak, 27=edmonds, 28=22 st, 29=new west, 30= columbia,
    31=scott road, 32=gateway, 33=surrey central, 34=king george,

    MILLINIUM-LINE
    35=sapperton,
    36= braid, 37=lougheed, 38=production, 39=lake city, 40=sperling, 41=holdom,
    42=brentwood, 43=gilmore, 44=rupert, 45=renfrew, 46=vcc-clark, 47= commercial-Mill
*/
public class StationLocation {

    private String name;
    private int index;

    public static double[][] sLC = {{49.285981, -123.111572, 1}, {49.282478, -123.118544, 1},
                                    {49.274448, -123.121951, 1}, {49.266623, -123.115566, 1},
                                    {49.262979, -123.114887, 1}, {49.249226, -123.115395, 1},
                                    {49.233209, -123.116339, 1}, {49.226287, -123.116560, 1},
                                    {49.209569, -123.116926, 1}, {49.195504, -123.126125, 2},
                                    {49.183924, -123.136357, 2}, {49.174750, -123.136498, 2},
                                    {49.168115, -123.136331, 2}, {49.196675, -123.146491, 2},
                                    {49.193020, -123.157903, 2},{49.194164, -123.178129, 1},
                                    {49.285801, -123.119864, 1},{49.283359, -123.116076, 1},
                                    {49.279301, -123.109158, 1},{49.273156, -123.100453, 1},
                                    {49.262309, -123.069077, 1},{49.248363, -123.055868, 1},//
                                    {49.244329, -123.046239, 1},{49.238429, -123.031825, 1},
                                    {49.229785, -123.012678, 2},{49.225774, -123.003759, 2},
                                    {49.220079, -122.988474, 2},{49.212205, -122.959315, 2},
                                    {49.199994, -122.949119, 2},{49.201421, -122.912750, 2},
                                    {49.204829, -122.906092, 2},{49.204426, -122.874167, 3},
                                    {49.198942, -122.850600, 3},{49.189595, -122.847848, 3},
                                    {49.182762, -122.844670, 3},{49.224662, -122.889392, 2},
                                    {49.233285, -122.882839, 2},{49.248534, -122.897059, 2},
                                    {49.253422, -122.918185, 2},{49.254623, -122.939260, 2},
                                    {49.259203, -122.964079, 2},{49.264745, -122.982166, 2},
                                    {49.266409, -123.001785, 2},{49.264906, -123.013524, 2},
                                    {49.260782, -123.032990, 1},{49.258922, -123.045318, 1},
                                    {49.265798, -123.078937, 1}, {49.262967, -123.068566, 1}};
    public String getStationName(int position){
        switch (position){
            case 0:
                name = "Waterfront";
                break;
            case 1:
                name = "Vancouver City Centre";
                break;
            case 2:
                name = "Yaletown Round House";
                break;
            case 3:
                name = "Olympic Village";
                break;
            case 4:
                name = "Broadway City Hall";
                break;
            case 5:
                name = "King Edward";
                break;
            case 6:
                name = "Oakridge 41st Ave";
                break;
            case 7:
                name = "Langara 49th Ave";
                break;
            case 8:
                name = "Marine Drive";
                break;
            case 9:
                name = "Bridgeport";
                break;
            case 10:
                name = "Alberdeen";
                break;
            case 11:
                name = "Lansdowne";
                break;
            case 12:
                name = "Richmond-Brighouse";
                break;
            case 13:
                name = "Templeton";
                break;
            case 14:
                name = "Sea Island Centre";
                break;
            case 15:
                name = "YVR-Airport";
                break;
            case 16:
                name = "Burrard";
                break;
            case 17:
                name = "Granville";
                break;
            case 18:
                name = "Stadium-Chinatown";
                break;
            case 19:
                name = "Main St-Science World";
                break;
            case 20:
                name = "Commercial-Broadway(E)";
                break;
            case 21:
                name = "Nanaimo";
                break;
            case 22:
                name = "29th Ave";
                break;
            case 23:
                name = "Joyce-Collingwood";
                break;
            case 24:
                name = "Patterson";
                break;
            case 25:
                name = "Metrotown";
                break;
            case 26:
                name = "Royal Oak";
                break;
            case 27:
                name = "Edmonds";
                break;
            case 28:
                name = "22nd Street";
                break;
            case 29:
                name = "New Westminster";
                break;
            case 30:
                name = "Columbia";
                break;
            case 31:
                name = "Scott Road";
                break;
            case 32:
                name = "Gateway";
                break;
            case 33:
                name = "Surrey Central";
                break;
            case 34:
                name = "King George";
                break;
            case 35:
                name = "Sapperton";
                break;
            case 36:
                name = "Braid";
                break;
            case 37:
                name = "Lougheed Town Centre";
                break;
            case 38:
                name = "Production Way-University";
                break;
            case 39:
                name = "Lake City Way";
                break;
            case 40:
                name = "Sperling-Burnaby Lake";
                break;
            case 41:
                name = "Holdom";
                break;
            case 42:
                name = "Brentwood Town Centre";
                break;
            case 43:
                name = "Gilmore";
                break;
            case 44:
                name = "Rupert";
                break;
            case 45:
                name = "Renfrew";
                break;
            case 46:
                name = "VCC-Clark";
                break;
            case 47:
                name = "Commercial-Broadway(M)";
                break;
        }
        return name;
    }

    public int getStationIndex(String name){
        switch (name){
            case "Waterfront":
                index = 0;
                break;
            case "Vancouver City Centre":
                index = 1;
                break;
            case "Yaletown Round House":
                index = 2;
                break;
            case "Olympic Village":
                index = 3;
                break;
            case "Broadway City Hall":
                index = 4;
                break;
            case "King Edward":
                index = 5;
                break;
            case "Oakridge 41st Ave":
                index = 6;
                break;
            case "Langara 49th Ave":
                index = 7;
                break;
            case "Marine Drive":
                index = 8;
                break;
            case "Bridgeport":
                index = 9;
                break;
            case "Alberdeen":
                index = 10;
                break;
            case "Lansdowne":
                index = 11;
                break;
            case "Richmond-Brighouse":
                index = 12;
                break;
            case "Templeton":
                index = 13;
                break;
            case "Sea Island Centre":
                index = 14;
                break;
            case "YVR-Airport":
                index = 15;
                break;
            case "Burrard":
                index = 16;
                break;
            case "Granville":
                index = 17;
                break;
            case "Stadium-Chinatown":
                index = 18;
                break;
            case "Main St-Science World":
                index = 19;
                break;
            case "Commercial-Broadway(E)":
                index = 20;
                break;
            case "Nanaimo":
                index = 21;
                break;
            case "29th Ave":
                index = 22;
                break;
            case "Joyce-Collingwood":
                index = 23;
                break;
            case "Patterson":
                index = 24;
                break;
            case "Metrotown":
                index = 25;
                break;
            case "Royal Oak":
                index = 26;
                break;
            case "Edmonds":
                index = 27;
                break;
            case "22nd Street":
                index = 28;
                break;
            case "New Westminster":
                index = 29;
                break;
            case "Columbia":
                index = 30;
                break;
            case "Scott Road":
                index = 31;
                break;
            case "Gateway":
                index = 32;
                break;
            case "Surrey Central":
                index = 33;
                break;
            case "King George":
                index = 34;
                break;
            case "Sapperton":
                index = 35;
                break;
            case "Braid":
                index = 36;
                break;
            case "Lougheed Town Centre":
                index = 37;
                break;
            case "Production Way-University":
                index = 38;
                break;
            case "Lake City Way":
                index = 39;
                break;
            case "Sperling-Burnaby Lake":
                index = 40;
                break;
            case "Holdom":
                index = 41;
                break;
            case "Brentwood Town Centre":
                index = 42;
                break;
            case "Gilmore":
                index = 43;
                break;
            case "Rupert":
                index = 44;
                break;
            case "Renfrew":
                index = 45;
                break;
            case "VCC-Clark":
                index = 46;
                break;
            case "Commercial-Broadway(M)":
                index = 47;
                break;
        }
        return index;
    }
}
