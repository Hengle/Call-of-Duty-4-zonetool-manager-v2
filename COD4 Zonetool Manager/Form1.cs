using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsInput.Native; 
using WindowsInput;

namespace COD4_Zonetool_Manager
{
    public partial class Form1 : Form
    {
        private const string ExpectedDllName = "zoneiw3.dll";
        private const string ExpectedProcessNames = "zonetool,iw3mp,iw3sp";
        private bool alreadyAdded = false;

        public Form1()
        {
            InitializeComponent();
            InitializeCommands();
            InitializeStockZones();

            instructionLabel.Text = "Supported processes: " + ExpectedProcessNames;
            instruction2Label.Text = "Supported dll\'s: " + ExpectedDllName;

            comboBox1.Text = "Choose the cod4 process...";
            comboBox1.Items.Clear();
            processBoxElements();
        }

        private void InitializeCommands()
        {
            // Add commands to cmdBox
            cmdBox.Items.Add("loadzone ");
            cmdBox.Items.Add("buildzone ");
            cmdBox.Items.Add("dumpzone ");
            cmdBox.Items.Add("quit");

            // Select (first) default element
            cmdBox.SelectedIndex = 0;
        }

        private void InitializeStockZones()
        {
            // Add zones to cmd2Box
            cmd2Box.Items.Add("ac130");
            cmd2Box.Items.Add("aftermath");
            cmd2Box.Items.Add("airlift");
            cmd2Box.Items.Add("airplane");
            cmd2Box.Items.Add("ambush");
            cmd2Box.Items.Add("armada");
            cmd2Box.Items.Add("blackout");
            cmd2Box.Items.Add("bog_a");
            cmd2Box.Items.Add("bog_b");
            cmd2Box.Items.Add("cargoship");
            cmd2Box.Items.Add("cod4x_patch");
            cmd2Box.Items.Add("code_post_gfx");
            cmd2Box.Items.Add("code_post_gfx_mp");
            cmd2Box.Items.Add("common");
            cmd2Box.Items.Add("common_mp");
            cmd2Box.Items.Add("coup");
            cmd2Box.Items.Add("hunted");
            cmd2Box.Items.Add("icbm");
            cmd2Box.Items.Add("jeepride");
            cmd2Box.Items.Add("killhouse");
            cmd2Box.Items.Add("launchfacility_a");
            cmd2Box.Items.Add("launchfacility_b");
            cmd2Box.Items.Add("localized_code_post_gfx_mp");
            cmd2Box.Items.Add("localized_common_mp");
            cmd2Box.Items.Add("mp_backlot");
            cmd2Box.Items.Add("mp_backlot_load");
            cmd2Box.Items.Add("mp_bloc");
            cmd2Box.Items.Add("mp_bloc_load");
            cmd2Box.Items.Add("mp_bog");
            cmd2Box.Items.Add("mp_bog_load");
            cmd2Box.Items.Add("mp_broadcast");
            cmd2Box.Items.Add("mp_broadcast_load");
            cmd2Box.Items.Add("mp_carentan");
            cmd2Box.Items.Add("mp_carentan_load");
            cmd2Box.Items.Add("mp_cargoship");
            cmd2Box.Items.Add("mp_cargoship_load");
            cmd2Box.Items.Add("mp_citystreets");
            cmd2Box.Items.Add("mp_citystreets_load");
            cmd2Box.Items.Add("mp_convoy");
            cmd2Box.Items.Add("mp_convoy_load");
            cmd2Box.Items.Add("mp_countdown");
            cmd2Box.Items.Add("mp_countdown_load");
            cmd2Box.Items.Add("mp_crash");
            cmd2Box.Items.Add("mp_crash_load");
            cmd2Box.Items.Add("mp_crash_snow");
            cmd2Box.Items.Add("mp_crash_snow_load");
            cmd2Box.Items.Add("mp_creek");
            cmd2Box.Items.Add("mp_creek_load");
            cmd2Box.Items.Add("mp_crossfire");
            cmd2Box.Items.Add("mp_crossfire_load");
            cmd2Box.Items.Add("mp_farm");
            cmd2Box.Items.Add("mp_farm_load");
            cmd2Box.Items.Add("mp_killhouse");
            cmd2Box.Items.Add("mp_killhouse_load");
            cmd2Box.Items.Add("mp_overgrown");
            cmd2Box.Items.Add("mp_overgrown_load");
            cmd2Box.Items.Add("mp_pipeline");
            cmd2Box.Items.Add("mp_pipeline_load");
            cmd2Box.Items.Add("mp_shipment");
            cmd2Box.Items.Add("mp_shipment_load");
            cmd2Box.Items.Add("mp_showdown");
            cmd2Box.Items.Add("mp_showdown_load");
            cmd2Box.Items.Add("mp_strike");
            cmd2Box.Items.Add("mp_strike_load");
            cmd2Box.Items.Add("mp_vacant");
            cmd2Box.Items.Add("mp_vacant_load");
            cmd2Box.Items.Add("scoutsniper");
            cmd2Box.Items.Add("simplecredits");
            cmd2Box.Items.Add("sniperescape");
            cmd2Box.Items.Add("ui");
            cmd2Box.Items.Add("ui_mp");
            cmd2Box.Items.Add("village_assault");
            cmd2Box.Items.Add("village_defend");

            // Select (first) default element
            cmd2Box.SelectedIndex = 0;
        }

