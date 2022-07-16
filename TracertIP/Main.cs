using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracertIP.IPLibrary;

namespace TracertIP
{
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// 输出字符(委托)
        /// </summary>
        /// <param name="s"></param>

        private delegate void PrintString(string s);

        /// <summary>
        /// Process
        /// </summary>
        private readonly Process process = new Process();

        /// <summary>
        /// IPHelper
        /// </summary>
        private readonly IPHelper iPHelper = new IPHelper();

        /// <summary>
        /// Main
        /// </summary>
        public Main()
        {
            InitializeComponent();
            //另起线程
            Task task = Task.Factory.StartNew(() =>
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = false;//需要对进程执行读写流
                startInfo.RedirectStandardOutput = true; //需要获取输出流
                startInfo.RedirectStandardInput = true;//需要获取输入流
                startInfo.CreateNoWindow = true;//不显示程序窗口
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;//隐藏窗口
                startInfo.FileName = @"cmd.exe";
                process.StartInfo = startInfo;//关联信息
                //输出事件
                process.OutputDataReceived += Process_OutputDataReceived;
                process.Start();
                //退出事件
                process.Exited += Process_Exited;
                //异步读取生成进程的标准输出
                //这会为每一行输出引发 OutputDataReceived 事件
                process.BeginOutputReadLine();
                process.WaitForExit();
            });
        }

        /// <summary>
        /// 追踪地址按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Dgv_Data.Rows.Clear();
            var writer = process.StandardInput;
            writer.WriteLine($"tracert {Text_IP.Text}");
        }

        /// <summary>
        /// Process 输出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            //输出结构数据
            if (!string.IsNullOrEmpty(e.Data))
            {
                var outData = e.Data;
                outData = new Regex("[\\s]+").Replace(outData, " ");
                outData = outData.Replace(" 毫秒", "").Replace(" ms", "");
                outData = outData.Trim();
                var outDatas = outData.Split(' ');
                Dgv_Data.Invoke(new PrintString((data) =>
                {
                    if (outData.Contains("通过")) return;
                    if (outDatas.Length < 5) return;
                    var index = Dgv_Data.Rows.Add();
                    var outIpStr = "--";
                    var outCountryStr = "--";
                    try
                    {
                        //查询
                        var ipStr = outDatas[4];
                        if (outDatas.Length == 6)
                        {
                            ipStr = outDatas[5];
                            ipStr = Regex.Match(ipStr, "(?<=\\[).+(?=\\])").Value;
                        }
                        var iPAddress = IPAddress.Parse(ipStr);
                        var iPData = iPHelper.GetIpLocation(iPAddress);
                        outIpStr = ipStr;
                        outCountryStr = iPData.Country;
                    }
                    catch { }
                    //行数据
                    Dgv_Data.Rows[index].Cells[0].Value = outDatas[0];
                    Dgv_Data.Rows[index].Cells[1].Value = outDatas[1];
                    Dgv_Data.Rows[index].Cells[2].Value = outDatas[2];
                    Dgv_Data.Rows[index].Cells[3].Value = outDatas[3];
                    Dgv_Data.Rows[index].Cells[4].Value = outIpStr;
                    Dgv_Data.Rows[index].Cells[5].Value = outCountryStr;
                }), e.Data);
                //输出原始数据
                Text_OutData.Invoke(new PrintString((data) =>
                {
                    Text_OutData.Text += $"{outData}\r\n";
                }), e.Data);
            }
        }

        /// <summary>
        /// Process 退出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Process_Exited(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询IP 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            var getIPContent = Text_IP.Text;
            var getIPs = getIPContent.Replace("，", ",").Split(',');
            Dgv_Data.Rows.Clear();
            for (int i = 0; i < getIPs.Length; i++)
            {
                var getIP = getIPs[i];
                if (string.IsNullOrEmpty(getIP)) continue;
                //查询
                var iPAddress = IPAddress.Parse(getIP);
                var iPData = iPHelper.GetIpLocation(iPAddress);
                //表格数据
                int index = Dgv_Data.Rows.Add();
                Dgv_Data.Rows[index].Cells[0].Value = i + 1;
                Dgv_Data.Rows[index].Cells[1].Value = "--";
                Dgv_Data.Rows[index].Cells[2].Value = "--";
                Dgv_Data.Rows[index].Cells[3].Value = "--";
                Dgv_Data.Rows[index].Cells[4].Value = iPData.IP;
                Dgv_Data.Rows[index].Cells[5].Value = iPData.Country;
            }
        }

        /// <summary>
        /// 关闭窗口前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            process.Kill();
        }

        /// <summary>
        /// 切换显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rsmi_ToggleDisplay_Click(object sender, EventArgs e)
        {
            Dgv_Data.Visible = !Dgv_Data.Visible;
        }
    }
}
