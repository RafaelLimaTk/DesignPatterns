using ChainOfResponsibility;
using System.ComponentModel.DataAnnotations;

Console.Title = "Chain of Responsibility pattern";

Document validDocument = new(
    title: "How to Avoid Java Development",
    lastModified: DateTimeOffset.UtcNow,
    approvedByLitigation: true,
    approvedByManagement: true);
Document invalidDocument = new(
    title: "How to Avoid Java Development",
    lastModified: DateTimeOffset.UtcNow,
    approvedByLitigation: false,
    approvedByManagement: true);

var documentHandlerChain = new DocumentTitleHandler();
documentHandlerChain
    .SetSuccessor(new DocumentLastModifiedHandler())
    .SetSuccessor(new DocumentLitigationApprovalHandler())
    .SetSuccessor(new DocumentManagementApprovalHandler());

try
{
    documentHandlerChain.Handle(validDocument);
    Console.WriteLine("Valid document passed all checks.");
    documentHandlerChain.Handle(invalidDocument);
    Console.WriteLine("Invalid document passed all checks.");
}
catch (ValidationException validation)
{
    Console.WriteLine(validation.Message);
}