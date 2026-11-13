using Mnemo.Core;

var deck = new Deck
{
    Name = "İngilizce Fiiller",
    Description = null
};

var card = new Card
{
    DeckId = deck.Id,
    Front = "Resilient",
    Back = "Dayanıklı, çabuk toparlanan"
};

// Referans semantiği gözlemi: aynı adresi paylaşan iki değişken
var aliasRef = card;
aliasRef.State = CardState.Learning;

Console.WriteLine($"Deck: {deck.Name} | Açıklama: {deck.Description ?? "(Yok)"}");
Console.WriteLine($"Card State: {card.State} (aliasRef üzerinden güncellendi)");
Console.WriteLine($"DueAt var mı: {(card.DueAt is null ? "Henüz çalışılmadı" : card.DueAt.ToString())}");