using System;
using System.Collections.Generic;
using System.Text;

class Money
{
    public int Gold { get; private set; }
    public int Sliver { get; private set; }

    public Money(int gold, int sliver)
    {
        Gold = gold;

        Sliver = sliver;
    }

    public Money Add(int gold, int sliver)
    {
        Gold += gold;
        Sliver += sliver;
        return new Money(Gold, Sliver);
    }
    public Money Substract(int gold, int sliver)
    {
        if (Gold - gold > 0)
        {
            Gold -= gold;
        }
        ;
        if (Sliver - sliver > 0)
        {
            Sliver -= sliver;
        }
        return new Money(Gold, Sliver);
    }
    public override string ToString()
    {
        return $"{Gold}골드 {Sliver}실버";
    }
}