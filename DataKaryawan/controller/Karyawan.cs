﻿using DataKaryawan.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataKaryawan.controller
{
    internal class Karyawan
    {
        // vhanges
        //memanggil koneksi dan membuat object baru
        Koneksi koneksi= new Koneksi();

        //method insert
        public bool Insert(Karyawan_m karyawan)

        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExcuteQuery("INSERT INTO karyawan (nik, nama, jabatan, alamat, email, nohp) VALUES('" + karyawan.Nik + "','" + karyawan.Nama + "','" + karyawan.Jabatan + "', '" + karyawan.Alamat + "', '" + karyawan.Email + "', '" + karyawan.Nohp + "' )");
                status = true;
                MessageBox.Show("Data berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               koneksi.CloseConnection();   
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;  
        }

        public bool Update(Karyawan_m karyawan, string id)

        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExcuteQuery("UPDATE karyawan SET nik='" + karyawan.Nik + "'," + "nama='"+karyawan.Nama+ "', "+"jabatan='" + karyawan.Jabatan + "', " + "alamat='" + karyawan.Alamat + "', " + "email='" +karyawan.Email+ "', " + " nohp='" + karyawan.Nohp + "' WHERE id='" +id + "'" );
                status = true;
                MessageBox.Show("Data berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string id)

        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExcuteQuery("DELETE  FROM karyawan WHERE id='" +id+ "'");
                status = true;
                MessageBox.Show("Data berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
