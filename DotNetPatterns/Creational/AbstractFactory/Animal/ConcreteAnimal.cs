using System.Text;

namespace DotNetPatterns.Creational.AbstractFactory.Animal
{
    class ConcreteAnimal : IAnimal
    {
        private readonly string Head;
        private readonly string Body;
        private readonly string Members;
        private readonly string Voice;

        public ConcreteAnimal(string head, string body, string members, string voice)
        {
            Head = head;
            Body = body;
            Members = members;
            Voice = voice;
        }

        public string GetDescription()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(string.Format("Head of: {0}", Head)).AppendLine()
                .Append(string.Format("Body of: {0}", Body)).AppendLine()
                .Append(string.Format("Members of: {0}", Members)).AppendLine()
                .Append(string.Format("And says: {0}", Voice)).AppendLine();
            return strBuilder.ToString();
        }
    }
}
