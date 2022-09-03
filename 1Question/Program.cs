class Project {
    
    public static string InputNumber(int i) {
        Console.Write("Input Number {0} : ", i+1);

        return Console.ReadLine();
    } 

    public static int Summary(int[] NumberInt) {
        int Summary = 0;
        for(int i = 0; i <= 2; i++) { 
            Summary = Summary + NumberInt[i];
        }

        return Summary;
    }

    public static void PrintInformation(int Answer) {
        Console.WriteLine("Summary is : {0}", Answer);
    }

    static void Main(string[] args) {

        string[] NumberText = new string[3];
        for(int i = 0; i <= 2; i++) { 
            NumberText[i] = InputNumber(i);
        }
        int[] NumberInt = Array.ConvertAll(NumberText, int.Parse); 
        int Answer = Summary(NumberInt);

        PrintInformation(Answer); 
    }
}