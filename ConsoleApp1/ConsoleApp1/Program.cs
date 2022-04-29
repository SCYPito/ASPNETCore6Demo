//// See https://aka.ms/new-console-template for more information
//int[] a = { 1, 3, 5, 7, 9, 8, 6, 4, 2 };
//int list = 9, tmp;
//for (int i = 0; i < list; i++) {
//    tmp = a[i];
//    a[i] = a[list - i - 1];
//    a[list - i - 1] = tmp;
//}
//for(int i = 0; i <= list/2; i++) 
//{
//    Console.WriteLine($"{a[i]},{a[list - i-1]}");
//}
int bigOfN = 0;
int smallOfN = 0;
int[] n= { 70, -4, 55, 13, -12,96,60 };
for (int i = 0; i < n.Length; i++)
{
    for (int j = 0; j < n.Length - i - 1; j++)
    {
        if (n[j] > n[j + 1])
        {
            int temp = n[j];
            n[j] = n[j + 1];
            n[j + 1] = temp;
        }
    }
}
for (int i = 0; i < n.Length; i++)
{
    if(n[i] > 60) 
    {
        bigOfN ++;
    }
    if (n[i] < 50) 
    {
        smallOfN++;
    }
}
Console.WriteLine("result");
foreach (int b in n)
{
    Console.Write(b + " ");
}
Console.WriteLine("\n");
Console.WriteLine($"大於60的整數個數:{bigOfN}\n小於50的整數個數:{smallOfN}");