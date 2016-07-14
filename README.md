Application Insights - CSharp
=============================

Exemplo em C#.NET de utilização do recurso do Azure de monitoramento de aplicações.

Configuração
------------

Informe a Instrumentation Key no arquivo ApplicationInsights.config e na view _Layout.cshtml

Testando os recursos
--------------------

Para gerar valores de visualizações de usuários, sessão, páginas e entre outras métricas de navegação, acesse as seguintes páginas:

 - Home/Index 
 - Home/About

Para testar o recurso de eventos e métricas, utilize a seguinte URL:

 - Home/TrackEvent?eventName=EventName

Para lançar uma exception:

 - Home/ThrowException

Referências
------------

https://azure.microsoft.com/en-us/documentation/articles/app-insights-overview/

https://msdn.microsoft.com/library/mt420197.aspx

https://azure.microsoft.com/en-us/documentation/articles/app-insights-api-custom-events-metrics/
