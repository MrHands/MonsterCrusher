using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace MonsterCrusher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Save _saveLoaded = null;

        public MainWindow()
        {
            InitializeComponent();

            Console.WriteLine("gameDirectory: " + Properties.Settings.Default.GameDirectory);

            DataContext = new MainViewModel();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Monster Girl Club Bifrost Save Files (*.dat)|*.dat";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {
                Properties.Settings.Default.GameDirectory = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                Properties.Settings.Default.Save();

                Stream fileStream = openFileDialog.OpenFile();
                _saveLoaded = new Save();
                _saveLoaded.Load(fileStream);

                DataContext = new MainViewModel(_saveLoaded);
            }
        }

        private byte[] GetBytes(SaveMonster data)
        {
            int length = Marshal.SizeOf(data);
            IntPtr ptr = Marshal.AllocHGlobal(length);
            byte[] myBuffer = new byte[length];

            Marshal.StructureToPtr(data, ptr, true);
            Marshal.Copy(ptr, myBuffer, 0, length);
            Marshal.FreeHGlobal(ptr);

            return myBuffer;
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            var selected = (DataContext as MainViewModel).MonsterSelected;
            if (selected == null)
            {
                return;
            }

            string path = System.IO.Path.Combine(Properties.Settings.Default.GameDirectory, "test.dat");
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                var bytes = GetBytes(selected.Save);
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
