using Akka.Actor;
using Core.Akka.ActorAutostart;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExpenses.Application.Bill
{
    [AutostartActor("BillCommandActor")]
    public class BillCommandActor : ReceiveActor
    {
        protected BillCommandActor()
        {
        }
    }
}
