using System;

namespace CleanCode_DataBase
{
    public class SQLiteException : SystemException
    {
        public int ErrorCode { get; private set; }
    }
}