
using System.Windows;
namespace CMCS_POE {
  public partial class MainWindow : Window {
    public MainWindow(){InitializeComponent();}
    void Lecturer(object s,RoutedEventArgs e){new Views.LecturerDashboard().Show();}
    void Coordinator(object s,RoutedEventArgs e){new Views.CoordinatorDashboard().Show();}
    void Manager(object s,RoutedEventArgs e){new Views.ManagerDashboard().Show();}
    void HR(object s,RoutedEventArgs e){new Views.HRDashboard().Show();}
  }
}
