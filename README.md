# agac_gunlugu

Projenin amacı nedir?
Bu proje, bir WPF (Windows Presentation Foundation) uygulaması olarak tasarlanmıştır. Amacı, kullanıcıya "tree" komutunu çalıştırma, çıktısını bir txt dosyasına kaydetme ve bu dosyayı belirlediği bir e-posta adresine gönderme imkanı sağlamaktır.

Hangi programlama dili veya teknolojiler kullanılmıştır?

Proje, C# programlama dilini kullanır ve WPF (Windows Presentation Foundation) teknolojisini kullanarak kullanıcı arayüzünü oluşturur. C# dilinde kodlama yapılırken .NET Framework'ün sağladığı kütüphanelerden faydalanılır.

Hangi işlevselliği sunmaktadır ve nasıl kullanılır?

Bu projede, kullanıcıya bir WPF penceresi aracılığıyla aşağıdaki işlevselliği sunar:

*Kullanıcı, WPF penceresinde bulunan bir butona (myButton) tıklayarak "tree" komutunu çalıştırabilir.

*"tree" komutu, bir yeni işlem (process) olarak başlatılır ve cmd.exe üzerinde çalıştırılır. Bu komut, mevcut dizinin ağaç yapısını gösterir.

*Komutun çıktısı, bir metin değişkenine (string) kaydedilir.

*Ardından, çıktı metni bir txt dosyasına kaydedilir. Dosya adı, o anki tarihi temel alarak belirlenir.

*Kullanıcıdan alınan e-posta adreslerine, çıktı dosyası eklenerek e-posta gönderilir. Bu işlem için Gmail SMTP sunucusu kullanılır.

*E-posta gönderimi tamamlandıktan sonra, kullanıcıya bir iletişim kutusu (MessageBox) ile gönderimin başarılı olduğu bilgisi verilir.

Hangi dosyalar veya bileşenler projede bulunmaktadır?

Proje, tek bir dosyadan oluşur: MainWindow.xaml.cs. Bu dosya, projenin ana penceresini temsil eder ve WPF uygulamasının arayüzünü ve kodun geri kalanını içerir. Bu dosya içinde gerekli C# kodları ve XAML (Extensible Application Markup Language) işaretlemeleri bulunur. Kodun içinde, kullanıcı arayüzü öğeleri (metin kutuları, düğmeler vb.) ve bu öğelerin etkileşimlerini yöneten kod parçacıkları yer alır.
