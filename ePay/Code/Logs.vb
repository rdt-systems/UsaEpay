Imports Serilog

Friend Class Logs
    Private Shared _Logger As ILogger
    Private Shared _LoggerConfig As Serilog.LoggerConfiguration

    Private Shared ReadOnly Property LoggerConfig As LoggerConfiguration
        Get
            If _LoggerConfig Is Nothing Then
                _LoggerConfig = New LoggerConfiguration() _
                .Destructure.ToMaximumDepth(3) _
                .Enrich.WithMachineName() _
                .Enrich.WithThreadId() _
                .Enrich.WithProcessId() _
                .Enrich.WithProperty("OSVersion", My.Computer.Info.OSVersion) _
                .Enrich.WithProperty("OSName", My.Computer.Info.OSFullName) _
                .Enrich.WithProperty("AvailablePhysicalMemory", My.Computer.Info.AvailablePhysicalMemory.ToString("n0")) _
                .Enrich.WithProperty("ApplicationVersion", My.Application.Info.Version) _
                .Enrich.WithProperty("AppID", "ePay") _
                .Enrich.WithProperty("ApplicationPath", AppDomain.CurrentDomain.BaseDirectory) _
                .MinimumLevel.Verbose _
                .WriteTo.Seq("http://logs.sequelpay.com:5341", Serilog.Events.LogEventLevel.Information) _
                .WriteTo.RollingFile(String.Format("{0}\Logs\log-{{Date}}.txt", AppDomain.CurrentDomain.BaseDirectory), Events.LogEventLevel.Verbose, , , , 14)
            End If

            Return _LoggerConfig
        End Get
    End Property

    Public Shared ReadOnly Property Logger As ILogger
        Get
            If _Logger Is Nothing Then
                _Logger = LoggerConfig.CreateLogger()
            End If
            Return _Logger
        End Get
    End Property

End Class
