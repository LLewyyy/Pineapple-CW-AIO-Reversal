using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace RAW.Auth
{
	// Token: 0x020000AC RID: 172
	public class json_wrapper
	{
		// Token: 0x06000407 RID: 1031 RVA: 0x00025897 File Offset: 0x00025897
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000258B4 File Offset: 0x000258B4
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00025904 File Offset: 0x00025904
		public object string_to_object(string json)
		{
			object result;
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(json)))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0002594C File Offset: 0x0002594C
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000444 RID: 1092
		private DataContractJsonSerializer serializer;

		// Token: 0x04000445 RID: 1093
		private object current_object;
	}
}
