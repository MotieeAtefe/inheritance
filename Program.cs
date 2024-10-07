namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylander cylander = new Cylander();

            Console.Write("Please Enter redius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());


            cylander.setRadius(radius);
            cylander.SetHeight(height);  
            
           
            cylander.SetAreaCalculate(radius);
            cylander.SetVolume();


            Console.WriteLine($"The RediusCylander is: '{cylander.getRadius()}'");
            Console.WriteLine($"The HeightCylander is: '{cylander.GetHeight()}'");

            Console.WriteLine($"The AreaCalculate is: '{cylander.GetAreaCalculate()}'");
            Console.WriteLine($"The ValumeCylander is: '{cylander.GetVolume()}'");

        }
    }
}