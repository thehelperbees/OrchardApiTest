//using Newtonsoft.Json;
//using OrchardCore.Markdown.Services;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddCors(o => o.AddDefaultPolicy(builder =>
//{
//    builder.AllowAnyOrigin()
//    .AllowAnyMethod()
//    .AllowAnyHeader();
//}));
//builder.Services.AddOrchardCms().ConfigureServices(tenantServices =>
//             tenantServices.PostConfigure<MarkdownPipelineOptions>(o =>
//             {
//                 o.Configure.Clear();
//             }));
//builder.Services.AddHttpContextAccessor();

//var app = builder.Build();

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseCors();
//if (app.Environment.IsDevelopment())
//{
//    app.UsePathBase("/resources");
//}
//app.UseRouting();
//app.UseOrchardCore();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("/", context =>
//    {
//        return Task.Run(() =>
//        {
//            context.Response.Redirect("/resources/admin");
//        });
//    });
//});

//app.Run();
