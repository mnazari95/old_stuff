package com.douglas.skytrainapp.androidproject;

import android.app.Activity;
import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.support.v7.widget.Toolbar;
import android.widget.TextView;

public class ContactActivity extends Activity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contact);

        final TextView txtTitle = (TextView)findViewById(R.id.txtToolBar);
        txtTitle.setText("Contact Information");
    }


}
