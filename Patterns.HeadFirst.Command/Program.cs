// See https://aka.ms/new-console-template for more information

using Patterns.HeadFirst;

IInvoker invoker = new Invoker();
invoker.SetCommand(new PrintNumberCommand());
invoker.Invoke();
invoker.SetCommand(new PrintStringCommand());
invoker.Invoke();