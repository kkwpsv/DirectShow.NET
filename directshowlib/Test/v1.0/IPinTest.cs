// $Id: IPinTest.cs,v 1.11 2007-06-21 08:42:23 snarfle Exp $
// $Author: snarfle $
// $Revision: 1.11 $
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace DirectShowLib.Test
{
	/// <summary>
	/// IPin Test is used to test all the calls for the IPin interface
	/// IPin::ReceiveConnection, IPin::BeginFlush, IPin::EndFlush, IPin::EndOfStream, IPin::NewSegment is not tested because it should not be called from application
	/// 
	/// Still need to test QueryAccept, and fix QueryInternalConnections
	/// </summary>
	[TestFixture]
	public class IPinTest
	{
        public void DoTests()
        {
            TestQueryDirection();
            TestQueryPinInfo();
            TestQueryId();
            TestEnumMediaTypes();
            TestQueryInternalConnections();
            TestConnectDisconnectConnectedToConnectionMediaType();
        }

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestQueryDirection()
		{
			IPin testPin = GetSmartTeeInputPin();
			PinDirection pDir;
			int hr = testPin.QueryDirection(out pDir);
			Marshal.ThrowExceptionForHR(hr);

			Assert.IsTrue(pDir == PinDirection.Input || pDir == PinDirection.Output);
		}


		[Test]
		public void TestQueryPinInfo()
		{
			IPin testPin = GetSmartTeeInputPin();
			PinInfo pinInfo;
			int hr = testPin.QueryPinInfo(out pinInfo);
			Marshal.ThrowExceptionForHR(hr);


			Assert.IsNotNull(pinInfo);
			Assert.IsNotNull(pinInfo.name);
			Console.WriteLine(pinInfo.name);
		}

		[Test]
		public void TestQueryId()
		{
			IPin testPin = GetSmartTeeInputPin();
			string idStr;
			int hr = testPin.QueryId(out idStr);
			Marshal.ThrowExceptionForHR(hr);

			Assert.IsNotNull(idStr);
		}

		[Test]
		public void TestEnumMediaTypes()
		{
			IPin testPin = GetSmartTeeInputPin();
			IEnumMediaTypes enumMediaTypes;
			int hr = testPin.EnumMediaTypes(out enumMediaTypes);
			Marshal.ThrowExceptionForHR(hr);

			Assert.IsNotNull(enumMediaTypes);

			hr = enumMediaTypes.Reset();
			Marshal.ThrowExceptionForHR(hr);			
		}


		[Test]
		public void TestQueryInternalConnections()
		{
			IPin testPin = GetSmartTeeInputPin();
			int nPin = 0;
			IPin[] ppPins = null;
			int hr = testPin.QueryInternalConnections(ppPins, ref nPin);

			Marshal.ThrowExceptionForHR(hr);
			Console.Write(nPin);

			Assert.IsNotNull(ppPins);
		}

		[Test]
		public void TestConnectDisconnectConnectedToConnectionMediaType()
		{
			int hr;
			IBaseFilter aviSplitter = null;
			IBaseFilter ibfAVISource = null;
			IPin pinIn = null;
			IPin pinOut = null;

			IFilterGraph2 graphBuilder = new FilterGraph() as IFilterGraph2;
			try
			{
				ibfAVISource = new AsyncReader() as IBaseFilter;

				// Add it to the graph
				hr = graphBuilder.AddFilter(ibfAVISource, "Ds.NET AsyncReader");
				Marshal.ThrowExceptionForHR(hr);

				// Set the file name
				IFileSourceFilter fsf = ibfAVISource as IFileSourceFilter;
				hr = fsf.Load(@"foo.avi", null);
				Marshal.ThrowExceptionForHR(hr);
				pinOut = DsFindPin.ByDirection(ibfAVISource, PinDirection.Output, 0);

				// Get the avi splitter
				aviSplitter = (IBaseFilter) new AviSplitter();

				// Add it to the graph
				hr = graphBuilder.AddFilter(aviSplitter, "Ds.NET AviSplitter");
				Marshal.ThrowExceptionForHR(hr);
				pinIn = DsFindPin.ByDirection(aviSplitter, PinDirection.Input, 0);

				Assert.IsNotNull(pinOut);
				Assert.IsNotNull(pinIn);

				// Test Connect
				hr = pinOut.Connect(pinIn, null);
				Marshal.ThrowExceptionForHR(hr);


				// Test ConnectedTo
				IPin pinConnect;
				hr = pinOut.ConnectedTo(out pinConnect);
				Marshal.ThrowExceptionForHR(hr);
				Assert.AreEqual(pinIn, pinConnect);


				// Test ConnectionMediaType
				AMMediaType mediaType = new AMMediaType();
				hr = pinIn.ConnectionMediaType(mediaType);
				Marshal.ThrowExceptionForHR(hr);
				Assert.IsNotNull(mediaType);
				Assert.IsNotNull(mediaType.majorType);

				// Test Disconnect
				hr = pinOut.Disconnect();
				Marshal.ThrowExceptionForHR(hr);

			}
			finally
			{
				Marshal.ReleaseComObject(graphBuilder);
			}
		}


		private static IPin GetSmartTeeInputPin()
		{
			IBaseFilter filter = new SmartTee() as IBaseFilter;
			int hr;
            IntPtr ip = Marshal.AllocCoTaskMem(4);
			IEnumPins ppEnum;
			IPin pRet = null;
			IPin[] pPins = new IPin[1];

			hr = filter.EnumPins(out ppEnum);
			Marshal.ThrowExceptionForHR(hr);

			while ((ppEnum.Next(1, pPins, ip) >= 0) && (Marshal.ReadInt32(ip) == 1))
			{
				pRet = pPins[0];
				break;
			}
            Marshal.FreeCoTaskMem(ip);
            Marshal.ReleaseComObject(ppEnum);
			return pRet;
		}

	}
}