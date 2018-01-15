package com.douglas.skytrainapp.androidproject;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

public class SettingActivity extends Activity {

    ListView listView;

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_setting);

        final TextView txtTitle = (TextView)findViewById(R.id.txtToolBar);
        txtTitle.setText("Settings");

        listView = (ListView) findViewById(R.id.list);
        String[] options = this.getResources().getStringArray(R.array.settingOptions);
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,
                android.R.layout.simple_list_item_1,
                options);

        listView.setAdapter(adapter);
        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> arg0, View arg1, int position, long arg3) {
                switch (position) {
                    //add more event after each case
                    case 0:
                        startActivity(new Intent(SettingActivity.this, HistoryActivity.class));
                        break;

                    case 1:
                        startActivity(new Intent(SettingActivity.this, ContactActivity.class));
                        break;
                    case 2:
                        //directly intent into email website to fill in the content of your commment
                        Intent Email = new Intent(Intent.ACTION_SEND);
                        Email.setType("text/email");
                        Email.putExtra(Intent.EXTRA_EMAIL, new String[]{"admin@hotmail.com"});
                        Email.putExtra(Intent.EXTRA_SUBJECT, "Feedback");
                        Email.putExtra(Intent.EXTRA_TEXT, "Dear ..." + "");
                        startActivity(Intent.createChooser(Email, "Send Feedback:"));
                        break;
                    case 3:
                        startActivity(new Intent(SettingActivity.this, ZoomMapActivity.class));
                        break;
                }
            }
        });

    }
}
