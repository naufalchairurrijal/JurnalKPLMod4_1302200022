// See https://aka.ms/new-console-template for more information
using KPL_MOD4_1302200022_RFL;

Penjumlahan Penjumlahan = new Penjumlahan();

//nim = 1302200022 berakhiran 2 sehingga menggunakan float
Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(1.3f, 2.2f, 2,2f));

SimpleDataBase<float> objData = new SimpleDataBase<float>();

objData.AddNewData(12.3f);
objData.AddNewData(15.2f);
objData.AddNewData(20.1f);

objData.PrintAllData();
