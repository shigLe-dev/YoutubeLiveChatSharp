using YoutubeLiveChatSharp;

ChatFetch f = new ChatFetch("jfKfPfyJRdk");

while (true)
{
    f.Fetch().ToList().ForEach(c => Console.WriteLine(c.text));

    await Task.Delay(1000);
}