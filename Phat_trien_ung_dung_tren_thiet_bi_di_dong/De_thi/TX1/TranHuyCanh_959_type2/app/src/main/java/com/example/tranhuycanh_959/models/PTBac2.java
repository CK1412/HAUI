package com.example.tranhuycanh_959.models;

public class PTBac2 {
    double a, b, c;
    double x1, x2;

    public PTBac2(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double getX1() {
        return x1;
    }

    public double getX2() {
        return x2;
    }

    public double getA() {
        return a;
    }

    public void setA(double a) {
        this.a = a;
    }

    public double getB() {
        return b;
    }

    public void setB(double b) {
        this.b = b;
    }

    public double getC() {
        return c;
    }

    public void setC(double c) {
        this.c = c;
    }

    public int giaiPT() {
        double delta = b*b - 4 * a * c;

        if(delta < 0) {
            return  -1;
        }
        else if(delta == 0) {
            x1 = (-1 * b) / ( 2 * a);
            x2 = (-1 * b) / ( 2 * a);
            return 0;
        }
        else  {
            x1 = ((-1) * b + delta) / (2 * a);
            x2 = ((-1) * b - delta) / (2 * a);
            return 1;
        }
    }

    @Override
    public String toString() {
        return "a=" + a +
                ", b=" + b +
                ", c=" + c +
                ", x1=" + x1 +
                ", x2=" + x2;
    }
}
