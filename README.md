🚀 Dapper ile .NET Core'da Yüksek Performanslı Veri Erişimi

Modern .NET projelerinde veri erişim katmanı, performans ve kontrol açısından kritik bir rol oynar.

Entity Framework gibi güçlü ORM araçları yaygın olarak kullanılsa da, bazı senaryolarda daha hızlı ve daha kontrol edilebilir çözümlere ihtiyaç duyarız. İşte tam bu noktada Dapper devreye girer.

Dapper, minimal yapısı sayesinde:

- Yüksek performans sunar
- SQL üzerinde tam kontrol sağlar
- Mikroservis ve CQRS mimarilerinde mükemmel çalışır
- Bu projede neler var?

Bu repoda, Dapper kullanarak katmanlı bir .NET Core uygulaması geliştirdim. İçerikte:

- Dapper entegrasyonu
- AppDbContext yapısı
- DTO kullanımı
- Service katmanı ile CRUD operasyonları
- Parameterized query ile güvenli veri erişimi
- Controller üzerinden API implementasyonu

yer almaktadır.

# Dapper vs Entity Framework

Gerçek dünyada çoğu zaman seçim “ya o ya bu” değildir.

# En doğru yaklaşım genellikle:

- Entity Framework → CRUD & hızlı geliştirme
- Dapper → Performans kritik ve kompleks sorgular

Bu projede de bu yaklaşım temel alınmıştır.

# Ne zaman Dapper kullanmalısın?
- Performans kritik sistemlerde
- Büyük veri setleriyle çalışırken
- Karmaşık SQL sorgularında
- Mikroservis mimarilerinde
- Read-heavy (CQRS) yapılarda

Dapper kullanırken en önemli konu:

-  String birleştirme ile SQL yazmak
-  Parametre kullanmak (DynamicParameters)

🔗 Detaylı anlatım ve kaynak kod

👉 Blog yazısının tamamı ve proje detayları için: https://sinantosun.com/blog-detayi/net-core-dapper-kullanimi-ve-performans-odakli-mimari
