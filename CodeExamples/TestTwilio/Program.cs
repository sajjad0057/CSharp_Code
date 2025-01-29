//using System;
//using System.Text.Json;
//using Twilio;
//using Twilio.Rest.Api.V2010.Account;


//class Program
//{
//    static void Main(string[] args)
//    {
//        // Find your Account SID and Auth Token at twilio.com/console
//        // and set the environment variables. See http://twil.io/secure
//        string accountSid = "AC5dc4486462f4c609a3247bf9baedd815";
//        string authToken = "043157e55b9458412b5ba441e1137614";

//        Console.WriteLine();

//        TwilioClient.Init(accountSid, authToken);

//        var message = MessageResource.Create(
//            body: "I'm sajjad hossain. it's a testing purpose message! blaaa bla bala bala blaaa blaaa",
//            from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
//            to: new Twilio.Types.PhoneNumber("whatsapp:+8801774135869")
//        );

//        Console.WriteLine(JsonSerializer.Serialize(message).ToString());
//    }
//}


using System.Text.Json;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Example
{
    static void Main(string[] args)
    {
        var accountSid = "AC52ec1441ca7d9492e698dfff3c976af1";
        var authToken = "53cd07b0d2d0ef825d4c2e678d4295b8";
        TwilioClient.Init(accountSid, authToken);

        var messageOptions = new CreateMessageOptions(
          new PhoneNumber("whatsapp:+8801924201310"));
        messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
        messageOptions.Body = "Hello , from sajjad hossain";


        var message = MessageResource.Create(messageOptions);

        Console.WriteLine(JsonSerializer.Serialize(message));
    }
}