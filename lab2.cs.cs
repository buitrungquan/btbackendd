using System;
using System.Linq;

class Lab2
{
    // Bài 1: Tính tổng các số chẵn trong mảng
    static int TongSoChan(int[] arr)
    {
        int tong = 0;
        foreach (int x in arr)
        {
            if (x % 2 == 0)
                tong += x;
        }
        return tong;
    }

    // Bài 2: Kiểm tra số nguyên tố
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void HienThiSoNguyenTo(int[] arr)
    {
        Console.WriteLine("Cac so nguyen to trong mang:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (LaSoNguyenTo(arr[i]))
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
    }

    // Bài 3: Đếm số âm và số dương
    static void DemSoAmDuong(int[] arr, out int demAm, out int demDuong)
    {
        demAm = demDuong = 0;
        foreach (int num in arr)
        {
            if (num < 0) demAm++;
            else if (num > 0) demDuong++;
        }
    }

    // Bài 4: Tìm số lớn thứ hai
    static int TimSoLonThuHai(int[] arr)
    {
        if (arr.Length < 2)
            throw new ArgumentException("Mang phai co it nhat 2 phan tu.");

        int max1 = int.MinValue, max2 = int.MinValue;
        foreach (int num in arr)
        {
            if (num > max1)
            {
                max2 = max1;
                max1 = num;
            }
            else if (num > max2 && num < max1)
            {
                max2 = num;
            }
        }
        return max2;
    }

    // Bài 5: Hoán vị hai số nguyên
    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Bài 6: Sắp xếp mảng số thực tăng dần
    static void SapXepTangDan(double[] arr)
    {
        Array.Sort(arr);
    }

    static void Main()
    {
        // Nhập mảng cho bài 1, 2, 3, 4
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Bài 1
        Console.WriteLine("\nTong cac so chan trong mang: " + TongSoChan(arr));

        // Bài 2
        Console.WriteLine();
        HienThiSoNguyenTo(arr);

        // Bài 3
        DemSoAmDuong(arr, out int soAm, out int soDuong);
        Console.WriteLine($"\nSo luong so am: {soAm}");
        Console.WriteLine($"So luong so duong: {soDuong}");

        // Bài 4
        try
        {
            int soLonThuHai = TimSoLonThuHai(arr);
            Console.WriteLine($"\nSo lon thu hai trong mang: {soLonThuHai}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        // Bài 5
        Console.Write("\nNhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau hoan vi: a = {a}, b = {b}");

        // Bài 6
        Console.Write("\nNhap so phan tu mang so thuc: ");
        int m = int.Parse(Console.ReadLine());
        double[] arrThuc = new double[m];
        for (int i = 0; i < m; i++)
        {
            Console.Write($"arrThuc[{i}] = ");
            arrThuc[i] = double.Parse(Console.ReadLine());
        }
        SapXepTangDan(arrThuc);
        Console.WriteLine("Mang sau khi sap xep tang dan:");
        foreach (double x in arrThuc)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine("\n\nChuong trinh ket thuc.");
    }
}
