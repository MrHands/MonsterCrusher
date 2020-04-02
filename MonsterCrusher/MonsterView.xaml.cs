using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

namespace MonsterCrusher
{
    public partial class MonsterView : UserControl
    {
        public MonsterView()
        {
            InitializeComponent();
        }

        private void GrdMonsterProps_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                var cellVM = e.Row.Item as MonsterPropertyViewModel;

                var dataVM = DataContext as MonsterViewModel;
                var save = dataVM.Save.Value;

                var newValue = (e.EditingElement as TextBox).Text;

                var field = save.GetType().GetField(cellVM.Name);
                if (field.FieldType == typeof(String))
                {
                    field.SetValueDirect(__makeref(save), newValue);
                }
                else if (field.FieldType == typeof(UInt32))
                {
                    field.SetValueDirect(__makeref(save), UInt32.Parse(newValue));
                }
                else
                {
                    Console.WriteLine("Unsupported type \"{0}\"", field.FieldType.ToString());
                }

                dataVM.Save.Value = save;
            }
        }
    }
}
