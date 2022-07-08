// A delegate can have more specific parameter types than its method target. This is called contravariance:

StringAction sa = new StringAction (ActOnObject);
sa("hello");

void ActOnObject (object o) => Console.WriteLine (o);   // hello

delegate void StringAction (string s);