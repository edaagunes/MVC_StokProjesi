# Stok Takip Projesi

**MVC Design Pattern'i** kullanılarak oluşturulan bu projede Kategori, Ürün, Müşteri kısımlarının **CRUD** işlemleri gerçekleştirilmiştir. 

### **MVC Nedir** ❓

MVC, Yazılım Mühendisliği’nde önemli bir yere sahip architectural patterns (yazılım mimari desenleri)’ın bir parçasıdır. Model, View ve Controller kelimelerinin baş harflerinden oluşan MVC (Model-View-Controller), 1979 yılında Tygve Reeskaug tarafından oluşturulmuş ve yazılım gelişmede bir çok projede kullanılmıştır. Son dönemlerde Microsoft’un MVC desenini Asp.Net teknolojisi ile birleştirmesi ile popülaritesi daha da artmıştır.

MVC deseni, 3 katmandan oluşmaktadır ve katmanları birbirinden bağımsız (birbirini etkilemeden) olarak çalışmaktadır. Bu sebeple çoğunlukla büyük çaplı projelerde projelerin yönetiminin ve kontrolünün daha rahat sağlanabilmesi için tercih edilmektedir. MVC ile geliştirilen projelerde projenin detaylarına göre bir çok kişi eş zamanlı olarak kolaylıkla çalışabilmektedir.

🔴 **Model:**  MVC’de projenin iş mantığının (business logic) oluşturulduğu bölümdür. İş mantığıyla beraber doğrulama (validation) ve veri erişim (data access) işlemleri de bu bölümde gerçekleştirilmektedir.

🔴 **View:** View, MVC’de projenin arayüzlerinin oluşturulduğu bölümdür. Bu bölümde projenin kullanıcılara sunulacak olan HTML dosyaları yer almaktadır. Projenin geliştirildiği yazılım dillerine göre dosya uzantıları da değişebilmektedir. View’ın bir görevi de, kullanıcılardan alınan istekleri controller’a iletmektir.

🔴 **Controller:** Controller, MVC’de projenin iç süreçlerini kontrol eden bölümdür. Bu bölümde View ile Model arasındaki bağlantı kurulur. Kullanıcılardan gelen istekler (request) Controller’larda değerlendirilir, isteğin detayına göre hangi işlemlerin yapılacağı ve kullanıcıya hangi View’ın döneceği (response) belirtilir.

♻️ MVC Life Cycle 

![image](https://github.com/user-attachments/assets/59f83975-335d-4da1-8313-a5733ed6fd40)


### :round_pushpin:  SQL Veri Tabanı İlişkisi
![1](https://github.com/user-attachments/assets/c47c819a-6bfe-4c3a-8beb-d7e13af5a8bc)

### :round_pushpin:  Ürün Kategori İşlemleri

✔️ Kategori sekmesinde ürünler listelendi. **Silme, Güncelleme ve Yeni Kategori Ekleme** işlemleri gerçekleştirildi.

![2](https://github.com/user-attachments/assets/e7accd97-01cd-4845-b84a-5a5425ba268f)
![4](https://github.com/user-attachments/assets/c96e4203-e8f9-41cb-83c6-389b4514c356)
![5](https://github.com/user-attachments/assets/95006883-354f-47ca-a944-5a8c603a0cf3)

### :round_pushpin:  Ürünler

✔️ **Paging** yapısı kullanılarak ürünler listelendi. 

![6](https://github.com/user-attachments/assets/ba07414e-3835-468d-a8d0-bab4bf9d4d77)

✔️ **Silme, Güncelleme, Arama ve Yeni Ürün Ekleme** işlemleri gerçekleştirildi.

![7](https://github.com/user-attachments/assets/48fa8653-5277-4ff5-9085-1bafe23720a1)
![8](https://github.com/user-attachments/assets/b8cee981-9b87-4af9-9315-b9db262345d9)
![9](https://github.com/user-attachments/assets/377a6ea5-3f41-434f-91dc-10022bc7a25e)

### :round_pushpin: Müşteriler

✔️ **Silme, Güncelleme, Arama ve Yeni Ürün Ekleme** işlemleri gerçekleştirildi.

![10](https://github.com/user-attachments/assets/c2d79918-8897-444d-9438-ccf6facfc387)
![11](https://github.com/user-attachments/assets/61635d54-e949-4d47-bdad-66f9f055edc7)
![12](https://github.com/user-attachments/assets/98438736-77f6-40c3-b7d9-42d7166dbd23)

✔️ **Alert** kullanılarak Silme işlemlerinde Kullanıcı'ya bildirimde bulunuldu.

![13](https://github.com/user-attachments/assets/2b0b59af-0307-4d9d-81f1-e3fc490f32a5)

### :round_pushpin: Satış Menüsü

✔️ Ürün satışı gerçekleştirmek için bilgiler girildikten sonra satış bilgisi veri tabanını eklenir.

![14](https://github.com/user-attachments/assets/87da7ffc-dc26-4835-bb41-e0d04fc20da4)
![15](https://github.com/user-attachments/assets/254693b1-7db4-47f0-a307-b08a05e66922)

### :round_pushpin:  Yardım Menüsü

![16](https://github.com/user-attachments/assets/e0474b1d-d37d-4b56-af42-2523742cb245)

















