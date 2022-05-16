using Amazon.Runtime;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using poc_sns;

var keys = new Config();

string number = keys.Number;
string message = "Hello at " + DateTime.Now.ToShortTimeString();

BasicAWSCredentials awsCredentials = new BasicAWSCredentials(keys.AccessKey, keys.SecretKey);
Amazon.RegionEndpoint awsRegion = keys.RegionEndpoint;

var client = new AmazonSimpleNotificationServiceClient(credentials: awsCredentials, region: awsRegion);
var request = new PublishRequest
{
    Message = message,
    PhoneNumber = number
};

try
{
    await client.PublishAsync(request);
    Console.WriteLine("Message sent to " + number + ":");
    Console.WriteLine(message);
}
catch (Exception ex)
{
    Console.WriteLine("Caught exception publishing request:");
    Console.WriteLine(ex.Message);
}
