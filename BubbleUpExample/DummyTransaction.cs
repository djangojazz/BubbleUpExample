using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleUpExample
{
  public sealed class DummyTransaction : BaseViewModel
  {
    public DummyTransaction(int id, string desc)
    {
      TransactionId = id;
      TransactionDesc = desc;
    }

    public int TransactionId { get; set; }
    public string TransactionDesc { get; set; }
  }
}
