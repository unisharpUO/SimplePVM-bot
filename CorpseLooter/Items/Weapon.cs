﻿using System;
using System.Xml.Serialization;
using XScript.Items;

namespace CorpseLooter
{

    public class Weapon
    {
        #region Vars
        private uint _id;
        private uint _containerId;
        private string _itemName;
        private bool _brittle;

        private string _hitSpell;
        private string _hitLeech;
        private string _hitArea;
        private sbyte _splintering;

        private bool _balanced;
        private sbyte _velocity;
        private bool _bloodDrinker;
        private bool _battleLust;

        private bool _ubws;
        private int _mageWeapon;
        private bool _sc;

        private string _abilities;
        private string _primaryAbility;
        private string _secondaryAbility;
        private string _weaponType;
        private string _skillType;

        private string _elementalDamage;

        private sbyte _hla;
        private sbyte _hld;

        private sbyte _str;
        private sbyte _intel;
        private sbyte _dex;
        private sbyte _hp;
        private sbyte _mana;
        private sbyte _stam;

        private sbyte _hpRegen;
        private sbyte _manaRegen;
        private sbyte _stamRegen;

        private sbyte _di;
        private sbyte _ssi;
        private sbyte _sdi;
        private sbyte _fc;
        private sbyte _fcr;
        private sbyte _dci;
        private sbyte _hci;
        private short _luck;
        private sbyte _enhancePotions;
        private sbyte _rpd;

        private DateTime _added;
        #endregion

        #region Properties
        public uint ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public uint ContainerID
        {
            get { return _containerId; }
            set { _containerId = value; }
        }
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        public bool Brittle
        {
            get { return _brittle; }
            set { _brittle = value; }
        }
        public string HitSpell
        {
            get { return _hitSpell; }
            set { _hitSpell = value; }
        }

        public string HitLeech
        {
            get { return _hitLeech; }
            set { _hitLeech = value; }
        }
        public string HitArea
        {
            get { return _hitArea; }
            set { _hitArea = value; }
        }
        public sbyte Splintering
        {
            get { return _splintering; }
            set { _splintering = value; }
        }
        public bool Balanced
        {
            get { return _balanced; }
            set { _balanced = value; }
        }
        public sbyte Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }
        public bool BloodDrinker
        {
            get { return _bloodDrinker; }
            set { _bloodDrinker = value; }
        }
        public bool BattleLust
        {
            get { return _battleLust; }
            set { _battleLust = value; }
        }
        public bool UBWS
        {
            get { return _ubws; }
            set { _ubws = value; }
        }
        public int MageWeapon
        {
            get { return _mageWeapon; }
            set { _mageWeapon = value; }
        }
        public bool SC
        {
            get { return _sc; }
            set { _sc = value; }
        }
        public string ElementalDamage
        {
            get { return _elementalDamage; }
            set { _elementalDamage = value; }
        }
        public sbyte HLA
        {
            get { return _hla; }
            set { _hla = value; }
        }
        public sbyte HLD
        {
            get { return _hld; }
            set { _hld = value; }
        }

        public string Abilities
        {
            get { return _abilities; }
            set { _abilities = value; }
        }

        public string PrimaryAbility
        {
            get { return _primaryAbility; }
            set { _primaryAbility = value; }
        }
        public string SecondaryAbility
        {
            get { return _secondaryAbility; }
            set { _secondaryAbility = value; }
        }

