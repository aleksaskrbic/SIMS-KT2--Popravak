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
    /// Interaction logic for UpdatedPatient.xaml
    /// </summary>
    public partial class UpdatedPatient : Window
    {
        private PatientFileStorage storage = new PatientFileStorage();
        Patient patient = new Patient();
        private String id, first_name, last_name, phone_number, jmbg, user_name, password;

       private void Button_Click(object sender, RoutedEventArgs e)
        {
            id = idChanged.Text;
            first_name = first_name_changed.Text;
            last_name = last_name_changed.Text;
            jmbg = jmbg_changed.Text;
            phone_number = phone_number_changed.Text;
            user_name = user_name_changed.Text;
            password = password_changed.Text;

            List<Patient> patients = storage.GetAll();
            Patient pat = new Patient();
            
            foreach(Patient p in patients)
            {
                if(patient.user.Id == p.user.Id)
                {
                    pat = p;
                }
            }

            pat.user.Id = id;
            pat.user.FirstName = first_name;
            pat.user.LastName = last_name;
            pat.user.Jmbg = jmbg;
            pat.user.PhoneNumber = phone_number;
            pat.user.Username = user_name;
            pat.user.Password = password;
            storage.Update(pat);
            MessageBox.Show("Success changed on patient!");
            Close();

            //ViewPatients vp = new ViewPatients();
          //  vp.Show();
        }


        public UpdatedPatient(Patient p)
        {

            InitializeComponent();
            idChanged.Text = p.user.Id;
            first_name_changed.Text = p.user.FirstName;
            last_name_changed.Text = p.user.LastName;
            jmbg_changed.Text = p.user.Jmbg;
            phone_number_changed.Text = p.user.PhoneNumber;
            user_name_changed.Text = p.user.Username;
            password_changed.Text = p.user.Password;
            patient = p;
        }

      
    }
}
