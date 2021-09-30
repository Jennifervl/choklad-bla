# H5Chocolate

* Jobba i grupper om max 5 personer
* Alla i gruppen ska göra commits till ert repo.

*Innan ni börjar koda ska ni skapa en lösningsbeskrivning och stämma av den med mig. Om jag förstår och accepterar vad ni tänkt så kan ni börja koda!*

Lycka till!

## Uppgiftsbeskrivning 
Vi på H5 vill ta fram en konsolapplikation för att testa hur vår chokladförsäljning skulle kunna fungera på webben. För att inte lägga för mycket tid på grafik och användargränssnitt vill vi göra en enkel konsolapplikation. Det vi behöver kunna göra i applikationen är detta:

* Logga in som användare med personnummer (Vi kan fejka en BankID-inloggning så länge. Alla personnummer är godkända och en användare skapas utifrån det personnummer som skrivs in. En FakeBankID-klass kan vara användbart här! ).
* Visa orderhistorik
* Skapa en ny order
* Lägga till skräddarsydd choklad till ordern
* Det kan tänkas att vi vill kunna sälja mer än bara choklad, så lägg till produktsorten Keps också. En basklass för produkter kan vara bra att ha. 
* Flera olika pprodukter skall kunna läggas till en och samma order
* Beräkna pris på ordern
* Välja organisation att donera chokladpriset till
* Se sammanställning av order
* Bekräfta order

Exempel på gränssnitt och flöde

```cs
-- H5 CHOCOLATE --

*Logga in med personnummer: 810203-5643

Inloggning lyckades! / Felaktigt personnummer
```

```cs
-- H5 CHOCOLATE --

1) Visa orderhistorik
2) Lägg en ny order
3) Avsluta
*Val: 1
```

```cs
-- H5 CHOCOLATE --

ORDERHISTORIK

Order no.    Datum         Varor         Pris        Status
2331         2021-10-01    Choklad x3    913.00kr    Levererad
5812         2021-12-23    Choklad x1    145.00kr    Packas
```

```cs
-- H5 CHOCOLATE --

NY ORDER:

1) Choklad
2) Keps
*Val: 1

Ange procent kakao (10%-90%): 23
Lägg till en fyllning:
1) Guldflarn
2) Romrussing
3) Kaktusmos
4) Ingen fyllning
*Val: 1
*Vill du lägga till mer fyllning? (J/n): n

Priset för din chokladkaka blir: 3500.00kr
Vilken organisation vill du donera till?
1) WWF
2) FN
3) H5
4) Slumvis valt
*Val: 4

*Order skapad. Vill du lägga till mer choklad till din order? (J/n): n
```

```cs
-- H5 CHOCOLATE --

ORDERBEKRÄFTELSE

Beställare: 810203-5643
Order no: 39487
Datum: 2021-12-03

Varor:
* Choklad 23% med guldflarn á 3500.00kr

Pris totalt: 3500.00kr

*Bekräftar du denna order? (J/n): j
Tack för din beställning!
```
