namespace PractAsync1
{
    internal class Class1
    {
        private string _result = string.Empty;

        public event Action<string> State;

        public void Random(string result)
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            if (number == 0)
            {
                result = $"{EnumStatus.Cancel}";
            }
            else if (number == 1)
            {
                result = $"{EnumStatus.Ok}";
            }

            _result = result;
        }

        public async void OpenAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Open");
                Thread.Sleep(3000);
                Console.WriteLine("Close");

                State.Invoke(_result);           
            });

            if (_result == "Ok")
            {
                Console.WriteLine("Operation was confirmed");
            }
            else if (_result == "Cancel")
            {
                Console.WriteLine("Operation was denied");
            }
        }
    }
}
