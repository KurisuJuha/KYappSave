using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KYapp.Save.Util;

namespace KYapp.Save.Editor
{
    public static class EditorSave
    {
        public static void Save(string data)
        {
            string Dir = Directory.GetCurrentDirectory() + "\\Data";
            Directory.CreateDirectory(Dir);
            StreamWriter sw = File.CreateText(Dir + "\\data.dat");
            sw.Write(data);
            sw.Close();
        }
        public static string Load()
        {
            string Dir = Directory.GetCurrentDirectory() + "\\Data";
            return File.ReadAllText(Dir + "\\data.dat");
        }
    }
}