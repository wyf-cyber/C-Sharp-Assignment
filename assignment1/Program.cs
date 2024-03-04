using System;
using static System.Console; // 确定命名空间
class Calculator
{
    static void Main()
    {
        WriteLine("Welcome To Use My Calculator");
        // 获取两个计算数
        WriteLine("Type the two numbers that will be calculated later:");
        int a = Convert.ToInt32(ReadLine());
        int b = Convert.ToInt32(ReadLine());
        // 获取计算类型
        WriteLine("Please choose the type of calculation from the following list:");
        WriteLine("A.add  B.sub  C.mul  D.div");
        // 根据用户输入的选项进行相应的计算并输出结果
        // C# 中switch语句支持string类型
        switch (ReadLine())
        {
            case "A":
                WriteLine(a + b);
                break;
            case "B":
                WriteLine(a - b);
                break;
            case "C":
                WriteLine(a * b);
                break;
            case "D":
                WriteLine(a / b);
                break;
            default:
                WriteLine("Invalid operator");
                break;
        }
        // 还需要添加关闭窗口逻辑，否则将会出现提前退出的状况
        WriteLine("Please type any key to close the window.");
        string s = ReadLine();
    }
}