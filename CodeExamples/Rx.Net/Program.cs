using System.Reactive.Subjects;

var behavior = new BehaviorSubject<int>(0); // initial value = 0

behavior.Subscribe(x => Console.WriteLine("Subscriber One : " + x));
behavior.Subscribe(x => Console.WriteLine("Subscriber Two : " + x));

behavior.OnNext(1);
behavior.OnNext(2);
behavior.OnNext(3);