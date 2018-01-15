package com.douglas.skytrainapp.androidproject.adapter;

import android.content.Context;
import android.graphics.Typeface;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseExpandableListAdapter;
import android.widget.TextView;

import com.douglas.skytrainapp.androidproject.R;

import java.util.HashMap;
import java.util.List;

public class StationAdapter extends BaseExpandableListAdapter{

    //fields
    private Context ctx;
    private HashMap<String, List<String>> stationCatagory;
    private List<String> stationList;

    public StationAdapter(Context ctx, HashMap<String, List<String>> stationCatagory, List<String> stationList){
        this.ctx = ctx;
        this.stationCatagory = stationCatagory;
        this.stationList = stationList;
    }
    @Override
    public int getGroupCount() {
        return stationList.size();
    }

    @Override
    public int getChildrenCount(int groupPosition) {
        return stationCatagory.get(stationList.get(groupPosition)).size();
    }

    @Override
    public Object getGroup(int groupPosition) {
        return stationList.get(groupPosition);
    }

    @Override
    public Object getChild(int groupPosition, int childPosition) {
        return stationCatagory.get(stationList.get(groupPosition)).get(childPosition);
    }

    @Override
    public long getGroupId(int groupPosition) {
        return groupPosition;
    }

    @Override
    public long getChildId(int groupPosition, int childPosition) {
        return childPosition;
    }

    @Override
    public boolean hasStableIds() {
        return false;
    }

    @Override
    public View getGroupView(int groupPosition, boolean isExpanded, View convertView, ViewGroup parent) {
        String groupTitle = (String) getGroup(groupPosition);
        //check for null
        if (convertView == null){
            LayoutInflater inflater = (LayoutInflater) ctx.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            convertView = inflater.inflate(R.layout.parent_layout, parent, false);
        }
        TextView parent_textView = (TextView) convertView.findViewById(R.id.parent_text);

        parent_textView.setTypeface(null, Typeface.BOLD);
        parent_textView.setText(groupTitle);
        return convertView;
    }

    @Override
    public View getChildView(int groupPosition, int childPosition, boolean isLastChild, View convertView, ViewGroup parent) {
        String childTitle = (String) getChild(groupPosition, childPosition);
        //check for null
        if (convertView == null){
            LayoutInflater inflater = (LayoutInflater) ctx.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            convertView = inflater.inflate(R.layout.child_layout, parent, false);
        }

        TextView child_textView = (TextView) convertView.findViewById(R.id.child_text);
        child_textView.setText(childTitle);
        return convertView;
    }

    @Override
    public boolean isChildSelectable(int groupPosition, int childPosition) {
        return true;
    }
}
