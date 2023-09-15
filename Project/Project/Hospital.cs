using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Project
{
    class Hospital
    {
        public string Name, ID;

        public string qry_select;
    }
    class patient:Hospital
    {
        public string Patient_Phone, Patient_Age;
        public string Patient_Address, Patient_Gender, Patient_blood, Paitent_disase;
        public patient(string query)
        {
            this.qry_select = query;
        }
        public patient()
        {
        }
        public void Empty_text_field(string patient_id, string patient_name, string patient_address)
        {
            this.ID = patient_id;
            this.Name = patient_name;
            this.Patient_Address = patient_address;  
        }
        public void Empty_text_field(string patient_phone, string patient_age, string patient_gender, string patient_bloodgrp, string patient_Disease)
        {
            this.Patient_Phone = patient_phone;
            this.Patient_Age = patient_age;
            this.Patient_Gender = patient_gender;
            this.Patient_blood = patient_bloodgrp;
            this.Paitent_disase = patient_Disease;
        }
    }
    class diagnosis:Hospital
    {
        public string DiagnosisID, Systoms, Diagnosis, Medicine, Doctor_Fee;
        public diagnosis(string view_query)
        {
            this.qry_select = view_query;
        }
        public diagnosis()
        {
                
        }
        public void Empty_text_field(string diagnosis_ID)
        {
            this.DiagnosisID = diagnosis_ID;
        }
    public void Empty_text_field(string systoms,string Patient_Diagnosis, string medicine, string DoctorFee)
        {
            this.Systoms = systoms;
            this.Diagnosis = Patient_Diagnosis;
            this.Medicine = medicine;
            this.Doctor_Fee = DoctorFee;
        }
    }
    class doctor:Hospital
    {
        public string Doctor_CNIC, Expiry;
        public doctor(string query_Select)
        {
            this.qry_select = query_Select;
        }
  
        public doctor()
        {

        }
        public void Empty_fields(string Doctor_ID)
        {
            this.ID = Doctor_ID;
        }
        public void Empty_fields(string DoctorName, string CNIC,string Expire)
        {
            this.Name = DoctorName;
            this.Doctor_CNIC = CNIC;
            this.Expiry = Expire;
        }
    }
}
