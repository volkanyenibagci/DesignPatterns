// See https://aka.ms/new-console-template for more information
using DesignPatterns.BehavioralPatterns.Mediator;

Console.WriteLine("BEHAVIORAL DESIGN PATTERNS!");

#region Mediator

//Bu örnekte, IChatRoomMediator arayüzü, Mediator'un temel işlevlerini tanımlar. ChatRoom sınıfı bu arayüzü uygular ve ShowMessage metodunu gerçekleştirir. Bu metod, bir kullanıcı tarafından gönderilen mesajı alır ve onu konsola yazdırır. User sınıfı, mesaj göndermek için Mediator'u kullanır. SendMessage metodu, kullanıcının bir mesaj göndermek istediğinde çağrıldığı yerdir.

IChatRoomMediator chatRoom = new ChatRoom();

User user1 = new User("John", chatRoom);
User user2 = new User("Jane", chatRoom);
User user3 = new User("Doe", chatRoom);

user1.SendMessage("Hi there!");
user2.SendMessage("Hey!");
user3.SendMessage("Hello everyone!");

#endregion Mediator