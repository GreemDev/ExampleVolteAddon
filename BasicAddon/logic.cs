Client.MessageReceived += async socketMessage => 
{
  if (socketMessage.ShouldHandle(out var userMessage) && userMessage.Content.Contains("ping")) 
  {
    await userMessage.ReplyAsync("pong!");
  }
};
