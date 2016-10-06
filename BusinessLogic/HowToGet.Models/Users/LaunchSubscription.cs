﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HowToGet.Models.Users
{
	public class LaunchSubscription
	{
		[BsonId]
		public ObjectId Id { get; set; }

		[BsonElement("email")]
		public string Email { get; set; }

		[BsonElement("lemail")]
		public string LowerCaseEmail { get; set; }

		[BsonIgnoreIfNull]
		public DateTime Time { get; set; }

		[BsonIgnoreIfNull]
		public string Referrer { get; set; }

		[BsonIgnoreIfNull]
		public string Ip { get; set; }
	}
}