﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IColorService {
        public List<Color> GetAll();
        public List<Color> GetByColorId(int colorId);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
