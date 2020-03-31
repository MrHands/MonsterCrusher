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

            OpenFileDialog dialog = new OpenFileDialog() {
                Filter = "Monster Girl Club Bifrost Save Files (*.dat)|*.dat",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == true)
            {
                Properties.Settings.Default.GameDirectory = System.IO.Path.GetDirectoryName(dialog.FileName);
                Properties.Settings.Default.Save();

                Stream fileStream = dialog.OpenFile();
                _saveLoaded = new Save();
                _saveLoaded.LoadFromStream(fileStream);

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

            SaveFileDialog dialog = new SaveFileDialog() {
                Filter = "Monster Girl Club Bifrost Save Files (*.dat)|*.dat",
                InitialDirectory = Properties.Settings.Default.GameDirectory
            };
            if (dialog.ShowDialog() != true)
            {
                return;
            }

            using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
            {
                var bytes = GetBytes(selected.Save);
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Monster Girl Club Bifrost Save Files (*.dat)|*.dat",
                InitialDirectory = Properties.Settings.Default.GameDirectory
            };
            if (dialog.ShowDialog() != true)
            {
                return;
            }

            using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
            {
                _saveLoaded.SaveToStream(fs);
            }
        }
    }
}
