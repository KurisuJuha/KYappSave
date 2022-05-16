using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KYapp.Save.Util;

namespace KYapp.Save.Runtime
{
    public static class RuntimeSave
    {
        public static void Save(string data)
        {
            Debug.Log(Application.persistentDataPath);
            StreamWriter sw = File.CreateText(Application.persistentDataPath + "\\data.dat");
            sw.Write(data);
            sw.Close();
        }
        public static string Load()
        {
            return File.ReadAllText(Application.persistentDataPath + "\\data.dat");
        }
    }
}