#include <iostream>
using namespace std;

// Temel Sınıf: Person
class Person {
protected:
    string name;
    int age;

public:
    // Yapıcı Fonksiyon (Constructor)
    Person(string n, int a) : name(n), age(a) {}

    // Bilgileri Görüntüleme
    virtual void displayInfo() {
        cout << "Name: " << name << endl;
        cout << "Age: " << age << endl;
    }
};

// Türemiş Sınıf: Student
class Student : public Person {
private:
    string studentID;

public:
    // Yapıcı Fonksiyon (Constructor)
    Student(string n, int a, string id) : Person(n, a), studentID(id) {}

    // Bilgileri Görüntüleme
    void displayInfo() override {
        Person::displayInfo(); // Temel sınıfın bilgilerini görüntüle
        cout << "Student ID: " << studentID << endl;
    }
};

// Türemiş Sınıf: Teacher
class Teacher : public Person {
private:
    string subject;

public:
    // Yapıcı Fonksiyon (Constructor)
    Teacher(string n, int a, string sub) : Person(n, a), subject(sub) {}

    // Bilgileri Görüntüleme
    void displayInfo() override {
        Person::displayInfo(); // Temel sınıfın bilgilerini görüntüle
        cout << "Subject: " << subject << endl;
    }
};

// Ana Fonksiyon
int main() {
    // Student Nesnesi Oluşturma
    Student student("Ali", 20, "S12345");
    cout << "Student Information:" << endl;
    student.displayInfo();
    cout << endl;

    // Teacher Nesnesi Oluşturma
    Teacher teacher("Ayşe", 35, "Mathematics");
    cout << "Teacher Information:" << endl;
    teacher.displayInfo();

    return 0;
}
