using System;

namespace CCDotNet.Emulation.State
{
    public interface IComputerState : IDisposable
    {
        void AddApi(object api); //TODO define a lua API

        object LoadBios(string bios); //TODO define a machine result

        object HandleEvent(string name, object[] args); //TODO define a machine a result
        
        //void Close(); //Close is considered Dispose
    }
}