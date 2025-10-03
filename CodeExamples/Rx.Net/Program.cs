using System.Reactive.Disposables;
using System.Reactive.Subjects;

//var behavior = new BehaviorSubject<int>(0); // initial value = 0

//behavior.Subscribe(x => Console.WriteLine("Subscriber One : " + x));
//behavior.Subscribe(x => Console.WriteLine("Subscriber Two : " + x));

//behavior.OnNext(1);
//behavior.OnNext(2);
//behavior.OnNext(3);


var disposables = new CompositeDisposable();

var subject = new BehaviorSubject<int>(0);

var sub1 = subject.Subscribe(x => Console.WriteLine("Sub One : " + x));
var sub2 = subject.Subscribe(x => Console.WriteLine("Sub Two : " + x));

// সাবস্ক্রিপশনগুলো CompositeDisposable এ রাখা হলো
disposables.Add(sub1);
disposables.Add(sub2);

subject.OnNext(1);
subject.OnNext(2);

// এখন একসাথে সব dispose করে দেওয়া হলো
disposables.Dispose();

// এখন আর কেউ notification পাবে না
subject.OnNext(3);