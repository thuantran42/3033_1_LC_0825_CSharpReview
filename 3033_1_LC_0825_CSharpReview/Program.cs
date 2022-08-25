// Thuan (Trae) Tran 113437456
//Lecture Code 08 25


//Variables, Expressions & Statements
int age = 2 + 3 * 2 + 4 / 2;


//comparison operators, conditional logical operators 

bool isResult = 2 > 3; // false
isResult = 3 <= 3; // true
isResult = 4 == 5; // false
isResult = 5 != 5;

age = 6;

isResult = !(age >= 65 || age < 6);

int r = 7 % 4;


//keyword: const

const double taxRate = 0.0875;

/* taxRate = 0.07 */
/*  const does not allow you to reassign */



//data type converstion: convert.ToDouble convert.ToInt32

double grade;

string userInputSring = Console.ReadLine();

grade = Convert.ToDouble(userInputSring);

string outputString = string.Format($"The grade is {grade:F2} {grade:C2}");
Console.WriteLine(outputString);

//string interpolation

//string.format("{0} {2}", var1, var2,...)
//string.format($"{var1} {var2}")
//Standard numeric format strings: F2, C2


//conditional statement: if ... else if...else

//if (bool value) 
//{
//     statements....
//}


//if (bool value)
//{
//    ....
//}
//else
//{

//}

//if ()
//{

//}

//else if ()
//{ }
//else if ()
//{ }
//else { }

if (grade > 85) // above the grade 85
{
    Console.WriteLine("Congrats! A");
    Console.WriteLine("Congrats! ");
    Console.WriteLine("Congrats! ");
}
else if (grade >= 75 && grade <= 85) //between 75 and 85 
{
    Console.WriteLine("Work harder!");
    Console.WriteLine("Work harder!");
    Console.WriteLine("Work harder!");
}
else
{
    Console.WriteLine("B");
    Console.WriteLine("B");
    Console.WriteLine("B");

}


//    loops(break continue )
//for (; ; ) { }
//while () { }
//do { } while ();
//method / function
//datatype method_name(optinal parameters) { ...return datatype_value; }


Console.ReadLine();
