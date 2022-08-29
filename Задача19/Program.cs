// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
result = RevertNum(number);
Palynodrome();

int RevertNum(int count)
{
while (count > 0)
{
result *= 10;
result += count % 10;
count /= 10;
}
return result;
}
void Palynodrome()
{
if (number == result)
{
Console.WriteLine("Число " + number + " является палиндромом");
}
else
{
Console.WriteLine("Число " + number + " не является палиндромом");
}
}
