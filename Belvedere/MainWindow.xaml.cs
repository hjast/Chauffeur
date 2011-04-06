using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/* TODO Only text attributes at first */
//TODO Serialize Folder, BelvedereRule, Condition, Action
namespace Belvedere
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Folder currentFolder;
        public MainWindow()
        {
            
            InitializeComponent();
            dataGrid1.ItemsSource = Folder.GetSampleCustomerList();
            currentFolder = Folder.GetSampleCustomerList()[0];
            dataGrid1.CurrentCellChanged += new EventHandler<EventArgs>(dataGrid1_CurrentCellChanged);
            dataGrid1.UpdateLayout();      
        }

        void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            currentFolder = (Folder)dataGrid1.CurrentCell.Item;
            dataGrid2.ItemsSource = currentFolder.Rules;
            Console.WriteLine("Got you new folder "+ currentFolder);
          //  throw new NotImplementedException();
        }

        void changeAction
    }


    
    class Testing
    {
    private static List<Conditionals>;
    private static List<Delegate> conditionals;

    public void testing()
    {
        preds= new List<Delegate>();

        Predicate<Folder> contains = new Predicate<Folder>( delegate(Folder val) { return (val.Name == "Hey"); });
        preds.Add(contains);
        
    }
    }
    public static TextConditionals;
    public static NumberConditionals;

    public class PanelFactory
    {
        public static Panel getMovePanel()
        {
            StackPanel p = new StackPanel();
            p.Children.Add(new TextBox());
            p.Children.Add(new Button());
            p.Children.Add(new Button());
            return p;
        }


    }

    public interface BelvedereConditionalPanel();

  
        public performAction(File f)
        {

        }
    }

    private static List<Attributes> attributes;

    public class Attribute
    {
    }
    public class TimeAttribute :Attribute
    {
    }
    public class NumericalAttribute : Attribute
    {
        int getAttribute(File f)
        {
        }
    }

    public class TextAttribute : Attribute
    {
        String getAttribute(File f)
        {
        }
    }


    
    enum Attributes
    {

    }
   

    public class BelvedereAction
    {
    }
  


   
}
