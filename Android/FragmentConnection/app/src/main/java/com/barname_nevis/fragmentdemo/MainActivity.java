package com.barname_nevis.fragmentdemo;

import android.app.Activity;
import android.app.FragmentManager;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;


public class MainActivity extends Activity implements OsSelectionListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }


    @Override
    public void OsSelectedChanges(int index) {
        FragmentManager fragmentManager = getFragmentManager();
        DescriptionFragment descriptionFragment = (DescriptionFragment)fragmentManager.findFragmentById(R.id.fragment_description);
        descriptionFragment.setDescriptionText(index);
    }
}
