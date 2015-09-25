# AppMetrica sample for Windows Phone, Windows Store, .NET 4.5

## What this is

Sample applications using AppMetrica SDK.


## Required reading

Please check out the [AppMetrica documentation page][API].


## Installing

### Register for a Yandex ApiKey.

You can register your app at the: [AppMetrica homepage][REGISTER].


### Reference assemblies

To start using Yandex.Metrica for Apps SDK:

- Reference AppMetrica nuget package in your Visual Studio project.

## Samples

There are six sample applications using AppMetrica:

- **Yandex.Metrica.wp8** Windows Phone 8.0
- **Yandex.Metrica.wpa81** Windows Phone 8.1
- **Yandex.Metrica.wp81Silverlight** Windows Phone 8.1 (Silverlight)
- **Yandex.Metrica.windows8** Windows Store
- **Yandex.Metrica.net45.WPF** .NET 4.5 WPF
- **Yandex.Metrica.net45.WindowsForms** .NET 4.5 Windows Forms

Important: Samples don't use any **ApiKey** value. The key should be specified in **App.xaml** or **App.xaml.cs** or **Program.cs**.

To get your own ApiKey register your application here: [AppMetrica homepage][REGISTER].

Note: Model-View-ViewModel (MVVM) pattern was not used in the samples. It’s done this way in order to make the code browsing and understanding easier for the SDK user. 


## FAQ

### Which types of applications and frameworks are supported by the SDK?

- Windows Phone applications (8.0 and higher).
- Windows Store applications.
- .NET 4.5 applications.

### Is there any more documentation available?

The SDK classes, interfaces, functions have comments in standard C# XML format. Besides that there is documentation on the [AppMetrica API page][API]

## License

License agreement on use of AppMetrica SDK is available at: http://legal.yandex.ru/metrica_termsofuse/


[LICENSE]: http://legal.yandex.ru/metrica_termsofuse/
[API]: http://api.yandex.ru/metrica-mobile-sdk/doc/mobile-sdk-dg/concepts/about.xml "AppMetrica documentation page"
[REGISTER]: http://appmetrica.yandex.ru/ "AppMetrica homepage"
