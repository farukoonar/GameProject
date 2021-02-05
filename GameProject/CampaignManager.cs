﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+ " eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " güncellendi.");
        }
    }
}
