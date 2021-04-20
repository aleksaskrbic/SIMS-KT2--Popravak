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
    /// Interaction logic for NewPatient.xaml
    /// </summary>
    public partial class NewPatient : Window
    {
        private PatientFileStorage storage = new PatientFileStorage();
        String id, first_name, last_name, jmbg, phone_number, username, password;
        public NewPatient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            id = Patient_Id.Text;
            first_name = Patient_First_Name.Text;
            last_name = Patient_Last_Name.Text;
            jmbg = Patient_JMBG.Text;
            phone_number = Patient_Phone_Number.Text;
            username = Patient_Username.Text;
            password = Patient_Password.Text;
            Patient new_patient = new Patient(id, first_name, last_name, jmbg,
                                     phone_number, username, password);
            MessageBox.Show("Succesfully added patient!");
            storage.Save(new_patient);
            Close();


        }
    }
}
