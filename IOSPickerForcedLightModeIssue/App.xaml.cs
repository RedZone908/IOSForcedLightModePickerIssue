﻿namespace IOSPickerForcedLightModeIssue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            UserAppTheme = AppTheme.Light;
        }
    }
}
