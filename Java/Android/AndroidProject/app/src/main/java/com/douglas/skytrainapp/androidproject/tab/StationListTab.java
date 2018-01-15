package com.douglas.skytrainapp.androidproject.tab;

import android.content.Intent;
import android.support.v4.app.Fragment;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ExpandableListView;
import android.widget.Toast;

import com.douglas.skytrainapp.androidproject.AttractionActivity;
import com.douglas.skytrainapp.androidproject.util.Data;
import com.douglas.skytrainapp.androidproject.R;
import com.douglas.skytrainapp.androidproject.adapter.StationAdapter;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class StationListTab extends Fragment{

    HashMap<String, List<String>> stationCatagory;
    List<String> stationList;
    ExpandableListView expList;
    StationAdapter adapter;
    //public final static String ImageID = "com.douglas.skytrainapp.androidproject._ID";
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState){
        final View view = inflater.inflate(R.layout.station_list_tab_layout,
                container,
                false);
        expList = (ExpandableListView)view.findViewById(R.id.expandableList);
        stationCatagory = Data.getInfo();
        stationList = new ArrayList<String>(stationCatagory.keySet());
        adapter = new StationAdapter(super.getActivity(),
                stationCatagory,
                stationList);

        expList.setAdapter(adapter);

        expList.setOnChildClickListener(new ExpandableListView.OnChildClickListener() {
            @Override
            public boolean onChildClick(ExpandableListView parent, View v, int groupPosition, int childPosition, long id) {
                Toast.makeText(getActivity(), /*stationList.get(groupPosition) + "->"
                 */stationCatagory.get(stationList.get(groupPosition)).get(childPosition),
                        Toast.LENGTH_SHORT).show();


                switch (stationCatagory.get(stationList.get(groupPosition)).get(childPosition)) {
                    case "Waterfront":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "waterfront"));
                        break;
                    case "Vancouver city centre":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "vancitycentre"));
                        break;
                    case "Yaletown-roundhouse":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "yaletown"));
                        break;
                    case "Olympic village":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "olympic"));
                        break;
                    case "Broadway-city hall":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "cityhall"));
                        break;
                    case "King Edward":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "kingedward"));
                        break;
                    case "Oakridge-41st Ave":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "oakridge"));
                        break;
                    case "Langara-49th Ave":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "langara"));
                        break;
                    case "Marine drive":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "marinedrive"));
                        break;
                    case "Bridgeport":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "bridgeport"));
                        break;
                    case "Alberdeen":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "alberdeen"));
                        break;
                    case "Lansdowne":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "lansdowne"));
                        break;
                    case "Richmond-brighouse":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "brighouse"));
                        break;
                    case "Templeton":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "templeton"));
                        break;
                    case "Sea inslad centre":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "seaisland"));
                        break;
                    case "YVR-airport":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "airport"));
                        break;
                    case "Burrard":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "burrad"));
                        break;
                    case "Granville":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "granville"));
                        break;
                    case "Stadium-chinatown":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "chinatown"));
                        break;
                    case "Main st-science world":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "scienceworld"));
                        break;
                    case "Commercial-broadway":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "commercial"));
                        break;
                    case "Nanaimo":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "nanaimo"));
                        break;
                    case "29th Ave":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "ave"));
                        break;
                    case "Joyce-collingwood":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "joycecollingwood"));
                        break;
                    case "Patterson":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "patterson"));
                        break;
                    case "Metrotown":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "metrotown"));
                        break;
                    case "Royal oak":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "royaloak"));
                        break;
                    case "Edmonds":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "edmonds"));
                        break;
                    case "22nd St":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "ndstreet"));
                        break;
                    case "New westminster":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "newwest"));
                        break;
                    case "Columbia":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "columbia"));
                        break;
                    case "Scott road":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "scottroad"));
                        break;
                    case "Gateway":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "gateway"));
                        break;
                    case "Surrey central":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "surreycentral"));
                        break;
                    case "King George":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "kinggeorge"));
                        break;
                    case "Sapperton":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "sapperton"));
                        break;
                    case "Braid":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "braid"));
                        break;
                    case "Lougheed town centre":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "lougheed"));
                        break;
                    case "Production way-university":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "productionway"));
                        break;
                    case "Lake city way":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "lakecity"));
                        break;
                    case "Sperling":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "sperling"));
                        break;
                    case "Holdom":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "holdom"));
                        break;
                    case "Brentwood town centre":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "brentwood"));
                        break;
                    case "Gilmore":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "gilmore"));
                        break;
                    case "Rupert":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "rupert"));
                        break;
                    case "Renfrew":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "renfrew"));
                        break;
                    case "VCC-clark":
                        startActivity(new Intent(getActivity(), AttractionActivity.class).putExtra("imageId", "vccclark"));
                        break;
                }
                return false;
            }
        });

        return view;
    }

}

