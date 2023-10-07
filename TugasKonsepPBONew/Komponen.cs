namespace Ngerakit
{
    class Klien
    {
        private string _namaKlien;

        public string namaKlien
        {
            get { return this._namaKlien; }
            set { this._namaKlien = value; }
        }

        private string _noTelpon;

        public string noTelpon
        {
            get { return this._noTelpon; }
            set { this._noTelpon = value; }
        }
        
        public string rakitSelesai(DateTime waktuSelesai)
        {
            return
                $"Pesanan rakitan PC atas nama {namaKlien} telah selesai pada {waktuSelesai.ToString("dddd, dd MMMM yyyy HH:mm:ss")}";
        }
    }

    interface IPC
    {
        public void Nyalakan();
        public void Matikan();
        public void Editing();
        public void MengerjakanTugas();
    }

    class Komputer : IPC
    {
        public string merk;
        public Processor processor { get; set; }
        public Vga vga { get; set; }
        public Motherboard motherboard { get; set; }
        public RAM ram { get; set; }
        public PSU psu { get; set; }
        public Storage storage { get; set; }
        public Casing casing { get; set; }

        public static Komputer BuildPC()
        {
            Console.WriteLine("\nPilih template PC rakitan atau rakit sendiri :");
            Console.WriteLine("1. PC Low End Intel NVIDIA");
            Console.WriteLine("2. PC Mid End Intel NVIDIA");
            Console.WriteLine("3. PC High End Intel NVIDIA");
            Console.WriteLine("4. PC Low End AMD Radeon");
            Console.WriteLine("5. PC Mid End AMD Radeon");
            Console.WriteLine("6. PC High End AMD Radeon");
            Console.WriteLine("7. Rakit PC Sendiri");
            int pilihTemplate = int.Parse(Console.ReadLine());

            Komputer komputer = null;

            switch (pilihTemplate)
            {
                case 1:
                    komputer = BuildLowEndIntelNvidiaPC();
                    break;
                case 2:
                    komputer = BuildMidEndIntelNvidiaPC();
                    break;
                case 3:
                    komputer = BuildHighEndIntelNvidiaPC();
                    break;
                case 4:
                    komputer = BuildLowEndAmdRadeonPC();
                    break;
                case 5:
                    komputer = BuildMidEndAmdRadeonPC();
                    break;
                case 6:
                    komputer = BuildHighEndAmdRadeonPC();
                    break;
                case 7:
                    komputer = BuildCustomPC();
                    break;
                default:
                    Console.WriteLine("Pilihan template tidak valid.");
                    break;
            }

            return komputer;
        }

        static Komputer BuildLowEndIntelNvidiaPC()
        {
            Komputer komputer = new Komputer();

            komputer.merk = "Low End Intel";
            komputer.processor = new CoreI3();
            komputer.motherboard = new Asrock();
            komputer.vga = new GTX750();
            komputer.ram = new Kingston();
            komputer.ram.memory = 4;
            komputer.psu = new Corsair();
            komputer.storage = new Seagate();
            komputer.storage.kapasitas = 500;
            komputer.casing = new Simbadda();

            return komputer;
        }

        static Komputer BuildMidEndIntelNvidiaPC()
        {
            Komputer komputer = new Komputer();

            komputer.merk = "Mid End Intel";
            komputer.processor = new CoreI5();
            komputer.motherboard = new Gigabyte();
            komputer.vga = new GTX1650();
            komputer.ram = new ramCorsair();
            komputer.ram.memory = 16;
            komputer.psu = new PSUAerocool();
            komputer.storage = new  SSDCorsair();
            komputer.storage.kapasitas = 1;
            komputer.casing = new  CasingAerocool();

            return komputer;
        }

        static Komputer BuildHighEndIntelNvidiaPC()
        {
            Komputer komputer = new Komputer();

            komputer.merk = "High End Intel";
            komputer.processor = new CoreI9();
            komputer.motherboard = new MoboAsus();
            komputer.vga = new RTX4090();
            komputer.ram = new HyperX();
            komputer.ram.memory = 32;
            komputer.psu = new AsusROG();
            komputer.storage = new  SSDCorsair();
            komputer.storage.kapasitas = 4;
            komputer.casing = new Armageddon();

            return komputer;
        }

        static Komputer BuildLowEndAmdRadeonPC()
        {
            Komputer komputer = new Komputer();

            komputer.merk = "Low End AMD";
            komputer.processor = new Ryzen3();
            komputer.motherboard = new Asrock();
            komputer.vga = new R5();
            komputer.ram = new Kingston();
            komputer.ram.memory = 4;
            komputer.psu = new Corsair();
            komputer.storage = new WDCaviar();
            komputer.storage.kapasitas = 500;
            komputer.casing = new Simbadda();

            return komputer;
        }

        static Komputer BuildMidEndAmdRadeonPC()
        {
            Komputer komputer = new Komputer();

            komputer.merk = "Mid End AMD";
            komputer.processor = new Ryzen5();
            komputer.motherboard = new MoboAsus();
            komputer.vga = new RX5600XT();
            komputer.ram = new ramCorsair();
            komputer.ram.memory = 16;
            komputer.psu = new PSUAerocool();
            komputer.storage = new Adata();
            komputer.storage.kapasitas = 2;
            komputer.casing = new Venom();

            return komputer;
        }

        static Komputer BuildHighEndAmdRadeonPC()
        {
            Komputer komputer = new Komputer();

            komputer.merk = "High End AMD";
            komputer.processor = new Ryzen7();
            komputer.motherboard = new MoboAsus();
            komputer.vga = new RX6800();
            komputer.ram = new HyperX();
            komputer.ram.memory = 64;
            komputer.psu = new AsusROG();
            komputer.storage = new Adata();
            komputer.storage.kapasitas = 4;
            komputer.casing = new Armageddon();

            return komputer;
        }

        static Komputer BuildCustomPC()
        {
            Komputer komputer = new Komputer();

            Console.Clear();
            Console.WriteLine("Pilih Merk Komputer : ");
            Console.WriteLine("1. Asus");
            Console.WriteLine("2. Acer");
            Console.WriteLine("3. Samsung");
            Console.WriteLine("4. LG");
            int pilihMerkKomputer = int.Parse(Console.ReadLine());

            switch (pilihMerkKomputer)
            {
                case 1:
                    komputer.merk = "Asus";
                    break;
                case 2:
                    komputer.merk = "Acer";
                    break;
                case 3:
                    komputer.merk = "Samsung";
                    break;
                case 4:
                    komputer.merk = "LG";
                    break;
                default:
                    Console.WriteLine("Pilihan komputer tidak valid.");
                    return null;
            }

            Console.Clear();
            Console.WriteLine("Pilih Processor:");
            Console.WriteLine("1. Intel Pentium");
            Console.WriteLine("2. Intel Core i3");
            Console.WriteLine("3. Intel Core i5");
            Console.WriteLine("4. Intel Core i7");
            Console.WriteLine("5. Intel Core i9");
            Console.WriteLine("6. AMD Athlon");
            Console.WriteLine("7. AMD Ryzen 3");
            Console.WriteLine("8. AMD Ryzen 5");
            Console.WriteLine("9. AMD Ryzen 7");
            int pilihProcessor = int.Parse(Console.ReadLine());

            switch (pilihProcessor)
            {
                case 1:
                    komputer.processor = new Pentium();
                    break;
                case 2:
                    komputer.processor = new CoreI3();
                    break;
                case 3:
                    komputer.processor = new CoreI5();
                    break;
                case 4:
                    komputer.processor = new CoreI7();
                    break;
                case 5:
                    komputer.processor = new CoreI9();
                    break;
                case 6:
                    komputer.processor = new Athlon();
                    break;
                case 7:
                    komputer.processor = new Ryzen3();
                    break;
                case 8:
                    komputer.processor = new Ryzen5();
                    break;
                case 9:
                    komputer.processor = new Ryzen7();
                    break;
                default:
                    Console.WriteLine("Pilihan processor tidak valid.");
                    return null;
            }

            Console.Clear();
            Console.WriteLine("Pilih Motherboard:");
            Console.WriteLine("1. Asus");
            Console.WriteLine("2. Asrock");
            Console.WriteLine("3. Gigabyte");
            int pilihMobo = int.Parse(Console.ReadLine());

            switch (pilihMobo)
            {
                case 1:
                    komputer.motherboard = new MoboAsus();
                    break;
                case 2:
                    komputer.motherboard = new Asrock();
                    break;
                case 3:
                    komputer.motherboard = new Gigabyte();
                    break;
                default:
                    Console.WriteLine("Pilihan motherboard tidak valid");
                    return null;
            }

            Console.Clear();
            Console.WriteLine("Pilih VGA:");
            Console.WriteLine("1. NVIDIA GeForce GTX 750");
            Console.WriteLine("2. NVIDIA GeForce GTX 1050");
            Console.WriteLine("3. NVIDIA GeForce RTX 1650");
            Console.WriteLine("4. NVIDIA GeForce RTX 2070");
            Console.WriteLine("5. NVIDIA GeForce RTX 3060");
            Console.WriteLine("6. NVIDIA GeForce RTX 4090");
            Console.WriteLine("7. AMD Radeon R5");
            Console.WriteLine("8. AMD Radeon RX 570");
            Console.WriteLine("9. AMD Radeon RX 5600 XT");
            Console.WriteLine("10. AMD Radeon RX 6800 XT");
            int pilihVGA = int.Parse(Console.ReadLine());

            switch (pilihVGA)
            {
                case 1:
                    komputer.vga = new GTX750();
                    break;
                case 2:
                    komputer.vga = new GTX1050();
                    break;
                case 3:
                    komputer.vga = new GTX1650();
                    break;
                case 4:
                    komputer.vga = new RTX2070();
                    break;
                case 5:
                    komputer.vga = new RTX3060();
                    break;
                case 6:
                    komputer.vga = new RTX4090();
                    break;
                case 7:
                    komputer.vga = new R5();
                    break;
                case 8:
                    komputer.vga = new RX570();
                    break;
                case 9:
                    komputer.vga = new RX5600XT();
                    break;
                case 10:
                    komputer.vga = new RX6800();
                    break;
                default:
                    Console.WriteLine("Pilihan VGA tidak valid.");
                    return null;
            }


            Console.Clear();
            Console.WriteLine("Pilih RAM:");
            Console.WriteLine("1.HyperX");
            Console.WriteLine("2.Corsair");
            Console.WriteLine("3.Kingston");
            int pilihRAM = int.Parse(Console.ReadLine());


            switch (pilihRAM)
            {
                case 1:
                    komputer.ram = new HyperX();
                    break;
                case 2:
                    komputer.ram = new ramCorsair();
                    break;
                case 3:
                    komputer.ram = new Kingston();
                    break;
                default:
                    Console.WriteLine("Pilihan RAM tidak valid.");
                    return null;
            }

            Console.Clear();
            Console.WriteLine("Pilih Kapasitas RAM:");
            Console.WriteLine("1. 4 GB");
            Console.WriteLine("2. 8 GB");
            Console.WriteLine("3. 16 GB");
            Console.WriteLine("4. 32 GB");
            Console.WriteLine("5. 64 GB");
            int pilihKapasitasRAM = int.Parse(Console.ReadLine());

            switch (pilihKapasitasRAM)
            {
                case 1:
                    komputer.ram.memory = 4;
                    break;
                case 2:
                    komputer.ram.memory = 8;
                    break;
                case 3:
                    komputer.ram.memory = 16;
                    break;
                case 4:
                    komputer.ram.memory = 32;
                    break;
                case 5:
                    komputer.ram.memory = 64;
                    break;
                default:
                    Console.WriteLine("Pilihan memory tidak valid");
                    return null;
            }


            Console.Clear();
            Console.WriteLine("Pilih Power Supply");
            Console.WriteLine("1. Corsair");
            Console.WriteLine("2. AeroCool");
            Console.WriteLine("3. CoolerMaster");
            int pilihPSU = int.Parse(Console.ReadLine());

            switch (pilihPSU)
            {
                case 1:
                    komputer.psu = new Corsair();
                    break;
                case 2:
                    komputer.psu = new PSUAerocool();
                    break;
                case 3:
                    komputer.psu = new CoolerMaster();
                    break;
                default:
                    Console.WriteLine("Pilihan Power Supply tidak valid");
                    return null;
            }

            Console.Clear();
            Console.WriteLine("Pilih Jenis Storage");
            Console.WriteLine("1. HDD Seagate Barracuda 3.5");
            Console.WriteLine("2. HDD WD Caviar Blue");
            Console.WriteLine("3. SSD Corsair Force Series MP 600");
            Console.WriteLine("4. SSD ADATA SU650");
            int PilihStorage = int.Parse(Console.ReadLine());

            switch (PilihStorage)
            {
                case 1:
                    komputer.storage = new Seagate();
                    break;
                case 2:
                    komputer.storage = new WDCaviar();
                    break;
                case 3:
                    komputer.storage = new  SSDCorsair();
                    break;
                case 4:
                    komputer.storage = new Adata();
                    break;
                default:
                    Console.WriteLine("Pilihan storage tidak valid");
                    return null;
            }

            Console.Clear();
            Console.WriteLine("Pilih Kapasitas Storage");
            Console.WriteLine("1. 500 GB");
            Console.WriteLine("2. 1 TB");
            Console.WriteLine("3. 2 TB");
            Console.WriteLine("4. 4 TB");
            int pilihKapasitasStoage = int.Parse(Console.ReadLine());

            switch (pilihKapasitasStoage)
            {
                case 1:
                    komputer.storage.kapasitas = 500;
                    break;
                case 2:
                    komputer.storage.kapasitas = 1;
                    break;
                case 3:
                    komputer.storage.kapasitas = 2;
                    break;
                case 4:
                    komputer.storage.kapasitas = 4;
                    break;
                default:
                    Console.WriteLine("Pilihan kapasitas tidak valid");
                    return null;
            }

            Console.Clear();
            Console.WriteLine("Pilih Casing");
            Console.WriteLine("1. Armageddon Nimitz N5");
            Console.WriteLine("2. AeroCool Bolt");
            Console.WriteLine("3. Venom RX Arasaka");
            Console.WriteLine("4. Simbadda Battleground");
            int pilihCasing = int.Parse(Console.ReadLine());

            switch (pilihCasing)
            {
                case 1:
                    komputer.casing = new Armageddon();
                    break;
                case 2:
                    komputer.casing = new  CasingAerocool();
                    break;
                case 3:
                    komputer.casing = new Venom();
                    break;
                case 4:
                    komputer.casing = new Simbadda();
                    break;
                default:
                    Console.WriteLine("Pilihan casing tidak valid");
                    return null;
            }

            return komputer;
        }

        public void Nyalakan()
        {
            Console.WriteLine($"Komputer {merk} menyala");
        }

        public void Matikan()
        {
            Console.WriteLine($"Komputer {merk} mati");
        }

        public void MainGame(string jenisGame)
        {
            Console.WriteLine($"Komputer {merk} bermain game {jenisGame}");
        }
        public void MainGame(string jenisGame, int jumlahPemain)
        {
            Console.WriteLine($"Komputer {merk} bermain game {jenisGame}, dengan jumlah pemain sebanyak {jumlahPemain}");
        }

        public void Editing()
        {
            Console.WriteLine($"Komputer {merk} sedang melakukan editing");
        }

        public void MengerjakanTugas()
        {
            Console.WriteLine($"Komputer {merk} sedang mengerjakan tugas");
        }

        public virtual void salamPenutup()
        {
        }
    }

    class Asus : Komputer, IPC
    {
        public Asus()
        {
            base.merk = "Asus";
        }
        public override void salamPenutup()
        {
            Console.WriteLine($"Terimakasih sudah merakit PC disini, ASUS kami yang terbaik");
        }
    }

    class Acer : Komputer, IPC
    {
        public Acer()
        {
            base.merk = "Acer";
        }
        public override void salamPenutup()
        {
            Console.WriteLine($"Terimakasih sudah merakit PC disini, Acer kami yang terbaik");
        }
    }

    class Samsung : Komputer, IPC
    {
        public Samsung()
        {
            base.merk = "Samsung";
        }
        public override void salamPenutup()
        {
            Console.WriteLine($"Terimakasih sudah merakit PC disini, Samsung kami yang terbaik");
        }
    }

    class LG : Komputer, IPC
    {
        public LG()
        {
            base.merk = "Asus";
        }
        public override void salamPenutup()
        {
            Console.WriteLine($"Terimakasih sudah merakit PC disini, Samsung kami yang terbaik");
        }
    }

    abstract class Processor
    {
        public string merk, tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    class Pentium : Intel
    {
        public Pentium()
        {
            base.tipe = "Pentium";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    class CoreI9 : Intel
    {
        public CoreI9()
        {
            base.tipe = "Core i7";
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    class Ryzen3 : AMD
    {
        public Ryzen3()
        {
            base.tipe = "Ryzen 3";
        }
    }

    class Ryzen5 : AMD
    {
        public Ryzen5()
        {
            base.tipe = "Ryzen 5";
        }
    }

    class Ryzen7 : AMD
    {
        public Ryzen7()
        {
            base.tipe = "Ryzen 7";
        }
    }

    class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "Athlon";
        }
    }

    abstract class Motherboard
    {
        public string merk;
    }

    class MoboAsus : Motherboard
    {
        public MoboAsus()
        {
            base.merk = "Asus";
        }
    }
    
    class Asrock : Motherboard
    {
        public Asrock()
        {
            base.merk = "Asrock";
        }
    }

    class Gigabyte : Motherboard
    {
        public Gigabyte()
        {
            base.merk = "Gigabyte";
        }
    }

    abstract class Vga
    {
        public string merk, tipe;
    }

    class NVIDIA : Vga
    {
        public NVIDIA()
        {
            base.merk = "NVIDIA";
        }
    }

    class GTX750 : NVIDIA
    {
        public GTX750()
        {
            base.tipe = "GeForce GTX 750";
        }
    }

    class GTX1050 : NVIDIA
    {
        public GTX1050()
        {
            base.tipe = "GeForce GTX 1050";
        }
    }

    class GTX1650 : NVIDIA
    {
        public GTX1650()
        {
            base.tipe = "GeForce GTX 1650";
        }
    }

    class RTX2070 : NVIDIA
    {
        public RTX2070()
        {
            base.tipe = "GeForce RTX 2070";
        }
    }

    class RTX3060 : NVIDIA
    {
        public RTX3060()
        {
            base.tipe = "GeForce RTX 3060";
        }
    }

    class RTX4090 : NVIDIA
    {
        public RTX4090()
        {
            base.tipe = "GeForce RTX 4090";
        }
    }

    class VgaAMD : Vga
    {
        public VgaAMD()
        {
            base.merk = "AMD";
        }
    }

    class R5 : VgaAMD
    {
        public R5()
        {
            base.tipe = "Radeon R5";
        }
    }

    class RX570 : VgaAMD
    {
        public RX570()
        {
            base.tipe = "Radeon RX 570";
        }
    }

    class RX5600XT : VgaAMD
    {
        public RX5600XT()
        {
            base.tipe = "Radeon RX 5600 XT";
        }
    }

    class RX6800 : VgaAMD
    {
        public RX6800()
        {
            base.tipe = "Radeon RX 6800 XT";
        }
    }

    abstract class RAM
    {
        public string merk;
        public int memory { get; set; }
    }

    class HyperX : RAM
    {
        public HyperX()
        {
            base.merk = "HyperX";
        }
    }

    class ramCorsair : RAM
    {
        public ramCorsair()
        {
            base.merk = "Corsair";
        }
    }

    class Kingston : RAM
    {
        public Kingston()
        {
            base.merk = "Kingston";
        }
    }


    abstract class PSU
    {
        public string nama;
        public int watt;
    }

    class Corsair : PSU
    {
        public Corsair()
        {
            base.nama = "Corsair VS";
            base.watt = 400;
        }
    }

    class PSUAerocool : PSU
    {
        public PSUAerocool()
        {
            base.nama = "AeroCool Lux RGB";
            base.watt = 550;
        }
    }

    class CoolerMaster : PSU
    {
        public CoolerMaster()
        {
            base.nama = "Cooler Master V SFX Gold";
            base.watt = 650;
        }
    }

    class AsusROG : PSU
    {
        public AsusROG()
        {
            base.nama = "ASUS ROG Strix 1000G";
            base.watt = 1000;
        }
    }

    abstract class Storage
    {
        public string jenis, merk;
        public int kapasitas { get; set; }
    }

    class HDD : Storage
    {
        public HDD()
        {
            base.jenis = "HDD";
        }
    }

    class Seagate : HDD
    {
        public Seagate()
        {
            base.merk = "Seagate Barracuda 3.5";
        }
    }

    class WDCaviar : HDD
    {
        public WDCaviar()
        {
            base.merk = "WD Caviar Blue";
        }
    }

    class SSD : Storage
    {
        public SSD()
        {
            base.jenis = "SSD";
        }
    }

    class SSDCorsair : SSD
    {
        public SSDCorsair()
        {
            base.merk = "Corsair Force Series MP600";
        }
    }

    class Adata : SSD
    {
        public Adata()
        {
            base.merk = "ADATA SU650";
        }
    }


    abstract class Casing
    {
        public string merk;
    }

    class Armageddon : Casing
    {
        public Armageddon()
        {
            base.merk = "Armageddon Nimitz N5";
        }
    }

    class CasingAerocool : Casing
    {
        public CasingAerocool()
        {
            base.merk = "AeroCool Bolt";
        }
    }

    class Venom : Casing
    {
        public Venom()
        {
            base.merk = "Venom RX Arasaka";
        }
    }

    class Simbadda : Casing
    {
        public Simbadda()
        {
            base.merk = "Simbadda Battleground";
        }
    }
}