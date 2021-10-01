Client.MessageReceived += async socketMessage => 
{
  if (m.ShouldHandle(out var userMessage) && um.Content.Contains("ping")) 
  {
    await userMessage.ReplyAsync("pong!");
  }
};
