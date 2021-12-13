#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

class Base {
private:
	int x;
	int y;
public:
	virtual char getcode() {
		char B = 'B';
		return B;
	}
	virtual void print() {

	}
	Base() {
		printf("Base()\n");

	}
	~Base() {
		printf("~Base()\n");

	}

};
class Point : public Base {

private:
	int x = 0;
	int y = 0;
public:
	char getcode() override {
		char P = 'P';
		return P;
	}
	void print() {
		printf("Вывод координат%d%d\t", x, y);
	}
	Point(int x, int y) {
		this->x = x;
		this->y = y;
	}
	Point(const Point* p) {
		this->x = p->x;
		this->y = p->y;

	}
	Point() {
		x = 0;
		y = 0;
	}
	~Point() {
		printf("~Point()\n");
	}

};
class Segment : public Base {
private:
	Point* a;
	Point* b;

public:
	virtual char getcode() {
		char S = 'S';
		return S;
	}
	void print() {
		printf("Вывод координат");
		a->print();
		b->print();
	}
	Segment() {
		Point* a = new Point;
		Point* b = new Point;

	}
	Segment(int _a, int _b) {
		this->a = a;
		this->b = b;

	}
	Segment(const Segment* p) {
		this->a = p->a;
		this->b = p->b;

	}
	~Segment() {
		printf("~Segment()\n");
		delete a;
		delete b;
	}
};

class Factory
{
public:
	Base* CreateBased(Base* obj) {

		Base* res = nullptr;
		switch (obj->getcode()) {
		case 'P':
			res = new Point((Point*)(obj));
			break;
		case 'S':
			res = new Segment((Segment*)obj);
			break;
		}
		return res; // посмотреть точкой остоновой
	}

};
class Storage
{
private:
	Factory factory;
public:
	Base** mas;;
	int size = 0;
	Storage(int size) {
		this->size = size;
		mas = new Base * [size];
		initArr();
	}
	int Getsize() {
		return size;
	}
	void Add(Base* obj, int index) {

		mas[index] = factory.CreateBased(obj);
	}
	Base* Getobj(int index) {
		return	factory.CreateBased(mas[index]);

	}
	Base* GetDelObj(int index) {
		Base* tmp = factory.CreateBased(mas[index]);
		delete mas[index];
		mas[index] = nullptr;
		return tmp;
	}
	void StoragePrint() {
		
		printf("Storage {\n");
		for (int i = 0; i < size; i++)
			if (mas[i] != nullptr) {
				printf("mas[%d]:", i);
				mas[i]->print();
			}
			else {
				i++;
			}
		printf("}\n");
	}
	void initArr() {
		for (int i = 0; i < size; i++)
			mas[i] = nullptr;
	}
};


int main() {
	setlocale(LC_ALL, "Rus");
	Storage arr(10);
	Point* p = new Point(10, 10);
	arr.StoragePrint();
	arr.Add(p, 6);
	arr.StoragePrint();

}