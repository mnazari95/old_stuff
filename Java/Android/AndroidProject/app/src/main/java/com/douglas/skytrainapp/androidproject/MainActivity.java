package com.douglas.skytrainapp.androidproject;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.support.v4.view.PagerTabStrip;
import android.support.v4.view.ViewPager;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.douglas.skytrainapp.androidproject.adapter.ProjectAdapter;

import java.text.DecimalFormat;

public class MainActivity extends FragmentActivity{

    ViewPager vPager;//the body where the content of each tab is displayed
    PagerTabStrip tab_strp;//tab navigation
    private String zone_type, adlt, senior;
    private int add, senr;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ProjectAdapter projectAdapter = new ProjectAdapter(getSupportFragmentManager());
        vPager = (ViewPager)findViewById(R.id.pager);
        vPager.setAdapter(projectAdapter);
        tab_strp =(PagerTabStrip)findViewById(R.id.tab_strip);
        tab_strp.setTextColor(Color.WHITE);
        tab_strp.setTabIndicatorColor(Color.rgb(227, 242, 253));

    }

    public void openMap(View view){
        startActivity(new Intent(this, MapsActivity.class));
    }

    public void openSettings(View view){
        startActivity(new Intent(this, SettingActivity.class));
    }

    public void fareResult(View view) {
        final Spinner zone=(Spinner) findViewById(R.id.spZone);
        zone_type = zone.getSelectedItem().toString();

        final EditText ad=(EditText) findViewById(R.id.edOne);
        final EditText sen=(EditText) findViewById(R.id.edTwo);
        add = 0;
        senr = 0;

        adlt = ad.getText().toString();
        senior = sen.getText().toString();

        if ((!adlt.equals("")) && (!senior.equals(""))) {
            add = Integer.parseInt(ad.getText().toString());
            senr = Integer.parseInt(sen.getText().toString());
            calculate();
        }else if ((!adlt.equals("")) && (senior.equals(""))){
            add = Integer.parseInt(ad.getText().toString());
            calculate();
        }else if ((adlt.equals("")) && (!senior.equals(""))){
            senr = Integer.parseInt(sen.getText().toString());
            calculate();
        }else{
            Toast.makeText(MainActivity.this, "Please enter a number in the field above.", Toast.LENGTH_SHORT).show();
        }
    }

    private void calculate(){
        final TextView reslt=(TextView) findViewById(R.id.Result);

        double price = 0;

        if(zone_type.equals("Zone 1"))
        {
            price=(add*2.75) + (senr*1.75);
        }
        if(zone_type.equals("Zone 2"))
        {
            price=(add*4.0) + (senr*2.75);
        }
        if(zone_type.equals("Zone 3"))
        {
            price=(add*5.50) + (senr*3.75);
        }

        DecimalFormat currency=new DecimalFormat("$###,#00.00");

        reslt.setText("Estimated Fare is "+ currency.format(price));
        //close keyboard
        try  {
            InputMethodManager imm = (InputMethodManager)getSystemService(INPUT_METHOD_SERVICE);
            imm.hideSoftInputFromWindow(getCurrentFocus().getWindowToken(), 0);
        } catch (NullPointerException e) {
            Toast.makeText(MainActivity.this, "An error occured while closing keyboard", Toast.LENGTH_SHORT).show();
        }
    }
}

