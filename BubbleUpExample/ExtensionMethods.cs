using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BubbleUpExample
{
  public static class ExtensionMethods
  {
    public static void ClearAndAddRange<T>(this ObservableCollection<T> input, IEnumerable<T> array)
    {
      input.Clear();
      foreach (var o in array)
      {
        input.Add(o);
      }
    }
  }
}
