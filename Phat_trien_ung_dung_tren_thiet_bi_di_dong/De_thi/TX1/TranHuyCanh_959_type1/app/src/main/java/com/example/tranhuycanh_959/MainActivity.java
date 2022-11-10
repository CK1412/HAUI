package com.example.tranhuycanh_959;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.tranhuycanh_959.models.Customer;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    EditText nameEditText;
    EditText quantityEditText;
    CheckBox isVIPCheckBox;
    TextView totalTextView;
    Button moneyCalcBtn;
    Button moneyInputBtn;
    Button reportBtn;

    ListView customerListView;
    ArrayList<Customer> arrayList = null;
    ArrayAdapter<Customer> arrayAdapter = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        getWidget();
        initData();
        onButtonEvent();
    }

    private void onButtonEvent() {
        moneyCalcBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                moneyTotalCalc();
            }
        });

        moneyInputBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                addCustomerToListView();
            }
        });

        reportBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showReport();
            }
        });
    }

    private void showReport() {
        int totalCustomer = arrayList.size();
        int totalVIP = 0;
        int totalMoneyVIP = 0;

        int totalNotVIP = 0;
        int totalMoneyNotVIP = 0;
        for (int i = 0; i < totalCustomer; i++) {
            if(arrayList.get(i).isVIP()) {
                totalVIP += 1;
                totalMoneyVIP += arrayList.get(i).getMoneyTotal();
            }
            else {
                totalNotVIP += 1;
                totalMoneyNotVIP += arrayList.get(i).getMoneyTotal();
            }
        }

        String message = "Số khách VIP: " + totalVIP + " - chiếm " + totalMoneyVIP + "VND"
                        + "\nSố khách không VIP: " + totalNotVIP + " - chiếm " + totalMoneyNotVIP + "VND";
        showToast(message);
    }

    private void addCustomerToListView() {
        String name = nameEditText.getText().toString();
        String quantityStr = quantityEditText.getText().toString();
        boolean isVIP = isVIPCheckBox.isChecked();
        if(checkInputValid()) {
            int quantity = Integer.parseInt(quantityStr);
            Customer newCustomer = new Customer(name, quantity, isVIP);
            arrayList.add(newCustomer);
            arrayAdapter.notifyDataSetChanged();

            resetData();
        }
    }

    private void resetData() {
        nameEditText.setText("");
        quantityEditText.setText("");
        isVIPCheckBox.setChecked(false);
        totalTextView.setText("");

        nameEditText.requestFocus();
    }

    private void moneyTotalCalc() {
        String quantityStr = quantityEditText.getText().toString();
        if(checkQuantity(quantityStr)) {
            int quantity = Integer.parseInt(quantityStr);
            int total = quantity * 50000;
            totalTextView.setText(total + "");
        }
    }

    private void initData() {
        arrayList = new ArrayList<Customer>();

        arrayAdapter = new ArrayAdapter<Customer>(this, android.R.layout.simple_list_item_1,arrayList);
        customerListView.setAdapter(arrayAdapter);
    }

    private void getWidget() {
        nameEditText = findViewById(R.id.nameEditText);
        quantityEditText = findViewById(R.id.quantityEditText);
        isVIPCheckBox = findViewById(R.id.isVIPCheckBox);
        totalTextView = findViewById(R.id.moneyTotalTextView);
        moneyCalcBtn = findViewById(R.id.moneyCalcBtn);
        moneyInputBtn = findViewById(R.id.moneyInputBtn);
        reportBtn = findViewById(R.id.reportBtn);
        customerListView = findViewById(R.id.customerListView);
    }

    private void showToast(String msg) {
        Toast.makeText(this, msg, Toast.LENGTH_LONG).show();
    }

    private boolean checkInputValid() {
        String name = nameEditText.getText().toString();
        String quantityStr = quantityEditText.getText().toString();

        if(name.isEmpty()) {
            showToast("Vui lòng nhập tên khách hàng");
            return false;
        }

        if(!checkQuantity(quantityStr)) {
            return false;
        }

        return true;
    }

    private boolean checkQuantity(String quantityStr) {
        if(quantityStr.isEmpty()) {
            showToast("Vui lòng nhập số lượng sách");
            return false;
        }

        try {
            int a = Integer.parseInt(quantityStr);
        } catch (NumberFormatException e) {
            showToast("Số lượng sách phải là số nguyên");
            return false;
        }

        int x = Integer.parseInt(quantityStr);
        if(x < 0) {
            showToast("Số lượng sách không được âm");
            return false;
        }

        return true;
    }
}