using Skeleton.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Models.DTO
{
    public class HomeViewModel
    {
        [Required]
        public int HomeId { get; set; }
        public string HomeText { get; set; }

        public static HomeViewModel ToViewModel(Home model)
        {
            return new HomeViewModel
            {
                HomeId = model.HomeId,
                HomeText = model?.HomeText
            };
        }

        public Home ToModel()
        {
            return new Home
            {
                HomeId = this.HomeId,
                HomeText = this.HomeText
            };
        }
    }



}

