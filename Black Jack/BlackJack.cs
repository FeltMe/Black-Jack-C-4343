using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Black_Jack
{
    class BlackJack
    {
        public Deck[] decks = new Deck[8];
        public Player player = new Player();
        public Diller diller = new Diller();
        public int Point { get; set; }


        public void Start()
        {
            Console.WriteLine(this.player.ToString());
            Console.WriteLine(this.diller.ToString());

            SetEightDecks();
            int menu = 0;
            while (true)
            {
                Console.WriteLine("Enter 1 to Stand");
                Console.WriteLine("Enter 2 to Hit");
                Console.WriteLine("Enter 3 to DoubleDown");
                string choise = Console.ReadLine();
                menu = ConvertChoise(choise);
                switch (menu)
                {
                    case 1:
                        {
                            int temp_rnd_i = Randomise.Random.Next(0, 9);
                            int temp_rnd_j = Randomise.Random.Next(0, 53);
                            Cards temp = new Cards();

                            Console.WriteLine(temp.ToString());
                            Thread.Sleep(1000);
                        }
                        break;
                    case 2:
                        {



                        }
                        break;
                    case 3:
                        {



                        }
                        break;
                }
            }
        }
        public void SetEightDecks()
        {
            for (int i = 0; i < 8; i++)
            {
                Deck temp_deck = new Deck();
                temp_deck.FillDeck();
                temp_deck = temp_deck.Shuffle(temp_deck);
                decks[i] = temp_deck;
            }
        }
        public Cards ReturnOneCardFromDecks(Deck[] decks, int i, int j)
        {
            return decks[i].CardsArr[j];
        }
        public void PrintAllDecks()
        {
            foreach (var item in decks)
            {
                Console.WriteLine($"Next Deck");
                foreach (var item_2 in item.CardsArr)
                {
                    Console.WriteLine(item_2.ToString());
                    Thread.Sleep(50);
                }
            }
        }
        public int ConvertChoise(string choise)
        {
            return Convert.ToInt32(choise);
        }
    }
}