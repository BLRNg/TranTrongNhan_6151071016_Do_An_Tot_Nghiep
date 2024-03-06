using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectShowLib;
using Parking_Slot.Helper;
using Parking_Slot.Repo;

namespace Parking_Slot
{
    public partial class InOutLane : Form
    {
        private IFilterGraph2 filterGraph;
        private ICaptureGraphBuilder2 captureGraphBuilder;
        private IVideoWindow videoWindow;
        private IMediaControl mediaControl;
        private ISampleGrabber sampleGrabber;
        WebClient client;
        SerialPort serialPort1;


        ObjectParameter CustomerName ;
        ObjectParameter Message ;
        ObjectParameter PlateNum ;
        ObjectParameter total_Amount ;
        ObjectParameter Time ;
        ObjectParameter LanceTye ;
        ObjectParameter PhotoCustomerIn ;
        ObjectParameter PhotoLicensePlateNumberIN ;
        SqlParameter checkTimeParameter;

        private UserRepository userRepository;
        public InOutLane()
        {
            InitializeComponent();
            serialPort1 = new SerialPort();
            serialPort1.PortName = "COM4"; // Change to match your Arduino's COM port
            serialPort1.BaudRate = 9600; // Must match Arduino's baud rate
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            userRepository = new UserRepository();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadExisting();

            if (data.Contains("C1"))
            {
                try
                {
                    serialPort1.Write("1");
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            if (data.Contains("C2"))
            {
                try
                {
                 
                    serialPort1.Write("3");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            //if( data.Contains("_") && 2==data.Count(c => c == '_'))
            //MessageBox.Show(data +" |"+data.Substring(8,19 -5 - 3)+"| "+ data.IndexOf("_") + " " + data.LastIndexOf("_"));
            if (data.Contains("r"))
            {

            }
                MessageBox.Show(data );
            //MessageBox.Show("Dau doc 1" + data);
            //if (data.Contains("Reader1") || data.Contains("Reader0"))
            //{
            //    //string textAfterReader1 = data.Substring("Reader1".Length).Trim();
            //    UpdateTextBox(data);
            //    //MessageBox.Show("Dau doc 1"+textAfterReader1);
            //}



        }

        delegate void UpdateTextBoxDelegate(string text);

        private void UpdateTextBox(string text)
        {
            if (cardNoBox.InvokeRequired)
            {
                cardNoBox.Invoke(new UpdateTextBoxDelegate(UpdateTextBox), new object[] { text });
            }
            else
            {
                if (text.Contains("Reader1"))
                {
                    string cardNo = text.Substring("Reader1".Length).Trim();
                    string licenseNumber = GetLicenseNumber.GetLicenseNumberByUrl(urlImg(), client);

                    var result = userRepository.sp_laneIn(1, licenseNumber, cardNo, DateTime.Now, CustomerName, Message, PlateNum, total_Amount, Time,
                    LanceTye, PhotoCustomerIn, PhotoLicensePlateNumberIN);

                    customerBox.Text = CustomerName.Value.ToString();
                    messaBox.Text = Message.Value.ToString();
                    licenseBox.Text = PlateNum.Value.ToString();
                    totalAmountBox.Text = total_Amount.Value.ToString();
                    timeBox.Text = Time.Value.ToString();
                    laneBox.Text = LanceTye.Value.ToString();
                    cardNoBox.Text = cardNo;

                    if (Message.Value.ToString().Contains("Xin mời qua"))
                    {
                        try
                        {
                            serialPort1.Write("2");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                    }

                }

                if (text.Contains("Reader0"))
                {
                    string cardNo="";
                    // Find the index of the substring "Reader0"
                    int startIndex = text.IndexOf("Reader0");

                    // If "Reader0" is found in the input string
                    if (startIndex != -1)
                    {
                        // Move the startIndex to the end of "Reader0" plus its length
                        startIndex += "Reader0".Length + 1; // Adding 1 for the space character

                        // Find the index of the next space character after "Reader0"
                        int endIndex = text.IndexOf(' ', startIndex);

                        // If another space is found after "Reader0"
                        if (endIndex != -1)
                        {
                            // Extract the substring between startIndex and endIndex
                            cardNo = text.Substring(startIndex);

                          
                        }
                    }
                        //string cardNo = text.Substring("Reader0".Length).Trim();
                    string licenseNumber = GetLicenseNumber.GetLicenseNumberByUrl(urlImg(), client);

                    var result = userRepository.sp_laneIn(1, licenseNumber, cardNo, DateTime.Now, CustomerName, Message, PlateNum, total_Amount, Time,
                    LanceTye, PhotoCustomerIn, PhotoLicensePlateNumberIN);

                    customerBox.Text = CustomerName.Value.ToString();
                    messaBox.Text = Message.Value.ToString();
                    licenseBox.Text = PlateNum.Value.ToString();
                    totalAmountBox.Text = total_Amount.Value.ToString();
                    timeBox.Text = Time.Value.ToString();
                    laneBox.Text = LanceTye.Value.ToString();
                    cardNoBox.Text = cardNo;

                    if (Message.Value.ToString().Contains("Xin mời qua"))
                    {
                        try
                        {
                            serialPort1.Write("4");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                    }

                }




            }
        }

        private void InOutLane_Load(object sender, EventArgs e)
        {
           
             CustomerName = new ObjectParameter("CustomerName", typeof(string));
             Message = new ObjectParameter("Message", typeof(string));
             PlateNum = new ObjectParameter("PlateNum", typeof(string));
             total_Amount = new ObjectParameter("total_Amount", typeof(string));
             Time = new ObjectParameter("Time", typeof(string));
             LanceTye = new ObjectParameter("LanceTye", typeof(string));
             PhotoCustomerIn = new ObjectParameter("PhotoCustomerIn", typeof(string));
             PhotoLicensePlateNumberIN = new ObjectParameter("PhotoLicensePlateNumberIN", typeof(string));

            client = new WebClient();
            try
            {
                serialPort1.Open(); // Open the serial port
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            filterGraph = new FilterGraph() as IFilterGraph2;
            captureGraphBuilder = new CaptureGraphBuilder2() as ICaptureGraphBuilder2;

            // Create the media control for controlling the graph
            mediaControl = filterGraph as IMediaControl;

            try
            {
                // Get the first video input device
                var device = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice)[0];

                // Attach the camera filter to the graph
                IBaseFilter sourceFilter;
                var hr = captureGraphBuilder.SetFiltergraph(filterGraph);
                hr = filterGraph.AddSourceFilterForMoniker(device.Mon, null, "Video Capture", out sourceFilter);
                Marshal.ThrowExceptionForHR(hr);

                // Create the renderer filter
                IBaseFilter rendererFilter = new VideoRenderer() as IBaseFilter;

                // Add both filters to the filter graph
                hr = filterGraph.AddFilter(sourceFilter, "Source Filter");
                Marshal.ThrowExceptionForHR(hr);
                hr = filterGraph.AddFilter(rendererFilter, "Renderer Filter");
                Marshal.ThrowExceptionForHR(hr);

                // Connect the camera filter to the renderer filter
                hr = captureGraphBuilder.RenderStream(PinCategory.Capture, MediaType.Video, sourceFilter, null, rendererFilter);
                Marshal.ThrowExceptionForHR(hr);

                // Create SampleGrabber
                sampleGrabber = new SampleGrabber() as ISampleGrabber;
                var sampGrabber = sampleGrabber as ISampleGrabber;
                var mt = new AMMediaType();
                mt.majorType = MediaType.Video;
                mt.subType = MediaSubType.RGB24;
                sampGrabber.SetMediaType(mt);
                hr = filterGraph.AddFilter(sampleGrabber as IBaseFilter, "SampleGrabber");
                Marshal.ThrowExceptionForHR(hr);

                // Connect SampleGrabber
                hr = captureGraphBuilder.RenderStream(null, null, sourceFilter, null, sampleGrabber as IBaseFilter);
                Marshal.ThrowExceptionForHR(hr);

                hr = sampGrabber.SetBufferSamples(true);
                Marshal.ThrowExceptionForHR(hr);
                hr = sampGrabber.SetOneShot(false);
                Marshal.ThrowExceptionForHR(hr);

                hr = sampGrabber.GetConnectedMediaType(mt);
                Marshal.ThrowExceptionForHR(hr);

                var header = (VideoInfoHeader)Marshal.PtrToStructure(mt.formatPtr, typeof(VideoInfoHeader));
                Marshal.FreeCoTaskMem(mt.formatPtr);



                // Get the video window interface
                videoWindow = filterGraph as IVideoWindow;
                videoWindow.put_Owner(pictureBox1.Handle);
                videoWindow.put_MessageDrain(this.Handle);
                videoWindow.put_WindowStyle(WindowStyle.Child | WindowStyle.ClipChildren);
                videoWindow.SetWindowPosition(pictureBox1.ClientRectangle.Left, pictureBox1.ClientRectangle.Top, pictureBox1.ClientRectangle.Width, pictureBox1.ClientRectangle.Height);
                videoWindow.put_Visible(OABool.True);



                // Start the preview
                hr = mediaControl.Run();
                Marshal.ThrowExceptionForHR(hr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void InOutLane_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close(); // Close the serial port when the form is closing

            // Stop the preview and release resources
            if (mediaControl != null)
                mediaControl.Stop();
            if (videoWindow != null)
                videoWindow.put_Visible(OABool.False);

            // Release COM objects
            if (mediaControl != null) Marshal.ReleaseComObject(mediaControl);
            if (videoWindow != null) Marshal.ReleaseComObject(videoWindow);
            if (captureGraphBuilder != null) Marshal.ReleaseComObject(captureGraphBuilder);
            if (filterGraph != null) Marshal.ReleaseComObject(filterGraph);
        }

        private string urlImg()
        {
            string fileName = @"C:\Users\trant\Downloads\Image\" + ImageNameGenerator.GenerateUniqueImageName(); ;
            try
            {
                if (sampleGrabber != null)
                {
                    var sampGrabber = sampleGrabber as ISampleGrabber;
                    int bufferSize = 0;
                    sampGrabber.GetCurrentBuffer(ref bufferSize, IntPtr.Zero);

                    if (bufferSize > 0)
                    {
                        var buffer = Marshal.AllocCoTaskMem(bufferSize);
                        sampGrabber.GetCurrentBuffer(ref bufferSize, buffer);

                        int width = 1280; // Change the width as needed
                        int height = 720; // Define the desired height
                        int stride = width * 3; // Calculate stride based on width and pixel format

                        var bitmap = new Bitmap(width, height, stride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, buffer);
                        bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

                        bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                        Marshal.FreeCoTaskMem(buffer);

                        return fileName;
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred while capturing and saving image: " + ex.Message);
            }

            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var result = userRepository.sp_laneIn(1, "03 40 3a fe", "03 40 3a fe", DateTime.Now, CustomerName, Message, PlateNum, total_Amount, Time,
                LanceTye, PhotoCustomerIn, PhotoLicensePlateNumberIN);
            MessageBox.Show($"CustomerName: {CustomerName.Value}, Message: {Message.Value}, PlateNum {PlateNum.Value}," +
                $"total_Amount: {total_Amount.Value}, Time {Time.Value}, LanceTye: {LanceTye.Value}, PhotoCustomerIn: {PhotoCustomerIn.Value}, " +
                $"PhotoLicensePlateNumberIN {PhotoLicensePlateNumberIN.Value}");
            //foreach(sp_LaneOneForSimplifiedInterface_Result item in result)
            //{
            //    MessageBox.Show(item.BienSo);
            //}
            //string result= GetLicenseNumber.GetLicenseNumberByUrl(urlImg(), client);
            //MessageBox.Show(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
