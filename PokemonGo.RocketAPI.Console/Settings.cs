﻿using System.Configuration;
using PokemonGo.RocketAPI.Enums;
using PokemonGo.RocketAPI.GeneratedCode;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using AllEnum;

namespace PokemonGo.RocketAPI.Console
{
    public class Settings : ISettings
    {
        public AuthType AuthType => (AuthType)Enum.Parse(typeof(AuthType), UserSettings.Default.AuthType);
        public string PtcUsername => UserSettings.Default.PtcUsername;
        public string PtcPassword => UserSettings.Default.PtcPassword;
        public double DefaultLatitude => UserSettings.Default.DefaultLatitude;
        public double DefaultLongitude => UserSettings.Default.DefaultLongitude;
        public double DefaultAltitude => UserSettings.Default.DefaultAltitude;

        ICollection<KeyValuePair<ItemId, int>> ISettings.itemRecycleFilter
        {
            get
            {
                //Type and amount to keep
                return new[]
                {
                    new KeyValuePair<ItemId, int>(ItemId.ItemUnknown, 0),
                    new KeyValuePair<ItemId, int>(ItemId.ItemPokeBall, 300),
                    new KeyValuePair<ItemId, int>(ItemId.ItemGreatBall, 30),
                    new KeyValuePair<ItemId, int>(ItemId.ItemUltraBall, 50),
                    new KeyValuePair<ItemId, int>(ItemId.ItemMasterBall, 100),

                    new KeyValuePair<ItemId, int>(ItemId.ItemPotion, 10),
                    new KeyValuePair<ItemId, int>(ItemId.ItemSuperPotion, 50),
                    new KeyValuePair<ItemId, int>(ItemId.ItemHyperPotion, 50),
                    new KeyValuePair<ItemId, int>(ItemId.ItemMaxPotion, 50),

                    new KeyValuePair<ItemId, int>(ItemId.ItemRevive, 50),
                    new KeyValuePair<ItemId, int>(ItemId.ItemMaxRevive, 50),

                     new KeyValuePair<ItemId, int>(ItemId.ItemLuckyEgg, 200),

                     new KeyValuePair<ItemId, int>(ItemId.ItemIncenseOrdinary, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemIncenseSpicy, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemIncenseCool, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemIncenseFloral, 100),

                     new KeyValuePair<ItemId, int>(ItemId.ItemTroyDisk, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemXAttack, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemXDefense, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemXMiracle, 100),

                     new KeyValuePair<ItemId, int>(ItemId.ItemRazzBerry, 10),
                     new KeyValuePair<ItemId, int>(ItemId.ItemBlukBerry, 10),
                     new KeyValuePair<ItemId, int>(ItemId.ItemNanabBerry, 10),
                     new KeyValuePair<ItemId, int>(ItemId.ItemWeparBerry, 30),
                     new KeyValuePair<ItemId, int>(ItemId.ItemPinapBerry, 30),

                     new KeyValuePair<ItemId, int>(ItemId.ItemSpecialCamera, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemIncubatorBasicUnlimited, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemIncubatorBasic, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemPokemonStorageUpgrade, 100),
                     new KeyValuePair<ItemId, int>(ItemId.ItemItemStorageUpgrade, 100),
                };
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string GoogleRefreshToken
        {
            get { return UserSettings.Default.GoogleRefreshToken; }
            set
            {
                UserSettings.Default.GoogleRefreshToken = value;
                UserSettings.Default.Save();
            }
        }
    }
}
