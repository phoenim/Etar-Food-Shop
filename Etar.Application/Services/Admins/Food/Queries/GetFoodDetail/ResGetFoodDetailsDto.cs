﻿namespace Etar.Application.Services.Admins.Food.Queries.GetFoodDetail
{
    public class ResGetFoodDetailsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
