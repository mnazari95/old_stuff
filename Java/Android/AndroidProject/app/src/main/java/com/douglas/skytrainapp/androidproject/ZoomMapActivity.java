package com.douglas.skytrainapp.androidproject;

import android.app.Activity;
import android.os.Bundle;

import com.douglas.skytrainapp.androidproject.util.TouchImageView;

public class ZoomMapActivity extends Activity{
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        //Set on the TouchImageView
        TouchImageView imgTouch = new TouchImageView(this);
        imgTouch.setImageResource(R.drawable.skytrain_detail_map);
        imgTouch.setMaxZoom(4f);
        setContentView(imgTouch);
    }
}
