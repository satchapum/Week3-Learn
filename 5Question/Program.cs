class Program {

    public static string InputSeatNumber() {
        Console.Write("Please Input Seatnumber : ");

        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string value) {
        int.TryParse(value, out int number);

        return number;
    }

    public static int CheckSeatNumber(int i) {
        int[] NumberOfSeat = { 1, 2, 3, 4, 5, 6, 7, 8 ,1 ,2 ,3 ,4};
        
        return NumberOfSeat[i]; 
    }

    public static void PrintAnswer(int[] seatUse) {
        Console.WriteLine("Number of seat is : {0} {1} {2} {3}",seatUse[0], seatUse[1], seatUse[2], seatUse[3]);
    }
    
    public static void Main(string[] args) {
        string SeatNumberText = InputSeatNumber();
        int SeatNumber = ConvertStringToInt(SeatNumberText);
        int[] SeatUse = new int[4];
        for (int i = 0; i <= 3; i++) {
            SeatUse[i] = CheckSeatNumber(SeatNumber);
            SeatNumber++;
        }

        PrintAnswer(SeatUse);
    }    
}