using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace BubbleUpExample
{
  public class MainViewModel : BaseViewModel
  { 
    public MainViewModel()
    {
    }

    protected override void OnPropertyChanged(String info)
    {
      Count = FakeRepo.Instance.Trans.Count; 
    }

    private int count;
    public int Count
    {
      get { return count; }
      set
      {
        count = value;
        OnPropertyChanged(nameof(Count));
      }
    }
  }
}
