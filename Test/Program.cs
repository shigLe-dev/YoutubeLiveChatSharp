using YoutubeLiveChatSharp;

ChatFetch f = new ChatFetch("jfKfPfyJRdk");

while (true)
{
    // 取得して表示
    f.Fetch().ToList().ForEach(c => Console.WriteLine(c.text));

    // 負荷を掛けすぎないようにちょっと待つ
    await Task.Delay(1000);
}