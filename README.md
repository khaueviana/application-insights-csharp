# application-insights-csharp

Example C # .NET using the application monitoring Azure resource.

Configuration
------------

Inform the Instrumentation Key in ApplicationInsights.config file and view _Layout.cshtml.

Testing the resources
--------------------

To generate views values of users, session, pages and navigation among other metrics , visit the following pages:

 - Home/Index 
 - Home/About

To test the event and resource metrics , use the following URL:

 - Home/TrackEvent?eventName=EventName

To throw an exception:

 - Home/ThrowException

References
------------

https://azure.microsoft.com/en-us/documentation/articles/app-insights-overview/

https://msdn.microsoft.com/library/mt420197.aspx

https://azure.microsoft.com/en-us/documentation/articles/app-insights-api-custom-events-metrics/
