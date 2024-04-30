
//functions
//types
/*
1. no return no parameter
2. return no parameter
3. no return parameter
4. return parameter
 
 

 void  Greet()
{
    Console.Write("Hi");
}


Greet(); 
string Greet2()
{
    return"Hi";
}

Console.WriteLine(Greet2());
*/

void Greet3(string a)
{
    Console.WriteLine("Hi , "+a);
}

Greet3("haris");

string Greet4(string a, int age)
{
    return("Hi , " + a + " your age is :" +age);
}

Console.WriteLine(Greet4("haris", 23));