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
      Trans.CollectionChanged += ModifyCollectionsBindings;
    }

    RelayCommand _addRow;

    public ICommand AddRow { get => (_addRow == null) ? _addRow = new RelayCommand(param => AddRowExecute()) : _addRow; }

    public void AddRowExecute()
    {
      FakeRepo.Instance.AddToTrans(4, "D");
      Trans.ClearAndAddRange(FakeRepo.Instance.Trans);
    }

    public ObservableCollection<DummyTransaction> Trans { get; }

    private void ModifyCollectionsBindings(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
      if (e?.OldItems != null)
      {
        //((List<object>)e?.OldItems).ForEach(arg => ((INotifyPropertyChanged)arg).PropertyChanged -= CascadeEvent);
        foreach (var arg in e?.OldItems) { ((INotifyPropertyChanged)arg).PropertyChanged -= CascadeEvent; base.OnPropertyChanged(arg.ToString()); }
      }

      if (e?.NewItems != null)
      {
        foreach (var arg in e?.NewItems) { ((INotifyPropertyChanged)arg).PropertyChanged += CascadeEvent; base.OnPropertyChanged(arg.ToString()); }
      }
    }

    private void CascadeEvent(object sender, PropertyChangedEventArgs e)
    {
      OnPropertyChanged(e.PropertyName);
    }
  }
}
