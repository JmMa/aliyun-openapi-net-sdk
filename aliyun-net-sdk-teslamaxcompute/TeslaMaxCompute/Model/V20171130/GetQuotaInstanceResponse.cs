/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Model.V20171130
{
	public class GetQuotaInstanceResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetQuotaInstance_Data data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public GetQuotaInstance_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetQuotaInstance_Data
		{

			private int? total;

			private List<GetQuotaInstance_Instance> detail;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<GetQuotaInstance_Instance> Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public class GetQuotaInstance_Instance
			{

				private string project;

				private string instanceId;

				private string status;

				private string userAccount;

				private string nickName;

				private string cluster;

				private string runTime;

				private int? cpuUsed;

				private int? cpuRequest;

				private int? cpuUsedTotal;

				private float? cpuUsedRatioMax;

				private float? cpuUsedRatioMin;

				private int? memUsed;

				private int? memRequest;

				private int? memUsedTotal;

				private float? memUsedRatioMax;

				private float? memUsedRatioMin;

				private string taskType;

				private string skynetId;

				public string Project
				{
					get
					{
						return project;
					}
					set	
					{
						project = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string UserAccount
				{
					get
					{
						return userAccount;
					}
					set	
					{
						userAccount = value;
					}
				}

				public string NickName
				{
					get
					{
						return nickName;
					}
					set	
					{
						nickName = value;
					}
				}

				public string Cluster
				{
					get
					{
						return cluster;
					}
					set	
					{
						cluster = value;
					}
				}

				public string RunTime
				{
					get
					{
						return runTime;
					}
					set	
					{
						runTime = value;
					}
				}

				public int? CpuUsed
				{
					get
					{
						return cpuUsed;
					}
					set	
					{
						cpuUsed = value;
					}
				}

				public int? CpuRequest
				{
					get
					{
						return cpuRequest;
					}
					set	
					{
						cpuRequest = value;
					}
				}

				public int? CpuUsedTotal
				{
					get
					{
						return cpuUsedTotal;
					}
					set	
					{
						cpuUsedTotal = value;
					}
				}

				public float? CpuUsedRatioMax
				{
					get
					{
						return cpuUsedRatioMax;
					}
					set	
					{
						cpuUsedRatioMax = value;
					}
				}

				public float? CpuUsedRatioMin
				{
					get
					{
						return cpuUsedRatioMin;
					}
					set	
					{
						cpuUsedRatioMin = value;
					}
				}

				public int? MemUsed
				{
					get
					{
						return memUsed;
					}
					set	
					{
						memUsed = value;
					}
				}

				public int? MemRequest
				{
					get
					{
						return memRequest;
					}
					set	
					{
						memRequest = value;
					}
				}

				public int? MemUsedTotal
				{
					get
					{
						return memUsedTotal;
					}
					set	
					{
						memUsedTotal = value;
					}
				}

				public float? MemUsedRatioMax
				{
					get
					{
						return memUsedRatioMax;
					}
					set	
					{
						memUsedRatioMax = value;
					}
				}

				public float? MemUsedRatioMin
				{
					get
					{
						return memUsedRatioMin;
					}
					set	
					{
						memUsedRatioMin = value;
					}
				}

				public string TaskType
				{
					get
					{
						return taskType;
					}
					set	
					{
						taskType = value;
					}
				}

				public string SkynetId
				{
					get
					{
						return skynetId;
					}
					set	
					{
						skynetId = value;
					}
				}
			}
		}
	}
}