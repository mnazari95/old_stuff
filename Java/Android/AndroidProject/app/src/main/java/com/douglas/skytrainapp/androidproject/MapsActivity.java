package com.douglas.skytrainapp.androidproject;

import android.graphics.Color;
import android.os.AsyncTask;
import android.support.v4.app.FragmentActivity;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.view.inputmethod.EditorInfo;
import android.view.inputmethod.InputMethodManager;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.douglas.skytrainapp.androidproject.parser.HttpConnection;
import com.douglas.skytrainapp.androidproject.parser.PathJSONParser;
import com.douglas.skytrainapp.androidproject.util.StationLocation;
import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;
import com.google.android.gms.maps.model.PolylineOptions;

import org.json.JSONObject;

import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class MapsActivity extends FragmentActivity implements OnMapReadyCallback {

    StationLocation sL = new StationLocation();
    private GoogleMap mMap;
    private AutoCompleteTextView fromAutoComp, toAutoComp;
    private int fromStation, toStation;
    private Button btn;
    private String departure, arrival;
    private final int LAT = 0;
    private final int LNG = 1;
    String fSS;
    String tSS;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_map);

        //auto complete stuff for route finder
        String[] stationListName = getResources().getStringArray(R.array.station_line_list);
        ArrayAdapter<String> fromAdapter = new ArrayAdapter<String>(this,
                android.R.layout.simple_expandable_list_item_1,
                stationListName);
        btn = (Button)findViewById(R.id.btnNav);
        fromAutoComp = (AutoCompleteTextView)findViewById(R.id.autoCompTVFrom);
        toAutoComp = (AutoCompleteTextView)findViewById(R.id.autoCompTVTo);
        fromAutoComp.setAdapter(fromAdapter);
        toAutoComp.setAdapter(fromAdapter);

        // Obtain the SupportMapFragment and get notified when the map is ready to be used.
        SupportMapFragment mapFragment = (SupportMapFragment) getSupportFragmentManager()
                .findFragmentById(R.id.map);
        mapFragment.getMapAsync(this);
    }

    public void saveNames(){
        //final EditText data = (EditText)findViewById(R.id.txtName);
        //String text = toAutoComp.getText().toString();
        fSS = fromAutoComp.getText().toString();
        tSS = toAutoComp.getText().toString();
        if(fSS != null && tSS != null) {
            try {

                // write the data onto a file
                OutputStreamWriter outFile = new
                        OutputStreamWriter(openFileOutput("myFile", MODE_APPEND));
                outFile.write("From:" + fSS + " " + "To:" + " " + tSS + "\n"); // write the data line by line
                outFile.close();

            } catch (Exception ex) {
                Toast.makeText(MapsActivity.this, "Error encountered", Toast.LENGTH_SHORT).show();
            }
        }

    }//finish the method saveName

    @Override
    public void onMapReady(GoogleMap googleMap) {
        mMap = googleMap;

        LatLng defaultLocation = new LatLng(49.225774, -123.003759);
        mMap.moveCamera(CameraUpdateFactory.newLatLngZoom(defaultLocation, (float) 15.1));
        mMap.animateCamera(CameraUpdateFactory.zoomIn());
        mMap.animateCamera(CameraUpdateFactory.zoomTo(10),3000, null);
        mMap.setMyLocationEnabled(true);
        mMap.getUiSettings().setMapToolbarEnabled(false);
        mMap.getUiSettings().setCompassEnabled(false);
    }

    private void drawMarker(double lat, double lng, String stationName, String time){
        mMap.addMarker(new MarkerOptions()
                .position(new LatLng(lat, lng))
                .snippet(time)
                .title(stationName)).showInfoWindow();
    }

    public void drawRoute(View view){
        //take input
        String fSS = fromAutoComp.getText().toString();
        String tSS = toAutoComp.getText().toString();
        fromStation = sL.getStationIndex(fromAutoComp.getText().toString());
        toStation = sL.getStationIndex(toAutoComp.getText().toString());

        //in-case user just clicks button without input
        if ((!fSS.equals("")) && (!tSS.equals(""))) {
            btn.setText("Looking for path..");
            saveNames();
            //find and draw the path
            String url = getMapsApiDirectionsUrl();
            ReadTask downloadTask = new ReadTask();
            downloadTask.execute(url);

            //close keyboard
            try  {
                InputMethodManager imm = (InputMethodManager)getSystemService(INPUT_METHOD_SERVICE);
                imm.hideSoftInputFromWindow(getCurrentFocus().getWindowToken(), 0);
            } catch (NullPointerException e) {
                Toast.makeText(MapsActivity.this, "An error occured while closing keyboard", Toast.LENGTH_SHORT).show();
            }
        }else{
            Toast.makeText(MapsActivity.this, "Please enter station name on the textfield above", Toast.LENGTH_SHORT).show();
        }
    }

    private String getMapsApiDirectionsUrl() {
        String origin = StationLocation.sLC[fromStation][LAT] + "," + StationLocation.sLC[fromStation][LNG];
        String destination = StationLocation.sLC[toStation][LAT] + "," + StationLocation.sLC[toStation][LNG];
        String key = "AIzaSyCCuDGp8_S_eAYNCzoPb29eDSy3mgmPAjg";
        String params = "origin=" + origin + "&"
                    + "destination=" + destination
                    +"&mode=transit"
                    + "&transit_mode=train"
                    + "&key=" + key;
        String output = "json";
        String url = "https://maps.googleapis.com/maps/api/directions/"
                + output + "?" + params;
        return url;
    }

    private class ReadTask extends AsyncTask<String, Void, String> {
        @Override
        protected String doInBackground(String... url) {
            String data = "";
            try {
                HttpConnection http = new HttpConnection();
                data = http.readUrl(url[0]);
            } catch (Exception e) {
            }
            return data;
        }

        @Override
        protected void onPostExecute(String result) {
            super.onPostExecute(result);
            new ParserTask().execute(result);
        }
    }

    private class ParserTask extends AsyncTask<String, Integer, List<List<HashMap<String, String>>>> {

        @Override
        protected List<List<HashMap<String, String>>> doInBackground(
                String... jsonData) {

            JSONObject jObject;
            List<List<HashMap<String, String>>> routes = null;

            try {
                jObject = new JSONObject(jsonData[0]);
                PathJSONParser parser = new PathJSONParser();
                routes = parser.parse(jObject);
            } catch (Exception e) {
                e.printStackTrace();
            }
            return routes;
        }

        @Override
        protected void onPostExecute(List<List<HashMap<String, String>>> routes) {
            ArrayList<LatLng> points = null;
            PolylineOptions polyLineOptions = null;

            // traversing through routes
            for (int i = 0; i < routes.size(); i++) {
                points = new ArrayList<LatLng>();
                polyLineOptions = new PolylineOptions();
                List<HashMap<String, String>> path = routes.get(i);

                for (int j = 0; j < path.size(); j++) {
                    HashMap<String, String> point = path.get(j);

                    if (j == 0){
                      departure = point.get("departure");
                        continue;
                    }else if (j == 1){
                        arrival = point.get("arrival");
                        continue;
                    }

                    double lat = Double.parseDouble(point.get("lat"));
                    double lng = Double.parseDouble(point.get("lng"));
                    LatLng position = new LatLng(lat, lng);

                    points.add(position);
                }

                polyLineOptions.addAll(points);
                polyLineOptions.width(10);
                polyLineOptions.color(Color.BLUE);
            }
            mMap.clear();
            //draw markers
            drawMarker(StationLocation.sLC[fromStation][LAT],
                    StationLocation.sLC[fromStation][LNG],
                    sL.getStationName(fromStation),
                    "Next Train At: " + departure);
            drawMarker(StationLocation.sLC[toStation][LAT],
                    StationLocation.sLC[toStation][LNG],
                    sL.getStationName(toStation),
                    "Expected Arrival: " + arrival);
            mMap.addPolyline(polyLineOptions);
            btn.setText("Find");
            //move the camera to destination
            LatLng zoomToLocation = new LatLng(StationLocation.sLC[toStation][LAT], StationLocation.sLC[toStation][LNG]);
            mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(zoomToLocation, 14));
        }
    }
}
