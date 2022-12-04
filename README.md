# YoutubeLiveChatSharp

YoutubeLiveChatをAPI無しで取得できる、C#ライブラリです。

## 使用方法

```c#
using YoutubeLiveChatSharp;

var chat = new ChatFetch(liveID);
var comments = chat.Fetch();
```

liveIDは以下のxxxxxxxxxxxに当たる部分です。

```url
https://www.youtube.com/watch?v=xxxxxxxxxxx
```

Fetch関数は、前回に呼び出したよりも後に送信されたコメントを取得します。

一度だけではなく、定期的に呼び出してください。
