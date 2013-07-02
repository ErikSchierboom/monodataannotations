# Mono dataannotations

This project is used to show that the `System.ComponentModel.DataAnnotations.UrlAttribute` class cannot be found in Mono 3.0.12. To verify that it does not work, you need to have an environment where Mono 3.0.12 has been installed. If this is done, execute the following steps to see that Mono 3.0.12 know of the `System.ComponentModel.DataAnnotations.UrlAttribute`:

 1. Build the **MonoDataAnnotations** project
 2. Run the project under Mono 3.0.12
 3. When the website has been loaded, click on the **With [Url] attribute** link

This will result in a error that looks like this:
```
Missing method .ctor in assembly /tmp/root-temp-aspnet-0/1d156a4d/assembly/shadow/d3af320d/907b835b_43d4b156_00000002/MonoDataAnnotations.dll, type System.ComponentModel.DataAnnotations.UrlAttribute
Can't find custom attr constructor image: /tmp/root-temp-aspnet-0/1d156a4d/assembly/shadow/d3af320d/907b835b_43d4b156_00000002/MonoDataAnnotations.dll mtoken: 0x0a000017 
```

This error indicates that no constructor can be found for the `UrlAttribute` class, which we have added to the view model used by the `WithUrlAttribute` action method which is `WithUrlAttributeViewModel`:

    public class WithUrlAttributeViewModel
    {
        [Url]
        public string Url { get; set; }
    }

We can verify that the problem is caused by the `UrlAttribute` class by clicking on the **Without [Url] attribute** link, which leads us to the `WithoutUrlAttribute` action that uses a similar view model but without the `UrlAttribute` data annotation:

    public class WithoutUrlAttributeViewModel
    {
        public string Url { get; set; }
    }

This action method *does* execute successfully, the only difference being that the `UrlAttribute` is not used.

## License
[Apache License 2.0](LICENSE.md)