using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BubbleUpExample.ViewModel
{
  public sealed class CollectionChangedBubbleUpViewModel : BaseViewModel
  {
    public CollectionChangedBubbleUpViewModel()
    {
      Trans = new ObservableCollection<DummyTransaction>(FakeRepo.Instance.Trans);
    }

    RelayCommand _addRow;

    public ICommand AddRow { get => (_addRow == null) ? _addRow = new RelayCommand(param => AddRowExecute()) : _addRow; }

    public void AddRowExecute()
    {
      FakeRepo.Instance.AddToTrans(Trans.Last().TransactionId + 1, "D", 100);
      Trans.ClearAndAddRange(FakeRepo.Instance.Trans);
    }

    public ObservableCollection<DummyTransaction> Trans { get; }
  }
}
