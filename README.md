# Yandex.Metrica for Apps sample for Windows Phone, Windows Store, .NET 4.5

## What this is

Sample applications using Yandex.Metrica for Apps SDK.


## Required reading

Please check out the [Yandex.Metrica for Apps documentation page][API].


## Installing

### Register for a Yandex ApiKey.

You can register your app at the: [Yandex.Metrica for Apps homepage][REGISTER].


### Reference assemblies

To start using Yandex.Metrica for Apps SDK:

- Reference Yandex.Metrica for Apps nuget package in your Visual Studio project.

## Samples

There are five sample applications using Yandex.Metrica for Apps:

- **Yandex.Metrica.wp7** Windows Phone 7.5 (please note Microsoft.Bcl.Async package reference)
- **Yandex.Metrica.wp8** Windows Phone 8.0
- **Yandex.Metrica.windows8** Windows Store
- **Yandex.Metrica.net45.WPF** .NET 4.5 WPF
- **Yandex.Metrica.net45.WindowsForms** .NET 4.5 Windows Forms

Important: Samples use **ApiKey** value `1111`. The key is specified in **App.xaml** or **App.xaml.cs** or **Program.cs**.

To get your own ApiKey register your application here: [Yandex.Metrica for Apps homepage][REGISTER].

Note: Model-View-ViewModel (MVVM) pattern was not used in the samples. It’s done this way in order to make the code browsing and understanding easier for the SDK user. 


## FAQ

### Which types of applications and frameworks are supported by the SDK?

- Windows Phone applications (7.5 and higher).
- Windows Store applications.
- .NET 4.5 applications.

### Is there any more documentation available?

The SDK classes, interfaces, functions have comments in standard C# XML format. Besides that there is documentation on the [Yandex.Metrica for Apps API page][API]

## License

License agreement on use of Yandex.Metrica for Apps SDK is available at: http://legal.yandex.ru/metrica_termsofuse/


[LICENSE]: http://legal.yandex.ru/metrica_termsofuse/
[API]: http://api.yandex.ru/metrica-mobile-sdk/doc/mobile-sdk-dg/concepts/about.xml "Yandex.Metrica for Apps documentation page"
[REGISTER]: http://appmetrica.yandex.ru/ "Yandex.Metrica for Apps homepage"
