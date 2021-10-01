Client.MessageReceived += async socketMessage => 
{
  if (m.ShouldHandle(out var userMessage) && userMessage.Content.Contains("ping")) 
  {
    await userMessage.ReplyAsync("pong!");
  }
};
