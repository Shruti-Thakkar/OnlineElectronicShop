﻿namespace OnlineElectronicShop.ViewModel
{
    public class Pager
    {
        
        public int TotalItems { get; private set; }
        public int CurrentPages { get; private set;}
        public int PageSize { get; private set; }
        public int TotalPages { get; private set; }
        public int StartPage { get; private set; }
        public int EndPage { get; private set;}

        public Pager()
        {

        }
        public Pager( int totalItems , int page , int pageSize =10)
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems /(decimal)pageSize);
            int currentPage = page;
            int startPage = currentPage-4;
            int endPage = currentPage+5;
            if (startPage <= 0  )
            {
                endPage = endPage-(StartPage-1);
                startPage = 1;
            
            }
            if (endPage > totalPages ) 
            {
                endPage = totalPages;
                if (endPage > 10)
                {
                    startPage = endPage-9;
                }

            }
            TotalItems = totalItems;
            CurrentPages = currentPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;


            
        }

    }
}
