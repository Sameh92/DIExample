namespace DIExample.Models
{
    public class WelcomeMessageForMiddleWare
    {

        private readonly string _welcome;
        public WelcomeMessageForMiddleWare()
        {
            _welcome = "Hello MeddleWare From Sameh";
        }
        public string GetWelocme { get => _welcome; }

    }
}
