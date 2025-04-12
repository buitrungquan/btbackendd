using System;
// Bai1
Console.WriteLine("=== Bài 1: Nhap ten va tuoi ===");

        Console.Write("Nhap ten: ");
        string ten = Console.ReadLine() ?? "";

        Console.Write("Nhap tuoi: ");
        int tuoi = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"Xin chao {ten}, bạn {tuoi} tuoi!");


// Bai2
Console.WriteLine("=== Bài 2: tính dien tích HCN ===");
Console.Write("Nhap chieu dai: ");
        double chieudai = double.TryParse(Console.ReadLine(), out double dai) ? dai : 0;

        Console.Write("Nhap chieu rong: ");
        double chieuRong = double.TryParse(Console.ReadLine(), out double rong) ? rong : 0;

        double dienTich = chieudai * chieuRong;

        Console.WriteLine($"Dien tich hinh chu nhat la: {dienTich}");
// Bai3
Console.WriteLine("=== Bài 3:  chuyen đoi nhiet đo tu đo C sang đo F ===");
Console.Write("Nhao do C:");
        double C = double.Parse(Console.ReadLine() ?? "");
        double F = (C * 9 / 5) + 32;
        Console.WriteLine($"{C} do C bang {F} do F");
// Bai4
Console.WriteLine("=== Bài 4: kiem tra xem so đo co phai là so chan , le , 0 ===");
Console.Write("Nhap so:");
        try
        {
            int so = int.Parse(Console.ReadLine() ?? "");
            if (so % 2 == 0)
            {
                Console.WriteLine("La so chan");
            }
            else
            {
                Console.WriteLine("La so le");
            }
        }
        catch
        {
            Console.WriteLine("Nhap dung so nguyen di");
        }
// Bai5()
Console.WriteLine("=== Bài 5: tong và tích cua hai so ===");
        double a, b, tong, tich;
        Console.Write("Nhap so a:");
        a = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Nhap so b:");
        b = double.Parse(Console.ReadLine() ?? "");
        tong = a + b;
        tich = a * b;
        Console.WriteLine($"Tong = {tong} va tich = {tich} ");
// Bai6
Console.WriteLine("=== Bài 6: kiem tra xem mot so la so duong hay am hay la 0 ===");
        while (true)
        {
            Console.Write("Nhap mot so: ");
            try
            {
                double so = double.Parse(Console.ReadLine() ?? "");

                if (so > 0)
                {
                    Console.WriteLine($"{so} la so duong.");
                }
                else if (so < 0)
                {
                    Console.WriteLine($"{so} la so am.");
                }
                else
                {
                    Console.WriteLine("Ban da nhap so 0.");
                }

                break;
            }
            catch
            {
                Console.WriteLine("Loi: Vui long nhap dung mot so!");
            }
        }
// Bai7

Console.WriteLine("=== Bai 7: Kiem tra nam nhuan ===");

        while (true)
        {
            Console.Write("Nhap mot nam: ");
            try
            {
                int nam = int.Parse(Console.ReadLine() ?? "");

                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                {
                    Console.WriteLine($"{nam} la nam nhuan.");
                }
                else
                {
                    Console.WriteLine($"{nam} khong phai la nam nhuan.");
                }

                break;
            }
            catch
            {
                Console.WriteLine("Loi: Vui long nhap mot so nguyen hop le!");
            }
        }
// Bai8
Console.WriteLine("=== Bai 8:  in ra bang cuu chương tu 1 đen 10 ===");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Bang nhan {i}");
            for (int j = 1; j <= 10; j++)
            {
                int ketqua = i * j;
                Console.WriteLine($"{i} x {j} = {ketqua}");
            }
        }
// Bai9
Console.WriteLine("=== Bai 9: tính giai thua của mot so nguyen dương n ===");
        while (true)
        {
            Console.Write("Nhap so nguyen duong: ");
            try
            {
                int n = int.Parse(Console.ReadLine() ?? "");

                if (n < 0)
                {
                    Console.WriteLine("Loi: Khong duoc nhap so am!");
                    continue;
                }

                long ketqua = 1;
                for (int i = 1; i <= n; i++)
                {
                    ketqua *= i;
                }

                Console.WriteLine($"Giai thua cua {n} la: {ketqua}");
                break;
            }
            catch
            {
                Console.WriteLine("Loi: Vui long nhap dung mot so nguyen!");
            }
        }
// Bai10
Console.WriteLine("=== Bai 10: kiem tra xem mot so có phải là so nguyen to hay khong ===");
        while (true)
        {
            Console.Write("nhap mot so nguyen: ");
            try
            {
                int n = int.Parse(Console.ReadLine() ?? "");

                if (n <= 1)
                {
                    Console.WriteLine($"{n} khong phai la so nguyen to.");
                }
                else
                {
                    bool languyento = true;

                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            languyento = false;
                            break;
                        }
                    }

                    if (languyento)
                    {
                        Console.WriteLine($"{n} la so nguyen to.");
                    }
                    else
                    {
                        Console.WriteLine($"{n} khong phai la so nguyen to.");
                    }
                }

                break;
            }
            catch
            {
                Console.WriteLine("loi: vui long nhap mot so nguyen hop le!");
            }
        }