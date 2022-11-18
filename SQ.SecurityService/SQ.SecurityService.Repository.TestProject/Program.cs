using SQ.SecurityService.Repository.Repositories;
internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //var connectionString = "Host=localhost;Port=5431;Database=SQCredential;Username=nat;Password=SoapShoes";
        ////docker run --name securityService -p 5431:5432 -e POSTGRES_USER=nat -e POSTGRES_PASSWORD=SoapShoes -e POSTGRES_DB=SQCredential -d postgres
        //var rep = new CredentialRepository(connectionString);
        //var cr = rep.GetCredentialsAsync("Lily");
        //Console.WriteLine($"{cr.UserName} - {cr.Passwword} ({cr.UserId})");
    }
}