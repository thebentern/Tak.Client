# Tak.Client
A simple C# client for asynchronously consuming CoT events from a TAK Server over SSL

* Utilizes [dpp.cot](https://github.com/darkplusplus/cot) library for serialization / deserialization of Cursor on Target events
* Asynchronous methods for sending / recieving CoTs
* Listen mode for service encapsulation

## Basic Usage
```csharp
var takClient = new TakClient(@"C:\path\to\my\datapackage\atak.zip");
await takClient.ListenAsync(myAsyncCoTEventHandler);
```

> **Warning**
> By default, `ignoreCertificateValidationIssues` is set to true. Set this parameter to false when constructing a TakClient instance to fail on certificate issues. 


## License

Distributed under the GNU GPLv3 License. See `LICENSE` for more information.