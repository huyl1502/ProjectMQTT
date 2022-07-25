using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Mvc;
using System.Threading;
using System.Windows.Controls;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace FireDetect.Controllers
{
    class BaseController : Controller
    {
        //for ResponseController 
        public DataContext Response { get; set; }
        const string _topic = "device";
        public string SubscribeTopic => "response/default/" + ClientId;

        public static string Token { get; set; }

        static string _clientId;
        public static string ClientId
        {
            get
            {
                if (_clientId == null)
                {
                    _clientId = Guid.NewGuid().ToString();
                }
                return _clientId;
            }
        }
        static MqttClient _mqttClient;
        public MqttClient Client
        {
            get
            {
                if (_mqttClient == null)
                {
                    _mqttClient = new MqttClient(
                    "localhost",
                    1502,
                    false,
                    MqttSslProtocols.None,
                    null,
                    null
                );
                    _mqttClient.MqttMsgPublishReceived += MqttMsgReceived;
                    ConnectMqtt(5);
                }
                return _mqttClient;
            }
        }
        //
        T GetMqttMessage<T>(MqttMsgPublishEventArgs e)
        {
            string content = System.Text.Encoding.UTF8.GetString(e.Message);
            var context = JObject
                .Parse(content)
                .ToObject<T>();
            return context;
        }
        byte[] GetEncodeBytes(object v)
        {
            var content = JObject.FromObject(v).ToString();
            return System.Text.Encoding.UTF8.GetBytes(content);
        }
        void MqttMsgReceived(object sender, MqttMsgPublishEventArgs e)
        {
            var context = GetMqttMessage<DataContext>(e);

            var c = Engine.GetController<BaseController>("Response");
            if (c != null)
            {
                var action = c.GetMethod("Default");
                if (action != null)
                {
                    c.Response = context;
                    //AsyncEngine.CreateThread(() => action.Invoke(c, new object[] { }));
                    Engine.BeginInvoke(() =>
                    {
                        action.Invoke(c, new object[] { });
                    });
                }
            }
        }

        protected void ConnectMqtt(int checkConnectionSeconds = 0)
        {
            if (_mqttClient != null && _mqttClient.IsConnected) return;
            try
            {
                _mqttClient.Connect(ClientId);
            }
            catch {
            }

            _mqttClient.ConnectionClosed += (s, e) =>
            {

            };

            if (_mqttClient.IsConnected)
            {
                Subscribe(SubscribeTopic);
                //Subscribe(_topic);
            }

            if (checkConnectionSeconds > 0)
            {
                int interval = checkConnectionSeconds * 1000;
                Engine.BeginInvoke(() =>
                {
                    while (true)
                    {
                        System.Threading.Thread.Sleep(interval);
                        ConnectMqtt();
                    }
                });
                //AsyncEngine.CreateThread(() =>
                //{
                //    while (true)
                //    {
                //        System.Threading.Thread.Sleep(interval);
                //        ConnectMqtt();
                //    }
                //});
            }
        }
        protected void Subscribe(string topic)
        {
            _mqttClient.Subscribe(new string[] { topic }, new byte[] { 0 });
        }
        public void Publish(string topic, string url, object value)
        {
            if (_mqttClient == null || _mqttClient.IsConnected == false)
            {
                ConnectMqtt();
            }
            if (_mqttClient.IsConnected)
            {
                var context = new DataContext();
                context.SetString("Url", url);
                System.Console.WriteLine(url);
                context.SetString("ClientId", ClientId);
                context.SetObject("Value", value);

                //if (Current_User != null && string.IsNullOrEmpty(Current_User.Token) == false)
                if (Token != null)
                {
                    //context.SetString("Token", Current_User.Token);
                    context.SetString("Token", Token);
                }

                _mqttClient.Publish(topic, GetEncodeBytes(context));
            }
        }
        protected void Publish(string url, object value)
        {
            Publish(_topic, url, value);
        }
        
        protected void Disconnect()
        {
            if (_mqttClient != null && _mqttClient.IsConnected)
            {
                _mqttClient.Disconnect();
            }
        }

        public object GoFirst()
        {
            return RedirectToAction("Default");
        }
        public object GoHome()
        {
            return Redirect("Home");
        }

        protected T GetValue<T>(object value) { return Json.Convert<T>(value); }
        protected T ConvertArray<T>(object value)
        {
            var jarray = JArray.FromObject(value);
            return jarray.ToObject<T>();
        }
        protected T ConvertDictionary<T>(object value)
        {
            return JsonConvert.DeserializeObject<T>(value.ToString());
        }
    }
}
