using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace _23DH112365_MyStore.Models.ViewModel
{
    public class HomeProductVM
    {
        //Tiêu chí để search theo tên, mô tả sản phẩm
        // hoặc loại sản phẩm
        public string SearchTerm { get; set; }

        // Các thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; } // trang hiện tại
        public int PageSize { get; set; } = 10;// Số sp mỗi trang

        //danh sách sp nổi bật
        public List<Product>FeaturedProducts { get; set; }

        //Danh sách Sản phẩm mới đã phân trang
        public PagedList.IPagedList<Product> NewProducts { get; set; }
    }
}