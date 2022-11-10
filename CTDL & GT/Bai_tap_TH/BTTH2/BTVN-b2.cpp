#include<bits/stdc++.h>
using namespace std;
void Nhap(int &m,int &n){
	cout<<"m = "; cin>>m;
	cout<<"n = "; cin>>n;
}
//
bool bia1(int a,int b,int c,int d){
	if (a+b+c+d == 4) return true;
	else return false;
}
bool bia2(int a,int b){
	if (a+b==2) return true;
	else return false;
}

bool bia3(int a){
	if (a==1) return true;
	else return false;
}
int main(){
	int m ,n,dem=0;
	Nhap(m,n);
	int a[100][100]={};
	
// ve hcn m*n :))
	for (int i=0;i<=m+1;i++)
	   for (int j=0;j<=n+1;j++)
	   	  a[i][j] = 0;
	
	for (int i=1;i<=m;i++)
	   for (int j=1;j<=n;j++)
	   	  a[i][j] = 1;
	   
// 	   	   	  
	for (int i=1;i<=m;i++)
		for (int j=1;j<=n;j++)
			if (bia1(a[i][j],a[i][j+1],a[i+1][j],a[i+1][j+1])){
				a[i][j] = 0;
				a[i][j+1] = 0;
				a[i+1][j] = 0;
				a[i+1][j+1] = 0;
				dem++;
			}
			else if(bia2(a[i][j],a[i+1][j])){
				a[i][j]  = 0; 
				a[i+1][j]= 0;
				dem++;
			}
			else if(bia2(a[i][j],a[i][j+1])){
				a[i][j]  = 0; 
				a[i][j+1]= 0;
				dem++;
			}
			else if(bia3(a[i][j])){
				a[i][j] = 0;
				dem++;
			}
	cout<<"dem="<<dem<<endl;
}

