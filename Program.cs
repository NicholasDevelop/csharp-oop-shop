
using csharp_oop_shop;
Random r = new Random();

Prodotto prod = new Prodotto("pasta", "pennette", 0.89, 22);

prod.CodiceProdotto();
prod.BasePrice();
prod.PriceIva();
prod.ExtendedName();
prod.NewCode();