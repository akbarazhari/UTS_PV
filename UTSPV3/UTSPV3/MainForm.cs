/*
 * Created by SharpDevelop.
 * User: bang rider
 * Date: 4/26/2020
 * Time: 2:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace UTSPV3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server=localhost; Database=pv; Uid=root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		MySqlConnection koneksi = new MySqlConnection("server=localhost; userid=root; password=; database=pv;");
		
		
		public void readdata(){
            try{
                mycommand.Connection = co;
                myadapter.SelectCommand = mycommand;
                mycommand.CommandText = "select * from siswa";
                DataSet ds = new DataSet();
                if (myadapter.Fill(ds,"daftar pesan")>0){
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "daftar pesan";
                }
                co.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

		public void InsertData(){
            try{
                co.Open();
                mycommand.Connection=co;
                mycommand.CommandText="insert into siswa values('"+nis.Text+"','"+nama.Text+"','"+kelas.Text+"','"+alamat.Text+"', '"+jurusan.Text+"', '"+usia.Text+"')";
		        myadapter.SelectCommand= mycommand;
                if (mycommand.ExecuteNonQuery()==1){
                    MessageBox.Show("Data has been added","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    readdata();
                }
                co.Close();
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

		
		public void UpdateData(){
            try{
                co.Open();
                mycommand.CommandText = "update siswa set nis='"+nis.Text+"',nama='"+nama.Text+"',kelas='"+kelas.Text+"',alamat='"+alamat.Text
                +"', jurusan='"+jurusan.Text+"',usia='"+usia.Text+"'where nis ='"+nis.Text+"'";
			                myadapter.SelectCommand = mycommand;
			                if (mycommand.ExecuteNonQuery()==1){
			                    MessageBox.Show("Data has been changed","Informasi",
			MessageBoxButtons.OK,MessageBoxIcon.Information);
			                    readdata();
			                }
			                co.Close();
			            }
			            catch(Exception ex){
			                MessageBox.Show(ex.ToString());
			            }
			        }
		
		void DeleteData(){
            try{
                co.Open();
                mycommand.CommandText="delete from siswa where nis='"+nis.Text+"'";
                myadapter.SelectCommand = mycommand;
                if (mycommand.ExecuteNonQuery()==1){
                    MessageBox.Show("Data has been deleted","Informasi",
			MessageBoxButtons.OK,MessageBoxIcon.Information);
                    readdata();
                }
                co.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }        
        }
		
		void DataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			nis.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			nama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			kelas.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			alamat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			jurusan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			usia.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
		}
		void HitungClick(object sender, EventArgs e)
		{
			int barang = 0;
			// harga barang dikali berapa banyak barang dibeli
			float jlh = 0;
			float jl = 0;
			
			// menentukan barang yang dibeli
			if (mSpp.Checked==true){
				if (jenisbrg.SelectedItem=="SMP"){
					barang=70000;
				}
				
				if (jenisbrg.SelectedItem=="SMA"){
					barang=100000;
				}
			}
			
			if (mSrgm.Checked==true){
				if (jenisbrg.SelectedItem=="SMP"){
					barang=80000;
				}
				if (jenisbrg.SelectedItem=="SMA"){
					barang=200000;
				}
			}
			
			int brp = int.Parse(jlhbrg.Text);
			float awal = barang*brp;
			
			// menentukan jenis pembeli
			if (pGuru.Checked==true){
				jlh=brp*20000;
			}
			if (pUmum.Checked==true){
				jlh=brp*50000;
			}
			
			// menentukan tindakan jika pembayaran cash atau transfer
			if (transfer.Checked==true){
				jl=(awal+jlh)-10000;
			}
			if (cash.Checked==true){
				jl=(awal+jlh)-5000;
			}
			
			jumlah.Text=jl.ToString();			
		}

		public MainForm()
		{
			InitializeComponent();
			readdata();
		}
			
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		

		public bool dbOpen()
	    {
		    try
		    {
		    	koneksi.Open();
		    }
		    catch
		    {
			    MessageBox.Show("Not Connected yet");
			    return false;
		    }
		    return true;
	    }
		
		void BtntesClick(object sender, EventArgs e)
		{
			if(dbOpen()){
			MessageBox.Show("Connected");
			koneksi.Close();
			}	
		}
		
		void InsertClick(object sender, EventArgs e)
		{
			InsertData();
		}
		
		void UpdateClick(object sender, EventArgs e)
		{
			UpdateData();
		}
		
		void DeleteClick(object sender, EventArgs e)
		{
			DeleteData();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			
		}
		void Label6Click(object sender, EventArgs e)
		{
	
		}
		
		
		void JlhbrgTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void JenisbrgSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
