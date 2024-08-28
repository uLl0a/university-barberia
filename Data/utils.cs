using System;
using System.Collections.Generic;

public class utils
{
    public static string CreateMD5(string input)
    {
        input += "Facilitador fue un gusto tenerlo como mi facilitadora en ingenieria de software II";
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            return Convert.ToHexString(hashBytes); // .NET 5 +
        }
    }
    
    public static Dictionary<string,object> TestIntentToLogIn(string username, string password){
        password = utils.CreateMD5(password);
        string sql = "SELECT empleado, usuario, pasw FROM Credenciales WHERE usuario = @username AND pasw = @password";
        var parameters = new Dictionary<string, object>();

        parameters.Add("@username",username);
        parameters.Add("@password",password);

        var dt = dbaccess.IsValidUser(sql,parameters);

        if(dt.Count > 0){
            return dt[0];   
        }

        return null;
    }
}