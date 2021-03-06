﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5173BookStore.Entities.Entity
{
    public enum Status
    {
        //Biz değer vermesekte kendi index mantığı vardı
        Active=1,
        Modified=2,
        Passive=3
    }

    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate 
        {
            get { return _createDate; }
            set { _createDate = value; }
        }


        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status 
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
