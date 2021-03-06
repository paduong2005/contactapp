﻿using Contacts;
using ContactsApp;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Contact> danhba = new List<Contact>();

        // doc du lieu tu file
        if (File.Exists("contacts.txt"))
            XuLyFile.LayDuLieuTuFile(danhba);

        char r;
        do
        {
            Console.WriteLine("\nMoi nhap thong tin lien lac:");
            Console.Write("Moi nhap ho:");
            string ho = Console.ReadLine();
            Console.Write("Moi nhap ten:");
            string ten = Console.ReadLine();
            Console.Write("Moi nhap dia chi:");
            string diachi = Console.ReadLine();
            Console.Write("Moi nhap so dien thoai:");
            string sdt = Console.ReadLine();

            Contact co = new Contact(ho, ten, diachi, sdt);
            danhba.Add(co);

            Console.Write("Ban co muon tiep tuc nhap hay khong (y/n) ? ");
            r = Console.ReadKey().KeyChar;
        } while (r == 'y');

        Console.WriteLine("\n\nDanh ba da nhap gom:");
        foreach (Contact c in danhba)
        {
            Console.WriteLine("{0} - {1} - {2} - {3}",
                             c.Ho,
                             c.Ten,
                             c.DiaChi,
                             c.SDT);
        }

        XuLyFile.LuuDuLieuRaFile(danhba);
        Console.ReadLine();
    }
}