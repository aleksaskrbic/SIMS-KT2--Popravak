using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for ViewPatients.xaml
    /// </summary>
    public partial class ViewPatients : Window
    {
        private PatientFileStorage storage  = new PatientFileStorage();
        private List<Patient> patients = new List<Patient>();
        /*private void AddPatient(object sender, RoutedEventArgs e)
        {
            Patients p = new Patients();
            p.Show();
        }*/
        public ViewPatients()
        {
            InitializeComponent();
            PatientFileStorage storage = new PatientFileStorage();
            List<Patient> patients = storage.GetAll();

            lvDataBinding.ItemsSource = patients;
        }

        //Brisanje Pacijenta
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Patient deletePatient = (Patient)lvDataBinding.SelectedItems[0];
            patients.Remove(deletePatient);
            lvDataBinding.Items.Refresh();
            storage.Delete(deletePatient);
            MessageBox.Show("Patient Succesfuly deleted!");
        }



        //Update pacijenta
        private void UpdatedPatient(object sender, RoutedEventArgs e)
        {
            //UpdatedPatient up = new UpdatedPatient();
            //up.Show();
            Patient selectedPatient = (Patient)lvDataBinding.SelectedItems[0];
            UpdatedPatient up1 = new UpdatedPatient(selectedPatient);
            up1.Show();
        }
        /*private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Patient selectedPatient = (Patient)lvDataBinding.SelectedItems[0];
            ViewPatients vp = new ViewPatients(selectedPatient);
            vp.Show();
        }*/



    }
}

