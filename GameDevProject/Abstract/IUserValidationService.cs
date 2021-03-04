using GameDevProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Abstract
{
    interface IUserValidationService
    {
        public bool Validate(Gamer gamer);

    }
}
