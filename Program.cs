// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main()
    {
        Program P = new Program();


        Console.WriteLine("введите число строк");
        int n = Convert.ToInt32(Console.ReadLine());
        char[] Delim = { ' ', ',', '_' };
        string[] MainRowBank = new string[n];

        Console.WriteLine("Заполните массив предложениями, используя разделители: пробел, запятую либо нижний слэш");
        P.InputDataToArray(ref MainRowBank);

        if (MainRowBank[0] is not null)
        {
            int k = 1;
            string[] RLine;
            string[] ChildRowBank = new string[1];

            for (int i = 0; i < MainRowBank.Length; i++)
            {
                string? Sent = null;
                RLine = MainRowBank[i].Split(Delim);
                for (int j = 0; j < RLine.Length; j++)
                {
                    if (RLine[j].Length <= 3)
                    {

                        Sent = Sent + " " + RLine[j];
                    }

                }
                if (Sent != null)
                {
                    if (ChildRowBank[0] != null)
                    {
                        k = k + 1;
                        Array.Resize(ref ChildRowBank, k);
                    }
                    P.ReadDataToArray(ref ChildRowBank, Sent);
                }
            }
            P.OutPutResult(ChildRowBank);
        }
    }

    void InputDataToArray(ref string[] Mas)
    {
        for (int i = 0; i < Mas.Length; i++)
        {
            Mas[i] = Console.ReadLine(); // проверка на null в основном методе
        }
    }

    void ReadDataToArray(ref string[] Mas, string p)
    {
        for (int i = 0; i < Mas.Length; i++)
        {
            if (Mas[i] == null)
            {
                Mas[i] = p;
                break;
            }
        }
    }

    void OutPutResult(string[] Mas)
    {
        Console.WriteLine("Новый массив: ");
        for (int i = 0; i < Mas.Length; i++)
        {
            Console.WriteLine(Mas[i]);
        }
    }
}

