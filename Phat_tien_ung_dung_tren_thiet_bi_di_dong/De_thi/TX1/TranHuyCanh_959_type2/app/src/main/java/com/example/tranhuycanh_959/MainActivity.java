package com.example.tranhuycanh_959;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.tranhuycanh_959.models.PTBac2;

import java.time.Duration;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    EditText aEditText;
    EditText bEditText;
    EditText cEditText;

    TextView resultTextView;

    Button calcBtn;
    Button deleteBtn;
    Button saveBtn;

    ListView infoListView;
    ArrayList<PTBac2> arrayList = null;
    ArrayAdapter<PTBac2> arrayAdapter = null;
    PTBac2 tempPTBac2 = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        getWidget();
        initData();
        onButtonEvent();
    }

    private void onButtonEvent() {
        calcBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                calcPT();
            }
        });

        deleteBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                resetValue();
            }
        });

        saveBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                addDataToListView();
            }
        });
    }

    private void addDataToListView() {
        if(checkInputValidate()) {
            arrayList.add(tempPTBac2);
            arrayAdapter.notifyDataSetChanged();

            resetValue();
        }
    }

    private void resetValue() {
        aEditText.setText("");
        bEditText.setText("");
        cEditText.setText("");

        aEditText.requestFocus();


    }

    private void calcPT() {
        String aNumberTxt = aEditText.getText().toString();
        String bNumberTxt = bEditText.getText().toString();
        String cNumberTxt = cEditText.getText().toString();

        if(checkInputValidate()) {
            double a = Double.parseDouble(aNumberTxt);
            double b = Double.parseDouble(bNumberTxt);
            double c = Double.parseDouble(cNumberTxt);

            tempPTBac2 = new PTBac2(a, b, c);

            if(tempPTBac2.giaiPT() == -1) {
                resultTextView.setText("PT vô nghiệm");
            }
            else if(tempPTBac2.giaiPT() == 1) {
                resultTextView.setText("PT có 1 nghiệm kép x = " + tempPTBac2.getX1());
            }
            else {
                resultTextView.setText("PT có 2 nghiệm x1 = " + tempPTBac2.getX1()
                        + ", x2 = " + tempPTBac2.getX2());
            }
        }
    }

    private boolean checkInputValidate() {
        String aNumberTxt = aEditText.getText().toString();
        String bNumberTxt = bEditText.getText().toString();
        String cNumberTxt = cEditText.getText().toString();

        if(aNumberTxt.isEmpty() || bNumberTxt.isEmpty() || cNumberTxt.isEmpty()) {
                showToast("Vui lòng nhập các số");
                return false;
        }

        try {
            double aNumber = Double.parseDouble(aNumberTxt);
            double bNumber = Double.parseDouble(bNumberTxt);
            double cNumber = Double.parseDouble(cNumberTxt);
        } catch (NumberFormatException e) {
            showToast("Các số phải là số thực");
            return false;
        }

        return true;
    }

    private void showToast(String msg) {
        Toast.makeText(this,msg, Toast.LENGTH_LONG).show();
    }

    private void initData() {
        arrayList = new ArrayList<PTBac2>();
        arrayAdapter = new ArrayAdapter<PTBac2>(this, android.R.layout.simple_list_item_1,arrayList);

        infoListView.setAdapter(arrayAdapter);
        arrayAdapter.notifyDataSetChanged();
    }

    private void getWidget() {
        aEditText = findViewById(R.id.aNumberEditText);
        bEditText = findViewById(R.id.bNumberEditText);
        cEditText = findViewById(R.id.cNumberEditText);

        resultTextView = findViewById(R.id.resultTextView);

        calcBtn = findViewById(R.id.calcBtn);
        deleteBtn = findViewById(R.id.deleteBtn);
        saveBtn = findViewById(R.id.saveBtn);

        infoListView = findViewById(R.id.infoListView);
    }
}