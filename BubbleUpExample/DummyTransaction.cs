using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleUpExample
{
  public sealed class DummyTransaction : BaseViewModel
  {
    public DummyTransaction(int id, string desc, int amount)
    {
      TransactionId = id;
      TransactionDesc = desc;
      Amount = amount;
    }

    public int TransactionId { get; set; }
    public string TransactionDesc { get; set; }
    private int _amount;

    public int Amount
    {
      get { return _amount; }
      set
      {
        _amount = value;
        if (FakeRepo.Instance != null)
        {
          FakeRepo.Instance.UpdateTotals();
          base.OnPropertyChanged("Trans");
        }
        OnPropertyChanged(nameof(Amount));
      }
    }

    public int RunningTotal { get; set; }
  }
}
