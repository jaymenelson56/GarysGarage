using Garage;

Zero fxs = new Zero { CurrentChargePercentage = 50 };
Zero fx = new Zero { CurrentChargePercentage = 60 };
Tesla modelS = new Tesla { CurrentChargePercentage = 70 };

List<IElecticVehicle> electricVehicles = new List<IElecticVehicle>() {
fx, fxs, modelS
};

Console.WriteLine("Electric Vehicles");
foreach (IElecticVehicle ev in electricVehicles)
{
    Console.WriteLine($"{ev.CurrentChargePercentage}");
}

foreach (IElecticVehicle ev in electricVehicles)
{
    ev.ChargeBattery();
}

foreach (IElecticVehicle ev in electricVehicles)
{
    Console.WriteLine($"{ev.CurrentChargePercentage}");
}

Ram rammy = new Ram { CurrentTankPercentage = 30};
Cessna Cessie = new Cessna {CurrentTankPercentage = 40 };

List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
rammy, Cessie
};

Console.WriteLine("Gas Vehicles");
foreach (IGasVehicle gv in gasVehicles)
{
    Console.WriteLine($"{gv.CurrentTankPercentage}");
}

foreach(IGasVehicle gv in gasVehicles)
{
    gv.RefuelTank();
}

foreach(IGasVehicle gv in gasVehicles)
{
    Console.WriteLine($"{gv.CurrentTankPercentage}");
}
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();

