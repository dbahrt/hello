// coding patterns/hello.cs
// (version of hello.pat with most comments stripped out)
// 27 Mar 2019

using System;

namespace mypgms {

//==========
public class Startup {
    private const int SUCCESS=0;
    private const int FAIL=1;

    //----------
    // main() serves as the program entry point.
    // gotta have one Main() function per program.
    // it is responsible for:
    // 1) handling the inputs to the program (command line arguments),
    // 2) overseeing the program functionality, and
    // 3) returning the output result of the program.
    //----------
    public static int Main( string [] args ) {
        Useful.dumpStringArray( args, "command line arguments:" );

        int result=driver();

        Console.WriteLine("\ndisplay result by typing ");
        Console.WriteLine("    \"echo %ERRORLEVEL%\" in Windows, or ");
        Console.WriteLine("    \"echo $?\" in Linux \n");
        return result;
    } // end Main() function

    //----------
    // this driver() function effects the program functionality.
    // returns SUCCESS if the work gets done; FAIL if it does not.
    //----------
    private static int driver( ) {
        Console.WriteLine("Hello, World.\n");

        Console.Write("Press Enter to continue...");
        Console.ReadLine();

        return SUCCESS;
    } // end function driver()

} // end class Startup
    
} // end namespace namespacename

