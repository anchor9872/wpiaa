using launcher.c1;
using launcher.c6.Adapter;
using launcher.c6.SingletonVault;
using launcher.c6.Factory;
using launcher.c6.Builder;
using launcher.c6.Facade;
using launcher.c6.Prototype;
using launcher.c6.Proxy;
using launcher.c6.Bridge;
using launcher.c6.Decorator;
using launcher.c6.Composite;

// ------------------------------------------------------------------------------------------------------------
// ------------------------------------------   CODE SMELLS      ----------------------------------------------
// ------------------------------------------------------------------------------------------------------------

// ------------------------
// LongParameterList
// ------------------------

// var product = new Product
// {
//     ProductName = "dassad",
//     Category = "dsasdaa",
//     Price = 43.3m,
//     Stock = 2,
//     SupplierName = "aswq",
//     SupplierContact = "sdasdaw" 
// };
//
// var lpl = new LongParameterList();
// lpl.RegisterProduct(product);

// ------------------------
// DuplicatedCode
// ------------------------

// var dc = new DuplicatedCode();
// dc.LogWarning("test warning", DateTime.Now);
// dc.LogError("test error", DateTime.Now);

// ------------------------
// Message Chains
// ------------------------

// Car car = new Car();
//
// string cylinderSize = car.GetEngine().GetCylinder().GetSize();
// Console.WriteLine(cylinderSize);
//
// string cs = car.GetCylinderSize();
// Console.WriteLine(cs);


// ------------------------
// Refused Bequest 
// ------------------------

// ------------------------
// Temporary Field
// ------------------------

// InvoiceGenerator ig = new InvoiceGenerator();
// ig.GenerateInvoice();

// ------------------------
// Data Clumps
// ------------------------

// EventDetails ed = new EventDetails
// {
//     Name = "event name",
//     Date = new DateTime(2020, 1, 1),
//     Location = "location"
// };
//
// EventService es = new EventService();
// es.RegisterEvent(ed);

// ------------------------
// Inappropriate Intimacy
// ------------------------

// var course = new Course();
// var student = new Student();
//
// student.CompleteCourse(course);
//
// Console.WriteLine($"completed: {course.IsCompleted}, credits: {course.Credits}");


// ------------------------
// Long Message Chain
// ------------------------

// var school = new School();
// var teacherName = school.GetClassroom().GetTeacher().GetName();
// Console.WriteLine(teacherName);
//
// Console.WriteLine(school.GetTeacherName());

// ------------------------
// Divergent Change
// ------------------------

// var user = new UserAccount { Username = "piotr", Password = "1234" };
// var auth = new AuthenticationService();
// var report = new UserReportGenerator();
//
// auth.Login(user);
// report.GenerateReport(user);
// auth.Logout(user);

// ------------------------
// Parallel Inheritance Hierarchies
// ------------------------

// ILogger logger = new FileLogger();
// IExporter exporter = new JsonExporter();
//
// logger.LogMessage();
// exporter.ExportData();

// ------------------------
// Feature Envy
// ------------------------

// var order = new Order
// {
//     Amount = 1000m,
//     ShippingDetails = new ShippingDetails { ShippingMethod = "Air", Destination = "🇵🇱" }
// };
//
// var cost = order.ShippingDetails.CalculateShippingCost(order.Amount);
// Console.WriteLine($"cost: {cost}");

// ------------------------
// God Class
// ------------------------

// var adminPanel = new AdminPanel();
// adminPanel.RunTasks();

// ------------------------
// Switch Statements
// ------------------------

// var creditCardPayment = new Payment(new CreditCardFeeStrategy());
// Console.WriteLine(creditCardPayment.DeterminePaymentFee(1000m));
//
// var paypalPayment = new Payment(new PayPalFeeStrategy());
// Console.WriteLine(paypalPayment.DeterminePaymentFee(1000m));


// ------------------------
// Large Class
// ------------------------

// var warehouse = new WarehouseManager();
// warehouse.RunWarehouseTasks();

// ------------------------
// Primitive Obsession
// ------------------------

