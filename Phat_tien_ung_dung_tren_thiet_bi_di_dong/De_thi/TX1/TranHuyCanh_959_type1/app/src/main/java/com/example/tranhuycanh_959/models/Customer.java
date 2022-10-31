package com.example.tranhuycanh_959.models;

public class Customer {
    private String name;
    private int bookQuantity;
    private boolean isVIP;
    private int moneyTotal;

    public Customer(String name, int bookQuantity, boolean isVIP) {
        this.name = name;
        this.bookQuantity = bookQuantity;
        this.isVIP = isVIP;
        this.moneyTotal = bookQuantity * 50000;
    }

    public String getName() {
        return name;
    }

    public int getBookQuantity() {
        return bookQuantity;
    }

    public boolean isVIP() {
        return isVIP;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setBookQuantity(int bookQuantity) {
        this.bookQuantity = bookQuantity;
    }

    public void setVIP(boolean VIP) {
        isVIP = VIP;
    }

    public int getMoneyTotal() {
        return moneyTotal;
    }

    public void setMoneyTotal(int moneyTotal) {
        this.moneyTotal = moneyTotal;
    }

    @Override
    public String toString() {
        String vip = isVIP ? "is VIP" : "is not VIP";
        return name + " - " + bookQuantity + " - " + vip + " - " + moneyTotal + "VND";
    }
}
