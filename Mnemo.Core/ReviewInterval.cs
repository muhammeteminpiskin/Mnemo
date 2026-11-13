namespace Mnemo.Core;

public readonly record struct ReviewInterval
{
    public int Days { get; }

    public ReviewInterval (int days)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(days);
        Days = days;
    }

    public static ReviewInterval Zero = new(0);
    public static ReviewInterval OneDay = new(1);

    public ReviewInterval AddDays(int extraDays) => new(Days + extraDays);

    public DateTimeOffset ApplyTo(DateTimeOffset reviewedAt) => reviewedAt.AddDays(Days);

    public override string ToString() => Days == 1 ? "1 gün" : $"{Days} gün";
}
