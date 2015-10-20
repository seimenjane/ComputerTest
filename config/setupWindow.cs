using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel;


namespace config
{
    public partial class setupWindow : Form
    {
        private string myDriver;

        public setupWindow()
        {
            InitializeComponent();
            if (findIP() != "")
            {
                ipInput.Text = findIP();
            }
        }

        private void setDisk()
        {
            DriveInfo diskInfo;
            string diskName = this.diskSelector.Text;
            string detail = "";
            StringBuilder sb = new StringBuilder();
            if (diskName == "")
                return;
            else
            {
                try { diskInfo = new DriveInfo(diskName);   }
                catch(ArgumentException)
                {
                    MessageBox.Show("盘符错误！");
                    return;
                }
                            
                try
                {
                    sb.Append("磁盘类型：");
                    if(diskInfo.DriveType.ToString() == "Fixed")
                        sb.Append("硬盘");
                    else if(diskInfo.DriveType.ToString() == "Removable")
                        sb.Append("移动磁盘");
                    else
                        sb.Append(diskInfo.DriveType.ToString());
                    sb.AppendLine();
                    sb.Append("文件格式：");
                    sb.Append(diskInfo.DriveFormat);
                    sb.AppendLine();
                    sb.Append("剩余容量：");
                    long freeSpace = diskInfo.TotalFreeSpace / 1024 / 1024;  //可能会除法溢出
                    sb.Append(freeSpace.ToString());
                    sb.Append("MB");
                    detail = sb.ToString();
                    this.myDriver = diskInfo.Name;
                } 
                catch(DriveNotFoundException)
                {
                    detail = "驱动器不存在,\r\n请重新选择一个有效的磁盘驱动器。";
                    this.myDriver = "";
                    return;
                }
                catch (IOException)
                {
                    detail = "无效的驱动器,\r\n请重新选择一个有效的磁盘驱动器。";
                    this.myDriver = "";
                    return;
                }
                finally
                {
                    this.diskDetail.Text = detail;
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            saveConfig("dataDisk",this.myDriver);
            saveConfig("teacherIP", this.ipInput.Text);
            StringBuilder sb = new StringBuilder();
            sb.Append("保存成功：\t\n");
            sb.Append("数据磁盘：");
            sb.Append(this.myDriver + "\t\n");
            sb.Append("教师机地址：");
            sb.Append(this.ipInput.Text);
            MessageBox.Show(sb.ToString());
        }//保存按钮

        private void diskTest_Click(object sender, EventArgs e)
        {
            if (this.myDriver == "" || this.myDriver == null)
            {
                MessageBox.Show("先选择一个有效的磁盘驱动器");
                return;
            }
            else
            {
                DirectoryInfo df = new DirectoryInfo(this.myDriver + "cn.sh.edu.fdkjy.seimen");
               
                try
                {
                    if (df.Exists)
                        df.Delete();
                    df.Create();
                    df.Delete();
                    MessageBox.Show("测试成功");
                }
                 catch (SecurityException)
                {
                    MessageBox.Show("权限测试出错");
                    return;
                }
                catch (IOException)
                {
                    MessageBox.Show("读写测试出错");
                    return;
                }
            }
        }//磁盘测试按钮

        private void diskSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDisk();
        }

        static void saveConfig(string setKey, string setValue)
        {
            try
            {
                string confPath = System.Windows.Forms.Application.StartupPath + @"\App.config";
                
                System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(confPath);
                bool exist = false;
                foreach (string key in config.AppSettings.Settings.AllKeys)
                {
                    if (key == setKey)
                    {
                        exist = true;
                    }
                }
                if (exist)
                {
                    config.AppSettings.Settings.Remove(setKey);
                }
                config.AppSettings.Settings.Add(setKey, setValue);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException err)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            catch (Exception)
            { MessageBox.Show("保存配置出错"); return; }
        }

        private void ipTest_Click(object sender, EventArgs e)//地址测试按钮
        {
            using (ChannelFactory<service.ItestServiceContract> channelFactory = new ChannelFactory<service.ItestServiceContract>(new WSHttpBinding(), "http://10.29.114.251:8000/testServices"))
            {
                service.ItestServiceContract proxy = channelFactory.CreateChannel();
                using (proxy as IDisposable)
                {
                    MessageBox.Show(proxy.shakeHand("test").ToString());
                }
            }
        }

        private string findIP()
        {
            try
            {
                var ipaddress = Dns.GetHostAddresses("teacher");
                foreach (IPAddress ip in ipaddress)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                        return ip.ToString();
                }
                return "";
            }
            catch (SocketException)
            {
                return "";
            }
        }
    }
}
