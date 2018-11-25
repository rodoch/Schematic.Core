using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace Schematic.Core
{
    public class EmailSettings
    {
        public MailAddress FromMailAddress { get; private set; }
        public NetworkCredential SMTPCredentials { get; private set; }

        public string ToAddress { get; set; }

        private string fromAddress;
        public string FromAddress
        {
            get => fromAddress;
            set
            {
                fromAddress = value;
                SetMailAddress();
            }
        }

        private string fromDisplayName;
        public string FromDisplayName
        {
            get => fromDisplayName;
            set
            {
                fromDisplayName = value;
                SetMailAddress();
            }
        }

        public string SMTPHost { get; set; }

        public int? SMTPPort { get; set; }

        private string smtpUserName;
        public string SMTPUserName
        {
            get => smtpUserName;
            set
            {
                smtpUserName = value;
                SetCredentials();
            }
        }

        private string smtpPassword;
        public string SMTPPassword
        {
            get => smtpPassword;
            set
            {
                smtpPassword = value;
                SetCredentials();
            }
        }

        public bool SMTPEnableSSL { get; set; }

        private void SetMailAddress()
        {
            try
            {
                FromMailAddress = fromDisplayName.HasValue()
                    ? new MailAddress(fromAddress, fromDisplayName)
                    : new MailAddress(fromAddress);
            }
            catch
            {
                FromMailAddress = null;
            }
        }

        private void SetCredentials() =>
            SMTPCredentials = smtpUserName.HasValue() && smtpPassword.HasValue()
                ? new NetworkCredential(smtpUserName, smtpPassword)
                : null;
    }
}