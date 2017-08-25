using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleUpExample
{
  public sealed class FakeRepo
  {
    private static readonly FakeRepo _instance = new FakeRepo();
    static FakeRepo() { }
    private FakeRepo()
    {
      Trans = new List<DummyTransaction>
      {
        new DummyTransaction(1, "A", 50),
        new DummyTransaction(2, "B", 60),
        new DummyTransaction(3, "C", 80),
      };

      UpdateTotals();
    }

    public void UpdateTotals()
    {
      int totalAmount = 0;

      for (int i = 0; i < Trans.Count; i++)
      {
        totalAmount += Trans[i].Amount;
        Trans[i].RunningTotal = totalAmount;
      }
    }

    public static FakeRepo Instance { get => _instance; }

    public List<DummyTransaction> Trans { get; set; }

    public void AddToTrans(int id, string desc, int amount)
    {
      Trans.Add(new DummyTransaction(id, desc, amount));
    }
  }
}
