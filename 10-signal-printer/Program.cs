List<string> messages = new List<string> { "SOS", "ACK" };
List<int> numbers = new List<int> {1,2};
SignalPrinter.PrintItems<string>(messages);
SignalPrinter.PrintItems<int>(numbers);
// Svar på oppdrag 3: int og string trengs ikke fordi listen allerede er definert når den blir laget, påkall via navn holder
List<int> noNumbers = new List<int> {};
SignalPrinter.PrintItems(noNumbers); 
SignalPrinter.PrintItems(messages);
SignalPrinter.PrintItems(numbers);

