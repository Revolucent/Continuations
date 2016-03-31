using System;
using System.Threading;
using System.Threading.Tasks;

namespace Continuations
{
    class Asynch
    {
        private readonly Output output;

        public Asynch(Output output)
        {
            this.output = output;
        }

        public async void Perform(string message, Action completion)
        {
            await Task.Run(() =>
            {
                output.AddOutput(message);
                Thread.Sleep(TimeSpan.FromSeconds(5));
            });
            completion();
        }
    }
}
