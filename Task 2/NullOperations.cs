using System;

namespace Tak_2
{
    // Class for Task 2: Null operations
    internal class NullOperations
    {
        public void PerformNullChecks()
        {
            // Step 2: Declare a string variable and assign null
            string username = null;

            // Step 3: Ternary operator check
            string ternaryCheck = (username == null) ? "Username is not available" : username;
            Console.WriteLine(ternaryCheck);

            // Step 4: Null-Coalescing operator check
            string nullCoalescing = username ?? "Username is not available";
            Console.WriteLine(nullCoalescing);

            // Step 5: Null-Coalescing Assignment operator
            username ??= "DefaultUser";
            Console.WriteLine("Updated username: " + username);
        }
    }
}
