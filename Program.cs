namespace GettingStarted;
using Newtonsoft.Json;
    class Program
    {
        static void Main()
        {
            // method
            // use void if the function doesn't return anything
            void DisplayMessage(string message)
            {
                Console.WriteLine($"{message}");
            }

            int[] myArray = {1,2,3,4};

            DisplayMessage("some new message");

            // ------ Mouse stuff

            var myMouse = new Mouse{Name ="Quieter"};
            myMouse.GetSecretCode();

            var jsonMouse = JsonConvert.SerializeObject(myMouse);
            var jsonArray = JsonConvert.SerializeObject(myArray);
            Console.WriteLine(jsonMouse);
            Console.WriteLine(jsonArray);

        }
    }
