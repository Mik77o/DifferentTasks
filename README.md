# Różne zadania w C# - treści poniżej


## Zadanie 1
Napisz funkcję określającą liczbę bitów, których wartości trzeba
odwrócić, aby przekształcić liczbę całkowitą A na liczbę całkowitą
B.

- Wejście
:Na wejściu funkcja powinna przyjąć dwa argumenty będące liczbami
całkowitymi.

- Wyjście
:Na wyjściu funkcja powinna zwrócić liczbę całkowitą informującą o
liczbie bitów, które należy odwrócić w celu wykonania
przekształcenia.

## Zadanie 2

Zaimplementuj metodę, która przeprowadza prostą kompresję
łańcuchów znaków opartą na zliczaniu powtarzających się liter. Na
przykład metoda ma przekształcić łańcuch aabcccccaaa na a2b1c5a3.
Jeśli "skompresowany" łańcuch znaków nie jest mniejszy od
wyjściowego, metoda powinna zwracać pierwotny łańcuch.

- Wejście
:Metoda powinna przyjmować jeden argument, będący łańcuchem znaków.
Łańcuch powinien składać się z liter alfabetu angielskiego.

- Wyjście
:Na wyjściu ma pojawić się skompresowany ciąg znaków. Jeśli
skompresowany łańcuch jest tej samej długości co oryginalny,
metoda powinna zwrócić pierwotny łańcuch.

## Zadanie 3

Napisz program, który sprawdzi, które spośród danych liczb są
liczbami pierwszymi.

- Wejście
:W pierwszym wierszu danych znajduje się liczba naturalna N, która jest
liczbą testów, gdzie N<100. w kolejnych liniach N liczb z
przedziału 1..1000 .

- Wyjście
:Dla każdej liczby słowo TAK, jeśli liczba ta jest pierwsza, słowo:
NIE, w przeciwnym wypadku.


## Zadanie 4

Napisz program, który wyświetli histogram dla liczb podanych na
wejściu.

- Wejście
:Wiersze z liczbami całkowitymi z przedziału <-10, 10>.

- Wyjście
:21 wierszy, każdy o stałej długości 37 znaków. Każdy wiersz składa
się z :
• Kolejnych liczb z przedziału <-10, 10> zapisanych na 4
polach.
• Dwukropka.
• Kreski.
• Odpowiedniej ilość gwiazdek symbolizującej ilość wystąpień
danej cyfry. Jeśli ilość wystąpień przekracza przewidziany
obszar rysowania gwiazdek, to ostatnia możliwa do
wyświetlenia gwiazdka powinna zostać zastąpiona znakiem „+”.
Przykład:
" 0:|*****************************+|";
• Kreski na końcu wiersza.

## Zadanie 5

Napisz program, który dla zadanej liczby n, wypisze ostatnią
niezerową cyfrę liczby n!

- Wejście
:W pierwszym wierszu znajduje się liczba testów t (1<=t<=100), w
każdej następnej linijce znajduje się dokładnie jedna liczba
całkowita n (1<=n<=100).

- Wyjście
:Dla każdego n należy wyświetlić ostatnią niezerową cyfrę liczby
n!.
Przykład
Wejście:
41358
Wyjście:
1622

