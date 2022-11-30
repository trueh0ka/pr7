using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace provodnik
{
    public static class Otkritie
    {
        public static List<Part> parts = new List<Part>();
        public static List<Part> parts2 = new List<Part>();
        public static void Diski()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.Write($"  Диск: {drive.Name} ");
                if (drive.IsReady)
                {
                    Console.Write($"Свободное пространство: {drive.TotalFreeSpace}");
                    Znach.max = Znach.max + 1;
                    parts.Add(new Part() {PartName = drive.Name, PartId = Znach.max});
                }
                Console.WriteLine();
;            }
        }
        public static void Papki()
        {
            Znach.max = 0;
                foreach (Part aPart in parts)
                {
                    if (aPart.PartId==Znach.position)
                    {
                        Znach.a = (aPart.PartName);
                    }
                };
            Papki2();
        }
        private static void Papki2()
        {
            Papki3();
            if (Directory.Exists(Znach.a))
            {
                Console.WriteLine("--------------------Проводник--------------------");
                string[] dirs = Directory.GetDirectories(Znach.a);
                foreach (string s in dirs)
                {
                    parts2.Add(new Part() { PartName = s, PartId = Znach.max });
                    Console.WriteLine(s);
                    Znach.max = Znach.max + 1;
                }
                string[] files = Directory.GetFiles(Znach.a);
                foreach (string s in files)
                {
                    parts2.Add(new Part() { PartName = s, PartId = Znach.max });
                    Znach.max = Znach.max + 1;
                    Console.WriteLine(s);
                }
            }
        }
        private static void Papki3()
        {
            foreach (Part iPart in parts2)
            {
                if (iPart.PartId == Znach.position-1)
                {
                    Znach.a = (iPart.PartName);
                }
            }
            Znach.a = Znach.kakoydisk + Znach.a;
        }
        public static void Ochistka()
        {
            parts.Clear();
            parts2.Clear();
        }
    }
}
