int number = int.Parse(Console.ReadLine());
VasyaStyle(number);

List<int> Numbers(int number)
{
    int KolvoCifr = 1;
    int TempNumber = number;
    List<int> Chisla = new List<int>();
    while (TempNumber > 10)
    {
        KolvoCifr++;
        TempNumber /= 10;
    }

    for (int j = 0; j < number; j++)

    {
        int temp = j;
        int k = 0;
        while (k < KolvoCifr)
        {
            k++;
            if (temp % 10 == 2 || temp % 10 == 3 || temp % 10 == 7)
            {
                if (temp < 10)
                {
                    Chisla.Add(j);
                    break;
                }
                else
                {
                    temp /= 10;
                    continue;
                }
            }
            else break;
        }
    }
    return Chisla;
}

int VasyaStyle(int number)
{
    byte temp = 0;
    List<int> tempC = new List<int>();
    foreach (var a in Numbers(number / 2 + 1))
    {
        foreach (var b in Numbers(number))
        {
            foreach (var c in Numbers(number))
            {
                if ((a * b) + c == number)
                {
                    if (tempC.Contains(c)) continue;
                    else
                    {
                        Console.WriteLine(number + " = " + a + " * " + b + " + " + c);
                        tempC.Add(c);
                        temp++;
                    }
                }
            }
        }
    }
    if (temp == 0) Console.WriteLine("No suitable combinations");
    return number;
}
