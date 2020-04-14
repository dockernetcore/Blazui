using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazui.Component
{
    public class BCarouselBase : BComponentBase
    {
        public List<string> Item { get; set; } = new List<string>();

        public ElCarousel Active { get; set; } = new ElCarousel()
        {
            Class = "el-carousel__item is-active is-animating",
            Style = "transform: translateX(0px) scale(1);",
            UlClass = "el-carousel__indicator el-carousel__indicator--horizontal is-active"
        };

        public ElCarousel Animating { get; set; } = new ElCarousel()
        { 
            Class = "el-carousel__item is-animating",
            Style = "transform: translateX(-278px) scale(1);",
            UlClass = "el-carousel__indicator el-carousel__indicator--horizontal"
        };

        public ElCarousel Carousel { get; set; } = new ElCarousel()
        { 
            Class = "el-carousel__item",
            Style = "transform: translateX(834px) scale(1);",
            UlClass = "el-carousel__indicator el-carousel__indicator--horizontal"
        };

        internal List<HtmlPropertyBuilder> cssClassBuilderList;

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            Item.Add("1");
            Item.Add("2");
            Item.Add("3");
            Item.Add("4");
        }
    }

    public class ElCarousel
    {
        public string Class { get; set; }

        public string Style { get; set; }

        public string UlClass { get; set; }
    }
}
