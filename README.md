# 📚 SapViz - Diák Teljesítményelemző Alkalmazás

## 🚀 Projektleírás

A SapViz egy innovatív Blazor WebAssembly alkalmazás, amely segít a diákoknak nyomon követni és elemezni tanulmányi teljesítményüket. Az alkalmazás lehetővé teszi a féléves jegyek rögzítését, részletes teljesítményelemzést és összehasonlítást az érettségi átlagokkal.

## ✨ Főbb Funkciók

### 1. Jegyek Rögzítése
- Négy évfolyam (9-12. osztály) jegyeinek felvitele
- Három tantárgy: Magyar, Román, Matematika
- Minden félévre külön jegybevitel
- 1-10 közötti osztályzatok

### 2. Teljesítményelemzés
- Tantárgyi teljesítmény részletes elemzése
- Saját átlag összehasonlítása az országos átlaggal
- Percentilis alapú teljesítményszint
- Egyedi javítási javaslatok

### 3. Érettségi Átlag Összehasonlítás
- Saját jegyek összevetése az érettségi átlagokkal
- Tantárgyanként részletes elemzés
- Eltérések megjelenítése

### 4. Adattárolás
- Helyi tárolás böngésző localStorage-ban
- Egyszerű adatkezelés
- Automatikus mentés

## 🛠️ Technológiai Háttér

- **Frontend**: Blazor WebAssembly
- **Adatkezelés**: 
  - localStorage
  - JSON szerializáció
- **Stílus**: Tailwind CSS
- **Komponensek**: MudBlazor

## 🔍 Fejlesztési Célok

- Diákok objektív teljesítményelemzése
- Egyéni fejlesztési javaslatok
- Átlátható, könnyen értelmezhető statisztikák

## 🚀 Telepítés

```bash
# Klónozás
git clone https://github.com/hunorszegedi/netproject.git

# Belépés a projektkönyvtárba
cd netproject

# Függőségek telepítése
dotnet restore

# Alkalmazás futtatása
dotnet run
```

## 📊 Adatvédelem

- Adatok csak helyi tárolásban
- Nem küld adatokat szerverre
- Böngészőben tárolva

## 🤝 Közreműködés

Örömmel fogadjuk a pull requesteket és az észrevételeket!

1. Fork a projekt
2. Készíts saját branchet (`git checkout -b feature/AmazingFeature`)
3. Commitold a változtatásokat (`git commit -m 'Add some AmazingFeature'`)
4. Pushold a branchet (`git push origin feature/AmazingFeature`)
5. Nyiss egy Pull Requestet

---

**Verzió**: 1.0.0