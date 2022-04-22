using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;
using System.Text.RegularExpressions;

namespace program
{
    class Program
    {
        static void Main()
        {
            //Задание "Карточная игра"
            {
                Game game = new Game();
                Console.WriteLine("Игра: ");
                game.ToGame();
                Console.WriteLine("\n\n");
            }
            //Проработка функционала коллекций
            {
                //List<T>
                {
                    var values = new List<MyRecord>() { new(1), new(10) };
                    var values2 = new List<MyRecord>(values) { new(50) }; //Инициализируем values2 значениями values,
                                                                          //добавляя 1 элемент
                    foreach (var v in values2)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();


                    var values3 = values2; //Присвоение ссылки с последующей демонстрацией изменений по ссылке
                    foreach (var v in values3)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();
                    values2[1].Value = 300;
                    foreach (var v in values3)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();

                    List<int> l = new(100); //Указываем capacity списка
                    Console.WriteLine(l.Capacity);

                    values3.Reverse(); //Переворачиваем спиком
                    foreach (var v in values3)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();

                    values3.RemoveAt(2); //Удаляем элементы списка 2-мя способами
                    values3.Remove(new(300));
                    foreach (var v in values3)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();

                    List<MyRecord> values4 = new() { new(10), new(100) };
                    List<MyRecord> values5 = new() { new(30), new(300) };
                    values4.AddRange(values5); //Добавляем коллекцию к коллекции
                    values4[3] = new(70);
                    foreach (var v in values4)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine("\n\n");
                }
                //LinkedList<T>
                {
                    List<MyRecord> list = new() { new(30), new(50), new(70) };
                    LinkedList<MyRecord> ll = new LinkedList<MyRecord>(list);

                    foreach (var v in ll) //Вывод через foreach
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();

                    var currentNode = ll.First; //Вывод, используя свойства LinkedList "First" и LinkedListNode "Next" и "Value"
                    while (currentNode != null)
                    {
                        Console.Write(currentNode.Value + " ");
                        currentNode = currentNode.Next;
                    }
                    Console.WriteLine();

                    // Last и First. Last/First - свойство LinkedList, Value - свойство LinkedListNode (элемента LinkedList)
                    Console.WriteLine(ll.Last?.Value);
                    Console.WriteLine(ll.First?.Value);

                    ll.AddLast(new MyRecord(300)); //AddLast, где добавляем объект
                    ll.AddFirst(new LinkedListNode<MyRecord>(new(700))); //AddFirst, где добавляем объект LinkedListNode

                    if (ll.First != null)
                    {
                        ll.AddAfter(ll.First, new MyRecord(1750));  //Вставляем после первого узла новый узел
                    }

                    //ll[1] = new MyRecord(370); //А так делать нельзя, ошибка!

                    foreach (var v in ll) //Вывод через foreach
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine("\n\n");
                }
                //Queue<T>
                {
                    MyRecord[] mr = { new(1), new(2), new(3), new(4), new(5) };
                    Queue<MyRecord> q = new(mr);
                    foreach (var v in q)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();

                    Console.WriteLine(q.Contains(new MyRecord(30)));
                    Console.WriteLine(q.Contains(new MyRecord(3)));
                    Console.WriteLine(q.Dequeue());
                    Console.WriteLine(q.Peek()); //Возвращяем без удаления
                    foreach (var v in q)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();
                    q.Enqueue(new(35));
                    foreach (var v in q)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();

                    var bqval = q.TryDequeue(out var qval); //Проверяем, есть ли элемент https://metanit.com/sharp/tutorial/4.7.php
                    if (bqval)
                    {
                        Console.WriteLine(qval);
                    }
                    Console.WriteLine("\n");
                }
                //Stack<T>
                {
                    int[] a = { 7, 8, 9, 10 };
                    Stack<int> s = new(a);
                    foreach (var v in s)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();
                    s.Push(30);
                    foreach (var v in s)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine(s.Peek()); //без вытягивания
                    Console.WriteLine(s.Pop()); //С вытягиванием
                    foreach(var v in s)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();

                    var bsval = s.TryPeek(out var sval);  //С проверкой на наличие https://metanit.com/sharp/tutorial/4.8.php
                    if (bsval)
                    {
                        Console.WriteLine(sval);
                    }
                    Console.WriteLine("\n\n");
                }
                //Dictionary<K, V>
                {
                    Dictionary<int, string> d = new();

                }
            }
        }
    }

    class Game
    {
        List<Player> players;

        public Game()
        {
            Random random = new Random();

            players = new List<Player>() { new(new()), new(new()) }; //Создаём двух игроков

            //Тасуем карты
            for (int i = 0; i < 16; i++)
            {
                players[0].Cards.Add(new(random.Next(1, 5), random.Next(6, 14)));
            }
            for (int i = 0; i < 16; i++)
            {
                players[1].Cards.Add(new(random.Next(1, 5), random.Next(6, 14)));
            }
        }

        public void ToGame()
        {
            List<int> counts = new() { 0, 0 };
            for (int i = 0; i < 16; i++)
            {
                if (players[0].Cards[i].Type > players[1].Cards[i].Type)
                    counts[0]++;
                else
                    counts[1]++;
            }
            if (counts[0] > counts[1])
                Console.WriteLine($"Победил Игорк 1");
            else
                Console.WriteLine($"Победил Игорк 2");
        }
    }

    record Player(List<Card> Cards);

    record Card(int Suit, int Type);

    record MyRecord
    {
        public MyRecord(int val)
        {
            Value = val;
        }

        public int Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}