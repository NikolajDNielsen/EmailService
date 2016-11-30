using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmailService
    {
        [OperationContract]
        string SendEmail(string gmailUserAddress, string gmailUserPassword,
        string[] emailTo, string[] ccTo, string subject, string body, bool isBodyHtml);
    }
}

