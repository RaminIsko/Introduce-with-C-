// 2ex
Console.Write("Enter first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
if(number1 > number2){
    Console.WriteLine($"Максимальное число: {max}");
}else{
    max = number2;
    Console.WriteLine($"Максимальное число: {max}");
}

//4ex
Console.Write("Enter first number: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNum = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int thirdNum= int.Parse(Console.ReadLine());
int max4 = firstNum;
if(firstNum > secondNum && firstNum > thirdNum){
    Console.WriteLine($"Максимальное число: {max4}");
}else if(secondNum > firstNum && secondNum > thirdNum){
    max4 = secondNum;
    Console.WriteLine($"Максимальное число: {max4}");
}else{
    max4 = thirdNum;
    Console.WriteLine($"Максимальное число: {max4}");
}

//3ex
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
if(number % 2 == 0 ){
    Console.WriteLine($"Число {number} четное ");
}else{
    Console.WriteLine($"Число {number} не четное");
}

//4ex
Console.Write("Enter number: ");
int num1 = int.Parse(Console.ReadLine());
for(int i = 1; i < num1; i++){
    if(i % 2 == 0){
        Console.Write(i + " ");
    }
}