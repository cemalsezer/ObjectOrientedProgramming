class Person{
    private string _name;
    private int _age;

    public string Name { 
    get{return _name;}
    set{
        if(!string.IsNullOrEmpty(value))
        {
            _name = value;

        }
        else
        {
            throw new ArgumentException("Doğru değer girilmedi!");

        }
    } 
    }
    public int Age { 
        get{return _age;} 
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Yaş pozitif değer olmalı!");
            }
            else
            {
                _age = value;
            }

        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display(){
        Console.WriteLine($"İsim: {Name}, Yaş: {Age}");
    }
}