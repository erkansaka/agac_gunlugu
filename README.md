# agac_kaydet

Projemin amacı:

Kullanıcıya bir WPF penceresi aracılığıyla "Tree" komutunu çalıştırma ve çıktısını bir txt dosyasına kaydetme imkanı sunmaktır.
Ayrıca, kullanıcının belirlediği e-posta adresine bu txt dosyasını gönderme özelliği sağlar.

Kullanılan programlama dili ve teknolojiler:

Bu kod C# programlama dilini kullanır ve WPF (Windows Presentation Foundation) teknolojisi üzerine inşa edilmiştir.

Sağladığı işlevsellik ve kullanımı:

Kullanıcı arayüzünde bir buton (myButton) bulunur. Kullanıcı bu butona tıkladığında, "tree" komutu cmd.exe üzerinden çalıştırılır.
"tree" komutunun çıktısı okunarak bir txt dosyasına yazılır. Dosya adı, o anki tarihi temel alarak belirlenir.
Ardından, kullanıcının belirlediği e-posta adresine çıktı dosyası eklenerek gönderilir. E-posta gönderimi için Gmail SMTP sunucusu kullanılır.
Son olarak, bir iletişim kutusu (MessageBox) ile e-posta gönderiminin başarılı olduğu bilgisi kullanıcıya gösterilir.

Projede bulunan dosyalar ve bileşenler:

Bu kod, tek bir dosya içinde (MainWindow.xaml.cs) yer alır. Bu dosya, bir WPF uygulamasının ana penceresini temsil eder ve kodun geri kalan kısmını içerir.
Bu bilgiler doğrultusunda, kodun "WpfTreeCommand" adlı bir WPF projesine ait olduğunu söyleyebiliriz. Proje, kullanıcıya "tree" komutunu çalıştırma, çıktıyı kaydetme ve e-posta ile gönderme yetenekleri sunar.
