#include<bits/stdc++.h>
#include<conio.h>
using namespace std;

struct Node {
	int data;
	Node* left;
	Node* right;
};
typedef Node* TRO;

void Set_NULL(TRO &root) {
	root = NULL;
}
void Add_Node(TRO &root, int x) {
	if(root == NULL) {
		TRO p = new Node;
		p->data = x;
		p->left = NULL;
		p->right = NULL;
		root = p;
	}
	else {
		if(x < root->data) {
			Add_Node(root->left, x);
		} 
		else if(x > root->data) {
			Add_Node(root->right, x);
		}
		else {
			cout << "\nNut da ton tai.\n";
		}
	}
}
void Create_tree(TRO &root) {
	char c;
	int x;
	do {
		cout << "nhap data: ";
		cin >> x;
		Add_Node(root, x);
		system("cls");
		cout << "An phim bat ki de tiep tuc, dung lai an ESC.\n";
		c = getch();
	} while(c != 27);
}
void Duyet_truoc(TRO root) {
	if(root != NULL) {
		cout << " " << root->data;
		Duyet_truoc(root->left);
		Duyet_truoc(root->right);
	}
}
void Duyet_giua(TRO root) {
	if(root != NULL) {
		Duyet_giua(root->left);
		cout << " " << root->data;
		Duyet_giua(root->right);
	}
}
void Duyet_sau(TRO root) {
	if(root != NULL) {
		Duyet_sau(root->left);
		Duyet_sau(root->right);
		cout << " " << root->data;
	}
}
bool Search(TRO root, int x) {
	if(root == NULL)
		return false;
	if(root->data == x)
		return true;
	else if(x < root->data) 
		return Search(root->left, x);
	else
		return Search(root->right, x);
}
void Tim_Node_left_nhat(TRO &p, TRO &q) {
	if(q->left != NULL)
		Tim_Node_left_nhat(p,q->left);
	else {
		p->data = q->data;
		p = q;
		q = q->right;
	}
}
void Delete_Node(TRO &root, int x) {
	if(root == NULL) {
		return;
	}
	else {
		if(x < root->data) 
			Delete_Node(root->left, x);
		else if(x > root->data) 
			Delete_Node(root->right, x);
		else {
			cout << "\nCo nut khoa " << x << " tren cay.\n";
			Node *p = root;
			if(root->left == NULL) 
				root = root->right;
			else if(root->right == NULL)
				root = root->left;
			else {
				Tim_Node_left_nhat(p, root->right);
				delete p;
				cout << "\nDa xoa nut khoa " << x << endl;
			}
		}
	}
}
int main()
{
	TRO root;
	Set_NULL(root);
	Create_tree(root);
	
	cout << "\nDuyet cay theo thu tu truoc: ";
	Duyet_truoc(root);
	cout << "\nDuyet cay theo thu tu giua: ";
	Duyet_giua(root);
	cout << "\nDuyet cay theo thu tu sau: ";
	Duyet_sau(root);
	
	Add_Node(root, 35);
	cout << "\n\nCay sau khi chen nut khoa 35: ";
	Duyet_truoc(root);
	
	if(Search(root, 48))
		cout << "\n\nTim thay nut co khoa 48 tren cay.\n";
	else 
		cout << "\n\nKhong tim thay nut co khoa 48 tren cay.\n"; 
		
	Delete_Node(root, 55);
	cout << "\nCay sau khi xoa nut co khoa 55: ";
	Duyet_truoc(root);
	
	return 0;
}

