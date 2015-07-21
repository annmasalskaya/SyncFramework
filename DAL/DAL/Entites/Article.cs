﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SF.Entites;

namespace DAL.Entites
{
    public class Article: AuditableEntity
    {

        public string Title { get; set; }

        public string Body { get; set; }
        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User Author { get; set; }
    }
}
