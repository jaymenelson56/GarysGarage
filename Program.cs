using Garage;
            
Zero fxs = new Zero();
Tesla modelS = new Tesla();
Cessna mx410 = new Cessna();

fxs.Drive();
modelS.Drive();
mx410.Drive();

List<Vehicle> vehicles = new List<Vehicle>()
{
    new Tesla()
    {
        MainColor ="Red",
        MaximumOccupancy = 5,
        BatteryKWh = 75.0
    },
    new Ram()
    {
        MainColor = "Blue",
        MaximumOccupancy = 3,
        FuelCapacity = 20.0
    },
    new Cessna()
    {
        MainColor = "White",
        MaximumOccupancy = 2,
        FuelCapacity = 100.0
    },
    new Zero()
    {
        MainColor = "Black",
        MaximumOccupancy = 1,
        BatteryKWh = 30.0
    }
};

foreach (var vehicle in vehicles)
{
    vehicle.Drive();
    vehicle.Turn();
    vehicle.Stop();
    Console.WriteLine("");
};

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

