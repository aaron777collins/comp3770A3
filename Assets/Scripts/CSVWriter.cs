using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class CSVWriter
{
    StreamWriter writer;

    public CSVWriter(string relLocation, string filename)
    {
        Directory.CreateDirectory(Path.Combine(Application.persistentDataPath, relLocation));
        Debug.Log("Editing file at: " + Path.Combine(Application.persistentDataPath, relLocation, filename));
        writer = new StreamWriter(Path.Combine(Application.persistentDataPath, relLocation, filename));
    }

    public void writeLn(string val)
    {
        writer.WriteLine(val);
    }

    public void close()
    {
        writer.Close();
    }
}