using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TestThread;

class ThreadLocalDemo
{

 
    static void Main()
    {


        List<Thread> threads = new List<Thread>();

        for (int i = 0; i < 100; i++)
        {
            var t = new Thread(a =>
            {


                ManagerTransaction.GetTransactionObject();
                ManagerTransaction.GetTransactionObject();

            });

            threads.Add(t);
            t.Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        Guid previusTransaction = new Guid();
        int repeated = 0;

        var list = new List<KeyValuePair<Guid, Transaction>>();

        foreach (KeyValuePair<Guid, Transaction> item in ManagerTransaction.TransactionList)
        {
            if (previusTransaction == (Guid)item.Key)
            {
                repeated++;
            }

            previusTransaction = (Guid)item.Key;
            list.Add(item);
        }



        //list.ForEach(item =>
        //{

        //    var objectValue = ManagerTransaction.TransactionList[item.Key];

        //    ManagerTransaction.TransactionList.TryRemove(item.Key, out objectValue);

        //});

        Console.ReadKey();
       
    }
}