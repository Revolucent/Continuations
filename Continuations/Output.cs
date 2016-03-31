using System;
using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace Continuations
{
    class Output
    {
        private Dispatcher dispatcher;

        public Output(Dispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
            this.Outputs = new ObservableCollection<string>();
        }

        public void AddOutput(string output)
        {
            Console.WriteLine(output);
            dispatcher.Invoke(() => Outputs.Add(output));
        }

        public ObservableCollection<String> Outputs { get; private set; }
    }
}
