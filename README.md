# Willkommen zum Portfolioeintrag von *Dein Schatz*!

Dies ist mein erstes Spiel, das ich mit C# programmiert habe. Es ist im Lernatelier entstanden, einem Fach in der Informatikmittelschule, in dem wir eigene Projekte programmieren dürfen. Die Aufgabe des Spielers ist es, eine Zahl zwischen 1 und 100 zu erraten, um seinen Schatz zurückzubekommen.

### Ziel:
Ich möchte erklären, wie man ein If Statement korrekt verneint.

### Erklärung:
Ein If Statement ist so aufgebaut, dass man "if" schreibt und in Klammern eine Bedingung. Nur wenn diese Bedingung erfüllt ist, wird der Inhalt des If Statements ausgeführt. Wenn man aber will, dass es nur ausgeführt wird, wenn es nicht so ist, dann verwendet man ein "!" zur Verneinung. Bei einer Bedingung schreibt man es direkt vor das Ralationszeichen. Wenn man aber Bedingungen kombiniert (durch "&&" oder "||"), muss man aufpassen, das man die Ausrufezeichen richtig setzt. Wichtig ist hierbei zu beachten, dass man das "!" nicht einfach vor die Klammer des If Statements setzen darf, sondern eine neue Klammer einbauen muss.

### Beispiele mit einer Bedingung:
```csharp
if (attempts == 1) 
{
    // Mach das.
}
if (attempts != 1)
{
    // Mach das.
}

if (attempts > 1)
{
    // Mach das.
}
if (attempts !> 1) 
{
    // Mach das.
}
```

### Beispiele mit zwei Bedingungen:
Positiv: `if (guess > 0 && guess < 101)` Bedeutung: Wenn guess zwischen 0 und 101 liegt.

Negativ 1: `if (guess !> 0 && guess !< 101)` Bedeutung: Wenn guess höchstens 0 und mindestens 101 ist. (Das ist nicht möglich.)

Negativ 2: `if (!(guess > 0 && guess < 101))` Bedeutung: Wenn guess nicht zwischen 0 und 101 liegt.

**NICHT:** `if !(guess > 0 && guess < 101)` Bedeutung: Das ist ein Syntaxfehler.

### Verifikation
Mein Ziel habe ich im Abschnitt "Erklärung" erreicht.

### Reflexion
Ich bin relativ langsam gewesen mit der Projektdokumentation und dem Portfolio. In Zukunft will ich versuchen, an einem ruhigeren Ort zu arbeiten, damit ich mich besser konzentrieren kann und damit hoffentlich auch schneller bin.
