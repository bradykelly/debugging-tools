using System.Diagnostics;

[System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
extern static bool DebugActiveProcess(int dwProcessId);

Console.WriteLine("Press any key to start the target process...");
Console.ReadKey();

// Start the target process

var psi = new ProcessStartInfo("msiexec.exe", "C:\\Users\\kellyb\\Downloads\\vagrant_2.3.4_windows_amd64.msi /L*V \"vagrant-install.log\"");
var targetProcess = Process.Start(psi);
targetProcess?.WaitForExit();