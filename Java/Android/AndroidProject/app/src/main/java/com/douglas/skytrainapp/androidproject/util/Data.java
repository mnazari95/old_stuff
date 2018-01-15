package com.douglas.skytrainapp.androidproject.util;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Data {

    public static HashMap<String, List<String>> getInfo(){
        HashMap<String, List<String>> stationDetails = new HashMap<String, List<String>>();
        List<String> canadaLine = new ArrayList<String>();
        canadaLine.add("Vancouver city centre");
        canadaLine.add("Yaletown-roundhouse");
        canadaLine.add("Olympic village");
        canadaLine.add("Broadway-city hall");
        canadaLine.add("King Edward");
        canadaLine.add("Oakridge-41st Ave");
        canadaLine.add("Langara-49th Ave");
        canadaLine.add("Marine drive");
        canadaLine.add("Bridgeport");
        canadaLine.add("Alberdeen");
        canadaLine.add("Lansdowne");
        canadaLine.add("Richmond-brighouse");
        canadaLine.add("Templeton");
        canadaLine.add("Sea inslad centre");
        canadaLine.add("YVR-airport");

        List<String> expoLine = new ArrayList<String>();
        expoLine.add("Waterfront");
        expoLine.add("Burrard");
        expoLine.add("Granville");
        expoLine.add("Stadium-chinatown");
        expoLine.add("Main st-science world");
        expoLine.add("Commercial-broadway");
        expoLine.add("Nanaimo");
        expoLine.add("29th Ave");
        expoLine.add("Joyce-collingwood");
        expoLine.add("Patterson");
        expoLine.add("Metrotown");
        expoLine.add("Royal oak");
        expoLine.add("Edmonds");
        expoLine.add("22nd St");
        expoLine.add("New westminster");
        expoLine.add("Columbia");
        expoLine.add("Scott road");
        expoLine.add("Gateway");
        expoLine.add("Surrey central");
        expoLine.add("King George");

        List<String> millLine = new ArrayList<String>();
        millLine.add("Sapperton");
        millLine.add("Braid");
        millLine.add("Lougheed town centre");
        millLine.add("Production way-university");
        millLine.add("Lake city way");
        millLine.add("Sperling");
        millLine.add("Holdom");
        millLine.add("Brentwood town centre");
        millLine.add("Gilmore");
        millLine.add("Rupert");
        millLine.add("Renfrew");
        millLine.add("VCC-clark");

        stationDetails.put("Canada-Line", canadaLine);
        stationDetails.put("Expo-Line", expoLine);
        stationDetails.put("Millenium-Line", millLine);

        return stationDetails;
    }
}
