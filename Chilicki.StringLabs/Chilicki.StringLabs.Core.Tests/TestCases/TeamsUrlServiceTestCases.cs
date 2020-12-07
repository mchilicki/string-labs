using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.StringLabs.Core.Tests.TestCases
{
    class TeamsUrlServiceTestCases
    {
        public const string CorrectTestCase1 = @"
           <div style=""margin - top: 24px; margin - bottom: 10px; "">
                     < a class=""me -email-headline"" style = ""font -size: 18px;font-family:'Segoe UI Semibold','Segoe UI','Helvetica Neue',Helvetica,Arial,sans-serif;text-decoration: underline;color: #6264a7;"" href =""https://teams.microsoft.com/l/meetup-join/19%3ameeting_YTJmOGM5NDQtNzA4MS00YjU3LThlNTEtZjYwZjc5ZDNmNzRl%40thread.v2/0?context=%7b%22Tid%22%3a%228b44c513-80e8-4767-9e1b-211d4411b13e%22%2c%22Oid%22%3a%22c5c4478e-fd77-4fa6-abbf-a1ef32ac4488%22%7d"" target =""_blank"" rel =""noreferrer noopener"" > Join Microsoft Teams Meeting</a>
              </div>
	 
	 
	          <a class=""me -email-link"" style =""font -size: 12px;text-decoration: none;color: #6264a7;"" target =""_blank"" href =""https://aka.ms/JoinTeamsMeeting"" rel =""noreferrer noopener"" > Learn more about Teams</a>
    
     
     
              <div style = ""font -size: 14px; margin-bottom: 4px;"" >


              </ div >
              < div style= ""font -size: 12px; "" >


              </ div >";
        
        public const string CorrectTestCase2 = @"
   < div style=""margin-top: 24px; margin-bottom: 10px;"">
        <a class=""me-email-headline"" style=""font-size: 18px;font-family:'Segoe UI Semibold','Segoe UI','Helvetica Neue',Helvetica,Arial,sans-serif;text-decoration: underline;color: #6264a7;"" href=""https://teams.microsoft.com/l/meetup-join/19%3ameeting_YzRmZGVhZTgtMmM2Ni00MmRlLTliZTMtOTE2NTdkYjE2Y2Zk%40thread.v2/0?context=%7b%22Tid%22%3a%228b44c513-80e8-4767-9e1b-211d4411b13e%22%2c%22Oid%22%3a%22c5c4478e-fd77-4fa6-abbf-a1ef32ac4488%22%7d"" target=""_blank"" rel=""noreferrer noopener"">Join Microsoft Teams Meeting</a>
      </div>
	 
	 
	  <a class=""me-email-link"" style=""font-size: 12px;text-decoration: none;color: #6264a7;"" target=""_blank"" href=""https://aka.ms/JoinTeamsMeeting"" rel=""noreferrer noopener"">Learn more about Teams</a>
    
     
     
      <div style = ""font-size: 14px; margin-bottom: 4px;"" >


      </ div >
      < div style= ""font-size: 12px;"" >


      </ div >";

        public const string CorrectResult1 = "https://teams.microsoft.com/l/meetup-join/19%3ameeting_YTJmOGM5NDQtNzA4MS00YjU3LThlNTEtZjYwZjc5ZDNmNzRl%40thread.v2/0?context=%7b%22Tid%22%3a%228b44c513-80e8-4767-9e1b-211d4411b13e%22%2c%22Oid%22%3a%22c5c4478e-fd77-4fa6-abbf-a1ef32ac4488%22%7d";
        public const string CorrectResult2 = "https://teams.microsoft.com/l/meetup-join/19%3ameeting_YzRmZGVhZTgtMmM2Ni00MmRlLTliZTMtOTE2NTdkYjE2Y2Zk%40thread.v2/0?context=%7b%22Tid%22%3a%228b44c513-80e8-4767-9e1b-211d4411b13e%22%2c%22Oid%22%3a%22c5c4478e-fd77-4fa6-abbf-a1ef32ac4488%22%7d";
    }
}
