using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt;

namespace Tools
{
    public class Mqtt
    {
        MqttClient mqttClient;
        public string receive_msg_old="";
        public string receive_msg_new=""; 

        public Mqtt() 
        {
          
        }

        public bool Connect(String client_id, string addr, string topic)
        {
            mqttClient = new MqttClient(addr);
            mqttClient.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            mqttClient.MqttMsgPublishReceived += client_receivedMessage;
            mqttClient.Connect(client_id);
            return mqttClient.IsConnected;
        }

        public bool Disconnect()
        {
            mqttClient.Disconnect();
            if (!mqttClient.IsConnected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String Get_GUID()
        {
            string clientid = Guid.NewGuid().ToString();
            return clientid;
        }

        public void publish(string topic, string msg)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(msg);
            mqttClient.Publish(topic,bytes);
        }

        public void client_receivedMessage(object sender, MqttMsgPublishEventArgs e)
        {
            var message = System.Text.Encoding.Default.GetString(e.Message);
            receive_msg_new=message;
        }

        public bool message_receive()
        {
            if(receive_msg_new !=receive_msg_old)
            {
                receive_msg_old = receive_msg_new;
                return true;
            }
            else
            {
                return false;
            }          
        }


    }
}




//  Console.WriteLine(clientid);
//  Console.WriteLine("Subscriber: MachineData/");
//  mqttClient.Subscribe(new string[] { "MachineData/" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
//  System.Console.ReadLine();
