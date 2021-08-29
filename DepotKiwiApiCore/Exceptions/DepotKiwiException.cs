using System;

namespace DepotKiwiApiCore.Exceptions {
    public class DepotKiwiException : Exception {
        protected DepotKiwiException(string message) : base(message) { }
    }
}