var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorPagesContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesContext")));

var app = builder.Build();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

SeedData.Initialize(services);

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();