package com.douglas.skytrainapp.androidproject.adapter;

import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentPagerAdapter;

import com.douglas.skytrainapp.androidproject.tab.StationListTab;
import com.douglas.skytrainapp.androidproject.tab.TranslinkFeedTab;
import com.douglas.skytrainapp.androidproject.tab.FareCalculatorTab;

//whenever creating new tab/fragment make sure to add the stuff into
//these two switch statements AND change the getCount to the total amount of tabs available

public class ProjectAdapter extends FragmentPagerAdapter {

    public ProjectAdapter(FragmentManager fm) {
        super(fm);
    }

    @Override
    public Fragment getItem(int i) {

        switch (i) {
            case 0:
                TranslinkFeedTab translinkFeedTab = new TranslinkFeedTab();
                return translinkFeedTab;
            case 1:
                StationListTab stationListTab = new StationListTab();
                return stationListTab;
            case 2:
                FareCalculatorTab fareCalculatorTab = new FareCalculatorTab();
                return fareCalculatorTab;

        }
        return null;
    }

    @Override
    public int getCount() {
        return 3;
    }//set the number of tabs

    @Override
    public CharSequence getPageTitle(int position) {
        switch (position) {
            case 0:
                return "Translink Feed";
            case 1:
                return "Station Attraction";
            case 2:
                return "Fare Calculator";
        }
        return null;
    }

}
