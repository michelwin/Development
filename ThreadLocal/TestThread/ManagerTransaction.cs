using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    public class ManagerTransaction
    {


        public static ConcurrentDictionary<Guid, Transaction> TransactionList = new ConcurrentDictionary<Guid, Transaction>();

        static ThreadLocal<Guid> ThreadName = new ThreadLocal<Guid>();

        private static Transaction instance;

        public static int CreatedCount = 0;
        public static int ReuseCount = 0;

        public static Transaction GetTransactionObject()
        {

            //lock (TransactionList)
            //{

            if (!TransactionList.Keys.Contains(ThreadName.Value))
                {
                    //lock (TransactionList)
                    //{
                        Console.WriteLine("Create New Object.");

                        var newGuid = Guid.NewGuid();

                        instance = new Transaction();
                        ThreadName.Value = newGuid;
                        TransactionList.TryAdd(ThreadName.Value, instance);
                        CreatedCount++;
                    //}
                }
                else
                {

                    Console.WriteLine("Reuse Object.");
                    instance = TransactionList[ThreadName.Value] as Transaction;
                    ReuseCount++;
                }

            //}

            return instance;

        }
    }
}
