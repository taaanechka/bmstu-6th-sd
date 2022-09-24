using System;

namespace BL
{
    public class UserDeleteException: Exception
    {
        public UserDeleteException(): base() {}

        public UserDeleteException(string? mes): base(mes) {}

        public UserDeleteException(string? mes, Exception? innerException): 
            base(mes, innerException) {}
    }
}