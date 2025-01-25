//class = blueprint for creating objects and defines the properties and methods of objects
//object = instance of a class
//syntax to create object of a class: ClassName objectName = new ClassName();



namespace day2;

    public class Car 
    {
        public string Make;
        public string Model;
        public int Year;
        public string Color;
        

        //method
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model} {Color}");
        }
    }


