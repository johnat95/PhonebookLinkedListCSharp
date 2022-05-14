

PhoneBook.PhonebookManager manager = new PhoneBook.PhonebookManager();

String a = "a";
String b = "b";
String c = "c"; 
String d = "d";

manager.AddSorted(manager.CreateContactNode(a, a, a, a, a, a, a, a));
manager.AddSorted(manager.CreateContactNode(b, b, b, b, b, b, b, b));

manager.AddSorted(manager.CreateContactNode(d,d,d,d,d,d,d,d));
manager.AddSorted(manager.CreateContactNode(c,c,c,c,c,c,c,c));
manager.RemoveNode("cc");

manager.DisplayAll();


//main ends
