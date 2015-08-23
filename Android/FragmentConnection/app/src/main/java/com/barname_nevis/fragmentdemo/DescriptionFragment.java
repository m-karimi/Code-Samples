package com.barname_nevis.fragmentdemo;

import android.os.Bundle;
import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

/**
 * Created by Mohammad on 8/8/2015.
 */
public class DescriptionFragment extends Fragment {
    TextView descriptionTextView;
    String[] descriptionArray;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View descriptionView = inflater.inflate(R.layout.fragment_description, container, false);
        descriptionArray = getResources().getStringArray(R.array.os_description);
        descriptionTextView = (TextView) descriptionView.findViewById(R.id.text_description);
        return descriptionView;
    }

    public void setDescriptionText(int osIndex) {
        descriptionTextView.setText(descriptionArray[osIndex]);
    }
}
