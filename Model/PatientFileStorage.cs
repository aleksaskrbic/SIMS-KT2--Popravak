/***********************************************************************
 * Module:  PatientFileStorage.cs
 * Author:  Ana_Marija
 * Purpose: Definition of the Class Model.PatientFileStorage
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Model
{
    public class PatientFileStorage
    {
        private String fileLocation = @"C:\Users\Aleksa\Desktop\pacijenti.txt";
        private List<Patient> patients;
        public PatientFileStorage()
        {
            using (StreamReader file = new StreamReader(fileLocation))
            {
                String line;
                patients = new List<Patient>();
                while ((line = file.ReadLine()) != null)
                {
                   String[] words = line.Split(',');
                   patients.Add(new Patient(words[0], words[1], words[2], words[3],
                                            words[4], words[5], words[6]));

                }
                file.Close();
            }
        }
        public List<Patient> GetAll()
        {
            return patients;
        }

        public Patient GetOne(int id)
        {
            throw new NotImplementedException();
        }

        //Dodavanje novog pacijenta
        public void Save(Patient newPatient)
        {
            int id = 0;
            using (StreamReader read = new StreamReader(fileLocation))
            {
                String line;
                while ((line = read.ReadLine()) != null)
                {
                    String[] words = line.Split(',');
                   
                    //Provera za dodavanje
                    if(newPatient.user.Id == words[0] || newPatient.user.Jmbg == words[3])

                    {
                        MessageBox.Show("Patient already exist");
                        return;
                    }
                }
                read.Close();
            }
            id++;
            String noviRed = newPatient.user.Id + "," + newPatient.user.FirstName + "," + newPatient.user.LastName + "," + newPatient.user.Jmbg +  "," + newPatient.user.PhoneNumber + "," + newPatient.user.Username + "," + newPatient.user.Password;
            StreamWriter write = new StreamWriter(fileLocation, true);
            write.WriteLine(noviRed);
            this.patients.Add(newPatient);
            write.Close();
        }

        public void Delete(Patient patient)
        {
            String deleteRed = patient.user.Id + "," + patient.user.FirstName + "," + patient.user.LastName + "," + patient.user.Jmbg + "," + patient.user.PhoneNumber + "," + patient.user.Username + "," + patient.user.Password;
            String tempFile = Path.GetTempFileName();
            using (StreamReader sr = new StreamReader(fileLocation))
            using (StreamWriter sw = new StreamWriter(tempFile))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != deleteRed)
                        sw.WriteLine(line);
                }
            }
            File.Delete(fileLocation);
            File.Move(tempFile, fileLocation);
        }
        public void Update(Patient newPatient)
        {
            StreamReader read = new StreamReader(fileLocation);
            String line_read;
            String changeRow = "";
            int red = 1;
            while ((line_read = read.ReadLine()) != null)
            {
                String[] words = line_read.Split(',');
                if (newPatient.user.Id == words[0])
                {
                    changeRow = newPatient.user.Id + "," + newPatient.user.FirstName + "," + newPatient.user.LastName + "," + newPatient.user.Jmbg + "," + newPatient.user.PhoneNumber + "," + newPatient.user.Username + "," + newPatient.user.Password;
                    break;
                }
                red++;
            }
            read.Close();
            int line_number = 1;
            int line_to_edit = red;
            String tempFile = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(fileLocation))
            {
                using (StreamWriter writer = new StreamWriter(tempFile, true))
                {
                    String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line_number == line_to_edit)
                        {
                            writer.WriteLine(changeRow);
                        }
                        if ((line_number != line_to_edit))
                        {
                            writer.WriteLine(line);
                        }
                        line_number++;
                    }
                }
            }

            File.Delete(fileLocation);
            File.Move(tempFile, fileLocation);
        }

        
    }

}

    


