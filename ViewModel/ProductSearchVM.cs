using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace _23DH112365_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        //Tiêu chí để search theo tên, mô tả sp
        //Hoặc loại sp
        public string SearchTerm { get; set; }

        //Các tiêu chí để search theo giá
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        //Thứ tự sắp xếp
        public string SortOrder { get; set; }

        //Các thuộc tính hỗ trợ phân trang
        public int PageNumber {  get; set; }   //trang hiện tại
        public int PageSize { get; set; } = 10; //số sản phẩm mỗi trang 

        ////danh sách sp thỏa điều kiện tìm kiếm
        //public PagedList.IPagedList<Product> Products { get; set; }

        //danh sách sp thỏa điều kiện tìm kiếm
        public List<Product> Products { get; set; }
    }
}