using Northwind.EntityModels; // To use Customer.
namespace Northwind.Blazor.Services;
public interface INorthwindService
{
Task<List<Customer>> GetCustomersAsync();
Task<List<Customer>> GetCustomersAsync(string country);
Task<Customer?> GetCustomerAsync(string id);
Task<Customer> CreateCustomerAsync(Customer c);
Task<Customer> UpdateCustomerAsync(Customer c);
Task DeleteCustomerAsync(string id);
}



      Northwind.Blazor.Services/
        Northwind.Blazor/Components/CustomerDetail.razor
        Northwind.Blazor/Components/Pages/CreateCustomer.razor
        Northwind.Blazor/Components/Pages/Customers.razor
        Northwind.Blazor/Components/Pages/DeleteCustomer.razor
        Northwind.Blazor/Components/Pages/EditCustomer.razor
        Northwind.Blazor/Services/
        Northwind.Blazor/bin/Debug/net8.0/Microsoft.Data.Sqlite.dll
        Northwind.Blazor/bin/Debug/net8.0/Microsoft.EntityFrameworkCore.Abstractions.dll
        Northwind.Blazor/bin/Debug/net8.0/Microsoft.EntityFrameworkCore.Relational.dll
        Northwind.Blazor/bin/Debug/net8.0/Microsoft.EntityFrameworkCore.Sqlite.dll
        Northwind.Blazor/bin/Debug/net8.0/Microsoft.EntityFrameworkCore.dll
        Northwind.Blazor/bin/Debug/net8.0/Microsoft.Extensions.DependencyModel.dll
        Northwind.Blazor/bin/Debug/net8.0/Northwind.Blazor.Services.dll
        Northwind.Blazor/bin/Debug/net8.0/Northwind.Blazor.Services.pdb
        Northwind.Blazor/bin/Debug/net8.0/Northwind.DataContext.Sqlite.dll
        Northwind.Blazor/bin/Debug/net8.0/Northwind.DataContext.Sqlite.pdb
        Northwind.Blazor/bin/Debug/net8.0/Northwind.EntityModels.Sqlite.dll
        Northwind.Blazor/bin/Debug/net8.0/Northwind.EntityModels.Sqlite.pdb
        Northwind.Blazor/bin/Debug/net8.0/SQLitePCLRaw.batteries_v2.dll
        Northwind.Blazor/bin/Debug/net8.0/SQLitePCLRaw.core.dll
        Northwind.Blazor/bin/Debug/net8.0/SQLitePCLRaw.provider.e_sqlite3.dll
        Northwind.Blazor/bin/Debug/net8.0/runtimes/
        Northwind.Blazor/obj/Debug/net8.0/Northwind.Blazor.csproj.AssemblyReference.cache
        Northwind.Blazor/obj/Debug/net8.0/Northwind.Blazor.csproj.CopyComplete
        Northwind.Blazor/wwwroot/icons.css