using jdb.dataClass;
using jdb.sundries;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace jdb
{
    public delegate void DelegateChangeTextVal(string TextVal);
    public partial class Login : Form
    {
        private readonly DataBase db = new DataBase();
        private MySqlDataReader sdr;
        public event DelegateChangeTextVal ChangeTextVal;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errInfo.Clear();

            if (String.IsNullOrEmpty(tbUser.Text.Trim()))
            {
                try
                {
                    errInfo.SetError(tbUser, "用户名不能为空！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }

                finally { }
            }

            if (String.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                try
                {
                    errInfo.SetError(tbPassword, "密码不能为空！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }

                finally { }

            }


            string strSql = "select * from user where username = '" + tbUser.Text.Trim() +
                           "' and password = '" + tbPassword.Text.Trim() + "'";

            try
            {
                sdr = db.GetDataReader(strSql);
                sdr.Read();
                if (sdr.HasRows)
                {
                    ChangeMainFormText("1");
                    MessageBox.Show("登陆成功", "软件提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户编码或用户密码不正确！", "软件提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw;
            }
            finally
            {
                sdr.Close();
            }
            
        }
        private void ChangeMainFormText(string TextVal)
        {  
          // 4.调用委托事件函数  
            ChangeTextVal(TextVal);  
        }


    //登录用户文本框敲回车键
    private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbUser.Focus();
            }
        }

        //登录密码文本框敲回车键

      

        private void tbPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
