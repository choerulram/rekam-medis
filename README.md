# Sistem Manajemen Rekam Medis

Selamat datang di repository Sistem Manajemen Rekam Medis. Repository ini berisi kode sumber untuk aplikasi manajemen rekam medis yang dikembangkan menggunakan bahasa C# dan Visual Studio.

## Deskripsi

Sistem Manajemen Rekam Medis ini dirancang untuk membantu dalam mengelola informasi rekam medis pasien di klinik atau rumah sakit. Aplikasi ini menyediakan fitur-fitur untuk mengelola data pasien, data dokter, serta rekam medis secara efisien dan aman.

## Fitur Utama

- **Manajemen Pasien**: Tambah, ubah, hapus, dan lihat data pasien.
- **Manajemen Dokter**: Tambah, ubah, hapus, dan lihat data dokter.
- **Manajemen Rekam Medis**: Catat dan kelola rekam medis pasien.
- **Pencarian**: Fitur pencarian untuk memudahkan akses ke data pasien dan dokter.
- **Keamanan Data**: Implementasi keamanan untuk melindungi data sensitif.

## Prasyarat

- **Visual Studio** (versi terbaru direkomendasikan)
- **.NET Framework** (minimal versi 4.7.2)
- **SQL Server** (untuk basis data)

## Instalasi

1. **Clone repository ini**:
   ```sh
   git clone https://github.com/username/SistemManajemenRekamMedis.git
   ```
2. **Buka proyek di Visual Studio**:

   - Buka Visual Studio.
   - Pilih `Open a project or solution`.
   - Navigasikan ke folder tempat Anda meng-clone repository ini dan pilih file solusi `.sln`.

3. **Restore dependensi dan build proyek**:

   - Visual Studio akan otomatis mengembalikan dependensi yang diperlukan.
   - Tekan `Ctrl + Shift + B` untuk membangun proyek.

4. **Konfigurasi basis data**:
   - Buka `App.config` dan sesuaikan string koneksi basis data sesuai dengan konfigurasi SQL Server Anda.
   - Jalankan migrasi basis data menggunakan Package Manager Console:
     ```sh
     Update-Database
     ```

## Penggunaan

1. **Jalankan aplikasi**:

   - Tekan `F5` atau klik `Start` di Visual Studio untuk menjalankan aplikasi.

2. **Navigasi melalui antarmuka pengguna**:
   - Gunakan menu navigasi untuk mengakses fitur-fitur manajemen pasien, dokter, dan rekam medis.

## Kontribusi

Jika Anda ingin berkontribusi pada proyek ini, silakan fork repository ini dan ajukan pull request dengan perubahan Anda. Kami menyambut baik kontribusi dari komunitas!

## Lisensi

Proyek ini dilisensikan di bawah [MIT License](LICENSE).

## Kontak

Jika Anda memiliki pertanyaan atau saran, silakan buka isu di GitHub atau hubungi kami melalui email di [email@example.com].

---

Terima kasih telah menggunakan Sistem Manajemen Rekam Medis kami!
