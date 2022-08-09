Console.Write ("Введите целое число N: ");
int num = Convert.ToInt32 (Console.ReadLine ());
int count = 1, 
    check = 0;
Console.Write ("Все чётные числа от 1 до N: ");
while (num>count-1) 
{
    check = count % 2;
        if ( check == 0 ) Console.Write (count+" ");
    count++;
}