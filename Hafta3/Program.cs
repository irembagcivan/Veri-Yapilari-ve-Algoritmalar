// fonksiyon ile metodun farkı: yüksek seviyeli dillerde nesne oluşturduğumuzda onlar metod olur (nesne tabanlı programlama dillerinde).
// return; bulunduğumuz metod içerisinden çıkmayı sağlıyor

LinkedList ll = new LinkedList(); //nesne oluşturma yapısı
ll.InsertFirst(4); // Baş eleman 4 olur
ll.InsertLast(5); // Son eleman 5 olur
MessageBox.Show(ll.DisplayElements()); // Ekrana 4 ve 5 yazar.