﻿using Entities.User;
using WebFramework.Api;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyApi.Models
{
    public class FollowerDto : BaseDto<FollowerDto, Follower>
    {
        public string FollowerFullName { get; set; }
        public int FollowerId { get; set; }
    }

    public class FollowerSelectDto : BaseDto<FollowerSelectDto, Follower>
    {
        [JsonIgnore]
        public override int Id { get; set; }

        [Required]
        public int FollowerId { get; set; }

        protected internal int UserId { get; set; }
    }
}