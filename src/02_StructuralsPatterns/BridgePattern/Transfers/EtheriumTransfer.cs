﻿using System;

namespace BridgePattern.Transfers;

// Refined Abstraction
public class EtheriumTransfer : CryptoTransfer
{
    public EtheriumTransfer(IAthorizationMethod athorizationMethod) : base(athorizationMethod)
    {
    }

    public override void MakeTransfer(decimal amount)
    {
        base.MakeTransfer(amount);

        Console.WriteLine("Przelew Etherium");
    }
}