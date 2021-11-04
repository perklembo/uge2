using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

    namespace MuseumTemplate.Models
    {
        public class Booking
        {
            public int ID { get; set; }

            [DataType(DataType.DateTime)]
            public DateTime Time { get; set; }

            public int ParticipantCount { get; set; }

            public string GroupName { get; set; }
        }
    }
