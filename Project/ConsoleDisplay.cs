using System;

public static class ConsoleDisplay
{
    public static void PrintResultWithPadding(string[] datas, int[] paddings)
    {
        if(datas.Length != paddings.Length)
            {
                Console.WriteLine("Error: Padding array size is different from element parametes");
                return;
            }
            for (int i = 0;i < datas.Length;i++)
            {
                Console.Write(datas[i].PadRight(paddings[i]));
            }
            Console.WriteLine();
    }
}