﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Projectile : Entity
    {
        private Sprite _projectile;
        private AABB _box;
        private int _num;

        public Projectile(float x, float y, int num) : base(x, y)
        {
            _bullet = new Sprite("Bullet-Transparent-Background.png");
            _box = new AABB(25, 25);
            _num = num;


            AddChild(_bullet);
            AddChild(_box);
        }
    }
}