// var product = new ProductDetails
// {
//     Name = "laptop",
//     Quantity = 10,
//     Category = "laptop",
//     Price = 100m
// };
// var manager = new ProductManager();
//
// manager.RegisterProduct(product);

// ------------------------
// Data Class
// ------------------------

// var product = new ProductDataClass { Name = "Laptop", Price = 5000m, StockQuantity = 10 };
//
// Console.WriteLine($"product: {product.Name}");
// Console.WriteLine($"price: {product.GetFormattedPrice()}");
// Console.WriteLine($"inStock: {product.IsInStock()}");

// ------------------------
// Comments
// ------------------------

// var transaction = new Transaction();
// var processor = new PaymentProcessor();
//
// processor.PerformTransaction(transaction);


// ------------------------
// Middle Man
// ------------------------

// var repository = new InvoiceRepository();
//
// var invoice = repository.GetInvoiceById(1);
// repository.SaveInvoice(invoice);

// ------------------------
// Long Method
// ------------------------

// var gradeBook = new GradeBook();
// var teacher = new TeacherLongMethod();
//
// teacher.FinalizeGrades(gradeBook);
//
// Console.WriteLine($"Grade: {gradeBook.Grade}");
// Console.WriteLine($"IsFinalized: {gradeBook.IsFinalized}");

// ------------------------
// Speculative Generality
// ------------------------

// var handler = new AdvancedHandler();
//
// handler.HandleHttpRequest(new HttpRequest { Url = "https://example.com" });
// handler.HandleFileRequest(new FileRequest { FileName = "document.txt" });

// ------------------------
// Lazy Class
// ------------------------

// var messagingService = new MessagingService();
// messagingService.SendNotification("Hello, world!");

// ------------------------
// Shotgun Surgery
// ------------------------

// var customer = new Customer { Name = "piotr" };
// var orderService = new OrderService();
//
// var order = orderService.CreateOrder(customer, "order123");
// orderService.SaveOrder(order);

// ------------------------------------------------------------------------------------------------------------
// ----------------------------------------------    WZORCE      ----------------------------------------------
// ------------------------------------------------------------------------------------------------------------

// ------------------------
// Singleton Vault
// ------------------------

// var vault = Vault.Instance;
// vault.GetVaultKey();
//
// var vault2 = Vault.Instance;
// Console.WriteLine($"{Object.ReferenceEquals(vault, vault2)}");


// ------------------------
// Factory
// ------------------------

// var garnizon = new launcher.c6.Factory.Garnizon();
//
// Wojownik[] wojownicy =
// {
//     garnizon.WyszkolWojownika("piechur", "piechur1"),
//     garnizon.WyszkolWojownika("piechur", "piechur2"),
//     garnizon.WyszkolWojownika("piechur", "piechur3"),
//
//     garnizon.WyszkolWojownika("konny", "konny1"),
//     garnizon.WyszkolWojownika("konny", "konny2"),
//     garnizon.WyszkolWojownika("konny", "konny3"),
//
//     garnizon.WyszkolWojownika("strzelec", "strzelec1"),
//     garnizon.WyszkolWojownika("strzelec", "strzelec2"),
//     garnizon.WyszkolWojownika("strzelec", "strzelec3"),
//     garnizon.WyszkolWojownika("strzelec", "strzelec4")
// };
//
// foreach (var woj in wojownicy)
// {
//     woj.Fight();
// }

// ------------------------
// Builder
// ------------------------

// var builderGarnizon = new launcher.c6.Builder.Garnizon();
//
// var armia = new List<Wojownik>();
//
// var piechurBuilder = new PiechurBuilder();
// var konnyBuilder = new KonnyBuilder();
// var strzelecBuilder = new StrzelecBuilder();
//
// armia.Add(builderGarnizon.WyszkolWojownika(piechurBuilder, "piechur1"));
// armia.Add(builderGarnizon.WyszkolWojownika(piechurBuilder, "piechur2"));
//
// armia.Add(builderGarnizon.WyszkolWojownika(konnyBuilder, "konny1"));
// armia.Add(builderGarnizon.WyszkolWojownika(konnyBuilder, "konny2"));
//
// armia.Add(builderGarnizon.WyszkolWojownika(strzelecBuilder, "strzelec1"));
// armia.Add(builderGarnizon.WyszkolWojownika(strzelecBuilder, "strzelec2"));
//
// foreach (var woj in armia)
// {
//     woj.Fight();
// }

