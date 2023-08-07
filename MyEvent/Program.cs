using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an event publisher object
            EvtPublisher evtPublisher = new EvtPublisher();

            //Instantiate an event subscriber object
            EvtSubscriber subscriber = new EvtSubscriber();
            evtPublisher.evt += subscriber.HandleTheEvent;

            //call the checkbalace method on the evtPublisher object
            //it will invoke the evtPublisher delegate if the balance exceeds
            evtPublisher.CheckBalance(260);
        }
    }
    public class EvtPublisher
    {
      /*  public delegate void del(string x);
        public event del evt;
        public void CheckBalance(int x)
      */ 
        
        public EventHandler evt;
        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                evt(this,EventArgs.Empty);
            }
                
        }

    }
    public class EvtSubscriber
    {
        public void HandleTheEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Attention " + sender +" is advising that the balance exceeds 250");
        }

    }
}
