﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevAssessment.CustomDialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertDialog : Frame
    {
        public AlertDialog()
        {
            InitializeComponent();
        }
    }
}