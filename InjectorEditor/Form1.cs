﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InjectorEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string delegatePath = "C:/GiteeSVN/ProtectGold/Research/MSILInject/Demo/Delegate";
            string dllPath = "C:/GiteeSVN/ProtectGold/Research/MSILInject/Demo/bin/Debug/Demo.exe";
            delegatePath = m_DelegatePath.Text;
            dllPath = m_DllPath.Text;
            try
            {
                DelegateGen inject = new DelegateGen();
                inject.Run(dllPath, delegatePath);

                m_log.Text = "生成完毕!";
            }
            catch(Exception exp)
            {
                m_log.Text = exp.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dllPath = "C:/GiteeSVN/ProtectGold/Research/MSILInject/Demo/bin/Debug/Demo.exe";
            dllPath = m_DllPath.Text;

            try
            {
                InjectorMain inject = new InjectorMain();
                inject.Run(dllPath);
                m_log.Text = "注入完毕完毕!";
            }
            catch(Exception exp)
            {
                m_log.Text = exp.Message + exp.StackTrace;
            }
        }
    }
}
