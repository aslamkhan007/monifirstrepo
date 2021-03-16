using System;

namespace monifirstwebapi.Controllers
{
    internal class Sqlconnection
    {
        private string v;

        public Sqlconnection(string v)
        {
            this.v = v;
        }

        internal void open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}