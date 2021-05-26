#include<bits/stdc++.h>
#include<conio.h>
using namespace std;

struct Node {
	int data;
	Node *left, *right;
};
typedef Node *TRO;
// tao cay rong
void Set_null(TRO &root) {
	root = NULL;
}
// them 1 node vao cay
void Add(TRO &root, int x) {
	if(root == NULL) {
		TRO P = new Node;
		P->data = x;
		P->left = NULL;
		P->right = NULL;
		root = P;
	}
	else {
		if(x > root->data)
			Add(root->right, x);
		else if(x < root->data)
			Add(root->left, x);
		else
			cout << "\nNode da ton tai.\n";
	}
}
// tao cay nhi phan
void Create_tree(TRO &root) {
	Set_null(root);
	char c;
	int x;
	do {
		cout << "Nhap data: ";
		cin >> x;
		Add(root, x);
		system("cls");
		cout << "An phim bat ki de tiep tuc, dung lai an ESC.\n";
		c = getch();
	} while(c != 27);
}
// duyet cay nhi phan theo thu tu truoc
void Duyet_NLR(TRO root) {
	if(root != NULL) {
		cout << " " << root->data;
		Duyet_NLR(root->left);
		Duyet_NLR(root->right);
	}
}
// dem so node la tren cay (la node k co node con)
int Count_node(TRO root) {
	if(root == NULL)
		return 0;
	else if(root->left == NULL && root->right == NULL)
		return 1;
	else
		return Count_node(root->left) + Count_node(root->right);
}
// tim kiem 1 node tren cay
TRO Search(TRO root, int x) {
	while(1) {
		if(root == NULL)
			return NULL;
		if(root->data == x) 
			return root;
		else if(x < root->data)
			root = root->left;
		else
			root = root->right;
			
	}
}
// tim node trai nhat cua cay con phai
void Find_node_leftmost(TRO &p, TRO &q) {
	if(q->left != NULL)
		Find_node_leftmost(p, q->left);
	else {
		p->data = q->data;
		p = q;
		q = q->right;
	}
}
// xoa 1 nut node tren cay
void Delete(TRO &root, int x) {
	if(root == NULL) {
		cout << "\nKhong tim thay nut khoa " << x << "tren cay.";
		return;	
	}
	else {
		if(x < root->data) 
			Delete(root->left, x);
		else if(x > root->data)
			Delete(root->right, x);
		else {
			cout << "\nCo nut khoa " << x << " tren cay."; 
			TRO p = root;
			if(root->left == NULL)
				root = root->right;
			else if(root->right == NULL)
				root = root->left;
			else {
				Find_node_leftmost(p, root->right);
			}
			delete p;
			cout << "\nDa xoa nut khoa " << x << endl;
		}
	}
}
int main()
{
	TRO root;
	Create_tree(root);
	cout << "\nHien thi day khoa cay theo thu tu truoc: ";
	Duyet_NLR(root);
	
	cout << "\nSo nut la cua cay la: " << Count_node(root) << endl;
	
	int x;
	cout << "\nNhap khoa can tim trong cay: ";
	cin >> x;
	TRO k = Search(root, x);
	if(k == NULL) 
		cout << "\nKhong tim thay khoa nay trong cay.\n";
	else
		cout << "\nDa tim thay khoa do tren cay.\n";
		
	cout << "\nNhap khoa can xoa trong cay: ";
	cin >> x;
	Delete(root, x);
	cout << "\nHien thi lai day khoa cay theo thu tu truoc: ";
	Duyet_NLR(root);
	return 0;
}

