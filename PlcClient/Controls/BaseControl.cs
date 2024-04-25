﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PlcClient.Controls
{
    public partial class BaseControl : UserControl
    {
        public BaseControl()
        {
            InitializeComponent();
        }
        public Ping ping = new Ping();
        public Stopwatch stopwatch = Stopwatch.StartNew();
        public virtual TypeCode[] TypeCodes { get; set; } = new[] {
            TypeCode.Boolean,
            TypeCode.Byte,
            TypeCode.Int16,
            TypeCode.Int32,
            //TypeCode.Int64,
            TypeCode.Single,
            TypeCode.Double,
            TypeCode.UInt16,
            TypeCode.UInt32,
            //TypeCode.UInt64
        };
        #region event
        public event Action<string> Msg;

        protected virtual void OnMsg(string msg)
        {
            this.Msg?.Invoke(msg);
        }
        #endregion

        public TControl[] FindControls<TControl>(Control baseControl, bool searchAllChildren) where TControl : Control
        {
            var list = new List<TControl>();
            if (baseControl == null)
                return list.ToArray();

            for (int i = 0; i < baseControl.Controls.Count; i++)
            {
                var item = baseControl.Controls[i];
                if (item.GetType() == typeof(TControl))
                {
                    list.Add(item as TControl);
                }
                if (searchAllChildren && item.Controls != null)
                {
                    list.AddRange(FindControls<TControl>(item, searchAllChildren));
                }
            }
            return list.ToArray();
        }
        private static IPAddress[] IPS = null;
        public string[] GetLocalAllIP()
        {
            if (IPS == null)
            {
                IPS = Dns.GetHostAddresses(Dns.GetHostName()).ToArray();
            }
            return IPS.Where(m => m.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).Select(m => m.ToString()).OrderByDescending(m => m).ToArray();

        }
        public string GetLocalIP()
        {
            return GetLocalAllIP().FirstOrDefault();
        }
    }
}
