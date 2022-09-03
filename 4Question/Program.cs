class Program {

    public static string InputNumber() {
        Console.Write("Please input number : ");

        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string value) {
        int.TryParse(value, out int number);

        return number;
    }

    public static bool IsMinus(int Number) {
        return Number < 0;
    }

    public static int AbsCovert(int Number, bool MinusCheck) {
        int MathSign = Convert.ToInt32(MinusCheck);

        return Number + (Number * (-MathSign) * 2) ;
    }

    public static void PrintSumary(int Ans) {
        Console.WriteLine("Output is : {0}",Ans);
    }

    public static void Main(string[] args) {
        string NumberText = InputNumber();
        int Number = ConvertStringToInt(NumberText);
        bool MinusCheck = IsMinus(Number);
        int AbsOfNumber = AbsCovert(Number,MinusCheck);

        PrintSumary(AbsOfNumber);
    } 
}