        public string WeaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; }
        }
        public string SkillType
        {
            get { return _skillType; }
            set { _skillType = value; }
        }

        public sbyte STR
        {
            get { return _str; }
            set { _str = value; }
        }
        public sbyte INTEL
        {
            get { return _intel; }
            set { _intel = value; }
        }
        public sbyte DEX
        {
            get { return _dex; }
            set { _dex = value; }
        }
        public sbyte HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public sbyte Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }
        public sbyte Stam
        {
            get { return _stam; }
            set { _stam = value; }
        }
        public sbyte HPRegen
        {
            get { return _hpRegen; }
            set { _hpRegen = value; }
        }
        public sbyte ManaRegen
        {
            get { return _manaRegen; }
            set { _manaRegen = value; }
        }
        public sbyte StamRegen
        {
            get { return _stamRegen; }
            set { _stamRegen = value; }
        }
        public sbyte DI
        {
            get { return _di; }
            set { _di = value; }
        }
        public sbyte SSI
        {
            get { return _ssi; }
            set { _ssi = value; }
        }
        public sbyte FC
        {
            get { return _fc; }
            set { _fc = value; }
        }
        public sbyte FCR
        {
            get { return _fcr; }
            set { _fcr = value; }
        }
        public sbyte SDI
        {
            get { return _sdi; }
            set { _sdi = value; }
        }
        public sbyte DCI
        {
            get { return _dci; }
            set { _dci = value; }
        }
        public sbyte HCI
        {
            get { return _hci; }
            set { _hci = value; }
        }
        public short Luck
        {
            get { return _luck; }
            set { _luck = value; }
        }
        public sbyte EnhancePotions
        {
            get { return _enhancePotions; }
            set { _enhancePotions = value; }
        }
        public sbyte RPD
        {
            get { return _rpd; }
            set { _rpd = value; }
        }
        [XmlIgnore]
        public DateTime Added
        {
            get { return _added; }
            set { _added = value; }
        }
        [XmlElement("Added")]
        public string DateAdded
        {
            get { return this.Added.ToString("yyyy-MM-dd HH:mm:ss"); }
            set { this.Added = DateTime.Parse(value); }
        }
        #endregion

        #region Constructors
        public Weapon()
        {
        }

        public Weapon(BaseWeapon Item, uint ContainerID)
        {
            Item.UpdateLocalizedProperties();
            Item.UpdateTextProperties();

            //General
            ID = Item.Serial.Value;
            this.ContainerID = ContainerID;
            ItemName = Item.Tooltip.Split('|')[0];
            Splintering = (sbyte)Item.WeaponAttributes.SplinteringWeapon;
            HLA = (sbyte)Item.WeaponAttributes.HitLowerAttack;
            HLD = (sbyte)Item.WeaponAttributes.HitLowerDefend;
            SC = Item.Attributes.SpellChanneling;
            Balanced = Item.WeaponAttributes.Balanced;
            UBWS = Item.WeaponAttributes.UseBestSkill;
            MageWeapon = Item.WeaponAttributes.MageWeapon * -1;
            BloodDrinker = Item.WeaponAttributes.BloodDrinker;
            Velocity = (sbyte)Item.WeaponAttributes.Velocity;
            BattleLust = Item.WeaponAttributes.BattleLust;
            DI = (sbyte)Item.Attributes.WeaponDamage;
            SSI = (sbyte)Item.Attributes.WeaponSpeed;
            FC = (sbyte)Item.Attributes.CastSpeed;
            FCR = (sbyte)Item.Attributes.CastRecovery;
            SDI = (sbyte)Item.Attributes.SpellDamage;
            RPD = (sbyte)Item.Attributes.ReflectPhysical;
            DCI = (sbyte)Item.Attributes.DefendChance;
            HCI = (sbyte)Item.Attributes.AttackChance;
            STR = (sbyte)Item.Attributes.BonusStr;
            DEX = (sbyte)Item.Attributes.BonusDex;
            INTEL = (sbyte)Item.Attributes.BonusInt;
            HP = (sbyte)Item.Attributes.BonusHits;
            Stam = (sbyte)Item.Attributes.BonusStam;
            Mana = (sbyte)Item.Attributes.BonusMana;
            HPRegen = (sbyte)Item.Attributes.RegenHits;
            StamRegen = (sbyte)Item.Attributes.RegenStam;
            ManaRegen = (sbyte)Item.Attributes.RegenMana;
            EnhancePotions = (sbyte)Item.Attributes.EnhancePotions;
            Luck = (short)Item.Attributes.Luck;
            Brittle = Item.Brittle;
            PrimaryAbility = Item.PrimaryAbility.ToString();
            SecondaryAbility = Item.SecondaryAbility.ToString();
            Abilities = PrimaryAbility + " " + SecondaryAbility;
            SkillType = Item.RequiredSkill.ToString();
            WeaponType = "none";
            HitSpell = "none";
            HitArea = "none";

            Added = DateTime.Now;

            //Hit Spell
            HitSpell = "";
            if (Item.WeaponAttributes.HitFatigue > 0)
                HitSpell += Item.WeaponAttributes.HitFatigue + " Hit Fatigue ";
            if (Item.WeaponAttributes.HitHarm > 0)
                HitSpell += Item.WeaponAttributes.HitHarm + " Hit Harm ";
            if (Item.WeaponAttributes.HitDispel > 0)
                HitSpell += Item.WeaponAttributes.HitDispel + " Hit Dispel ";
            if (Item.WeaponAttributes.HitLightning > 0)
                HitSpell += Item.WeaponAttributes.HitLightning + " Hit Lightning ";
            if (Item.WeaponAttributes.HitFireball > 0)
                HitSpell += Item.WeaponAttributes.HitFireball + " Hit Fireball ";
            if (Item.WeaponAttributes.HitMagicArrow > 0)
                HitSpell += Item.WeaponAttributes.HitMagicArrow + " Hit Magic Arrow ";

            //Hit Area
            HitArea = "";
            if (Item.WeaponAttributes.HitFireArea > 0)
                HitArea = Item.WeaponAttributes.HitFireArea + " Hit Fire Area";
            if (Item.WeaponAttributes.HitColdArea > 0)
                HitArea = Item.WeaponAttributes.HitColdArea + " Hit Cold Area";
            if (Item.WeaponAttributes.HitPoisonArea > 0)
                HitArea = Item.WeaponAttributes.HitPoisonArea + " Hit Poison Area";
            if (Item.WeaponAttributes.HitEnergyArea > 0)
                HitArea = Item.WeaponAttributes.HitEnergyArea + " Hit Energy Area";


        }
        #endregion
    }
}
