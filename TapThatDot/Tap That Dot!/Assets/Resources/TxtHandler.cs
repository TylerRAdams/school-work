using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class TxtHandler
{
    public void writeLevel(int lvl)
    {
        string path = "Assets/Resources/CurrentData.txt";

        //Write some text to the CurrentData.txt file
        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine(lvl);
        Debug.Log(lvl);

        writer.AutoFlush = true;
        writer.Close();    
    }

    public int getLevel()
    {
        string path = "Assets/Resources/CurrentData.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);

        string level = reader.ReadToEnd();
 
        reader.Close();

        int lvl = int.Parse(level);
     
        return lvl;
    }

    public int getIsMuted()
    {
        string path = "Assets/Resources/isMute.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);

        string level = reader.ReadToEnd();

        reader.Close();

        int isMuted = int.Parse(level);

        return isMuted;
    }

    public void writeIsMuted(int isMuted)
    {
        string path = "Assets/Resources/isMute.txt";

        //Write some text to the CurrentData.txt file
        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine(isMuted);
        Debug.Log(isMuted);

        writer.AutoFlush = true;
        writer.Close();
    }

}