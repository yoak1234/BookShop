using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class AddProductViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImageUpload { get; set; }
        public string Detail { get; set; }
        public int Balance { get; set; }
        public double Price { get; set; }
        public string Isbn { get; set; }
        public int CategoryId { get; set; }
        public int CreateBy { get; set; }
        public DateTime? CreateAt { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsActive { get; set; }
        public bool IsRecommend { get; set; }
    }
}