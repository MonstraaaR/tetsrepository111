/*int num = new Random().Next (10,100);
string NumStr = num.ToString();
if (NumStr.Length == 2) {
    Console.WriteLine ($" Ваша первая цифра числа {NumStr[0]} Ваша вторая цифра числа {NumStr[1]}");
    if (NumStr[0] > NumStr [1]){
        Console.WriteLine (NumStr[0]);
    }
}
    else {
        Console.WriteLine (NumStr[1]);
    } */

/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Если решаете математически через рандом, то проверка не нужна на трехзначность. Если через строки, то она обязательна)
456 -> 5
782 -> 8
918 -> 1 */


/*int num = new Random().Next (100,1000);
string NumStr = num.ToString();
if (NumStr.Length == 3){
    Console.WriteLine ($"Ваше число {NumStr} вторая цифра этого числа {NumStr[1]}" );
} 

Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Если решаете математически максимум берем 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/*Console.WriteLine ("Введите число:");
int number = int.Parse (Console.ReadLine()!);
string NumStr = number.ToString();
if (NumStr.Length >= 3 && number > 0){
    Console.WriteLine ($"Третья цифра вашего числа {number} равна {NumStr[2]}");
    }
    else if (NumStr.Length >= 3 && number < 0){
    Console.WriteLine ($"Третья цифра вашего числа {number} равна {NumStr[3]}");
}
else {
    Console.WriteLine ($"Третья цифра вашего числа {number} отсутствует");
} */

/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. (Проверка выхода за пределы значений недели, т.е. < 1 и > 7)
6 -> да
7 -> да
1 -> нет */


