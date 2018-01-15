package com.douglas.skytrainapp.androidproject;


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.WindowManager;

import com.twitter.sdk.android.Twitter;
import com.twitter.sdk.android.core.TwitterAuthConfig;
import io.fabric.sdk.android.Fabric;
import java.util.Timer;
import java.util.TimerTask;

public class SplashActivity extends Activity{

    // Note: Your consumer key and secret should be obfuscated in your source code before shipping.
    private static final String TWITTER_KEY = "mIjXd2vY3bbbDsW81p2RVvv7e";
    private static final String TWITTER_SECRET = "air7F6zlgI5HZFMbYPC9iCO1sRFl7ftdEydkRi7wETwJw6mWuD";


    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        TwitterAuthConfig authConfig = new TwitterAuthConfig(TWITTER_KEY, TWITTER_SECRET);
        Fabric.with(this, new Twitter(authConfig));

        this.getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                                    WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.splash_screen);

        TimerTask task = new TimerTask() {
            @Override
            public void run() {
                finish();
                startActivity(new Intent(SplashActivity.this, MainActivity.class));
            }
        };
        Timer splashTime = new Timer();
        splashTime.schedule(task, 1000);

    }

    @Override
    protected void onPause(){
        super.onPause();
        finish();
    }
}
