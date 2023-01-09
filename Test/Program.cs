using System.Text;
using YoutubeLiveChatSharp;

// lofi hip hop https://www.youtube.com/watch?v=jfKfPfyJRdk
ChatFetch f = new ChatFetch("jfKfPfyJRdk");

// 文字コードの設定
Console.OutputEncoding = Encoding.UTF8;

while (true)
{
    // 取得して表示
    f.Fetch().ToList().ForEach(c => ShowComment(c));

    // 負荷を掛けすぎないようにちょっと待つ
    await Task.Delay(1000);
}

void ShowComment(Comment c)
{
    Console.WriteLine(
        $"name: {c.userName}\n" +
        $"    message: {c.text}\n" +
        $"    userId: {c.userId}\n" +
        $"    commentId: {c.commentId}");
}
