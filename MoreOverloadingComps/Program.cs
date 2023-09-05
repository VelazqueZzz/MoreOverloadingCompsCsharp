using System;

class MyClass
{
    public int code;
    public MyClass(int n)
    {
        code = n;
    }
    public static MyClass operator <= (MyClass a, MyClass b)
    {
        if (a.code <= b.code) return a;
        else return b;
    }
    public static MyClass operator>=(MyClass a,MyClass b)
    {
        if (a.code >= b.code) return a;
        else return b;
    }
    public static bool operator<=(MyClass a,int x)
    {
        if (a.code <= x - 1) return true;
        else return false;
    }
    public static bool operator>=(MyClass a,int x)
    {
        if (a.code >= x + 1) return true;
        else return false;
    }
    public static bool operator <(MyClass a, MyClass b) {
        return a.code < b.code;
    }
    public static bool operator>(MyClass a,MyClass b)
    {
        return a.code > b.code;
    }
    public static int operator<(MyClass a,int x)
    {
        return x - a.code;
    }
    public static int operator>(MyClass a,int x)
    {
        return a.code - x;
    }
}
class MoreOverloadingCompsDemp
{
    static void Main()
    {
        MyClass A = new MyClass(100);
        MyClass B = new MyClass(200);
        Console.WriteLine("Object A: {0}",A.code);
        Console.WriteLine("Object B: {0}",B.code);
        Console.WriteLine("A<B daet {0}", A < B);
        Console.WriteLine("A>B daet {0}", A > B);
        MyClass C;
        C = A >= B;
        C.code = 300;
        Console.WriteLine("Object B: {0}", B.code);
        C = A <= B;
        C.code = 150;
        Console.WriteLine("Object A: {0}", A.code);
        (B <= A).code = 500;
        Console.WriteLine("Object A: {0}", A.code);
        int x = 400, y = 500, z = 600;
        Console.WriteLine("A<={0} daet {1}", x, A <= x);
        Console.WriteLine("A>={0} daet {1}", x, A >= x);
        Console.WriteLine("A<={0} daet {1}", y, A <= y);
        Console.WriteLine("A>={0} daet {1}", y, A >= y);
        Console.WriteLine("A<={0} daet {1}", z, A <= z);
        Console.WriteLine("A>={0} daet {1}", z, A >= z);
        Console.WriteLine("A<{0} daet {1}", z, A < z);
        Console.WriteLine("A>{0} daet {1}", x, A > x);
    }
}
