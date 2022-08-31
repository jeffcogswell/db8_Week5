// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

char ch = 'A';
Console.WriteLine(ch);
int value = (int)ch - 64; // Casting
Console.WriteLine(value);

ch = 'E';
Console.WriteLine(ch);
value = (int)ch - 64; // Cast
Console.WriteLine(value);

ch = 'Z';
Console.WriteLine(ch);
value = (int)ch - 64;
Console.WriteLine(value);

// How would we want to use the DrawDiamond class?
// Make a new instance each time? For example:

//DrawDiamond d1 = new DrawDiamond('E');
//d1.Draw();

// Or does it make more sense to not have to create an instance
// And just have static methods in the class like so:

//DrawDiamond.Draw('E');
//DrawDiamond.Draw('Z');

// int factorial = Calculator.FindFactorial(5);

// vs

// Calculator c1 = new Calculator(5);
// int factorial = c1.FindFactorial();

// double value = Math.Cos(3.1415926);


