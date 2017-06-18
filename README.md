# CSharp
 - It is an object-oriented programming language from Microsoft.
 - It is a strong typed language.

# CSharp 4.0 (.NET Framework 4.0 / 2010)
 - Named and optional arguments
 - Dynamic types

# CSharp 5.0 (.NET Framework 4.5 / 2012)
 - Async features

# CSharp 6.0 (.NET Framework 4.6 / 2015)
 - Null conditional operators.
    ```cs
    first = person?.FirstName ?? "Unspecified";
    ```
 - String Interpolation
   ```cs
   public string FullName => $"{FirstName} {LastName}";
   ```
 - Await in Catch and Finally blocks
   ```cs 
   catch (System.Net.Http.HttpRequestException e) when (e.Message.Contains("301"))
   {
       await logError("Recovered from redirect", e);
       return "Site Moved";
   }
   finally
   {
       await logMethodExit();
       client.Dispose();
   }
   ```

# CSharp 7.0 (.NET Framework 4.7 / 2017)
 -  Tuples
    ```cs
    var letters = ("a", "b");

    (string Alpha, string Beta) namedLetters = ("a", "b");
    ```