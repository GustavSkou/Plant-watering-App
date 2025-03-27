using System;
using System.IO;

namespace Data;

public class UserCredentials
{
    private string name, password;
    static private UserCredentials user = new UserCredentials();

    static public string Name
    {
        get { return user.name; }
    }

    static public string Password
    {
        get { return user.password; }
    }

    private UserCredentials ()
    {
        ReadCredentials ();
    }

    private void ReadCredentials ()
    {
        var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        var projectRoot = Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName;
        var credentialsFilePath = Path.Combine(projectRoot, "Data", "Credentials.txt");
        using ( StreamReader streamReader = new StreamReader ( credentialsFilePath ) )
        {
            string line;
            while ( ( line = streamReader.ReadLine () ) != null )
            {
                string[] values = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                name = values[0];
                password = values[1];
            }
        }
    }
}
