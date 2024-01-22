




var builder = WebApplication.CreateBuilder();
var app = builder.Build();


app.Map("/home",
    appBuilder =>
    {
        appBuilder.Map("/index", Index);
        appBuilder.Map("/about", About);


        appBuilder.Run(async (context) =>
        {
            await context.Response.WriteAsync("HOME PAGE");
        });
    }
    );

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Not found");
});

app.Run();







void Index(IApplicationBuilder appBuilder)
{
    appBuilder.Run(async (context) =>
    {
        await context.Response.WriteAsync("This is Index Page");
    });
}

void About(IApplicationBuilder appBuilder)
{
    appBuilder.Run(async (context) =>
    {
        await context.Response.WriteAsync("This is About Page");
    });
}

void List(IApplicationBuilder appBuilder)
{
    appBuilder.Run(async (context) =>
    {
        await context.Response.WriteAsync("This is List Page");
    });
}

void Users(IApplicationBuilder appBuilder)
{
    appBuilder.Run(async (context) =>
    {
        await context.Response.WriteAsync("This is Users Page");
    });
}







/*
app.Map("/index", Index);
app.Map("/about", About);
app.Map("/users", Users);


app.Run(async(context) =>
{
    await context.Response.WriteAsync("Not found");
});

app.Run();

void Index(IApplicationBuilder appBuilder)
{
    var time = DateTime.Now;
    appBuilder.Run(async context => await context.Response.WriteAsync("Page Index"));
}

void About(IApplicationBuilder appBuilder)
{
    appBuilder.Run(async context => await context.Response.WriteAsync("Page About"));
}


void Users(IApplicationBuilder appBuilder)
{
    appBuilder.Run(async context => await context.Response.WriteAsync("Page Users"));
}

*/




/*
app.Map("/index",
    appBuilder =>
    {
        appBuilder.Run(async context => 
        {
            await context.Response.WriteAsync("This start menu");
            var time = DateTime.Now.ToShortTimeString();
            Console.WriteLine($"Index Page opening in: {time}");
            
        }
        ); 
    }
    );
app.Map("/about",
    appBuilder =>
    {
        appBuilder.Run(async context =>
        {
            await context.Response.WriteAsync("This menu about");
            var time = DateTime.Now.ToShortTimeString();
            Console.WriteLine($"About opening in: {time}");
        });
    });
app.Map("/users",
    appBuilder =>
    {
        appBuilder.Run(async context =>
        {
            await context.Response.WriteAsync("table users");
            var time = DateTime.Now.ToShortTimeString();
            Console.WriteLine($"Users opening in: {time}");
        });
    }
    );
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Page not found");
});
app.Run();
*/