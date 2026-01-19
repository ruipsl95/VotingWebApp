using VotingWebApp.Components;
using Grpc.Net.Client;
using System.Net.Http;
using VotingSystem;       
using VotingSystem.Voting; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// --- INÍCIO CONFIGURAÇÃO GRPC---

// Handler para ignorar certificado SSL inválido (igual ao -insecure)
var httpHandler = new HttpClientHandler();
httpHandler.ServerCertificateCustomValidationCallback = 
    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

// Criar canal gRPC (Porta 9091 com HTTPS)
var channel = GrpcChannel.ForAddress("https://ken01.utad.pt:9091", new GrpcChannelOptions
{
    HttpHandler = httpHandler
});

// Registar os serviços gRPC para injeção
builder.Services.AddSingleton(new VoterRegistrationService.VoterRegistrationServiceClient(channel));
builder.Services.AddSingleton(new VotingService.VotingServiceClient(channel));

// --- FIM CONFIGURAÇÃO GRPC ---

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(); // Garante interatividade

app.Run();