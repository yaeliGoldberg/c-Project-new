using System;

namespace DO
{
    [Serializable]
    public class DalNotExistException : Exception
    {
        public DalNotExistException(string message) : base(message) { }
    }

    [Serializable]
    public class DalAlreadyExistException : Exception
    {
        public DalAlreadyExistException(string message) : base(message) { }
    }
}
