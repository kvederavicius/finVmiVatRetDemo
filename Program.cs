using System;
using System.Security.Cryptography.X509Certificates;

namespace finVmiVatRetDemo
{
	internal class Program
	{
		static void Main(string[] _)
		{
			string certPath = @"C:\xxxx.pfx";
			string certPwd = "*******";

			X509Certificate2 cert = new X509Certificate2(certPath, certPwd);			

			var srvc = new VmiVatRefund.VATRefundforForeignTravelerTRPortService();
			srvc.ClientCertificates.Add(cert);
			//srvc.Url = "https://taxfree-ws.vmi.lt:8843/VATRefundforForeignTravelerTR";
			srvc.Url = "https://taxfree-tst-ws.vmi.lt:8844/VATRefundforForeignTravelerTR";

			try
			{
				VmiVatRefund.queryDeclarationsResponse vmiResponce = srvc.queryDeclarations(new VmiVatRefund.queryDeclarationsRequest()
				{
					RequestId = "2",
					SenderIn = "1231231",
					TimeStamp = new DateTime(),

					Query = new VmiVatRefund.queryDeclarationsRequestQuery()
					{
						DocId = "1120002221"
					}
				});

				bool error = vmiResponce.ResultStatus == VmiVatRefund.ResultStatus_Type.ERROR;

				if (error)
				{
					var errors = ((VmiVatRefund.Errors_Type)vmiResponce.Item).Error;
					foreach (var errorItem in errors)
						Console.WriteLine($"{errorItem.ErrorCode} - {errorItem.Description}");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);

				if (ex.InnerException != null)
					Console.WriteLine(ex.InnerException.Message);
			}

			Console.ReadLine();
		}		
	}
}