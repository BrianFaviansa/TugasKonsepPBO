using Ngerakit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("         PC Building Simulator");
        Console.WriteLine("========================================");

        Klien klien1 = new Klien();

        Console.WriteLine("\nMasukkan nama");
        klien1.namaKlien = Console.ReadLine();
        Console.WriteLine("Masukkan No. Telpon");
        klien1.noTelpon = (Console.ReadLine());

        Komputer komputer = Komputer.BuildPC();

        if (komputer != null)
        {
            Console.Clear();
            Console.WriteLine(klien1.rakitSelesai(DateTime.Now));
            Console.WriteLine($"\nMerk\t\t: {komputer.merk}");
            Console.WriteLine($"Processor\t: {komputer.processor.merk} {komputer.processor.tipe}");
            Console.WriteLine($"Motherboard\t: {komputer.motherboard.merk}");
            Console.WriteLine($"VGA\t\t: {komputer.vga.merk} {komputer.vga.tipe}");
            Console.WriteLine($"RAM\t\t: {komputer.ram.merk} {komputer.ram.memory} GB");
            Console.WriteLine($"PSU\t\t: {komputer.psu.nama} {komputer.psu.watt} watt");
            if (komputer.storage.kapasitas != 500)
            {
                Console.WriteLine(
                    $"Storage\t\t: {komputer.storage.jenis} {komputer.storage.merk} {komputer.storage.kapasitas} TB");
            }
            else
            {
                Console.WriteLine(
                    $"Storage\t\t: {komputer.storage.jenis} {komputer.storage.merk} {komputer.storage.kapasitas} GB");
            }

            Console.WriteLine($"Casing\t\t: {komputer.casing.merk}");

            Console.WriteLine("\nCoba komputer untuk : ");
            Console.WriteLine("1. Main Game");
            Console.WriteLine("2. Editing");
            Console.WriteLine("3. Mengerjakan Tugas");
            int pilihAktivitas = int.Parse((Console.ReadLine()));

            komputer.Nyalakan();

            switch (pilihAktivitas)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Pilih game : 1. online / 2. offline");
                    int jenisGame = int.Parse(Console.ReadLine());
                    if (jenisGame == 1)
                    {
                        Console.WriteLine("Masukkan jumlah player");
                        int jmlPlayer = int.Parse(Console.ReadLine());
                        komputer.MainGame("online",jmlPlayer);
                    }
                    else
                    {
                        komputer.MainGame("offline");
                    }
                    komputer.Matikan();
                    break;
                case 2:
                    komputer.Editing();
                    komputer.Matikan();
                    break;
                case 3:
                    komputer.MengerjakanTugas();
                    komputer.Matikan();
                    break;
                default:
                    Console.WriteLine("Pilihan aktivitas tidak valid");
                    return;
            }

            komputer.salamPenutup();
        }
        else
        {
            Console.WriteLine("\nGagal merakit komputer. Silakan coba lagi.");
        }
    }

    
}