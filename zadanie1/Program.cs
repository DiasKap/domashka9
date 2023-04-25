using static System.Console;
 Write("Число: ");
int n = int.Parse(ReadLine());
int Number(int n, int m)
{
  if (n == m) return n;
  else Write($"{Number(n, m + 1)}, ");
  return m;
}
WriteLine(Number(n, 1));