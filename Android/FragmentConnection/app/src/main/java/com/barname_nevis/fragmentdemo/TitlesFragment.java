package com.barname_nevis.fragmentdemo;


import android.os.Bundle;
import android.app.ListFragment;
import android.view.View;
import android.widget.ArrayAdapter;

import android.widget.ListView;

/**
 * Created by Mohammad on 8/8/2015.
 */
public class TitlesFragment extends ListFragment {
    @Override
    public void onListItemClick(ListView l, View v, int position, long id) {
        OsSelectionListener osSelectionListener = (OsSelectionListener) getActivity();
        osSelectionListener.OsSelectedChanges(position);
    }

    @Override
    public void onActivityCreated(Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);

        String[] osTitles = getResources().getStringArray(R.array.os_titles);
        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(getActivity(), android.R.layout.simple_list_item_1, osTitles);
        setListAdapter(arrayAdapter);
    }
}