        private static string DLLP
        {
            get;
            set;
        }

        private void processBoxElements()
        {
            if( alreadyAdded )
                return;
            Process[] PC = Process.GetProcesses().Where(p => (long)p.MainWindowHandle != 0).ToArray();
            foreach( Process p in PC )
            {
                if( p.ProcessName == "zonetool" || p.ProcessName == "iw3mp" || p.ProcessName == "iw3sp" )
                {
                    alreadyAdded = true;
                    comboBox1.Items.Add( p.ProcessName );
                }
            }
        }

        // Exit application
        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Choose DLL
        private void dllSelButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = @"C:\";
                open.Title = "Locate zoneiw3.dll File For Injection"; // Selection window title
                open.Filter = "DLL files (*.dll)|*.dll;";
                open.DefaultExt = "dll";
                open.CheckFileExists = true;
                open.CheckPathExists = true;
                open.Multiselect = false;

                if( open.ShowDialog() == DialogResult.OK )
                {
                    if( Path.GetFileName(open.FileName) == ExpectedDllName )
                    {
                        textBox1.Text = open.FileName;
                        DLLP = open.FileName;
                    }
                    else
                    {
                        MessageBox.Show($"Please select the '{ExpectedDllName}' DLL file.", "Invalid DLL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch( Exception ed )
            {
                MessageBox.Show( ed.Message );
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DLLP = textBox1.Text;
        }

        // Refresh Process
        private void refreshProcButton_Click(object sender, EventArgs e)
        {
            processBoxElements();
        }

        // Inject dll
        private void dllInjButton_Click(object sender, EventArgs e)
        {
            int Result = Inject( comboBox1.Text, DLLP );

            if( Result == 1 )
                MessageBox.Show( "File Does not Exist" );
            else if( Result == 2 )
                MessageBox.Show( "Process not valid" );
            else if( Result == 3 )
                MessageBox.Show( "Process Does not Exist" );
            else if( Result == 4 )
                MessageBox.Show( "Injection Fails" );
            else if( Result == 5 )
                MessageBox.Show( "Injection Succeeded" );
        }

        private void sendCmdButton_Click(object sender, EventArgs e)
        {
            string selectedCommand = cmdBox.SelectedItem.ToString();
            string selectedZone = cmd2Box.SelectedItem.ToString();

            Process zoneToolProcess = FindZoneToolProcess();

            if( zoneToolProcess != null && !zoneToolProcess.HasExited )
            {
                // Put foreground the window
                SetForegroundWindow( zoneToolProcess.MainWindowHandle );
                try
                {
                    if( selectedCommand != "quit" )
                    {
                        if( customCmd2Box.Text == "your command" || customCmd2Box.Text == "" )
                            SendCommandToZoneTool(zoneToolProcess, selectedCommand+selectedZone, 100);
                        else
                            SendCommandToZoneTool(zoneToolProcess, selectedCommand+customCmd2Box.Text, 100);
                    }
                    else
                        SendCommandToZoneTool(zoneToolProcess, selectedCommand, 100);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error sending command: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ZoneTool process found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendCommandToZoneTool(Process process, string command, int typingDelay)
        {
            InputSimulator sim = new InputSimulator();

            System.Threading.Thread.Sleep(100);
        
            // Send all of the characters at one time for the writing the command
            sim.Keyboard.TextEntry(command);
            
            // Wait a little bit to stabilize the intake
            System.Threading.Thread.Sleep(typingDelay);
        
            // Pressing enter for the command execute
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            
            // Show percentage
            MessageBox.Show("Command sent successfully!");
        }
/*
        private Process FindZoneToolProcess()
        {
            Process[] processes = Process.GetProcessesByName("iw3mp");
        
            foreach( Process process in processes )
            {
                // Identify the process with the name "ZoneTool".
                if( process.MainWindowTitle == "ZoneTool" )
                {
                    return process;
                }
            }
            return null; // If the ZoneTool process can't be found
        }
*/
        private Process FindZoneToolProcess()
        {
            string[] expectedProcessNames = ExpectedProcessNames.Split(',');
        
            foreach( string processName in expectedProcessNames )
            {
                Process[] processes = Process.GetProcessesByName(processName);
                if( processes.Length > 0 )
                {
                    return processes[0]; // Return the first process found
                }
            }
            return null; // None of the expected processes are found
        }


        // The function that brings the window to foreground
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

        [DllImport( "kernel32.dll", SetLastError = true )]
        static extern IntPtr OpenProcess( uint dwDesiredAccess, int bInheritHandle, uint dwProcessId );

        [DllImport( "kernel32.dll", SetLastError = true )]
        static extern int CloseHandle( IntPtr hObject );

        [DllImport( "kernel32.dll", SetLastError = true )]
        static extern IntPtr GetProcAddress( IntPtr hModule, string lpProcName );

        [DllImport( "kernel32.dll", SetLastError = true )]
        static extern IntPtr GetModuleHandle( string lpModuleName );

        [DllImport( "kernel32.dll", SetLastError = true )]
        static extern IntPtr VirtualAllocEx( IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect );

        [DllImport( "kernel32.dll", SetLastError = true )]
        static extern int WriteProcessMemory( IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten );

        [DllImport( "kernel32.dll", SetLastError = true )]
        static extern IntPtr CreateRemoteThread( IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId );

        public static int Inject( string PN, string DLLP )
        {
            // 1 = file does not exist
            // 2 = The selected process is not the call of duty 4
            // 3 = process not active
            // 4 = injection failed
            // 5 = injection succeeded

            if( !File.Exists( DLLP ) )
                return 1;

            if( !ExpectedProcessesRunning() )
                return 2;

            uint _procId = 0;
            Process[] _procs = Process.GetProcesses();
            for( int i = 0; i < _procs.Length; i++ )
            {
                if( _procs[i].ProcessName == PN )
                {
                    _procId = (uint)_procs[i].Id;
                    break;
                }
            }

            if( _procId == 0 )
                return 3;

            if( !SI( _procId, DLLP ) )
                return 4;

            return 5;
        }

        public static bool SI( uint P, string DLLP )
        {
            IntPtr hndProc = OpenProcess( ( 0x2 | 0x8 | 0x10 | 0x20 | 0x400 ), 1, P );

            if( hndProc == INTPTR_ZERO )
                return false;

            IntPtr lpLLAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
 
            if( lpLLAddress == INTPTR_ZERO )
                return false;

            IntPtr lpAddress = VirtualAllocEx( hndProc, (IntPtr)null, (IntPtr)DLLP.Length, ( 0x1000 | 0x2000 ), 0x40 );

            if( lpAddress == INTPTR_ZERO )
                return false;

            byte[] bytes = Encoding.ASCII.GetBytes( DLLP );

            if( WriteProcessMemory( hndProc, lpAddress, bytes, (uint)bytes.Length, 0 ) == 0 )
                return false;

            if (CreateRemoteThread(hndProc, (IntPtr)null, INTPTR_ZERO, lpLLAddress, lpAddress, 0, (IntPtr)null) == INTPTR_ZERO)
                return false;

            CloseHandle( hndProc );

            return true;
        }

        private static bool ExpectedProcessesRunning()
        {
            string[] processNames = ExpectedProcessNames.Split(',');
        
            foreach( string processName in processNames )
            {
                // Verify that the process is running
                Process[] processes = Process.GetProcessesByName(processName);
                if( processes.Length > 0 )
                    return true; // At least one expected process is running
            }
        
            return false; // None of the expected processes are running
        }
    }
}
