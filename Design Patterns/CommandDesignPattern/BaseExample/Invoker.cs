using CommandDesignPattern.BaseExample.Commands;

namespace CommandDesignPattern.BaseExample
{
    internal class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand onStart)
            => _onStart = onStart;

        public void SetOnFinish(ICommand onFinish)
            => _onFinish = onFinish;

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");

            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something dont after I finish?");

            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }
        }
    }
}
