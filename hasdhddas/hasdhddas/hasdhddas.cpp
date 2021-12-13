#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

class Based {
protected:
	char code = 'B'; // для того что бы фабрика принимает код
	int x = 0, y = 0;
public:
	virtual char getCode() {
		return code;
	}
	virtual void print() {}
	virtual ~Based() {
		printf("\t\t~Base()\n");
	}
};

class Point : public Based {
private:
	int x, y;
public:

	char getCode() override {
		return 'P';
	}
	Point() {
		x = 0;
		y = 0;

	}
	Point(const Point* p) {
		x = p->x; // скидываем  в x, y
		y = p->y;
	}
	Point(int _x, int _y) {
		x = _x;
		y = _y;
	}

	void print() override {
		printf(" \t%i %i\n", x, y);
	}
	void SetXY(int x, int y) {
		printf("SetXY()\n"); //  сюда мы вводим  x y (опять)
		this->x = x;
		this->y = y; // мы указываем координаты точки.
	}
	int getX() {
		return x;
	}
	int getY() {
		return y;
	}

	~Point() {
		printf("\t\t~Point\n");
	}
};
class Segment :public Based {
private:
	//int x1, x2, y1, y2;
	Point* p1;
	Point* p2;

public:
	char getCode() override {
		return 'S'; //  для фабрики
	}
	Segment() {
		printf("\tSegment() %p\n", this); // адрес  объекта
		p1 = new Point;
		p2 = new Point;
	}
	Segment(Point* _p1, Point* _p2) {
		printf("\tSegment() %p\n", this);
		p1 = new Point(_p1);
		p2 = new Point(_p2);
	}
	Segment(const Segment* segment) {
		printf("\tSegment() %p\n", this);
		p1 = new Point(segment->p1); // конструктор копирование отрезков
		p2 = new Point(segment->p2);
	}

	void print() override {
		printf("\tsegment {\n");
		//printf("\t");
		p1->print(); // распечатываються координаты точки p1
		//printf("\t");
		p2->print();
		printf("\t}\n");
	}
	~Segment() {
		printf("\t\t~Segment %p\n", this);
		printf("\t\t{\n");
		delete p1;
		delete p2;
		printf("\t\t}\n");
	}
};
class Factory
{
public:
	Based* CreateBased(Based* obj) {

		Based* res = nullptr;
		switch (obj->getCode()) {
		case 'P':
			res = new Point((Point*)(obj));
			break;
		case 'S':
			res = new Segment((Segment*)obj);
			break;
		}
		return res;
	}

};

class Storage
{
private:
	int size = 0;
	Based** mas;
	
public:
	Storage(int size) { //size == N в записи arr[N]
		this->size = size;
		mas = new Based * [size];	//arr[N]
	}
	void add(Based* obj, int index) {
		Factory factory;
		mas[index] = factory.CreateBased(obj);
	}
	Based* Get(int index) {
		if (mas[index] == nullptr) {
			printf("По хаданнмоу индексу не существует элемента");
			exit(228);

		}
		Factory factory;
		return factory.CreateBased(mas[index]);
	}

	Based* GetDel(int index, Based* tmp) {
		/*if (mas[index] == nullptr) {
			printf("По хаданнмоу индексу не существует элемента");
			exit(228);
		}*/

		Factory factory;
		tmp = factory.CreateBased(mas[index]);
		delete mas[index];
		mas[index] = nullptr;
		return tmp;
	}
	int  GetSize() {

		return size;
	}
	Based** base() {
		for (int i; i < size, i++;)
			printf("Вывод хранилища:\n[\n");
	}

};
int main() {
	setlocale(LC_ALL, ("RUS"));
	Storage arr(10);
	//Storage a();
	printf("Создание объектов Point и добавление их в хранилище Storage\n");
	for (int i = 0; i < 10; i++) {
		Point* t = new Point(i, i);
		arr.add(t, i);
		//arr.add(new Point(i, i), i);
	}
	for (int i = 0; i < 10; i++) {
		arr.Get(i)->print();
	}


}
