# AkaNet  
**Graph Tabanlı Yol Bulma ve Analiz Uygulaması**

## 👥 Ekip Üyeleri
- Oğuz Atılkan  
- Mehmet Morgül  

## 📅 Tarih
Ocak 2026

---

## 1. Giriş (Problem Tanımı ve Amaç)

Günümüzde sosyal ağlar, ulaşım sistemleri, bilgisayar ağları ve bilgi akışı gibi birçok problem **graf (graph)** yapıları ile modellenmektedir. Bu projede, düğümler (node) ve kenarlar (edge) kullanılarak oluşturulan bir graf üzerinde çeşitli **yol bulma, analiz ve optimizasyon algoritmalarının** uygulanması amaçlanmıştır.

**AkaNet** projesi;  
- Grafik tabanlı verileri görsel olarak oluşturmayı,  
- Düğümler arası ilişkileri analiz etmeyi,  
- Klasik ve sezgisel algoritmalarla yol bulmayı,  
- Graf istatistiklerini kullanıcıya sunmayı  

hedefleyen bir Windows Forms uygulamasıdır.

---

## 2. Projede Gerçeklenen Algoritmalar

Bu projede aşağıdaki algoritmalar gerçeklenmiştir:

- BFS (Breadth First Search)
- DFS (Depth First Search)
- Dijkstra
- A* (A Star)
- Connected Components
- Centrality (Merkezilik Analizi)
- Welsh-Powell Graph Coloring

---

### 2.1 Breadth First Search (BFS)

**Çalışma Mantığı:**  
BFS, graf üzerinde genişlik öncelikli arama yapar. Başlangıç düğümünden itibaren tüm komşular ziyaret edilir, ardından bir sonraki seviye düğümlere geçilir.

**Kullanım Alanları:**  
- En kısa yol (ağırlıksız graflar)
- Seviye tabanlı aramalar

**Zaman Karmaşıklığı:**  
- O(V + E)

**Akış Diyagramı (Mermaid):**
```mermaid
flowchart TD
    A[Başlangıç Düğümü] --> B[Queue'ya Ekle]
    B --> C{Queue Boş mu?}
    C -- Hayır --> D[Düğümü Ziyaret Et]
    D --> E[Komşuları Queue'ya Ekle]
    E --> C
    C -- Evet --> F[Bitiş]
