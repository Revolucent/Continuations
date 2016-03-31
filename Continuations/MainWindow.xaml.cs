using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Continuations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartDemo(object sender, RoutedEventArgs e)
        {
            var output = new Output(Dispatcher);
            this.DataContext = output.Outputs;
            var asynch = new Asynch(output);
            output.AddOutput("1. Before calling Perform().");
            asynch.Perform("3. In Background", () => output.AddOutput("4. When Perform() is complete."));
            /*
                NSURLSession().dataTaskWithRequest(request) { response in
                    
                }
                print("1. done!)
                asynch.perform("In Background") { 
                    output.addOutput("When Perform() is complete.")
                }
                asynch.perform("In Background", completion: { 
                    output.addOutput("When Perform() is complete.")
                })
            */
            output.AddOutput("2. After calling Perform().");
        }

    }

    
}
