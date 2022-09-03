class Program {

    public static string InputNumberText() {
        Console.Write("Input Number of pow :");

        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string value) {
        int.TryParse(value, out int number);

        return number;
    }

    public static int Operation(int power) {
        if(power == 0) {
            return 1;
        }

        return 2 * Operation(power - 1);   
    }

    public static void PrintAnswer(int Number, int Answer) {
        Console.WriteLine("{0} Pow of 2 is {1} ",Number ,Answer);
    }

    public static void Main(string[] args) {
        string NumberText = InputNumberText();
        int Number = ConvertStringToInt(NumberText);
        int Answer = Operation(Number);
        
        PrintAnswer(Number,Answer);
    }
}