namespace Library
{
    public class ChatBot
    {
        public ChatBot()
        {
            Console.WriteLine("Hello, I am a chat bot.");
            string responseUser = Console.ReadLine();
            Console.WriteLine("Are you an eployee or an employer?. If you are an employer enter 1,If you are an employee,enter 2.");
            string responseUser1 = Console.ReadLine();

            if (responseUser1=="1")
            {
                Console.WriteLine("Hello employer ,please enter your name and surname,the email ,your adress and your phone number,all separated by a space.");
                string  personalInfo = Console.ReadLine();
                string[] personalInfoArray = personalInfo.Split(' ');

                Console.WriteLine("To crate offers,enter 1.To see offers,enter 2.To qualify an employer ,enter 2 and to gain reputation be an an employer enter 3 .");
                string responseUser2 = Console.ReadLine();

                if  (responseUser2=="1")

                {
                    Console.WriteLine("Enter the offer ID,description,price and category,all separated by a space.");
                    string offerInfo = Console.ReadLine();
                    string[] offerInfoArray = offerInfo.Split(' ');
                    Console.WriteLine("The offer has been created.");
                }

                
            
            }   

        }
    }
}