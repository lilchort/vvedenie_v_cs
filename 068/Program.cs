// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введи n: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи m: ");
int m = Convert.ToInt16(Console.ReadLine());

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if ((m > 0) && (n == 0)) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
