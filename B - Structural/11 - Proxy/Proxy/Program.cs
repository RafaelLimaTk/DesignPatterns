Console.Title = "Proxy pattern";

Console.WriteLine("Constructing document.");
var myDocument = new Proxy.Document("mydocument.pdf");
Console.WriteLine("Document constructed.");
myDocument.Display();

Console.WriteLine();

// with proxy
Console.WriteLine("Constructing document with proxy.");
var myDocumentProxy = new Proxy.DocumentProxy("mydocument.pdf");
Console.WriteLine("Document proxy constructed.");
myDocumentProxy.Display();

//with proxy, no access
Console.WriteLine("Constructing protected document with proxy.");
var myProtectedDocumentProxy = new Proxy.ProtectedDocumentProxy("mydocument.pdf", "ViewRole");
Console.WriteLine("Protected Document proxy constructed.");
myProtectedDocumentProxy.Display();

Console.ReadKey();
