using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
    "AsyncCompletionSample",
    Namespace = "AsyncCompletionSample",
    Version = "1.0"
)]

[assembly: AddinName("AsyncCompletionSample")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("Demonstrates xPlat Async Completion in Visual Studio")]
[assembly: AddinAuthor("Amadeusz Wieczorek")]
