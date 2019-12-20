using System;

namespace PrismSample.Pages
{
    public class MyMasterPageMasterMenuItem
    {
        public MyMasterPageMasterMenuItem()
        {
            TargetType = typeof(MyMasterPageMasterMenuItem);
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}