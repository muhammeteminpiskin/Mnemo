namespace Mnemo.Core;

public class Card
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required Guid DeckId { get; init; }
    public required string Front { get; init; }
    public required string Back { get; init; }
    public CardState State { get; set; } = CardState.New;
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? DueAt { get; set; }


}
