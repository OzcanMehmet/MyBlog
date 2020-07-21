# MyBlogApi

Uzun zamandır bir çok yerde gördüğüm fakat kullanmadığım microsoftun dokümanlarında(https://docs.microsoft.com/tr-tr/azure/architecture/patterns/cqrs) olan CQRS paternini kullanarak kendi websitemin apisine başlangıç yaptım. Klasik repository patern kullanarak yapılan işlemler zamanla controllerin çok genişlemesine sebep oluyor. CQRS ile daha küçük controller elde edebiliyoruz. CQRS bağlılığı azaltarak işlemleri ayrık olarak farklılaştırabilmemize olanak sağlıyor. CQRS Paterni uygularken mediator paternini kullarak daha merkezcil bir çözüm olacağını düşündüm. Mediator içinde daha önceden kullanamaya fırsatımın olmadığı MediatR kütüphanesini tercih ettim.MediatR direk olarak inject edebiliyoruz.Repositorylerinde .net core ile inject etmemiz daha gevşek bir yapı sunuyor.DTO ile entityler arasındaki map işlemidene automapper ile yaptım.

Code first olarak başladım, database update ederek kullanabilirsiniz.

Daha ilerleyen zamanlarda User ve JWT Authorization, tag kısmı için controller ve daha sonrada angular ile admin panel ve ön arayüzü yazacağım.Kategoriden çok bir yazıya n adet tag gelebilir olarak kurguladım. 


