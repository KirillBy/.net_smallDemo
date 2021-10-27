using System;
using Strategy_DucksBehaviour;

namespace Adapter_TurkeyDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            ITurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);
            
            turkeyAdapter.Display();
            turkeyAdapter.Fly();
            turkeyAdapter.Quack();
            turkeyAdapter.Swim();
        }
    }
}
