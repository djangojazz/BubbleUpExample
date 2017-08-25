using BubbleUpExample.ViewModel;
using System.Windows.Controls;

namespace BubbleUpExample
{
  /// <summary>
  /// Interaction logic for CollectionChangedBubbleUpView.xaml
  /// </summary>
  public partial class CollectionChangedBubbleUpView : UserControl
  {
    public CollectionChangedBubbleUpView()
    {
      InitializeComponent();
      DataContext = new CollectionChangedBubbleUpViewModel();
    }
  }
}
