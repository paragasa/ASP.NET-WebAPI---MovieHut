﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieHut.Models;

namespace MovieHut.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18YearsAndMember]
        public DateTime? BirthDate { get; set; }
    }
}