using Mediator;

Console.Title = "Mediator pattern";

TeamChatRoom teamChatroom = new();

Lawyer alice = new("Alice");
Lawyer kenneth = new("Kenneth");
AccountManager maria = new("Maria");
AccountManager john = new("John");
AccountManager bob = new("Bob");

teamChatroom.Register(alice);
teamChatroom.Register(kenneth);
teamChatroom.Register(maria);
teamChatroom.Register(john);
teamChatroom.Register(bob);

alice.Send("Hi all, Alice here.");
kenneth.Send("Hello Alice, Kenneth here.");
maria.Send("Welcome Alice and Kenneth, Maria here.");
john.Send("Hi everyone, John here.");
bob.Send("Hey all, Bob here.");