﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace System.Windows.Controls
{
    /// <summary>
    /// Interaction logic for LoadingPanel.xaml
    /// </summary>
    public partial class LoadingPanel
    {
        public static readonly DependencyProperty IsLoadingProperty =
            DependencyProperty.Register("IsLoading", typeof(bool), typeof(LoadingPanel), new UIPropertyMetadata(false));

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(LoadingPanel), new UIPropertyMetadata("Loading..."));

        public static readonly DependencyProperty SubMessageProperty =
            DependencyProperty.Register("SubMessage", typeof(string), typeof(LoadingPanel), new UIPropertyMetadata(string.Empty));

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadingPanel"/> class.
        /// </summary>
        public LoadingPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is loading.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is loading; otherwise, <c>false</c>.
        /// </value>
        public bool IsLoading
        {
            get { return (bool)GetValue(IsLoadingProperty); }
            set { SetValue(IsLoadingProperty, value); }
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        /// <summary>
        /// Gets or sets the sub message.
        /// </summary>
        /// <value>The sub message.</value>
        public string SubMessage
        {
            get { return (string)GetValue(SubMessageProperty); }
            set { SetValue(SubMessageProperty, value); }
        }

        /// <summary>
        /// Gets or sets the close panel command.
        /// </summary>
        /// <value>The close panel command.</value>
    }
}
