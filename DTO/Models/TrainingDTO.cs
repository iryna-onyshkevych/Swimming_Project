﻿using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DTO.Models
{
    public partial class TrainingDTO
    {
        [Required(ErrorMessage = "Id is invalid!")]

        public int Id { get; set; }
        [Required(ErrorMessage = "Swimmer Id is invalid!")]

        public int SwimmerId { get; set; }
        [Required(ErrorMessage = "SwimStyle Id is invalid!")]

        public int SwimStyleId { get; set; }
        [Required(ErrorMessage = "Training date is invalid!")]

        public DateTime TrainingDate { get; set; }

        [Required(ErrorMessage = "Distance is invalid!")]

        public int Distance { get; set; }

        public virtual SwimStyleDTO SwimStyle { get; set; }
        public virtual SwimmerDTO Swimmer { get; set; }
    }
}
