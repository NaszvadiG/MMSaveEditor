﻿using FullSerializer;

[fsObject(MemberSerialization = fsMemberSerialization.OptOut)]
public class Finance
{
    public TransactionHistory transactionHistory = new TransactionHistory();
    public bool saveTransactionHistory;
    public Team team;
    public long initialBudget;
    public long currentBudget;

    public long InitialBudget
    {
        get
        {
            return initialBudget;
        }

        set
        {
            initialBudget = value;
        }
    }

    public long CurrentBudget
    {
        get
        {
            return currentBudget;
        }

        set
        {
            currentBudget = value;
        }
    }
}
