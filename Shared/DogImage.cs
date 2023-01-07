﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutDogs.Shared
{
    public class DogImage
    {
        public string ID { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public DogImage(string id, string url, int width, int height)
        {
            this.ID = id;
            this.url = url;
            this.width = width;
            this.height = height;
        }
    }
}
