namespace ConsoleDIPlayground;

public class GetLocationUserMessage : IUserMessageComposer
{
  public UserMessage Compose(params object[] p) => new("🌍 [red]Getting current location...[/]    ", true);
}
