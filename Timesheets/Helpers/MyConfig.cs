using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Timesheets.Models;

namespace Timesheets.Helpers
{
    public static class MyConfig
    {
        static string fileName = @"C:\PowerCranes\user.txt";
        public static string ReadValue(string key)
        {
            StreamReader reader = null;
            if (File.Exists(fileName))
            {
                reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                while (!line.Contains(key))
                {
                    line = reader.ReadLine();
                }
                string[] keyVals = line.Split('=');
                return keyVals[1];
            }
            reader.Close();
            return "";
        }

        public static void WriteValue(string key,string value)
        {
            StreamReader reader = new StreamReader(fileName);
            List<string> lines = new List<string>();
            while (reader.Peek() > 0)
            {
                string line = reader.ReadLine();
                if (line.Contains(key))
                {
                    string[] lineParts = line.Split('=');
                    line = lineParts[0] + "=" + value;
                }
                lines.Add(line);
            }
            File.Delete("user.settings");
            StreamWriter writer = new StreamWriter(fileName);
            foreach (var line in lines)
                writer.WriteLine(line);
            reader.Close();
            writer.Close();
        }

        public static void BuildFile(Login login)
        {
            if (File.Exists("user.txt"))
                File.Delete("user.txt");
            StreamWriter writer = new StreamWriter(fileName);
            string line = "userId=" + login.userID;
            writer.WriteLine(line);
            line = "firstName=" + login.firstName;
            writer.WriteLine(line);
            line = "lastName=" + login.lastName;
            writer.WriteLine(line);
            line = "userName=" + login.userName;
            writer.WriteLine(line);
            line = "accessLevel=" + login.accessLevel;
            writer.WriteLine(line);
            line = "branch=" + login.branch;
            writer.WriteLine(line);
            writer.Flush();
            writer.Close();
        }
        public static Login ReadFile()
        {
            StreamReader reader = new StreamReader(fileName);
            Login login = new Login();
            while(reader.Peek() > 0)
            {
                string line = reader.ReadLine();
                string[] lineParts = line.Split('=');
                string key = lineParts[0];
                string value = lineParts[1];
                switch (key)
                {
                    case "userId":
                        login.userID = int.Parse(value);
                        break;
                    case "firstName":
                        login.firstName = value;
                        break;
                    case "lastName":
                        login.lastName = value;
                        break;
                    case "userName":
                        login.userName = value;
                        break;
                    case "accessLevel":
                        login.accessLevel = int.Parse(value);
                        break;
                    case "branch":
                        login.branch = int.Parse(value);
                        break;
                }
            }
            reader.Close();
            return login;
        }
    }
}
