using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class MainClass
    {
        delegate void Mydelegate();

        public static void Main(string[] args)
        {
            #region Interface
            //Gode videoer hvis selv vil lave lidt.
            //God video1: https://www.youtube.com/watch?v=jh4y8HzGqCQ
            //God Video2(fortsættelse fra video1): https://www.youtube.com/watch?v=TZi86NDFwNU

            //Et Interface er lidt som en kontrakt
            //dem der har interfacet (Worker og Manager klasserne)
            //LOVER at implementer den metode der står i interfacet.
            //Både Worker og Manager implementerer IWorker interfacet
            //så begge klasser har metoden GetSalary().


            Worker worker1 = new Worker(40, 130);
            Worker worker2 = new Worker(40, 130);
            Worker worker3 = new Worker(40, 230);
            Manager leder1 = new Manager(40, 330);
            Manager leder2 = new Manager(40, 430);
            Manager leder3 = new Manager(40, 300);

            //fordi både Worker og Manager klasserne implementere IWorker interfacet
            //kan vi putte dem sammen på en liste af IWorkers
            List<IWorker> Personer = new List<IWorker>() { worker1, worker2, worker3, leder1, leder2, leder3 };

            //Working(Personer);
            #endregion

            #region Delegates
            //God Video: https://www.youtube.com/watch?v=9K9Aq7die7Q

            //En Delegate er en "function-pointer", d.v.s. den refererer/peger på en metode
            //En delegates signatur skal matche den metode den peger på.
            //Da delegaten på linje 9 er void, så skal den også pege på en metode
            //der retunere void. Det samme gælder for parameteren.

            //Vi siger at del skal pege på/referere Void metoden Foo() i delegate methods
            //Vi kan nu kalde Del som en almindelig metode med del();
            Mydelegate del = Foo;
            //del();

            //Nu siger vi at del skal pege på Goo istedet for
            //Når vi nu kalder del() eller del.Invoke();
            //vil den kalde Goo metoden
            del = Goo;
            //del.Invoke();

            //Her under "Chainer" vi en delegate
            //Først siger vi at del peger på Foo
            //derefter kan vi sige at del OGSÅ peger på Goo
            //Ved at bruge += kan vi sige at del skal pege på mange metoder 
            //hvis man vil. 
            del = Foo;
            del += Goo;
            del += Goo;
            del += Goo;
            del += Goo;
            del += Foo;
            //del -= Goo: det her vil fjerne DEN SIDSTE reference til Goo
            //så de 3 FØRSTE Goo vil stadig være der 
            //del.Invoke();

            //God Video: https://www.youtube.com/watch?v=qmdziLz51w4
            //lambda expression, den sidste type i Func er altid returtypen. op til 16 parametre
            Func<int, bool> Func1 = input => input > 5;
            //Console.WriteLine(Func1(5));

            //Anonymous method: Bemærk at på højre side har metoden ikke noget navn ligesom f.eks Metode(); 
            Func<int, bool> FuncAM = delegate (int input) { return input > 5; };
            //Console.WriteLine(Func1(5));

            //Action retuner altid Void(hover over Action), kan holde op til 16 parametre.
            Action<string, int> Ac1 = (inputstreng, inputtal) => Console.WriteLine(inputstreng + inputtal);
            Ac1("test af Action ", 007);

            //Predicate retuner altid bool (hover over Predicate), tager kun mod 1 parameter
            Predicate<string> Prd1 = inputstreng => inputstreng == "";
            Console.WriteLine(Prd1("fx. navn"));
            #endregion

            #region LINQ
            //God Video: https://www.youtube.com/watch?v=Z6YWWRUcJis

            //LINQ Lambda - worker-navnet kan man bare skifte ud, det er bare en variabel. 
            //Der kunne også stå x => x.gender == "Mand"; Den ved at der er tale om en liste af workers objekter.
            var LambdaLinqList = Worker.GetAllWorkers().Where(worker => worker.gender == "mand");

            foreach (var item in LambdaLinqList)
            {
                // Console.WriteLine("LambdaLinqList:" + item.gender);
            }

            //LINQ SQlformat - workers-navnet kan man bare skifte ud.  
            var SQlLinkList = from workers in Worker.GetAllWorkers()
                              where workers.gender == "Dame"
                              select workers;

            foreach (var item in SQlLinkList)
            {
                // Console.WriteLine("LambdaLinqList:" + item.gender);
            }

            #endregion

        }

        #region Interface Methods

        public static void GetSalary(IWorker persontocalculate)
        {
            Console.WriteLine("Lønnen er: " + persontocalculate.CalculateSalary());
        }

        public static void Working(List<IWorker> personer)
        {
            //vi tar fat i hver worker på listen og kalder Iworker metoderne på dem alle
            foreach (var item in personer)
            {
                //Fordi de ALLE implementerer metoden GetSalary()
                GetSalary(item);
                //hvis den støder på en worker der også implementerer Iboard (Manager)
                //så skal den også caste til IBoard og kalde GoToMeeting()(Se manager klassen) på dem;
                if (item is IBoard)
                {
                    ((IBoard)item).GoToMeeting();
                }
                Console.WriteLine("");
            }
        }
        #endregion

        #region Delegate Methods

        public static void Foo() { Console.WriteLine("hello from Foo"); }

        public static void Goo() { Console.WriteLine("hello from Goo"); }

        #endregion
    }
}
