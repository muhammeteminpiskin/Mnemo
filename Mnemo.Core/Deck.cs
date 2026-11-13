namespace Mnemo.Core;

public class Deck
{
    private readonly List<Card> _cards = [];

    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Name { get; init; }
    public string? Description { get; init; }
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;

    public IReadOnlyList<Card> Cards => _cards;
}
