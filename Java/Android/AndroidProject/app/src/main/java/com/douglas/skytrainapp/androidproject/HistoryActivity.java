package com.douglas.skytrainapp.androidproject;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import java.io.BufferedReader;
import java.io.File;
import java.io.InputStream;
import java.io.InputStreamReader;

public class HistoryActivity extends Activity {

    TextView history;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_history);
        final TextView txtTitle = (TextView)findViewById(R.id.txtToolBar);
        txtTitle.setText("History");
        history = (TextView)findViewById(R.id.txtHistory);
        readNames();

    }

    public void readNames(){

        try
        {
            // you use inFile to replace "myFile" to operate
            InputStream inFile = openFileInput("myFile");
            //put the data read from the file onto the inReader (container)
            InputStreamReader inReader = new InputStreamReader(inFile);
            BufferedReader bfReader = new BufferedReader(inReader);
            String line = null;
            // read the "bfReader" line by line onto String "line"
            //the code below read the first name
            line = bfReader.readLine();
            while (line != null)
            {
                history.append(line+"\n\n");
                line = bfReader.readLine();
            }
            inFile.close();
        }
        catch (Exception ex)
        {
            history.setText("");

        }
    }

    public void deleteFile(View view) {
        File dir = getFilesDir();
        File file = new File(dir, "myFile");
        boolean deleted = file.delete();
        readNames();

    }


}

