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


      //InstanceConverter = new InstanceInSetToStringConverter();
      //LocationCollection = new ObservableCollectionContentNotifying<DemandLocation>();
      //ChartData = new ObservableCollectionContentNotifying<PlotTrend>();

      //LocationCollection.ClearAndAddRange(Selects.GetDemandLocations().Take(5));
      //var locs = new List<int> { 18, 55 };
      //locs.ForEach(x => LocationCollection.Single(y => y.LocationID == x).IsUsed = true);
      //UpdateHeader();
      //SelectedItem = TrendChoices.FiscalPeriod;
      //UpdateChartData();
      //LocationCollection.OnCollectionItemChanged += UpdateHeader;
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