// ------------------------
// Prototype
// ------------------------

// var orcs = new List<Ork>();
//
// var og = new Ork(20, 50);
//
// for (int i = 0; i < 5; i++)
// {
//     Ork clone = og.Clone();
//     orcs.Add(clone);
// }
//
// foreach (var o in orcs)
// {
//     Console.WriteLine(o.ToString());
// }

// ------------------------
// Facade
// ------------------------

// var city = "";
// while (string.IsNullOrEmpty(city))
// {
//     Console.Write("podaj miasto: ");
//     city = Console.ReadLine();
// }
//
// var temp = await WeatherFacade.GetWeather(city);
// Console.Write($"Temperatura w {city}: {temp.Temperature} Celcius\n");

// ------------------------
// Proxy
// ------------------------

// var fileAccess = new FileAccessProxy();
//
// var appLoop = true;
// while (appLoop)
// {
//     Console.WriteLine("Dostępne pliki: ");
//     Console.WriteLine("1. publiczny_plik.txt");
//     Console.WriteLine("2. tajny_plik1.xls");
//     Console.WriteLine("3. tajny_plik2.pdf");
//     Console.WriteLine("4. Wyjście");
//     Console.Write("Wybierz plik do pobrania (1-4): ");
//
//     var choice = Console.ReadLine() ?? "";
//     var fileName = "";
//     switch (choice)
//     {
//         case "1":
//             fileName = "publiczny_plik.txt";
//             break;
//         case "2":
//             fileName = "tajny_plik1.xls";
//             break;
//         case "3":
//             fileName = "tajny_plik2.pdf";
//             break;
//         case "4":
//             appLoop = false;
//             break;
//         default:
//             Console.WriteLine("Nieprawidlowa wartosc.");
//             continue; 
//     }
//     if (!appLoop) break;
//
//     Console.WriteLine($"\nPróba porbania: '{fileName}'");
//     var result = fileAccess.GetFile(fileName);
//     Console.WriteLine($"\n{result}");
//     Console.WriteLine("-------------------------------------");
// }

// ------------------------
// Adapter
// ------------------------

// var club = new Club();
//
// var krzysiu1 = new Adult("Krzysiu", 17);
// club.CheckEntry(krzysiu1);
//
// Console.WriteLine();
//
// var krzysiu2 = new FakeAdult("Krzysiu", 17);
// club.CheckEntry(krzysiu2);

// ------------------------
// Bridhe
// ------------------------

// OperationSystem linux = new LinuxSystem();
// linux._ui = new GraphicInterface();
// linux.PressMenuButton();
//
// linux._ui = new TextInterface();
// linux.PressMenuButton();
//
// OperationSystem windows = new WindowsSystem();
// windows._ui = new GraphicInterface();
// windows.PressMenuButton();
//
// Console.ReadKey();


// ------------------------
// Decorator
// ------------------------

// var myShop = new Shop();
//
// myShop.MakePurchase("gotowka", 50.00);
// myShop.MakePurchase("karta", 250.00);
//
// Console.ReadKey();


// ------------------------
// Composite
// ------------------------

MenuCategory mainMenu = new MenuCategory("Główne Menu");

MenuCategory breakfast = new MenuCategory("Śniadania");
breakfast.AddComponent(new Dish("Jajecznica", 15.00));
breakfast.AddComponent(new Dish("Owsianka", 12.50));

MenuCategory dinner = new MenuCategory("Obiady");
        
MenuCategory soups = new MenuCategory("Zupy");
soups.AddComponent(new Dish("Rosół", 18.00));
soups.AddComponent(new Dish("Pomidorowa", 19.00));

dinner.AddComponent(soups); 
dinner.AddComponent(new Dish("Schabowy", 35.00));

mainMenu.AddComponent(breakfast);
mainMenu.AddComponent(dinner);
mainMenu.AddComponent(new Dish("Woda Niegazowana", 5.00));

mainMenu.DisplayMenu(0);

