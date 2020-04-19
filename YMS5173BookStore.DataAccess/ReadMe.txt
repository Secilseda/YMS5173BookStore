  
    1.Projenin amacı: Code first yaklaşımı ile var olmayan bizim kendi senaryomuza(modelimize) göre, VeriTabanımızı ve tablolarımızı oluşturup Sql server Management studio'ya gölge olarak göndermek. Gönderme olayını migration gerçekleştiğinde yaparız.
       Kapsamı: OOP mimarisi ile bir sınıf yaratarak başka sınıflara kalıtım vasıtasıyla miras bırakırız yani, ana sınıvın(Base Entity)İçerisinde olan proportyleri kalıtım alacağı sınıfa aktarır, bu sayede diğer tablolarımızda id gibi primariy key olacak özellikleri sadece ana sınıfta yaratıp bu tablolara miras bırakmış oluruz. Bu yöntem kod kalabalığından bizi kurtararak nesne yönelimli programlama sayesinde projelErin hızını artırır.

       Bu Projede Composite Key (Birleşik Anahtar)'a da değiniyoruz. 
         Composite Key; VeriTabanı oluştururken , tablodaki kayıtların benzersiz olması için her tabloya genellikle 1 tane birinci anahtar yerleştiririz.Ancak bazı durumlarda 1 tane birincil anahtar tek başına istediğimiz şekilde tablodaki sorunları çözmek için yeterli olmayabilir. Birden fazla alanın birlikte birincil olması gerektiği durumlarda birincil anahtar olarak ayarlaması gerekir. Bu duruma composite key adı verilir. Book Store Projemizde çoka çok ilişki vardır. Örneğin  Bir kitabın birden fazla yazarı olabilir, bir yazarda birden fazla kitap yazabilir.

        Projede 4 Katman mevcut. Birnci katmanımızda Veritabanı ilişkilendirmeyi migration ile yapıyoruz. İkinci katmanda tablolarımızı(class) yaratıyoruz Update database ile veritabanında güncelleyerek tablolarımızın yansımasını hazırlıyoruz. Üçüncü katmanda ise class'larımızı repository yöntemi ile içerisine metotlar yazarak kod kalabalığından kurtarıyoruz.Dördüncü ve son katmanda ise Kullanıcının göreceği Form pencerelerimizi oluşturuyoruz gerekli kodlamaları yaparak veritabanı ile ilişkili kodlamaları hayata geçirerek kullanıcının kullanılabileceği hale getiriyoruz.


        2.Kullanılan Teknolojiler :Repository temel olarak veritabanı sorgulama işlemlerinin bir merkezden yapılmasını sağlayarak iş katmanına bu işlerin taşınmasını önler bu şekilde sorgu ve kod tekrarına engel olmuş olur. Yani asıl amaç veri işlem ve sorgulamaların tekrarlardan kaçınılarak merkezi bir yapıya çekilmesidir .Bu sayede veritabanı işlemlerimizi tekrar ve tekrar iş katmanı içinde yazmaktan uzak dururuz.
        Entity Framemwork Teknolojisi:Bir ORM mimarisidir. Object Relation Mapping(ORM) İlişkisel veritabanı ile nesneye yönelik programlama (OOP)arasında bir köprü görevi gören araçtır.Bu köprü, ilişkisel veritabanındaki bilgilerimizi yönetmek için nesne modellerimizi kullandığımız bir yapıdır. Veritabanına bizim nesnelerimizi bağlayan ve izin için veri alışverişini yapan Microsoft tarafından geliştirilmiş bir framework'tür. 

        Entity Framemwork  ile 3 farklı yöntem kullanarak proje geliştirilebilir.
         Bu yöntemler;
          1.Model First= Visual studio ile yeni veritabanı oluşturmak.
            2.DataBase First= Var olan veritabanını kullanmak.
             3.Code First = Yeni veritabanını kod yazarak oluşturmak.(Bu projede kullanılan yöntem)
          
              

