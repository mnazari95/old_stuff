package com.douglas.skytrainapp.androidproject.tab;

import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;

import com.douglas.skytrainapp.androidproject.R;

import java.text.DecimalFormat;


public class FareCalculatorTab extends Fragment {
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view=inflater.inflate(R.layout.fare_calculator_tab_layout,container,false);
        return  view;
    }

}
