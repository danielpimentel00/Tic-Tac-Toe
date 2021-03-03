using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Net;
using System.Net.Sockets;

public class Servidor : MonoBehaviour
{
    public bool host;
    public bool guest;
    public string address;
    int port;
    public bool connected;

    private void Start()
    {
        port = 4321;
        host = false;
        guest = false;
        connected = false;
    }

    private void Update()
    {
        Debug.Log(host);
        Debug.Log(guest);

    }

    public void Connect()
    {
        
        if (host && !guest)
        {
            Debug.Log("Esperando conexion...");
            TcpListener server = new TcpListener(IPAddress.Any, port);
            server.Start();

            byte[] bytes = new byte[4];
            string data = null;
            
            try
            {
                // Perform a blocking call to accept requests.
                

                TcpClient client = server.AcceptTcpClient();


                Debug.Log("conectado");
                connected = true;

                
                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();

                int i;

                // Loop to receive all the data sent by the client.
                /*while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                    // Process the data sent by the client.
                    data = data.ToUpper();

                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                    // Send back a response.
                    stream.Write(msg, 0, msg.Length);
                }*/

                // Shutdown and end connection
                client.Close();

            }
            catch (SocketException e)
            {
                Debug.Log(e.ErrorCode);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

        }
        else if(!host && guest)
        {
            
            try
            {
                TcpClient client = new TcpClient(address, port);

                connected = true;

                // Translate the passed message into ASCII and store it as a Byte array.
                byte[] data = new byte[4];

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                string message = string.Empty;

                while (message != string.Empty)
                {
                    data = Encoding.ASCII.GetBytes(message);
                    // Send the message to the connected TcpServer.
                    stream.Write(data, 0, data.Length);


                    // Receive the TcpServer.response.

                    // Buffer to store the response bytes.
                    data = new byte[256];

                    // String to store the response ASCII representation.
                    string responseData = string.Empty;

                    // Read the first batch of the TcpServer response bytes.
                    int bytes = stream.Read(data, 0, data.Length);
                    responseData = Encoding.ASCII.GetString(data, 0, bytes);

                    message = string.Empty;
                }


                // Close everything.
                stream.Close();
                client.Close();

            }

            catch (SocketException e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}
