using SimUDuck.Domain;

Duck mallard = new MallardDuck();
Duck rubber = new RubberDuck();
Duck rocket = new RocketDuck();

Console.WriteLine("Starting simulation...");

mallard.Display();
mallard.PerformFly();
mallard.PerformQuack();

rubber.Display();
rubber.PerformFly();
rubber.PerformQuack();

rocket.Display();
rocket.PerformFly();
rocket.PerformQuack();

