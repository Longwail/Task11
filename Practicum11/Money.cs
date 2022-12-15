using System;

namespace Practicum11
{
    internal class Money
    {
        private int first;
        private int second;

        public Money(int nomination, int value)
        {
            first = nomination;
            second = value;
        }

        public void outInfo()
        {
            Console.WriteLine($"Номинал купюры - {first}");
            Console.WriteLine($"Количество купюр - {second}");
        }

        public void isEnoughMoney(int sum)
        {
            if (first * second >= sum) Console.WriteLine("Денежной суммы хватит на покупку товара");
            else Console.WriteLine("Денежной суммы не хватит на покупку товара");
        }

        public void quantityOfGoods(int price)
        {
            int sum = first * second;
            
            if (sum >= price)
            {
                Console.WriteLine($"Можно приобрести {sum/price} шт. товара");
            }
            else Console.WriteLine("Товар нельзя приобрести так как его цена превышает денежную сумму");
        }

        public int First
        {
            get { return first; }
            set { first = value; }
        }
        public int Second
        {
            get { return second; }
            set { second = value; }
        }

        public int Sum
        {
            get { return first * second; }
        }
    }
}
