# 🗄️ C# Otomatik Database Oluşturucu

**C# Otomatik Database Oluşturucu**, Microsoft SQL Server üzerinde yeni veritabanları ve tablolar oluşturmayı kolaylaştırmak amacıyla geliştirilmiş bir Windows masaüstü yardımcı uygulamasıdır.

Uygulama **C# / Windows Forms** tabanlıdır ve MetroFramework arayüz bileşenlerini kullanır. SQL Server bağlantısı `System.Data.SqlClient` üzerinden sağlanır. fileciteturn114file0turn115file0

## ✨ Özellikler

- 🗄️ Yeni SQL Server veritabanı oluşturma
- 📋 Yeni tablo oluşturma ekranı
- 🔎 Mevcut veritabanlarını listeleme
- 📊 SQL sorgularını DataGridView/MetroGrid üzerinde görüntüleme
- 🔌 Windows Integrated Security ile SQL Server bağlantısı
- 🖥️ MetroFramework tabanlı kullanıcı arayüzü
- 🧩 Veritabanı ve tablo işlemlerini ayrı ekranlardan yönetme

Ana menü açıldığında SQL Server üzerindeki veritabanlarının isimleri sorgulanarak grid içerisinde listelenir. Veritabanı oluşturma ve tablo oluşturma işlemleri ayrı pencereler üzerinden gerçekleştirilir. fileciteturn116file0

## 🛠️ Kullanılan Teknolojiler

- **C#**
- **Windows Forms**
- **.NET Framework**
- **Microsoft SQL Server**
- **System.Data.SqlClient**
- **MetroFramework**
- **Visual Studio**

## 📂 Proje Yapısı

```text
Csharp-Oto-Database-Olusturcu/
│
├── Csharp Oto Database Oluşturcu.sln
├── LICENSE
│
└── Csharp Oto Database Oluşturcu/
    ├── Csharp Oto Database Oluşturcu.csproj
    ├── Program.cs
    ├── Menu.cs
    ├── Form1.cs
    ├── Tablo_Olusturma.cs
    ├── baglanti.cs
    ├── iletisim.cs
    ├── Properties/
    └── *.Designer.cs / *.resx
```

## 🧭 Uygulama Akışı

```text
              Ana Menü
                 │
       ┌─────────┼─────────┐
       │         │         │
       ▼         ▼         ▼
  Veritabanı   Tablo    Veritabanı
   Oluştur     Oluştur    Listesi
       │         │         │
       ▼         ▼         ▼
    SQL Server / System.Data.SqlClient
```

`Menu` formu açıldığında `sys.databases` üzerinden mevcut veritabanlarını listeler. Veritabanı oluşturma ekranı `Form1`, tablo oluşturma ekranı ise `Tablo_Olusturma` formu üzerinden açılır. fileciteturn116file0

## 🗄️ Veritabanı Oluşturma

Veritabanı oluşturma ekranında girilen veritabanı adı kullanılarak SQL Server üzerinde `CREATE DATABASE` komutu çalıştırılır.

Temel mantık:

```csharp
baglanti.database_create("create database " + databaseName);
```

Bu işlem `Form1.cs` içerisinde gerçekleştirilmektedir. fileciteturn114file0

## 📋 Tablo Oluşturma

Uygulamada tablo oluşturma işlemi için ayrı bir arayüz bulunmaktadır. SQL komutu belirtilen veritabanı bağlantısı üzerinden çalıştırılarak tablo oluşturulabilir.

## 🔌 SQL Server Bağlantısı

Bağlantı sınıfında SQL Server bağlantısı Windows Integrated Security kullanacak şekilde tasarlanmıştır:

```text
Server=<SERVER>;
Integrated Security=true;
```

Belirli bir veritabanına bağlanırken:

```text
Server=<SERVER>;
Integrated Security=true;
Database=<DATABASE>;
```

kullanılır. fileciteturn115file0

Sunucu adı için projede:

```text
C:\ayar.txt
```

yolu tanımlanmıştır. Başka bir bilgisayarda çalıştırırken bu yapılandırmanın güncellenmesi gerekebilir. fileciteturn115file0

> ⚠️ **Güvenlik:** Uygulama doğrudan SQL komutları çalıştırdığı için kullanıcıdan alınan değerlerin doğrulanması önemlidir. Özellikle veritabanı ve tablo adları için SQL injection ve geçersiz identifier risklerine karşı güvenli doğrulama yapılması önerilir.

## ⚙️ Kurulum

### Gereksinimler

- Windows
- Visual Studio
- .NET Framework
- Microsoft SQL Server
- MetroFramework bağımlılığı

### 1. Repoyu klonlayın

```bash
git clone https://github.com/ebubekirbastama/Csharp-Oto-Database-Olusturcu.git
cd Csharp-Oto-Database-Olusturcu
```

### 2. Solution dosyasını açın

Visual Studio ile:

```text
Csharp Oto Database Oluşturcu.sln
```

dosyasını açın.

### 3. SQL Server bağlantısını hazırlayın

Uygulamanın çalışacağı Windows kullanıcısının SQL Server'a Windows Authentication ile erişebildiğinden emin olun.

### 4. Sunucu ayarını kontrol edin

Projede tanımlanan `C:\ayar.txt` yapılandırmasını kendi SQL Server sunucunuza göre düzenleyin.

### 5. Derleyin ve çalıştırın

Visual Studio üzerinden **Build** ve ardından **Start** işlemlerini gerçekleştirin.

## ⚠️ Proje Durumu

Bu proje küçük ve pratik bir SQL Server yönetim yardımcısı olarak hazırlanmıştır. Üretim ortamında kullanılmadan önce SQL komutlarının güvenli şekilde oluşturulması ve hata yönetiminin güçlendirilmesi önerilir.

Gelecekte yapılabilecek geliştirmeler:

- Modern .NET sürümüne geçiş
- `Microsoft.Data.SqlClient` kullanımı
- Connection string'in `appsettings` üzerinden yönetilmesi
- Veritabanı adı ve tablo adı için güvenli identifier doğrulaması
- Parametreli SQL sorgularının yaygınlaştırılması
- SQL Server bağlantı testi ekranı
- Veritabanı silme/backup/restore gibi işlemlerin kontrollü şekilde eklenmesi
- İşlem günlükleri ve daha ayrıntılı hata raporlaması

## 🤝 Katkıda Bulunma

1. Repoyu fork edin.
2. Yeni bir branch oluşturun.
3. Değişikliklerinizi yapın.
4. Test edin.
5. Pull Request gönderin.

## 📄 Lisans

Bu repository içerisinde `LICENSE` dosyası bulunmaktadır. Kullanım ve dağıtım koşulları için lisans dosyasına bakın.

## 👨‍💻 Geliştirici

**Ebubekir Bastama**

GitHub: https://github.com/ebubekirbastama
