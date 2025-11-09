using launcher.c1;
using launcher.c6.SingletonVault;
using launcher.c6.Factory;

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

Garnizon garnizon = new Garnizon();

Wojownik[] wojownicy =
{
    garnizon.WyszkolWojownika("piechur", "piechur1"),
    garnizon.WyszkolWojownika("piechur", "piechur2"),
    garnizon.WyszkolWojownika("piechur", "piechur3"),

    garnizon.WyszkolWojownika("konny", "konny1"),
    garnizon.WyszkolWojownika("konny", "konny2"),
    garnizon.WyszkolWojownika("konny", "konny3"),

    garnizon.WyszkolWojownika("strzelec", "strzelec1"),
    garnizon.WyszkolWojownika("strzelec", "strzelec2"),
    garnizon.WyszkolWojownika("strzelec", "strzelec3"),
    garnizon.WyszkolWojownika("strzelec", "strzelec4")
};

foreach (var woj in wojownicy)
{
    woj.Fight();
}














