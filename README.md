# RandomProxy
An easy way to get a Random Proxy or a list of Proxies for multiple types!

# What can this Package do?
This Package allows you to implement the usage of random Proxies into your Programs, you can get get a `List of Proxies`, a normal `random Proxy` or if you want to work with the proxy itself, you can get a `Proxy object` that has more information about the Proxy!

# Where can I get this Package?
You can download the Package on [NuGet](https://www.nuget.org/packages/RandomProxy) or soon here on GitHub! You can also:
- Type `Install-Package RandomProxy -Version 1.0` into the Package Manager
- Type `dotnet add package RandomProxy --version 1.0` into the command prompt, note that you need to have `dotnet` installed
- Reference the Dependency using `<PackageReference Include="RandomProxy" Version="1.0" />`
- Install the package in your Editors NuGet Package Manager

# DOCUMENTATION
## Getting a Random Proxy
You can get a random Proxy using the `getRandomProxy()` function!
### Note:
- The `getRandomProxy` function will return a `string`
- The function might return `null` if something goes wrong
- You can change the type of the Proxy using the `GetProxy.proxyType` enum, it contains `all`, `http`, `https`, `socks5`
- The default Proxy type is set to `all`
### Example Usage
```CSharp
Console.WriteLine("Random Proxy: " + RandomProxy.GetProxy.getRandomProxy());
```
### Output
```
Random Proxy: 45.71.196.66:999
```

## Getting a Full Proxy List
You can get a List of Proxies using the `getProxyList()` function!
### Note
- The `getProxyList` function will return a `string[]`
- The function might return `null` if something goes wrong
- You can change the type of the Proxy using the `GetProxy.proxyType` enum, it contains `all`, `http`, `https`, `socks5`
- The default Proxy type is set to `all`
### Example Usage
```CSharp
foreach(string proxy in RandomProxy.GetProxy.getProxyList())
{
    Console.WriteLine(proxy); //There will be no example output for this one as it would only clog up this documentation!
}
```

## Getting a Proxy Object
You can get a Proxy Object using the `getFullProxy()` object! This will allow you to include random Proxies into any Project, and will allow you to see more information about the proxies etc.
### Note:
- The `getFullProxy` object will return multiple datatypes you can work with
- The function might return `null` if something goes wrong
- You can change the type of the Proxy using the `GetProxy.proxyType` enum, it contains `all`, `http`, `https`, `socks5`
- The default Proxy type is set to `all`
- With this object you will be able to get a `random Proxy`, a `full Proxy List`, a `Proxy Count of all the proxies`, the `Proxy Type`
### Example Usage
```CSharp

RandomProxy.GetProxy.getFullProxy Proxy = new RandomProxy.GetProxy.getFullProxy(RandomProxy.GetProxy.proxyType.https); //We will use the https proxy type for this request!

Console.WriteLine("Proxy: " + Proxy.Proxy);
Console.WriteLine("Proxy Count: " + Proxy.ProxyCount);
Console.WriteLine("Proxy Type: " + Proxy.ProxyType);

/* This would clog up the output for the examples
foreach(string proxy in Proxy.ProxyList)
{
    Console.WriteLine(proxy);
}
*/
```
### output
```
Proxy: 185.46.170.253:4145
Proxy Count: 1300
Proxy Type: https
```