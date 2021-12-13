#include <iostream>

class X {
private:
    int n = 300;
public:
    int get_n() {
        return n;
    }
};

int main()
{
    X obj;
    int xueta = obj.get_n();
}
