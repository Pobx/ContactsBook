using System;
using SQLite;

namespace ContractsBook.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection Getconnection();
    }
}

