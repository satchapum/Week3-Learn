class Project {

    public static string InputLowerNumber() {
        Console.Write("Please input Lower number : ");
    
        return Console.ReadLine();
    }

    public static string InputUpperNumber() {
        Console.Write("Please input Upper number : ");
    
        return Console.ReadLine();
    }

    public static string InputNumber() {
        Console.Write("Please input Lowwer number : ");
    
        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string value) {
        if (int.TryParse(value, out int number)) {
            return number;
         }

       throw new Exception("Please input decimal data."); 
    }

    public static bool IsTrue(int Input, int Lower, int Upper) {
        
        return Input > Lower && Input < Upper ;
    }

    public static void PrintOutput(bool Check) {
        if(Check == true) {
        Console.WriteLine("Output = True");
        }
        else {
            Console.WriteLine("Output = False");
        }
    }

    public static void Main(string[] args) {
        string LowerNumberText = InputLowerNumber();
        string UpperNumberText = InputUpperNumber();
        string InputNumberText = InputNumber();
        int LowerNumber = ConvertStringToInt(LowerNumberText);
        int UpperNumber = ConvertStringToInt(UpperNumberText);
        int InputNumberInt = ConvertStringToInt(InputNumberText);
        bool Check = IsTrue(InputNumberInt, LowerNumber, UpperNumber);

        PrintOutput(Check);
    }

}