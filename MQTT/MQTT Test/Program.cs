using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTT_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create client instance
            MqttClient mqttClient = new MqttClient("localhost");

            //Register to message received
            mqttClient.MqttMsgPublishReceived += client_receivedMessage;

            string clientid=Guid.NewGuid().ToString();  
            mqttClient.Connect(clientid);
            Console.WriteLine(clientid);
            Console.WriteLine("Subscriber: MachineData/");
            mqttClient.Subscribe(new string[] {"MachineData/"},new byte[] {MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE});
            System.Console.ReadLine();
        }

        private static void client_receivedMessage(object sender, MqttMsgPublishEventArgs e)
        {
            //Handle message received
            var message=System.Text.Encoding.Default.GetString(e.Message);
            System.Console.WriteLine("Message received:"+message);  
        }
    }

     

}
