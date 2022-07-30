using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RAW.Auth
{
	// Token: 0x020000A6 RID: 166
	public class api
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x00024750 File Offset: 0x00024750
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				MessageBox.Show("Application not setup correctly. Please watch video link found in Login.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000247D0 File Offset: 0x000247D0
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			if (text2 == "KeyAuth_Invalid")
			{
				MessageBox.Show("Application not found.");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (response_structure.success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
				return;
			}
			if (response_structure.message == "invalidver")
			{
				Process.Start(response_structure.download);
				Environment.Exit(0);
				return;
			}
			MessageBox.Show(response_structure.message);
			Environment.Exit(0);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00024934 File Offset: 0x00024934
		public bool register(string username, string pass, string key)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				return false;
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
				return false;
			}
			this.load_user_data(response_structure.info);
			return true;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00024AA8 File Offset: 0x00024AA8
		public bool login(string username, string pass)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				return false;
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
				return false;
			}
			this.load_user_data(response_structure.info);
			return true;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00024C04 File Offset: 0x00024C04
		public void upgrade(string username, string key)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				return;
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
				Environment.Exit(0);
				return;
			}
			MessageBox.Show(response_structure.message);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00024D48 File Offset: 0x00024D48
		public bool UseLicense(string key)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				return false;
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
				Environment.Exit(0);
				return false;
			}
			this.load_user_data(response_structure.info);
			return true;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00024E90 File Offset: 0x00024E90
		public void ban()
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				return;
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00024F88 File Offset: 0x00024F88
		public string var(string varid)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				return "";
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
				return "";
			}
			return response_structure.message;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000250B4 File Offset: 0x000250B4
		public void webhook(string webid, string param)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				return;
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000251E8 File Offset: 0x000251E8
		public byte[] download(string fileid)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				return new byte[0];
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				MessageBox.Show(response_structure.message);
			}
			return encryption.str_to_byte_arr(response_structure.contents);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00025304 File Offset: 0x00025304
		public void log(string message)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				return;
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			api.req(nameValueCollection);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000253FC File Offset: 0x000253FC
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.business/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch
			{
				MessageBox.Show("Connection failure. Please try again, or contact us for help.");
				Thread.Sleep(500);
				Environment.Exit(0);
				result = "nothing";
			}
			return result;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00025478 File Offset: 0x00025478
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x0400042C RID: 1068
		public string name;

		// Token: 0x0400042D RID: 1069
		public string ownerid;

		// Token: 0x0400042E RID: 1070
		public string secret;

		// Token: 0x0400042F RID: 1071
		public string version;

		// Token: 0x04000430 RID: 1072
		private string sessionid;

		// Token: 0x04000431 RID: 1073
		private string enckey;

		// Token: 0x04000432 RID: 1074
		private bool initzalized;

		// Token: 0x04000433 RID: 1075
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000434 RID: 1076
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x020000A7 RID: 167
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060003DD RID: 989 RVA: 0x000254AD File Offset: 0x000254AD
			// (set) Token: 0x060003DE RID: 990 RVA: 0x000254B5 File Offset: 0x000254B5
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060003DF RID: 991 RVA: 0x000254BE File Offset: 0x000254BE
			// (set) Token: 0x060003E0 RID: 992 RVA: 0x000254C6 File Offset: 0x000254C6
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x000254CF File Offset: 0x000254CF
			// (set) Token: 0x060003E2 RID: 994 RVA: 0x000254D7 File Offset: 0x000254D7
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x000254E0 File Offset: 0x000254E0
			// (set) Token: 0x060003E4 RID: 996 RVA: 0x000254E8 File Offset: 0x000254E8
			[DataMember]
			public string response { get; set; }

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060003E5 RID: 997 RVA: 0x000254F1 File Offset: 0x000254F1
			// (set) Token: 0x060003E6 RID: 998 RVA: 0x000254F9 File Offset: 0x000254F9
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060003E7 RID: 999 RVA: 0x00025502 File Offset: 0x00025502
			// (set) Token: 0x060003E8 RID: 1000 RVA: 0x0002550A File Offset: 0x0002550A
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00025513 File Offset: 0x00025513
			// (set) Token: 0x060003EA RID: 1002 RVA: 0x0002551B File Offset: 0x0002551B
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }
		}

		// Token: 0x020000A8 RID: 168
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x00025524 File Offset: 0x00025524
			// (set) Token: 0x060003ED RID: 1005 RVA: 0x0002552C File Offset: 0x0002552C
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060003EE RID: 1006 RVA: 0x00025535 File Offset: 0x00025535
			// (set) Token: 0x060003EF RID: 1007 RVA: 0x0002553D File Offset: 0x0002553D
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00025546 File Offset: 0x00025546
			// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0002554E File Offset: 0x0002554E
			[DataMember]
			public string ip { get; set; }
		}

		// Token: 0x020000A9 RID: 169
		public class user_data_class
		{
			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00025557 File Offset: 0x00025557
			// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0002555F File Offset: 0x0002555F
			public string username { get; set; }

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00025568 File Offset: 0x00025568
			// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00025570 File Offset: 0x00025570
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00025579 File Offset: 0x00025579
			// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00025581 File Offset: 0x00025581
			public string ip { get; set; }
		}

		// Token: 0x020000AA RID: 170
		public class Data
		{
			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060003FA RID: 1018 RVA: 0x0002558A File Offset: 0x0002558A
			// (set) Token: 0x060003FB RID: 1019 RVA: 0x00025592 File Offset: 0x00025592
			public string subscription { get; set; }

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060003FC RID: 1020 RVA: 0x0002559B File Offset: 0x0002559B
			// (set) Token: 0x060003FD RID: 1021 RVA: 0x000255A3 File Offset: 0x000255A3
			public string expiry { get; set; }
		}
	}
}
