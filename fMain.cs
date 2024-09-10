// Circle World Creator
// Copyright 1999-2004 Alan K. Miles <silvertower@comcast.net>
// Licensed under Version 2 of the GNU Public License
// See 'License.txt' for more details.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace Circle_World_Creator
{
	/// <summary>
	/// Summary description for fMain.
	/// </summary>
	public class fMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mmMain;
		private System.Windows.Forms.MenuItem miFile;
		private System.Windows.Forms.MenuItem miFileExit;
		private System.Windows.Forms.StatusBar sbMain;
		private System.Windows.Forms.TabControl tcEditors;
		private System.Windows.Forms.TabPage tpMobileEditor;
		private System.Windows.Forms.TabPage tpObjectEditor;
		private System.Windows.Forms.TabPage tpRoomEditor;
		private System.Windows.Forms.TabPage tpShopEditor;
		private System.Windows.Forms.TabPage tpZoneEditor;
		private System.Windows.Forms.GroupBox gbMobVNum;
		private System.Windows.Forms.GroupBox gbMobAliasList;
		private System.Windows.Forms.TextBox tbMobAliasList;
		private System.Windows.Forms.MenuItem miHelp;
		private System.Windows.Forms.MenuItem miHelpAbout;
		private System.Windows.Forms.GroupBox gbMobActionBitvector;
		private System.Windows.Forms.CheckedListBox clboxMobActionBitvector;
		private System.Windows.Forms.GroupBox gbMobAffectionBitvector;
		private System.Windows.Forms.CheckedListBox clboxMobAffectionBitvector;
		private System.Windows.Forms.GroupBox gbMobAlignment;
		private System.Windows.Forms.NumericUpDown nudMobAlignment;
		private System.Windows.Forms.GroupBox gbMobLevel;
		private System.Windows.Forms.NumericUpDown nudMobLevel;
		private System.Windows.Forms.GroupBox gbMobThaco;
		private System.Windows.Forms.NumericUpDown nudMobThaco;
		private System.Windows.Forms.GroupBox gbMobGold;
		private System.Windows.Forms.NumericUpDown nudMobGold;
		private System.Windows.Forms.GroupBox gbMobExperience;
		private System.Windows.Forms.GroupBox gbMobLoadPosition;
		private System.Windows.Forms.ComboBox cboxMobLoadPosition;
		private System.Windows.Forms.GroupBox gbMobDefaultPosition;
		private System.Windows.Forms.ComboBox cboxMobDefaultPosition;
		private System.Windows.Forms.GroupBox gbMobGender;
		private System.Windows.Forms.ComboBox cboxMobGender;
		private System.Windows.Forms.GroupBox gbMobQuickSelect;
		private System.Windows.Forms.ComboBox cboxMobQuickSelect;
		private System.Windows.Forms.Button bMobNew;
		private System.Windows.Forms.Button bMobESpecs;
		private System.Windows.Forms.Button bMobCopy;
		private System.Windows.Forms.Button bMobMove;
		private System.Windows.Forms.Button bMobSave;
		private System.Windows.Forms.MenuItem miFileOpen;
		private System.Windows.Forms.MenuItem miFileClose;
		private System.Windows.Forms.MenuItem miFileNew;
		private System.Windows.Forms.MenuItem miEdit;
		private System.Windows.Forms.MenuItem miFileSep1;
		private System.Windows.Forms.MenuItem miFileSave;
		private System.Windows.Forms.MenuItem miFileSep2;
		private System.Windows.Forms.TextBox tbMobShortDescription;
		private System.Windows.Forms.TextBox tbMobLongDescription;
		private System.Windows.Forms.TextBox tbMobDetailedDescription;
		private System.Windows.Forms.NumericUpDown nudMobHPAdd;
		private System.Windows.Forms.NumericUpDown nudMobHPDie;
		private System.Windows.Forms.NumericUpDown nudMobHPNum;
		private System.Windows.Forms.NumericUpDown nudMobBHAdd;
		private System.Windows.Forms.NumericUpDown nudMobBHDie;
		private System.Windows.Forms.NumericUpDown nudMobBHNum;
		private System.Windows.Forms.NumericUpDown nudMobExperience;
		private System.Windows.Forms.Button bObjSave;
		private System.Windows.Forms.Button bObjMove;
		private System.Windows.Forms.Button bObjCopy;
		private System.Windows.Forms.GroupBox gbObjQuickSelect;
		private System.Windows.Forms.ComboBox cboxObjQuickSelect;
		private System.Windows.Forms.GroupBox gbObjVNum;
		private System.Windows.Forms.GroupBox gbObjShortDescription;
		private System.Windows.Forms.TextBox tbObjShortDescription;
		private System.Windows.Forms.GroupBox gbObjLongDescription;
		private System.Windows.Forms.TextBox tbObjLongDescription;
		private System.Windows.Forms.GroupBox gbObjAliasList;
		private System.Windows.Forms.TextBox tbObjAliasList;
		private System.Windows.Forms.GroupBox gbObjActionDescription;
		private System.Windows.Forms.TextBox tbObjActionDescription;
		private System.Windows.Forms.Button bObjNew;
		private System.Windows.Forms.GroupBox gbObjTypeFlag;
		private System.Windows.Forms.ComboBox cboxObjTypeFlag;
		private System.Windows.Forms.GroupBox gbObjWearBitvector;
		private System.Windows.Forms.CheckedListBox clboxObjWearBitvector;
		private System.Windows.Forms.GroupBox gbObjEffectsBitvector;
		private System.Windows.Forms.CheckedListBox clboxObjEffectsBitvector;
		private System.Windows.Forms.GroupBox gbObjWeight;
		private System.Windows.Forms.NumericUpDown nudObjWeight;
		private System.Windows.Forms.GroupBox gbObjRentPerDay;
		private System.Windows.Forms.NumericUpDown nudObjRentPerDay;
		private System.Windows.Forms.GroupBox gbObjCost;
		private System.Windows.Forms.NumericUpDown nudObjCost;
		private System.Windows.Forms.Button bObjExtraDescriptions;
		private System.Windows.Forms.GroupBox gbObjValues;
		private System.Windows.Forms.NumericUpDown nudObjValue0;
		private System.Windows.Forms.GroupBox gbObjValue1;
		private System.Windows.Forms.NumericUpDown nudObjValue1;
		private System.Windows.Forms.GroupBox gbObjValue2;
		private System.Windows.Forms.NumericUpDown nudObjValue2;
		private System.Windows.Forms.GroupBox gbObjValue3;
		private System.Windows.Forms.NumericUpDown nudObjValue3;
		private System.Windows.Forms.ComboBox cboxObjValue1;
		private System.Windows.Forms.ComboBox cboxObjValue2;
		private System.Windows.Forms.ComboBox cboxObjValue3;
		private System.Windows.Forms.NumericUpDown nudMobVNum;
		private System.Windows.Forms.NumericUpDown nudObjVNum;
		private System.Windows.Forms.GroupBox gbWldRoomBitvector;
		private System.Windows.Forms.CheckedListBox clboxWldRoomBitvector;
		private System.Windows.Forms.Button bWldSave;
		private System.Windows.Forms.Button bWldMove;
		private System.Windows.Forms.Button bWldCopy;
		private System.Windows.Forms.ComboBox cboxWldQuickSelect;
		private System.Windows.Forms.GroupBox gbWldVNum;
		private System.Windows.Forms.NumericUpDown nudWldVNum;
		private System.Windows.Forms.GroupBox gbWldRoomName;
		private System.Windows.Forms.TextBox tbWldRoomName;
		private System.Windows.Forms.GroupBox gbWldRoomDescription;
		private System.Windows.Forms.TextBox tbWldRoomDescription;
		private System.Windows.Forms.Button bWldNew;
		private System.Windows.Forms.GroupBox gbWldSectorType;
		private System.Windows.Forms.ComboBox cboxWldSectorType;
		private System.Windows.Forms.Button bWldExtraDescriptions;
		private System.Windows.Forms.GroupBox gbMobHP;
		private System.Windows.Forms.GroupBox gbMobBH;
		private System.Windows.Forms.Label lMobHPDie;
		private System.Windows.Forms.Label lMobHPPlus;
		private System.Windows.Forms.Label lMobBHDie;
		private System.Windows.Forms.Label lMobBHPlus;
		private System.Windows.Forms.GroupBox gbShpShopInformation;
		private System.Windows.Forms.GroupBox gbShpOpenTime1;
		private System.Windows.Forms.NumericUpDown nudShpOpenTime1;
		private System.Windows.Forms.GroupBox gbShpCloseTime1;
		private System.Windows.Forms.NumericUpDown nudShpCloseTime1;
		private System.Windows.Forms.GroupBox gbShpOpenTime2;
		private System.Windows.Forms.NumericUpDown nudShpOpenTime2;
		private System.Windows.Forms.GroupBox gbShpCloseTime2;
		private System.Windows.Forms.NumericUpDown nudShpCloseTime2;
		private System.Windows.Forms.GroupBox gbShpBuyProfit;
		private System.Windows.Forms.NumericUpDown nudShpBuyProfit;
		private System.Windows.Forms.GroupBox gbShpSellProfit;
		private System.Windows.Forms.NumericUpDown nudShpSellProfit;
		private System.Windows.Forms.CheckBox cbShpAlwaysOpen;
		private System.Windows.Forms.GroupBox gbShpShopkeeper;
		private System.Windows.Forms.GroupBox gbShpShopkeeperTemper;
		private System.Windows.Forms.ComboBox cboxShpShopkeeperTemper;
		private System.Windows.Forms.GroupBox gbShpAreaMobile;
		private System.Windows.Forms.ComboBox cboxShpAreaMobile;
		private System.Windows.Forms.GroupBox gbShpMobileVNum;
		private System.Windows.Forms.NumericUpDown nudShpMobileVNum;
		private System.Windows.Forms.GroupBox gbShpShopRooms;
		private System.Windows.Forms.GroupBox gbShpAreaRoom;
		private System.Windows.Forms.ComboBox cboxShpAreaRoom;
		private System.Windows.Forms.GroupBox gbShpRoomVNum;
		private System.Windows.Forms.NumericUpDown nudShpRoomVNum;
		private System.Windows.Forms.Button bShpRemoveRoom;
		private System.Windows.Forms.Button bShpAddRoom;
		private System.Windows.Forms.ListBox lboxShpShopRooms;
		private System.Windows.Forms.GroupBox gbShpShopItems;
		private System.Windows.Forms.GroupBox gbShpAreaItem;
		private System.Windows.Forms.ComboBox cboxShpAreaItem;
		private System.Windows.Forms.GroupBox gbShpItemVNum;
		private System.Windows.Forms.NumericUpDown nudShpItemVNum;
		private System.Windows.Forms.Button bShpRemoveItem;
		private System.Windows.Forms.Button bShpAddItem;
		private System.Windows.Forms.ListBox lboxShpShopItems;
		private System.Windows.Forms.Button bShpSave;
		private System.Windows.Forms.Button bShpMove;
		private System.Windows.Forms.Button bShpCopy;
		private System.Windows.Forms.Button bShpShopkeeperMessages;
		private System.Windows.Forms.GroupBox gbShpQuickSelect;
		private System.Windows.Forms.ComboBox cboxShpQuickSelect;
		private System.Windows.Forms.GroupBox gbShpWillNotSellTo;
		private System.Windows.Forms.CheckedListBox clboxShpWillNotSellTo;
		private System.Windows.Forms.GroupBox gbShpBuyTypes;
		private System.Windows.Forms.CheckedListBox clboxShpBuyTypes;
		private System.Windows.Forms.GroupBox gbShpVNum;
		private System.Windows.Forms.NumericUpDown nudShpVNum;
		private System.Windows.Forms.Button bShpNew;
		private System.Windows.Forms.GroupBox gbZonZoneInformation;
		private System.Windows.Forms.GroupBox gbZonZoneName;
		private System.Windows.Forms.TextBox tbZonZoneName;
		private System.Windows.Forms.GroupBox gbZonResetMode;
		private System.Windows.Forms.ComboBox cboxZonResetMode;
		private System.Windows.Forms.GroupBox gbZonLifespan;
		private System.Windows.Forms.NumericUpDown nudZonLifespan;
		private System.Windows.Forms.GroupBox gbZonTopRoom;
		private System.Windows.Forms.NumericUpDown nudZonTopRoom;
		private System.Windows.Forms.GroupBox gbZonZoneCommand;
		private System.Windows.Forms.GroupBox gbZonCommandType;
		private System.Windows.Forms.ComboBox cboxZonCommandType;
		private System.Windows.Forms.GroupBox gbZonZoneCommands;
		private System.Windows.Forms.Button bZonInsert;
		private System.Windows.Forms.Button bZonRemove;
		private System.Windows.Forms.Button bZonAdd;
		private System.Windows.Forms.ListBox lboxZonZoneCommands;
		private System.Windows.Forms.GroupBox gbZonComment;
		private System.Windows.Forms.TextBox tbZonComment;
		private System.Windows.Forms.CheckBox cbZonIfFlag;
		private System.Windows.Forms.GroupBox gbShpShopBitvector;
		private System.Windows.Forms.CheckedListBox clboxShpShopBitvector;
		private System.Windows.Forms.GroupBox gbMobArmorClass;
		private System.Windows.Forms.NumericUpDown nudMobArmorClass;
		private System.Windows.Forms.ComboBox cboxObjValue0;
		private System.Windows.Forms.Button bObjAffects;
		private System.Windows.Forms.GroupBox gbObjValue0;
		private System.Windows.Forms.MenuItem miFileOpenObjectFile;
		private System.Windows.Forms.MenuItem miFileOpenWorldFile;
		private System.Windows.Forms.GroupBox gbWldDirections;
		private System.Windows.Forms.GroupBox gbWldCurrentExit;
		private System.Windows.Forms.CheckBox cbWldNowhere;
		private System.Windows.Forms.CheckBox cbWldExitExists;
		private System.Windows.Forms.Button bWldDoorDescription;
		private System.Windows.Forms.CheckBox cbWldNoKey;
		private System.Windows.Forms.GroupBox gbWldExits;
		private System.Windows.Forms.NumericUpDown nudWldWest;
		private System.Windows.Forms.RadioButton rbWldSouth;
		private System.Windows.Forms.RadioButton rbWldDown;
		private System.Windows.Forms.RadioButton rbWldUp;
		private System.Windows.Forms.RadioButton rbWldWest;
		private System.Windows.Forms.RadioButton rbWldEast;
		private System.Windows.Forms.NumericUpDown nudWldDown;
		private System.Windows.Forms.NumericUpDown nudWldEast;
		private System.Windows.Forms.NumericUpDown nudWldUp;
		private System.Windows.Forms.NumericUpDown nudWldSouth;
		private System.Windows.Forms.NumericUpDown nudWldNorth;
		private System.Windows.Forms.RadioButton rbWldNorth;
		private System.Windows.Forms.GroupBox gbWldDoorKey;
		private System.Windows.Forms.ComboBox cboxWldDoorFlag;
		private System.Windows.Forms.GroupBox gbWldDoorFlag;
		private System.Windows.Forms.ComboBox cboxWldAreaDoorKey;
		private System.Windows.Forms.NumericUpDown nudWldDoorKey;
		private System.Windows.Forms.MenuItem miFileOpenShopFile;
		private System.Windows.Forms.MenuItem miFileOpenZoneFile;
		private System.Windows.Forms.GroupBox gbZonBottomRoom;
		private System.Windows.Forms.NumericUpDown nudZonBottomRoom;
		private System.Windows.Forms.GroupBox gbZonArg2;
		private System.Windows.Forms.GroupBox gbZonArg1;
		private System.Windows.Forms.GroupBox gbZonArg0;
		private System.Windows.Forms.MenuItem miFileOpenSep0;
		private System.Windows.Forms.MenuItem miFileOpenArea;
		private System.Windows.Forms.NumericUpDown nudZonArg2;
		private System.Windows.Forms.NumericUpDown nudZonArg1;
		private System.Windows.Forms.NumericUpDown nudZonArg0;
		private System.Windows.Forms.Button bZonCommandDown;
		private System.Windows.Forms.Button bZonCommandUp;
		private System.Windows.Forms.MenuItem miFileSaveMobileFile;
		private System.Windows.Forms.MenuItem miFileSaveObjectFile;
		private System.Windows.Forms.MenuItem miFileSaveWorldFile;
		private System.Windows.Forms.MenuItem miFileSaveShopFile;
		private System.Windows.Forms.MenuItem miFileSaveZoneFile;
		private System.Windows.Forms.MenuItem miFileSaveSep0;
		private System.Windows.Forms.ComboBox cboxZonAreaArg2;
		private System.Windows.Forms.ComboBox cboxZonAreaArg1;
		private System.Windows.Forms.ComboBox cboxZonAreaArg0;
		private System.Windows.Forms.Button bMobDelete;
		private System.Windows.Forms.Button bObjDelete;
		private System.Windows.Forms.Button bWldDelete;
		private System.Windows.Forms.Button bShpDelete;
		private System.Windows.Forms.MenuItem miTools;
		private System.Windows.Forms.MenuItem miToolsOptions;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem miEditUndo;
		private System.Windows.Forms.MenuItem miEditRedo;
		private System.Windows.Forms.MenuItem miEditCut;
		private System.Windows.Forms.MenuItem miEditCopy;
		private System.Windows.Forms.MenuItem miEditPaste;
		private System.Windows.Forms.GroupBox gbMobShortDescription;
		private System.Windows.Forms.GroupBox gbMobLongDescription;
		private System.Windows.Forms.GroupBox gbMobDetailedDescription;
		private System.Windows.Forms.MenuItem miFileNewArea;
		private System.Windows.Forms.MenuItem miFileNewSep0;
		private System.Windows.Forms.MenuItem miFileNewMobileFile;
		private System.Windows.Forms.MenuItem miFileNewObjectFile;
		private System.Windows.Forms.MenuItem miFileNewWorldFile;
		private System.Windows.Forms.MenuItem miFileNewShopFile;
		private System.Windows.Forms.MenuItem miFileNewZoneFile;
		private System.Windows.Forms.MenuItem miFileCloseSep0;
		private System.Windows.Forms.MenuItem miFileCloseMobileFile;
		private System.Windows.Forms.MenuItem miFileCloseObjectFile;
		private System.Windows.Forms.MenuItem miFileCloseWorldFile;
		private System.Windows.Forms.MenuItem miFileCloseShopFile;
		private System.Windows.Forms.MenuItem miFileCloseZoneFile;
		private System.Windows.Forms.GroupBox gbWldQuickSelect;
		private System.Windows.Forms.GroupBox gbZonNumber;
		private System.Windows.Forms.NumericUpDown nudZonNumber;
		private System.Windows.Forms.MenuItem miFileOpenMobileFile;
		private System.Windows.Forms.MenuItem miFileCloseArea;
		private System.Windows.Forms.MenuItem miFileSaveArea;

		/// <summary>
		/// MUD Config. Data Structures
		/// </summary>
		public static StringCollection mobActions = new StringCollection();
		public static StringCollection mobAffections = new StringCollection();
		public static StringCollection mobPositions = new StringCollection();
		public static StringCollection mobGenders = new StringCollection();
		public static StringCollection mobAttackTypes = new StringCollection();
		public static StringCollection mobESpecTypes = new StringCollection();
		public static StringCollection objTypeFlags = new StringCollection();
		public static StringCollection objEffects = new StringCollection();
		public static StringCollection objWear = new StringCollection();
		public static StringCollection objAffects = new StringCollection();
		public static StringCollection objSpells = new StringCollection();
		public static StringCollection objLiquids = new StringCollection();
		public static StringCollection objWeaponTypes = new StringCollection();
		public static StringCollection objExtraDescriptions = new StringCollection();
		public static StringCollection wldBitvectors = new StringCollection();
		public static StringCollection wldSectorTypes = new StringCollection();
		public static StringCollection wldDoorFlags = new StringCollection();
		public static StringCollection shpBuyTypes = new StringCollection();
		public static StringCollection shpTempers = new StringCollection();
		public static StringCollection shpBitvectors = new StringCollection();
		public static StringCollection shpWillNotSellTo = new StringCollection();
		public static StringCollection zonResetModes = new StringCollection();
		public static StringCollection zonCommandTypes = new StringCollection();

		/// <summary>
		/// Extra Description Data Structure (Used in both Objects and Rooms)
		/// </summary>
		public class ExtraDescription
		{
			public string Keywords, Description;

			public ExtraDescription(string theKeywords, string theDescription)
			{
				this.Keywords = theKeywords;
				this.Description = theDescription;
			}
		}

		/// <summary>
		/// Mobile Data Structures
		/// </summary>
		public class Mobile
		{
			public long VNum;
			public string AliasList, ShortDescription, LongDescription, DetailedDescription;
			public string ActionBitvector, AffectionBitvector;
			public int Alignment;
			public string TypeFlag;
			public int Level, Thaco, ArmorClass;
			public int HPNum, HPDie, HPAdd;
			public int BHNum, BHDie, BHAdd;
			public long Gold, Experience;
			public int LoadPosition, DefaultPosition, Sex;
			public SortedList ESpecs = new SortedList();

			public Mobile(long theVNum)
			{
				this.VNum = theVNum;
			}
		}

		public class ESpecData
		{
			public string SpecTxt;
			public long SpecMin, SpecMax;
			public StringCollection Range = new StringCollection();
		}

		/// <summary>
		/// Object Data Structures
		/// </summary>
		public class Object
		{
			public long VNum;
			public string AliasList, ShortDescription, LongDescription, ActionDescription;
			public int TypeFlag;
			public string EffectsBitvector, WearBitvector;
			public long Value0, Value1, Value2, Value3;
			public int Weight;
			public long Cost, RentPerDay;
			public SortedList Affects = new SortedList();
			public SortedList ExtraDescriptions = new SortedList();

			public Object(long theVNum)
			{
				this.VNum = theVNum;
			}
		}

		public class ValueData
		{
			public SortedList Value = new SortedList();
		}

		public class Value
		{
			public string ValueTxt;
			public long ValueMin, ValueMax;
			public StringCollection Range = new StringCollection();
		}

		public class Affect
		{
			public int Location;
			public long Value;

			public Affect(int theLocation, long theValue)
			{
				this.Location = theLocation;
				this.Value = theValue;
			}
		}

		/// <summary>
		/// Room Data Structures
		/// </summary>
		public class Room
		{
			public long VNum;
			public string Name, Description;
			public int Zone;
			public string RoomBitvector;
			public int SectorType;
			public SortedList DirectionField = new SortedList();
			public SortedList ExtraDescriptions = new SortedList();

			public Room(long theVNum)
			{
				this.VNum = theVNum;
			}
		}

		public class DirectionData
		{
			public int Direction;
			public string Description, Keywords;
			public int DoorFlag;
			public long Key, Exit;
			public bool Exists;

			public DirectionData(int theDirection)
			{
				this.Direction = theDirection;
			}
		}

        /// <summary>
        /// Shop Data Structure
        /// </summary>
		public class Shop
		{
			public long VNum;
			public StringCollection ShopItems = new StringCollection();
			public double SellProfit, BuyProfit;
			public StringCollection BuyTypes = new StringCollection();
			public string MessageBuyItemDoesNotExist;
			public string MessageSellItemDoesNotExist;
			public string MessageShopDoesNotBuyItem;
			public string MessageShopCanNotAffordItem;
			public string MessagePlayerCanNotAffordItem;
			public string MessageBuySuccess;
			public string MessageSellSuccess;
			public int ShopkeeperTemper;
			public string ShopBitvector;
			public long ShopkeeperVNum;
			public string WithWhoBitvector;
			public StringCollection ShopRooms = new StringCollection();
			public int OpenTime1, CloseTime1;
			public int OpenTime2, CloseTime2;

			public Shop(long theVNum)
			{
				this.VNum = theVNum;
			}
		}

		/// <summary>
		/// Zone Data Structures
		/// </summary>
		public class Zone
		{
			public int Number;
			public string Name;
			public long BottomRoom, TopRoom;
			public int Lifespan, ResetMode;
			public SortedList ZoneCommands = new SortedList();

			public Zone(int theNumber)
			{
				this.Number = theNumber;
			}
		}

		public class ZoneCommand
		{
			public string CommandType, Comment;
			public int IfFlag;
			public long Arg0, Arg1, Arg2;
		}

		public class CommandData
		{
			public SortedList Arg = new SortedList();
		}

		public class Arg
		{
			public string ArgTxt;
			public long ArgMin, ArgMax;
			public StringCollection Range = new StringCollection();
		}

		/// <summary>
		/// Default Data Structures
		/// </summary>
		public class DefaultMobile
		{
			public long VNumMin, VNumMax;
			public int[] ActionBitvector, AffectionBitvector;
			public int LoadPosition, DefaultPosition, Sex, AttackType;
			public string ESpec;
		}

		public class DefaultObject
		{
			public long VNumMin, VNumMax;
			public int[] EffectsBitvector, WearBitvector;
			public int TypeFlag, Spell, Liquid;
			public string Affect;
		}

		public class DefaultRoom
		{
			public long VNumMin, VNumMax;
			public int[] RoomBitvector;
			public int SectorType, DoorFlag;
		}

		public class DefaultShop
		{
			public long VNumMin, VNumMax;
			public int[] BuyTypes, ShopBitvector, WillNotSellTo;
			public int ShopkeeperTemper;
		}

		public class DefaultZone
		{
			public int NumberMin, NumberMax;
			public int ResetMode, CommandType;
		}

		/// <summary>
		/// Data Structures to contain area data types.
		/// </summary>
		public SortedList theMobiles = new SortedList();
		public SortedList theObjects = new SortedList();
		public SortedList theRooms = new SortedList();
		public SortedList theShops = new SortedList();
		public SortedList theCommands = new SortedList();

		/// <summary>
		/// Data Structures to hold additional data types.
		/// </summary>
		public SortedList theESpecs = new SortedList();
		public SortedList theValues = new SortedList();

		/// <summary>
		/// Current Mobile Data
		/// </summary>
		public Mobile currentMobile;
		public static int mobZone = 0;

		/// <summary>
		/// Current Object Data
		/// </summary>
		public Object currentObject;
		public static int objZone = 0;
		public static int objExtraDescKeywordMax = 0;
		public static int objExtraDescDescriptionMax = 0;
		public static int objAffectsMax = 0;

		/// <summary>
		/// Current Room Data
		/// </summary>
		public Room currentRoom;
		public static int wldZone = 0;
		public static int currentDirection = 0;
		public static int wldDoorDescKeywordMax = 0;
		public static int wldDoorDescDescriptionMax = 0;
		public static int wldExtraDescKeywordMax = 0;
		public static int wldExtraDescDescriptionMax = 0;

		/// <summary>
		/// Current Shop Data
		/// </summary>
		public Shop currentShop;
		public static int shpZone = 0;
		public static int shpMessageMax = 0;

		/// <summary>
		/// Current Zone Data
		/// </summary>
		public Zone currentZone;
		public static string currentZoneName = "";
		public static int currentZoneNumber = 0;
		public static bool autoGenComment = false;

		/// <summary>
		/// Default Editor Data
		/// </summary>
		public static DefaultMobile defaultMobile = new DefaultMobile();
		public static DefaultObject defaultObject = new DefaultObject();
		public static DefaultRoom defaultRoom = new DefaultRoom();
		public static DefaultShop defaultShop = new DefaultShop();
		public static DefaultZone defaultZone = new DefaultZone();

		/// <summary>
		/// Booleans, true if given area type has changed. 
		/// </summary>
		public static bool mobChanged = false;
		public static bool objChanged = false;
		public static bool wldChanged = false;
		public static bool shpChanged = false;
		public static bool zonChanged = false;

		/// <summary>
		/// Booleans, false if given area file has not been saved.
		/// </summary>
		public static bool mobFileSaved = true;
		public static bool objFileSaved = true;
		public static bool wldFileSaved = true;
		public static bool shpFileSaved = true;
		public static bool zonFileSaved = true;

		/// <summary>
		/// Misc. Variables
		/// </summary>

		public static long inputResult = 0;			// Generic number to contain returned value from fInput

		public bool valueChanging = false;
		public bool loadingExit = false;
		private System.Windows.Forms.MenuItem miToolsLoadMUDConfiguration;
		private System.Windows.Forms.MenuItem miToolsSep0;
		private System.Windows.Forms.MenuItem miToolsAutoGenerateComments;	// Used to enforce a simple semaphore.
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(fMain));
			this.mmMain = new System.Windows.Forms.MainMenu();
			this.miFile = new System.Windows.Forms.MenuItem();
			this.miFileNew = new System.Windows.Forms.MenuItem();
			this.miFileNewArea = new System.Windows.Forms.MenuItem();
			this.miFileNewSep0 = new System.Windows.Forms.MenuItem();
			this.miFileNewMobileFile = new System.Windows.Forms.MenuItem();
			this.miFileNewObjectFile = new System.Windows.Forms.MenuItem();
			this.miFileNewWorldFile = new System.Windows.Forms.MenuItem();
			this.miFileNewShopFile = new System.Windows.Forms.MenuItem();
			this.miFileNewZoneFile = new System.Windows.Forms.MenuItem();
			this.miFileOpen = new System.Windows.Forms.MenuItem();
			this.miFileOpenArea = new System.Windows.Forms.MenuItem();
			this.miFileOpenSep0 = new System.Windows.Forms.MenuItem();
			this.miFileOpenMobileFile = new System.Windows.Forms.MenuItem();
			this.miFileOpenObjectFile = new System.Windows.Forms.MenuItem();
			this.miFileOpenWorldFile = new System.Windows.Forms.MenuItem();
			this.miFileOpenShopFile = new System.Windows.Forms.MenuItem();
			this.miFileOpenZoneFile = new System.Windows.Forms.MenuItem();
			this.miFileClose = new System.Windows.Forms.MenuItem();
			this.miFileCloseArea = new System.Windows.Forms.MenuItem();
			this.miFileCloseSep0 = new System.Windows.Forms.MenuItem();
			this.miFileCloseMobileFile = new System.Windows.Forms.MenuItem();
			this.miFileCloseObjectFile = new System.Windows.Forms.MenuItem();
			this.miFileCloseWorldFile = new System.Windows.Forms.MenuItem();
			this.miFileCloseShopFile = new System.Windows.Forms.MenuItem();
			this.miFileCloseZoneFile = new System.Windows.Forms.MenuItem();
			this.miFileSep1 = new System.Windows.Forms.MenuItem();
			this.miFileSave = new System.Windows.Forms.MenuItem();
			this.miFileSaveArea = new System.Windows.Forms.MenuItem();
			this.miFileSaveSep0 = new System.Windows.Forms.MenuItem();
			this.miFileSaveMobileFile = new System.Windows.Forms.MenuItem();
			this.miFileSaveObjectFile = new System.Windows.Forms.MenuItem();
			this.miFileSaveWorldFile = new System.Windows.Forms.MenuItem();
			this.miFileSaveShopFile = new System.Windows.Forms.MenuItem();
			this.miFileSaveZoneFile = new System.Windows.Forms.MenuItem();
			this.miFileSep2 = new System.Windows.Forms.MenuItem();
			this.miFileExit = new System.Windows.Forms.MenuItem();
			this.miEdit = new System.Windows.Forms.MenuItem();
			this.miEditUndo = new System.Windows.Forms.MenuItem();
			this.miEditRedo = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.miEditCut = new System.Windows.Forms.MenuItem();
			this.miEditCopy = new System.Windows.Forms.MenuItem();
			this.miEditPaste = new System.Windows.Forms.MenuItem();
			this.miTools = new System.Windows.Forms.MenuItem();
			this.miToolsLoadMUDConfiguration = new System.Windows.Forms.MenuItem();
			this.miToolsSep0 = new System.Windows.Forms.MenuItem();
			this.miToolsOptions = new System.Windows.Forms.MenuItem();
			this.miToolsAutoGenerateComments = new System.Windows.Forms.MenuItem();
			this.miHelp = new System.Windows.Forms.MenuItem();
			this.miHelpAbout = new System.Windows.Forms.MenuItem();
			this.sbMain = new System.Windows.Forms.StatusBar();
			this.tcEditors = new System.Windows.Forms.TabControl();
			this.tpMobileEditor = new System.Windows.Forms.TabPage();
			this.bMobDelete = new System.Windows.Forms.Button();
			this.bMobMove = new System.Windows.Forms.Button();
			this.bMobCopy = new System.Windows.Forms.Button();
			this.bMobSave = new System.Windows.Forms.Button();
			this.bMobNew = new System.Windows.Forms.Button();
			this.bMobESpecs = new System.Windows.Forms.Button();
			this.gbMobQuickSelect = new System.Windows.Forms.GroupBox();
			this.cboxMobQuickSelect = new System.Windows.Forms.ComboBox();
			this.gbMobGender = new System.Windows.Forms.GroupBox();
			this.cboxMobGender = new System.Windows.Forms.ComboBox();
			this.gbMobDefaultPosition = new System.Windows.Forms.GroupBox();
			this.cboxMobDefaultPosition = new System.Windows.Forms.ComboBox();
			this.gbMobLoadPosition = new System.Windows.Forms.GroupBox();
			this.cboxMobLoadPosition = new System.Windows.Forms.ComboBox();
			this.gbMobExperience = new System.Windows.Forms.GroupBox();
			this.nudMobExperience = new System.Windows.Forms.NumericUpDown();
			this.gbMobArmorClass = new System.Windows.Forms.GroupBox();
			this.nudMobArmorClass = new System.Windows.Forms.NumericUpDown();
			this.gbMobAffectionBitvector = new System.Windows.Forms.GroupBox();
			this.clboxMobAffectionBitvector = new System.Windows.Forms.CheckedListBox();
			this.gbMobActionBitvector = new System.Windows.Forms.GroupBox();
			this.clboxMobActionBitvector = new System.Windows.Forms.CheckedListBox();
			this.gbMobVNum = new System.Windows.Forms.GroupBox();
			this.nudMobVNum = new System.Windows.Forms.NumericUpDown();
			this.gbMobShortDescription = new System.Windows.Forms.GroupBox();
			this.tbMobShortDescription = new System.Windows.Forms.TextBox();
			this.gbMobLongDescription = new System.Windows.Forms.GroupBox();
			this.tbMobLongDescription = new System.Windows.Forms.TextBox();
			this.gbMobAliasList = new System.Windows.Forms.GroupBox();
			this.tbMobAliasList = new System.Windows.Forms.TextBox();
			this.gbMobDetailedDescription = new System.Windows.Forms.GroupBox();
			this.tbMobDetailedDescription = new System.Windows.Forms.TextBox();
			this.gbMobAlignment = new System.Windows.Forms.GroupBox();
			this.nudMobAlignment = new System.Windows.Forms.NumericUpDown();
			this.gbMobLevel = new System.Windows.Forms.GroupBox();
			this.nudMobLevel = new System.Windows.Forms.NumericUpDown();
			this.gbMobHP = new System.Windows.Forms.GroupBox();
			this.lMobHPPlus = new System.Windows.Forms.Label();
			this.lMobHPDie = new System.Windows.Forms.Label();
			this.nudMobHPAdd = new System.Windows.Forms.NumericUpDown();
			this.nudMobHPDie = new System.Windows.Forms.NumericUpDown();
			this.nudMobHPNum = new System.Windows.Forms.NumericUpDown();
			this.gbMobGold = new System.Windows.Forms.GroupBox();
			this.nudMobGold = new System.Windows.Forms.NumericUpDown();
			this.gbMobBH = new System.Windows.Forms.GroupBox();
			this.lMobBHPlus = new System.Windows.Forms.Label();
			this.lMobBHDie = new System.Windows.Forms.Label();
			this.nudMobBHAdd = new System.Windows.Forms.NumericUpDown();
			this.nudMobBHDie = new System.Windows.Forms.NumericUpDown();
			this.nudMobBHNum = new System.Windows.Forms.NumericUpDown();
			this.gbMobThaco = new System.Windows.Forms.GroupBox();
			this.nudMobThaco = new System.Windows.Forms.NumericUpDown();
			this.tpObjectEditor = new System.Windows.Forms.TabPage();
			this.bObjDelete = new System.Windows.Forms.Button();
			this.bObjMove = new System.Windows.Forms.Button();
			this.bObjCopy = new System.Windows.Forms.Button();
			this.bObjSave = new System.Windows.Forms.Button();
			this.bObjNew = new System.Windows.Forms.Button();
			this.bObjAffects = new System.Windows.Forms.Button();
			this.gbObjValues = new System.Windows.Forms.GroupBox();
			this.gbObjValue3 = new System.Windows.Forms.GroupBox();
			this.cboxObjValue3 = new System.Windows.Forms.ComboBox();
			this.nudObjValue3 = new System.Windows.Forms.NumericUpDown();
			this.gbObjValue2 = new System.Windows.Forms.GroupBox();
			this.cboxObjValue2 = new System.Windows.Forms.ComboBox();
			this.nudObjValue2 = new System.Windows.Forms.NumericUpDown();
			this.gbObjValue1 = new System.Windows.Forms.GroupBox();
			this.cboxObjValue1 = new System.Windows.Forms.ComboBox();
			this.nudObjValue1 = new System.Windows.Forms.NumericUpDown();
			this.gbObjValue0 = new System.Windows.Forms.GroupBox();
			this.cboxObjValue0 = new System.Windows.Forms.ComboBox();
			this.nudObjValue0 = new System.Windows.Forms.NumericUpDown();
			this.bObjExtraDescriptions = new System.Windows.Forms.Button();
			this.gbObjCost = new System.Windows.Forms.GroupBox();
			this.nudObjCost = new System.Windows.Forms.NumericUpDown();
			this.gbObjRentPerDay = new System.Windows.Forms.GroupBox();
			this.nudObjRentPerDay = new System.Windows.Forms.NumericUpDown();
			this.gbObjWearBitvector = new System.Windows.Forms.GroupBox();
			this.clboxObjWearBitvector = new System.Windows.Forms.CheckedListBox();
			this.gbObjEffectsBitvector = new System.Windows.Forms.GroupBox();
			this.clboxObjEffectsBitvector = new System.Windows.Forms.CheckedListBox();
			this.gbObjTypeFlag = new System.Windows.Forms.GroupBox();
			this.cboxObjTypeFlag = new System.Windows.Forms.ComboBox();
			this.gbObjQuickSelect = new System.Windows.Forms.GroupBox();
			this.cboxObjQuickSelect = new System.Windows.Forms.ComboBox();
			this.gbObjVNum = new System.Windows.Forms.GroupBox();
			this.nudObjVNum = new System.Windows.Forms.NumericUpDown();
			this.gbObjShortDescription = new System.Windows.Forms.GroupBox();
			this.tbObjShortDescription = new System.Windows.Forms.TextBox();
			this.gbObjLongDescription = new System.Windows.Forms.GroupBox();
			this.tbObjLongDescription = new System.Windows.Forms.TextBox();
			this.gbObjAliasList = new System.Windows.Forms.GroupBox();
			this.tbObjAliasList = new System.Windows.Forms.TextBox();
			this.gbObjActionDescription = new System.Windows.Forms.GroupBox();
			this.tbObjActionDescription = new System.Windows.Forms.TextBox();
			this.gbObjWeight = new System.Windows.Forms.GroupBox();
			this.nudObjWeight = new System.Windows.Forms.NumericUpDown();
			this.tpRoomEditor = new System.Windows.Forms.TabPage();
			this.bWldExtraDescriptions = new System.Windows.Forms.Button();
			this.bWldDelete = new System.Windows.Forms.Button();
			this.bWldMove = new System.Windows.Forms.Button();
			this.bWldCopy = new System.Windows.Forms.Button();
			this.bWldSave = new System.Windows.Forms.Button();
			this.bWldNew = new System.Windows.Forms.Button();
			this.gbWldDirections = new System.Windows.Forms.GroupBox();
			this.gbWldCurrentExit = new System.Windows.Forms.GroupBox();
			this.bWldDoorDescription = new System.Windows.Forms.Button();
			this.cbWldNowhere = new System.Windows.Forms.CheckBox();
			this.cbWldExitExists = new System.Windows.Forms.CheckBox();
			this.gbWldDoorFlag = new System.Windows.Forms.GroupBox();
			this.cboxWldDoorFlag = new System.Windows.Forms.ComboBox();
			this.gbWldDoorKey = new System.Windows.Forms.GroupBox();
			this.cboxWldAreaDoorKey = new System.Windows.Forms.ComboBox();
			this.cbWldNoKey = new System.Windows.Forms.CheckBox();
			this.nudWldDoorKey = new System.Windows.Forms.NumericUpDown();
			this.gbWldExits = new System.Windows.Forms.GroupBox();
			this.nudWldWest = new System.Windows.Forms.NumericUpDown();
			this.rbWldSouth = new System.Windows.Forms.RadioButton();
			this.rbWldDown = new System.Windows.Forms.RadioButton();
			this.rbWldUp = new System.Windows.Forms.RadioButton();
			this.rbWldWest = new System.Windows.Forms.RadioButton();
			this.rbWldEast = new System.Windows.Forms.RadioButton();
			this.nudWldDown = new System.Windows.Forms.NumericUpDown();
			this.nudWldEast = new System.Windows.Forms.NumericUpDown();
			this.nudWldUp = new System.Windows.Forms.NumericUpDown();
			this.nudWldSouth = new System.Windows.Forms.NumericUpDown();
			this.nudWldNorth = new System.Windows.Forms.NumericUpDown();
			this.rbWldNorth = new System.Windows.Forms.RadioButton();
			this.gbWldSectorType = new System.Windows.Forms.GroupBox();
			this.cboxWldSectorType = new System.Windows.Forms.ComboBox();
			this.gbWldRoomBitvector = new System.Windows.Forms.GroupBox();
			this.clboxWldRoomBitvector = new System.Windows.Forms.CheckedListBox();
			this.gbWldQuickSelect = new System.Windows.Forms.GroupBox();
			this.cboxWldQuickSelect = new System.Windows.Forms.ComboBox();
			this.gbWldVNum = new System.Windows.Forms.GroupBox();
			this.nudWldVNum = new System.Windows.Forms.NumericUpDown();
			this.gbWldRoomName = new System.Windows.Forms.GroupBox();
			this.tbWldRoomName = new System.Windows.Forms.TextBox();
			this.gbWldRoomDescription = new System.Windows.Forms.GroupBox();
			this.tbWldRoomDescription = new System.Windows.Forms.TextBox();
			this.tpShopEditor = new System.Windows.Forms.TabPage();
			this.bShpShopkeeperMessages = new System.Windows.Forms.Button();
			this.bShpDelete = new System.Windows.Forms.Button();
			this.bShpMove = new System.Windows.Forms.Button();
			this.bShpCopy = new System.Windows.Forms.Button();
			this.bShpSave = new System.Windows.Forms.Button();
			this.bShpNew = new System.Windows.Forms.Button();
			this.gbShpShopInformation = new System.Windows.Forms.GroupBox();
			this.gbShpOpenTime1 = new System.Windows.Forms.GroupBox();
			this.nudShpOpenTime1 = new System.Windows.Forms.NumericUpDown();
			this.gbShpCloseTime1 = new System.Windows.Forms.GroupBox();
			this.nudShpCloseTime1 = new System.Windows.Forms.NumericUpDown();
			this.gbShpOpenTime2 = new System.Windows.Forms.GroupBox();
			this.nudShpOpenTime2 = new System.Windows.Forms.NumericUpDown();
			this.gbShpCloseTime2 = new System.Windows.Forms.GroupBox();
			this.nudShpCloseTime2 = new System.Windows.Forms.NumericUpDown();
			this.gbShpBuyProfit = new System.Windows.Forms.GroupBox();
			this.nudShpBuyProfit = new System.Windows.Forms.NumericUpDown();
			this.gbShpSellProfit = new System.Windows.Forms.GroupBox();
			this.nudShpSellProfit = new System.Windows.Forms.NumericUpDown();
			this.cbShpAlwaysOpen = new System.Windows.Forms.CheckBox();
			this.gbShpShopkeeper = new System.Windows.Forms.GroupBox();
			this.gbShpShopBitvector = new System.Windows.Forms.GroupBox();
			this.clboxShpShopBitvector = new System.Windows.Forms.CheckedListBox();
			this.gbShpShopkeeperTemper = new System.Windows.Forms.GroupBox();
			this.cboxShpShopkeeperTemper = new System.Windows.Forms.ComboBox();
			this.gbShpAreaMobile = new System.Windows.Forms.GroupBox();
			this.cboxShpAreaMobile = new System.Windows.Forms.ComboBox();
			this.gbShpMobileVNum = new System.Windows.Forms.GroupBox();
			this.nudShpMobileVNum = new System.Windows.Forms.NumericUpDown();
			this.gbShpShopRooms = new System.Windows.Forms.GroupBox();
			this.bShpRemoveRoom = new System.Windows.Forms.Button();
			this.bShpAddRoom = new System.Windows.Forms.Button();
			this.gbShpAreaRoom = new System.Windows.Forms.GroupBox();
			this.cboxShpAreaRoom = new System.Windows.Forms.ComboBox();
			this.gbShpRoomVNum = new System.Windows.Forms.GroupBox();
			this.nudShpRoomVNum = new System.Windows.Forms.NumericUpDown();
			this.lboxShpShopRooms = new System.Windows.Forms.ListBox();
			this.gbShpShopItems = new System.Windows.Forms.GroupBox();
			this.bShpRemoveItem = new System.Windows.Forms.Button();
			this.bShpAddItem = new System.Windows.Forms.Button();
			this.gbShpAreaItem = new System.Windows.Forms.GroupBox();
			this.cboxShpAreaItem = new System.Windows.Forms.ComboBox();
			this.gbShpItemVNum = new System.Windows.Forms.GroupBox();
			this.nudShpItemVNum = new System.Windows.Forms.NumericUpDown();
			this.lboxShpShopItems = new System.Windows.Forms.ListBox();
			this.gbShpQuickSelect = new System.Windows.Forms.GroupBox();
			this.cboxShpQuickSelect = new System.Windows.Forms.ComboBox();
			this.gbShpWillNotSellTo = new System.Windows.Forms.GroupBox();
			this.clboxShpWillNotSellTo = new System.Windows.Forms.CheckedListBox();
			this.gbShpBuyTypes = new System.Windows.Forms.GroupBox();
			this.clboxShpBuyTypes = new System.Windows.Forms.CheckedListBox();
			this.gbShpVNum = new System.Windows.Forms.GroupBox();
			this.nudShpVNum = new System.Windows.Forms.NumericUpDown();
			this.tpZoneEditor = new System.Windows.Forms.TabPage();
			this.gbZonZoneInformation = new System.Windows.Forms.GroupBox();
			this.gbZonBottomRoom = new System.Windows.Forms.GroupBox();
			this.nudZonBottomRoom = new System.Windows.Forms.NumericUpDown();
			this.gbZonZoneName = new System.Windows.Forms.GroupBox();
			this.tbZonZoneName = new System.Windows.Forms.TextBox();
			this.gbZonResetMode = new System.Windows.Forms.GroupBox();
			this.cboxZonResetMode = new System.Windows.Forms.ComboBox();
			this.gbZonLifespan = new System.Windows.Forms.GroupBox();
			this.nudZonLifespan = new System.Windows.Forms.NumericUpDown();
			this.gbZonTopRoom = new System.Windows.Forms.GroupBox();
			this.nudZonTopRoom = new System.Windows.Forms.NumericUpDown();
			this.gbZonNumber = new System.Windows.Forms.GroupBox();
			this.nudZonNumber = new System.Windows.Forms.NumericUpDown();
			this.gbZonZoneCommand = new System.Windows.Forms.GroupBox();
			this.bZonInsert = new System.Windows.Forms.Button();
			this.bZonAdd = new System.Windows.Forms.Button();
			this.gbZonComment = new System.Windows.Forms.GroupBox();
			this.tbZonComment = new System.Windows.Forms.TextBox();
			this.cbZonIfFlag = new System.Windows.Forms.CheckBox();
			this.gbZonArg2 = new System.Windows.Forms.GroupBox();
			this.cboxZonAreaArg2 = new System.Windows.Forms.ComboBox();
			this.nudZonArg2 = new System.Windows.Forms.NumericUpDown();
			this.gbZonArg1 = new System.Windows.Forms.GroupBox();
			this.cboxZonAreaArg1 = new System.Windows.Forms.ComboBox();
			this.nudZonArg1 = new System.Windows.Forms.NumericUpDown();
			this.gbZonArg0 = new System.Windows.Forms.GroupBox();
			this.cboxZonAreaArg0 = new System.Windows.Forms.ComboBox();
			this.nudZonArg0 = new System.Windows.Forms.NumericUpDown();
			this.gbZonCommandType = new System.Windows.Forms.GroupBox();
			this.cboxZonCommandType = new System.Windows.Forms.ComboBox();
			this.gbZonZoneCommands = new System.Windows.Forms.GroupBox();
			this.bZonCommandUp = new System.Windows.Forms.Button();
			this.bZonCommandDown = new System.Windows.Forms.Button();
			this.bZonRemove = new System.Windows.Forms.Button();
			this.lboxZonZoneCommands = new System.Windows.Forms.ListBox();
			this.tcEditors.SuspendLayout();
			this.tpMobileEditor.SuspendLayout();
			this.gbMobQuickSelect.SuspendLayout();
			this.gbMobGender.SuspendLayout();
			this.gbMobDefaultPosition.SuspendLayout();
			this.gbMobLoadPosition.SuspendLayout();
			this.gbMobExperience.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobExperience)).BeginInit();
			this.gbMobArmorClass.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobArmorClass)).BeginInit();
			this.gbMobAffectionBitvector.SuspendLayout();
			this.gbMobActionBitvector.SuspendLayout();
			this.gbMobVNum.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobVNum)).BeginInit();
			this.gbMobShortDescription.SuspendLayout();
			this.gbMobLongDescription.SuspendLayout();
			this.gbMobAliasList.SuspendLayout();
			this.gbMobDetailedDescription.SuspendLayout();
			this.gbMobAlignment.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobAlignment)).BeginInit();
			this.gbMobLevel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobLevel)).BeginInit();
			this.gbMobHP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobHPAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMobHPDie)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMobHPNum)).BeginInit();
			this.gbMobGold.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobGold)).BeginInit();
			this.gbMobBH.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobBHAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMobBHDie)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMobBHNum)).BeginInit();
			this.gbMobThaco.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobThaco)).BeginInit();
			this.tpObjectEditor.SuspendLayout();
			this.gbObjValues.SuspendLayout();
			this.gbObjValue3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudObjValue3)).BeginInit();
			this.gbObjValue2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudObjValue2)).BeginInit();
			this.gbObjValue1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudObjValue1)).BeginInit();
			this.gbObjValue0.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudObjValue0)).BeginInit();
			this.gbObjCost.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudObjCost)).BeginInit();
			this.gbObjRentPerDay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudObjRentPerDay)).BeginInit();
			this.gbObjWearBitvector.SuspendLayout();
			this.gbObjEffectsBitvector.SuspendLayout();
			this.gbObjTypeFlag.SuspendLayout();
			this.gbObjQuickSelect.SuspendLayout();
			this.gbObjVNum.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudObjVNum)).BeginInit();
			this.gbObjShortDescription.SuspendLayout();
			this.gbObjLongDescription.SuspendLayout();
			this.gbObjAliasList.SuspendLayout();
			this.gbObjActionDescription.SuspendLayout();
			this.gbObjWeight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudObjWeight)).BeginInit();
			this.tpRoomEditor.SuspendLayout();
			this.gbWldDirections.SuspendLayout();
			this.gbWldCurrentExit.SuspendLayout();
			this.gbWldDoorFlag.SuspendLayout();
			this.gbWldDoorKey.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudWldDoorKey)).BeginInit();
			this.gbWldExits.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudWldWest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldEast)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldSouth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldNorth)).BeginInit();
			this.gbWldSectorType.SuspendLayout();
			this.gbWldRoomBitvector.SuspendLayout();
			this.gbWldQuickSelect.SuspendLayout();
			this.gbWldVNum.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudWldVNum)).BeginInit();
			this.gbWldRoomName.SuspendLayout();
			this.gbWldRoomDescription.SuspendLayout();
			this.tpShopEditor.SuspendLayout();
			this.gbShpShopInformation.SuspendLayout();
			this.gbShpOpenTime1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpOpenTime1)).BeginInit();
			this.gbShpCloseTime1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpCloseTime1)).BeginInit();
			this.gbShpOpenTime2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpOpenTime2)).BeginInit();
			this.gbShpCloseTime2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpCloseTime2)).BeginInit();
			this.gbShpBuyProfit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpBuyProfit)).BeginInit();
			this.gbShpSellProfit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpSellProfit)).BeginInit();
			this.gbShpShopkeeper.SuspendLayout();
			this.gbShpShopBitvector.SuspendLayout();
			this.gbShpShopkeeperTemper.SuspendLayout();
			this.gbShpAreaMobile.SuspendLayout();
			this.gbShpMobileVNum.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpMobileVNum)).BeginInit();
			this.gbShpShopRooms.SuspendLayout();
			this.gbShpAreaRoom.SuspendLayout();
			this.gbShpRoomVNum.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpRoomVNum)).BeginInit();
			this.gbShpShopItems.SuspendLayout();
			this.gbShpAreaItem.SuspendLayout();
			this.gbShpItemVNum.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpItemVNum)).BeginInit();
			this.gbShpQuickSelect.SuspendLayout();
			this.gbShpWillNotSellTo.SuspendLayout();
			this.gbShpBuyTypes.SuspendLayout();
			this.gbShpVNum.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShpVNum)).BeginInit();
			this.tpZoneEditor.SuspendLayout();
			this.gbZonZoneInformation.SuspendLayout();
			this.gbZonBottomRoom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudZonBottomRoom)).BeginInit();
			this.gbZonZoneName.SuspendLayout();
			this.gbZonResetMode.SuspendLayout();
			this.gbZonLifespan.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudZonLifespan)).BeginInit();
			this.gbZonTopRoom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudZonTopRoom)).BeginInit();
			this.gbZonNumber.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudZonNumber)).BeginInit();
			this.gbZonZoneCommand.SuspendLayout();
			this.gbZonComment.SuspendLayout();
			this.gbZonArg2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudZonArg2)).BeginInit();
			this.gbZonArg1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudZonArg1)).BeginInit();
			this.gbZonArg0.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudZonArg0)).BeginInit();
			this.gbZonCommandType.SuspendLayout();
			this.gbZonZoneCommands.SuspendLayout();
			this.SuspendLayout();
			// 
			// mmMain
			// 
			this.mmMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.miFile,
																				   this.miEdit,
																				   this.miTools,
																				   this.miHelp});
			// 
			// miFile
			// 
			this.miFile.Index = 0;
			this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.miFileNew,
																				   this.miFileOpen,
																				   this.miFileClose,
																				   this.miFileSep1,
																				   this.miFileSave,
																				   this.miFileSep2,
																				   this.miFileExit});
			this.miFile.Text = "&File";
			// 
			// miFileNew
			// 
			this.miFileNew.Index = 0;
			this.miFileNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.miFileNewArea,
																					  this.miFileNewSep0,
																					  this.miFileNewMobileFile,
																					  this.miFileNewObjectFile,
																					  this.miFileNewWorldFile,
																					  this.miFileNewShopFile,
																					  this.miFileNewZoneFile});
			this.miFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.miFileNew.Text = "&New";
			// 
			// miFileNewArea
			// 
			this.miFileNewArea.Index = 0;
			this.miFileNewArea.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftN;
			this.miFileNewArea.Text = "New Area";
			this.miFileNewArea.Click += new System.EventHandler(this.miFileNewArea_Click);
			// 
			// miFileNewSep0
			// 
			this.miFileNewSep0.Index = 1;
			this.miFileNewSep0.Text = "-";
			// 
			// miFileNewMobileFile
			// 
			this.miFileNewMobileFile.Index = 2;
			this.miFileNewMobileFile.Text = "New Mobile File";
			this.miFileNewMobileFile.Click += new System.EventHandler(this.miFileNewMobileFile_Click);
			// 
			// miFileNewObjectFile
			// 
			this.miFileNewObjectFile.Index = 3;
			this.miFileNewObjectFile.Text = "New Object File";
			this.miFileNewObjectFile.Click += new System.EventHandler(this.miFileNewObjectFile_Click);
			// 
			// miFileNewWorldFile
			// 
			this.miFileNewWorldFile.Index = 4;
			this.miFileNewWorldFile.Text = "New World File";
			this.miFileNewWorldFile.Click += new System.EventHandler(this.miFileNewWorldFile_Click);
			// 
			// miFileNewShopFile
			// 
			this.miFileNewShopFile.Index = 5;
			this.miFileNewShopFile.Text = "New Shop File";
			this.miFileNewShopFile.Click += new System.EventHandler(this.miFileNewShopFile_Click);
			// 
			// miFileNewZoneFile
			// 
			this.miFileNewZoneFile.Index = 6;
			this.miFileNewZoneFile.Text = "New Zone File";
			this.miFileNewZoneFile.Click += new System.EventHandler(this.miFileNewZoneFile_Click);
			// 
			// miFileOpen
			// 
			this.miFileOpen.Index = 1;
			this.miFileOpen.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.miFileOpenArea,
																					   this.miFileOpenSep0,
																					   this.miFileOpenMobileFile,
																					   this.miFileOpenObjectFile,
																					   this.miFileOpenWorldFile,
																					   this.miFileOpenShopFile,
																					   this.miFileOpenZoneFile});
			this.miFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.miFileOpen.Text = "&Open";
			// 
			// miFileOpenArea
			// 
			this.miFileOpenArea.Index = 0;
			this.miFileOpenArea.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftO;
			this.miFileOpenArea.Text = "Open Entire Area";
			this.miFileOpenArea.Click += new System.EventHandler(this.miFileOpenArea_Click);
			// 
			// miFileOpenSep0
			// 
			this.miFileOpenSep0.Index = 1;
			this.miFileOpenSep0.Text = "-";
			// 
			// miFileOpenMobileFile
			// 
			this.miFileOpenMobileFile.Index = 2;
			this.miFileOpenMobileFile.Text = "Open Mobile File";
			this.miFileOpenMobileFile.Click += new System.EventHandler(this.miFileOpenMobileFile_Click);
			// 
			// miFileOpenObjectFile
			// 
			this.miFileOpenObjectFile.Index = 3;
			this.miFileOpenObjectFile.Text = "Open Object File";
			this.miFileOpenObjectFile.Click += new System.EventHandler(this.miFileOpenObjectFile_Click);
			// 
			// miFileOpenWorldFile
			// 
			this.miFileOpenWorldFile.Index = 4;
			this.miFileOpenWorldFile.Text = "Open World File";
			this.miFileOpenWorldFile.Click += new System.EventHandler(this.miFileOpenWorldFile_Click);
			// 
			// miFileOpenShopFile
			// 
			this.miFileOpenShopFile.Index = 5;
			this.miFileOpenShopFile.Text = "Open Shop File";
			this.miFileOpenShopFile.Click += new System.EventHandler(this.miFileOpenShopFile_Click);
			// 
			// miFileOpenZoneFile
			// 
			this.miFileOpenZoneFile.Index = 6;
			this.miFileOpenZoneFile.Text = "Open Zone File";
			this.miFileOpenZoneFile.Click += new System.EventHandler(this.miFileOpenZoneFile_Click);
			// 
			// miFileClose
			// 
			this.miFileClose.Enabled = false;
			this.miFileClose.Index = 2;
			this.miFileClose.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.miFileCloseArea,
																						this.miFileCloseSep0,
																						this.miFileCloseMobileFile,
																						this.miFileCloseObjectFile,
																						this.miFileCloseWorldFile,
																						this.miFileCloseShopFile,
																						this.miFileCloseZoneFile});
			this.miFileClose.Text = "&Close";
			// 
			// miFileCloseArea
			// 
			this.miFileCloseArea.Enabled = false;
			this.miFileCloseArea.Index = 0;
			this.miFileCloseArea.Text = "Close Entire Area";
			this.miFileCloseArea.Click += new System.EventHandler(this.miFileCloseArea_Click);
			// 
			// miFileCloseSep0
			// 
			this.miFileCloseSep0.Index = 1;
			this.miFileCloseSep0.Text = "-";
			// 
			// miFileCloseMobileFile
			// 
			this.miFileCloseMobileFile.Enabled = false;
			this.miFileCloseMobileFile.Index = 2;
			this.miFileCloseMobileFile.Text = "Close Mobile File";
			this.miFileCloseMobileFile.Click += new System.EventHandler(this.miFileCloseMobileFile_Click);
			// 
			// miFileCloseObjectFile
			// 
			this.miFileCloseObjectFile.Enabled = false;
			this.miFileCloseObjectFile.Index = 3;
			this.miFileCloseObjectFile.Text = "Close Object File";
			this.miFileCloseObjectFile.Click += new System.EventHandler(this.miFileCloseObjectFile_Click);
			// 
			// miFileCloseWorldFile
			// 
			this.miFileCloseWorldFile.Enabled = false;
			this.miFileCloseWorldFile.Index = 4;
			this.miFileCloseWorldFile.Text = "Close World File";
			this.miFileCloseWorldFile.Click += new System.EventHandler(this.miFileCloseWorldFile_Click);
			// 
			// miFileCloseShopFile
			// 
			this.miFileCloseShopFile.Enabled = false;
			this.miFileCloseShopFile.Index = 5;
			this.miFileCloseShopFile.Text = "Close Shop File";
			this.miFileCloseShopFile.Click += new System.EventHandler(this.miFileCloseShopFile_Click);
			// 
			// miFileCloseZoneFile
			// 
			this.miFileCloseZoneFile.Enabled = false;
			this.miFileCloseZoneFile.Index = 6;
			this.miFileCloseZoneFile.Text = "Close Zone File";
			this.miFileCloseZoneFile.Click += new System.EventHandler(this.miFileCloseZoneFile_Click);
			// 
			// miFileSep1
			// 
			this.miFileSep1.Index = 3;
			this.miFileSep1.Text = "-";
			// 
			// miFileSave
			// 
			this.miFileSave.Enabled = false;
			this.miFileSave.Index = 4;
			this.miFileSave.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.miFileSaveArea,
																					   this.miFileSaveSep0,
																					   this.miFileSaveMobileFile,
																					   this.miFileSaveObjectFile,
																					   this.miFileSaveWorldFile,
																					   this.miFileSaveShopFile,
																					   this.miFileSaveZoneFile});
			this.miFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.miFileSave.Text = "Save";
			// 
			// miFileSaveArea
			// 
			this.miFileSaveArea.Enabled = false;
			this.miFileSaveArea.Index = 0;
			this.miFileSaveArea.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
			this.miFileSaveArea.Text = "Save Entire Area";
			this.miFileSaveArea.Click += new System.EventHandler(this.miFileSaveArea_Click);
			// 
			// miFileSaveSep0
			// 
			this.miFileSaveSep0.Index = 1;
			this.miFileSaveSep0.Text = "-";
			// 
			// miFileSaveMobileFile
			// 
			this.miFileSaveMobileFile.Enabled = false;
			this.miFileSaveMobileFile.Index = 2;
			this.miFileSaveMobileFile.Text = "Save Mobile File";
			this.miFileSaveMobileFile.Click += new System.EventHandler(this.miFileSaveMobileFile_Click);
			// 
			// miFileSaveObjectFile
			// 
			this.miFileSaveObjectFile.Enabled = false;
			this.miFileSaveObjectFile.Index = 3;
			this.miFileSaveObjectFile.Text = "Save Object File";
			this.miFileSaveObjectFile.Click += new System.EventHandler(this.miFileSaveObjectFile_Click);
			// 
			// miFileSaveWorldFile
			// 
			this.miFileSaveWorldFile.Enabled = false;
			this.miFileSaveWorldFile.Index = 4;
			this.miFileSaveWorldFile.Text = "Save World File";
			this.miFileSaveWorldFile.Click += new System.EventHandler(this.miFileSaveWorldFile_Click);
			// 
			// miFileSaveShopFile
			// 
			this.miFileSaveShopFile.Enabled = false;
			this.miFileSaveShopFile.Index = 5;
			this.miFileSaveShopFile.Text = "Save Shop File";
			this.miFileSaveShopFile.Click += new System.EventHandler(this.miFileSaveShopFile_Click);
			// 
			// miFileSaveZoneFile
			// 
			this.miFileSaveZoneFile.Enabled = false;
			this.miFileSaveZoneFile.Index = 6;
			this.miFileSaveZoneFile.Text = "Save Zone File";
			this.miFileSaveZoneFile.Click += new System.EventHandler(this.miFileSaveZoneFile_Click);
			// 
			// miFileSep2
			// 
			this.miFileSep2.Index = 5;
			this.miFileSep2.Text = "-";
			// 
			// miFileExit
			// 
			this.miFileExit.Index = 6;
			this.miFileExit.Text = "E&xit";
			this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
			// 
			// miEdit
			// 
			this.miEdit.Enabled = false;
			this.miEdit.Index = 1;
			this.miEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.miEditUndo,
																				   this.miEditRedo,
																				   this.menuItem3,
																				   this.miEditCut,
																				   this.miEditCopy,
																				   this.miEditPaste});
			this.miEdit.Text = "&Edit";
			this.miEdit.Visible = false;
			// 
			// miEditUndo
			// 
			this.miEditUndo.Index = 0;
			this.miEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.miEditUndo.Text = "&Undo";
			// 
			// miEditRedo
			// 
			this.miEditRedo.Index = 1;
			this.miEditRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
			this.miEditRedo.Text = "&Redo";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// miEditCut
			// 
			this.miEditCut.Index = 3;
			this.miEditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.miEditCut.Text = "Cu&t";
			// 
			// miEditCopy
			// 
			this.miEditCopy.Index = 4;
			this.miEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.miEditCopy.Text = "&Copy";
			// 
			// miEditPaste
			// 
			this.miEditPaste.Index = 5;
			this.miEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.miEditPaste.Text = "&Paste";
			// 
			// miTools
			// 
			this.miTools.Index = 2;
			this.miTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.miToolsLoadMUDConfiguration,
																					this.miToolsSep0,
																					this.miToolsOptions,
																					this.miToolsAutoGenerateComments});
			this.miTools.Text = "&Tools";
			// 
			// miToolsLoadMUDConfiguration
			// 
			this.miToolsLoadMUDConfiguration.Index = 0;
			this.miToolsLoadMUDConfiguration.Text = "&Load MUD Configuration";
			this.miToolsLoadMUDConfiguration.Click += new System.EventHandler(this.miToolsLoadMUDConfiguration_Click);
			// 
			// miToolsSep0
			// 
			this.miToolsSep0.Index = 1;
			this.miToolsSep0.Text = "-";
			// 
			// miToolsOptions
			// 
			this.miToolsOptions.Enabled = false;
			this.miToolsOptions.Index = 2;
			this.miToolsOptions.Text = "&Options...";
			this.miToolsOptions.Visible = false;
			// 
			// miToolsAutoGenerateComments
			// 
			this.miToolsAutoGenerateComments.Index = 3;
			this.miToolsAutoGenerateComments.Text = "Auto-Generate Zone File Comments";
			this.miToolsAutoGenerateComments.Click += new System.EventHandler(this.miToolsAutoGenerateComments_Click);
			// 
			// miHelp
			// 
			this.miHelp.Index = 3;
			this.miHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.miHelpAbout});
			this.miHelp.Text = "&Help";
			// 
			// miHelpAbout
			// 
			this.miHelpAbout.Index = 0;
			this.miHelpAbout.Text = "&About Circle World Creator...";
			this.miHelpAbout.Click += new System.EventHandler(this.miHelpAbout_Click);
			// 
			// sbMain
			// 
			this.sbMain.Location = new System.Drawing.Point(0, 529);
			this.sbMain.Name = "sbMain";
			this.sbMain.Size = new System.Drawing.Size(912, 24);
			this.sbMain.TabIndex = 0;
			this.sbMain.Text = "Welcome to Circle World Creator!";
			// 
			// tcEditors
			// 
			this.tcEditors.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.tpMobileEditor,
																					this.tpObjectEditor,
																					this.tpRoomEditor,
																					this.tpShopEditor,
																					this.tpZoneEditor});
			this.tcEditors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcEditors.Name = "tcEditors";
			this.tcEditors.SelectedIndex = 0;
			this.tcEditors.Size = new System.Drawing.Size(912, 529);
			this.tcEditors.TabIndex = 1;
			// 
			// tpMobileEditor
			// 
			this.tpMobileEditor.AutoScroll = true;
			this.tpMobileEditor.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.bMobDelete,
																						 this.bMobMove,
																						 this.bMobCopy,
																						 this.bMobSave,
																						 this.bMobNew,
																						 this.bMobESpecs,
																						 this.gbMobQuickSelect,
																						 this.gbMobGender,
																						 this.gbMobDefaultPosition,
																						 this.gbMobLoadPosition,
																						 this.gbMobExperience,
																						 this.gbMobArmorClass,
																						 this.gbMobAffectionBitvector,
																						 this.gbMobActionBitvector,
																						 this.gbMobVNum,
																						 this.gbMobShortDescription,
																						 this.gbMobLongDescription,
																						 this.gbMobAliasList,
																						 this.gbMobDetailedDescription,
																						 this.gbMobAlignment,
																						 this.gbMobLevel,
																						 this.gbMobHP,
																						 this.gbMobGold,
																						 this.gbMobBH,
																						 this.gbMobThaco});
			this.tpMobileEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tpMobileEditor.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tpMobileEditor.Location = new System.Drawing.Point(4, 22);
			this.tpMobileEditor.Name = "tpMobileEditor";
			this.tpMobileEditor.Size = new System.Drawing.Size(904, 503);
			this.tpMobileEditor.TabIndex = 0;
			this.tpMobileEditor.Text = "Mobile Editor";
			// 
			// bMobDelete
			// 
			this.bMobDelete.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bMobDelete.Location = new System.Drawing.Point(296, 409);
			this.bMobDelete.Name = "bMobDelete";
			this.bMobDelete.Size = new System.Drawing.Size(56, 23);
			this.bMobDelete.TabIndex = 24;
			this.bMobDelete.Text = "Delete";
			this.bMobDelete.Click += new System.EventHandler(this.bMobDelete_Click);
			// 
			// bMobMove
			// 
			this.bMobMove.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bMobMove.Location = new System.Drawing.Point(248, 409);
			this.bMobMove.Name = "bMobMove";
			this.bMobMove.Size = new System.Drawing.Size(40, 23);
			this.bMobMove.TabIndex = 23;
			this.bMobMove.Text = "Move";
			this.bMobMove.Click += new System.EventHandler(this.bMobMove_Click);
			// 
			// bMobCopy
			// 
			this.bMobCopy.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bMobCopy.Location = new System.Drawing.Point(200, 409);
			this.bMobCopy.Name = "bMobCopy";
			this.bMobCopy.Size = new System.Drawing.Size(40, 23);
			this.bMobCopy.TabIndex = 22;
			this.bMobCopy.Text = "Copy";
			this.bMobCopy.Click += new System.EventHandler(this.bMobCopy_Click);
			// 
			// bMobSave
			// 
			this.bMobSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bMobSave.Location = new System.Drawing.Point(152, 409);
			this.bMobSave.Name = "bMobSave";
			this.bMobSave.Size = new System.Drawing.Size(40, 23);
			this.bMobSave.TabIndex = 21;
			this.bMobSave.Text = "Save";
			this.bMobSave.Click += new System.EventHandler(this.bMobSave_Click);
			// 
			// bMobNew
			// 
			this.bMobNew.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bMobNew.Location = new System.Drawing.Point(104, 409);
			this.bMobNew.Name = "bMobNew";
			this.bMobNew.Size = new System.Drawing.Size(40, 23);
			this.bMobNew.TabIndex = 20;
			this.bMobNew.Text = "New";
			this.bMobNew.Click += new System.EventHandler(this.bMobNew_Click);
			// 
			// bMobESpecs
			// 
			this.bMobESpecs.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.bMobESpecs.Location = new System.Drawing.Point(712, 448);
			this.bMobESpecs.Name = "bMobESpecs";
			this.bMobESpecs.Size = new System.Drawing.Size(168, 23);
			this.bMobESpecs.TabIndex = 17;
			this.bMobESpecs.Text = "E-Specs";
			this.bMobESpecs.Click += new System.EventHandler(this.bMobESpecs_Click);
			// 
			// gbMobQuickSelect
			// 
			this.gbMobQuickSelect.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbMobQuickSelect.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.cboxMobQuickSelect});
			this.gbMobQuickSelect.Location = new System.Drawing.Point(8, 449);
			this.gbMobQuickSelect.Name = "gbMobQuickSelect";
			this.gbMobQuickSelect.Size = new System.Drawing.Size(344, 48);
			this.gbMobQuickSelect.TabIndex = 19;
			this.gbMobQuickSelect.TabStop = false;
			this.gbMobQuickSelect.Text = "Mobile Quick-Select";
			// 
			// cboxMobQuickSelect
			// 
			this.cboxMobQuickSelect.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxMobQuickSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxMobQuickSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxMobQuickSelect.Location = new System.Drawing.Point(8, 16);
			this.cboxMobQuickSelect.MaxDropDownItems = 16;
			this.cboxMobQuickSelect.Name = "cboxMobQuickSelect";
			this.cboxMobQuickSelect.Size = new System.Drawing.Size(328, 21);
			this.cboxMobQuickSelect.TabIndex = 0;
			this.cboxMobQuickSelect.SelectedIndexChanged += new System.EventHandler(this.cboxMobQuickSelect_SelectedIndexChanged);
			// 
			// gbMobGender
			// 
			this.gbMobGender.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobGender.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.cboxMobGender});
			this.gbMobGender.Location = new System.Drawing.Point(696, 296);
			this.gbMobGender.Name = "gbMobGender";
			this.gbMobGender.Size = new System.Drawing.Size(200, 48);
			this.gbMobGender.TabIndex = 12;
			this.gbMobGender.TabStop = false;
			this.gbMobGender.Text = "Gender";
			// 
			// cboxMobGender
			// 
			this.cboxMobGender.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxMobGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxMobGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxMobGender.Location = new System.Drawing.Point(8, 16);
			this.cboxMobGender.MaxDropDownItems = 16;
			this.cboxMobGender.Name = "cboxMobGender";
			this.cboxMobGender.Size = new System.Drawing.Size(184, 21);
			this.cboxMobGender.TabIndex = 0;
			this.cboxMobGender.SelectedIndexChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobDefaultPosition
			// 
			this.gbMobDefaultPosition.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobDefaultPosition.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.cboxMobDefaultPosition});
			this.gbMobDefaultPosition.Location = new System.Drawing.Point(696, 392);
			this.gbMobDefaultPosition.Name = "gbMobDefaultPosition";
			this.gbMobDefaultPosition.Size = new System.Drawing.Size(200, 48);
			this.gbMobDefaultPosition.TabIndex = 14;
			this.gbMobDefaultPosition.TabStop = false;
			this.gbMobDefaultPosition.Text = "Default Position";
			// 
			// cboxMobDefaultPosition
			// 
			this.cboxMobDefaultPosition.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxMobDefaultPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxMobDefaultPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxMobDefaultPosition.Location = new System.Drawing.Point(8, 16);
			this.cboxMobDefaultPosition.MaxDropDownItems = 16;
			this.cboxMobDefaultPosition.Name = "cboxMobDefaultPosition";
			this.cboxMobDefaultPosition.Size = new System.Drawing.Size(184, 21);
			this.cboxMobDefaultPosition.TabIndex = 0;
			this.cboxMobDefaultPosition.SelectedIndexChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobLoadPosition
			// 
			this.gbMobLoadPosition.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobLoadPosition.Controls.AddRange(new System.Windows.Forms.Control[] {
																							this.cboxMobLoadPosition});
			this.gbMobLoadPosition.Location = new System.Drawing.Point(696, 344);
			this.gbMobLoadPosition.Name = "gbMobLoadPosition";
			this.gbMobLoadPosition.Size = new System.Drawing.Size(200, 48);
			this.gbMobLoadPosition.TabIndex = 13;
			this.gbMobLoadPosition.TabStop = false;
			this.gbMobLoadPosition.Text = "Load Position";
			// 
			// cboxMobLoadPosition
			// 
			this.cboxMobLoadPosition.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxMobLoadPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxMobLoadPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxMobLoadPosition.Location = new System.Drawing.Point(8, 16);
			this.cboxMobLoadPosition.MaxDropDownItems = 16;
			this.cboxMobLoadPosition.Name = "cboxMobLoadPosition";
			this.cboxMobLoadPosition.Size = new System.Drawing.Size(184, 21);
			this.cboxMobLoadPosition.TabIndex = 0;
			this.cboxMobLoadPosition.SelectedIndexChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobExperience
			// 
			this.gbMobExperience.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobExperience.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.nudMobExperience});
			this.gbMobExperience.Location = new System.Drawing.Point(696, 104);
			this.gbMobExperience.Name = "gbMobExperience";
			this.gbMobExperience.Size = new System.Drawing.Size(200, 48);
			this.gbMobExperience.TabIndex = 8;
			this.gbMobExperience.TabStop = false;
			this.gbMobExperience.Text = "Experience";
			// 
			// nudMobExperience
			// 
			this.nudMobExperience.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudMobExperience.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobExperience.Location = new System.Drawing.Point(8, 16);
			this.nudMobExperience.Maximum = new System.Decimal(new int[] {
																			 0,
																			 0,
																			 0,
																			 0});
			this.nudMobExperience.Name = "nudMobExperience";
			this.nudMobExperience.Size = new System.Drawing.Size(184, 22);
			this.nudMobExperience.TabIndex = 0;
			this.nudMobExperience.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobArmorClass
			// 
			this.gbMobArmorClass.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobArmorClass.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.nudMobArmorClass});
			this.gbMobArmorClass.Location = new System.Drawing.Point(800, 56);
			this.gbMobArmorClass.Name = "gbMobArmorClass";
			this.gbMobArmorClass.Size = new System.Drawing.Size(96, 48);
			this.gbMobArmorClass.TabIndex = 7;
			this.gbMobArmorClass.TabStop = false;
			this.gbMobArmorClass.Text = "Armor Class";
			// 
			// nudMobArmorClass
			// 
			this.nudMobArmorClass.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudMobArmorClass.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobArmorClass.Location = new System.Drawing.Point(8, 16);
			this.nudMobArmorClass.Maximum = new System.Decimal(new int[] {
																			 0,
																			 0,
																			 0,
																			 0});
			this.nudMobArmorClass.Name = "nudMobArmorClass";
			this.nudMobArmorClass.Size = new System.Drawing.Size(80, 22);
			this.nudMobArmorClass.TabIndex = 0;
			this.nudMobArmorClass.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobAffectionBitvector
			// 
			this.gbMobAffectionBitvector.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobAffectionBitvector.Controls.AddRange(new System.Windows.Forms.Control[] {
																								  this.clboxMobAffectionBitvector});
			this.gbMobAffectionBitvector.Location = new System.Drawing.Point(528, 393);
			this.gbMobAffectionBitvector.Name = "gbMobAffectionBitvector";
			this.gbMobAffectionBitvector.Size = new System.Drawing.Size(160, 104);
			this.gbMobAffectionBitvector.TabIndex = 16;
			this.gbMobAffectionBitvector.TabStop = false;
			this.gbMobAffectionBitvector.Text = "Affection Bitvector";
			// 
			// clboxMobAffectionBitvector
			// 
			this.clboxMobAffectionBitvector.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.clboxMobAffectionBitvector.CheckOnClick = true;
			this.clboxMobAffectionBitvector.Location = new System.Drawing.Point(8, 16);
			this.clboxMobAffectionBitvector.Name = "clboxMobAffectionBitvector";
			this.clboxMobAffectionBitvector.Size = new System.Drawing.Size(144, 79);
			this.clboxMobAffectionBitvector.TabIndex = 0;
			this.clboxMobAffectionBitvector.SelectedIndexChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobActionBitvector
			// 
			this.gbMobActionBitvector.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobActionBitvector.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.clboxMobActionBitvector});
			this.gbMobActionBitvector.Location = new System.Drawing.Point(360, 393);
			this.gbMobActionBitvector.Name = "gbMobActionBitvector";
			this.gbMobActionBitvector.Size = new System.Drawing.Size(160, 104);
			this.gbMobActionBitvector.TabIndex = 15;
			this.gbMobActionBitvector.TabStop = false;
			this.gbMobActionBitvector.Text = "Action Bitvector";
			// 
			// clboxMobActionBitvector
			// 
			this.clboxMobActionBitvector.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.clboxMobActionBitvector.CheckOnClick = true;
			this.clboxMobActionBitvector.Location = new System.Drawing.Point(8, 16);
			this.clboxMobActionBitvector.Name = "clboxMobActionBitvector";
			this.clboxMobActionBitvector.Size = new System.Drawing.Size(144, 79);
			this.clboxMobActionBitvector.TabIndex = 0;
			this.clboxMobActionBitvector.SelectedIndexChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobVNum
			// 
			this.gbMobVNum.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.gbMobVNum.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.nudMobVNum});
			this.gbMobVNum.Location = new System.Drawing.Point(8, 393);
			this.gbMobVNum.Name = "gbMobVNum";
			this.gbMobVNum.Size = new System.Drawing.Size(88, 48);
			this.gbMobVNum.TabIndex = 18;
			this.gbMobVNum.TabStop = false;
			this.gbMobVNum.Text = "VNum";
			// 
			// nudMobVNum
			// 
			this.nudMobVNum.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudMobVNum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobVNum.Location = new System.Drawing.Point(8, 16);
			this.nudMobVNum.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudMobVNum.Name = "nudMobVNum";
			this.nudMobVNum.Size = new System.Drawing.Size(72, 22);
			this.nudMobVNum.TabIndex = 0;
			this.nudMobVNum.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobShortDescription
			// 
			this.gbMobShortDescription.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbMobShortDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																								this.tbMobShortDescription});
			this.gbMobShortDescription.Location = new System.Drawing.Point(8, 56);
			this.gbMobShortDescription.Name = "gbMobShortDescription";
			this.gbMobShortDescription.Size = new System.Drawing.Size(664, 48);
			this.gbMobShortDescription.TabIndex = 1;
			this.gbMobShortDescription.TabStop = false;
			this.gbMobShortDescription.Text = "Short Description";
			// 
			// tbMobShortDescription
			// 
			this.tbMobShortDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbMobShortDescription.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbMobShortDescription.Location = new System.Drawing.Point(8, 16);
			this.tbMobShortDescription.Name = "tbMobShortDescription";
			this.tbMobShortDescription.Size = new System.Drawing.Size(648, 22);
			this.tbMobShortDescription.TabIndex = 0;
			this.tbMobShortDescription.Text = "";
			this.tbMobShortDescription.TextChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobLongDescription
			// 
			this.gbMobLongDescription.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbMobLongDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.tbMobLongDescription});
			this.gbMobLongDescription.Location = new System.Drawing.Point(8, 104);
			this.gbMobLongDescription.Name = "gbMobLongDescription";
			this.gbMobLongDescription.Size = new System.Drawing.Size(664, 48);
			this.gbMobLongDescription.TabIndex = 2;
			this.gbMobLongDescription.TabStop = false;
			this.gbMobLongDescription.Text = "Long Description";
			// 
			// tbMobLongDescription
			// 
			this.tbMobLongDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbMobLongDescription.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbMobLongDescription.Location = new System.Drawing.Point(8, 16);
			this.tbMobLongDescription.Name = "tbMobLongDescription";
			this.tbMobLongDescription.Size = new System.Drawing.Size(648, 22);
			this.tbMobLongDescription.TabIndex = 0;
			this.tbMobLongDescription.Text = "";
			this.tbMobLongDescription.TextChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobAliasList
			// 
			this.gbMobAliasList.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbMobAliasList.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.tbMobAliasList});
			this.gbMobAliasList.Location = new System.Drawing.Point(8, 8);
			this.gbMobAliasList.Name = "gbMobAliasList";
			this.gbMobAliasList.Size = new System.Drawing.Size(664, 48);
			this.gbMobAliasList.TabIndex = 0;
			this.gbMobAliasList.TabStop = false;
			this.gbMobAliasList.Text = "Alias List";
			// 
			// tbMobAliasList
			// 
			this.tbMobAliasList.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbMobAliasList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbMobAliasList.Location = new System.Drawing.Point(8, 16);
			this.tbMobAliasList.Name = "tbMobAliasList";
			this.tbMobAliasList.Size = new System.Drawing.Size(648, 22);
			this.tbMobAliasList.TabIndex = 0;
			this.tbMobAliasList.Text = "";
			this.tbMobAliasList.TextChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobDetailedDescription
			// 
			this.gbMobDetailedDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbMobDetailedDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																								   this.tbMobDetailedDescription});
			this.gbMobDetailedDescription.Location = new System.Drawing.Point(8, 152);
			this.gbMobDetailedDescription.Name = "gbMobDetailedDescription";
			this.gbMobDetailedDescription.Size = new System.Drawing.Size(680, 241);
			this.gbMobDetailedDescription.TabIndex = 3;
			this.gbMobDetailedDescription.TabStop = false;
			this.gbMobDetailedDescription.Text = "Detailed Description";
			// 
			// tbMobDetailedDescription
			// 
			this.tbMobDetailedDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbMobDetailedDescription.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbMobDetailedDescription.Location = new System.Drawing.Point(8, 16);
			this.tbMobDetailedDescription.Multiline = true;
			this.tbMobDetailedDescription.Name = "tbMobDetailedDescription";
			this.tbMobDetailedDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbMobDetailedDescription.Size = new System.Drawing.Size(664, 217);
			this.tbMobDetailedDescription.TabIndex = 0;
			this.tbMobDetailedDescription.Text = "";
			this.tbMobDetailedDescription.TextChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobAlignment
			// 
			this.gbMobAlignment.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobAlignment.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.nudMobAlignment});
			this.gbMobAlignment.Location = new System.Drawing.Point(800, 8);
			this.gbMobAlignment.Name = "gbMobAlignment";
			this.gbMobAlignment.Size = new System.Drawing.Size(96, 48);
			this.gbMobAlignment.TabIndex = 5;
			this.gbMobAlignment.TabStop = false;
			this.gbMobAlignment.Text = "Alignment";
			// 
			// nudMobAlignment
			// 
			this.nudMobAlignment.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudMobAlignment.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobAlignment.Location = new System.Drawing.Point(8, 16);
			this.nudMobAlignment.Maximum = new System.Decimal(new int[] {
																			0,
																			0,
																			0,
																			0});
			this.nudMobAlignment.Name = "nudMobAlignment";
			this.nudMobAlignment.Size = new System.Drawing.Size(80, 22);
			this.nudMobAlignment.TabIndex = 0;
			this.nudMobAlignment.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobLevel
			// 
			this.gbMobLevel.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobLevel.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.nudMobLevel});
			this.gbMobLevel.Location = new System.Drawing.Point(696, 8);
			this.gbMobLevel.Name = "gbMobLevel";
			this.gbMobLevel.Size = new System.Drawing.Size(96, 48);
			this.gbMobLevel.TabIndex = 4;
			this.gbMobLevel.TabStop = false;
			this.gbMobLevel.Text = "Level";
			// 
			// nudMobLevel
			// 
			this.nudMobLevel.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudMobLevel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobLevel.Location = new System.Drawing.Point(8, 16);
			this.nudMobLevel.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudMobLevel.Name = "nudMobLevel";
			this.nudMobLevel.Size = new System.Drawing.Size(80, 22);
			this.nudMobLevel.TabIndex = 0;
			this.nudMobLevel.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobHP
			// 
			this.gbMobHP.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobHP.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.lMobHPPlus,
																				  this.lMobHPDie,
																				  this.nudMobHPAdd,
																				  this.nudMobHPDie,
																				  this.nudMobHPNum});
			this.gbMobHP.Location = new System.Drawing.Point(696, 200);
			this.gbMobHP.Name = "gbMobHP";
			this.gbMobHP.Size = new System.Drawing.Size(200, 48);
			this.gbMobHP.TabIndex = 10;
			this.gbMobHP.TabStop = false;
			this.gbMobHP.Text = "Hit Points";
			// 
			// lMobHPPlus
			// 
			this.lMobHPPlus.Location = new System.Drawing.Point(120, 16);
			this.lMobHPPlus.Name = "lMobHPPlus";
			this.lMobHPPlus.Size = new System.Drawing.Size(16, 24);
			this.lMobHPPlus.TabIndex = 4;
			this.lMobHPPlus.Text = "+";
			this.lMobHPPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lMobHPDie
			// 
			this.lMobHPDie.Location = new System.Drawing.Point(56, 16);
			this.lMobHPDie.Name = "lMobHPDie";
			this.lMobHPDie.Size = new System.Drawing.Size(16, 24);
			this.lMobHPDie.TabIndex = 3;
			this.lMobHPDie.Text = "d";
			this.lMobHPDie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nudMobHPAdd
			// 
			this.nudMobHPAdd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobHPAdd.Location = new System.Drawing.Point(136, 16);
			this.nudMobHPAdd.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudMobHPAdd.Name = "nudMobHPAdd";
			this.nudMobHPAdd.Size = new System.Drawing.Size(56, 20);
			this.nudMobHPAdd.TabIndex = 2;
			this.nudMobHPAdd.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// nudMobHPDie
			// 
			this.nudMobHPDie.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobHPDie.Location = new System.Drawing.Point(72, 16);
			this.nudMobHPDie.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudMobHPDie.Name = "nudMobHPDie";
			this.nudMobHPDie.Size = new System.Drawing.Size(48, 20);
			this.nudMobHPDie.TabIndex = 1;
			this.nudMobHPDie.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// nudMobHPNum
			// 
			this.nudMobHPNum.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobHPNum.Location = new System.Drawing.Point(8, 16);
			this.nudMobHPNum.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudMobHPNum.Name = "nudMobHPNum";
			this.nudMobHPNum.Size = new System.Drawing.Size(48, 20);
			this.nudMobHPNum.TabIndex = 0;
			this.nudMobHPNum.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobGold
			// 
			this.gbMobGold.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobGold.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.nudMobGold});
			this.gbMobGold.Location = new System.Drawing.Point(696, 152);
			this.gbMobGold.Name = "gbMobGold";
			this.gbMobGold.Size = new System.Drawing.Size(200, 48);
			this.gbMobGold.TabIndex = 9;
			this.gbMobGold.TabStop = false;
			this.gbMobGold.Text = "Gold";
			// 
			// nudMobGold
			// 
			this.nudMobGold.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudMobGold.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobGold.Location = new System.Drawing.Point(8, 16);
			this.nudMobGold.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudMobGold.Name = "nudMobGold";
			this.nudMobGold.Size = new System.Drawing.Size(184, 22);
			this.nudMobGold.TabIndex = 0;
			this.nudMobGold.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobBH
			// 
			this.gbMobBH.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobBH.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.lMobBHPlus,
																				  this.lMobBHDie,
																				  this.nudMobBHAdd,
																				  this.nudMobBHDie,
																				  this.nudMobBHNum});
			this.gbMobBH.Location = new System.Drawing.Point(696, 248);
			this.gbMobBH.Name = "gbMobBH";
			this.gbMobBH.Size = new System.Drawing.Size(200, 48);
			this.gbMobBH.TabIndex = 11;
			this.gbMobBH.TabStop = false;
			this.gbMobBH.Text = "Bare Hand";
			// 
			// lMobBHPlus
			// 
			this.lMobBHPlus.Location = new System.Drawing.Point(120, 16);
			this.lMobBHPlus.Name = "lMobBHPlus";
			this.lMobBHPlus.Size = new System.Drawing.Size(16, 24);
			this.lMobBHPlus.TabIndex = 7;
			this.lMobBHPlus.Text = "+";
			this.lMobBHPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lMobBHDie
			// 
			this.lMobBHDie.Location = new System.Drawing.Point(56, 16);
			this.lMobBHDie.Name = "lMobBHDie";
			this.lMobBHDie.Size = new System.Drawing.Size(16, 24);
			this.lMobBHDie.TabIndex = 6;
			this.lMobBHDie.Text = "d";
			this.lMobBHDie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nudMobBHAdd
			// 
			this.nudMobBHAdd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobBHAdd.Location = new System.Drawing.Point(136, 16);
			this.nudMobBHAdd.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudMobBHAdd.Name = "nudMobBHAdd";
			this.nudMobBHAdd.Size = new System.Drawing.Size(56, 20);
			this.nudMobBHAdd.TabIndex = 2;
			this.nudMobBHAdd.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// nudMobBHDie
			// 
			this.nudMobBHDie.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobBHDie.Location = new System.Drawing.Point(72, 16);
			this.nudMobBHDie.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudMobBHDie.Name = "nudMobBHDie";
			this.nudMobBHDie.Size = new System.Drawing.Size(48, 20);
			this.nudMobBHDie.TabIndex = 1;
			this.nudMobBHDie.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// nudMobBHNum
			// 
			this.nudMobBHNum.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobBHNum.Location = new System.Drawing.Point(8, 16);
			this.nudMobBHNum.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudMobBHNum.Name = "nudMobBHNum";
			this.nudMobBHNum.Size = new System.Drawing.Size(48, 20);
			this.nudMobBHNum.TabIndex = 0;
			this.nudMobBHNum.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// gbMobThaco
			// 
			this.gbMobThaco.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobThaco.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.nudMobThaco});
			this.gbMobThaco.Location = new System.Drawing.Point(696, 56);
			this.gbMobThaco.Name = "gbMobThaco";
			this.gbMobThaco.Size = new System.Drawing.Size(96, 48);
			this.gbMobThaco.TabIndex = 6;
			this.gbMobThaco.TabStop = false;
			this.gbMobThaco.Text = "Thaco";
			// 
			// nudMobThaco
			// 
			this.nudMobThaco.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudMobThaco.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobThaco.Location = new System.Drawing.Point(8, 16);
			this.nudMobThaco.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudMobThaco.Name = "nudMobThaco";
			this.nudMobThaco.Size = new System.Drawing.Size(80, 22);
			this.nudMobThaco.TabIndex = 0;
			this.nudMobThaco.ValueChanged += new System.EventHandler(this.mobileEditorChanged);
			// 
			// tpObjectEditor
			// 
			this.tpObjectEditor.AutoScroll = true;
			this.tpObjectEditor.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.bObjDelete,
																						 this.bObjMove,
																						 this.bObjCopy,
																						 this.bObjSave,
																						 this.bObjNew,
																						 this.bObjAffects,
																						 this.gbObjValues,
																						 this.bObjExtraDescriptions,
																						 this.gbObjCost,
																						 this.gbObjRentPerDay,
																						 this.gbObjWearBitvector,
																						 this.gbObjEffectsBitvector,
																						 this.gbObjTypeFlag,
																						 this.gbObjQuickSelect,
																						 this.gbObjVNum,
																						 this.gbObjShortDescription,
																						 this.gbObjLongDescription,
																						 this.gbObjAliasList,
																						 this.gbObjActionDescription,
																						 this.gbObjWeight});
			this.tpObjectEditor.Location = new System.Drawing.Point(4, 22);
			this.tpObjectEditor.Name = "tpObjectEditor";
			this.tpObjectEditor.Size = new System.Drawing.Size(904, 503);
			this.tpObjectEditor.TabIndex = 1;
			this.tpObjectEditor.Text = "Object Editor";
			// 
			// bObjDelete
			// 
			this.bObjDelete.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bObjDelete.Location = new System.Drawing.Point(296, 409);
			this.bObjDelete.Name = "bObjDelete";
			this.bObjDelete.Size = new System.Drawing.Size(56, 23);
			this.bObjDelete.TabIndex = 19;
			this.bObjDelete.Text = "Delete";
			this.bObjDelete.Click += new System.EventHandler(this.bObjDelete_Click);
			// 
			// bObjMove
			// 
			this.bObjMove.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bObjMove.Location = new System.Drawing.Point(248, 409);
			this.bObjMove.Name = "bObjMove";
			this.bObjMove.Size = new System.Drawing.Size(40, 23);
			this.bObjMove.TabIndex = 18;
			this.bObjMove.Text = "Move";
			this.bObjMove.Click += new System.EventHandler(this.bObjMove_Click);
			// 
			// bObjCopy
			// 
			this.bObjCopy.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bObjCopy.Location = new System.Drawing.Point(200, 409);
			this.bObjCopy.Name = "bObjCopy";
			this.bObjCopy.Size = new System.Drawing.Size(40, 23);
			this.bObjCopy.TabIndex = 17;
			this.bObjCopy.Text = "Copy";
			this.bObjCopy.Click += new System.EventHandler(this.bObjCopy_Click);
			// 
			// bObjSave
			// 
			this.bObjSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bObjSave.Location = new System.Drawing.Point(152, 409);
			this.bObjSave.Name = "bObjSave";
			this.bObjSave.Size = new System.Drawing.Size(40, 23);
			this.bObjSave.TabIndex = 16;
			this.bObjSave.Text = "Save";
			this.bObjSave.Click += new System.EventHandler(this.bObjSave_Click);
			// 
			// bObjNew
			// 
			this.bObjNew.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bObjNew.Location = new System.Drawing.Point(104, 409);
			this.bObjNew.Name = "bObjNew";
			this.bObjNew.Size = new System.Drawing.Size(40, 23);
			this.bObjNew.TabIndex = 15;
			this.bObjNew.Text = "New";
			this.bObjNew.Click += new System.EventHandler(this.bObjNew_Click);
			// 
			// bObjAffects
			// 
			this.bObjAffects.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.bObjAffects.Location = new System.Drawing.Point(712, 472);
			this.bObjAffects.Name = "bObjAffects";
			this.bObjAffects.Size = new System.Drawing.Size(168, 23);
			this.bObjAffects.TabIndex = 12;
			this.bObjAffects.Text = "Object Affects";
			this.bObjAffects.Click += new System.EventHandler(this.bObjAffects_Click);
			// 
			// gbObjValues
			// 
			this.gbObjValues.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbObjValues.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.gbObjValue3,
																					  this.gbObjValue2,
																					  this.gbObjValue1,
																					  this.gbObjValue0});
			this.gbObjValues.Location = new System.Drawing.Point(696, 152);
			this.gbObjValues.Name = "gbObjValues";
			this.gbObjValues.Size = new System.Drawing.Size(200, 288);
			this.gbObjValues.TabIndex = 8;
			this.gbObjValues.TabStop = false;
			this.gbObjValues.Text = "Object Values";
			// 
			// gbObjValue3
			// 
			this.gbObjValue3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.cboxObjValue3,
																					  this.nudObjValue3});
			this.gbObjValue3.Enabled = false;
			this.gbObjValue3.Location = new System.Drawing.Point(8, 208);
			this.gbObjValue3.Name = "gbObjValue3";
			this.gbObjValue3.Size = new System.Drawing.Size(184, 64);
			this.gbObjValue3.TabIndex = 3;
			this.gbObjValue3.TabStop = false;
			this.gbObjValue3.Text = "Object Value 3";
			// 
			// cboxObjValue3
			// 
			this.cboxObjValue3.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxObjValue3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxObjValue3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxObjValue3.Location = new System.Drawing.Point(8, 40);
			this.cboxObjValue3.MaxDropDownItems = 16;
			this.cboxObjValue3.Name = "cboxObjValue3";
			this.cboxObjValue3.Size = new System.Drawing.Size(168, 21);
			this.cboxObjValue3.TabIndex = 1;
			this.cboxObjValue3.SelectedIndexChanged += new System.EventHandler(this.cboxObjValue3_SelectedIndexChanged);
			// 
			// nudObjValue3
			// 
			this.nudObjValue3.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudObjValue3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudObjValue3.Location = new System.Drawing.Point(8, 16);
			this.nudObjValue3.Maximum = new System.Decimal(new int[] {
																		 0,
																		 0,
																		 0,
																		 0});
			this.nudObjValue3.Name = "nudObjValue3";
			this.nudObjValue3.Size = new System.Drawing.Size(168, 20);
			this.nudObjValue3.TabIndex = 0;
			this.nudObjValue3.ValueChanged += new System.EventHandler(this.nudObjValue3_ValueChanged);
			// 
			// gbObjValue2
			// 
			this.gbObjValue2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.cboxObjValue2,
																					  this.nudObjValue2});
			this.gbObjValue2.Enabled = false;
			this.gbObjValue2.Location = new System.Drawing.Point(8, 144);
			this.gbObjValue2.Name = "gbObjValue2";
			this.gbObjValue2.Size = new System.Drawing.Size(184, 64);
			this.gbObjValue2.TabIndex = 2;
			this.gbObjValue2.TabStop = false;
			this.gbObjValue2.Text = "Object Value 2";
			// 
			// cboxObjValue2
			// 
			this.cboxObjValue2.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxObjValue2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxObjValue2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxObjValue2.Location = new System.Drawing.Point(8, 40);
			this.cboxObjValue2.MaxDropDownItems = 16;
			this.cboxObjValue2.Name = "cboxObjValue2";
			this.cboxObjValue2.Size = new System.Drawing.Size(168, 21);
			this.cboxObjValue2.TabIndex = 1;
			this.cboxObjValue2.SelectedIndexChanged += new System.EventHandler(this.cboxObjValue2_SelectedIndexChanged);
			// 
			// nudObjValue2
			// 
			this.nudObjValue2.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudObjValue2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudObjValue2.Location = new System.Drawing.Point(8, 16);
			this.nudObjValue2.Maximum = new System.Decimal(new int[] {
																		 0,
																		 0,
																		 0,
																		 0});
			this.nudObjValue2.Name = "nudObjValue2";
			this.nudObjValue2.Size = new System.Drawing.Size(168, 20);
			this.nudObjValue2.TabIndex = 0;
			this.nudObjValue2.ValueChanged += new System.EventHandler(this.nudObjValue2_ValueChanged);
			// 
			// gbObjValue1
			// 
			this.gbObjValue1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.cboxObjValue1,
																					  this.nudObjValue1});
			this.gbObjValue1.Enabled = false;
			this.gbObjValue1.Location = new System.Drawing.Point(8, 80);
			this.gbObjValue1.Name = "gbObjValue1";
			this.gbObjValue1.Size = new System.Drawing.Size(184, 64);
			this.gbObjValue1.TabIndex = 1;
			this.gbObjValue1.TabStop = false;
			this.gbObjValue1.Text = "Object Value 1";
			// 
			// cboxObjValue1
			// 
			this.cboxObjValue1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxObjValue1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxObjValue1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxObjValue1.Location = new System.Drawing.Point(8, 40);
			this.cboxObjValue1.MaxDropDownItems = 16;
			this.cboxObjValue1.Name = "cboxObjValue1";
			this.cboxObjValue1.Size = new System.Drawing.Size(168, 21);
			this.cboxObjValue1.TabIndex = 1;
			this.cboxObjValue1.SelectedIndexChanged += new System.EventHandler(this.cboxObjValue1_SelectedIndexChanged);
			// 
			// nudObjValue1
			// 
			this.nudObjValue1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudObjValue1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudObjValue1.Location = new System.Drawing.Point(8, 16);
			this.nudObjValue1.Maximum = new System.Decimal(new int[] {
																		 0,
																		 0,
																		 0,
																		 0});
			this.nudObjValue1.Name = "nudObjValue1";
			this.nudObjValue1.Size = new System.Drawing.Size(168, 20);
			this.nudObjValue1.TabIndex = 0;
			this.nudObjValue1.ValueChanged += new System.EventHandler(this.nudObjValue1_ValueChanged);
			// 
			// gbObjValue0
			// 
			this.gbObjValue0.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.cboxObjValue0,
																					  this.nudObjValue0});
			this.gbObjValue0.Enabled = false;
			this.gbObjValue0.Location = new System.Drawing.Point(8, 16);
			this.gbObjValue0.Name = "gbObjValue0";
			this.gbObjValue0.Size = new System.Drawing.Size(184, 64);
			this.gbObjValue0.TabIndex = 0;
			this.gbObjValue0.TabStop = false;
			this.gbObjValue0.Text = "Object Value 0";
			// 
			// cboxObjValue0
			// 
			this.cboxObjValue0.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxObjValue0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxObjValue0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxObjValue0.Location = new System.Drawing.Point(8, 40);
			this.cboxObjValue0.MaxDropDownItems = 16;
			this.cboxObjValue0.Name = "cboxObjValue0";
			this.cboxObjValue0.Size = new System.Drawing.Size(168, 21);
			this.cboxObjValue0.TabIndex = 1;
			this.cboxObjValue0.SelectedIndexChanged += new System.EventHandler(this.cboxObjValue0_SelectedIndexChanged);
			// 
			// nudObjValue0
			// 
			this.nudObjValue0.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudObjValue0.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudObjValue0.Location = new System.Drawing.Point(8, 16);
			this.nudObjValue0.Maximum = new System.Decimal(new int[] {
																		 0,
																		 0,
																		 0,
																		 0});
			this.nudObjValue0.Name = "nudObjValue0";
			this.nudObjValue0.Size = new System.Drawing.Size(168, 20);
			this.nudObjValue0.TabIndex = 0;
			this.nudObjValue0.ValueChanged += new System.EventHandler(this.nudObjValue0_ValueChanged);
			// 
			// bObjExtraDescriptions
			// 
			this.bObjExtraDescriptions.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.bObjExtraDescriptions.Location = new System.Drawing.Point(712, 448);
			this.bObjExtraDescriptions.Name = "bObjExtraDescriptions";
			this.bObjExtraDescriptions.Size = new System.Drawing.Size(168, 23);
			this.bObjExtraDescriptions.TabIndex = 11;
			this.bObjExtraDescriptions.Text = "Extra Descriptions";
			this.bObjExtraDescriptions.Click += new System.EventHandler(this.bObjExtraDescriptions_Click);
			// 
			// gbObjCost
			// 
			this.gbObjCost.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbObjCost.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.nudObjCost});
			this.gbObjCost.Location = new System.Drawing.Point(792, 8);
			this.gbObjCost.Name = "gbObjCost";
			this.gbObjCost.Size = new System.Drawing.Size(104, 48);
			this.gbObjCost.TabIndex = 5;
			this.gbObjCost.TabStop = false;
			this.gbObjCost.Text = "Cost";
			// 
			// nudObjCost
			// 
			this.nudObjCost.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudObjCost.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudObjCost.Location = new System.Drawing.Point(8, 16);
			this.nudObjCost.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudObjCost.Name = "nudObjCost";
			this.nudObjCost.Size = new System.Drawing.Size(88, 20);
			this.nudObjCost.TabIndex = 0;
			this.nudObjCost.ValueChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// gbObjRentPerDay
			// 
			this.gbObjRentPerDay.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbObjRentPerDay.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.nudObjRentPerDay});
			this.gbObjRentPerDay.Location = new System.Drawing.Point(792, 56);
			this.gbObjRentPerDay.Name = "gbObjRentPerDay";
			this.gbObjRentPerDay.Size = new System.Drawing.Size(104, 48);
			this.gbObjRentPerDay.TabIndex = 6;
			this.gbObjRentPerDay.TabStop = false;
			this.gbObjRentPerDay.Text = "Rent Per Day";
			// 
			// nudObjRentPerDay
			// 
			this.nudObjRentPerDay.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudObjRentPerDay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudObjRentPerDay.Location = new System.Drawing.Point(8, 16);
			this.nudObjRentPerDay.Maximum = new System.Decimal(new int[] {
																			 0,
																			 0,
																			 0,
																			 0});
			this.nudObjRentPerDay.Name = "nudObjRentPerDay";
			this.nudObjRentPerDay.Size = new System.Drawing.Size(88, 20);
			this.nudObjRentPerDay.TabIndex = 0;
			this.nudObjRentPerDay.ValueChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// gbObjWearBitvector
			// 
			this.gbObjWearBitvector.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbObjWearBitvector.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.clboxObjWearBitvector});
			this.gbObjWearBitvector.Location = new System.Drawing.Point(528, 393);
			this.gbObjWearBitvector.Name = "gbObjWearBitvector";
			this.gbObjWearBitvector.Size = new System.Drawing.Size(160, 104);
			this.gbObjWearBitvector.TabIndex = 10;
			this.gbObjWearBitvector.TabStop = false;
			this.gbObjWearBitvector.Text = "Wear Bitvector";
			// 
			// clboxObjWearBitvector
			// 
			this.clboxObjWearBitvector.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.clboxObjWearBitvector.CheckOnClick = true;
			this.clboxObjWearBitvector.Location = new System.Drawing.Point(8, 16);
			this.clboxObjWearBitvector.Name = "clboxObjWearBitvector";
			this.clboxObjWearBitvector.Size = new System.Drawing.Size(144, 79);
			this.clboxObjWearBitvector.TabIndex = 0;
			this.clboxObjWearBitvector.SelectedIndexChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// gbObjEffectsBitvector
			// 
			this.gbObjEffectsBitvector.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbObjEffectsBitvector.Controls.AddRange(new System.Windows.Forms.Control[] {
																								this.clboxObjEffectsBitvector});
			this.gbObjEffectsBitvector.Location = new System.Drawing.Point(360, 393);
			this.gbObjEffectsBitvector.Name = "gbObjEffectsBitvector";
			this.gbObjEffectsBitvector.Size = new System.Drawing.Size(160, 104);
			this.gbObjEffectsBitvector.TabIndex = 9;
			this.gbObjEffectsBitvector.TabStop = false;
			this.gbObjEffectsBitvector.Text = "Effects Bitvector";
			// 
			// clboxObjEffectsBitvector
			// 
			this.clboxObjEffectsBitvector.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.clboxObjEffectsBitvector.CheckOnClick = true;
			this.clboxObjEffectsBitvector.Location = new System.Drawing.Point(8, 16);
			this.clboxObjEffectsBitvector.Name = "clboxObjEffectsBitvector";
			this.clboxObjEffectsBitvector.Size = new System.Drawing.Size(144, 79);
			this.clboxObjEffectsBitvector.TabIndex = 0;
			this.clboxObjEffectsBitvector.SelectedIndexChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// gbObjTypeFlag
			// 
			this.gbObjTypeFlag.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbObjTypeFlag.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.cboxObjTypeFlag});
			this.gbObjTypeFlag.Location = new System.Drawing.Point(696, 104);
			this.gbObjTypeFlag.Name = "gbObjTypeFlag";
			this.gbObjTypeFlag.Size = new System.Drawing.Size(200, 48);
			this.gbObjTypeFlag.TabIndex = 7;
			this.gbObjTypeFlag.TabStop = false;
			this.gbObjTypeFlag.Text = "Type Flag";
			// 
			// cboxObjTypeFlag
			// 
			this.cboxObjTypeFlag.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxObjTypeFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxObjTypeFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxObjTypeFlag.Location = new System.Drawing.Point(8, 16);
			this.cboxObjTypeFlag.MaxDropDownItems = 16;
			this.cboxObjTypeFlag.Name = "cboxObjTypeFlag";
			this.cboxObjTypeFlag.Size = new System.Drawing.Size(184, 21);
			this.cboxObjTypeFlag.TabIndex = 0;
			this.cboxObjTypeFlag.SelectedIndexChanged += new System.EventHandler(this.cboxObjTypeFlag_SelectedIndexChanged);
			// 
			// gbObjQuickSelect
			// 
			this.gbObjQuickSelect.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbObjQuickSelect.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.cboxObjQuickSelect});
			this.gbObjQuickSelect.Location = new System.Drawing.Point(8, 449);
			this.gbObjQuickSelect.Name = "gbObjQuickSelect";
			this.gbObjQuickSelect.Size = new System.Drawing.Size(344, 48);
			this.gbObjQuickSelect.TabIndex = 14;
			this.gbObjQuickSelect.TabStop = false;
			this.gbObjQuickSelect.Text = "Object Quick-Select";
			// 
			// cboxObjQuickSelect
			// 
			this.cboxObjQuickSelect.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxObjQuickSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxObjQuickSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxObjQuickSelect.Location = new System.Drawing.Point(8, 16);
			this.cboxObjQuickSelect.MaxDropDownItems = 16;
			this.cboxObjQuickSelect.Name = "cboxObjQuickSelect";
			this.cboxObjQuickSelect.Size = new System.Drawing.Size(328, 21);
			this.cboxObjQuickSelect.TabIndex = 0;
			this.cboxObjQuickSelect.SelectedIndexChanged += new System.EventHandler(this.cboxObjQuickSelect_SelectedIndexChanged);
			// 
			// gbObjVNum
			// 
			this.gbObjVNum.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.gbObjVNum.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.nudObjVNum});
			this.gbObjVNum.Location = new System.Drawing.Point(8, 393);
			this.gbObjVNum.Name = "gbObjVNum";
			this.gbObjVNum.Size = new System.Drawing.Size(88, 48);
			this.gbObjVNum.TabIndex = 13;
			this.gbObjVNum.TabStop = false;
			this.gbObjVNum.Text = "VNum";
			// 
			// nudObjVNum
			// 
			this.nudObjVNum.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudObjVNum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudObjVNum.Location = new System.Drawing.Point(8, 16);
			this.nudObjVNum.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudObjVNum.Name = "nudObjVNum";
			this.nudObjVNum.Size = new System.Drawing.Size(72, 22);
			this.nudObjVNum.TabIndex = 0;
			this.nudObjVNum.ValueChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// gbObjShortDescription
			// 
			this.gbObjShortDescription.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbObjShortDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																								this.tbObjShortDescription});
			this.gbObjShortDescription.Location = new System.Drawing.Point(8, 56);
			this.gbObjShortDescription.Name = "gbObjShortDescription";
			this.gbObjShortDescription.Size = new System.Drawing.Size(664, 48);
			this.gbObjShortDescription.TabIndex = 1;
			this.gbObjShortDescription.TabStop = false;
			this.gbObjShortDescription.Text = "Short Description";
			// 
			// tbObjShortDescription
			// 
			this.tbObjShortDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbObjShortDescription.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbObjShortDescription.Location = new System.Drawing.Point(8, 16);
			this.tbObjShortDescription.Name = "tbObjShortDescription";
			this.tbObjShortDescription.Size = new System.Drawing.Size(648, 22);
			this.tbObjShortDescription.TabIndex = 0;
			this.tbObjShortDescription.Text = "";
			this.tbObjShortDescription.TextChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// gbObjLongDescription
			// 
			this.gbObjLongDescription.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbObjLongDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.tbObjLongDescription});
			this.gbObjLongDescription.Location = new System.Drawing.Point(8, 104);
			this.gbObjLongDescription.Name = "gbObjLongDescription";
			this.gbObjLongDescription.Size = new System.Drawing.Size(664, 48);
			this.gbObjLongDescription.TabIndex = 2;
			this.gbObjLongDescription.TabStop = false;
			this.gbObjLongDescription.Text = "Long Description";
			// 
			// tbObjLongDescription
			// 
			this.tbObjLongDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbObjLongDescription.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbObjLongDescription.Location = new System.Drawing.Point(8, 16);
			this.tbObjLongDescription.Name = "tbObjLongDescription";
			this.tbObjLongDescription.Size = new System.Drawing.Size(648, 22);
			this.tbObjLongDescription.TabIndex = 0;
			this.tbObjLongDescription.Text = "";
			this.tbObjLongDescription.TextChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// gbObjAliasList
			// 
			this.gbObjAliasList.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbObjAliasList.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.tbObjAliasList});
			this.gbObjAliasList.Location = new System.Drawing.Point(8, 8);
			this.gbObjAliasList.Name = "gbObjAliasList";
			this.gbObjAliasList.Size = new System.Drawing.Size(664, 48);
			this.gbObjAliasList.TabIndex = 0;
			this.gbObjAliasList.TabStop = false;
			this.gbObjAliasList.Text = "Alias List";
			// 
			// tbObjAliasList
			// 
			this.tbObjAliasList.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbObjAliasList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbObjAliasList.Location = new System.Drawing.Point(8, 16);
			this.tbObjAliasList.Name = "tbObjAliasList";
			this.tbObjAliasList.Size = new System.Drawing.Size(648, 22);
			this.tbObjAliasList.TabIndex = 0;
			this.tbObjAliasList.Text = "";
			this.tbObjAliasList.TextChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// gbObjActionDescription
			// 
			this.gbObjActionDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbObjActionDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																								 this.tbObjActionDescription});
			this.gbObjActionDescription.Location = new System.Drawing.Point(8, 152);
			this.gbObjActionDescription.Name = "gbObjActionDescription";
			this.gbObjActionDescription.Size = new System.Drawing.Size(680, 241);
			this.gbObjActionDescription.TabIndex = 3;
			this.gbObjActionDescription.TabStop = false;
			this.gbObjActionDescription.Text = "Action Description";
			// 
			// tbObjActionDescription
			// 
			this.tbObjActionDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbObjActionDescription.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbObjActionDescription.Location = new System.Drawing.Point(8, 16);
			this.tbObjActionDescription.Multiline = true;
			this.tbObjActionDescription.Name = "tbObjActionDescription";
			this.tbObjActionDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbObjActionDescription.Size = new System.Drawing.Size(664, 217);
			this.tbObjActionDescription.TabIndex = 0;
			this.tbObjActionDescription.Text = "";
			this.tbObjActionDescription.TextChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// gbObjWeight
			// 
			this.gbObjWeight.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbObjWeight.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.nudObjWeight});
			this.gbObjWeight.Location = new System.Drawing.Point(696, 8);
			this.gbObjWeight.Name = "gbObjWeight";
			this.gbObjWeight.Size = new System.Drawing.Size(88, 48);
			this.gbObjWeight.TabIndex = 4;
			this.gbObjWeight.TabStop = false;
			this.gbObjWeight.Text = "Weight";
			// 
			// nudObjWeight
			// 
			this.nudObjWeight.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudObjWeight.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudObjWeight.Location = new System.Drawing.Point(8, 16);
			this.nudObjWeight.Maximum = new System.Decimal(new int[] {
																		 0,
																		 0,
																		 0,
																		 0});
			this.nudObjWeight.Name = "nudObjWeight";
			this.nudObjWeight.Size = new System.Drawing.Size(72, 20);
			this.nudObjWeight.TabIndex = 0;
			this.nudObjWeight.ValueChanged += new System.EventHandler(this.objectEditorChanged);
			// 
			// tpRoomEditor
			// 
			this.tpRoomEditor.AutoScroll = true;
			this.tpRoomEditor.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.bWldExtraDescriptions,
																					   this.bWldDelete,
																					   this.bWldMove,
																					   this.bWldCopy,
																					   this.bWldSave,
																					   this.bWldNew,
																					   this.gbWldDirections,
																					   this.gbWldSectorType,
																					   this.gbWldRoomBitvector,
																					   this.gbWldQuickSelect,
																					   this.gbWldVNum,
																					   this.gbWldRoomName,
																					   this.gbWldRoomDescription});
			this.tpRoomEditor.Location = new System.Drawing.Point(4, 22);
			this.tpRoomEditor.Name = "tpRoomEditor";
			this.tpRoomEditor.Size = new System.Drawing.Size(904, 503);
			this.tpRoomEditor.TabIndex = 2;
			this.tpRoomEditor.Text = "Room Editor";
			// 
			// bWldExtraDescriptions
			// 
			this.bWldExtraDescriptions.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.bWldExtraDescriptions.Location = new System.Drawing.Point(712, 448);
			this.bWldExtraDescriptions.Name = "bWldExtraDescriptions";
			this.bWldExtraDescriptions.Size = new System.Drawing.Size(168, 23);
			this.bWldExtraDescriptions.TabIndex = 5;
			this.bWldExtraDescriptions.Text = "Extra Descriptions";
			this.bWldExtraDescriptions.Click += new System.EventHandler(this.bWldExtraDescriptions_Click);
			// 
			// bWldDelete
			// 
			this.bWldDelete.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bWldDelete.Location = new System.Drawing.Point(296, 409);
			this.bWldDelete.Name = "bWldDelete";
			this.bWldDelete.Size = new System.Drawing.Size(56, 23);
			this.bWldDelete.TabIndex = 12;
			this.bWldDelete.Text = "Delete";
			this.bWldDelete.Click += new System.EventHandler(this.bWldDelete_Click);
			// 
			// bWldMove
			// 
			this.bWldMove.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bWldMove.Location = new System.Drawing.Point(248, 409);
			this.bWldMove.Name = "bWldMove";
			this.bWldMove.Size = new System.Drawing.Size(40, 23);
			this.bWldMove.TabIndex = 11;
			this.bWldMove.Text = "Move";
			this.bWldMove.Click += new System.EventHandler(this.bWldMove_Click);
			// 
			// bWldCopy
			// 
			this.bWldCopy.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bWldCopy.Location = new System.Drawing.Point(200, 409);
			this.bWldCopy.Name = "bWldCopy";
			this.bWldCopy.Size = new System.Drawing.Size(40, 23);
			this.bWldCopy.TabIndex = 10;
			this.bWldCopy.Text = "Copy";
			this.bWldCopy.Click += new System.EventHandler(this.bWldCopy_Click);
			// 
			// bWldSave
			// 
			this.bWldSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bWldSave.Location = new System.Drawing.Point(152, 409);
			this.bWldSave.Name = "bWldSave";
			this.bWldSave.Size = new System.Drawing.Size(40, 23);
			this.bWldSave.TabIndex = 9;
			this.bWldSave.Text = "Save";
			this.bWldSave.Click += new System.EventHandler(this.bWldSave_Click);
			// 
			// bWldNew
			// 
			this.bWldNew.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bWldNew.Location = new System.Drawing.Point(104, 409);
			this.bWldNew.Name = "bWldNew";
			this.bWldNew.Size = new System.Drawing.Size(40, 23);
			this.bWldNew.TabIndex = 8;
			this.bWldNew.Text = "New";
			this.bWldNew.Click += new System.EventHandler(this.bWldNew_Click);
			// 
			// gbWldDirections
			// 
			this.gbWldDirections.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbWldDirections.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.gbWldCurrentExit,
																						  this.gbWldExits});
			this.gbWldDirections.Location = new System.Drawing.Point(696, 8);
			this.gbWldDirections.Name = "gbWldDirections";
			this.gbWldDirections.Size = new System.Drawing.Size(200, 432);
			this.gbWldDirections.TabIndex = 4;
			this.gbWldDirections.TabStop = false;
			this.gbWldDirections.Text = "Directions";
			// 
			// gbWldCurrentExit
			// 
			this.gbWldCurrentExit.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.bWldDoorDescription,
																						   this.cbWldNowhere,
																						   this.cbWldExitExists,
																						   this.gbWldDoorFlag,
																						   this.gbWldDoorKey});
			this.gbWldCurrentExit.Location = new System.Drawing.Point(8, 184);
			this.gbWldCurrentExit.Name = "gbWldCurrentExit";
			this.gbWldCurrentExit.Size = new System.Drawing.Size(184, 240);
			this.gbWldCurrentExit.TabIndex = 1;
			this.gbWldCurrentExit.TabStop = false;
			this.gbWldCurrentExit.Text = "Current Exit";
			// 
			// bWldDoorDescription
			// 
			this.bWldDoorDescription.Enabled = false;
			this.bWldDoorDescription.Location = new System.Drawing.Point(8, 208);
			this.bWldDoorDescription.Name = "bWldDoorDescription";
			this.bWldDoorDescription.Size = new System.Drawing.Size(168, 24);
			this.bWldDoorDescription.TabIndex = 4;
			this.bWldDoorDescription.Text = "Door Description";
			this.bWldDoorDescription.Click += new System.EventHandler(this.bWldDoorDescription_Click);
			// 
			// cbWldNowhere
			// 
			this.cbWldNowhere.Enabled = false;
			this.cbWldNowhere.Location = new System.Drawing.Point(96, 16);
			this.cbWldNowhere.Name = "cbWldNowhere";
			this.cbWldNowhere.Size = new System.Drawing.Size(80, 16);
			this.cbWldNowhere.TabIndex = 1;
			this.cbWldNowhere.Text = "Nowhere";
			this.cbWldNowhere.CheckedChanged += new System.EventHandler(this.cbWldNowhere_CheckedChanged);
			// 
			// cbWldExitExists
			// 
			this.cbWldExitExists.Location = new System.Drawing.Point(16, 16);
			this.cbWldExitExists.Name = "cbWldExitExists";
			this.cbWldExitExists.Size = new System.Drawing.Size(80, 16);
			this.cbWldExitExists.TabIndex = 0;
			this.cbWldExitExists.Text = "Exit Exists";
			this.cbWldExitExists.CheckedChanged += new System.EventHandler(this.cbWldExitExists_CheckedChanged);
			// 
			// gbWldDoorFlag
			// 
			this.gbWldDoorFlag.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.cboxWldDoorFlag});
			this.gbWldDoorFlag.Enabled = false;
			this.gbWldDoorFlag.Location = new System.Drawing.Point(8, 40);
			this.gbWldDoorFlag.Name = "gbWldDoorFlag";
			this.gbWldDoorFlag.Size = new System.Drawing.Size(168, 48);
			this.gbWldDoorFlag.TabIndex = 2;
			this.gbWldDoorFlag.TabStop = false;
			this.gbWldDoorFlag.Text = "Door Flag";
			// 
			// cboxWldDoorFlag
			// 
			this.cboxWldDoorFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxWldDoorFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxWldDoorFlag.Location = new System.Drawing.Point(8, 16);
			this.cboxWldDoorFlag.MaxDropDownItems = 16;
			this.cboxWldDoorFlag.Name = "cboxWldDoorFlag";
			this.cboxWldDoorFlag.Size = new System.Drawing.Size(152, 21);
			this.cboxWldDoorFlag.TabIndex = 0;
			this.cboxWldDoorFlag.SelectedIndexChanged += new System.EventHandler(this.cboxWldDoorFlag_SelectedIndexChanged);
			// 
			// gbWldDoorKey
			// 
			this.gbWldDoorKey.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.cboxWldAreaDoorKey,
																					   this.cbWldNoKey,
																					   this.nudWldDoorKey});
			this.gbWldDoorKey.Enabled = false;
			this.gbWldDoorKey.Location = new System.Drawing.Point(8, 88);
			this.gbWldDoorKey.Name = "gbWldDoorKey";
			this.gbWldDoorKey.Size = new System.Drawing.Size(168, 104);
			this.gbWldDoorKey.TabIndex = 3;
			this.gbWldDoorKey.TabStop = false;
			this.gbWldDoorKey.Text = "Door Key";
			// 
			// cboxWldAreaDoorKey
			// 
			this.cboxWldAreaDoorKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxWldAreaDoorKey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxWldAreaDoorKey.Location = new System.Drawing.Point(8, 48);
			this.cboxWldAreaDoorKey.MaxDropDownItems = 16;
			this.cboxWldAreaDoorKey.Name = "cboxWldAreaDoorKey";
			this.cboxWldAreaDoorKey.Size = new System.Drawing.Size(152, 21);
			this.cboxWldAreaDoorKey.TabIndex = 1;
			this.cboxWldAreaDoorKey.SelectedIndexChanged += new System.EventHandler(this.cboxWldAreaDoorKey_SelectedIndexChanged);
			// 
			// cbWldNoKey
			// 
			this.cbWldNoKey.Checked = true;
			this.cbWldNoKey.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbWldNoKey.Location = new System.Drawing.Point(8, 80);
			this.cbWldNoKey.Name = "cbWldNoKey";
			this.cbWldNoKey.Size = new System.Drawing.Size(64, 16);
			this.cbWldNoKey.TabIndex = 2;
			this.cbWldNoKey.Text = "No Key";
			this.cbWldNoKey.CheckedChanged += new System.EventHandler(this.cbWldNoKey_CheckedChanged);
			// 
			// nudWldDoorKey
			// 
			this.nudWldDoorKey.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudWldDoorKey.Enabled = false;
			this.nudWldDoorKey.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudWldDoorKey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.nudWldDoorKey.Location = new System.Drawing.Point(8, 16);
			this.nudWldDoorKey.Maximum = new System.Decimal(new int[] {
																		  999999,
																		  0,
																		  0,
																		  0});
			this.nudWldDoorKey.Minimum = new System.Decimal(new int[] {
																		  1,
																		  0,
																		  0,
																		  -2147483648});
			this.nudWldDoorKey.Name = "nudWldDoorKey";
			this.nudWldDoorKey.Size = new System.Drawing.Size(152, 22);
			this.nudWldDoorKey.TabIndex = 0;
			this.nudWldDoorKey.Value = new System.Decimal(new int[] {
																		1,
																		0,
																		0,
																		-2147483648});
			this.nudWldDoorKey.ValueChanged += new System.EventHandler(this.nudWldDoorKey_ValueChanged);
			// 
			// gbWldExits
			// 
			this.gbWldExits.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.nudWldWest,
																					 this.rbWldSouth,
																					 this.rbWldDown,
																					 this.rbWldUp,
																					 this.rbWldWest,
																					 this.rbWldEast,
																					 this.nudWldDown,
																					 this.nudWldEast,
																					 this.nudWldUp,
																					 this.nudWldSouth,
																					 this.nudWldNorth,
																					 this.rbWldNorth});
			this.gbWldExits.Location = new System.Drawing.Point(8, 16);
			this.gbWldExits.Name = "gbWldExits";
			this.gbWldExits.Size = new System.Drawing.Size(184, 168);
			this.gbWldExits.TabIndex = 0;
			this.gbWldExits.TabStop = false;
			this.gbWldExits.Text = "Exits";
			// 
			// nudWldWest
			// 
			this.nudWldWest.Enabled = false;
			this.nudWldWest.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudWldWest.Location = new System.Drawing.Point(64, 88);
			this.nudWldWest.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudWldWest.Name = "nudWldWest";
			this.nudWldWest.Size = new System.Drawing.Size(112, 22);
			this.nudWldWest.TabIndex = 7;
			this.nudWldWest.ValueChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// rbWldSouth
			// 
			this.rbWldSouth.Location = new System.Drawing.Point(8, 64);
			this.rbWldSouth.Name = "rbWldSouth";
			this.rbWldSouth.Size = new System.Drawing.Size(56, 24);
			this.rbWldSouth.TabIndex = 4;
			this.rbWldSouth.Text = "South";
			this.rbWldSouth.CheckedChanged += new System.EventHandler(this.rbWldSouth_CheckedChanged);
			// 
			// rbWldDown
			// 
			this.rbWldDown.Location = new System.Drawing.Point(8, 136);
			this.rbWldDown.Name = "rbWldDown";
			this.rbWldDown.Size = new System.Drawing.Size(56, 24);
			this.rbWldDown.TabIndex = 10;
			this.rbWldDown.Text = "Down";
			this.rbWldDown.CheckedChanged += new System.EventHandler(this.rbWldDown_CheckedChanged);
			// 
			// rbWldUp
			// 
			this.rbWldUp.Location = new System.Drawing.Point(8, 112);
			this.rbWldUp.Name = "rbWldUp";
			this.rbWldUp.Size = new System.Drawing.Size(56, 24);
			this.rbWldUp.TabIndex = 8;
			this.rbWldUp.Text = "Up";
			this.rbWldUp.CheckedChanged += new System.EventHandler(this.rbWldUp_CheckedChanged);
			// 
			// rbWldWest
			// 
			this.rbWldWest.Location = new System.Drawing.Point(8, 88);
			this.rbWldWest.Name = "rbWldWest";
			this.rbWldWest.Size = new System.Drawing.Size(56, 24);
			this.rbWldWest.TabIndex = 6;
			this.rbWldWest.Text = "West";
			this.rbWldWest.CheckedChanged += new System.EventHandler(this.rbWldWest_CheckedChanged);
			// 
			// rbWldEast
			// 
			this.rbWldEast.Location = new System.Drawing.Point(8, 40);
			this.rbWldEast.Name = "rbWldEast";
			this.rbWldEast.Size = new System.Drawing.Size(56, 24);
			this.rbWldEast.TabIndex = 2;
			this.rbWldEast.Text = "East";
			this.rbWldEast.CheckedChanged += new System.EventHandler(this.rbWldEast_CheckedChanged);
			// 
			// nudWldDown
			// 
			this.nudWldDown.Enabled = false;
			this.nudWldDown.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudWldDown.Location = new System.Drawing.Point(64, 136);
			this.nudWldDown.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudWldDown.Name = "nudWldDown";
			this.nudWldDown.Size = new System.Drawing.Size(112, 22);
			this.nudWldDown.TabIndex = 11;
			this.nudWldDown.ValueChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// nudWldEast
			// 
			this.nudWldEast.Enabled = false;
			this.nudWldEast.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudWldEast.Location = new System.Drawing.Point(64, 40);
			this.nudWldEast.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudWldEast.Name = "nudWldEast";
			this.nudWldEast.Size = new System.Drawing.Size(112, 22);
			this.nudWldEast.TabIndex = 3;
			this.nudWldEast.ValueChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// nudWldUp
			// 
			this.nudWldUp.Enabled = false;
			this.nudWldUp.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudWldUp.Location = new System.Drawing.Point(64, 112);
			this.nudWldUp.Maximum = new System.Decimal(new int[] {
																	 0,
																	 0,
																	 0,
																	 0});
			this.nudWldUp.Name = "nudWldUp";
			this.nudWldUp.Size = new System.Drawing.Size(112, 22);
			this.nudWldUp.TabIndex = 9;
			this.nudWldUp.ValueChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// nudWldSouth
			// 
			this.nudWldSouth.Enabled = false;
			this.nudWldSouth.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudWldSouth.Location = new System.Drawing.Point(64, 64);
			this.nudWldSouth.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudWldSouth.Name = "nudWldSouth";
			this.nudWldSouth.Size = new System.Drawing.Size(112, 22);
			this.nudWldSouth.TabIndex = 5;
			this.nudWldSouth.ValueChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// nudWldNorth
			// 
			this.nudWldNorth.Enabled = false;
			this.nudWldNorth.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudWldNorth.Location = new System.Drawing.Point(64, 16);
			this.nudWldNorth.Maximum = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.nudWldNorth.Name = "nudWldNorth";
			this.nudWldNorth.Size = new System.Drawing.Size(112, 22);
			this.nudWldNorth.TabIndex = 1;
			this.nudWldNorth.ValueChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// rbWldNorth
			// 
			this.rbWldNorth.Location = new System.Drawing.Point(8, 16);
			this.rbWldNorth.Name = "rbWldNorth";
			this.rbWldNorth.Size = new System.Drawing.Size(56, 24);
			this.rbWldNorth.TabIndex = 0;
			this.rbWldNorth.Text = "North";
			this.rbWldNorth.CheckedChanged += new System.EventHandler(this.rbWldNorth_CheckedChanged);
			// 
			// gbWldSectorType
			// 
			this.gbWldSectorType.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbWldSectorType.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.cboxWldSectorType});
			this.gbWldSectorType.Location = new System.Drawing.Point(528, 393);
			this.gbWldSectorType.Name = "gbWldSectorType";
			this.gbWldSectorType.Size = new System.Drawing.Size(160, 48);
			this.gbWldSectorType.TabIndex = 3;
			this.gbWldSectorType.TabStop = false;
			this.gbWldSectorType.Text = "Sector Type";
			// 
			// cboxWldSectorType
			// 
			this.cboxWldSectorType.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxWldSectorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxWldSectorType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxWldSectorType.Location = new System.Drawing.Point(8, 16);
			this.cboxWldSectorType.MaxDropDownItems = 16;
			this.cboxWldSectorType.Name = "cboxWldSectorType";
			this.cboxWldSectorType.Size = new System.Drawing.Size(144, 21);
			this.cboxWldSectorType.TabIndex = 0;
			this.cboxWldSectorType.SelectedIndexChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// gbWldRoomBitvector
			// 
			this.gbWldRoomBitvector.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbWldRoomBitvector.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.clboxWldRoomBitvector});
			this.gbWldRoomBitvector.Location = new System.Drawing.Point(360, 393);
			this.gbWldRoomBitvector.Name = "gbWldRoomBitvector";
			this.gbWldRoomBitvector.Size = new System.Drawing.Size(160, 104);
			this.gbWldRoomBitvector.TabIndex = 2;
			this.gbWldRoomBitvector.TabStop = false;
			this.gbWldRoomBitvector.Text = "Room Bitvector";
			// 
			// clboxWldRoomBitvector
			// 
			this.clboxWldRoomBitvector.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.clboxWldRoomBitvector.CheckOnClick = true;
			this.clboxWldRoomBitvector.Location = new System.Drawing.Point(8, 16);
			this.clboxWldRoomBitvector.Name = "clboxWldRoomBitvector";
			this.clboxWldRoomBitvector.Size = new System.Drawing.Size(144, 79);
			this.clboxWldRoomBitvector.TabIndex = 0;
			this.clboxWldRoomBitvector.SelectedIndexChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// gbWldQuickSelect
			// 
			this.gbWldQuickSelect.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbWldQuickSelect.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.cboxWldQuickSelect});
			this.gbWldQuickSelect.Location = new System.Drawing.Point(8, 449);
			this.gbWldQuickSelect.Name = "gbWldQuickSelect";
			this.gbWldQuickSelect.Size = new System.Drawing.Size(344, 48);
			this.gbWldQuickSelect.TabIndex = 7;
			this.gbWldQuickSelect.TabStop = false;
			this.gbWldQuickSelect.Text = "Room Quick-Select";
			// 
			// cboxWldQuickSelect
			// 
			this.cboxWldQuickSelect.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxWldQuickSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxWldQuickSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxWldQuickSelect.Location = new System.Drawing.Point(8, 16);
			this.cboxWldQuickSelect.MaxDropDownItems = 16;
			this.cboxWldQuickSelect.Name = "cboxWldQuickSelect";
			this.cboxWldQuickSelect.Size = new System.Drawing.Size(328, 21);
			this.cboxWldQuickSelect.TabIndex = 0;
			this.cboxWldQuickSelect.SelectedIndexChanged += new System.EventHandler(this.cboxWldQuickSelect_SelectedIndexChanged);
			// 
			// gbWldVNum
			// 
			this.gbWldVNum.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.gbWldVNum.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.nudWldVNum});
			this.gbWldVNum.Location = new System.Drawing.Point(8, 393);
			this.gbWldVNum.Name = "gbWldVNum";
			this.gbWldVNum.Size = new System.Drawing.Size(88, 48);
			this.gbWldVNum.TabIndex = 6;
			this.gbWldVNum.TabStop = false;
			this.gbWldVNum.Text = "VNum";
			// 
			// nudWldVNum
			// 
			this.nudWldVNum.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudWldVNum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudWldVNum.Location = new System.Drawing.Point(8, 16);
			this.nudWldVNum.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudWldVNum.Name = "nudWldVNum";
			this.nudWldVNum.Size = new System.Drawing.Size(72, 22);
			this.nudWldVNum.TabIndex = 0;
			this.nudWldVNum.ValueChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// gbWldRoomName
			// 
			this.gbWldRoomName.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbWldRoomName.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.tbWldRoomName});
			this.gbWldRoomName.Location = new System.Drawing.Point(8, 8);
			this.gbWldRoomName.Name = "gbWldRoomName";
			this.gbWldRoomName.Size = new System.Drawing.Size(664, 48);
			this.gbWldRoomName.TabIndex = 0;
			this.gbWldRoomName.TabStop = false;
			this.gbWldRoomName.Text = "Room Name";
			// 
			// tbWldRoomName
			// 
			this.tbWldRoomName.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbWldRoomName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbWldRoomName.Location = new System.Drawing.Point(8, 16);
			this.tbWldRoomName.Name = "tbWldRoomName";
			this.tbWldRoomName.Size = new System.Drawing.Size(648, 22);
			this.tbWldRoomName.TabIndex = 0;
			this.tbWldRoomName.Text = "";
			this.tbWldRoomName.TextChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// gbWldRoomDescription
			// 
			this.gbWldRoomDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbWldRoomDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.tbWldRoomDescription});
			this.gbWldRoomDescription.Location = new System.Drawing.Point(8, 56);
			this.gbWldRoomDescription.Name = "gbWldRoomDescription";
			this.gbWldRoomDescription.Size = new System.Drawing.Size(680, 337);
			this.gbWldRoomDescription.TabIndex = 1;
			this.gbWldRoomDescription.TabStop = false;
			this.gbWldRoomDescription.Text = "Room Description";
			// 
			// tbWldRoomDescription
			// 
			this.tbWldRoomDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbWldRoomDescription.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbWldRoomDescription.Location = new System.Drawing.Point(8, 16);
			this.tbWldRoomDescription.Multiline = true;
			this.tbWldRoomDescription.Name = "tbWldRoomDescription";
			this.tbWldRoomDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbWldRoomDescription.Size = new System.Drawing.Size(664, 313);
			this.tbWldRoomDescription.TabIndex = 0;
			this.tbWldRoomDescription.Text = "";
			this.tbWldRoomDescription.TextChanged += new System.EventHandler(this.roomEditorChanged);
			// 
			// tpShopEditor
			// 
			this.tpShopEditor.AutoScroll = true;
			this.tpShopEditor.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.bShpShopkeeperMessages,
																					   this.bShpDelete,
																					   this.bShpMove,
																					   this.bShpCopy,
																					   this.bShpSave,
																					   this.bShpNew,
																					   this.gbShpShopInformation,
																					   this.gbShpShopkeeper,
																					   this.gbShpShopRooms,
																					   this.gbShpShopItems,
																					   this.gbShpQuickSelect,
																					   this.gbShpWillNotSellTo,
																					   this.gbShpBuyTypes,
																					   this.gbShpVNum});
			this.tpShopEditor.Location = new System.Drawing.Point(4, 22);
			this.tpShopEditor.Name = "tpShopEditor";
			this.tpShopEditor.Size = new System.Drawing.Size(904, 503);
			this.tpShopEditor.TabIndex = 3;
			this.tpShopEditor.Text = "Shop Editor";
			// 
			// bShpShopkeeperMessages
			// 
			this.bShpShopkeeperMessages.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.bShpShopkeeperMessages.Location = new System.Drawing.Point(712, 448);
			this.bShpShopkeeperMessages.Name = "bShpShopkeeperMessages";
			this.bShpShopkeeperMessages.Size = new System.Drawing.Size(168, 23);
			this.bShpShopkeeperMessages.TabIndex = 6;
			this.bShpShopkeeperMessages.Text = "Shopkeeper Messages";
			this.bShpShopkeeperMessages.Click += new System.EventHandler(this.bShpShopkeeperMessages_Click);
			// 
			// bShpDelete
			// 
			this.bShpDelete.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bShpDelete.Location = new System.Drawing.Point(296, 409);
			this.bShpDelete.Name = "bShpDelete";
			this.bShpDelete.Size = new System.Drawing.Size(56, 23);
			this.bShpDelete.TabIndex = 13;
			this.bShpDelete.Text = "Delete";
			this.bShpDelete.Click += new System.EventHandler(this.bShpDelete_Click);
			// 
			// bShpMove
			// 
			this.bShpMove.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bShpMove.Location = new System.Drawing.Point(248, 409);
			this.bShpMove.Name = "bShpMove";
			this.bShpMove.Size = new System.Drawing.Size(40, 23);
			this.bShpMove.TabIndex = 12;
			this.bShpMove.Text = "Move";
			this.bShpMove.Click += new System.EventHandler(this.bShpMove_Click);
			// 
			// bShpCopy
			// 
			this.bShpCopy.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bShpCopy.Location = new System.Drawing.Point(200, 409);
			this.bShpCopy.Name = "bShpCopy";
			this.bShpCopy.Size = new System.Drawing.Size(40, 23);
			this.bShpCopy.TabIndex = 11;
			this.bShpCopy.Text = "Copy";
			this.bShpCopy.Click += new System.EventHandler(this.bShpCopy_Click);
			// 
			// bShpSave
			// 
			this.bShpSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bShpSave.Location = new System.Drawing.Point(152, 409);
			this.bShpSave.Name = "bShpSave";
			this.bShpSave.Size = new System.Drawing.Size(40, 23);
			this.bShpSave.TabIndex = 10;
			this.bShpSave.Text = "Save";
			this.bShpSave.Click += new System.EventHandler(this.bShpSave_Click);
			// 
			// bShpNew
			// 
			this.bShpNew.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bShpNew.Location = new System.Drawing.Point(104, 409);
			this.bShpNew.Name = "bShpNew";
			this.bShpNew.Size = new System.Drawing.Size(40, 23);
			this.bShpNew.TabIndex = 9;
			this.bShpNew.Text = "New";
			this.bShpNew.Click += new System.EventHandler(this.bShpNew_Click);
			// 
			// gbShpShopInformation
			// 
			this.gbShpShopInformation.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbShpShopInformation.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.gbShpOpenTime1,
																							   this.gbShpCloseTime1,
																							   this.gbShpOpenTime2,
																							   this.gbShpCloseTime2,
																							   this.gbShpBuyProfit,
																							   this.gbShpSellProfit,
																							   this.cbShpAlwaysOpen});
			this.gbShpShopInformation.Location = new System.Drawing.Point(696, 240);
			this.gbShpShopInformation.Name = "gbShpShopInformation";
			this.gbShpShopInformation.Size = new System.Drawing.Size(200, 200);
			this.gbShpShopInformation.TabIndex = 3;
			this.gbShpShopInformation.TabStop = false;
			this.gbShpShopInformation.Text = "Shop Information";
			// 
			// gbShpOpenTime1
			// 
			this.gbShpOpenTime1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.nudShpOpenTime1});
			this.gbShpOpenTime1.Location = new System.Drawing.Point(8, 72);
			this.gbShpOpenTime1.Name = "gbShpOpenTime1";
			this.gbShpOpenTime1.Size = new System.Drawing.Size(88, 48);
			this.gbShpOpenTime1.TabIndex = 2;
			this.gbShpOpenTime1.TabStop = false;
			this.gbShpOpenTime1.Text = "Open Time 1";
			// 
			// nudShpOpenTime1
			// 
			this.nudShpOpenTime1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpOpenTime1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpOpenTime1.Location = new System.Drawing.Point(8, 16);
			this.nudShpOpenTime1.Maximum = new System.Decimal(new int[] {
																			28,
																			0,
																			0,
																			0});
			this.nudShpOpenTime1.Name = "nudShpOpenTime1";
			this.nudShpOpenTime1.Size = new System.Drawing.Size(72, 22);
			this.nudShpOpenTime1.TabIndex = 0;
			this.nudShpOpenTime1.ValueChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// gbShpCloseTime1
			// 
			this.gbShpCloseTime1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.nudShpCloseTime1});
			this.gbShpCloseTime1.Location = new System.Drawing.Point(104, 72);
			this.gbShpCloseTime1.Name = "gbShpCloseTime1";
			this.gbShpCloseTime1.Size = new System.Drawing.Size(88, 48);
			this.gbShpCloseTime1.TabIndex = 3;
			this.gbShpCloseTime1.TabStop = false;
			this.gbShpCloseTime1.Text = "Close Time 1";
			// 
			// nudShpCloseTime1
			// 
			this.nudShpCloseTime1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpCloseTime1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpCloseTime1.Location = new System.Drawing.Point(8, 16);
			this.nudShpCloseTime1.Maximum = new System.Decimal(new int[] {
																			 28,
																			 0,
																			 0,
																			 0});
			this.nudShpCloseTime1.Name = "nudShpCloseTime1";
			this.nudShpCloseTime1.Size = new System.Drawing.Size(72, 22);
			this.nudShpCloseTime1.TabIndex = 0;
			this.nudShpCloseTime1.ValueChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// gbShpOpenTime2
			// 
			this.gbShpOpenTime2.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.nudShpOpenTime2});
			this.gbShpOpenTime2.Location = new System.Drawing.Point(8, 120);
			this.gbShpOpenTime2.Name = "gbShpOpenTime2";
			this.gbShpOpenTime2.Size = new System.Drawing.Size(88, 48);
			this.gbShpOpenTime2.TabIndex = 4;
			this.gbShpOpenTime2.TabStop = false;
			this.gbShpOpenTime2.Text = "Open Time 2";
			// 
			// nudShpOpenTime2
			// 
			this.nudShpOpenTime2.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpOpenTime2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpOpenTime2.Location = new System.Drawing.Point(8, 16);
			this.nudShpOpenTime2.Maximum = new System.Decimal(new int[] {
																			28,
																			0,
																			0,
																			0});
			this.nudShpOpenTime2.Name = "nudShpOpenTime2";
			this.nudShpOpenTime2.Size = new System.Drawing.Size(72, 22);
			this.nudShpOpenTime2.TabIndex = 0;
			this.nudShpOpenTime2.ValueChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// gbShpCloseTime2
			// 
			this.gbShpCloseTime2.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.nudShpCloseTime2});
			this.gbShpCloseTime2.Location = new System.Drawing.Point(104, 120);
			this.gbShpCloseTime2.Name = "gbShpCloseTime2";
			this.gbShpCloseTime2.Size = new System.Drawing.Size(88, 48);
			this.gbShpCloseTime2.TabIndex = 5;
			this.gbShpCloseTime2.TabStop = false;
			this.gbShpCloseTime2.Text = "Close Time 2";
			// 
			// nudShpCloseTime2
			// 
			this.nudShpCloseTime2.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpCloseTime2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpCloseTime2.Location = new System.Drawing.Point(8, 16);
			this.nudShpCloseTime2.Maximum = new System.Decimal(new int[] {
																			 28,
																			 0,
																			 0,
																			 0});
			this.nudShpCloseTime2.Name = "nudShpCloseTime2";
			this.nudShpCloseTime2.Size = new System.Drawing.Size(72, 22);
			this.nudShpCloseTime2.TabIndex = 0;
			this.nudShpCloseTime2.ValueChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// gbShpBuyProfit
			// 
			this.gbShpBuyProfit.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.nudShpBuyProfit});
			this.gbShpBuyProfit.Location = new System.Drawing.Point(8, 16);
			this.gbShpBuyProfit.Name = "gbShpBuyProfit";
			this.gbShpBuyProfit.Size = new System.Drawing.Size(88, 48);
			this.gbShpBuyProfit.TabIndex = 0;
			this.gbShpBuyProfit.TabStop = false;
			this.gbShpBuyProfit.Text = "Buy Profit";
			// 
			// nudShpBuyProfit
			// 
			this.nudShpBuyProfit.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpBuyProfit.DecimalPlaces = 2;
			this.nudShpBuyProfit.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpBuyProfit.Increment = new System.Decimal(new int[] {
																			  5,
																			  0,
																			  0,
																			  131072});
			this.nudShpBuyProfit.Location = new System.Drawing.Point(8, 16);
			this.nudShpBuyProfit.Maximum = new System.Decimal(new int[] {
																			99999,
																			0,
																			0,
																			0});
			this.nudShpBuyProfit.Name = "nudShpBuyProfit";
			this.nudShpBuyProfit.Size = new System.Drawing.Size(72, 22);
			this.nudShpBuyProfit.TabIndex = 0;
			this.nudShpBuyProfit.ValueChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// gbShpSellProfit
			// 
			this.gbShpSellProfit.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.nudShpSellProfit});
			this.gbShpSellProfit.Location = new System.Drawing.Point(104, 16);
			this.gbShpSellProfit.Name = "gbShpSellProfit";
			this.gbShpSellProfit.Size = new System.Drawing.Size(88, 48);
			this.gbShpSellProfit.TabIndex = 1;
			this.gbShpSellProfit.TabStop = false;
			this.gbShpSellProfit.Text = "Sell Profit";
			// 
			// nudShpSellProfit
			// 
			this.nudShpSellProfit.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpSellProfit.DecimalPlaces = 2;
			this.nudShpSellProfit.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpSellProfit.Increment = new System.Decimal(new int[] {
																			   5,
																			   0,
																			   0,
																			   131072});
			this.nudShpSellProfit.Location = new System.Drawing.Point(8, 16);
			this.nudShpSellProfit.Maximum = new System.Decimal(new int[] {
																			 99999,
																			 0,
																			 0,
																			 0});
			this.nudShpSellProfit.Name = "nudShpSellProfit";
			this.nudShpSellProfit.Size = new System.Drawing.Size(72, 22);
			this.nudShpSellProfit.TabIndex = 0;
			this.nudShpSellProfit.ValueChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// cbShpAlwaysOpen
			// 
			this.cbShpAlwaysOpen.Location = new System.Drawing.Point(16, 176);
			this.cbShpAlwaysOpen.Name = "cbShpAlwaysOpen";
			this.cbShpAlwaysOpen.Size = new System.Drawing.Size(96, 16);
			this.cbShpAlwaysOpen.TabIndex = 6;
			this.cbShpAlwaysOpen.Text = "Always Open";
			this.cbShpAlwaysOpen.CheckedChanged += new System.EventHandler(this.cbShpAlwaysOpen_CheckedChanged);
			// 
			// gbShpShopkeeper
			// 
			this.gbShpShopkeeper.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbShpShopkeeper.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.gbShpShopBitvector,
																						  this.gbShpShopkeeperTemper,
																						  this.gbShpAreaMobile,
																						  this.gbShpMobileVNum});
			this.gbShpShopkeeper.Location = new System.Drawing.Point(696, 8);
			this.gbShpShopkeeper.Name = "gbShpShopkeeper";
			this.gbShpShopkeeper.Size = new System.Drawing.Size(200, 232);
			this.gbShpShopkeeper.TabIndex = 2;
			this.gbShpShopkeeper.TabStop = false;
			this.gbShpShopkeeper.Text = "Shopkeeper";
			// 
			// gbShpShopBitvector
			// 
			this.gbShpShopBitvector.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbShpShopBitvector.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.clboxShpShopBitvector});
			this.gbShpShopBitvector.Location = new System.Drawing.Point(8, 112);
			this.gbShpShopBitvector.Name = "gbShpShopBitvector";
			this.gbShpShopBitvector.Size = new System.Drawing.Size(184, 64);
			this.gbShpShopBitvector.TabIndex = 2;
			this.gbShpShopBitvector.TabStop = false;
			this.gbShpShopBitvector.Text = "Shop/Shopkeeper Bitvector";
			// 
			// clboxShpShopBitvector
			// 
			this.clboxShpShopBitvector.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.clboxShpShopBitvector.CheckOnClick = true;
			this.clboxShpShopBitvector.Location = new System.Drawing.Point(8, 16);
			this.clboxShpShopBitvector.Name = "clboxShpShopBitvector";
			this.clboxShpShopBitvector.Size = new System.Drawing.Size(168, 34);
			this.clboxShpShopBitvector.TabIndex = 0;
			this.clboxShpShopBitvector.SelectedIndexChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// gbShpShopkeeperTemper
			// 
			this.gbShpShopkeeperTemper.Controls.AddRange(new System.Windows.Forms.Control[] {
																								this.cboxShpShopkeeperTemper});
			this.gbShpShopkeeperTemper.Location = new System.Drawing.Point(8, 176);
			this.gbShpShopkeeperTemper.Name = "gbShpShopkeeperTemper";
			this.gbShpShopkeeperTemper.Size = new System.Drawing.Size(184, 48);
			this.gbShpShopkeeperTemper.TabIndex = 3;
			this.gbShpShopkeeperTemper.TabStop = false;
			this.gbShpShopkeeperTemper.Text = "Shopkeeper Temper";
			// 
			// cboxShpShopkeeperTemper
			// 
			this.cboxShpShopkeeperTemper.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxShpShopkeeperTemper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxShpShopkeeperTemper.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxShpShopkeeperTemper.Location = new System.Drawing.Point(8, 16);
			this.cboxShpShopkeeperTemper.MaxDropDownItems = 16;
			this.cboxShpShopkeeperTemper.Name = "cboxShpShopkeeperTemper";
			this.cboxShpShopkeeperTemper.Size = new System.Drawing.Size(168, 21);
			this.cboxShpShopkeeperTemper.TabIndex = 0;
			this.cboxShpShopkeeperTemper.SelectedIndexChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// gbShpAreaMobile
			// 
			this.gbShpAreaMobile.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.cboxShpAreaMobile});
			this.gbShpAreaMobile.Location = new System.Drawing.Point(8, 64);
			this.gbShpAreaMobile.Name = "gbShpAreaMobile";
			this.gbShpAreaMobile.Size = new System.Drawing.Size(184, 48);
			this.gbShpAreaMobile.TabIndex = 1;
			this.gbShpAreaMobile.TabStop = false;
			this.gbShpAreaMobile.Text = "Area Mobile";
			// 
			// cboxShpAreaMobile
			// 
			this.cboxShpAreaMobile.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxShpAreaMobile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxShpAreaMobile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxShpAreaMobile.Location = new System.Drawing.Point(8, 16);
			this.cboxShpAreaMobile.MaxDropDownItems = 16;
			this.cboxShpAreaMobile.Name = "cboxShpAreaMobile";
			this.cboxShpAreaMobile.Size = new System.Drawing.Size(168, 21);
			this.cboxShpAreaMobile.TabIndex = 0;
			this.cboxShpAreaMobile.SelectedIndexChanged += new System.EventHandler(this.cboxShpAreaMobile_SelectedIndexChanged);
			// 
			// gbShpMobileVNum
			// 
			this.gbShpMobileVNum.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.nudShpMobileVNum});
			this.gbShpMobileVNum.Location = new System.Drawing.Point(8, 16);
			this.gbShpMobileVNum.Name = "gbShpMobileVNum";
			this.gbShpMobileVNum.Size = new System.Drawing.Size(184, 48);
			this.gbShpMobileVNum.TabIndex = 0;
			this.gbShpMobileVNum.TabStop = false;
			this.gbShpMobileVNum.Text = "Mobile VNum";
			// 
			// nudShpMobileVNum
			// 
			this.nudShpMobileVNum.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpMobileVNum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpMobileVNum.Location = new System.Drawing.Point(8, 16);
			this.nudShpMobileVNum.Maximum = new System.Decimal(new int[] {
																			 0,
																			 0,
																			 0,
																			 0});
			this.nudShpMobileVNum.Name = "nudShpMobileVNum";
			this.nudShpMobileVNum.Size = new System.Drawing.Size(168, 22);
			this.nudShpMobileVNum.TabIndex = 0;
			this.nudShpMobileVNum.ValueChanged += new System.EventHandler(this.nudShpMobileVNum_ValueChanged);
			// 
			// gbShpShopRooms
			// 
			this.gbShpShopRooms.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbShpShopRooms.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.bShpRemoveRoom,
																						 this.bShpAddRoom,
																						 this.gbShpAreaRoom,
																						 this.gbShpRoomVNum,
																						 this.lboxShpShopRooms});
			this.gbShpShopRooms.Location = new System.Drawing.Point(8, 241);
			this.gbShpShopRooms.Name = "gbShpShopRooms";
			this.gbShpShopRooms.Size = new System.Drawing.Size(680, 152);
			this.gbShpShopRooms.TabIndex = 1;
			this.gbShpShopRooms.TabStop = false;
			this.gbShpShopRooms.Text = "Shop Rooms";
			// 
			// bShpRemoveRoom
			// 
			this.bShpRemoveRoom.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.bShpRemoveRoom.Enabled = false;
			this.bShpRemoveRoom.Location = new System.Drawing.Point(584, 112);
			this.bShpRemoveRoom.Name = "bShpRemoveRoom";
			this.bShpRemoveRoom.Size = new System.Drawing.Size(88, 23);
			this.bShpRemoveRoom.TabIndex = 4;
			this.bShpRemoveRoom.Text = "Remove Room";
			this.bShpRemoveRoom.Click += new System.EventHandler(this.bShpRemoveRoom_Click);
			// 
			// bShpAddRoom
			// 
			this.bShpAddRoom.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.bShpAddRoom.Enabled = false;
			this.bShpAddRoom.Location = new System.Drawing.Point(488, 112);
			this.bShpAddRoom.Name = "bShpAddRoom";
			this.bShpAddRoom.Size = new System.Drawing.Size(88, 23);
			this.bShpAddRoom.TabIndex = 3;
			this.bShpAddRoom.Text = "Add Room";
			this.bShpAddRoom.Click += new System.EventHandler(this.bShpAddRoom_Click);
			// 
			// gbShpAreaRoom
			// 
			this.gbShpAreaRoom.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbShpAreaRoom.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.cboxShpAreaRoom});
			this.gbShpAreaRoom.Location = new System.Drawing.Point(104, 96);
			this.gbShpAreaRoom.Name = "gbShpAreaRoom";
			this.gbShpAreaRoom.Size = new System.Drawing.Size(376, 48);
			this.gbShpAreaRoom.TabIndex = 2;
			this.gbShpAreaRoom.TabStop = false;
			this.gbShpAreaRoom.Text = "Area Room";
			// 
			// cboxShpAreaRoom
			// 
			this.cboxShpAreaRoom.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxShpAreaRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxShpAreaRoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxShpAreaRoom.Location = new System.Drawing.Point(8, 16);
			this.cboxShpAreaRoom.MaxDropDownItems = 16;
			this.cboxShpAreaRoom.Name = "cboxShpAreaRoom";
			this.cboxShpAreaRoom.Size = new System.Drawing.Size(360, 21);
			this.cboxShpAreaRoom.TabIndex = 0;
			this.cboxShpAreaRoom.SelectedIndexChanged += new System.EventHandler(this.cboxShpAreaRoom_SelectedIndexChanged);
			// 
			// gbShpRoomVNum
			// 
			this.gbShpRoomVNum.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.gbShpRoomVNum.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.nudShpRoomVNum});
			this.gbShpRoomVNum.Location = new System.Drawing.Point(8, 96);
			this.gbShpRoomVNum.Name = "gbShpRoomVNum";
			this.gbShpRoomVNum.Size = new System.Drawing.Size(88, 48);
			this.gbShpRoomVNum.TabIndex = 1;
			this.gbShpRoomVNum.TabStop = false;
			this.gbShpRoomVNum.Text = "Room VNum";
			// 
			// nudShpRoomVNum
			// 
			this.nudShpRoomVNum.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpRoomVNum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpRoomVNum.Location = new System.Drawing.Point(8, 16);
			this.nudShpRoomVNum.Maximum = new System.Decimal(new int[] {
																		   999999,
																		   0,
																		   0,
																		   0});
			this.nudShpRoomVNum.Name = "nudShpRoomVNum";
			this.nudShpRoomVNum.Size = new System.Drawing.Size(72, 22);
			this.nudShpRoomVNum.TabIndex = 0;
			this.nudShpRoomVNum.ValueChanged += new System.EventHandler(this.nudShpRoomVNum_ValueChanged);
			// 
			// lboxShpShopRooms
			// 
			this.lboxShpShopRooms.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.lboxShpShopRooms.Location = new System.Drawing.Point(8, 16);
			this.lboxShpShopRooms.Name = "lboxShpShopRooms";
			this.lboxShpShopRooms.Size = new System.Drawing.Size(664, 69);
			this.lboxShpShopRooms.TabIndex = 0;
			this.lboxShpShopRooms.SelectedIndexChanged += new System.EventHandler(this.lboxShpShopRooms_SelectedIndexChanged);
			// 
			// gbShpShopItems
			// 
			this.gbShpShopItems.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbShpShopItems.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.bShpRemoveItem,
																						 this.bShpAddItem,
																						 this.gbShpAreaItem,
																						 this.gbShpItemVNum,
																						 this.lboxShpShopItems});
			this.gbShpShopItems.Location = new System.Drawing.Point(8, 8);
			this.gbShpShopItems.Name = "gbShpShopItems";
			this.gbShpShopItems.Size = new System.Drawing.Size(680, 233);
			this.gbShpShopItems.TabIndex = 0;
			this.gbShpShopItems.TabStop = false;
			this.gbShpShopItems.Text = "Shop Items";
			// 
			// bShpRemoveItem
			// 
			this.bShpRemoveItem.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.bShpRemoveItem.Enabled = false;
			this.bShpRemoveItem.Location = new System.Drawing.Point(584, 193);
			this.bShpRemoveItem.Name = "bShpRemoveItem";
			this.bShpRemoveItem.Size = new System.Drawing.Size(88, 23);
			this.bShpRemoveItem.TabIndex = 4;
			this.bShpRemoveItem.Text = "Remove Item";
			this.bShpRemoveItem.Click += new System.EventHandler(this.bShpRemoveItem_Click);
			// 
			// bShpAddItem
			// 
			this.bShpAddItem.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.bShpAddItem.Enabled = false;
			this.bShpAddItem.Location = new System.Drawing.Point(488, 192);
			this.bShpAddItem.Name = "bShpAddItem";
			this.bShpAddItem.Size = new System.Drawing.Size(88, 23);
			this.bShpAddItem.TabIndex = 3;
			this.bShpAddItem.Text = "Add Item";
			this.bShpAddItem.Click += new System.EventHandler(this.bShpAddItem_Click);
			// 
			// gbShpAreaItem
			// 
			this.gbShpAreaItem.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbShpAreaItem.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.cboxShpAreaItem});
			this.gbShpAreaItem.Location = new System.Drawing.Point(104, 176);
			this.gbShpAreaItem.Name = "gbShpAreaItem";
			this.gbShpAreaItem.Size = new System.Drawing.Size(376, 48);
			this.gbShpAreaItem.TabIndex = 2;
			this.gbShpAreaItem.TabStop = false;
			this.gbShpAreaItem.Text = "Area Item";
			// 
			// cboxShpAreaItem
			// 
			this.cboxShpAreaItem.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxShpAreaItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxShpAreaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboxShpAreaItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxShpAreaItem.Location = new System.Drawing.Point(8, 16);
			this.cboxShpAreaItem.MaxDropDownItems = 16;
			this.cboxShpAreaItem.Name = "cboxShpAreaItem";
			this.cboxShpAreaItem.Size = new System.Drawing.Size(360, 21);
			this.cboxShpAreaItem.TabIndex = 0;
			this.cboxShpAreaItem.SelectedIndexChanged += new System.EventHandler(this.cboxShpAreaItem_SelectedIndexChanged);
			// 
			// gbShpItemVNum
			// 
			this.gbShpItemVNum.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.gbShpItemVNum.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.nudShpItemVNum});
			this.gbShpItemVNum.Location = new System.Drawing.Point(8, 177);
			this.gbShpItemVNum.Name = "gbShpItemVNum";
			this.gbShpItemVNum.Size = new System.Drawing.Size(88, 48);
			this.gbShpItemVNum.TabIndex = 1;
			this.gbShpItemVNum.TabStop = false;
			this.gbShpItemVNum.Text = "Item VNum";
			// 
			// nudShpItemVNum
			// 
			this.nudShpItemVNum.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpItemVNum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpItemVNum.Location = new System.Drawing.Point(8, 16);
			this.nudShpItemVNum.Maximum = new System.Decimal(new int[] {
																		   999999,
																		   0,
																		   0,
																		   0});
			this.nudShpItemVNum.Name = "nudShpItemVNum";
			this.nudShpItemVNum.Size = new System.Drawing.Size(72, 22);
			this.nudShpItemVNum.TabIndex = 0;
			this.nudShpItemVNum.ValueChanged += new System.EventHandler(this.nudShpItemVNum_ValueChanged);
			// 
			// lboxShpShopItems
			// 
			this.lboxShpShopItems.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.lboxShpShopItems.Location = new System.Drawing.Point(8, 16);
			this.lboxShpShopItems.Name = "lboxShpShopItems";
			this.lboxShpShopItems.Size = new System.Drawing.Size(664, 147);
			this.lboxShpShopItems.TabIndex = 0;
			this.lboxShpShopItems.SelectedIndexChanged += new System.EventHandler(this.lboxShpShopItems_SelectedIndexChanged);
			// 
			// gbShpQuickSelect
			// 
			this.gbShpQuickSelect.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbShpQuickSelect.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.cboxShpQuickSelect});
			this.gbShpQuickSelect.Location = new System.Drawing.Point(8, 449);
			this.gbShpQuickSelect.Name = "gbShpQuickSelect";
			this.gbShpQuickSelect.Size = new System.Drawing.Size(344, 48);
			this.gbShpQuickSelect.TabIndex = 8;
			this.gbShpQuickSelect.TabStop = false;
			this.gbShpQuickSelect.Text = "Shop Quick-Select";
			// 
			// cboxShpQuickSelect
			// 
			this.cboxShpQuickSelect.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxShpQuickSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxShpQuickSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxShpQuickSelect.Location = new System.Drawing.Point(8, 16);
			this.cboxShpQuickSelect.MaxDropDownItems = 16;
			this.cboxShpQuickSelect.Name = "cboxShpQuickSelect";
			this.cboxShpQuickSelect.Size = new System.Drawing.Size(328, 21);
			this.cboxShpQuickSelect.TabIndex = 0;
			this.cboxShpQuickSelect.SelectedIndexChanged += new System.EventHandler(this.cboxShpQuickSelect_SelectedIndexChanged);
			// 
			// gbShpWillNotSellTo
			// 
			this.gbShpWillNotSellTo.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbShpWillNotSellTo.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.clboxShpWillNotSellTo});
			this.gbShpWillNotSellTo.Location = new System.Drawing.Point(528, 393);
			this.gbShpWillNotSellTo.Name = "gbShpWillNotSellTo";
			this.gbShpWillNotSellTo.Size = new System.Drawing.Size(160, 104);
			this.gbShpWillNotSellTo.TabIndex = 5;
			this.gbShpWillNotSellTo.TabStop = false;
			this.gbShpWillNotSellTo.Text = "Will Not Trade With";
			// 
			// clboxShpWillNotSellTo
			// 
			this.clboxShpWillNotSellTo.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.clboxShpWillNotSellTo.CheckOnClick = true;
			this.clboxShpWillNotSellTo.Location = new System.Drawing.Point(8, 16);
			this.clboxShpWillNotSellTo.Name = "clboxShpWillNotSellTo";
			this.clboxShpWillNotSellTo.Size = new System.Drawing.Size(144, 79);
			this.clboxShpWillNotSellTo.TabIndex = 0;
			this.clboxShpWillNotSellTo.SelectedIndexChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// gbShpBuyTypes
			// 
			this.gbShpBuyTypes.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbShpBuyTypes.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.clboxShpBuyTypes});
			this.gbShpBuyTypes.Location = new System.Drawing.Point(360, 393);
			this.gbShpBuyTypes.Name = "gbShpBuyTypes";
			this.gbShpBuyTypes.Size = new System.Drawing.Size(160, 104);
			this.gbShpBuyTypes.TabIndex = 4;
			this.gbShpBuyTypes.TabStop = false;
			this.gbShpBuyTypes.Text = "Buy Types";
			// 
			// clboxShpBuyTypes
			// 
			this.clboxShpBuyTypes.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.clboxShpBuyTypes.CheckOnClick = true;
			this.clboxShpBuyTypes.Location = new System.Drawing.Point(8, 16);
			this.clboxShpBuyTypes.Name = "clboxShpBuyTypes";
			this.clboxShpBuyTypes.Size = new System.Drawing.Size(144, 79);
			this.clboxShpBuyTypes.TabIndex = 0;
			this.clboxShpBuyTypes.SelectedIndexChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// gbShpVNum
			// 
			this.gbShpVNum.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.gbShpVNum.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.nudShpVNum});
			this.gbShpVNum.Location = new System.Drawing.Point(8, 393);
			this.gbShpVNum.Name = "gbShpVNum";
			this.gbShpVNum.Size = new System.Drawing.Size(88, 48);
			this.gbShpVNum.TabIndex = 7;
			this.gbShpVNum.TabStop = false;
			this.gbShpVNum.Text = "VNum";
			// 
			// nudShpVNum
			// 
			this.nudShpVNum.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudShpVNum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudShpVNum.Location = new System.Drawing.Point(8, 16);
			this.nudShpVNum.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudShpVNum.Name = "nudShpVNum";
			this.nudShpVNum.Size = new System.Drawing.Size(72, 22);
			this.nudShpVNum.TabIndex = 0;
			this.nudShpVNum.ValueChanged += new System.EventHandler(this.shopEditorChanged);
			// 
			// tpZoneEditor
			// 
			this.tpZoneEditor.AutoScroll = true;
			this.tpZoneEditor.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.gbZonZoneInformation,
																					   this.gbZonZoneCommand,
																					   this.gbZonZoneCommands});
			this.tpZoneEditor.Location = new System.Drawing.Point(4, 22);
			this.tpZoneEditor.Name = "tpZoneEditor";
			this.tpZoneEditor.Size = new System.Drawing.Size(904, 503);
			this.tpZoneEditor.TabIndex = 4;
			this.tpZoneEditor.Text = "Zone Editor";
			// 
			// gbZonZoneInformation
			// 
			this.gbZonZoneInformation.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbZonZoneInformation.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.gbZonBottomRoom,
																							   this.gbZonZoneName,
																							   this.gbZonResetMode,
																							   this.gbZonLifespan,
																							   this.gbZonTopRoom,
																							   this.gbZonNumber});
			this.gbZonZoneInformation.Location = new System.Drawing.Point(8, 425);
			this.gbZonZoneInformation.Name = "gbZonZoneInformation";
			this.gbZonZoneInformation.Size = new System.Drawing.Size(888, 72);
			this.gbZonZoneInformation.TabIndex = 2;
			this.gbZonZoneInformation.TabStop = false;
			this.gbZonZoneInformation.Text = "Zone Information";
			// 
			// gbZonBottomRoom
			// 
			this.gbZonBottomRoom.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbZonBottomRoom.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.nudZonBottomRoom});
			this.gbZonBottomRoom.Location = new System.Drawing.Point(440, 16);
			this.gbZonBottomRoom.Name = "gbZonBottomRoom";
			this.gbZonBottomRoom.Size = new System.Drawing.Size(104, 48);
			this.gbZonBottomRoom.TabIndex = 2;
			this.gbZonBottomRoom.TabStop = false;
			this.gbZonBottomRoom.Text = "Bottom Room";
			// 
			// nudZonBottomRoom
			// 
			this.nudZonBottomRoom.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudZonBottomRoom.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudZonBottomRoom.Location = new System.Drawing.Point(8, 16);
			this.nudZonBottomRoom.Maximum = new System.Decimal(new int[] {
																			 999999,
																			 0,
																			 0,
																			 0});
			this.nudZonBottomRoom.Name = "nudZonBottomRoom";
			this.nudZonBottomRoom.Size = new System.Drawing.Size(88, 22);
			this.nudZonBottomRoom.TabIndex = 0;
			this.nudZonBottomRoom.ValueChanged += new System.EventHandler(this.zoneEditorChanged);
			// 
			// gbZonZoneName
			// 
			this.gbZonZoneName.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbZonZoneName.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.tbZonZoneName});
			this.gbZonZoneName.Location = new System.Drawing.Point(104, 16);
			this.gbZonZoneName.Name = "gbZonZoneName";
			this.gbZonZoneName.Size = new System.Drawing.Size(328, 48);
			this.gbZonZoneName.TabIndex = 1;
			this.gbZonZoneName.TabStop = false;
			this.gbZonZoneName.Text = "Zone Name";
			// 
			// tbZonZoneName
			// 
			this.tbZonZoneName.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbZonZoneName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbZonZoneName.Location = new System.Drawing.Point(8, 16);
			this.tbZonZoneName.Name = "tbZonZoneName";
			this.tbZonZoneName.Size = new System.Drawing.Size(312, 20);
			this.tbZonZoneName.TabIndex = 0;
			this.tbZonZoneName.Text = "";
			this.tbZonZoneName.TextChanged += new System.EventHandler(this.zoneEditorChanged);
			// 
			// gbZonResetMode
			// 
			this.gbZonResetMode.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbZonResetMode.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.cboxZonResetMode});
			this.gbZonResetMode.Location = new System.Drawing.Point(768, 16);
			this.gbZonResetMode.Name = "gbZonResetMode";
			this.gbZonResetMode.Size = new System.Drawing.Size(112, 48);
			this.gbZonResetMode.TabIndex = 5;
			this.gbZonResetMode.TabStop = false;
			this.gbZonResetMode.Text = "Reset Mode";
			// 
			// cboxZonResetMode
			// 
			this.cboxZonResetMode.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxZonResetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxZonResetMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxZonResetMode.Location = new System.Drawing.Point(8, 16);
			this.cboxZonResetMode.MaxDropDownItems = 16;
			this.cboxZonResetMode.Name = "cboxZonResetMode";
			this.cboxZonResetMode.Size = new System.Drawing.Size(96, 21);
			this.cboxZonResetMode.TabIndex = 0;
			this.cboxZonResetMode.SelectedIndexChanged += new System.EventHandler(this.zoneEditorChanged);
			// 
			// gbZonLifespan
			// 
			this.gbZonLifespan.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbZonLifespan.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.nudZonLifespan});
			this.gbZonLifespan.Location = new System.Drawing.Point(664, 16);
			this.gbZonLifespan.Name = "gbZonLifespan";
			this.gbZonLifespan.Size = new System.Drawing.Size(96, 48);
			this.gbZonLifespan.TabIndex = 4;
			this.gbZonLifespan.TabStop = false;
			this.gbZonLifespan.Text = "Lifespan";
			// 
			// nudZonLifespan
			// 
			this.nudZonLifespan.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudZonLifespan.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudZonLifespan.Location = new System.Drawing.Point(8, 16);
			this.nudZonLifespan.Maximum = new System.Decimal(new int[] {
																		   99999,
																		   0,
																		   0,
																		   0});
			this.nudZonLifespan.Name = "nudZonLifespan";
			this.nudZonLifespan.Size = new System.Drawing.Size(80, 22);
			this.nudZonLifespan.TabIndex = 0;
			this.nudZonLifespan.ValueChanged += new System.EventHandler(this.zoneEditorChanged);
			// 
			// gbZonTopRoom
			// 
			this.gbZonTopRoom.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbZonTopRoom.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.nudZonTopRoom});
			this.gbZonTopRoom.Location = new System.Drawing.Point(552, 16);
			this.gbZonTopRoom.Name = "gbZonTopRoom";
			this.gbZonTopRoom.Size = new System.Drawing.Size(104, 48);
			this.gbZonTopRoom.TabIndex = 3;
			this.gbZonTopRoom.TabStop = false;
			this.gbZonTopRoom.Text = "Top Room";
			// 
			// nudZonTopRoom
			// 
			this.nudZonTopRoom.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudZonTopRoom.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudZonTopRoom.Location = new System.Drawing.Point(8, 16);
			this.nudZonTopRoom.Maximum = new System.Decimal(new int[] {
																		  999999,
																		  0,
																		  0,
																		  0});
			this.nudZonTopRoom.Name = "nudZonTopRoom";
			this.nudZonTopRoom.Size = new System.Drawing.Size(88, 22);
			this.nudZonTopRoom.TabIndex = 0;
			this.nudZonTopRoom.ValueChanged += new System.EventHandler(this.zoneEditorChanged);
			// 
			// gbZonNumber
			// 
			this.gbZonNumber.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.nudZonNumber});
			this.gbZonNumber.Location = new System.Drawing.Point(8, 16);
			this.gbZonNumber.Name = "gbZonNumber";
			this.gbZonNumber.Size = new System.Drawing.Size(88, 48);
			this.gbZonNumber.TabIndex = 0;
			this.gbZonNumber.TabStop = false;
			this.gbZonNumber.Text = "Number";
			// 
			// nudZonNumber
			// 
			this.nudZonNumber.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudZonNumber.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudZonNumber.Location = new System.Drawing.Point(8, 16);
			this.nudZonNumber.Maximum = new System.Decimal(new int[] {
																		 0,
																		 0,
																		 0,
																		 0});
			this.nudZonNumber.Name = "nudZonNumber";
			this.nudZonNumber.Size = new System.Drawing.Size(72, 22);
			this.nudZonNumber.TabIndex = 0;
			this.nudZonNumber.ValueChanged += new System.EventHandler(this.zoneEditorChanged);
			// 
			// gbZonZoneCommand
			// 
			this.gbZonZoneCommand.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbZonZoneCommand.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.bZonInsert,
																						   this.bZonAdd,
																						   this.gbZonComment,
																						   this.cbZonIfFlag,
																						   this.gbZonArg2,
																						   this.gbZonArg1,
																						   this.gbZonArg0,
																						   this.gbZonCommandType});
			this.gbZonZoneCommand.Location = new System.Drawing.Point(8, 273);
			this.gbZonZoneCommand.Name = "gbZonZoneCommand";
			this.gbZonZoneCommand.Size = new System.Drawing.Size(888, 152);
			this.gbZonZoneCommand.TabIndex = 1;
			this.gbZonZoneCommand.TabStop = false;
			this.gbZonZoneCommand.Text = "Zone Command";
			// 
			// bZonInsert
			// 
			this.bZonInsert.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.bZonInsert.Enabled = false;
			this.bZonInsert.Location = new System.Drawing.Point(776, 112);
			this.bZonInsert.Name = "bZonInsert";
			this.bZonInsert.Size = new System.Drawing.Size(72, 24);
			this.bZonInsert.TabIndex = 7;
			this.bZonInsert.Text = "Insert";
			this.bZonInsert.Click += new System.EventHandler(this.bZonInsert_Click);
			// 
			// bZonAdd
			// 
			this.bZonAdd.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.bZonAdd.Location = new System.Drawing.Point(696, 112);
			this.bZonAdd.Name = "bZonAdd";
			this.bZonAdd.Size = new System.Drawing.Size(72, 24);
			this.bZonAdd.TabIndex = 6;
			this.bZonAdd.Text = "Add";
			this.bZonAdd.Click += new System.EventHandler(this.bZonAdd_Click);
			// 
			// gbZonComment
			// 
			this.gbZonComment.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbZonComment.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.tbZonComment});
			this.gbZonComment.Location = new System.Drawing.Point(8, 96);
			this.gbZonComment.Name = "gbZonComment";
			this.gbZonComment.Size = new System.Drawing.Size(648, 48);
			this.gbZonComment.TabIndex = 5;
			this.gbZonComment.TabStop = false;
			this.gbZonComment.Text = "Comment";
			// 
			// tbZonComment
			// 
			this.tbZonComment.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbZonComment.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbZonComment.Location = new System.Drawing.Point(8, 16);
			this.tbZonComment.Name = "tbZonComment";
			this.tbZonComment.Size = new System.Drawing.Size(632, 22);
			this.tbZonComment.TabIndex = 0;
			this.tbZonComment.Text = "";
			// 
			// cbZonIfFlag
			// 
			this.cbZonIfFlag.Location = new System.Drawing.Point(16, 64);
			this.cbZonIfFlag.Name = "cbZonIfFlag";
			this.cbZonIfFlag.Size = new System.Drawing.Size(192, 24);
			this.cbZonIfFlag.TabIndex = 1;
			this.cbZonIfFlag.Text = "Depends on Previous Command";
			// 
			// gbZonArg2
			// 
			this.gbZonArg2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbZonArg2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.cboxZonAreaArg2,
																					this.nudZonArg2});
			this.gbZonArg2.Location = new System.Drawing.Point(664, 16);
			this.gbZonArg2.Name = "gbZonArg2";
			this.gbZonArg2.Size = new System.Drawing.Size(216, 80);
			this.gbZonArg2.TabIndex = 4;
			this.gbZonArg2.TabStop = false;
			this.gbZonArg2.Text = "Argument 2";
			// 
			// cboxZonAreaArg2
			// 
			this.cboxZonAreaArg2.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxZonAreaArg2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxZonAreaArg2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxZonAreaArg2.Location = new System.Drawing.Point(8, 48);
			this.cboxZonAreaArg2.MaxDropDownItems = 16;
			this.cboxZonAreaArg2.Name = "cboxZonAreaArg2";
			this.cboxZonAreaArg2.Size = new System.Drawing.Size(200, 21);
			this.cboxZonAreaArg2.TabIndex = 1;
			this.cboxZonAreaArg2.SelectedIndexChanged += new System.EventHandler(this.cboxZonAreaArg2_SelectedIndexChanged);
			// 
			// nudZonArg2
			// 
			this.nudZonArg2.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudZonArg2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudZonArg2.Location = new System.Drawing.Point(8, 16);
			this.nudZonArg2.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudZonArg2.Name = "nudZonArg2";
			this.nudZonArg2.Size = new System.Drawing.Size(200, 22);
			this.nudZonArg2.TabIndex = 0;
			this.nudZonArg2.ValueChanged += new System.EventHandler(this.nudZonArg2_ValueChanged);
			// 
			// gbZonArg1
			// 
			this.gbZonArg1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbZonArg1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.cboxZonAreaArg1,
																					this.nudZonArg1});
			this.gbZonArg1.Location = new System.Drawing.Point(440, 16);
			this.gbZonArg1.Name = "gbZonArg1";
			this.gbZonArg1.Size = new System.Drawing.Size(216, 80);
			this.gbZonArg1.TabIndex = 3;
			this.gbZonArg1.TabStop = false;
			this.gbZonArg1.Text = "Argument 1";
			// 
			// cboxZonAreaArg1
			// 
			this.cboxZonAreaArg1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxZonAreaArg1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxZonAreaArg1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxZonAreaArg1.Location = new System.Drawing.Point(8, 48);
			this.cboxZonAreaArg1.MaxDropDownItems = 16;
			this.cboxZonAreaArg1.Name = "cboxZonAreaArg1";
			this.cboxZonAreaArg1.Size = new System.Drawing.Size(200, 21);
			this.cboxZonAreaArg1.TabIndex = 1;
			this.cboxZonAreaArg1.SelectedIndexChanged += new System.EventHandler(this.cboxZonAreaArg1_SelectedIndexChanged);
			// 
			// nudZonArg1
			// 
			this.nudZonArg1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudZonArg1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudZonArg1.Location = new System.Drawing.Point(8, 16);
			this.nudZonArg1.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudZonArg1.Name = "nudZonArg1";
			this.nudZonArg1.Size = new System.Drawing.Size(200, 22);
			this.nudZonArg1.TabIndex = 0;
			this.nudZonArg1.ValueChanged += new System.EventHandler(this.nudZonArg1_ValueChanged);
			// 
			// gbZonArg0
			// 
			this.gbZonArg0.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gbZonArg0.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.cboxZonAreaArg0,
																					this.nudZonArg0});
			this.gbZonArg0.Location = new System.Drawing.Point(216, 16);
			this.gbZonArg0.Name = "gbZonArg0";
			this.gbZonArg0.Size = new System.Drawing.Size(216, 80);
			this.gbZonArg0.TabIndex = 2;
			this.gbZonArg0.TabStop = false;
			this.gbZonArg0.Text = "Argument 0";
			// 
			// cboxZonAreaArg0
			// 
			this.cboxZonAreaArg0.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxZonAreaArg0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxZonAreaArg0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxZonAreaArg0.Location = new System.Drawing.Point(8, 48);
			this.cboxZonAreaArg0.MaxDropDownItems = 16;
			this.cboxZonAreaArg0.Name = "cboxZonAreaArg0";
			this.cboxZonAreaArg0.Size = new System.Drawing.Size(200, 21);
			this.cboxZonAreaArg0.TabIndex = 1;
			this.cboxZonAreaArg0.SelectedIndexChanged += new System.EventHandler(this.cboxZonAreaArg0_SelectedIndexChanged);
			// 
			// nudZonArg0
			// 
			this.nudZonArg0.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudZonArg0.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudZonArg0.Location = new System.Drawing.Point(8, 16);
			this.nudZonArg0.Maximum = new System.Decimal(new int[] {
																	   0,
																	   0,
																	   0,
																	   0});
			this.nudZonArg0.Name = "nudZonArg0";
			this.nudZonArg0.Size = new System.Drawing.Size(200, 22);
			this.nudZonArg0.TabIndex = 0;
			this.nudZonArg0.ValueChanged += new System.EventHandler(this.nudZonArg0_ValueChanged);
			// 
			// gbZonCommandType
			// 
			this.gbZonCommandType.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbZonCommandType.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.cboxZonCommandType});
			this.gbZonCommandType.Location = new System.Drawing.Point(8, 16);
			this.gbZonCommandType.Name = "gbZonCommandType";
			this.gbZonCommandType.Size = new System.Drawing.Size(200, 48);
			this.gbZonCommandType.TabIndex = 0;
			this.gbZonCommandType.TabStop = false;
			this.gbZonCommandType.Text = "Command Type";
			// 
			// cboxZonCommandType
			// 
			this.cboxZonCommandType.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxZonCommandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxZonCommandType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxZonCommandType.Location = new System.Drawing.Point(8, 16);
			this.cboxZonCommandType.MaxDropDownItems = 16;
			this.cboxZonCommandType.Name = "cboxZonCommandType";
			this.cboxZonCommandType.Size = new System.Drawing.Size(184, 21);
			this.cboxZonCommandType.TabIndex = 0;
			this.cboxZonCommandType.SelectedIndexChanged += new System.EventHandler(this.cboxZonCommandType_SelectedIndexChanged);
			// 
			// gbZonZoneCommands
			// 
			this.gbZonZoneCommands.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbZonZoneCommands.Controls.AddRange(new System.Windows.Forms.Control[] {
																							this.bZonCommandUp,
																							this.bZonCommandDown,
																							this.bZonRemove,
																							this.lboxZonZoneCommands});
			this.gbZonZoneCommands.Location = new System.Drawing.Point(8, 8);
			this.gbZonZoneCommands.Name = "gbZonZoneCommands";
			this.gbZonZoneCommands.Size = new System.Drawing.Size(888, 264);
			this.gbZonZoneCommands.TabIndex = 0;
			this.gbZonZoneCommands.TabStop = false;
			this.gbZonZoneCommands.Text = "Zone Commands (Double-Click Entry to Edit)";
			// 
			// bZonCommandUp
			// 
			this.bZonCommandUp.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bZonCommandUp.Location = new System.Drawing.Point(8, 231);
			this.bZonCommandUp.Name = "bZonCommandUp";
			this.bZonCommandUp.Size = new System.Drawing.Size(56, 24);
			this.bZonCommandUp.TabIndex = 1;
			this.bZonCommandUp.Text = "Up";
			this.bZonCommandUp.Click += new System.EventHandler(this.bZonCommandUp_Click);
			// 
			// bZonCommandDown
			// 
			this.bZonCommandDown.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bZonCommandDown.Location = new System.Drawing.Point(72, 231);
			this.bZonCommandDown.Name = "bZonCommandDown";
			this.bZonCommandDown.Size = new System.Drawing.Size(56, 24);
			this.bZonCommandDown.TabIndex = 2;
			this.bZonCommandDown.Text = "Down";
			this.bZonCommandDown.Click += new System.EventHandler(this.bZonCommandDown_Click);
			// 
			// bZonRemove
			// 
			this.bZonRemove.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bZonRemove.Enabled = false;
			this.bZonRemove.Location = new System.Drawing.Point(136, 231);
			this.bZonRemove.Name = "bZonRemove";
			this.bZonRemove.Size = new System.Drawing.Size(72, 24);
			this.bZonRemove.TabIndex = 3;
			this.bZonRemove.Text = "Remove";
			this.bZonRemove.Click += new System.EventHandler(this.bZonRemove_Click);
			// 
			// lboxZonZoneCommands
			// 
			this.lboxZonZoneCommands.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.lboxZonZoneCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lboxZonZoneCommands.Location = new System.Drawing.Point(8, 16);
			this.lboxZonZoneCommands.Name = "lboxZonZoneCommands";
			this.lboxZonZoneCommands.Size = new System.Drawing.Size(872, 212);
			this.lboxZonZoneCommands.TabIndex = 0;
			this.lboxZonZoneCommands.DoubleClick += new System.EventHandler(this.lboxZonZoneCommands_DoubleClick);
			this.lboxZonZoneCommands.SelectedIndexChanged += new System.EventHandler(this.lboxZonZoneCommands_SelectedIndexChanged);
			// 
			// fMain
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(912, 553);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tcEditors,
																		  this.sbMain});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mmMain;
			this.Name = "fMain";
			this.Text = "Circle World Creator";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.fMain_Closing);
			this.Load += new System.EventHandler(this.fMain_Load);
			this.tcEditors.ResumeLayout(false);
			this.tpMobileEditor.ResumeLayout(false);
			this.gbMobQuickSelect.ResumeLayout(false);
			this.gbMobGender.ResumeLayout(false);
			this.gbMobDefaultPosition.ResumeLayout(false);
			this.gbMobLoadPosition.ResumeLayout(false);
			this.gbMobExperience.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobExperience)).EndInit();
			this.gbMobArmorClass.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobArmorClass)).EndInit();
			this.gbMobAffectionBitvector.ResumeLayout(false);
			this.gbMobActionBitvector.ResumeLayout(false);
			this.gbMobVNum.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobVNum)).EndInit();
			this.gbMobShortDescription.ResumeLayout(false);
			this.gbMobLongDescription.ResumeLayout(false);
			this.gbMobAliasList.ResumeLayout(false);
			this.gbMobDetailedDescription.ResumeLayout(false);
			this.gbMobAlignment.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobAlignment)).EndInit();
			this.gbMobLevel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobLevel)).EndInit();
			this.gbMobHP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobHPAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMobHPDie)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMobHPNum)).EndInit();
			this.gbMobGold.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobGold)).EndInit();
			this.gbMobBH.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobBHAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMobBHDie)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMobBHNum)).EndInit();
			this.gbMobThaco.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobThaco)).EndInit();
			this.tpObjectEditor.ResumeLayout(false);
			this.gbObjValues.ResumeLayout(false);
			this.gbObjValue3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudObjValue3)).EndInit();
			this.gbObjValue2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudObjValue2)).EndInit();
			this.gbObjValue1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudObjValue1)).EndInit();
			this.gbObjValue0.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudObjValue0)).EndInit();
			this.gbObjCost.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudObjCost)).EndInit();
			this.gbObjRentPerDay.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudObjRentPerDay)).EndInit();
			this.gbObjWearBitvector.ResumeLayout(false);
			this.gbObjEffectsBitvector.ResumeLayout(false);
			this.gbObjTypeFlag.ResumeLayout(false);
			this.gbObjQuickSelect.ResumeLayout(false);
			this.gbObjVNum.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudObjVNum)).EndInit();
			this.gbObjShortDescription.ResumeLayout(false);
			this.gbObjLongDescription.ResumeLayout(false);
			this.gbObjAliasList.ResumeLayout(false);
			this.gbObjActionDescription.ResumeLayout(false);
			this.gbObjWeight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudObjWeight)).EndInit();
			this.tpRoomEditor.ResumeLayout(false);
			this.gbWldDirections.ResumeLayout(false);
			this.gbWldCurrentExit.ResumeLayout(false);
			this.gbWldDoorFlag.ResumeLayout(false);
			this.gbWldDoorKey.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudWldDoorKey)).EndInit();
			this.gbWldExits.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudWldWest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldEast)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldSouth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWldNorth)).EndInit();
			this.gbWldSectorType.ResumeLayout(false);
			this.gbWldRoomBitvector.ResumeLayout(false);
			this.gbWldQuickSelect.ResumeLayout(false);
			this.gbWldVNum.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudWldVNum)).EndInit();
			this.gbWldRoomName.ResumeLayout(false);
			this.gbWldRoomDescription.ResumeLayout(false);
			this.tpShopEditor.ResumeLayout(false);
			this.gbShpShopInformation.ResumeLayout(false);
			this.gbShpOpenTime1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpOpenTime1)).EndInit();
			this.gbShpCloseTime1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpCloseTime1)).EndInit();
			this.gbShpOpenTime2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpOpenTime2)).EndInit();
			this.gbShpCloseTime2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpCloseTime2)).EndInit();
			this.gbShpBuyProfit.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpBuyProfit)).EndInit();
			this.gbShpSellProfit.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpSellProfit)).EndInit();
			this.gbShpShopkeeper.ResumeLayout(false);
			this.gbShpShopBitvector.ResumeLayout(false);
			this.gbShpShopkeeperTemper.ResumeLayout(false);
			this.gbShpAreaMobile.ResumeLayout(false);
			this.gbShpMobileVNum.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpMobileVNum)).EndInit();
			this.gbShpShopRooms.ResumeLayout(false);
			this.gbShpAreaRoom.ResumeLayout(false);
			this.gbShpRoomVNum.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpRoomVNum)).EndInit();
			this.gbShpShopItems.ResumeLayout(false);
			this.gbShpAreaItem.ResumeLayout(false);
			this.gbShpItemVNum.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpItemVNum)).EndInit();
			this.gbShpQuickSelect.ResumeLayout(false);
			this.gbShpWillNotSellTo.ResumeLayout(false);
			this.gbShpBuyTypes.ResumeLayout(false);
			this.gbShpVNum.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudShpVNum)).EndInit();
			this.tpZoneEditor.ResumeLayout(false);
			this.gbZonZoneInformation.ResumeLayout(false);
			this.gbZonBottomRoom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudZonBottomRoom)).EndInit();
			this.gbZonZoneName.ResumeLayout(false);
			this.gbZonResetMode.ResumeLayout(false);
			this.gbZonLifespan.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudZonLifespan)).EndInit();
			this.gbZonTopRoom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudZonTopRoom)).EndInit();
			this.gbZonNumber.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudZonNumber)).EndInit();
			this.gbZonZoneCommand.ResumeLayout(false);
			this.gbZonComment.ResumeLayout(false);
			this.gbZonArg2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudZonArg2)).EndInit();
			this.gbZonArg1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudZonArg1)).EndInit();
			this.gbZonArg0.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudZonArg0)).EndInit();
			this.gbZonCommandType.ResumeLayout(false);
			this.gbZonZoneCommands.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new fMain());
		}

		/// <summary>
		/// Function to load a configuration file from the passed-in stream.
		/// </summary>
		/// <param name="myStream"></param>
		/// <returns>True if successfull, False if not successfull.</returns>
		private bool loadConfig(Stream myStream)
		{
			StreamReader myStreamReader = new StreamReader(myStream);
			string temp;
			string[] split;

			NumericUpDown[] myDirNUD = new NumericUpDown[6];
			myDirNUD[0] = nudWldNorth;
			myDirNUD[1] = nudWldEast;
			myDirNUD[2] = nudWldSouth;
			myDirNUD[3] = nudWldWest;
			myDirNUD[4] = nudWldUp;
			myDirNUD[5] = nudWldDown;

			mobActions = new StringCollection();
			mobAffections = new StringCollection();
			mobPositions = new StringCollection();
			mobGenders = new StringCollection();
			mobAttackTypes = new StringCollection();
			mobESpecTypes = new StringCollection();
			objTypeFlags = new StringCollection();
			objEffects = new StringCollection();
			objWear = new StringCollection();
			objAffects = new StringCollection();
			objSpells = new StringCollection();
			objLiquids = new StringCollection();
			objWeaponTypes = new StringCollection();
			objExtraDescriptions = new StringCollection();
			wldBitvectors = new StringCollection();
			wldSectorTypes = new StringCollection();
			wldDoorFlags = new StringCollection();
			shpBuyTypes = new StringCollection();
			shpTempers = new StringCollection();
			shpBitvectors = new StringCollection();
			shpWillNotSellTo = new StringCollection();
			zonResetModes = new StringCollection();
			zonCommandTypes = new StringCollection();

			theMobiles = new SortedList();
			theESpecs = new SortedList();
			theObjects = new SortedList();
			theValues = new SortedList();
			theRooms = new SortedList();
			theShops = new SortedList();
			theCommands = new SortedList();

			try
			{
				split = myStreamReader.ReadLine().Split('=');				// Read MudConfig and Split it.
				sbMain.Text = "Loaded Configuration File For: " + split[1];	// Display configuration info in sbMain

				myStreamReader.ReadLine();									// Consume <mobiles>

				split = myStreamReader.ReadLine().Split('=');				// Read VNumMin and Split it.
				nudMobVNum.Minimum = int.Parse(split[1]);					// Set nudMobVNum.Minimum to VNumMin
				split = myStreamReader.ReadLine().Split('=');				// Read VNumMax and Split it.
				nudMobVNum.Maximum = int.Parse(split[1]);					// Set nudMobVNum.Maximum to VNumMax
				defaultMobile.VNumMin = decimal.ToInt64(nudMobVNum.Minimum);
				defaultMobile.VNumMax = decimal.ToInt64(nudMobVNum.Maximum);

				split = myStreamReader.ReadLine().Split('=');				// Read AliasMax and Split it.
				tbMobAliasList.MaxLength = int.Parse(split[1]);				// Set tbMobAliasList.MaxLength to AliasMax
				split = myStreamReader.ReadLine().Split('=');				// Read SDescMax and Split it.
				tbMobShortDescription.MaxLength = int.Parse(split[1]);		// Set tbMobShortDescription.MaxLength to SDescMax
				split = myStreamReader.ReadLine().Split('=');				// Read LDescMax and Split it.
				tbMobLongDescription.MaxLength = int.Parse(split[1]);		// Set tbMobLongDescription.MaxLength to LDescMax
				split = myStreamReader.ReadLine().Split('=');				// Read AliasMax and Split it.
				tbMobDetailedDescription.MaxLength = int.Parse(split[1]);	// Set tbMobDetailedDescription.MaxLength to DDescMax

				myStreamReader.ReadLine();									// Consume <actions>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				clboxMobActionBitvector.Items.Clear();						// Clear clboxMobActionBitvector.Items
				while(temp.CompareTo("</actions>") != 0)					// Read until </actions> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					clboxMobActionBitvector.Items.Add(split[1]);			// Add action to clboxMobActionBitvector.Items
					if(temp.EndsWith("*") == true)
					{
						clboxMobActionBitvector.SetItemChecked((clboxMobActionBitvector.Items.Count - 1), true);	// Set any default Action Bitvectors.
					}
					mobActions.Add(split[0]);
					mobActions.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				defaultMobile.ActionBitvector = new int[clboxMobActionBitvector.CheckedIndices.Count];
				clboxMobActionBitvector.CheckedIndices.CopyTo(defaultMobile.ActionBitvector, 0);

				myStreamReader.ReadLine();									// Consume <affections>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				clboxMobAffectionBitvector.Items.Clear();					// Clear clboxMobAffectionBitvector.Items
				while(temp.CompareTo("</affections>") != 0)					// Read until </affections> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					clboxMobAffectionBitvector.Items.Add(split[1]);			// Add affection to clboxMobAffectionBitvector.Items
					if(temp.EndsWith("*") == true)
					{
						clboxMobAffectionBitvector.SetItemChecked((clboxMobAffectionBitvector.Items.Count - 1), true);	// Set any default Affection Bitvectors.
					}
					mobAffections.Add(split[0]);
					mobAffections.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				defaultMobile.AffectionBitvector = new int[clboxMobAffectionBitvector.CheckedIndices.Count];
				clboxMobAffectionBitvector.CheckedIndices.CopyTo(defaultMobile.AffectionBitvector, 0);

				split = myStreamReader.ReadLine().Split('=');				// Read AlignMin and Split it.
				nudMobAlignment.Minimum = int.Parse(split[1]);				// Set nudMobAlignment.Minimum to AlignMin
				split = myStreamReader.ReadLine().Split('=');				// Read AlignMax and Split it.
				nudMobAlignment.Maximum = int.Parse(split[1]);				// Set nudMobAlignment.Maximum to AlignMax

				split = myStreamReader.ReadLine().Split('=');				// Read LevelMin and Split it.
				nudMobLevel.Minimum = int.Parse(split[1]);					// Set nudMobLevel.Minimum to LevelMin
				split = myStreamReader.ReadLine().Split('=');				// Read LevelMax and Split it.
				nudMobLevel.Maximum = int.Parse(split[1]);					// Set nudMobLevel.Maximum to LevelMax

				split = myStreamReader.ReadLine().Split('=');				// Read ThacoMin and Split it.
				nudMobThaco.Minimum = int.Parse(split[1]);					// Set nudMobThaco.Minimum to ThacoMin
				split = myStreamReader.ReadLine().Split('=');				// Read ThacoMax and Split it.
				nudMobThaco.Maximum = int.Parse(split[1]);					// Set nudMobThaco.Maximum to ThacoMax

				split = myStreamReader.ReadLine().Split('=');				// Read ArmorMin and Split it.
				nudMobArmorClass.Minimum = int.Parse(split[1]);				// Set nudMobArmorClass.Minimum to ArmorMin
				split = myStreamReader.ReadLine().Split('=');				// Read ArmorMax and Split it.
				nudMobArmorClass.Maximum = int.Parse(split[1]);				// Set nudMobArmorClass.Maximum to ArmorMax

				split = myStreamReader.ReadLine().Split('=');				// Read HPMinNum and Split it.
				nudMobHPNum.Minimum = int.Parse(split[1]);					// Set nudMobHPNum.Minimum to HPMinNum
				split = myStreamReader.ReadLine().Split('=');				// Read HPMaxNum and Split it.
				nudMobHPNum.Maximum = int.Parse(split[1]);					// Set nudMobHPNum.Maximum to HPMaxNum
				split = myStreamReader.ReadLine().Split('=');				// Read HPMinDie and Split it.
				nudMobHPDie.Minimum = int.Parse(split[1]);					// Set nudMobHPDie.Minimum to HPMinDie
				split = myStreamReader.ReadLine().Split('=');				// Read HPMaxDie and Split it.
				nudMobHPDie.Maximum = int.Parse(split[1]);					// Set nudMobHPDie.Maximum to HPMaxDie
				split = myStreamReader.ReadLine().Split('=');				// Read HPMinAdd and Split it.
				nudMobHPAdd.Minimum = int.Parse(split[1]);					// Set nudMobHPAdd.Minimum to HPMinAdd
				split = myStreamReader.ReadLine().Split('=');				// Read HPMaxAdd and Split it.
				nudMobHPAdd.Maximum = int.Parse(split[1]);					// Set nudMobHPAdd.Maximum to HPMaxAdd

				split = myStreamReader.ReadLine().Split('=');				// Read BHMinNum and Split it.
				nudMobBHNum.Minimum = int.Parse(split[1]);					// Set nudMobBHNum.Minimum to BHMinNum
				split = myStreamReader.ReadLine().Split('=');				// Read BHMaxNum and Split it.
				nudMobBHNum.Maximum = int.Parse(split[1]);					// Set nudMobBHNum.Maximum to BHMaxNum
				split = myStreamReader.ReadLine().Split('=');				// Read BHMinDie and Split it.
				nudMobBHDie.Minimum = int.Parse(split[1]);					// Set nudMobBHDie.Minimum to BHMinDie
				split = myStreamReader.ReadLine().Split('=');				// Read BHMaxDie and Split it.
				nudMobBHDie.Maximum = int.Parse(split[1]);					// Set nudMobBHDie.Maximum to BHMaxDie
				split = myStreamReader.ReadLine().Split('=');				// Read BHMinAdd and Split it.
				nudMobBHAdd.Minimum = int.Parse(split[1]);					// Set nudMobBHAdd.Minimum to BHMinAdd
				split = myStreamReader.ReadLine().Split('=');				// Read BHMaxAdd and Split it.
				nudMobBHAdd.Maximum = int.Parse(split[1]);					// Set nudMobBHAdd.Maximum to BHMaxAdd

				split = myStreamReader.ReadLine().Split('=');				// Read GPMin and Split it.
				nudMobGold.Minimum = int.Parse(split[1]);					// Set nudMobGold.Minimum to GPMin
				split = myStreamReader.ReadLine().Split('=');				// Read GPMax and Split it.
				nudMobGold.Maximum = int.Parse(split[1]);					// Set nudMobGold.Maximum to GPMax

				split = myStreamReader.ReadLine().Split('=');				// Read XPMin and Split it.
				nudMobExperience.Minimum = int.Parse(split[1]);				// Set nudMobExperience.Minimum to XPMin
				split = myStreamReader.ReadLine().Split('=');				// Read XPMax and Split it.
				nudMobExperience.Maximum = int.Parse(split[1]);				// Set nudMobExperience.Maximum to XPMax

				myStreamReader.ReadLine();									// Consume <positions>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				cboxMobLoadPosition.Items.Clear();							// Clear cboxMobLoadPosition.Items
				cboxMobDefaultPosition.Items.Clear();						// Clear cboxMobDefaultPosition.Items
				while(temp.CompareTo("</positions>") != 0)					// Read until </positions> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					cboxMobLoadPosition.Items.Add(split[1]);				// Add position to cboxMobLoadPosition.Items
					cboxMobDefaultPosition.Items.Add(split[1]);				// Add position to cboxMobDefaultPosition.Items
					if(temp.EndsWith("*"))
					{
						cboxMobLoadPosition.SelectedIndex = (cboxMobLoadPosition.Items.Count - 1);		// Set default Load Position.
						cboxMobDefaultPosition.SelectedIndex = (cboxMobLoadPosition.Items.Count - 1);	// Set default Default Position.
					}
					mobPositions.Add(split[0]);
					mobPositions.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				if(cboxMobLoadPosition.SelectedIndex != -1)
				{
					defaultMobile.LoadPosition = cboxMobLoadPosition.SelectedIndex;
					defaultMobile.DefaultPosition = cboxMobDefaultPosition.SelectedIndex;
				}
				else
				{
					cboxMobLoadPosition.SelectedIndex = 0;
					cboxMobDefaultPosition.SelectedIndex = 0;
				}

				myStreamReader.ReadLine();									// Consume <genders>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				cboxMobGender.Items.Clear();								// Clear cboxMobGender.Items
				while(temp.CompareTo("</genders>") != 0)					// Read until </genders> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					cboxMobGender.Items.Add(split[1]);						// Add gender to cboxMobGender.Items
					if(temp.EndsWith("*"))
					{
						cboxMobGender.SelectedIndex = (cboxMobGender.Items.Count - 1);	// Set default Gender.
					}
					mobGenders.Add(split[0]);
					mobGenders.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				if(cboxMobGender.SelectedIndex != -1)
				{
					defaultMobile.Sex = cboxMobGender.SelectedIndex;
				}
				else
				{
					cboxMobGender.SelectedIndex = 0;
				}

				myStreamReader.ReadLine();									// Consume <attack_types>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				while(temp.CompareTo("</attack_types>") != 0)				// Read until </attack_types> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					if(temp.EndsWith("*") == true)
					{
						defaultMobile.AttackType = int.Parse(split[0]);
					}
					mobAttackTypes.Add(split[0]);
					mobAttackTypes.Add(split[1]);

					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				objWeaponTypes = mobAttackTypes;

				myStreamReader.ReadLine();									// Consume <e-specs>
				temp = myStreamReader.ReadLine().Trim();
				while(temp.CompareTo("</e-specs>") != 0)
				{
					ESpecData theSpec = new ESpecData();

					split = myStreamReader.ReadLine().Trim().Split('=');
					theSpec.SpecTxt = split[1];
					mobESpecTypes.Add(split[1]);
					split = myStreamReader.ReadLine().Trim().Split('=');
					theSpec.SpecMin = long.Parse(split[1]);
					split = myStreamReader.ReadLine().Trim().Split('=');
					theSpec.SpecMax = long.Parse(split[1]);

					myStreamReader.ReadLine();							// Consume <range>
					temp = myStreamReader.ReadLine().Trim();			// Read next line and trim whitespace.
					if(temp.CompareTo("unused") != 0)					// Range is used, read it in.
					{
						if(temp.CompareTo("attack_types") == 0)
						{
							theSpec.Range = mobAttackTypes;
							myStreamReader.ReadLine();					// Consume </range>
						}
						else
						{
							while(temp.CompareTo("</range>") != 0)			// Read until </range> is found.
							{
								split = temp.Split(new Char[] {'=','*'});	// Split temp.
								if(temp.EndsWith("*") == true)
								{
									defaultMobile.ESpec = split[0];
								}
								theSpec.Range.Add(split[0]);
								theSpec.Range.Add(split[1]);

								temp = myStreamReader.ReadLine().Trim();	// Read next line and trim whitespace.
							}
						}
					}
					else
					{
						myStreamReader.ReadLine();						// Consume </range>
					}

					myStreamReader.ReadLine();								// Consume </(specX)>
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.

					theESpecs.Add(theSpec.SpecTxt, theSpec);
				}

				myStreamReader.ReadLine();									// Consume </mobiles>
				myStreamReader.ReadLine();									// Consume <objects>

				split = myStreamReader.ReadLine().Split('=');				// Read VNumMin and Split it.
				nudObjVNum.Minimum = int.Parse(split[1]);					// Set nudObjVNum.Minimum to VNumMin
				split = myStreamReader.ReadLine().Split('=');				// Read VNumMax and Split it.
				nudObjVNum.Maximum = int.Parse(split[1]);					// Set nudObjVNum.Maximum to VNumMax
				defaultObject.VNumMin = decimal.ToInt64(nudObjVNum.Minimum);
				defaultObject.VNumMax = decimal.ToInt64(nudObjVNum.Maximum);

				split = myStreamReader.ReadLine().Split('=');				// Read AliasMax and Split it.
				tbObjAliasList.MaxLength = int.Parse(split[1]);				// Set tbObjAliasList.MaxLength to AliasMax
				split = myStreamReader.ReadLine().Split('=');				// Read SDescMax and Split it.
				tbObjShortDescription.MaxLength = int.Parse(split[1]);		// Set tbObjShortDescription.MaxLength to SDescMax
				split = myStreamReader.ReadLine().Split('=');				// Read LDescMax and Split it.
				tbObjLongDescription.MaxLength = int.Parse(split[1]);		// Set tbObjLongDescription.MaxLength to LDescMax
				split = myStreamReader.ReadLine().Split('=');				// Read ADescMax and Split it.
				tbObjActionDescription.MaxLength = int.Parse(split[1]);		// Set tbObjActionDescription.MaxLength to ADescMax

				myStreamReader.ReadLine();									// Consume <types>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				cboxObjTypeFlag.Items.Clear();								// Clear clboxObjTypeFlag.Items
				while(temp.CompareTo("</types>") != 0)						// Read until </types> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					cboxObjTypeFlag.Items.Add(split[1]);					// Add type to cboxObjTypeFlag.Items
					if(temp.EndsWith("*") == true)
					{
						cboxObjTypeFlag.SelectedIndex = (cboxObjTypeFlag.Items.Count - 1);	// Set default Type.
					}
					objTypeFlags.Add(split[0]);
					objTypeFlags.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				if(cboxObjTypeFlag.SelectedIndex != -1)
				{
					defaultObject.TypeFlag = cboxObjTypeFlag.SelectedIndex;
				}
				else
				{
					defaultObject.TypeFlag = 0;
				}
					
				myStreamReader.ReadLine();									// Consume <effects>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				clboxObjEffectsBitvector.Items.Clear();						// Clear clboxObjEffectsBitvector.Items
				while(temp.CompareTo("</effects>") != 0)					// Read until </effects> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					clboxObjEffectsBitvector.Items.Add(split[1]);			// Add effect to clboxObjEffectsBitvector.Items
					if(temp.EndsWith("*") == true)
					{
						clboxObjEffectsBitvector.SetItemChecked((clboxObjEffectsBitvector.Items.Count - 1), true);	// Set any default Effects Bitvectors.
					}
					objEffects.Add(split[0]);
					objEffects.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				defaultObject.EffectsBitvector = new int[clboxObjEffectsBitvector.CheckedIndices.Count];
				clboxObjEffectsBitvector.CheckedIndices.CopyTo(defaultObject.EffectsBitvector, 0);

				myStreamReader.ReadLine();									// Consume <wear>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				clboxObjWearBitvector.Items.Clear();						// Clear clboxObjWearBitvector.Items
				while(temp.CompareTo("</wear>") != 0)						// Read until </wear> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					clboxObjWearBitvector.Items.Add(split[1]);				// Add wear to cboxObjWearBitvector.Items
					if(temp.EndsWith("*") == true)
					{
						clboxObjWearBitvector.SetItemChecked((clboxObjWearBitvector.Items.Count - 1), true);	// Set any default Wear Bitvectors.
					}
					objWear.Add(split[0]);
					objWear.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				defaultObject.WearBitvector = new int[clboxObjWearBitvector.CheckedIndices.Count];
				clboxObjWearBitvector.CheckedIndices.CopyTo(defaultObject.WearBitvector, 0);

				split = myStreamReader.ReadLine().Split('=');				// Read WeightMin and Split it.
				nudObjWeight.Minimum = int.Parse(split[1]);					// Set nudObjWeight.Minimum to WeightMin
				split = myStreamReader.ReadLine().Split('=');				// Read WeightMax and Split it.
				nudObjWeight.Maximum = int.Parse(split[1]);					// Set nudObjWeight.Maximum to WeightMax

				split = myStreamReader.ReadLine().Split('=');				// Read CostMin and Split it.
				nudObjCost.Minimum = int.Parse(split[1]);					// Set nudObjCost.Minimum to CostMin
				split = myStreamReader.ReadLine().Split('=');				// Read CostMax and Split it.
				nudObjCost.Maximum = int.Parse(split[1]);					// Set nudObjCost.Maximum to CostMax

				split = myStreamReader.ReadLine().Split('=');				// Read RentMin and Split it.
				nudObjRentPerDay.Minimum = int.Parse(split[1]);				// Set nudObjRentPerDay.Minimum to RentMin
				split = myStreamReader.ReadLine().Split('=');				// Read RentMax and Split it.
				nudObjRentPerDay.Maximum = int.Parse(split[1]);				// Set nudObjRentPerDay.Maximum to RentMax

				split = myStreamReader.ReadLine().Split('=');				// Read EKeyWMax and Split it.
				objExtraDescKeywordMax = int.Parse(split[1]);
				split = myStreamReader.ReadLine().Split('=');				// Read EDescMax and Split it.
				objExtraDescDescriptionMax = int.Parse(split[1]);

				split = myStreamReader.ReadLine().Split('=');				// Read AffectsMax and Split it.
				objAffectsMax = int.Parse(split[1]);
				myStreamReader.ReadLine();									// Consume <affects>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				while(temp.CompareTo("</affects>") != 0)					// Read until </affects> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					if(temp.EndsWith("*") == true)
					{
						defaultObject.Affect = split[1];
					}
					objAffects.Add(split[0]);
					objAffects.Add(split[1]);

					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}

				myStreamReader.ReadLine();									// Consume <values>
				for(int i = 0; i < (objTypeFlags.Count / 2); i++)
				{
					ValueData theValue = new ValueData();

					myStreamReader.ReadLine();								// Consume <(type)>
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
					if(temp.CompareTo("unused") != 0)						// Object Type has values, read them in.
					{
						for(int j = 0; j < 4; j++)
						{
							temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
							Value myValue = new Value();
							if(temp.CompareTo("unused") != 0)						// Value is used, read it in.
							{
								split = temp.Split('=');
								myValue.ValueTxt = split[1];
								split = myStreamReader.ReadLine().Trim().Split('=');
								myValue.ValueMin = long.Parse(split[1]);
								split = myStreamReader.ReadLine().Trim().Split('=');
								myValue.ValueMax = long.Parse(split[1]);

								myStreamReader.ReadLine();							// Consume <range>
								temp = myStreamReader.ReadLine().Trim();			// Read next line and trim whitespace.
								if(temp.CompareTo("unused") != 0)					// Range is used, read it in.
								{
									if(temp.CompareTo("mobiles") == 0)
									{
										myValue.Range.Add("<MOBILES>");
										myStreamReader.ReadLine();					// Consume </range>
									}
									else if(temp.CompareTo("objects") == 0)
									{
										myValue.Range.Add("<OBJECTS>");
										myStreamReader.ReadLine();					// Consume </range>
									}
									else if(temp.CompareTo("rooms") == 0)
									{
										myValue.Range.Add("<ROOMS>");
										myStreamReader.ReadLine();					// Consume </range>
									}
									else if(temp.CompareTo("shops") == 0)
									{
										myValue.Range.Add("<SHOPS>");
										myStreamReader.ReadLine();					// Consume </range>
									}
									else if(temp.CompareTo("spells") == 0)
									{
										myValue.Range = objSpells;
										myStreamReader.ReadLine();					// Consume </range>
									}
									else if(temp.CompareTo("liquids") == 0)
									{
										myValue.Range = objLiquids;
										myStreamReader.ReadLine();					// Consume </range>
									}
									else if (temp.CompareTo("weapon_types") == 0)
									{
										myValue.Range = objWeaponTypes;
										myStreamReader.ReadLine();					// Consume </range>
									}
									else
									{
										while(temp.CompareTo("</range>") != 0)			// Read until </range> is found.
										{
											split = temp.Split(new char[] {'=','*'});	// Split temp.

											myValue.Range.Add(split[0]);
											myValue.Range.Add(split[1]);

											temp = myStreamReader.ReadLine().Trim();	// Read next line and trim whitespace.
										}
									}
								}
								else
								{
									myStreamReader.ReadLine();						// Consume </range>
								}
							}
							else
							{
								myValue.ValueTxt = "unused";
							}

							theValue.Value.Add(j, myValue);

							myStreamReader.ReadLine();								// Consume </(valueX)>
							myStreamReader.ReadLine();								// Consume next line.
						}
					}
					else
					{
						for(int j = 0; j < 4; j++)
						{
							Value tmpValue = new Value();
							tmpValue.ValueTxt = "unused";
							theValue.Value.Add(j, tmpValue);
						}
						myStreamReader.ReadLine();								// Consume </(type)>
					}

					theValues.Add(int.Parse(objTypeFlags[i*2]), theValue);
				}
				myStreamReader.ReadLine();									// Consume </values>

				myStreamReader.ReadLine();									// Consume <spells>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				while(temp.CompareTo("</spells>") != 0)						// Read until </spells> is found.
				{
					split = temp.Split(new Char[] {'=','*'});				// Split temp.
					if(temp.EndsWith("*") == true)
					{
						defaultObject.Spell= int.Parse(split[0]);
					}
					objSpells.Add(split[0]);
					objSpells.Add(split[1]);

					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}

				myStreamReader.ReadLine();									// Consume <liquids>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				while(temp.CompareTo("</liquids>") != 0)					// Read until </liquids> is found.
				{
					split = temp.Split(new Char[] {'=','*'});				// Split temp.
					if(temp.EndsWith("*") == true)
					{
						defaultObject.Liquid= int.Parse(split[0]);
					}
					objLiquids.Add(split[0]);
					objLiquids.Add(split[1]);

					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}

				myStreamReader.ReadLine();									// Consume </objects>
				myStreamReader.ReadLine();									// Consume <rooms>

				split = myStreamReader.ReadLine().Split('=');				// Read VNumMin and Split it.
				nudWldVNum.Minimum = int.Parse(split[1]);					// Set nudWldVNum.Minimum to VNumMin
				split = myStreamReader.ReadLine().Split('=');				// Read VNumMax and Split it.
				nudWldVNum.Maximum = int.Parse(split[1]);					// Set nudWldVNum.Maximum to VNumMax
				defaultRoom.VNumMin = decimal.ToInt64(nudWldVNum.Minimum);
				defaultRoom.VNumMax = decimal.ToInt64(nudWldVNum.Maximum);

				for(int i = 0; i < 6; i++)
				{
					myDirNUD[i].Minimum = -1;
					myDirNUD[i].Maximum = nudWldVNum.Maximum;
				}

				split = myStreamReader.ReadLine().Split('=');				// Read RNameMax and Split it.
				tbWldRoomName.MaxLength = int.Parse(split[1]);				// Set tbWldRoomName.MaxLength to RNameMax
				split = myStreamReader.ReadLine().Split('=');				// Read RDescMax and Split it.
				tbWldRoomDescription.MaxLength = int.Parse(split[1]);		// Set tbWldRoomDescription.MaxLength to RDescMax

				myStreamReader.ReadLine();									// Consume <bitvectors>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				clboxWldRoomBitvector.Items.Clear();						// Clear clboxWldRoomBitvector.Items
				while(temp.CompareTo("</bitvectors>") != 0)					// Read until </bitvectors> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					clboxWldRoomBitvector.Items.Add(split[1]);				// Add bitvector to clboxWldRoomBitvector.Items
					if(temp.EndsWith("*") == true)
					{
						clboxWldRoomBitvector.SetItemChecked((clboxWldRoomBitvector.Items.Count - 1), true);	// Set any default Room Bitvectors.
					}
					wldBitvectors.Add(split[0]);
					wldBitvectors.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				defaultRoom.RoomBitvector = new int[clboxWldRoomBitvector.CheckedIndices.Count];
				clboxWldRoomBitvector.CheckedIndices.CopyTo(defaultRoom.RoomBitvector, 0);

				myStreamReader.ReadLine();									// Consume <sectors>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				cboxWldSectorType.Items.Clear();							// Clear cboxWldSectorType.Items
				while(temp.CompareTo("</sectors>") != 0)					// Read until </sectors> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					cboxWldSectorType.Items.Add(split[1]);					// Add sector type to cboxWldSectorType.Items
					if(temp.EndsWith("*") == true)
					{
						cboxWldSectorType.SelectedIndex = (cboxWldSectorType.Items.Count - 1);	// Set default Sector Type.
					}
					wldSectorTypes.Add(split[0]);
					wldSectorTypes.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				if(cboxWldSectorType.SelectedIndex != -1)
				{
					defaultRoom.SectorType = cboxWldSectorType.SelectedIndex;
				}
				else
				{
					defaultRoom.SectorType = 0;
				}

				myStreamReader.ReadLine();									// Consume <doors>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				cboxWldDoorFlag.Items.Clear();								// Clear cboxWldDoorFlag.Items
				while(temp.CompareTo("</doors>") != 0)						// Read until </doors> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					cboxWldDoorFlag.Items.Add(split[1]);					// Add door type to cboxWldDoorType.Items
					if(temp.EndsWith("*") == true)
					{
						cboxWldDoorFlag.SelectedIndex = (cboxWldDoorFlag.Items.Count - 1);	// Set default Door Flag.
					}
					wldDoorFlags.Add(split[0]);
					wldDoorFlags.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				if(cboxWldDoorFlag.SelectedIndex != -1)
				{
					defaultRoom.DoorFlag = cboxWldDoorFlag.SelectedIndex;
				}
				else
				{
					defaultRoom.DoorFlag = 0;
				}

				split = myStreamReader.ReadLine().Split('=');				// Read DKeyWMax and Split it.
				wldDoorDescKeywordMax = int.Parse(split[1]);				// Set wldDoorDescKeywordMax
				split = myStreamReader.ReadLine().Split('=');				// Read DDescMax and Split it.
				wldDoorDescDescriptionMax = int.Parse(split[1]);			// Set wldDoorDescDescriptionMax
				split = myStreamReader.ReadLine().Split('=');				// Read EKeyWMax and Split it.
				wldExtraDescKeywordMax = int.Parse(split[1]);				// Set wldExtraDescKeywordMax
				split = myStreamReader.ReadLine().Split('=');				// Read EDescMax and Split it.
				wldExtraDescDescriptionMax = int.Parse(split[1]);			// Set wldExtraDescDescriptionMax

				myStreamReader.ReadLine();									// Consume </rooms>
				myStreamReader.ReadLine();									// Consume <shops>
			
				split = myStreamReader.ReadLine().Split('=');				// Read VNumMin and Split it.
				nudShpVNum.Minimum = int.Parse(split[1]);					// Set nudShpVNum.Minimum to VNumMin
				split = myStreamReader.ReadLine().Split('=');				// Read VNumMax and Split it.
				nudShpVNum.Maximum = int.Parse(split[1]);					// Set nudShpVNum.Maximum to VNumMax
				defaultShop.VNumMin = decimal.ToInt64(nudShpVNum.Minimum);
				defaultShop.VNumMax = decimal.ToInt64(nudShpVNum.Maximum);

				split = myStreamReader.ReadLine().Split('=');				// Read BMulMin and Split it.
				nudShpBuyProfit.Minimum = int.Parse(split[1]);				// Set nudShpBuyProfit.Minimum to BMulMin
				split = myStreamReader.ReadLine().Split('=');				// Read BMulMax and Split it.
				nudShpBuyProfit.Maximum = int.Parse(split[1]);				// Set nudShpBuyProfit.Maximum to BMulMax
				split = myStreamReader.ReadLine().Split('=');				// Read SMulMin and Split it.
				nudShpSellProfit.Minimum = int.Parse(split[1]);				// Set nudShpSellProfit.Minimum to SMulMin
				split = myStreamReader.ReadLine().Split('=');				// Read SMulMax and Split it.
				nudShpSellProfit.Maximum = int.Parse(split[1]);				// Set nudShpSellProfit.Maximum to SMulMin
				split = myStreamReader.ReadLine().Split('=');				// Read ObjVNumMin and Split it.
				nudShpItemVNum.Minimum = int.Parse(split[1]);				// Set nudShpItemVNum.Minimum to ObjVNumMin
				split = myStreamReader.ReadLine().Split('=');				// Read ObjVNumMax and Split it.
				nudShpItemVNum.Maximum = int.Parse(split[1]);				// Set nudShpItemVNum.Maximum to ObjVNumMax

				myStreamReader.ReadLine();									// Consume <buy_types>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				clboxShpBuyTypes.Items.Clear();								// Clear clboxShpBuyTypes.Items
				while(temp.CompareTo("</buy_types>") != 0)					// Read until </buy_types> is found.
				{
					split = temp.Split('*');								// Split temp.
					clboxShpBuyTypes.Items.Add(split[0]);
					if(temp.EndsWith("*") == true)
					{
						clboxShpBuyTypes.SetItemChecked((clboxShpBuyTypes.Items.Count - 1), true);	// Set any default Buy Types.
					}
					shpBuyTypes.Add(split[0]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				defaultShop.BuyTypes = new int[clboxShpBuyTypes.CheckedIndices.Count];
				clboxShpBuyTypes.CheckedIndices.CopyTo(defaultShop.BuyTypes, 0);

				split = myStreamReader.ReadLine().Split('=');				// Read MLenMax and Split it.
				shpMessageMax = int.Parse(split[1]);						// Set shpMessageMax

				myStreamReader.ReadLine();									// Consume <tempers>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				cboxShpShopkeeperTemper.Items.Clear();						// Clear cboxShpShopkeeperTemper.Items
				while(temp.CompareTo("</tempers>") != 0)					// Read until </tempers> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					cboxShpShopkeeperTemper.Items.Add(split[1]);			// Add door type to cboxShpShopkeeperTemper.Items
					if(temp.EndsWith("*") == true)
					{
						cboxShpShopkeeperTemper.SelectedIndex = (cboxShpShopkeeperTemper.Items.Count - 1);	// Set default Temper.
					}
					shpTempers.Add(split[0]);
					shpTempers.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				if(cboxShpShopkeeperTemper.SelectedIndex != -1)
				{
					defaultShop.ShopkeeperTemper = cboxShpShopkeeperTemper.SelectedIndex;
				}
				else
				{
					defaultShop.ShopkeeperTemper = 0;
				}

				myStreamReader.ReadLine();									// Consume <bitvectors>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				clboxShpShopBitvector.Items.Clear();						// Clear clboxShpShopBitvector.Items
				while(temp.CompareTo("</bitvectors>") != 0)					// Read until </bitvectors> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					clboxShpShopBitvector.Items.Add(split[1]);				// Add bitvector to clboxWldRoomBitvector.Items
					if(temp.EndsWith("*") == true)
					{
						clboxShpShopBitvector.SetItemChecked((clboxShpShopBitvector.Items.Count - 1), true);	// Set any default Shop Bitvectors.
					}
					shpBitvectors.Add(split[0]);
					shpBitvectors.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				defaultShop.ShopBitvector = new int[clboxShpShopBitvector.CheckedIndices.Count];
				clboxShpShopBitvector.CheckedIndices.CopyTo(defaultShop.ShopBitvector, 0);

				split = myStreamReader.ReadLine().Split('=');				// Read MobVNumMin and Split it.
				nudShpMobileVNum.Minimum = int.Parse(split[1]);				// Set nudShpMobileVNum.Minimum to MobVNumMin
				split = myStreamReader.ReadLine().Split('=');				// Read MobVNumMax and Split it.
				nudShpMobileVNum.Maximum = int.Parse(split[1]);				// Set nudShpMobileVNum.Maximum to MobVNumMax

				myStreamReader.ReadLine();									// Consume <no_sell>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				clboxShpWillNotSellTo.Items.Clear();						// Clear clboxShpWillNotSellTo.Items
				while(temp.CompareTo("</no_sell>") != 0)					// Read until </no_sell> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					clboxShpWillNotSellTo.Items.Add(split[1]);				// Add bitvector to clboxShpWillNotSellTo.Items
					if(temp.EndsWith("*") == true)
					{
						clboxShpWillNotSellTo.SetItemChecked((clboxShpWillNotSellTo.Items.Count - 1), true);	// Set any default NoSell Bitvectors.
					}
					shpWillNotSellTo.Add(split[0]);
					shpWillNotSellTo.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				defaultShop.WillNotSellTo = new int[clboxShpWillNotSellTo.CheckedIndices.Count];
				clboxShpWillNotSellTo.CheckedIndices.CopyTo(defaultShop.WillNotSellTo, 0);

				split = myStreamReader.ReadLine().Split('=');				// Read WldVNumMin and Split it.
				nudShpRoomVNum.Minimum = int.Parse(split[1]);				// Set nudShpRoomVNum.Minimum to WldVNumMin
				split = myStreamReader.ReadLine().Split('=');				// Read WldVNumMax and Split it.
				nudShpRoomVNum.Maximum = int.Parse(split[1]);				// Set nudShpRoomVNum.Maximum to WldVNumMax
			
				split = myStreamReader.ReadLine().Split('=');				// Read TimeMin and Split it.
				nudShpOpenTime1.Minimum = int.Parse(split[1]);				// Set nudShpOpenTime1.Minimum to TimeMin
				nudShpCloseTime1.Minimum = int.Parse(split[1]);				// Set nudShpCloseTime1.Minimum to TimeMin
				nudShpOpenTime2.Minimum = int.Parse(split[1]);				// Set nudShpOpenTime2.Minimum to TimeMin
				nudShpCloseTime2.Minimum = int.Parse(split[1]);				// Set nudShpCloseTime2.Minimum to TimeMin
				split = myStreamReader.ReadLine().Split('=');				// Read TimeMax and Split it.
				nudShpOpenTime1.Maximum = int.Parse(split[1]);				// Set nudShpOpenTime1.Maximum to TimeMax
				nudShpCloseTime1.Maximum = int.Parse(split[1]);				// Set nudShpCloseTime1.Maximum to TimeMax
				nudShpOpenTime2.Maximum = int.Parse(split[1]);				// Set nudShpOpenTime2.Maximum to TimeMax
				nudShpCloseTime2.Maximum = int.Parse(split[1]);				// Set nudShpCloseTime2.Maximum to TimeMax

				myStreamReader.ReadLine();									// Consume </shops>
				myStreamReader.ReadLine();									// Consume <zones>
			
				split = myStreamReader.ReadLine().Split('=');				// Read VNumMin and Split it.
				nudZonNumber.Minimum = int.Parse(split[1]);					// Set nudZonNumber.Minimum to VNumMin
				split = myStreamReader.ReadLine().Split('=');				// Read VNumMax and Split it.
				nudZonNumber.Maximum = int.Parse(split[1]);					// Set nudZonNumber.Maximum to VNumMax
				defaultZone.NumberMin = decimal.ToInt32(nudZonNumber.Minimum);
				defaultZone.NumberMax = decimal.ToInt32(nudZonNumber.Maximum);
			
				split = myStreamReader.ReadLine().Split('=');				// Read NameMax and Split it.
				tbZonZoneName.MaxLength = int.Parse(split[1]);				// Set tbZonZoneName.MaxLength to NameMax

				split = myStreamReader.ReadLine().Split('=');				// Read LifeMin and Split it.
				nudZonLifespan.Minimum = int.Parse(split[1]);				// Set nudZonLifespan.Minimum to LifeMin
				split = myStreamReader.ReadLine().Split('=');				// Read LifeMax and Split it.
				nudZonLifespan.Maximum = int.Parse(split[1]);				// Set nudZonLifespan.Maximum to LifeMax

				myStreamReader.ReadLine();									// Consume <resets>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				cboxZonResetMode.Items.Clear();								// Clear cboxZonResetMode.Items
				while(temp.CompareTo("</resets>") != 0)						// Read until </resets> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					cboxZonResetMode.Items.Add(split[1]);					// Add reset mode to cboxZonResetMode.Items
					if(temp.EndsWith("*") == true)
					{
						cboxZonResetMode.SelectedIndex = (cboxZonResetMode.Items.Count - 1);	// Set default Reset Mode.
					}
					zonResetModes.Add(split[0]);
					zonResetModes.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				if(cboxZonResetMode.SelectedIndex != -1)
				{
					defaultZone.ResetMode = cboxZonResetMode.SelectedIndex;
				}
				else
				{
					defaultZone.ResetMode = 0;
				}

				myStreamReader.ReadLine();									// Consume <commands>
				temp = myStreamReader.ReadLine().Trim();					// Read next line and trim whitespace.
				cboxZonCommandType.Items.Clear();							// Clear cboxZonCommandType.Items
				while(temp.CompareTo("</commands>") != 0)					// Read until </commands> is found.
				{
					split = temp.Split(new char[] {'=','*'});				// Split temp.
					cboxZonCommandType.Items.Add(split[1]);					// Add command type to cboxZonCommandType.Items
					if(temp.EndsWith("*") == true)
					{
						cboxZonCommandType.SelectedIndex = (cboxZonCommandType.Items.Count - 1);	// Set default Command Type.
					}
					zonCommandTypes.Add(split[0]);
					zonCommandTypes.Add(split[1]);
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
				}
				cboxZonCommandType.Items.Add("Comment Only");
				zonCommandTypes.Add("*");
				if(cboxZonCommandType.SelectedIndex != -1)
				{
					defaultZone.CommandType = cboxZonCommandType.SelectedIndex;
				}
				else
				{
					defaultZone.CommandType = 0;
				}

				myStreamReader.ReadLine();									// Consume <command_info>
				for(int i = 0; i < (zonCommandTypes.Count / 2); i++)
				{
					CommandData theCommand = new CommandData();

					myStreamReader.ReadLine();								// Consume <(command)>
					temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
					if(temp.CompareTo("unused") != 0)						// Object Type has values, read them in.
					{
						for(int j = 0; j < 3; j++)
						{
							temp = myStreamReader.ReadLine().Trim();				// Read next line and trim whitespace.
							Arg myArg = new Arg();
							if(temp.CompareTo("unused") != 0)						// Value is used, read it in.
							{
								split = temp.Split('=');
								myArg.ArgTxt = split[1];
								split = myStreamReader.ReadLine().Trim().Split('=');
								myArg.ArgMin = long.Parse(split[1]);
								split = myStreamReader.ReadLine().Trim().Split('=');
								myArg.ArgMax = long.Parse(split[1]);

								myStreamReader.ReadLine();							// Consume <range>
								temp = myStreamReader.ReadLine().Trim();			// Read next line and trim whitespace.
								if(temp.CompareTo("unused") != 0)					// Range is used, read it in.
								{
									if(temp.CompareTo("mobiles") == 0)
									{
										myArg.Range.Add("<MOBILES>");
										myStreamReader.ReadLine();					// Consume </range>
									}
									else if(temp.CompareTo("objects") == 0)
									{
										myArg.Range.Add("<OBJECTS>");
										myStreamReader.ReadLine();					// Consume </range>
									}
									else if(temp.CompareTo("rooms") == 0)
									{
										myArg.Range.Add("<ROOMS>");
										myStreamReader.ReadLine();					// Consume </range>
									}
									else if(temp.CompareTo("shops") == 0)
									{
										myArg.Range.Add("<SHOPS>");
										myStreamReader.ReadLine();					// Consume </range>
									}
									else
									{
										while(temp.CompareTo("</range>") != 0)			// Read until </range> is found.
										{
											split = temp.Split(new char[] {'=','*'});	// Split temp.

											myArg.Range.Add(split[0]);
											myArg.Range.Add(split[1]);

											temp = myStreamReader.ReadLine().Trim();	// Read next line and trim whitespace.
										}
									}
								}
								else
								{
									myStreamReader.ReadLine();						// Consume </range>
								}
							}
							else
							{
								myArg.ArgTxt = "unused";
							}

							theCommand.Arg.Add(j, myArg);

							myStreamReader.ReadLine();								// Consume </(argX)>
							myStreamReader.ReadLine();								// Consume next line.
						}
					}
					else
					{
						for(int j = 0;j < 3;j++)
						{
							Arg tmpArg = new Arg();
							tmpArg.ArgTxt = "unused";
							theCommand.Arg.Add(j, tmpArg);
						}
						myStreamReader.ReadLine();								// Consume </(command_info)>
					}

					theCommands.Add(zonCommandTypes[i*2], theCommand);
				}

				myStream.Close();

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Loading MUD Configuration File";
				MessageBox.Show(e.Message + "\n\nMalformed MUD Configuration File!", "Error");

				return false;
			}
		}

		private bool openMobFile(Stream myStream)
		{
			StreamReader myStreamReader = new StreamReader(myStream);
			string temp, temp2;
			string[] split, split2;
			string[] strArray = new String[4];

			try
			{
				temp = myStreamReader.ReadLine().Trim();								// Read first line of file.
				while(temp.CompareTo("$") != 0)											// File terminates with $ on a line.
				{
					split = temp.Split('#');											// Split the VNum from the #
					Mobile myMobile = new Mobile(long.Parse(split[1]));					// Create a new Mobile(VNum)

					for(int i = 0; i < 4; i++)
					{
						temp2 = "";														// Clear temp2
						do																// Read lines in until ~ is found at the end.
						{
							temp = myStreamReader.ReadLine();							// Read the line.
							temp2 += temp + "\r\n";										// Append line to temp2
						} while(!temp.EndsWith("~"));									// Terminate when ~ is found at the end.
						split = temp2.Split('~');
						strArray[i] = split[0].TrimEnd();								// strArray[i] is temp2 minus the '~' at the end.
					}
					myMobile.AliasList = strArray[0];
					myMobile.ShortDescription = strArray[1];
					myMobile.LongDescription = strArray[2];
					myMobile.DetailedDescription = strArray[3];

					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					split = temp.Split();												// Split temp on the spaces.
					myMobile.ActionBitvector = split[0];
					myMobile.AffectionBitvector = split[1];
					myMobile.Alignment = int.Parse(split[2]);
					myMobile.TypeFlag = split[3];

					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					split = temp.Split();												// Split temp on the spaces.
					myMobile.Level = int.Parse(split[0]);
					myMobile.Thaco = int.Parse(split[1]);
					myMobile.ArmorClass = int.Parse(split[2]);
					split2 = split[3].Split(new Char[] { 'd', '+' });					// split2 is set to split[3] and split it on 'd' and '+' (xdy+z)
					myMobile.HPNum = int.Parse(split2[0]);
					myMobile.HPDie = int.Parse(split2[1]);
					myMobile.HPAdd = int.Parse(split2[2]);
					split2 = split[4].Split(new Char[] { 'd', '+' });					// split2 is set to split[4] and split it on 'd' and '+' (xdy+z)
					myMobile.BHNum = int.Parse(split2[0]);
					myMobile.BHDie = int.Parse(split2[1]);
					myMobile.BHAdd = int.Parse(split2[2]);

					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					split = temp.Split();												// Split temp on the spaces.
					myMobile.Gold = long.Parse(split[0]);
					myMobile.Experience = long.Parse(split[1]);
					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					split = temp.Split();												// Split temp on the spaces.
					myMobile.LoadPosition = int.Parse(split[0]);
					myMobile.DefaultPosition = int.Parse(split[1]);
					myMobile.Sex = int.Parse(split[2]);

					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					if((myMobile.TypeFlag.CompareTo("E") == 0) && (temp.CompareTo("#") != 0))
					{
						while(temp.CompareTo("E") != 0)
						{
							split = temp.Split(':');
							myMobile.ESpecs.Add(split[0].Trim(), split[1].Trim());

							temp = myStreamReader.ReadLine().Trim();
						}
						temp = myStreamReader.ReadLine().Trim();
					}

					theMobiles.Add(myMobile.VNum, myMobile);							// Add the mobile to theMobiles
				}

				this.setMobQuickSelect();
				cboxMobQuickSelect.SelectedIndex = 0;

				if(int.Parse(decimal.ToInt32(nudMobVNum.Value).ToString()) >= 100)
				{
					mobZone = int.Parse(decimal.ToInt32(nudMobVNum.Value).ToString().Substring(0, (decimal.ToInt32(nudMobVNum.Value).ToString().Length - 2)));
					nudMobVNum.Minimum = int.Parse(mobZone + "00");
					nudMobVNum.Maximum = int.Parse(mobZone + "99");
				}
				else
				{
					nudMobVNum.Minimum = 0;
					nudMobVNum.Maximum = 99;
				}

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Loading Mobile File";
				MessageBox.Show(e.Message + "\n\nMalformed Mobile File!", "Error");

				return false;
			}
		}

		private bool openObjFile(Stream myStream)
		{
			StreamReader myStreamReader = new StreamReader(myStream);
			string temp, temp2;
			string[] split;
			string[] strArray = new string[4];

			try
			{
				temp = myStreamReader.ReadLine().Trim();								// Read first line of file.
				while(temp.CompareTo("$") != 0)											// File terminates with $ on a line.
				{
					split = temp.Split('#');											// Split the VNum from the #
					Object myObject = new Object(long.Parse(split[1]));					// Create a new Object(VNum)

					for(int i = 0; i < 4; i++)
					{
						temp2 = "";															// Clear temp2
						do																	// Read lines in until ~ is found at the end.
						{
							temp = myStreamReader.ReadLine();								// Read the line.
							temp2 += temp + "\r\n";											// Append line to temp2
						} while(!temp.EndsWith("~"));										// Terminate when ~ is found at the end.
						split = temp2.Split('~');
						strArray[i] = split[0].TrimEnd();								// strArray[i] is temp2 minus the '~' at the end.
					}
					myObject.AliasList = strArray[0];
					myObject.ShortDescription = strArray[1];
					myObject.LongDescription = strArray[2];
					myObject.ActionDescription = strArray[3];
				
					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					split = temp.Split();												// Split temp on the spaces.
					myObject.TypeFlag = int.Parse(split[0]);
					myObject.EffectsBitvector = split[1];
					myObject.WearBitvector = split[2];

					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					split = temp.Split();												// Split temp on the spaces.
					myObject.Value0 = long.Parse(split[0]);
					myObject.Value1 = long.Parse(split[1]);
					myObject.Value2 = long.Parse(split[2]);
					myObject.Value3 = long.Parse(split[3]);

					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					split = temp.Split();												// Split temp on the spaces.
					myObject.Weight = int.Parse(split[0]);
					myObject.Cost =  long.Parse(split[1]);
					myObject.RentPerDay =  long.Parse(split[2]);

					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					while((temp.Substring(0, 1).CompareTo("#") != 0) && (temp.CompareTo("$") != 0))
					{
						if(temp.CompareTo("A") == 0)
						{
							temp = myStreamReader.ReadLine().Trim();
                            split = Regex.Split(temp, @"\s+");
							myObject.Affects.Add(split[0], new Affect(int.Parse(split[0]), long.Parse(split[1])));
						}
						else if(temp.CompareTo("E") == 0)
						{
							for(int i = 0; i < 2; i++)
							{
								temp2 = "";															// Clear temp2
								do																	// Read lines in until ~ is found at the end.
								{
									temp = myStreamReader.ReadLine();								// Read the line.
									temp2 += temp + "\r\n";											// Append line to temp2
								} while(!temp.EndsWith("~"));										// Terminate when ~ is found at the end.
								split = temp2.Split('~');
								strArray[i] = split[0].TrimEnd();								// strArray[i] is temp2 minus the '~' at the end.
							}
							myObject.ExtraDescriptions.Add(myObject.ExtraDescriptions.Count, new ExtraDescription(strArray[0], strArray[1]));
						}
						temp = myStreamReader.ReadLine().Trim();
					}

					theObjects.Add(myObject.VNum, myObject);							// Add the object to theObjects
				}

				this.setObjQuickSelect();
				cboxObjQuickSelect.SelectedIndex = 0;

				if(int.Parse(decimal.ToInt32(nudObjVNum.Value).ToString()) >= 100)
				{
					objZone = int.Parse(decimal.ToInt32(nudObjVNum.Value).ToString().Substring(0, (decimal.ToInt32(nudObjVNum.Value).ToString().Length - 2)));
					nudObjVNum.Minimum = int.Parse(objZone + "00");
					nudObjVNum.Maximum = int.Parse(objZone + "99");
				}
				else
				{
					nudObjVNum.Minimum = 0;
					nudObjVNum.Maximum = 99;
				}

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Loading Object File";
				MessageBox.Show(e.Message + "\n\nMalformed Object File!", "Error");

				return false;
			}
		}

		private bool openWldFile(Stream myStream)
		{
			StreamReader myStreamReader = new StreamReader(myStream);
			string temp, temp2;
			string[] split;
			string[] strArray = new string[2];

			try
			{
				temp = myStreamReader.ReadLine().Trim();								// Read first line of file.
				while(temp.CompareTo("$") != 0)											// File terminates with $ on a line.
				{
					split = temp.Split('#');											// Split the VNum from the #
					Room myRoom = new Room(long.Parse(split[1]));						// Create a new Room(VNum)

					for(int i = 0; i < 2; i++)
					{
						temp2 = "";										// Clear temp2
						do												// Read lines in until ~ is found at the end.
						{
							temp = myStreamReader.ReadLine();			// Read the line.
							temp2 += temp + "\r\n";						// Append line to temp2
						} while(!temp.EndsWith("~"));					// Terminate when ~ is found at the end.
						split = temp2.Split('~');
						strArray[i] = split[0].TrimEnd();				// strArray[i] is temp2 minus the '~' at the end.
					}
					myRoom.Name = strArray[0];
					myRoom.Description = strArray[1];
				
					temp = myStreamReader.ReadLine().Trim();							// Read in the next line and trim it.
					split = temp.Split();												// Split temp on the spaces.
					myRoom.Zone = int.Parse(split[0]);
					myRoom.RoomBitvector = split[1];
					myRoom.SectorType = int.Parse(split[2]);

					temp = myStreamReader.ReadLine().Trim();
					while(temp.CompareTo("S") != 0)
					{
						if(temp.Substring(0, 1).CompareTo("D") == 0)
						{
							DirectionData myDirection = new DirectionData(int.Parse(temp.Substring(1, 1)));
							for(int i = 0; i < 2; i++)
							{
								temp2 = "";								// Clear temp2
								do										// Read lines in until ~ is found at the end.
								{
									temp = myStreamReader.ReadLine();	// Read the line.
									temp2 += temp + "\r\n";				// Append line to temp2
								} while(!temp.EndsWith("~"));			// Terminate when ~ is found at the end.
								split = temp2.Split('~');
								strArray[i] = split[0].TrimEnd();		// strArray[i] is temp2 minus the '~ ' at the end.
							}
							myDirection.Description = strArray[0];
							myDirection.Keywords = strArray[1];

							temp = myStreamReader.ReadLine().Trim();
							split = temp.Split();
							myDirection.DoorFlag = int.Parse(split[0]);
							myDirection.Key = long.Parse(split[1]);
							myDirection.Exit = long.Parse(split[2]);
							myDirection.Exists = true;

							myRoom.DirectionField.Add(myDirection.Direction, myDirection);
						}
						else if(temp.Substring(0, 1).CompareTo("E") == 0)
						{
							for(int i = 0; i < 2; i++)
							{
								temp2 = "";															// Clear temp2
								do																	// Read lines in until ~ is found at the end.
								{
									temp = myStreamReader.ReadLine();								// Read the line.
									temp2 += temp + "\r\n";											// Append line to temp2
								} while(!temp.EndsWith("~"));										// Terminate when ~ is found at the end.
								split = temp2.Split('~');
								strArray[i] = split[0].TrimEnd();									// strArray[i] is temp2 minus the '~' at the end.
							}
							myRoom.ExtraDescriptions.Add(myRoom.ExtraDescriptions.Count, new ExtraDescription(strArray[0], strArray[1]));
						}
						temp = myStreamReader.ReadLine().Trim();
					}
					temp = myStreamReader.ReadLine().Trim();

					theRooms.Add(myRoom.VNum, myRoom);							// Add the object to theObjects
				}

				this.setWldQuickSelect();
				cboxWldQuickSelect.SelectedIndex = 0;

				if(int.Parse(decimal.ToInt32(nudWldVNum.Value).ToString()) >= 100)
				{
					wldZone = int.Parse(decimal.ToInt32(nudWldVNum.Value).ToString().Substring(0, (decimal.ToInt32(nudWldVNum.Value).ToString().Length - 2)));
					nudWldVNum.Minimum = int.Parse(wldZone + "00");
					nudWldVNum.Maximum = int.Parse(wldZone + "99");
				}
				else
				{
					nudWldVNum.Minimum = 0;
					nudWldVNum.Maximum = 99;
				}

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Loading World File";
				MessageBox.Show(e.Message + "\n\nMalformed World File!", "Error");

				return false;
			}
		}

		private bool openShpFile(Stream myStream)
		{
			StreamReader myStreamReader = new StreamReader(myStream);
			string temp, temp2;
			string[] split;
			string[] strArray = new string[7];

			try
			{
				temp = myStreamReader.ReadLine().Trim();								// Read first line of file.
				while(temp.CompareTo("$~") != 0)										// File terminates with '$~' on a line.
				{
					if(temp.CompareTo("CircleMUD v3.0 Shop File~") == 0)
					{
						temp = myStreamReader.ReadLine().Trim();
					}

					split = temp.Split(new Char[] { '#', '~' });						// Split the VNum from the #
					Shop myShop = new Shop(long.Parse(split[1]));						// Create a new Shop(VNum)

					temp = myStreamReader.ReadLine().Trim();
					while(temp.CompareTo("-1") != 0)
					{
						myShop.ShopItems.Add(temp);
						temp = myStreamReader.ReadLine().Trim();
					}

					temp = myStreamReader.ReadLine().Trim();
					myShop.SellProfit = double.Parse(temp);
					temp = myStreamReader.ReadLine().Trim();
					myShop.BuyProfit = double.Parse(temp);

					temp = myStreamReader.ReadLine().Trim();
					while(temp.CompareTo("-1") != 0)
					{
						myShop.BuyTypes.Add(temp);
						temp = myStreamReader.ReadLine().Trim();
					}

					for(int i = 0; i < 7; i++)
					{
						temp2 = "";															// Clear temp2
						do																	// Read lines in until ~ is found at the end.
						{
							temp = myStreamReader.ReadLine();								// Read the line.
							temp2 += temp + "\r\n";											// Append line to temp2
						} while(!temp.EndsWith("~"));										// Terminate when ~ is found at the end.
						split = temp2.Split('~');
						strArray[i] = split[0].TrimEnd();									// strArray[i] is temp2 minus the '~ ' at the end.
					}
					myShop.MessageBuyItemDoesNotExist = strArray[0].Substring(3);
					myShop.MessageSellItemDoesNotExist = strArray[1].Substring(3);
					myShop.MessageShopDoesNotBuyItem = strArray[2].Substring(3);
					myShop.MessageShopCanNotAffordItem = strArray[3].Substring(3);
					myShop.MessagePlayerCanNotAffordItem = strArray[4].Substring(3);
					myShop.MessageBuySuccess = strArray[5].Substring(3);
					myShop.MessageSellSuccess = strArray[6].Substring(3);

					temp = myStreamReader.ReadLine().Trim();
					myShop.ShopkeeperTemper = int.Parse(temp);
					temp = myStreamReader.ReadLine().Trim();
					myShop.ShopBitvector = temp;
					temp = myStreamReader.ReadLine().Trim();
					myShop.ShopkeeperVNum = long.Parse(temp);
					temp = myStreamReader.ReadLine().Trim();
					myShop.WithWhoBitvector = temp;

					temp = myStreamReader.ReadLine().Trim();
					while(temp.CompareTo("-1") != 0)
					{
						myShop.ShopRooms.Add(temp);
						temp = myStreamReader.ReadLine().Trim();
					}

					temp = myStreamReader.ReadLine().Trim();
					myShop.OpenTime1 = int.Parse(temp);
					temp = myStreamReader.ReadLine().Trim();
					myShop.CloseTime1 = int.Parse(temp);
					temp = myStreamReader.ReadLine().Trim();
					myShop.OpenTime2 = int.Parse(temp);
					temp = myStreamReader.ReadLine().Trim();
					myShop.CloseTime2 = int.Parse(temp);

					temp = myStreamReader.ReadLine().Trim();

					theShops.Add(myShop.VNum, myShop);							// Add the shop to theShops
				}

				this.setShpQuickSelect();
				cboxShpQuickSelect.SelectedIndex = 0;

				if(int.Parse(decimal.ToInt32(nudShpVNum.Value).ToString()) >= 100)
				{
					shpZone = int.Parse(decimal.ToInt32(nudShpVNum.Value).ToString().Substring(0, (decimal.ToInt32(nudShpVNum.Value).ToString().Length - 2)));
					nudShpVNum.Minimum = int.Parse(shpZone + "00");
					nudShpVNum.Maximum = int.Parse(shpZone + "99");
				}
				else
				{
					nudShpVNum.Minimum = 0;
					nudShpVNum.Maximum = 99;
				}

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Loading Shop File";
				MessageBox.Show(e.Message + "\n\nMalformed Shop File!", "Error");

				return false;
			}
		}

		private bool openZonFile(Stream myStream)
		{
			StreamReader myStreamReader = new StreamReader(myStream);
			string temp, temp2;
			string[] split;
			string[] strArray = new string[7];
			Arg myArg;

			try
			{
				temp = myStreamReader.ReadLine().Trim();							// Read first line of file.
				split = temp.Split('#');											// Split the VNum from the #
				Zone myZone = new Zone(int.Parse(split[1]));						// Create a new Zone(Number)

				currentZoneNumber = myZone.Number;

				temp2 = "";															// Clear temp2
				do																	// Read lines in until ~ is found at the end.
				{
					temp = myStreamReader.ReadLine();								// Read the line.
					temp2 += temp + " ";											// Append line to temp2
				} while(!temp.EndsWith("~"));										// Terminate when ~ is found at the end.
				split = temp2.Split('~');
				myZone.Name = split[0].TrimEnd();									// split[0] minus any whitespace.

				temp = myStreamReader.ReadLine().Trim();
				split = temp.Split();
				myZone.BottomRoom = long.Parse(split[0]);
				myZone.TopRoom = long.Parse(split[1]);
				myZone.Lifespan = int.Parse(split[2]);
				myZone.ResetMode = int.Parse(split[3]);

				temp = myStreamReader.ReadLine().Trim();
				ZoneCommand myCommand;
				for(int i = 0; temp.CompareTo("S") != 0; i++)						// File terminates with 'S' on a line.
				{
					myCommand = new ZoneCommand();
					if(temp.StartsWith("*") == false)
					{
						int jStart = 2;
						split = temp.Split();
						myCommand.CommandType = split[0];
						myCommand.IfFlag = int.Parse(split[1]);
						myArg = ((Arg)((CommandData)theCommands[myCommand.CommandType]).Arg[0]);
						if(myArg.ArgTxt.CompareTo("unused") != 0)
						{
							myCommand.Arg0 = long.Parse(split[2]);
							jStart = 3;
						}
						myArg = ((Arg)((CommandData)theCommands[myCommand.CommandType]).Arg[1]);
						if(myArg.ArgTxt.CompareTo("unused") != 0)
						{
							myCommand.Arg1 = long.Parse(split[3]);
							jStart = 4;
						}
						myArg = ((Arg)((CommandData)theCommands[myCommand.CommandType]).Arg[2]);
						if(myArg.ArgTxt.CompareTo("unused") != 0)
						{
							myCommand.Arg2 = long.Parse(split[4]);
							jStart = 5;
						}
						myCommand.Comment = "";
						for(int j = jStart; j < split.Length; j++)
						{
							myCommand.Comment += split[j] + " ";
						}
						myCommand.Comment = myCommand.Comment.Trim();
						myZone.ZoneCommands.Add(i, myCommand);
					}
					else
					{
						myCommand.CommandType = "*";
						myCommand.Comment = temp.Substring(1).Trim();
						myZone.ZoneCommands.Add(i, myCommand);
					}
					temp = myStreamReader.ReadLine().Trim();
				}

				currentZone = myZone;

				this.loadZone();

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Loading Zone File";
				MessageBox.Show(e.Message + "\n\nMalformed Zone File!", "Error");

				return false;
			}
		}

		private void setBitvector(string theBitvector, StringCollection theCollection, CheckedListBox theCLBox)
		{
			if(theBitvector.Length > 0)
			{
				if(Char.IsNumber(theBitvector, 0))
				{
					long myNumber = long.Parse(theBitvector);
					foreach(int i in theCLBox.CheckedIndices)
					{
						theCLBox.SetItemChecked(i, false);
					}
					for(int i = 1; myNumber > 0; i++)
					{
						long num = (long)System.Math.Pow(2, ((theCollection.Count / 2) - i));
						if((myNumber - num) >= 0)
						{
							myNumber -= num;
							theCLBox.SetItemChecked(((theCollection.Count / 2) - i), true);
						}
					}
				}
				else if(theBitvector.CompareTo("0") != 0)
				{
					char[] myBits = theBitvector.ToCharArray();
					foreach(int i in theCLBox.CheckedIndices)
					{
						theCLBox.SetItemChecked(i, false);
					}
					foreach(char c in myBits)
					{
						theCLBox.SetItemChecked((theCollection.IndexOf(c.ToString()) / 2), true);
					}
				}
			}
		}

		private string genBitvector(CheckedListBox.CheckedIndexCollection theBits, StringCollection theCollection)
		{
			string myBitvector = "";

			foreach(int i in theBits)
			{
				myBitvector += theCollection[i*2];
			}

			return myBitvector;
		}

		private void setDirectionData()
		{
			if(currentRoom != null)
			{
				loadingExit = true;

				NumericUpDown[] myDirNUD = new NumericUpDown[6];
				myDirNUD[0] = nudWldNorth;
				myDirNUD[1] = nudWldEast;
				myDirNUD[2] = nudWldSouth;
				myDirNUD[3] = nudWldWest;
				myDirNUD[4] = nudWldUp;
				myDirNUD[5] = nudWldDown;

				for(int i = 0; i < 6; i++)
				{
					myDirNUD[i].Enabled = false;
				}

				myDirNUD[currentDirection].Enabled = true;

				if(currentRoom.DirectionField.IndexOfKey(currentDirection) != -1)
				{
					DirectionData myDirectionData = ((DirectionData)currentRoom.DirectionField[currentDirection]);

					if(myDirectionData.Exists == true)
					{
						cbWldExitExists.Checked = true;
						cbWldNowhere.Enabled = true;
						if(myDirNUD[currentDirection].Value == -1)
						{
							cbWldNowhere.Checked = true;
						}
						else
						{
							cbWldNowhere.Checked = false;
						}
						gbWldDoorFlag.Enabled = true;
						cboxWldDoorFlag.SelectedIndex = (wldDoorFlags.IndexOf(myDirectionData.DoorFlag.ToString()) / 2);
						gbWldDoorKey.Enabled = true;
						nudWldDoorKey.Value = myDirectionData.Key;               
						Object myObject;
						if(theObjects.Count > 0)
						{
							cboxWldAreaDoorKey.Items.Clear();
							for(int i = 0; i < theObjects.Count; i++)
							{
								myObject = ((Object)theObjects.GetByIndex(i));
								cboxWldAreaDoorKey.Items.Add(myObject.VNum + " - " + myObject.ShortDescription);
							}
						}
						else
						{
							cboxWldAreaDoorKey.Enabled = false;
						}

						if(myDirectionData.Key == -1)
						{
							cbWldNoKey.Checked = true;
						}
						else
						{
							cbWldNoKey.Checked = false;
						}
						bWldDoorDescription.Enabled = true;
					}
					else
					{
						cbWldExitExists.Checked = false;
						cbWldNowhere.Checked = false;
						cbWldNowhere.Enabled = false;
						gbWldDoorFlag.Enabled = false;
						gbWldDoorKey.Enabled = false;
						bWldDoorDescription.Enabled = false;
					}
				}
				else
				{
					cbWldExitExists.Checked = false;
					cbWldNowhere.Checked = false;
					cbWldNowhere.Enabled = false;
					gbWldDoorFlag.Enabled = false;
					gbWldDoorKey.Enabled = false;
					bWldDoorDescription.Enabled = false;
				}

				loadingExit = false;
			}
		}

		private bool saveMobile()
		{
			long myVNum = decimal.ToInt64(nudMobVNum.Value);

			Mobile myMobile;
			if(theMobiles.ContainsKey(myVNum) == true)
			{
				if(currentMobile.VNum != myVNum)
				{
					if(MessageBox.Show("Mobile [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Mobile Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
					{
						return false;
					}
				}
				myMobile = ((Mobile)theMobiles[myVNum]);
				theMobiles.Remove(myVNum);
			}
			else
			{
				myMobile = new Mobile(myVNum);
			}
		
			myMobile.AliasList = tbMobAliasList.Text;
			myMobile.ShortDescription = tbMobShortDescription.Text;
			myMobile.LongDescription = tbMobLongDescription.Text;
			myMobile.DetailedDescription = tbMobDetailedDescription.Text;
			
			myMobile.ActionBitvector = this.genBitvector(clboxMobActionBitvector.CheckedIndices, mobActions);
			myMobile.AffectionBitvector = this.genBitvector(clboxMobAffectionBitvector.CheckedIndices, mobAffections);
			myMobile.Alignment = decimal.ToInt32(nudMobAlignment.Value);

			myMobile.Level = decimal.ToInt32(nudMobLevel.Value);
			myMobile.Thaco = decimal.ToInt32(nudMobThaco.Value);
			myMobile.ArmorClass = decimal.ToInt32(nudMobArmorClass.Value);
			myMobile.HPNum = decimal.ToInt32(nudMobHPNum.Value);
			myMobile.HPDie = decimal.ToInt32(nudMobHPDie.Value);
			myMobile.HPAdd = decimal.ToInt32(nudMobHPAdd.Value);
			myMobile.BHNum = decimal.ToInt32(nudMobBHNum.Value);
			myMobile.BHDie = decimal.ToInt32(nudMobBHDie.Value);
			myMobile.BHAdd = decimal.ToInt32(nudMobBHAdd.Value);

			myMobile.Gold = decimal.ToInt64(nudMobGold.Value);
			myMobile.Experience = decimal.ToInt64(nudMobExperience.Value);
			myMobile.LoadPosition = int.Parse(mobPositions[cboxMobLoadPosition.SelectedIndex * 2]);
			myMobile.DefaultPosition = int.Parse(mobPositions[cboxMobDefaultPosition.SelectedIndex * 2]);
			myMobile.Sex = int.Parse(mobGenders[cboxMobGender.SelectedIndex * 2]);

			if(myMobile.Equals(currentMobile) == false)
			{
				myMobile.ESpecs.Clear();
				for(int i = 0; i < currentMobile.ESpecs.Count; i++)
				{
					myMobile.ESpecs.Add(currentMobile.ESpecs.GetKey(i), currentMobile.ESpecs.GetByIndex(i));
				}
			}

			this.mobileEditorUnchanged();

			theMobiles.Add(myVNum, myMobile);

			this.setMobQuickSelect();
			cboxMobQuickSelect.SelectedIndex = theMobiles.IndexOfKey(myVNum);

			bMobDelete.Enabled = true;

			int myInt = cboxZonCommandType.SelectedIndex;
			cboxZonCommandType.SelectedIndex = (cboxZonCommandType.Items.Count - 1);
			cboxZonCommandType.SelectedIndex = myInt;

			this.updateMobCBoxes();

			return true;
		}

		private void updateMobCBoxes()
		{
			if(theMobiles.Count > 0)
			{
				Mobile myMobile;
				cboxShpAreaMobile.Items.Clear();
				for(int i = 0; i < theMobiles.Count; i++)
				{
					myMobile = ((Mobile)theMobiles.GetByIndex(i));
					cboxShpAreaMobile.Items.Add(myMobile.VNum + " - " + myMobile.ShortDescription);
				}
			}
		}

		private bool saveObject()
		{
			long myVNum = decimal.ToInt64(nudObjVNum.Value);
			
			Object myObject;
			if(theObjects.ContainsKey(myVNum) == true)
			{
				if(currentObject.VNum != myVNum)
				{
					if(MessageBox.Show("Object [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Object Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
					{
						return false;
					}
				}
				myObject = ((Object)theObjects[myVNum]);
				theObjects.Remove(myVNum);
			}
			else
			{
				myObject = new Object(myVNum);
			}
		
			myObject.AliasList = tbObjAliasList.Text;
			myObject.ShortDescription = tbObjShortDescription.Text;
			myObject.LongDescription = tbObjLongDescription.Text;
			myObject.ActionDescription = tbObjActionDescription.Text;
			
			myObject.TypeFlag = int.Parse(objTypeFlags[cboxObjTypeFlag.SelectedIndex * 2]);
			myObject.EffectsBitvector = this.genBitvector(clboxObjEffectsBitvector.CheckedIndices, objEffects);
			myObject.WearBitvector = this.genBitvector(clboxObjWearBitvector.CheckedIndices, objWear);

			if(nudObjValue0.Enabled == true)
			{
				myObject.Value0 = decimal.ToInt64(nudObjValue0.Value);
			}
			else
			{
				myObject.Value0 = 0;
			}
			if(nudObjValue1.Enabled == true)
			{
				myObject.Value1 = decimal.ToInt64(nudObjValue1.Value);
			}
			else
			{
				myObject.Value1 = 0;
			}
			if(nudObjValue2.Enabled == true)
			{
				myObject.Value2 = decimal.ToInt64(nudObjValue2.Value);
			}
			else
			{
				myObject.Value2 = 0;
			}
			if(nudObjValue3.Enabled == true)
			{
				myObject.Value3 = decimal.ToInt64(nudObjValue3.Value);
			}
			else
			{
				myObject.Value3 = 0;
			}

			myObject.Weight = decimal.ToInt32(nudObjWeight.Value);
			myObject.Cost = decimal.ToInt64(nudObjCost.Value);
			myObject.RentPerDay = decimal.ToInt64(nudObjRentPerDay.Value);

			if(myObject.Equals(currentObject) == false)
			{
				myObject.ExtraDescriptions.Clear();
				for(int i = 0; i < currentObject.ExtraDescriptions.Count; i++)
				{
					myObject.ExtraDescriptions.Add(i, currentObject.ExtraDescriptions[i]);
				}

				myObject.Affects.Clear();
				for(int i = 0; i < currentObject.Affects.Count; i++)
				{
					myObject.Affects.Add(currentObject.Affects.GetKey(i), currentObject.Affects.GetByIndex(i));
				}
			}

			this.objectEditorUnchanged();

			theObjects.Add(myVNum, myObject);

			this.setObjQuickSelect();
			cboxObjQuickSelect.SelectedIndex = theObjects.IndexOfKey(myVNum);

			bObjDelete.Enabled = true;

			int myInt = cboxZonCommandType.SelectedIndex;
			cboxZonCommandType.SelectedIndex = (cboxZonCommandType.Items.Count - 1);
			cboxZonCommandType.SelectedIndex = myInt;

			this.updateObjCBoxes();

			return true;
		}

		private void updateObjCBoxes()
		{
			if(theObjects.Count > 0)
			{
				Object myObject;
				cboxWldAreaDoorKey.Items.Clear();
				cboxShpAreaItem.Items.Clear();
				for(int i = 0; i < theObjects.Count; i++)
				{
					myObject = ((Object)theObjects.GetByIndex(i));
					cboxWldAreaDoorKey.Items.Add(myObject.VNum + " - " + myObject.ShortDescription);
					cboxShpAreaItem.Items.Add(myObject.VNum + " - " + myObject.ShortDescription);
				}
			}
		}

		private bool saveRoom()
		{
			long myVNum = decimal.ToInt64(nudWldVNum.Value);
			
			Room myRoom;
			if(theRooms.ContainsKey(myVNum) == true)
			{
				if(currentRoom.VNum != myVNum)
				{
					if(MessageBox.Show("Room [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Room Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
					{
						return false;
					}
				}
				myRoom = new Room(myVNum);
				theRooms.Remove(myVNum);
			}
			else
			{
				myRoom = new Room(myVNum);
			}

			myRoom.Name = tbWldRoomName.Text;
			myRoom.Description = tbWldRoomDescription.Text;
			myRoom.Zone = wldZone;
			myRoom.RoomBitvector = this.genBitvector(clboxWldRoomBitvector.CheckedIndices, wldBitvectors);
			myRoom.SectorType = int.Parse(wldSectorTypes[cboxWldSectorType.SelectedIndex * 2]);

			this.saveDirectionData();

			if(myRoom.Equals(currentRoom) == false)
			{
				myRoom.DirectionField.Clear();
				for(int i = 0; i < currentRoom.DirectionField.Count; i++)
				{
					myRoom.DirectionField.Add(currentRoom.DirectionField.GetKey(i), currentRoom.DirectionField.GetByIndex(i));
				}

				myRoom.ExtraDescriptions.Clear();
				for(int i = 0; i < currentRoom.ExtraDescriptions.Count; i++)
				{
					myRoom.ExtraDescriptions.Add(currentRoom.ExtraDescriptions.GetKey(i), currentRoom.ExtraDescriptions.GetByIndex(i));
				}
			}

			this.roomEditorUnchanged();

			theRooms.Add(myVNum, myRoom);

			this.setWldQuickSelect();
			cboxWldQuickSelect.SelectedIndex = theRooms.IndexOfKey(myVNum);

			bWldDelete.Enabled = true;

			int myInt = cboxZonCommandType.SelectedIndex;
			cboxZonCommandType.SelectedIndex = (cboxZonCommandType.Items.Count - 1);
			cboxZonCommandType.SelectedIndex = myInt;

			this.updateWldCBoxes();

			return true;
		}

		private void updateWldCBoxes()
		{
			if(theRooms.Count > 0)
			{
				Room myRoom;
				cboxShpAreaRoom.Items.Clear();
				for(int i = 0; i < theRooms.Count; i++)
				{
					myRoom = ((Room)theRooms.GetByIndex(i));
					cboxShpAreaRoom.Items.Add(myRoom.VNum + " - " + myRoom.Name);
				}
			}
		}

		private bool saveShop()
		{
			long myVNum = decimal.ToInt64(nudShpVNum.Value);
			string[] split;
			
			Shop myShop;
			if(theShops.ContainsKey(myVNum) == true)
			{
				if(currentShop.VNum != myVNum)
				{
					if(MessageBox.Show("Shop [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Shop Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
					{
						return false;
					}
				}
				myShop = new Shop(myVNum);
				theShops.Remove(myVNum);
			}
			else
			{
				myShop = new Shop(myVNum);
			}

			myShop.ShopItems.Clear();
			for(int i = 0; i < lboxShpShopItems.Items.Count; i++)
			{
				split = lboxShpShopItems.Items[i].ToString().Trim().Split();
				myShop.ShopItems.Add(split[0]);
			}
			myShop.BuyProfit = decimal.ToDouble(nudShpBuyProfit.Value);
			myShop.SellProfit = decimal.ToDouble(nudShpSellProfit.Value);
			myShop.BuyTypes.Clear();
			foreach(String s in clboxShpBuyTypes.CheckedItems)
			{
				myShop.BuyTypes.Add(s);
			}
			myShop.ShopkeeperTemper = int.Parse(shpTempers[cboxShpShopkeeperTemper.SelectedIndex * 2]);
			myShop.ShopBitvector = this.genBitvector(clboxShpShopBitvector.CheckedIndices, shpBitvectors);
			myShop.ShopkeeperVNum = decimal.ToInt64(nudShpMobileVNum.Value);
			myShop.WithWhoBitvector = this.genBitvector(clboxShpWillNotSellTo.CheckedIndices, shpWillNotSellTo);
			myShop.ShopRooms.Clear();
			for(int i = 0; i < lboxShpShopRooms.Items.Count; i++)
			{
				split = lboxShpShopRooms.Items[i].ToString().Trim().Split();
				myShop.ShopRooms.Add(split[0]);
			}
			myShop.OpenTime1 = decimal.ToInt32(nudShpOpenTime1.Value);
			myShop.CloseTime1 = decimal.ToInt32(nudShpCloseTime1.Value);
			myShop.OpenTime2 = decimal.ToInt32(nudShpOpenTime2.Value);
			myShop.CloseTime2 = decimal.ToInt32(nudShpCloseTime2.Value);

			if(myShop.Equals(currentShop) == false)
			{
				myShop.MessageBuyItemDoesNotExist = currentShop.MessageBuyItemDoesNotExist;
				myShop.MessageBuySuccess = currentShop.MessageBuySuccess;
				myShop.MessagePlayerCanNotAffordItem = currentShop.MessagePlayerCanNotAffordItem;
				myShop.MessageSellItemDoesNotExist = currentShop.MessageSellItemDoesNotExist;
				myShop.MessageSellSuccess = currentShop.MessageSellSuccess;
				myShop.MessageShopCanNotAffordItem = currentShop.MessageShopCanNotAffordItem;
				myShop.MessageShopDoesNotBuyItem = currentShop.MessageShopDoesNotBuyItem;
			}

			this.shopEditorUnchanged();

			theShops.Add(myVNum, myShop);

			this.setShpQuickSelect();
			cboxShpQuickSelect.SelectedIndex = theShops.IndexOfKey(myVNum);

			bShpDelete.Enabled = true;

			int myInt = cboxZonCommandType.SelectedIndex;
			cboxZonCommandType.SelectedIndex = (cboxZonCommandType.Items.Count - 1);
			cboxZonCommandType.SelectedIndex = myInt;

			return true;
		}

		private bool loadMobile(long theIndex, bool isInMemory)
		{
			if(isInMemory == true)
			{
				currentMobile = (Mobile)theMobiles.GetByIndex(decimal.ToInt32(theIndex));
			}
			else
			{
				currentMobile = (Mobile)theMobiles[theIndex];
			}

			nudMobVNum.Value = currentMobile.VNum;

			tbMobAliasList.Text = currentMobile.AliasList;
			tbMobShortDescription.Text = currentMobile.ShortDescription;
			tbMobLongDescription.Text = currentMobile.LongDescription;
			tbMobDetailedDescription.Text = currentMobile.DetailedDescription;

			this.setBitvector(currentMobile.ActionBitvector, mobActions, clboxMobActionBitvector);
			this.setBitvector(currentMobile.AffectionBitvector, mobAffections, clboxMobAffectionBitvector);
			nudMobAlignment.Value = currentMobile.Alignment;

			nudMobLevel.Value = currentMobile.Level;
			nudMobThaco.Value = currentMobile.Thaco;
			nudMobArmorClass.Value = currentMobile.ArmorClass;
			nudMobHPNum.Value = currentMobile.HPNum;
			nudMobHPDie.Value = currentMobile.HPDie;
			nudMobHPAdd.Value = currentMobile.HPAdd;
			nudMobBHNum.Value = currentMobile.BHNum;
			nudMobBHDie.Value = currentMobile.BHDie;
			nudMobBHAdd.Value = currentMobile.BHAdd;

			nudMobExperience.Value = currentMobile.Experience;
			nudMobGold.Value = currentMobile.Gold;

			cboxMobLoadPosition.SelectedIndex = (mobPositions.IndexOf(currentMobile.LoadPosition.ToString()) / 2);
			cboxMobDefaultPosition.SelectedIndex = (mobPositions.IndexOf(currentMobile.DefaultPosition.ToString()) / 2);
			cboxMobGender.SelectedIndex = (mobGenders.IndexOf(currentMobile.Sex.ToString()) / 2);

			this.mobileEditorUnchanged();

			return true;
		}

		private bool loadObject(long theIndex, bool isInMemory)
		{
			if(isInMemory == true)
			{
				currentObject = ((Object)theObjects.GetByIndex(decimal.ToInt32(theIndex)));
			}
			else
			{
				currentObject = ((Object)theObjects[theIndex]);
			}

			nudObjVNum.Value = currentObject.VNum;
			tbObjAliasList.Text = currentObject.AliasList;
			tbObjShortDescription.Text = currentObject.ShortDescription;
			tbObjLongDescription.Text = currentObject.LongDescription;
			tbObjActionDescription.Text = currentObject.ActionDescription;

			cboxObjTypeFlag.SelectedIndex = (objTypeFlags.IndexOf(currentObject.TypeFlag.ToString()) / 2);
			this.setBitvector(currentObject.EffectsBitvector, objEffects, clboxObjEffectsBitvector);
			this.setBitvector(currentObject.WearBitvector, objWear, clboxObjWearBitvector);

			if (nudObjValue0.Enabled == true)
			{
				nudObjValue0.Value = currentObject.Value0;
			}
			if (nudObjValue1.Enabled == true)
			{
				nudObjValue1.Value = currentObject.Value1;
			}
			if (nudObjValue2.Enabled == true)
			{
				nudObjValue2.Value = currentObject.Value2;
			}
			if (nudObjValue3.Enabled == true)
			{
				nudObjValue3.Value = currentObject.Value3;
			}

			nudObjWeight.Value = currentObject.Weight;
			nudObjCost.Value = currentObject.Cost;
			nudObjRentPerDay.Value = currentObject.RentPerDay;

			this.objectEditorUnchanged();

			return true;
		}

		private bool loadRoom(long theIndex, bool isInMemory)
		{
			NumericUpDown[] myDirNUD = new NumericUpDown[6];
			myDirNUD[0] = nudWldNorth;
			myDirNUD[1] = nudWldEast;
			myDirNUD[2] = nudWldSouth;
			myDirNUD[3] = nudWldWest;
			myDirNUD[4] = nudWldUp;
			myDirNUD[5] = nudWldDown;

			if(isInMemory == true)
			{
				currentRoom = ((Room)theRooms.GetByIndex(decimal.ToInt32(theIndex)));
			}
			else
			{
				currentRoom = ((Room)theRooms[theIndex]);
			}

			nudWldVNum.Value = currentRoom.VNum;
			tbWldRoomName.Text = currentRoom.Name;
			tbWldRoomDescription.Text = currentRoom.Description;
			this.setBitvector(currentRoom.RoomBitvector, wldBitvectors, clboxWldRoomBitvector);
			cboxWldSectorType.SelectedIndex = (wldSectorTypes.IndexOf(currentRoom.SectorType.ToString()) / 2);

			if(currentRoom.DirectionField.Count > 0)
			{
				DirectionData myDirectionData;
				for(int i = 0; i < currentRoom.DirectionField.Count; i++)
				{
					myDirectionData = ((DirectionData)currentRoom.DirectionField.GetByIndex(i));

					myDirNUD[myDirectionData.Direction].Value = myDirectionData.Exit;
				}
			}

			this.setDirectionData();

			this.roomEditorUnchanged();

			return true;
		}

		private bool loadShop(long theIndex, bool isInMemory)
		{
			if(isInMemory == true)
			{
				currentShop = ((Shop)theShops.GetByIndex(decimal.ToInt32(theIndex)));
			}
			else
			{
				currentShop = ((Shop)theShops[theIndex]);
			}

			nudShpVNum.Value = currentShop.VNum;

			Object myObject;
			lboxShpShopItems.Items.Clear();
			for(int i = 0; i < currentShop.ShopItems.Count; i++)
			{
				if(theObjects.Count > 0)
				{
					if(theObjects.IndexOfKey(long.Parse(currentShop.ShopItems[i])) != -1)
					{
						myObject = (Object)theObjects[long.Parse(currentShop.ShopItems[i])];
						lboxShpShopItems.Items.Add(myObject.VNum + " - " + myObject.ShortDescription);
					}
					else
					{
						lboxShpShopItems.Items.Add(currentShop.ShopItems[i] + " - (Unknown Object)");
					}
				}
				else
				{
					lboxShpShopItems.Items.Add(currentShop.ShopItems[i] + " - (Unknown Object)");
				}
			}

			nudShpBuyProfit.Value = (decimal)currentShop.BuyProfit;
			nudShpSellProfit.Value = (decimal)currentShop.SellProfit;

			for(int i = 0; i < clboxShpBuyTypes.Items.Count; i++)
			{
				clboxShpBuyTypes.SetItemChecked(i, false);
			}

			for(int i = 0; i < currentShop.BuyTypes.Count; i++)
			{
				clboxShpBuyTypes.SetItemChecked(clboxShpBuyTypes.Items.IndexOf(currentShop.BuyTypes[i]), true);
			}

			cboxShpShopkeeperTemper.SelectedIndex = (shpTempers.IndexOf(currentShop.ShopkeeperTemper.ToString()) / 2);
			this.setBitvector(currentShop.ShopBitvector, shpBitvectors, clboxShpShopBitvector);
			this.setBitvector(currentShop.WithWhoBitvector, shpWillNotSellTo, clboxShpWillNotSellTo);

			Room myRoom;
			lboxShpShopRooms.Items.Clear();
			for(int i = 0; i < currentShop.ShopRooms.Count; i++)
			{
				if(theRooms.Count > 0)
				{
					if(theRooms.IndexOfKey(long.Parse(currentShop.ShopRooms[i])) != -1)
					{
						myRoom = (Room)theRooms[long.Parse(currentShop.ShopRooms[i])];
						lboxShpShopRooms.Items.Add(myRoom.VNum + " - " + myRoom.Name);
					}
					else
					{
						lboxShpShopRooms.Items.Add(currentShop.ShopRooms[i] + " - (Unknown Room)");
					}
				}
				else
				{
					lboxShpShopRooms.Items.Add(currentShop.ShopRooms[i] + " - (Unknown Room)");
				}
			}

			nudShpOpenTime1.Value = currentShop.OpenTime1;
			nudShpCloseTime1.Value = currentShop.CloseTime1;
			nudShpOpenTime2.Value = currentShop.OpenTime2;
			nudShpCloseTime2.Value = currentShop.CloseTime2;

			if((currentShop.OpenTime1 == 0) && (currentShop.CloseTime1 == 28) && (currentShop.OpenTime2 == 0) && (currentShop.CloseTime2 == 0))
			{
				cbShpAlwaysOpen.Checked = true;
			}
			else
			{
				cbShpAlwaysOpen.Checked = false;
			}

			if(theMobiles.Count > 0)
			{
				Mobile myMobile;
				cboxShpAreaMobile.Items.Clear();
				for(int i = 0; i < theMobiles.Count; i++)
				{
					myMobile = ((Mobile)theMobiles.GetByIndex(i));
					cboxShpAreaMobile.Items.Add(myMobile.VNum + " - " + myMobile.ShortDescription);
				}
			}
			else
			{
				cboxShpAreaMobile.Enabled = false;
			}
			nudShpMobileVNum.Value = currentShop.ShopkeeperVNum;
            
			if(theObjects.Count > 0)
			{
				cboxShpAreaItem.Items.Clear();
				for(int i = 0; i < theObjects.Count; i++)
				{
					myObject = ((Object)theObjects.GetByIndex(i));
					cboxShpAreaItem.Items.Add(myObject.VNum + " - " + myObject.ShortDescription);
				}
			}
			else
			{
				cboxShpAreaItem.Enabled = false;
			}

			if(theRooms.Count > 0)
			{
				cboxShpAreaRoom.Items.Clear();
				for(int i = 0; i < theRooms.Count; i++)
				{
					myRoom = ((Room)theRooms.GetByIndex(i));
					cboxShpAreaRoom.Items.Add(myRoom.VNum + " - " + myRoom.Name);
				}
			}
			else
			{
				cboxShpAreaRoom.Enabled = false;
			}

			this.shopEditorUnchanged();

			return true;
		}

		private bool loadZone()
		{
			nudZonNumber.Value = currentZone.Number;
			tbZonZoneName.Text = currentZone.Name;
			nudZonBottomRoom.Value = currentZone.BottomRoom;
			nudZonTopRoom.Value = currentZone.TopRoom;
			nudZonLifespan.Value = currentZone.Lifespan;
			cboxZonResetMode.SelectedIndex = (zonResetModes.IndexOf(currentZone.ResetMode.ToString()) / 2);

			ZoneCommand myCommand;
			Arg myArg;
			string myStr;
			for(int i = 0; i < currentZone.ZoneCommands.Count; i++)
			{
				myCommand = (ZoneCommand)currentZone.ZoneCommands.GetByIndex(i);
				if(myCommand.CommandType.CompareTo("*") == 0)
				{
					myStr = "* " + myCommand.Comment;
				}
				else
				{
					myStr = myCommand.CommandType;
					myStr += "\t" + myCommand.IfFlag;

					myArg = (Arg)(((CommandData)theCommands[myCommand.CommandType])).Arg[0];
					if(myArg.ArgTxt.CompareTo("unused") != 0)
					{
						myStr += "\t" + myCommand.Arg0;
					}
					myArg = (Arg)(((CommandData)theCommands[myCommand.CommandType])).Arg[1];
					if(myArg.ArgTxt.CompareTo("unused") != 0)
					{
						myStr += "\t" + myCommand.Arg1;
					}
					myArg = (Arg)(((CommandData)theCommands[myCommand.CommandType])).Arg[2];
					if(myArg.ArgTxt.CompareTo("unused") != 0)
					{
						myStr += "\t" + myCommand.Arg2;
					}
					if(myCommand.Comment.Length > 0)
					{
						myStr += "\t\t\t" + myCommand.Comment;
					}
				}
				lboxZonZoneCommands.Items.Add(myStr);
			}

			this.zoneEditorUnchanged();

			return true;
		}

		private void setNUDValue(int theValue, NumericUpDown theNUD, ComboBox theCBox)
		{
			if((valueChanging == false) && (theCBox.Enabled == true))
			{
				valueChanging = true;
				ValueData myValueData = ((ValueData)theValues[int.Parse(objTypeFlags[cboxObjTypeFlag.SelectedIndex * 2])]);
				Value valueX = ((Value)myValueData.Value[theValue]);

				int myIndex = -1;
				if(valueX.Range[0].CompareTo("<MOBILES>") == 0)
				{
					if(theMobiles.ContainsKey(decimal.ToInt64(theNUD.Value)) == true)
					{
						myIndex = theMobiles.IndexOfKey(decimal.ToInt64(theNUD.Value));
					}
				}
				else if(valueX.Range[0].CompareTo("<OBJECTS>") == 0)
				{
					if(theObjects.ContainsKey(decimal.ToInt64(theNUD.Value)) == true)
					{
						myIndex = theObjects.IndexOfKey(decimal.ToInt64(theNUD.Value));
					}
				}
				else if(valueX.Range[0].CompareTo("<ROOMS>") == 0)
				{
					if(theRooms.ContainsKey(decimal.ToInt64(theNUD.Value)) == true)
					{
						myIndex = theRooms.IndexOfKey(decimal.ToInt64(theNUD.Value));
					}
				}
				else if(valueX.Range[0].CompareTo("<SHOPS>") == 0)
				{
					if(theShops.ContainsKey(decimal.ToInt64(theNUD.Value)) == true)
					{
						myIndex = theShops.IndexOfKey(decimal.ToInt64(theNUD.Value));
					}
				}
				else
				{
					myIndex = (valueX.Range.IndexOf(decimal.ToInt32(theNUD.Value).ToString()) / 2);
				}
				theCBox.SelectedIndex = myIndex;

				this.objectEditorChanged(null, null);
				valueChanging = false;
			}
		}

		private void setBoxValue(int theValue, ComboBox theCBox, NumericUpDown theNUD)
		{
			if(valueChanging == false)
			{
				valueChanging = true;
				ValueData myValueData = ((ValueData)theValues[int.Parse(objTypeFlags[cboxObjTypeFlag.SelectedIndex * 2])]);
				Value valueX = ((Value)myValueData.Value[theValue]);

				if(valueX.Range[0].CompareTo("<MOBILES>") == 0)
				{
					theNUD.Value = ((Mobile)theMobiles.GetByIndex(theCBox.SelectedIndex)).VNum;
				}
				else if(valueX.Range[0].CompareTo("<OBJECTS>") == 0)
				{
					theNUD.Value = ((Object)theObjects.GetByIndex(theCBox.SelectedIndex)).VNum;
				}
				else if(valueX.Range[0].CompareTo("<ROOMS>") == 0)
				{
					theNUD.Value = ((Room)theRooms.GetByIndex(theCBox.SelectedIndex)).VNum;
				}
				else if(valueX.Range[0].CompareTo("<SHOPS>") == 0)
				{
					theNUD.Value = ((Shop)theShops.GetByIndex(theCBox.SelectedIndex)).VNum;
				}
				else
				{
					theNUD.Value = decimal.Parse(valueX.Range[valueX.Range.IndexOf(theCBox.SelectedItem.ToString()) - 1]);
				}

				this.objectEditorChanged(null, null);
				valueChanging = false;
			}
		}

		private void miFileExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void fMain_Load(object sender, System.EventArgs e)
		{
			disableMobileEditor();
			disableObjectEditor();
			disableRoomEditor();
			disableShopEditor();
			disableZoneEditor();

			try
			{
				this.loadConfig(File.OpenRead("Default.mudcfg"));
			}
			catch(FileNotFoundException fnfe)
			{
				MessageBox.Show(fnfe.Message + "\n\n'Default.mudcfg' not found!\nUse 'File/Load MUD Configuration' to manually configure editor.", "Error");
				sbMain.Text = "Default MUD Configuration File (Default.mudcfg) load failure.";
			}
		}

		private void fMain_Closing(object sender, CancelEventArgs e)
		{
			if(mobFileSaved == false || objFileSaved == false || wldFileSaved == false || shpFileSaved == false || zonFileSaved == false)
			{
				if(MessageBox.Show("File(s) May Not Have Been Saved; Exit Anyway?", "File(s) May Not Have Been Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					Application.Exit();
				}
				else
				{
					e.Cancel = true;
				}
			}
			else
			{
				Application.Exit();
			}
		}

		private void bMobSave_Click(object sender, System.EventArgs e)
		{
			this.saveMobile();
		}

		private void cboxMobQuickSelect_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DialogResult myResult;
			int myIndex = cboxMobQuickSelect.SelectedIndex;

			if(mobChanged == true)
			{
				myResult = MessageBox.Show("Current Mobile Has Changed; Save Changes?", "Current Mobile Has Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				if(myResult == DialogResult.Yes)
				{
					this.saveMobile();
				}
			}

			this.clearMobileEditor();
			if(myIndex != -1)
			{
				this.loadMobile(myIndex, true);
			}
		}

		private void cboxObjTypeFlag_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(currentObject != null)
			{
				string temp;
				ValueData myValueData = ((ValueData)theValues[int.Parse(objTypeFlags[cboxObjTypeFlag.SelectedIndex * 2])]);
				Value[] myValue = new Value[4];
				for(int i = 0; i < 4; i++)
				{
					myValue[i] = ((Value)myValueData.Value[i]);
				}

				GroupBox[] myGB = new GroupBox[4];
				myGB[0] = gbObjValue0;
				myGB[1] = gbObjValue1;
				myGB[2] = gbObjValue2;
				myGB[3] = gbObjValue3;
				NumericUpDown[] myNUD = new NumericUpDown[4];
				myNUD[0] = nudObjValue0;
				myNUD[1] = nudObjValue1;
				myNUD[2] = nudObjValue2;
				myNUD[3] = nudObjValue3;
				ComboBox[] myCBox = new ComboBox[4];
				myCBox[0] = cboxObjValue0;
				myCBox[1] = cboxObjValue1;
				myCBox[2] = cboxObjValue2;
				myCBox[3] = cboxObjValue3;
				long[] myValues = new long[4];
				myValues[0] = currentObject.Value0;
				myValues[1] = currentObject.Value1;
				myValues[2] = currentObject.Value2;
				myValues[3] = currentObject.Value3;

				for(int i = 0; i < 4; i++)
				{
					if(myValue[i].ValueTxt.CompareTo("unused") != 0)
					{
						myGB[i].Enabled = true;
						myGB[i].Text = myValue[i].ValueTxt;
						myNUD[i].Minimum = myValue[i].ValueMin;
						myNUD[i].Maximum = myValue[i].ValueMax;
						valueChanging = true;
						myNUD[i].Value = myValue[i].ValueMin;
						valueChanging = false;
						if(myValue[i].Range.Count > 0)
						{
							myCBox[i].Enabled = true;
							myCBox[i].Items.Clear();

							if(myValue[i].Range[0].CompareTo("<MOBILES>") == 0)
							{
								Mobile myMobile;
								for(int j = 0; j < theMobiles.Count; j++)
								{
									myMobile = ((Mobile)theMobiles.GetByIndex(j));
									myCBox[i].Items.Add(myMobile.VNum + " - " + myMobile.ShortDescription);
								}
							}
							else if(myValue[i].Range[0].CompareTo("<OBJECTS>") == 0)
							{
								Object myObject;
								for(int j = 0; j < theObjects.Count; j++)
								{
									myObject = ((Object)theObjects.GetByIndex(j));
									myCBox[i].Items.Add(myObject.VNum + " - " + myObject.ShortDescription);
								}
							}
							else if(myValue[i].Range[0].CompareTo("<ROOMS>") == 0)
							{
								Room myRoom;
								for(int j = 0; j < theRooms.Count; j++)
								{
									myRoom = ((Room)theRooms.GetByIndex(j));
									myCBox[i].Items.Add(myRoom.VNum + " - " + myRoom.Name);
								}
							}
							else if(myValue[i].Range[0].CompareTo("<SHOPS>") == 0)
							{
								Shop myShop;
								for(int j = 0; j < theShops.Count; j++)
								{
									myShop = ((Shop)theShops.GetByIndex(j));
									myCBox[i].Items.Add(myShop.VNum + " - Shopkeeper: " + ((Mobile)theMobiles[myShop.ShopkeeperVNum]).ShortDescription);
								}
							}
							else
							{
								for(int j = 1; j < myValue[i].Range.Count; j += 2)
								{
									temp = myValue[i].Range[j].Trim();
									myCBox[i].Items.Add(temp);
								}
							}
							
							if(myCBox[i].Items.Count > 0)
							{
								myCBox[i].SelectedIndex = (myValue[i].Range.IndexOf(myValues[i].ToString()) / 2);
							}
						}
						else
						{
							myCBox[i].Enabled = false;
							myCBox[i].Items.Clear();
						}
					}
					else
					{
						myGB[i].Enabled = false;
						myGB[i].Text = "Unused";
						myNUD[i].Minimum = 0;
						myNUD[i].Maximum = 0;
						myNUD[i].Value = 0;
						myCBox[i].Items.Clear();
					}
				}
			}

			this.objectEditorChanged(null, null);
		}

		private void cboxObjValue0_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.setBoxValue(0, cboxObjValue0, nudObjValue0);
		}

		private void cboxObjValue1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.setBoxValue(1, cboxObjValue1, nudObjValue1);
		}

		private void cboxObjValue2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.setBoxValue(2, cboxObjValue2, nudObjValue2);
		}

		private void cboxObjValue3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.setBoxValue(3, cboxObjValue3, nudObjValue3);
		}

		private void nudObjValue0_ValueChanged(object sender, System.EventArgs e)
		{
			this.setNUDValue(0, nudObjValue0, cboxObjValue0);
		}

		private void nudObjValue1_ValueChanged(object sender, System.EventArgs e)
		{
			this.setNUDValue(1, nudObjValue1, cboxObjValue1);
		}

		private void nudObjValue2_ValueChanged(object sender, System.EventArgs e)
		{
			this.setNUDValue(2, nudObjValue2, cboxObjValue2);
		}

		private void nudObjValue3_ValueChanged(object sender, System.EventArgs e)
		{
			this.setNUDValue(3, nudObjValue3, cboxObjValue3);
		}

		private void miFileOpenMobileFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Mobile Files (*.mob)|*.mob";
			openFileDialog.RestoreDirectory = true;

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = openFileDialog.OpenFile()) != null)
				{
					if(openMobFile(myStream) == true)
					{
						enableMobileEditor();
						miFileOpenMobileFile.Enabled = false;
						miFileClose.Enabled = true;
						miFileCloseArea.Enabled = false;
						miFileCloseMobileFile.Enabled = true;
						miFileSave.Enabled = true;
						miFileSaveArea.Enabled = false;
						miFileSaveMobileFile.Enabled = true;
						miToolsLoadMUDConfiguration.Enabled = false;
					}
					else
					{
						sbMain.Text = "Mobile File load failure.";
					}
				}
				this.mobileEditorUnchanged();

				mobFileSaved = true;

				tcEditors.SelectedTab = tpMobileEditor;
			}
		}

		private void cboxObjQuickSelect_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DialogResult myResult;
			int myIndex = cboxObjQuickSelect.SelectedIndex;

			if(objChanged == true)
			{
				myResult = MessageBox.Show("Current Object Has Changed; Save Changes?", "Current Object Has Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				if(myResult == DialogResult.Yes)
				{
					this.saveObject();
				}
			}

			this.clearObjectEditor();
			if(myIndex != -1)
			{
				loadObject(myIndex, true);
			}
		}

		private void bObjSave_Click(object sender, System.EventArgs e)
		{
			saveObject();
		}

		private void miFileOpenObjectFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Object Files (*.obj)|*.obj";
			openFileDialog.RestoreDirectory = true;

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = openFileDialog.OpenFile()) != null)
				{
					if(openObjFile(myStream) == true)
					{
						enableObjectEditor();
						miFileOpenObjectFile.Enabled = false;
						miFileClose.Enabled = true;
						miFileCloseArea.Enabled = false;
						miFileCloseObjectFile.Enabled = true;
						miFileSave.Enabled = true;
						miFileSaveArea.Enabled = false;
						miFileSaveObjectFile.Enabled = true;
						miToolsLoadMUDConfiguration.Enabled = false;
					}
					else
					{
						sbMain.Text = "Object File load failure.";
					}
				}
				this.objectEditorUnchanged();

				objFileSaved = true;

				tcEditors.SelectedTab = tpObjectEditor;
			}
		}

		private void miFileOpenWorldFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "World Files (*.wld)|*.wld";
			openFileDialog.RestoreDirectory = true;

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = openFileDialog.OpenFile()) != null)
				{
					if(openWldFile(myStream) == true)
					{
						enableRoomEditor();
						miFileOpenWorldFile.Enabled = false;
						miFileClose.Enabled = true;
						miFileCloseArea.Enabled = false;
						miFileCloseWorldFile.Enabled = true;
						miFileSave.Enabled = true;
						miFileSaveArea.Enabled = false;
						miFileSaveWorldFile.Enabled = true;
						miToolsLoadMUDConfiguration.Enabled = false;
					}
					else
					{
						sbMain.Text = "World File load failure.";
					}
				}
				this.roomEditorUnchanged();

				wldFileSaved = true;

				tcEditors.SelectedTab = tpRoomEditor;
			}
		}

		private void cboxWldQuickSelect_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DialogResult myResult;
			int myIndex = cboxWldQuickSelect.SelectedIndex;

			if(wldChanged == true)
			{
				myResult = MessageBox.Show("Current Room Has Changed; Save Changes?", "Current Room Has Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				if(myResult == DialogResult.Yes)
				{
					this.saveRoom();
				}
			}

			this.clearRoomEditor();
			if(myIndex != -1)
			{
				this.loadRoom(myIndex, true);
			}
		}

		private void saveDirectionData()
		{
			if(cbWldExitExists.Checked == true)
			{
				NumericUpDown[] myDirNUD = new NumericUpDown[6];
				myDirNUD[0] = nudWldNorth;
				myDirNUD[1] = nudWldEast;
				myDirNUD[2] = nudWldSouth;
				myDirNUD[3] = nudWldWest;
				myDirNUD[4] = nudWldUp;
				myDirNUD[5] = nudWldDown;

				DirectionData myDirectionData;
				if(currentRoom.DirectionField.ContainsKey(currentDirection))
				{
					myDirectionData = ((DirectionData)currentRoom.DirectionField[currentDirection]);
					currentRoom.DirectionField.Remove(currentDirection);
				}
				else
				{
					myDirectionData = new DirectionData(currentDirection);
				}

				myDirectionData.Exists = true;
				myDirectionData.Exit = decimal.ToInt64(myDirNUD[currentDirection].Value);
				myDirectionData.DoorFlag = int.Parse(wldDoorFlags[wldDoorFlags.IndexOf(cboxWldDoorFlag.SelectedItem.ToString()) - 1]);
				myDirectionData.Key = decimal.ToInt64(nudWldDoorKey.Value);

				currentRoom.DirectionField.Add(currentDirection, myDirectionData);
			}
		}

		private void rbWldNorth_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbWldNorth.Checked == true)
			{
				saveDirectionData();
				currentDirection = 0;
				setDirectionData();
			}
		}

		private void rbWldEast_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbWldEast.Checked == true)
			{
				saveDirectionData();
				currentDirection = 1;
				setDirectionData();
			}
		}

		private void rbWldSouth_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbWldSouth.Checked == true)
			{
				saveDirectionData();
				currentDirection = 2;
				setDirectionData();
			}
		}

		private void rbWldWest_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbWldWest.Checked == true)
			{
				saveDirectionData();
				currentDirection = 3;
				setDirectionData();
			}
		}

		private void rbWldUp_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbWldUp.Checked == true)
			{
				saveDirectionData();
				currentDirection = 4;
				setDirectionData();
			}
		}

		private void rbWldDown_CheckedChanged(object sender, System.EventArgs e)
		{
			if(rbWldDown.Checked == true)
			{
				saveDirectionData();
				currentDirection = 5;
				setDirectionData();
			}
		}

		private void miFileOpenShopFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Shop Files (*.shp)|*.shp";
			openFileDialog.RestoreDirectory = true;

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = openFileDialog.OpenFile()) != null)
				{
					if(this.openShpFile(myStream) == true)
					{
						enableShopEditor();
						miFileOpenShopFile.Enabled = false;
						miFileClose.Enabled = true;
						miFileCloseArea.Enabled = false;
						miFileCloseShopFile.Enabled = true;
						miFileSave.Enabled = true;
						miFileSaveArea.Enabled = false;
						miFileSaveShopFile.Enabled = true;
						miToolsLoadMUDConfiguration.Enabled = false;
					}
					else
					{
						sbMain.Text = "Shop File load failure.";
					}
				}
				this.shopEditorUnchanged();

				shpFileSaved = true;

				tcEditors.SelectedTab = tpShopEditor;
			}
		}

		private void cboxShpQuickSelect_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DialogResult myResult;
			int myIndex = cboxShpQuickSelect.SelectedIndex;

			if(wldChanged == true)
			{
				myResult = MessageBox.Show("Current Shop Has Changed; Save Changes?", "Current Shop Has Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				if(myResult == DialogResult.Yes)
				{
					this.saveShop();
				}
			}

			this.clearShopEditor();
			if(myIndex != -1)
			{
				this.loadShop(myIndex, true);
			}
		}

		private void bShpSave_Click(object sender, System.EventArgs e)
		{
			this.saveShop();
		}

		private void cbWldNoKey_CheckedChanged(object sender, System.EventArgs e)
		{
			if(cbWldNoKey.Checked == true)
			{
				nudWldDoorKey.Value = -1;
				nudWldDoorKey.Enabled = false;
				cboxWldAreaDoorKey.Enabled = false;
			}
			else
			{
				nudWldDoorKey.Enabled = true;
				if(cboxWldAreaDoorKey.Items.Count > 0)
				{
					cboxWldAreaDoorKey.Enabled = true;
				}
			}

			if(loadingExit == false)
			{
				this.roomEditorChanged(null, null);
			}
		}

		private void cboxShpAreaItem_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cboxShpAreaItem.SelectedIndex != - 1)
			{
				if(valueChanging == false)
				{
					valueChanging = true;
					nudShpItemVNum.Value = ((Object)theObjects.GetByIndex(cboxShpAreaItem.SelectedIndex)).VNum;
					bShpAddItem.Enabled = true;
					valueChanging = false;
				}
			}
		}

		private void cboxShpAreaRoom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cboxShpAreaRoom.SelectedIndex != -1)
			{
				if(valueChanging == false)
				{
					valueChanging = true;
					nudShpRoomVNum.Value = ((Room)theRooms.GetByIndex(cboxShpAreaRoom.SelectedIndex)).VNum;
					bShpAddRoom.Enabled = true;
					valueChanging = false;
				}
			}
		}

		private void cboxShpAreaMobile_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(valueChanging == false)
			{
				valueChanging = true;
				nudShpMobileVNum.Value = ((Mobile)theMobiles.GetByIndex(cboxShpAreaMobile.SelectedIndex)).VNum;

				this.shopEditorChanged(null, null);
				valueChanging = false;
			}
		}

		private void cbShpAlwaysOpen_CheckedChanged(object sender, System.EventArgs e)
		{
			if(cbShpAlwaysOpen.Checked == true)
			{
				nudShpOpenTime1.Value = 0;
				nudShpOpenTime1.Enabled = false;
				nudShpCloseTime1.Value = 28;
				nudShpCloseTime1.Enabled = false;
				nudShpOpenTime2.Value = 0;
				nudShpOpenTime2.Enabled = false;
				nudShpCloseTime2.Value = 0;
				nudShpCloseTime2.Enabled = false;
			}
			else
			{
				nudShpOpenTime1.Enabled = true;
				nudShpCloseTime1.Enabled = true;
				nudShpOpenTime2.Enabled = true;
				nudShpCloseTime2.Enabled = true;
			}

			this.shopEditorChanged(null, null);
		}

		private void miFileOpenZoneFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Zone Files (*.zon)|*.zon";
			openFileDialog.RestoreDirectory = true;

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = openFileDialog.OpenFile()) != null)
				{
					if(this.openZonFile(myStream) == true)
					{
						enableZoneEditor();
						miFileOpenZoneFile.Enabled = false;
						miFileClose.Enabled = true;
						miFileCloseArea.Enabled = false;
						miFileCloseZoneFile.Enabled = true;
						miFileSave.Enabled = true;
						miFileSaveArea.Enabled = false;
						miFileSaveZoneFile.Enabled = true;
						miToolsLoadMUDConfiguration.Enabled = false;
					}
					else
					{
						sbMain.Text = "Zone File load failure.";
					}
				}
				this.zoneEditorUnchanged();

				zonFileSaved = true;

				tcEditors.SelectedTab = tpZoneEditor;
			}
		}

		private void miFileOpenArea_Click(object sender, System.EventArgs e)
		{
			string myFileName, myDirectoryName, myDirectory;
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Zone Files (*.zon)|*.zon";
			openFileDialog.RestoreDirectory = true;

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myFileName = openFileDialog.FileName) != null)
				{
					myDirectoryName = Path.GetDirectoryName(myFileName);
					Directory.SetCurrentDirectory(Directory.GetParent(myDirectoryName).ToString());
					myDirectory = Directory.GetCurrentDirectory();
					myFileName = Path.GetFileNameWithoutExtension(myFileName);
					if(System.IO.File.Exists("mob/" + myFileName + ".mob"))
					{
						this.enableMobileEditor();
						if(openMobFile(System.IO.File.OpenRead("mob/" + myFileName + ".mob")) == false)
						{
							this.disableMobileEditor();
						}
					}
					if(System.IO.File.Exists("obj/" + myFileName + ".obj"))
					{
						this.enableObjectEditor();
						if(openObjFile(System.IO.File.OpenRead("obj/" + myFileName + ".obj")) == false)
						{
							this.disableObjectEditor();
						}
					}
					if(System.IO.File.Exists("wld/" + myFileName + ".wld"))
					{
						this.enableRoomEditor();
						if(openWldFile(System.IO.File.OpenRead("wld/" + myFileName + ".wld")) == false)
						{
							this.disableRoomEditor();
						}
					}
					if(System.IO.File.Exists("shp/" + myFileName + ".shp"))
					{
						enableShopEditor();
						if(openShpFile(System.IO.File.OpenRead("shp/" + myFileName + ".shp")) == false)
						{
							disableShopEditor();
						}
					}
					this.enableZoneEditor();
					if(openZonFile(System.IO.File.OpenRead("zon/" + myFileName + ".zon")) == false)
					{
						disableZoneEditor();
					}

					miFileNew.Enabled = false;
					miFileOpen.Enabled = false;
					miFileClose.Enabled = true;
					miFileCloseArea.Enabled = true;
					miFileCloseMobileFile.Enabled = false;
					miFileCloseObjectFile.Enabled = false;
					miFileCloseWorldFile.Enabled = false;
					miFileCloseShopFile.Enabled = false;
					miFileCloseZoneFile.Enabled = false;
					miFileSave.Enabled = true;
					miFileSaveArea.Enabled = true;
					miFileSaveMobileFile.Enabled = false;
					miFileSaveObjectFile.Enabled = false;
					miFileSaveWorldFile.Enabled = false;
					miFileSaveShopFile.Enabled = false;
					miFileSaveZoneFile.Enabled = false;
					miToolsLoadMUDConfiguration.Enabled = false;

					this.mobileEditorUnchanged();
					this.objectEditorUnchanged();
					this.roomEditorUnchanged();
					this.shopEditorUnchanged();
					this.zoneEditorUnchanged();

					mobFileSaved = true;
					objFileSaved = true;
					wldFileSaved = true;
					shpFileSaved = true;
					zonFileSaved = true;
				}
				else
				{
						sbMain.Text = "Area load failure.";
				}
			}
		}

		private void lboxZonZoneCommands_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lboxZonZoneCommands.SelectedIndex != -1)
			{
				bZonRemove.Enabled = true;
			}
			else
			{
				bZonRemove.Enabled = false;
			}
		}

		private void lboxZonZoneCommands_DoubleClick(object sender, System.EventArgs e)
		{
			if(lboxZonZoneCommands.SelectedIndex != -1)
			{
				ZoneCommand myCommand = ((ZoneCommand)currentZone.ZoneCommands.GetByIndex(lboxZonZoneCommands.SelectedIndex));
				Arg myArg;

				cboxZonCommandType.SelectedIndex = (zonCommandTypes.IndexOf(myCommand.CommandType) / 2);

				setCommandTypeData();

				tbZonComment.Text = myCommand.Comment;
				if(myCommand.IfFlag == 1)
				{
					cbZonIfFlag.Checked = true;
				}
				else
				{
					cbZonIfFlag.Checked = false;
				}
				if(nudZonArg0.Minimum >= 0)
				{
					nudZonArg0.Value = nudZonArg0.Minimum;
				}
				else
				{
					nudZonArg0.Value = -1;
				}
				if(nudZonArg1.Minimum >= 0)
				{
					nudZonArg1.Value = nudZonArg1.Minimum;
				}
				else
				{
					nudZonArg1.Value = -1;
				}
				if(nudZonArg2.Minimum >= 0)
				{
					nudZonArg2.Value = nudZonArg2.Minimum;
				}
				else
				{
					nudZonArg2.Value = -1;
				}
				if(myCommand.CommandType.CompareTo("*") != 0)
				{
					myArg = (Arg)(((CommandData)theCommands[myCommand.CommandType])).Arg[0];
					if(myArg.ArgTxt.CompareTo("unused") != 0)
					{
						nudZonArg0.Value = myCommand.Arg0;
					}
					myArg = (Arg)(((CommandData)theCommands[myCommand.CommandType])).Arg[1];
					if(myArg.ArgTxt.CompareTo("unused") != 0)
					{
						nudZonArg1.Value = myCommand.Arg1;
					}
					myArg = (Arg)(((CommandData)theCommands[myCommand.CommandType])).Arg[2];
					if(myArg.ArgTxt.CompareTo("unused") != 0)
					{
						nudZonArg2.Value = myCommand.Arg2;
					}
				}
			}
		}

		private void setCommandTypeData()
		{
			if(cboxZonCommandType.SelectedIndex != -1)
			{
				string myCommandType;

				if(cboxZonCommandType.SelectedIndex == (cboxZonCommandType.Items.Count - 1))
				{
					myCommandType = "*";
				}
				else
				{
					myCommandType = zonCommandTypes[cboxZonCommandType.SelectedIndex * 2];
				}

				if(myCommandType.CompareTo("*") != 0)
				{
					Arg myArg;

					GroupBox[] myGB = new GroupBox[3];
					myGB[0] = gbZonArg0;
					myGB[1] = gbZonArg1;
					myGB[2] = gbZonArg2;
					NumericUpDown[] myNUD = new NumericUpDown[3];
					myNUD[0] = nudZonArg0;
					myNUD[1] = nudZonArg1;
					myNUD[2] = nudZonArg2;
					ComboBox[] myCBox = new ComboBox[3];
					myCBox[0] = cboxZonAreaArg0;
					myCBox[1] = cboxZonAreaArg1;
					myCBox[2] = cboxZonAreaArg2;

					cbZonIfFlag.Enabled = true;

					gbZonArg0.Enabled = false;
					gbZonArg1.Enabled = false;
					gbZonArg2.Enabled = false;

					for(int i = 0; i < 3; i++)
					{
						myArg = ((Arg)((CommandData)theCommands[myCommandType]).Arg[i]);
						myGB[i].Text = myArg.ArgTxt;
						myCBox[i].Items.Clear();
						if(myArg.ArgTxt.CompareTo("unused") != 0)
						{
							myNUD[i].Minimum = myArg.ArgMin;
							myNUD[i].Maximum = myArg.ArgMax;
							if(myNUD[i].Minimum >= 0)
							{
								myNUD[i].Value = myNUD[i].Minimum;
							}
							else
							{
								myNUD[i].Value = 0;
							}
							myGB[i].Enabled = true;
							if(myArg.Range.Count > 0)
							{
								if(myArg.Range[0].CompareTo("<MOBILES>") == 0)
								{
									if(theMobiles.Count > 0)
									{
										Mobile myMobile;
										for(int j = 0; j < theMobiles.Count; j++)
										{
											myMobile = ((Mobile)theMobiles.GetByIndex(j));
											myCBox[i].Items.Add(myMobile.VNum + " - " + myMobile.ShortDescription);
										}
										myCBox[i].Enabled = true;
									}
									else
									{
										myCBox[i].Enabled = false;
									}
								}
								else if(myArg.Range[0].CompareTo("<OBJECTS>") == 0)
								{
									if(theObjects.Count > 0)
									{
										Object myObject;
										for(int j = 0; j < theObjects.Count; j++)
										{
											myObject = ((Object)theObjects.GetByIndex(j));
											myCBox[i].Items.Add(myObject.VNum + " - " + myObject.ShortDescription);
										}
										myCBox[i].Enabled = true;
									}
									else
									{
										myCBox[i].Enabled = false;
									}
								}
								else if(myArg.Range[0].CompareTo("<ROOMS>") == 0)
								{
									if(theRooms.Count > 0)
									{
										Room myRoom;
										for(int j = 0; j < theRooms.Count; j++)
										{
											myRoom = ((Room)theRooms.GetByIndex(j));
											myCBox[i].Items.Add(myRoom.VNum + " - " + myRoom.Name);
										}
										myCBox[i].Enabled = true;
									}
									else
									{
										myCBox[i].Enabled = false;
									}
								}
								else if(myArg.Range[0].CompareTo("<SHOPS>") == 0)
								{
									if(theShops.Count > 0)
									{
										Shop myShop;
										for(int j = 0; j < theShops.Count; j++)
										{
											myShop = ((Shop)theShops.GetByIndex(j));
											myCBox[i].Items.Add(myShop.VNum + " - Shopkeeper: " + ((Mobile)theMobiles[myShop.ShopkeeperVNum]).ShortDescription);
										}
										myCBox[i].Enabled = true;
									}
									else
									{
										myCBox[i].Enabled = false;
									}
								}
								else
								{
									for(int j = 1; j < myArg.Range.Count; j += 2)
									{
										myCBox[i].Items.Add(myArg.Range[j]);
										myCBox[i].Enabled = true;
									}
								}
							}
							else
							{
								myCBox[i].Enabled = false;
								myNUD[i].Minimum = myArg.ArgMin;
								myNUD[i].Maximum = myArg.ArgMax;
								if(myNUD[i].Minimum >= 0)
								{
									myNUD[i].Value = myNUD[i].Minimum;
								}
								else
								{
									myNUD[i].Value = 0;
								}
							}
						}
					}
				}
				else
				{
					cbZonIfFlag.Enabled = false;
					gbZonArg0.Text = "Unused";
					gbZonArg0.Enabled = false;
					nudZonArg0.Minimum = -1;
					nudZonArg0.Maximum = -1;
					nudZonArg0.Value = -1;
					cboxZonAreaArg0.Items.Clear();
					cboxZonAreaArg0.Enabled = false;
					gbZonArg1.Text = "Unused";
					gbZonArg1.Enabled = false;
					nudZonArg1.Minimum = -1;
					nudZonArg1.Maximum = -1;
					nudZonArg1.Value = -1;
					cboxZonAreaArg1.Items.Clear();
					cboxZonAreaArg1.Enabled = false;
					gbZonArg2.Text = "Unused";
					gbZonArg2.Enabled = false;
					nudZonArg2.Minimum = -1;
					nudZonArg2.Maximum = -1;
					nudZonArg2.Value = -1;
					cboxZonAreaArg2.Items.Clear();
					cboxZonAreaArg2.Enabled = false;
				}
			}
		}

		private void cboxZonCommandType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			setCommandTypeData();
		}

		private void bZonCommandDown_Click(object sender, System.EventArgs e)
		{
			if(lboxZonZoneCommands.SelectedIndex < (lboxZonZoneCommands.Items.Count - 1))
			{
				Zone myZone = currentZone;
				int myIndex = lboxZonZoneCommands.SelectedIndex;
				object myItem = lboxZonZoneCommands.SelectedItem;
				object myObject = lboxZonZoneCommands.Items[myIndex + 1];
				ZoneCommand myCommand = ((ZoneCommand)myZone.ZoneCommands.GetByIndex(myIndex));

				myZone.ZoneCommands.SetByIndex(myIndex, ((ZoneCommand)myZone.ZoneCommands.GetByIndex(myIndex + 1)));
				myZone.ZoneCommands.SetByIndex((myIndex + 1), myCommand);
				lboxZonZoneCommands.Items[myIndex + 1] = myItem;
				lboxZonZoneCommands.Items[myIndex] = myObject;
				lboxZonZoneCommands.SelectedIndex = (myIndex + 1);

				this.zoneEditorChanged(null, null);
			}
		}

		private void bZonCommandUp_Click(object sender, System.EventArgs e)
		{
			if(lboxZonZoneCommands.SelectedIndex > 0)
			{
				Zone myZone = currentZone;
				int myIndex = lboxZonZoneCommands.SelectedIndex;
				object myItem = lboxZonZoneCommands.SelectedItem;
				object myObject = lboxZonZoneCommands.Items[myIndex - 1];
				ZoneCommand myCommand = ((ZoneCommand)myZone.ZoneCommands.GetByIndex(myIndex));

				myZone.ZoneCommands.SetByIndex(myIndex, ((ZoneCommand)myZone.ZoneCommands.GetByIndex(myIndex - 1)));
				myZone.ZoneCommands.SetByIndex((myIndex - 1), myCommand);
				lboxZonZoneCommands.Items[myIndex - 1] = myItem;
				lboxZonZoneCommands.Items[myIndex] = myObject;
				lboxZonZoneCommands.SelectedIndex = (myIndex - 1);

				this.zoneEditorChanged(null, null);
			}
		}

		private void bZonAdd_Click(object sender, System.EventArgs e)
		{
			int myIndex = cboxZonCommandType.SelectedIndex;
			ZoneCommand myCommand = new ZoneCommand();
			string myStr;

			myCommand.CommandType = zonCommandTypes[myIndex * 2];
			if(cbZonIfFlag.Checked == true)
			{
				myCommand.IfFlag = 1;
			}
			else
			{
				myCommand.IfFlag = 0;
			}
			myCommand.Arg0 = decimal.ToInt64(nudZonArg0.Value);
			myCommand.Arg1 = decimal.ToInt64(nudZonArg1.Value);
			if(nudZonArg2.Enabled == true)
			{
				myCommand.Arg2 = decimal.ToInt64(nudZonArg2.Value);
			}
			else
			{
				myCommand.Arg2 = -1;
			}

			if(tbZonComment.Text.Length > 0)
			{
				myCommand.Comment = tbZonComment.Text;
			}
			else if(autoGenComment == true)
			{
				if(myCommand.CommandType.CompareTo("M") == 0)
				{
					myCommand.Comment = "Load Mobile [" + myCommand.Arg0.ToString() + "]";
					if(theMobiles.ContainsKey(myCommand.Arg0) == true)
					{
						myCommand.Comment += " " + ((Mobile)theMobiles[myCommand.Arg0]).ShortDescription;
					}
					myCommand.Comment += " in Room [" + myCommand.Arg2.ToString() + "]";
					if(theRooms.ContainsKey(myCommand.Arg2) == true)
					{
						myCommand.Comment += " " + ((Room)theRooms[myCommand.Arg2]).Name;
					}
				}
				else if(myCommand.CommandType.CompareTo("O") == 0)
				{
					myCommand.Comment = "Load Object [" + myCommand.Arg0.ToString() + "]";
					if(theObjects.ContainsKey(myCommand.Arg0) == true)
					{
						myCommand.Comment += " " + ((Object)theObjects[myCommand.Arg0]).ShortDescription;
					}
					myCommand.Comment += " in Room [" + myCommand.Arg2.ToString() + "]";
					if(theRooms.ContainsKey(myCommand.Arg2) == true)
					{
						myCommand.Comment += " " + ((Room)theRooms[myCommand.Arg2]).Name;
					}
				}
				else if(myCommand.CommandType.CompareTo("G") == 0)
				{
					myCommand.Comment = "Give Object [" + myCommand.Arg0.ToString() + "]";
					if(theObjects.ContainsKey(myCommand.Arg0) == true)
					{
						myCommand.Comment += " " + ((Object)theObjects[myCommand.Arg0]).ShortDescription;
					}
					myCommand.Comment += " to Previous Mobile";
				}
				else if(myCommand.CommandType.CompareTo("E") == 0)
				{
					myCommand.Comment = "Equip Object [" + myCommand.Arg0.ToString() + "]";
					if(theObjects.ContainsKey(myCommand.Arg0) == true)
					{
						myCommand.Comment += " " + ((Object)theObjects[myCommand.Arg0]).ShortDescription;
					}
					myCommand.Comment += " to Previous Mobile at Wear Location [" + ((Arg)((CommandData)theCommands["E"]).Arg[2]).Range[((Arg)((CommandData)theCommands["E"]).Arg[2]).Range.IndexOf(myCommand.Arg2.ToString()) + 1] + "]";
				}
				else if(myCommand.CommandType.CompareTo("P") == 0)
				{
					myCommand.Comment = "Put Object1 [" + myCommand.Arg0.ToString() + "]";
					if(theObjects.ContainsKey(myCommand.Arg0) == true)
					{
						myCommand.Comment += " " + ((Object)theObjects[myCommand.Arg0]).ShortDescription;
					}
					myCommand.Comment += " into Object2 [" + myCommand.Arg0.ToString() + "]";
					if(theObjects.ContainsKey(myCommand.Arg2) == true)
					{
						myCommand.Comment += " " + ((Object)theObjects[myCommand.Arg2]).ShortDescription;
					}
				}
				else if(myCommand.CommandType.CompareTo("D") == 0)
				{
					myCommand.Comment = "Set Door [" + ((Arg)((CommandData)theCommands["D"]).Arg[1]).Range[((Arg)((CommandData)theCommands["D"]).Arg[1]).Range.IndexOf(myCommand.Arg1.ToString()) + 1] + "] in Room [" + myCommand.Arg0.ToString() + "]";
					if(theRooms.ContainsKey(myCommand.Arg1) == true)
					{
						myCommand.Comment += " " + ((Room)theRooms[myCommand.Arg1]).Name;
					}
					myCommand.Comment += " to [" + ((Arg)((CommandData)theCommands["D"]).Arg[2]).Range[((Arg)((CommandData)theCommands["D"]).Arg[2]).Range.IndexOf(myCommand.Arg2.ToString()) + 1] + "]";
				}
				else if(myCommand.CommandType.CompareTo("R") == 0)
				{
					myCommand.Comment = "Remove All Instances of Object [" + myCommand.Arg0.ToString() + "]";
					if(theObjects.ContainsKey(myCommand.Arg0) == true)
					{
						myCommand.Comment += " " + ((Object)theObjects[myCommand.Arg0]).ShortDescription;
					}
					myCommand.Comment += " in Room [" + myCommand.Arg0.ToString() + "]";
					if(theRooms.ContainsKey(myCommand.Arg2) == true)
					{
						myCommand.Comment += " " + ((Room)theRooms[myCommand.Arg2]).Name;
					}
				}
			}

			if(currentZone.ZoneCommands.Count > 0)
			{
				currentZone.ZoneCommands.Add((int.Parse(currentZone.ZoneCommands.GetKey(currentZone.ZoneCommands.Count - 1).ToString()) + 1), myCommand);
			}
			else
			{
				currentZone.ZoneCommands.Add(0, myCommand);
			}

			if(myCommand.CommandType.CompareTo("*") != 0)
			{
				myStr = myCommand.CommandType + "\t" + myCommand.IfFlag.ToString() + "\t" + myCommand.Arg0.ToString() + "\t" + myCommand.Arg1.ToString() + "\t" + myCommand.Arg2.ToString();

				if(myCommand.Comment != null)
				{
					myStr += "\t\t\t" + myCommand.Comment;
				}
			}
			else
			{
				myStr = "* " + myCommand.Comment;
			}

			lboxZonZoneCommands.Items.Add(myStr);
			lboxZonZoneCommands.SelectedIndex = lboxZonZoneCommands.Items.Count - 1;

			tbZonComment.Clear();

			this.zoneEditorChanged(null, null);
		}

		private void bZonRemove_Click(object sender, System.EventArgs e)
		{
			if(lboxZonZoneCommands.SelectedIndex != -1)
			{			
				currentZone.ZoneCommands.RemoveAt(lboxZonZoneCommands.SelectedIndex);
				lboxZonZoneCommands.Items.RemoveAt(lboxZonZoneCommands.SelectedIndex);

				zonFileSaved = false;
			}
		}

		private void miFileSaveMobileFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Mobile Files (*.mob)|*.mob";
			saveFileDialog.RestoreDirectory = true;

			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = saveFileDialog.OpenFile())!= null)
				{
					if(this.writeMobFile(new StreamWriter(myStream)) == true)
					{
						sbMain.Text = "Wrote Mobile File.";
					}
					else
					{
						sbMain.Text = "Mobile File save failure.";
					}
				}
			}			
		}

		private bool writeMobFile(StreamWriter myStreamWriter)
		{
			Mobile myMobile;

			try
			{
				for(int i = 0; i < theMobiles.Count; i++)
				{
					myMobile = ((Mobile)theMobiles.GetByIndex(i));

					myStreamWriter.WriteLine("#" + myMobile.VNum.ToString());
					myStreamWriter.WriteLine(myMobile.AliasList + "~");
					myStreamWriter.WriteLine(myMobile.ShortDescription + "~");
					myStreamWriter.WriteLine(myMobile.LongDescription);
					myStreamWriter.WriteLine("~");
					myStreamWriter.WriteLine(myMobile.DetailedDescription);
					myStreamWriter.WriteLine("~");
					if(myMobile.ESpecs.Count > 0)
					{
						myMobile.TypeFlag = "E";
					}
					else
					{
						myMobile.TypeFlag = "S";
					}
					myStreamWriter.WriteLine(myMobile.ActionBitvector + " " + myMobile.AffectionBitvector + " " + myMobile.Alignment.ToString() + " " + myMobile.TypeFlag);
					myStreamWriter.WriteLine(myMobile.Level.ToString() + " " + myMobile.Thaco.ToString() + " " + myMobile.ArmorClass.ToString() + " " + myMobile.HPNum.ToString() + "d" + myMobile.HPDie.ToString() + "+" + myMobile.HPAdd.ToString() + " " + myMobile.BHNum.ToString() + "d" + myMobile.BHDie.ToString() + "+" + myMobile.BHAdd.ToString());
					myStreamWriter.WriteLine(myMobile.Gold.ToString() + " " + myMobile.Experience.ToString());
					myStreamWriter.WriteLine(myMobile.LoadPosition.ToString() + " " + myMobile.DefaultPosition.ToString() + " " + myMobile.Sex.ToString());
					if(myMobile.TypeFlag.CompareTo("E") == 0)
					{
						for(int j = 0; j < myMobile.ESpecs.Count; j++)
						{
							myStreamWriter.WriteLine(myMobile.ESpecs.GetKey(j) + ": " + myMobile.ESpecs.GetByIndex(j));
						}
						myStreamWriter.WriteLine("E");
					}
				}
				myStreamWriter.Write("$");

				myStreamWriter.Close();

				this.mobileEditorUnchanged();
				mobFileSaved = true;

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Writing Mobile File";
				MessageBox.Show(e.Message + "\n\nError Writing Mobile File!", "Error");

				return false;
			}
		}

		private void miFileSaveObjectFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Object Files (*.obj)|*.obj";
			saveFileDialog.RestoreDirectory = true;

			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = saveFileDialog.OpenFile())!= null)
				{
					if(this.writeObjFile(new StreamWriter(myStream)) == true)
					{
						sbMain.Text = "Wrote Object File.";
					}
					else
					{
						sbMain.Text = "Object File save failure.";
					}
				}
			}
		}

		private bool writeObjFile(StreamWriter myStreamWriter)
		{
			Object myObject;

			try
			{
				for(int i = 0; i < theObjects.Count; i++)
				{
					myObject = ((Object)theObjects.GetByIndex(i));

					myStreamWriter.WriteLine("#" + myObject.VNum.ToString());
					myStreamWriter.WriteLine(myObject.AliasList + "~");
					myStreamWriter.WriteLine(myObject.ShortDescription + "~");
					myStreamWriter.WriteLine(myObject.LongDescription + "~");
					myStreamWriter.WriteLine(myObject.ActionDescription + "~");
					myStreamWriter.WriteLine(myObject.TypeFlag.ToString() + " " + myObject.EffectsBitvector + " " + myObject.WearBitvector);
					myStreamWriter.WriteLine(myObject.Value0.ToString() + " " + myObject.Value1.ToString() + " " + myObject.Value2.ToString() + " " + myObject.Value3.ToString());
					myStreamWriter.WriteLine(myObject.Weight.ToString() + " " + myObject.Cost.ToString() + " " + myObject.RentPerDay.ToString());
					if(myObject.ExtraDescriptions.Count > 0)
					{
						ExtraDescription myDescription;
						for(int j = 0; j < myObject.ExtraDescriptions.Count; j++)
						{
							myDescription = ((ExtraDescription)myObject.ExtraDescriptions.GetByIndex(j));

							myStreamWriter.WriteLine("E");
							myStreamWriter.WriteLine(myDescription.Keywords + "~");
							myStreamWriter.WriteLine(myDescription.Description);
							myStreamWriter.WriteLine("~");
						}
					}
					if(myObject.Affects.Count > 0)
					{
						Affect myAffect;
						for(int j = 0; j < myObject.Affects.Count; j++)
						{
							myAffect = ((Affect)myObject.Affects.GetByIndex(j));

							myStreamWriter.WriteLine("A");
							myStreamWriter.WriteLine(myAffect.Location.ToString() + " " + myAffect.Value.ToString());
						}
					}
				}
				myStreamWriter.Write("$");

				myStreamWriter.Close();

				this.objectEditorUnchanged();
				objFileSaved = true;

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Writing Object File";
				MessageBox.Show(e.Message + "\n\nError Writing Object File!", "Error");

				return false;
			}
		}

		private bool writeWldFile(StreamWriter myStreamWriter)
		{
			Room myRoom;

			try
			{
				for(int i = 0; i < theRooms.Count; i++)
				{
					myRoom = ((Room)theRooms.GetByIndex(i));

					myStreamWriter.WriteLine("#" + myRoom.VNum.ToString());
					myStreamWriter.WriteLine(myRoom.Name + "~");
					myStreamWriter.WriteLine(myRoom.Description);
					myStreamWriter.WriteLine("~");
					myStreamWriter.WriteLine(myRoom.Zone.ToString() + " " + myRoom.RoomBitvector + " " + myRoom.SectorType.ToString());
					if(myRoom.DirectionField.Count > 0)
					{
						DirectionData myDirection;
						for(int j = 0; j < myRoom.DirectionField.Count; j++)
						{
							myDirection = ((DirectionData)myRoom.DirectionField.GetByIndex(j));

							myStreamWriter.WriteLine("D" + myDirection.Direction.ToString());
							myStreamWriter.WriteLine(myDirection.Description);
							myStreamWriter.WriteLine("~");
							myStreamWriter.WriteLine(myDirection.Keywords + "~");
							myStreamWriter.WriteLine(myDirection.DoorFlag.ToString() + " " + myDirection.Key.ToString() + " " + myDirection.Exit.ToString());
						}
					}					
					if(myRoom.ExtraDescriptions.Count > 0)
					{
						ExtraDescription myDescription;
						for(int j = 0; j < myRoom.ExtraDescriptions.Count; j++)
						{
							myDescription = ((ExtraDescription)myRoom.ExtraDescriptions.GetByIndex(j));

							myStreamWriter.WriteLine("E");
							myStreamWriter.WriteLine(myDescription.Keywords + "~");
							myStreamWriter.WriteLine(myDescription.Description);
							myStreamWriter.WriteLine("~");
						}
					}
					myStreamWriter.WriteLine("S");
				}
				myStreamWriter.Write("$");

				myStreamWriter.Close();

				this.roomEditorUnchanged();
				wldFileSaved = true;

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Writing Object File";
				MessageBox.Show(e.Message + "\n\nError Writing Object File!", "Error");

				return false;
			}
		}

		private void miFileSaveWorldFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "World Files (*.wld)|*.wld";
			saveFileDialog.RestoreDirectory = true;

			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = saveFileDialog.OpenFile()) != null)
				{
					if(this.writeWldFile(new StreamWriter(myStream)) == true)
					{
						sbMain.Text = "Wrote World File.";
					}
					else
					{
						sbMain.Text = "World File save failure.";
					}
				}
			}
		}

		private bool writeShpFile(StreamWriter myStreamWriter)
		{
			Shop myShop;

			try
			{
				myStreamWriter.WriteLine("CircleMUD v3.0 Shop File~");
				for(int i = 0; i < theShops.Count; i++)
				{
					myShop = ((Shop)theShops.GetByIndex(i));

					myStreamWriter.WriteLine("#" + myShop.VNum.ToString() + "~");
					for(int j = 0; j < myShop.ShopItems.Count; j++)
					{
						myStreamWriter.WriteLine(myShop.ShopItems[j]);
					}
					myStreamWriter.WriteLine("-1");
					
					if((myShop.SellProfit % 1) == 0) myStreamWriter.WriteLine(myShop.SellProfit.ToString() + ".0");
					else myStreamWriter.WriteLine(myShop.SellProfit.ToString());
					if((myShop.BuyProfit % 1) == 0) myStreamWriter.WriteLine(myShop.BuyProfit.ToString() + ".0");
					else myStreamWriter.WriteLine(myShop.BuyProfit.ToString());

					for(int j = 0; j < myShop.BuyTypes.Count; j++)
					{
						myStreamWriter.WriteLine(myShop.BuyTypes[j]);
					}
					myStreamWriter.WriteLine("-1");

					myStreamWriter.WriteLine("%s " + myShop.MessageBuyItemDoesNotExist + "~");
					myStreamWriter.WriteLine("%s " + myShop.MessageSellItemDoesNotExist + "~");
					myStreamWriter.WriteLine("%s " + myShop.MessageShopDoesNotBuyItem + "~");
					myStreamWriter.WriteLine("%s " + myShop.MessageShopCanNotAffordItem + "~");
					myStreamWriter.WriteLine("%s " + myShop.MessagePlayerCanNotAffordItem + "~");
					myStreamWriter.WriteLine("%s " + myShop.MessageBuySuccess + "~");
					myStreamWriter.WriteLine("%s " + myShop.MessageSellSuccess + "~");

					myStreamWriter.WriteLine(myShop.ShopkeeperTemper.ToString());
					myStreamWriter.WriteLine(myShop.ShopBitvector);
					myStreamWriter.WriteLine(myShop.ShopkeeperVNum.ToString());
					myStreamWriter.WriteLine(myShop.WithWhoBitvector);

					for(int j = 0; j < myShop.ShopRooms.Count; j++)
					{
						myStreamWriter.WriteLine(myShop.ShopRooms[j]);
					}
					myStreamWriter.WriteLine("-1");

					myStreamWriter.WriteLine(myShop.OpenTime1.ToString());
					myStreamWriter.WriteLine(myShop.CloseTime1.ToString());
					myStreamWriter.WriteLine(myShop.OpenTime2.ToString());
					myStreamWriter.WriteLine(myShop.CloseTime2.ToString());
				}
				myStreamWriter.Write("$~");

				myStreamWriter.Close();

				this.shopEditorUnchanged();
				shpFileSaved = true;

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Writing Shop File";
				MessageBox.Show(e.Message + "\n\nError Writing Shop File!", "Error");

				return false;
			}
		}

		private void miFileSaveShopFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Shop Files (*.shp)|*.shp";
			saveFileDialog.RestoreDirectory = true;

			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = saveFileDialog.OpenFile())!= null)
				{
					if(this.writeShpFile(new StreamWriter(myStream)) == true)
					{
						sbMain.Text = "Wrote Shop File.";
					}
					else
					{
						sbMain.Text = "Shop File save failure.";
					}
				}
			}
		}

		private void bShpAddItem_Click(object sender, System.EventArgs e)
		{
			long myVNum = decimal.ToInt64(nudShpItemVNum.Value);

			if(myVNum > 0)
			{
				if(currentShop.ShopItems.Contains(myVNum.ToString()) != true)
				{
					nudShpItemVNum.Value = 0;
					currentShop.ShopItems.Add(myVNum.ToString());
					if(theObjects.Count > 0)
					{
						if(theObjects.IndexOfKey(myVNum) != -1)
						{
							lboxShpShopItems.Items.Add(myVNum + " - " + ((Object)theObjects[myVNum]).ShortDescription);
						}
						else
						{
							lboxShpShopItems.Items.Add(myVNum + " - (Unknown Object)");
						}
					}
					else
					{
						lboxShpShopItems.Items.Add(myVNum + " - (Unknown Object)");
					}

					this.shopEditorChanged(null, null);
				}
				else
				{
					MessageBox.Show("Shop Already Sells That Object");
				}

				bShpAddItem.Enabled = false;
			}
		}

		private void bShpRemoveItem_Click(object sender, System.EventArgs e)
		{
			if(lboxShpShopItems.SelectedIndex != -1)
			{
				currentShop.ShopItems.RemoveAt(lboxShpShopItems.SelectedIndex);
				lboxShpShopItems.Items.RemoveAt(lboxShpShopItems.SelectedIndex);

				this.shopEditorChanged(null, null);

				bShpRemoveItem.Enabled = false;
			}
		}

		private void bShpAddRoom_Click(object sender, System.EventArgs e)
		{
			long myVNum = decimal.ToInt64(nudShpRoomVNum.Value);
            
			if(myVNum > 0)
			{
				if(currentShop.ShopRooms.Contains(myVNum.ToString()) != true)
				{
					nudShpRoomVNum.Value = 0;
					currentShop.ShopRooms.Add(myVNum.ToString());
					if(theRooms.Count > 0)
					{
						if(theRooms.IndexOfKey(myVNum) != -1)
						{
							lboxShpShopRooms.Items.Add(myVNum + " - " + ((Room)theRooms[myVNum]).Name);
						}
						else
						{
							lboxShpShopRooms.Items.Add(myVNum + " - (Unknown Room)");
						}
					}
					else
					{
						lboxShpShopRooms.Items.Add(myVNum + " - (Unknown Room)");
					}

					this.shopEditorChanged(null, null);
				}
				else
				{
					MessageBox.Show("Shop Already Exists in That Room");
				}

				bShpAddRoom.Enabled = false;
			}
		}

		private void bShpRemoveRoom_Click(object sender, System.EventArgs e)
		{
			if(lboxShpShopRooms.SelectedIndex != -1)
			{
				currentShop.ShopRooms.RemoveAt(lboxShpShopRooms.SelectedIndex);
				lboxShpShopRooms.Items.RemoveAt(lboxShpShopRooms.SelectedIndex);

				this.shopEditorChanged(null, null);

				bShpRemoveRoom.Enabled = false;
			}
		}

		private void lboxShpShopRooms_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lboxShpShopRooms.SelectedIndex != -1)
			{
				bShpRemoveRoom.Enabled = true;
			}
			else
			{
				bShpRemoveRoom.Enabled = false;
			}
		}

		private void lboxShpShopItems_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lboxShpShopItems.SelectedIndex != -1)
			{
				bShpRemoveItem.Enabled = true;
			}
			else
			{
				bShpRemoveItem.Enabled = false;
			}
		}

		private void nudShpRoomVNum_ValueChanged(object sender, System.EventArgs e)
		{
			if(valueChanging == false)
			{
				valueChanging = true;
				if(nudShpRoomVNum.Value > 0)
				{
					bShpAddRoom.Enabled = true;
				}
				else
				{
					bShpAddRoom.Enabled = false;
				}
				cboxShpAreaRoom.SelectedIndex = theRooms.IndexOfKey(decimal.ToInt64(nudShpRoomVNum.Value));
				valueChanging = false;
			}
		}

		private void nudShpItemVNum_ValueChanged(object sender, System.EventArgs e)
		{
			if(valueChanging == false)
			{
				valueChanging = true;
				if(nudShpItemVNum.Value > 0)
				{
					bShpAddItem.Enabled = true;
				}
				else
				{
					bShpAddItem.Enabled = false;
				}
				cboxShpAreaItem.SelectedIndex = theObjects.IndexOfKey(decimal.ToInt64(nudShpItemVNum.Value));
				valueChanging = false;
			}
		}

		private void nudShpMobileVNum_ValueChanged(object sender, System.EventArgs e)
		{
			if(valueChanging == false)
			{
				valueChanging = true;
				cboxShpAreaMobile.SelectedIndex = theMobiles.IndexOfKey(decimal.ToInt64(nudShpMobileVNum.Value));

				this.shopEditorChanged(null, null);
				valueChanging = false;
			}
		}

		private bool writeZonFile(StreamWriter myStreamWriter)
		{
			try
			{
				myStreamWriter.WriteLine("#" + currentZone.Number);
				myStreamWriter.WriteLine(currentZone.Name + "~");
				myStreamWriter.WriteLine(currentZone.BottomRoom.ToString() + " " + currentZone.TopRoom.ToString() + " " + currentZone.Lifespan.ToString() + " " + currentZone.ResetMode.ToString());

				ZoneCommand myCommand;
				Arg myArg;
				string myStr;
				for(int i = 0; i < currentZone.ZoneCommands.Count; i++)
				{
					myCommand = ((ZoneCommand)currentZone.ZoneCommands.GetByIndex(i));

					if((myCommand.CommandType.CompareTo("*") == 0))
					{
						myStr = "* " + myCommand.Comment;
					}
					else
					{
						myStr = myCommand.CommandType + " " + myCommand.IfFlag.ToString();

						myArg = (Arg)(((CommandData)theCommands[myCommand.CommandType])).Arg[0];
						if(myArg.ArgTxt.CompareTo("unused") != 0)
						{
							myStr += " " + myCommand.Arg0.ToString();
						}
						myArg = (Arg)(((CommandData)theCommands[myCommand.CommandType])).Arg[1];
						if(myArg.ArgTxt.CompareTo("unused") != 0)
						{
							myStr += " " + myCommand.Arg1.ToString();
						}
						myArg = (Arg)(((CommandData)theCommands[myCommand.CommandType])).Arg[2];
						if(myArg.ArgTxt.CompareTo("unused") != 0)
						{
							myStr += " " + myCommand.Arg2.ToString();
						}
						if(myCommand.Comment.Length > 0)
						{
							myStr += "\t\t\t" + myCommand.Comment;
						}
					}
					myStreamWriter.WriteLine(myStr);
				}
				myStreamWriter.WriteLine("S");
				myStreamWriter.Write("$");

				myStreamWriter.Close();

				this.zoneEditorUnchanged();
				zonFileSaved = true;

				return true;
			}
			catch(Exception e)
			{
				sbMain.Text = "Error Writing Zone File";
				MessageBox.Show(e.Message + "\n\nError Writing Zone File!", "Error");

				return false;
			}
		}

		private void miFileSaveZoneFile_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Zone Files (*.zon)|*.zon";
			saveFileDialog.RestoreDirectory = true;

			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = saveFileDialog.OpenFile())!= null)
				{
					this.saveZone();
					if(this.writeZonFile(new StreamWriter(myStream)) == true)
					{
						sbMain.Text = "Wrote Zone File.";
					}
					else
					{
						sbMain.Text = "Zone File save failure.";
					}
				}
			}
		}

		private void miFileSaveArea_Click(object sender, System.EventArgs e)
		{
			string myFileName, myDirectoryName, myDirectory;
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Zone Files (*.zon)|*.zon";
			saveFileDialog.RestoreDirectory = true;

			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myFileName = saveFileDialog.FileName) != null)
				{
					myDirectoryName = Path.GetDirectoryName(myFileName);
					Directory.SetCurrentDirectory(Directory.GetParent(myDirectoryName).ToString());
					myDirectory = Directory.GetCurrentDirectory();
					myFileName = Path.GetFileNameWithoutExtension(myFileName);

					if(theMobiles.Count > 0)
					{
						this.writeMobFile(System.IO.File.CreateText("mob/" + myFileName + ".mob"));
					}
					if(theObjects.Count > 0)
					{
						this.writeObjFile(System.IO.File.CreateText("obj/" + myFileName + ".obj"));
					}
					if(theRooms.Count > 0)
					{
						this.writeWldFile(System.IO.File.CreateText("wld/" + myFileName + ".wld"));
					}
					if(theShops.Count > 0)
					{
						this.writeShpFile(System.IO.File.CreateText("shp/" + myFileName + ".shp"));
					}
					this.saveZone();
					this.writeZonFile(System.IO.File.CreateText("zon/" + myFileName + ".zon"));
				}
				else
				{
					sbMain.Text = "Area save failure.";
				}
			}
		}

		private void cbWldNowhere_CheckedChanged(object sender, System.EventArgs e)
		{
			NumericUpDown[] myDirNUD = new NumericUpDown[6];
			myDirNUD[0] = nudWldNorth;
			myDirNUD[1] = nudWldEast;
			myDirNUD[2] = nudWldSouth;
			myDirNUD[3] = nudWldWest;
			myDirNUD[4] = nudWldUp;
			myDirNUD[5] = nudWldDown;

			if(cbWldNowhere.Checked == true)
			{
				myDirNUD[currentDirection].Value = -1;
				if(cbWldExitExists.Checked == false)
				{
					cbWldExitExists.Checked = true;
				}
			}

			if(loadingExit == false)
			{
				this.roomEditorChanged(null, null);
			}
		}

		private void bMobESpecs_Click(object sender, System.EventArgs e)
		{
			fMobESpecs mobESpecForm = new fMobESpecs(currentMobile, theESpecs);
			mobESpecForm.ShowDialog(this);

			if(mobESpecForm.DialogResult == DialogResult.Yes)
			{
				this.mobileEditorChanged(null, null);
			}
		}

		private void bObjExtraDescriptions_Click(object sender, System.EventArgs e)
		{
			fExtraDescs objExtraDescForm = new fExtraDescs(currentObject.ExtraDescriptions, objExtraDescKeywordMax, objExtraDescDescriptionMax);
			objExtraDescForm.ShowDialog(this);

			if(objExtraDescForm.DialogResult == DialogResult.Yes)
			{
				this.objectEditorChanged(null, null);
			}
		}

		private void bObjAffects_Click(object sender, System.EventArgs e)
		{
			fObjAffects objAffectForm = new fObjAffects(currentObject);
			objAffectForm.ShowDialog(this);

			if(objAffectForm.DialogResult == DialogResult.Yes)
			{
				this.objectEditorChanged(null, null);
			}
		}

		private void bWldExtraDescriptions_Click(object sender, System.EventArgs e)
		{
			fExtraDescs wldExtraDescForm = new fExtraDescs(currentRoom.ExtraDescriptions, wldExtraDescKeywordMax, wldExtraDescDescriptionMax);
			wldExtraDescForm.ShowDialog(this);

			if(wldExtraDescForm.DialogResult == DialogResult.Yes)
			{
				this.roomEditorChanged(null, null);
			}
		}

		private void bShpShopkeeperMessages_Click(object sender, System.EventArgs e)
		{
			fShpMessages shpMessagesForm = new fShpMessages(currentShop);
			shpMessagesForm.ShowDialog(this);

			if(shpMessagesForm.DialogResult == DialogResult.Yes)
			{
				this.shopEditorChanged(null, null);
			}
		}

		private void bWldDoorDescription_Click(object sender, System.EventArgs e)
		{
			this.saveDirectionData();

			fWldDoorDesc wldDoorDescForm = new fWldDoorDesc(((DirectionData)currentRoom.DirectionField[currentDirection]));
			wldDoorDescForm.ShowDialog(this);

			if(wldDoorDescForm.DialogResult == DialogResult.Yes)
			{
				this.roomEditorChanged(null, null);
			}
		}

		private void bMobDelete_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Really Delete This Mobile?", "Delete Mobile", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				theMobiles.Remove(currentMobile.VNum);
				this.setMobQuickSelect();
				if(this.theMobiles.Count > 0)
				{
					cboxMobQuickSelect.SelectedIndex = 0;
				}
				else
				{
					this.clearMobileEditor();
					this.disableMobileEditor();
					bMobNew.Enabled = true;
				}

				this.mobileEditorUnchanged();
				mobFileSaved = false;
			}
		}

		private void clearMobileEditor()
		{
			tbMobAliasList.Clear();
			tbMobShortDescription.Clear();
			tbMobLongDescription.Clear();
			tbMobDetailedDescription.Clear();
			foreach(int i in clboxMobActionBitvector.CheckedIndices)
			{
				clboxMobActionBitvector.SetItemChecked(i, false);
			}
			for(int i = 0; i < defaultMobile.ActionBitvector.Length; i++)
			{
				clboxMobActionBitvector.SetItemChecked(defaultMobile.ActionBitvector[i], true);
			}
			foreach(int i in clboxMobAffectionBitvector.CheckedIndices)
			{
				clboxMobAffectionBitvector.SetItemChecked(i, false);
			}
			for(int i = 0; i < defaultMobile.AffectionBitvector.Length; i++)
			{
				clboxMobAffectionBitvector.SetItemChecked(defaultMobile.AffectionBitvector[i], true);
			}
			if((nudMobLevel.Minimum > 0) || (nudMobLevel.Maximum < 0))
			{
				nudMobLevel.Value = nudMobLevel.Minimum;
			}
			else
			{
				nudMobLevel.Value = 0;
			}
			if((nudMobAlignment.Minimum > 0) || (nudMobAlignment.Maximum < 0))
			{
				nudMobAlignment.Value = nudMobAlignment.Minimum;
			}
			else
			{
				nudMobAlignment.Value = 0;
			}
			if((nudMobThaco.Minimum > 0) || (nudMobThaco.Maximum < 0))
			{
				nudMobThaco.Value = nudMobThaco.Minimum;
			}
			else
			{
				nudMobThaco.Value = 0;
			}
			if((nudMobArmorClass.Minimum > 0) || (nudMobArmorClass.Maximum < 0))
			{
				nudMobArmorClass.Value = nudMobArmorClass.Minimum;
			}
			else
			{
				nudMobArmorClass.Value = 0;
			}
			if((nudMobExperience.Minimum > 0) || (nudMobExperience.Maximum < 0))
			{
				nudMobExperience.Value = nudMobExperience.Minimum;
			}
			else
			{
				nudMobExperience.Value = 0;
			}
			if((nudMobGold.Minimum > 0) || (nudMobGold.Maximum < 0))
			{
				nudMobGold.Value = nudMobGold.Minimum;
			}
			else
			{
				nudMobGold.Value = 0;
			}
			if((nudMobHPNum.Minimum > 0) || (nudMobHPNum.Maximum < 0))
			{
				nudMobHPNum.Value = nudMobHPNum.Minimum;
			}
			else
			{
				nudMobHPNum.Value = 0;
			}
			if((nudMobHPDie.Minimum > 0) || (nudMobHPDie.Maximum < 0))
			{
				nudMobHPDie.Value = nudMobHPDie.Minimum;
			}
			else
			{
				nudMobHPDie.Value = 0;
			}
			if((nudMobHPAdd.Minimum > 0) || (nudMobHPAdd.Maximum < 0))
			{
				nudMobHPAdd.Value = nudMobHPAdd.Minimum;
			}
			else
			{
				nudMobHPAdd.Value = 0;
			}
			if((nudMobBHNum.Minimum > 0) || (nudMobBHNum.Maximum < 0))
			{
				nudMobBHNum.Value = nudMobBHNum.Minimum;
			}
			else
			{
				nudMobBHNum.Value = 0;
			}
			if((nudMobBHDie.Minimum > 0) || (nudMobBHDie.Maximum < 0))
			{
				nudMobBHDie.Value = nudMobBHDie.Minimum;
			}
			else
			{
				nudMobBHDie.Value = 0;
			}
			if((nudMobBHAdd.Minimum > 0) || (nudMobBHAdd.Maximum < 0))
			{
				nudMobBHAdd.Value = nudMobBHAdd.Minimum;
			}
			else
			{
				nudMobBHAdd.Value = 0;
			}
			cboxMobGender.SelectedIndex = defaultMobile.Sex;
			cboxMobLoadPosition.SelectedIndex = defaultMobile.LoadPosition;
			cboxMobDefaultPosition.SelectedIndex = defaultMobile.DefaultPosition;

			this.mobileEditorUnchanged();
		}

		private void clearObjectEditor()
		{
			tbObjAliasList.Clear();
			tbObjShortDescription.Clear();
			tbObjLongDescription.Clear();
			tbObjActionDescription.Clear();
			foreach(int i in clboxObjEffectsBitvector.CheckedIndices)
			{
				clboxObjEffectsBitvector.SetItemChecked(i, false);
			}
			for(int i = 0; i < defaultObject.EffectsBitvector.Length; i++)
			{
				clboxObjEffectsBitvector.SetItemChecked(defaultObject.EffectsBitvector[i], true);
			}
			foreach(int i in clboxObjWearBitvector.CheckedIndices)
			{
				clboxObjWearBitvector.SetItemChecked(i, false);
			}
			for(int i = 0; i < defaultObject.WearBitvector.Length; i++)
			{
				clboxObjWearBitvector.SetItemChecked(defaultObject.WearBitvector[i], true);
			}
			if((nudObjCost.Minimum > 0) || (nudObjCost.Maximum < 0))
			{
				nudObjCost.Value = nudObjCost.Minimum;
			}
			else
			{
				nudObjCost.Value = 0;
			}
			if((nudObjWeight.Minimum > 0) || (nudObjWeight.Maximum < 0))
			{
				nudObjWeight.Value = nudObjWeight.Minimum;
			}
			else
			{
				nudObjWeight.Value = 0;
			}
			if((nudObjRentPerDay.Minimum > 0) || (nudObjRentPerDay.Maximum < 0))
			{
				nudObjRentPerDay.Value = nudObjRentPerDay.Minimum;
			}
			else
			{
				nudObjRentPerDay.Value = 0;
			}
			cboxObjTypeFlag.SelectedIndex = defaultObject.TypeFlag;

			this.objectEditorUnchanged();
		}

		private void clearRoomEditor()
		{
			NumericUpDown[] myDirNUD = new NumericUpDown[6];
			myDirNUD[0] = nudWldNorth;
			myDirNUD[1] = nudWldEast;
			myDirNUD[2] = nudWldSouth;
			myDirNUD[3] = nudWldWest;
			myDirNUD[4] = nudWldUp;
			myDirNUD[5] = nudWldDown;

			tbWldRoomName.Clear();
			tbWldRoomDescription.Clear();
			foreach(int i in clboxWldRoomBitvector.CheckedIndices)
			{
				clboxWldRoomBitvector.SetItemChecked(i, false);
			}
			for(int i = 0; i < defaultRoom.RoomBitvector.Length; i++)
			{
				clboxWldRoomBitvector.SetItemChecked(defaultRoom.RoomBitvector[i], true);
			}

			cboxWldSectorType.SelectedIndex = defaultRoom.SectorType;

			for(int i = 0; i < 6; i++)
			{
				if((myDirNUD[i].Minimum > 0) || (myDirNUD[i].Maximum < 0))
				{
					myDirNUD[i].Value = myDirNUD[i].Minimum;
				}
				else
				{
					myDirNUD[i].Value = 0;
				}
				myDirNUD[i].Enabled = false;
			}
			rbWldNorth.Checked = true;
			nudWldNorth.Enabled = true;

			cbWldExitExists.Checked = false;
			cbWldNowhere.Checked = false;
			cboxWldDoorFlag.SelectedIndex = defaultRoom.DoorFlag;
			if((nudWldDoorKey.Minimum > 0) || (nudWldDoorKey.Maximum < 0))
			{
				nudWldDoorKey.Value = nudWldDoorKey.Minimum;
			}
			else
			{
				nudWldDoorKey.Value = -1;
			}
			cboxWldAreaDoorKey.SelectedIndex = -1;
			cboxWldAreaDoorKey.Enabled = false;
			cbWldNoKey.Checked = true;

			nudWldVNum.Value = nudWldVNum.Minimum;

			this.roomEditorUnchanged();
		}

		private void setMobQuickSelect()
		{
			cboxMobQuickSelect.Items.Clear();
			foreach(Mobile mob in theMobiles.Values)
			{
				cboxMobQuickSelect.Items.Add(mob.VNum + " - " + mob.ShortDescription);
			}
		}

		private void bObjDelete_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Really Delete This Object?", "Delete Object", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				theObjects.Remove(currentObject.VNum);
				this.setObjQuickSelect();
				if(this.theObjects.Count > 0)
				{
					cboxObjQuickSelect.SelectedIndex = 0;
				}
				else
				{
					this.clearObjectEditor();
					this.disableObjectEditor();
					bObjNew.Enabled = true;
				}

				this.objectEditorUnchanged();
				objFileSaved = false;
			}
		}

		private void setObjQuickSelect()
		{
			cboxObjQuickSelect.Items.Clear();
			foreach(Object obj in theObjects.Values)
			{
				cboxObjQuickSelect.Items.Add(obj.VNum + " - " + obj.ShortDescription);
			}
		}

		private void bWldDelete_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Really Delete This Room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				theRooms.Remove(currentRoom.VNum);
				this.setWldQuickSelect();
				if(this.theRooms.Count > 0)
				{
					cboxWldQuickSelect.SelectedIndex = 0;
				}
				else
				{
					this.clearRoomEditor();
					this.disableRoomEditor();
					bWldNew.Enabled = true;
				}

				this.roomEditorUnchanged();
				wldFileSaved = false;
			}
		}

		private void setWldQuickSelect()
		{
			cboxWldQuickSelect.Items.Clear();
			foreach(Room wld in theRooms.Values)
			{
				cboxWldQuickSelect.Items.Add(wld.VNum + " - " + wld.Name);
			}
		}

		private void bShpDelete_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Really Delete This Shop?", "Delete Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				theShops.Remove(currentShop.VNum);
				this.setShpQuickSelect();
				if(this.theShops.Count > 0)
				{
					cboxShpQuickSelect.SelectedIndex = 0;
				}
				else
				{
					this.clearShopEditor();
					this.disableShopEditor();
					bShpNew.Enabled = true;
				}

				this.shopEditorUnchanged();
				shpFileSaved = false;
			}
		}

		private void setShpQuickSelect()
		{
			Mobile myMobile;
			cboxShpQuickSelect.Items.Clear();
			foreach(Shop shp in theShops.Values)
			{
				if(theMobiles.Count > 0)
				{
					if(theMobiles.IndexOfKey(shp.ShopkeeperVNum) != -1)
					{
						myMobile = (Mobile)theMobiles[shp.ShopkeeperVNum];
						cboxShpQuickSelect.Items.Add(shp.VNum + " - Shopkeeper: [" + myMobile.VNum + "] " + myMobile.ShortDescription);
					}
					else
					{
						cboxShpQuickSelect.Items.Add(shp.VNum + " - Shopkeeper: [" + shp.ShopkeeperVNum + "] (Unknown Mobile)");
					}
				}
				else
				{
					cboxShpQuickSelect.Items.Add(shp.VNum + " - Shopkeeper: [" + shp.ShopkeeperVNum + "] (Unknown Mobile)");
				}
			}
		}

		private void disableMobileEditor()
		{
			gbMobAliasList.Enabled = false;
			gbMobShortDescription.Enabled = false;
			gbMobLongDescription.Enabled = false;
			gbMobDetailedDescription.Enabled = false;
			gbMobLevel.Enabled = false;
			gbMobAlignment.Enabled = false;
			gbMobThaco.Enabled = false;
			gbMobArmorClass.Enabled = false;
			gbMobExperience.Enabled = false;
			gbMobGold.Enabled = false;
			gbMobHP.Enabled = false;
			gbMobBH.Enabled = false;
			gbMobGender.Enabled = false;
			gbMobLoadPosition.Enabled = false;
			gbMobDefaultPosition.Enabled = false;
			gbMobActionBitvector.Enabled = false;
			gbMobAffectionBitvector.Enabled = false;
			bMobESpecs.Enabled = false;
			gbMobVNum.Enabled = false;
			gbMobQuickSelect.Enabled = false;
			bMobNew.Enabled = false;
			bMobSave.Enabled = false;
			bMobCopy.Enabled = false;
			bMobMove.Enabled = false;
			bMobDelete.Enabled = false;
		}

		private void enableMobileEditor()
		{
			gbMobAliasList.Enabled = true;
			gbMobShortDescription.Enabled = true;
			gbMobLongDescription.Enabled = true;
			gbMobDetailedDescription.Enabled = true;
			gbMobLevel.Enabled = true;
			gbMobAlignment.Enabled = true;
			gbMobThaco.Enabled = true;
			gbMobArmorClass.Enabled = true;
			gbMobExperience.Enabled = true;
			gbMobGold.Enabled = true;
			gbMobHP.Enabled = true;
			gbMobBH.Enabled = true;
			gbMobGender.Enabled = true;
			cboxMobGender.SelectedIndex = defaultMobile.Sex;
			gbMobLoadPosition.Enabled = true;
			cboxMobLoadPosition.SelectedIndex = defaultMobile.LoadPosition;
			gbMobDefaultPosition.Enabled = true;
			cboxMobDefaultPosition.SelectedIndex = defaultMobile.DefaultPosition;
			gbMobActionBitvector.Enabled = true;
			gbMobAffectionBitvector.Enabled = true;
			bMobESpecs.Enabled = true;
			gbMobVNum.Enabled = true;
			gbMobQuickSelect.Enabled = true;
			bMobNew.Enabled = true;
			bMobSave.Enabled = true;
			bMobCopy.Enabled = true;
			bMobMove.Enabled = true;
			bMobDelete.Enabled = true;

			this.mobileEditorUnchanged();
		}

		private void disableObjectEditor()
		{
			gbObjAliasList.Enabled = false;
			gbObjShortDescription.Enabled = false;
			gbObjLongDescription.Enabled = false;
			gbObjActionDescription.Enabled = false;
			gbObjWeight.Enabled = false;
			gbObjCost.Enabled = false;
			gbObjRentPerDay.Enabled = false;
			bObjAffects.Enabled = false;
			gbObjTypeFlag.Enabled = false;
			gbObjValues.Enabled = false;
			gbObjEffectsBitvector.Enabled = false;
			gbObjWearBitvector.Enabled = false;
			bObjExtraDescriptions.Enabled = false;
			gbObjVNum.Enabled = false;
			gbObjQuickSelect.Enabled = false;
			bObjNew.Enabled = false;
			bObjSave.Enabled = false;
			bObjCopy.Enabled = false;
			bObjMove.Enabled = false;
			bObjDelete.Enabled = false;
		}

		private void enableObjectEditor()
		{
			gbObjAliasList.Enabled = true;
			gbObjShortDescription.Enabled = true;
			gbObjLongDescription.Enabled = true;
			gbObjActionDescription.Enabled = true;
			gbObjWeight.Enabled = true;
			gbObjCost.Enabled = true;
			gbObjRentPerDay.Enabled = true;
			bObjAffects.Enabled = true;
			gbObjTypeFlag.Enabled = true;
			gbObjValues.Enabled = true;
			gbObjEffectsBitvector.Enabled = true;
			gbObjWearBitvector.Enabled = true;
			bObjExtraDescriptions.Enabled = true;
			gbObjVNum.Enabled = true;
			gbObjQuickSelect.Enabled = true;
			bObjNew.Enabled = true;
			bObjSave.Enabled = true;
			bObjCopy.Enabled = true;
			bObjMove.Enabled = true;
			bObjDelete.Enabled = true;

			this.objectEditorUnchanged();
		}

		private void disableRoomEditor()
		{
			gbWldRoomName.Enabled = false;
			gbWldRoomDescription.Enabled = false;
			gbWldDirections.Enabled = false;
			gbWldRoomBitvector.Enabled = false;
			gbWldSectorType.Enabled = false;
			bWldExtraDescriptions.Enabled = false;
			gbWldVNum.Enabled = false;
			gbWldQuickSelect.Enabled = false;
			bWldNew.Enabled = false;
			bWldSave.Enabled = false;
			bWldCopy.Enabled = false;
			bWldMove.Enabled = false;
			bWldDelete.Enabled = false;
		}

		private void enableRoomEditor()
		{
			gbWldRoomName.Enabled = true;
			gbWldRoomDescription.Enabled = true;
			gbWldDirections.Enabled = true;
			gbWldRoomBitvector.Enabled = true;
			gbWldSectorType.Enabled = true;
			bWldExtraDescriptions.Enabled = true;
			gbWldVNum.Enabled = true;
			gbWldQuickSelect.Enabled = true;
			bWldNew.Enabled = true;
			bWldSave.Enabled = true;
			bWldCopy.Enabled = true;
			bWldMove.Enabled = true;
			bWldDelete.Enabled = true;

			this.roomEditorUnchanged();
		}

		private void disableShopEditor()
		{
			gbShpShopItems.Enabled = false;
			gbShpShopRooms.Enabled = false;
			gbShpShopkeeper.Enabled = false;
			gbShpShopInformation.Enabled = false;
			gbShpBuyTypes.Enabled = false;
			gbShpWillNotSellTo.Enabled = false;
			bShpShopkeeperMessages.Enabled = false;
			gbShpVNum.Enabled = false;
			gbShpQuickSelect.Enabled = false;
			bShpNew.Enabled = false;
			bShpSave.Enabled = false;
			bShpCopy.Enabled = false;
			bShpMove.Enabled = false;
			bShpDelete.Enabled = false;
		}

		private void enableShopEditor()
		{
			gbShpShopItems.Enabled = true;
			gbShpShopRooms.Enabled = true;
			gbShpShopkeeper.Enabled = true;
			gbShpShopInformation.Enabled = true;
			gbShpBuyTypes.Enabled = true;
			gbShpWillNotSellTo.Enabled = true;
			bShpShopkeeperMessages.Enabled = true;
			gbShpVNum.Enabled = true;
			gbShpQuickSelect.Enabled = true;
			bShpNew.Enabled = true;
			bShpSave.Enabled = true;
			bShpCopy.Enabled = true;
			bShpMove.Enabled = true;
			bShpDelete.Enabled = true;

			this.shopEditorUnchanged();
		}

		private void disableZoneEditor()
		{
			gbZonZoneCommands.Enabled = false;
			gbZonZoneCommand.Enabled = false;
			gbZonZoneInformation.Enabled = false;
			cboxZonCommandType.SelectedIndex = -1;
		}
		private void enableZoneEditor()
		{
			gbZonZoneCommands.Enabled = true;
			gbZonZoneCommand.Enabled = true;
			gbZonZoneInformation.Enabled = true;
			cboxZonCommandType.SelectedIndex = 0;

			this.zoneEditorUnchanged();
		}

		private void miFileNewMobileFile_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Mobiles Belong to Zone Number:");
			
			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				mobZone = decimal.ToInt32(inputResult);
				bMobNew.Enabled = true;
				miFileNewArea.Enabled = false;
				miFileNewMobileFile.Enabled = false;
				miFileOpenArea.Enabled = false;
				miFileOpenMobileFile.Enabled = false;
				miFileClose.Enabled = true;
				miFileCloseArea.Enabled = false;
				miFileCloseMobileFile.Enabled = true;
				miFileSave.Enabled = true;
				miFileSaveMobileFile.Enabled = true;
				miToolsLoadMUDConfiguration.Enabled = false;

				this.mobileEditorUnchanged();

				mobFileSaved = true;

				tcEditors.SelectedTab = tpMobileEditor;
			}
		}

		private void miFileNewArea_Click(object sender, System.EventArgs e)
		{
			fNewArea newAreaForm = new fNewArea();

			if(newAreaForm.ShowDialog() == DialogResult.OK)
			{
				if(autoGenComment == true)
				{
					miToolsAutoGenerateComments.Checked = true;
				}
				else
				{
					miToolsAutoGenerateComments.Checked = false;
				}

				bMobNew.Enabled = true;
				mobZone = currentZoneNumber;
				bObjNew.Enabled = true;
				objZone = currentZoneNumber;
				bWldNew.Enabled = true;
				wldZone = currentZoneNumber;
				bShpNew.Enabled = true;
				shpZone = currentZoneNumber;
				enableZoneEditor();
				nudZonNumber.Value = currentZoneNumber;
				tbZonZoneName.Text = currentZoneName;
				currentZone = new Zone(currentZoneNumber);

				miFileNew.Enabled = false;
				miFileOpen.Enabled = false;
				miFileClose.Enabled = true;
				miFileCloseArea.Enabled = true;
				miFileCloseMobileFile.Enabled = false;
				miFileCloseObjectFile.Enabled = false;
				miFileCloseWorldFile.Enabled = false;
				miFileCloseShopFile.Enabled = false;
				miFileCloseZoneFile.Enabled = false;
				miFileSave.Enabled = true;
				miFileSaveArea.Enabled = true;
				miFileSaveMobileFile.Enabled = false;
				miFileSaveObjectFile.Enabled = false;
				miFileSaveWorldFile.Enabled = false;
				miFileSaveShopFile.Enabled = false;
				miFileSaveZoneFile.Enabled = false;
				miToolsLoadMUDConfiguration.Enabled = false;

				this.mobileEditorUnchanged();
				this.objectEditorUnchanged();
				this.roomEditorUnchanged();
				this.shopEditorUnchanged();
				this.zoneEditorUnchanged();

				mobFileSaved = true;
				objFileSaved = true;
				wldFileSaved = true;
				shpFileSaved = true;
				zonFileSaved = true;
			}
		}

		private void bMobNew_Click(object sender, System.EventArgs e)
		{
			if(theMobiles.Count >= 100)
			{
				MessageBox.Show("Cannot Add More Than 100 Mobiles to a File", "Cannot Add Mobile", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				enableMobileEditor();
				bMobDelete.Enabled = false;
				nudMobVNum.Minimum = int.Parse(mobZone + "00");
				nudMobVNum.Maximum = int.Parse(mobZone + "99");
				nudMobVNum.Value = nudMobVNum.Minimum;
				tbMobAliasList.Focus();
				if(theMobiles.Count < 100)
				{
					long myKey;

					for(int i = 0; i < 100; i++)
					{
						if(i < 10)
						{
							myKey = long.Parse(mobZone.ToString() + "0" + i.ToString());
						}
						else
						{
							myKey = long.Parse(mobZone.ToString() + i.ToString());
						}
						if(theMobiles.ContainsKey(myKey) == false)
						{
							currentMobile = new Mobile(myKey);
							clearMobileEditor();
							nudMobVNum.Value = myKey;
							break;
						}
					}
				}
				this.mobileEditorUnchanged();
			}
		}

		private void miFileNewObjectFile_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Objects Belong to Zone Number:");
			
			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				objZone = decimal.ToInt32(inputResult);
				bObjNew.Enabled = true;
				miFileNewArea.Enabled = false;
				miFileNewObjectFile.Enabled = false;
				miFileOpenArea.Enabled = false;
				miFileOpenObjectFile.Enabled = false;
				miFileClose.Enabled = true;
				miFileCloseArea.Enabled = false;
				miFileCloseObjectFile.Enabled = true;
				miFileSave.Enabled = true;
				miFileSaveObjectFile.Enabled = true;
				miToolsLoadMUDConfiguration.Enabled = false;

				this.objectEditorUnchanged();

				objFileSaved = true;

				tcEditors.SelectedTab = tpObjectEditor;
			}
		}

		private void bObjNew_Click(object sender, System.EventArgs e)
		{
			if(theObjects.Count >= 100)
			{
				MessageBox.Show("Cannot Add More Than 100 Objects to a File", "Cannot Add Object", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				enableObjectEditor();
				bObjDelete.Enabled = false;
				nudObjVNum.Minimum = int.Parse(objZone + "00");
				nudObjVNum.Maximum = int.Parse(objZone + "99");
				nudObjVNum.Value = nudObjVNum.Minimum;
				tbObjAliasList.Focus();
				if(theObjects.Count < 100)
				{
					long myKey;

					for(int i = 0; i < 100; i++)
					{
						if(i < 10)
						{
							myKey = long.Parse(objZone.ToString() + "0" + i.ToString());
						}
						else
						{
							myKey = long.Parse(objZone.ToString() + i.ToString());
						}
						if(theObjects.ContainsKey(myKey) == false)
						{
							currentObject = new Object(myKey);
							clearObjectEditor();
							nudObjVNum.Value = myKey;
							break;
						}
					}
				}
				this.objectEditorUnchanged();
			}
		}

		private void miFileNewWorldFile_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Rooms Belong to Zone Number:");
			
			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				wldZone = decimal.ToInt32(inputResult);
				bWldNew.Enabled = true;
				miFileNewArea.Enabled = false;
				miFileNewWorldFile.Enabled = false;
				miFileOpenArea.Enabled = false;
				miFileOpenWorldFile.Enabled = false;
				miFileClose.Enabled = true;
				miFileCloseArea.Enabled = false;
				miFileCloseWorldFile.Enabled = true;
				miFileSave.Enabled = true;
				miFileSaveWorldFile.Enabled = true;
				miToolsLoadMUDConfiguration.Enabled = false;

				this.roomEditorUnchanged();

				tcEditors.SelectedTab = tpRoomEditor;
			}
		}

		private void bWldNew_Click(object sender, System.EventArgs e)
		{
			if(theRooms.Count >= 100)
			{
				MessageBox.Show("Cannot Add More Than 100 Rooms to a File", "Cannot Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				enableRoomEditor();
				bWldDelete.Enabled = false;
				nudWldVNum.Minimum = int.Parse(wldZone + "00");
				nudWldVNum.Maximum = int.Parse(wldZone + "99");
				nudWldVNum.Value = nudWldVNum.Minimum;
				tbWldRoomName.Focus();
				if(theRooms.Count < 100)
				{
					long myKey;

					for(int i = 0; i < 100; i++)
					{
						if(i < 10)
						{
							myKey = long.Parse(wldZone.ToString() + "0" + i.ToString());
						}
						else
						{
							myKey = long.Parse(wldZone.ToString() + i.ToString());
						}
						if(theRooms.ContainsKey(myKey) == false)
						{
							currentRoom = new Room(myKey);
							clearRoomEditor();
							nudWldVNum.Value = myKey;
							break;
						}
					}
				}
				this.roomEditorUnchanged();
			}
		}

		private void bWldSave_Click(object sender, System.EventArgs e)
		{
			this.saveRoom();
		}

		private void cbWldExitExists_CheckedChanged(object sender, System.EventArgs e)
		{
			if(cbWldExitExists.Checked == true)
			{
				cbWldNowhere.Enabled = true;
				gbWldDoorFlag.Enabled = true;
				bWldDoorDescription.Enabled = true;
			}
			else
			{
				cbWldNowhere.Enabled = false;
				gbWldDoorFlag.Enabled = false;
				gbWldDoorKey.Enabled = false;
				bWldDoorDescription.Enabled = true;
			}

			if(loadingExit == false)
			{
				this.roomEditorChanged(null, null);
			}
		}

		private void cboxWldDoorFlag_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cboxWldDoorFlag.SelectedIndex > 0)
			{
				gbWldDoorKey.Enabled = true;
			}
			else
			{
				gbWldDoorKey.Enabled = false;
				cbWldNoKey.Checked = true;
			}

			if(loadingExit == false)
			{
				this.roomEditorChanged(null, null);
			}
		}

		private void bShpNew_Click(object sender, System.EventArgs e)
		{
			if(theShops.Count >= 100)
			{
				MessageBox.Show("Cannot Add More Than 100 Shops to a File", "Cannot Add Shop", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				enableShopEditor();
				bShpDelete.Enabled = false;
				nudShpVNum.Minimum = int.Parse(shpZone + "00");
				nudShpVNum.Maximum = int.Parse(shpZone + "99");
				nudShpVNum.Value = nudShpVNum.Minimum;
				nudShpItemVNum.Focus();
				if(theShops.Count < 100)
				{
					long myKey;

					for(int i = 0; i < 100; i++)
					{
						if(i < 10)
						{
							myKey = long.Parse(shpZone.ToString() + "0" + i.ToString());
						}
						else
						{
							myKey = long.Parse(shpZone.ToString() + i.ToString());
						}
						if(theShops.ContainsKey(myKey) == false)
						{
							currentShop = new Shop(myKey);
							clearShopEditor();
							nudShpVNum.Value = myKey;
							break;
						}
					}
				}

				for(int i = 0; i < theObjects.Count; i++)
				{
					Object myObject = ((Object)theObjects.GetByIndex(i));
					cboxShpAreaItem.Items.Add(myObject.VNum + " - " + myObject.ShortDescription);
				}
				for(int i = 0; i < theRooms.Count; i++)
				{
					Room myRoom = ((Room)theRooms.GetByIndex(i));
					cboxShpAreaRoom.Items.Add(myRoom.VNum + " - " + myRoom.Name);
				}
				for(int i = 0; i < cboxObjQuickSelect.Items.Count; i++)
				{
					Mobile myMobile = ((Mobile)theMobiles.GetByIndex(i));
					cboxShpAreaMobile.Items.Add(myMobile.VNum + " - " + myMobile.ShortDescription);
				}

				this.shopEditorUnchanged();
			}
		}

		private void nudZonArg0_ValueChanged(object sender, System.EventArgs e)
		{
			setZonCBoxData(0);
		}

		private void setZonCBoxData(int theArg)
		{
			if(valueChanging == false)
			{
				ComboBox[] myCBox = new ComboBox[3];
				myCBox[0] = cboxZonAreaArg0;
				myCBox[1] = cboxZonAreaArg1;
				myCBox[2] = cboxZonAreaArg2;

				if(myCBox[theArg].Enabled == true)
				{
					NumericUpDown[] myNUD = new NumericUpDown[3];
					myNUD[0] = nudZonArg0;
					myNUD[1] = nudZonArg1;
					myNUD[2] = nudZonArg2;

					string myCommandType;
					if(cboxZonCommandType.SelectedIndex == (cboxZonCommandType.Items.Count - 1))
					{
						myCommandType = "*";
					}
					else
					{
						myCommandType = zonCommandTypes[cboxZonCommandType.SelectedIndex * 2];
					}

					Arg myArg = ((Arg)((CommandData)theCommands[myCommandType]).Arg[theArg]);

					valueChanging = true;
					if(myArg.Range[0].CompareTo("<MOBILES>") == 0)
					{
						myCBox[theArg].SelectedIndex = theMobiles.IndexOfKey(decimal.ToInt64(myNUD[theArg].Value));
					}
					else if(myArg.Range[0].CompareTo("<OBJECTS>") == 0)
					{
						myCBox[theArg].SelectedIndex = theObjects.IndexOfKey(decimal.ToInt64(myNUD[theArg].Value));
					}
					else if(myArg.Range[0].CompareTo("<ROOMS>") == 0)
					{
						myCBox[theArg].SelectedIndex = theRooms.IndexOfKey(decimal.ToInt64(myNUD[theArg].Value));
					}
					else if(myArg.Range[0].CompareTo("<SHOPS>") == 0)
					{
						myCBox[theArg].SelectedIndex = theShops.IndexOfKey(decimal.ToInt64(myNUD[theArg].Value));
					}
					else
					{
						myCBox[theArg].SelectedIndex = myCBox[theArg].Items.IndexOf(myArg.Range[myArg.Range.IndexOf(myNUD[theArg].Value.ToString()) + 1]);
					}
					valueChanging = false;
				}
			}
		}

		private void cboxZonAreaArg0_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			setZonNUDData(0);
		}

		private void setZonNUDData(int theArg)
		{
			if(valueChanging == false)
			{
				ComboBox[] myCBox = new ComboBox[3];
				myCBox[0] = cboxZonAreaArg0;
				myCBox[1] = cboxZonAreaArg1;
				myCBox[2] = cboxZonAreaArg2;
				NumericUpDown[] myNUD = new NumericUpDown[3];
				myNUD[0] = nudZonArg0;
				myNUD[1] = nudZonArg1;
				myNUD[2] = nudZonArg2;

				string myCommandType;
				if(cboxZonCommandType.SelectedIndex == (cboxZonCommandType.Items.Count - 1))
				{
					myCommandType = "*";
				}
				else
				{
					myCommandType = zonCommandTypes[cboxZonCommandType.SelectedIndex * 2];
				}

				Arg myArg = ((Arg)((CommandData)theCommands[myCommandType]).Arg[theArg]);

				valueChanging = true;
				if(myArg.Range[0].CompareTo("<MOBILES>") == 0)
				{
					myNUD[theArg].Value = long.Parse(theMobiles.GetKey(myCBox[theArg].SelectedIndex).ToString());
				}
				else if(myArg.Range[0].CompareTo("<OBJECTS>") == 0)
				{
					myNUD[theArg].Value = long.Parse(theObjects.GetKey(myCBox[theArg].SelectedIndex).ToString());
				}
				else if(myArg.Range[0].CompareTo("<ROOMS>") == 0)
				{
					myNUD[theArg].Value = long.Parse(theRooms.GetKey(myCBox[theArg].SelectedIndex).ToString());
				}
				else if(myArg.Range[0].CompareTo("<SHOPS>") == 0)
				{
					myNUD[theArg].Value = long.Parse(theShops.GetKey(myCBox[theArg].SelectedIndex).ToString());
				}
				else
				{
					myNUD[theArg].Value = long.Parse(myArg.Range[myArg.Range.IndexOf(myCBox[theArg].SelectedItem.ToString()) - 1]);
				}
				valueChanging = false;
			}
		}

		private void nudZonArg1_ValueChanged(object sender, System.EventArgs e)
		{
			setZonCBoxData(1);
		}

		private void cboxZonAreaArg1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			setZonNUDData(1);
		}

		private void nudZonArg2_ValueChanged(object sender, System.EventArgs e)
		{
			setZonCBoxData(2);
		}

		private void cboxZonAreaArg2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			setZonNUDData(2);
		}

		private void bMobCopy_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Copy Mobile To VNum:");
			
			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				bool myBool = false;

				if(theMobiles.ContainsKey(inputResult) == true)
				{
					if(MessageBox.Show("Mobile [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Mobile Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						myBool = true;
						theMobiles.Remove(inputResult);
					}
				}
				else
				{
					myBool = true;
				}
				if(myBool == true)
				{
					this.saveMobile();

					Mobile myMobile = new Mobile(inputResult);
					myMobile.AliasList = currentMobile.AliasList;
					myMobile.ShortDescription = currentMobile.ShortDescription;
					myMobile.LongDescription = currentMobile.LongDescription;
					myMobile.DetailedDescription = currentMobile.DetailedDescription;
					myMobile.ActionBitvector = currentMobile.ActionBitvector;
					myMobile.AffectionBitvector = currentMobile.AffectionBitvector;
					myMobile.Alignment = currentMobile.Alignment;
					myMobile.TypeFlag = currentMobile.TypeFlag;
					myMobile.Level = currentMobile.Level;
					myMobile.Thaco = currentMobile.Thaco;
					myMobile.ArmorClass = currentMobile.ArmorClass;
					myMobile.Experience = currentMobile.Experience;
					myMobile.Gold = currentMobile.Gold;
					myMobile.HPNum = currentMobile.HPNum;
					myMobile.HPDie = currentMobile.HPDie;
					myMobile.HPAdd = currentMobile.HPAdd;
					myMobile.BHNum = currentMobile.BHNum;
					myMobile.BHDie = currentMobile.BHDie;
					myMobile.BHAdd = currentMobile.BHAdd;
					myMobile.LoadPosition = currentMobile.LoadPosition;
					myMobile.DefaultPosition = currentMobile.DefaultPosition;
					myMobile.Sex = currentMobile.Sex;
					for(int i = 0; i < currentMobile.ESpecs.Count; i++)
					{
						myMobile.ESpecs.Add(currentMobile.ESpecs.GetKey(i), currentMobile.ESpecs.GetByIndex(i));
					}

					theMobiles.Add(myMobile.VNum, myMobile);

					this.setMobQuickSelect();
					cboxMobQuickSelect.SelectedItem = myMobile.VNum + " - " + myMobile.ShortDescription;
				}
			}
		}

		private void bMobMove_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Move Mobile To VNum:");

			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				bool myBool = false;

				if(theMobiles.ContainsKey(inputResult) == true)
				{
					if(MessageBox.Show("Mobile [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Mobile Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						myBool = true;
						theMobiles.Remove(inputResult);
					}
				}
				else
				{
					myBool = true;
				}
				if(myBool == true)
				{
					theMobiles.Remove(currentMobile.VNum);
					currentMobile.VNum = inputResult;
					theMobiles.Add(currentMobile.VNum, currentMobile);

					this.setMobQuickSelect();
					cboxMobQuickSelect.SelectedItem = currentMobile.VNum + " - " + currentMobile.ShortDescription;
				}
			}
		}

		private void bObjCopy_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Copy Object To VNum:");
			
			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				bool myBool = false;

				if(theObjects.ContainsKey(inputResult) == true)
				{
					if(MessageBox.Show("Object [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Object Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						myBool = true;
						theObjects.Remove(inputResult);
					}
				}
				else
				{
					myBool = true;
				}
				if(myBool == true)
				{
					Object myObject = new Object(inputResult);
					myObject.AliasList = currentObject.AliasList;
					myObject.ShortDescription = currentObject.ShortDescription;
					myObject.LongDescription = currentObject.LongDescription;
					myObject.ActionDescription = currentObject.ActionDescription;
					myObject.TypeFlag = currentObject.TypeFlag;
					myObject.EffectsBitvector = currentObject.EffectsBitvector;
					myObject.WearBitvector = currentObject.WearBitvector;
					myObject.Value0 = currentObject.Value0;
					myObject.Value1 = currentObject.Value1;
					myObject.Value2 = currentObject.Value2;
					myObject.Value3 = currentObject.Value3;
					myObject.Weight = currentObject.Weight;
					myObject.Cost = currentObject.Cost;
					myObject.RentPerDay = currentObject.RentPerDay;
					for(int i = 0; i < currentObject.ExtraDescriptions.Count; i++)
					{
						myObject.ExtraDescriptions.Add(currentObject.ExtraDescriptions.GetKey(i), currentObject.ExtraDescriptions.GetByIndex(i));
					}
					for(int i = 0; i < currentObject.Affects.Count; i++)
					{
						myObject.Affects.Add(currentObject.Affects.GetKey(i), currentObject.Affects.GetByIndex(i));
					}

					theObjects.Add(myObject.VNum, myObject);

					this.setObjQuickSelect();
					cboxObjQuickSelect.SelectedItem = myObject.VNum + " - " + myObject.ShortDescription;
				}
			}
		}

		private void bObjMove_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Move Object To VNum:");

			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				bool myBool = false;

				if(theObjects.ContainsKey(inputResult) == true)
				{
					if(MessageBox.Show("Object [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Object Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						myBool = true;
						theObjects.Remove(inputResult);
					}
				}
				else
				{
					myBool = true;
				}
				if(myBool == true)
				{
					theObjects.Remove(currentObject.VNum);
					currentObject.VNum = inputResult;
					theObjects.Add(currentObject.VNum, currentObject);

					this.setObjQuickSelect();
					cboxObjQuickSelect.SelectedItem = currentObject.VNum + " - " + currentObject.ShortDescription;
				}
			}
		}

		private void bWldCopy_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Copy Room To VNum:");
			
			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				bool myBool = false;

				if(theRooms.ContainsKey(inputResult) == true)
				{
					if(MessageBox.Show("Room [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Room Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						myBool = true;
						theRooms.Remove(inputResult);
					}
				}
				else
				{
					myBool = true;
				}
				if(myBool == true)
				{
					Room myRoom = new Room(inputResult);
					myRoom.Name = currentRoom.Name;
					myRoom.Description = currentRoom.Description;
					myRoom.RoomBitvector = currentRoom.RoomBitvector;
					myRoom.SectorType = currentRoom.SectorType;
					for(int i = 0; i < currentRoom.DirectionField.Count; i++)
					{
						myRoom.DirectionField.Add(currentRoom.DirectionField.GetKey(i), currentRoom.DirectionField.GetByIndex(i));
					}
					for(int i = 0; i < currentRoom.ExtraDescriptions.Count; i++)
					{
						myRoom.ExtraDescriptions.Add(currentRoom.ExtraDescriptions.GetKey(i), currentRoom.ExtraDescriptions.GetByIndex(i));
					}

					theRooms.Add(myRoom.VNum, myRoom);

					this.setWldQuickSelect();
					cboxWldQuickSelect.SelectedItem = myRoom.VNum + " - " + myRoom.Name;
				}
			}
		}

		private void bWldMove_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Move Room To VNum:");

			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				bool myBool = false;

				if(theRooms.ContainsKey(inputResult) == true)
				{
					if(MessageBox.Show("Room [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Room Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						myBool = true;
						theRooms.Remove(inputResult);
					}
				}
				else
				{
					myBool = true;
				}
				if(myBool == true)
				{
					theRooms.Remove(currentRoom.VNum);
					currentRoom.VNum = inputResult;
					theRooms.Add(currentRoom.VNum, currentRoom);

					this.setWldQuickSelect();
					cboxWldQuickSelect.SelectedItem = currentRoom.VNum + " - " + currentRoom.Name;
				}
			}
		}

		private void bShpCopy_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Copy Shop To VNum:");
			
			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				bool myBool = false;

				if(theShops.ContainsKey(inputResult) == true)
				{
					if(MessageBox.Show("Shop [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Shop Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						myBool = true;
						theShops.Remove(inputResult);
					}
				}
				else
				{
					myBool = true;
				}
				if(myBool == true)
				{
					Shop myShop = new Shop(inputResult);
					for(int i = 0; i < currentShop.ShopItems.Count; i++)
					{
						myShop.ShopItems.Add(currentShop.ShopItems[i]);
					}
					myShop.SellProfit = currentShop.SellProfit;
					myShop.BuyProfit = currentShop.BuyProfit;
					for(int i = 0; i < currentShop.BuyTypes.Count; i++)
					{
						myShop.BuyTypes.Add(currentShop.BuyTypes[i]);
					}
					myShop.MessageBuyItemDoesNotExist = currentShop.MessageBuyItemDoesNotExist;
					myShop.MessageSellItemDoesNotExist = currentShop.MessageSellItemDoesNotExist;
					myShop.MessageShopDoesNotBuyItem = currentShop.MessageShopDoesNotBuyItem;
					myShop.MessageShopCanNotAffordItem = currentShop.MessageShopCanNotAffordItem;
					myShop.MessagePlayerCanNotAffordItem = currentShop.MessagePlayerCanNotAffordItem;
					myShop.MessageBuySuccess = currentShop.MessageBuySuccess;
					myShop.MessageSellSuccess = currentShop.MessageSellSuccess;
					myShop.ShopkeeperTemper = currentShop.ShopkeeperTemper;
					myShop.ShopBitvector = currentShop.ShopBitvector;
					myShop.ShopkeeperVNum = currentShop.ShopkeeperVNum;
					myShop.WithWhoBitvector = currentShop.WithWhoBitvector;
					for(int i = 0; i < currentShop.ShopRooms.Count; i++)
					{
						myShop.ShopRooms.Add(currentShop.ShopRooms[i]);
					}
					myShop.OpenTime1 = currentShop.OpenTime1;
					myShop.CloseTime1 = currentShop.CloseTime1;
					myShop.OpenTime2 = currentShop.OpenTime2;
					myShop.CloseTime2 = currentShop.CloseTime2;

					theShops.Add(myShop.VNum, myShop);

					this.setShpQuickSelect();
					if(theMobiles.ContainsKey(currentShop.ShopkeeperVNum) == true)
					{
						Mobile myMobile = (Mobile)theMobiles[myShop.ShopkeeperVNum];
						cboxShpQuickSelect.SelectedItem = myShop.VNum + " - Shopkeeper: [" + myMobile.VNum + "] " + myMobile.ShortDescription;
					}
					else
					{
						cboxShpQuickSelect.SelectedItem = myShop.VNum + " - Shopkeeper: [" + myShop.ShopkeeperVNum + "] (Unknown Mobile)";
					}
				}
			}
		}

		private void bShpMove_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Move Shop To VNum:");

			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				bool myBool = false;

				if(theShops.ContainsKey(inputResult) == true)
				{
					if(MessageBox.Show("Shop [" + inputResult.ToString() + "] Already Exists; Overwrite?", "Shop Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						myBool = true;
						theShops.Remove(inputResult);
					}
				}
				else
				{
					myBool = true;
				}
				if(myBool == true)
				{
					theShops.Remove(currentShop.VNum);
					currentShop.VNum = inputResult;
					theShops.Add(currentShop.VNum, currentShop);

					this.setShpQuickSelect();
					if(theMobiles.ContainsKey(currentShop.ShopkeeperVNum) == true)
					{
						Mobile myMobile = (Mobile)theMobiles[currentShop.ShopkeeperVNum];
						cboxShpQuickSelect.SelectedItem = currentShop.VNum + " - Shopkeeper: [" + myMobile.VNum + "] " + myMobile.ShortDescription;
					}
					else
					{
						cboxShpQuickSelect.SelectedItem = currentShop.VNum + " - Shopkeeper: [" + currentShop.VNum + "] (Unknown Mobile)";
					}
				}
			}
		}

		private void clearShopEditor()
		{
			lboxShpShopItems.Items.Clear();

			if((nudShpItemVNum.Minimum > 0) || (nudShpItemVNum.Maximum < 0))
			{
				nudShpItemVNum.Value = nudShpItemVNum.Minimum;
			}
			else
			{
				nudShpItemVNum.Value = 0;
			}

			cboxShpAreaItem.Items.Clear();
			lboxShpShopRooms.Items.Clear();

			if((nudShpRoomVNum.Minimum > 0) || (nudShpRoomVNum.Maximum < 0))
			{
				nudShpRoomVNum.Value = nudShpRoomVNum.Minimum;
			}
			else
			{
				nudShpRoomVNum.Value = 0;
			}

			cboxShpAreaRoom.Items.Clear();

			if((nudShpMobileVNum.Minimum > 0) || (nudShpMobileVNum.Maximum < 0))
			{
				nudShpMobileVNum.Value = nudShpMobileVNum.Minimum;
			}
			else
			{
				nudShpMobileVNum.Value = 0;
			}

			cboxShpAreaMobile.Items.Clear();
			foreach(int i in clboxShpShopBitvector.CheckedIndices)
			{
				clboxShpShopBitvector.SetItemChecked(i, false);
			}

			cboxShpShopkeeperTemper.SelectedIndex = defaultShop.ShopkeeperTemper;

			if((nudShpBuyProfit.Minimum > 0) || (nudShpBuyProfit.Maximum < 0))
			{
				nudShpBuyProfit.Value = nudShpBuyProfit.Minimum;
			}
			else
			{
				nudShpBuyProfit.Value = 0;
			}
			if((nudShpSellProfit.Minimum > 0) || (nudShpSellProfit.Maximum < 0))
			{
				nudShpSellProfit.Value = nudShpSellProfit.Minimum;
			}
			else
			{
				nudShpSellProfit.Value = 0;
			}
			if((nudShpOpenTime1.Minimum > 0) || (nudShpOpenTime1.Maximum < 0))
			{
				nudShpOpenTime1.Value = nudShpOpenTime1.Minimum;
			}
			else
			{
				nudShpOpenTime1.Value = 0;
			}
			if((nudShpCloseTime1.Minimum > 0) || (nudShpCloseTime1.Maximum < 0))
			{
				nudShpCloseTime1.Value = nudShpCloseTime1.Minimum;
			}
			else
			{
				nudShpCloseTime1.Value = 0;
			}
			if((nudShpOpenTime2.Minimum > 0) || (nudShpOpenTime2.Maximum < 0))
			{
				nudShpOpenTime2.Value = nudShpOpenTime2.Minimum;
			}
			else
			{
				nudShpOpenTime2.Value = 0;
			}
			if((nudShpCloseTime2.Minimum > 0) || (nudShpCloseTime2.Maximum < 0))
			{
				nudShpCloseTime2.Value = nudShpCloseTime2.Minimum;
			}
			else
			{
				nudShpCloseTime2.Value = 0;
			}

			cbShpAlwaysOpen.Checked = false;

			foreach(int i in clboxShpShopBitvector.CheckedIndices)
			{
				clboxShpShopBitvector.SetItemChecked(i, false);
			}
			for(int i = 0; i < defaultShop.ShopBitvector.Length; i++)
			{
				clboxShpShopBitvector.SetItemChecked(defaultShop.ShopBitvector[i], true);
			}
			foreach(int i in clboxShpBuyTypes.CheckedIndices)
			{
				clboxShpBuyTypes.SetItemChecked(i, false);
			}
			for(int i = 0; i < defaultShop.BuyTypes.Length; i++)
			{
				clboxShpBuyTypes.SetItemChecked(defaultShop.BuyTypes[i], true);
			}
			foreach(int i in clboxShpWillNotSellTo.CheckedIndices)
			{
				clboxShpWillNotSellTo.SetItemChecked(i, false);
			}
			for(int i = 0; i < defaultShop.WillNotSellTo.Length; i++)
			{
				clboxShpWillNotSellTo.SetItemChecked(defaultShop.WillNotSellTo[i], true);
			}

			this.shopEditorUnchanged();
		}

		private void clearZoneEditor()
		{
			lboxZonZoneCommands.Items.Clear();
			cboxZonCommandType.SelectedIndex = defaultZone.CommandType;
			cbZonIfFlag.Checked = false;

			if((nudZonArg0.Minimum > 0) || (nudZonArg0.Maximum < 0))
			{
				nudZonArg0.Value = nudZonArg0.Minimum;
			}
			else
			{
				nudZonArg0.Value = 0;
			}
			cboxZonAreaArg0.Items.Clear();
			if((nudZonArg1.Minimum > 0) || (nudZonArg1.Maximum < 0))
			{
				nudZonArg1.Value = nudZonArg1.Minimum;
			}
			else
			{
				nudZonArg1.Value = 0;
			}
			cboxZonAreaArg1.Items.Clear();
			if((nudZonArg2.Minimum > 0) || (nudZonArg2.Maximum < 0))
			{
				nudZonArg2.Value = nudZonArg2.Minimum;
			}
			else
			{
				nudZonArg2.Value = 0;
			}
            cboxZonAreaArg2.Items.Clear();
			
			tbZonComment.Clear();

			if((nudZonNumber.Minimum > 0) || (nudZonNumber.Maximum < 0))
			{
				nudZonNumber.Value = nudZonNumber.Minimum;
			}
			else
			{
				nudZonNumber.Value = 0;
			}

			tbZonZoneName.Clear();

			if((nudZonBottomRoom.Minimum > 0) || (nudZonBottomRoom.Maximum < 0))
			{
				nudZonBottomRoom.Value = nudZonBottomRoom.Minimum;
			}
			else
			{
				nudZonBottomRoom.Value = 0;
			}
			if((nudZonTopRoom.Minimum > 0) || (nudZonTopRoom.Maximum < 0))
			{
				nudZonTopRoom.Value = nudZonTopRoom.Minimum;
			}
			else
			{
				nudZonTopRoom.Value = 0;
			}
			if((nudZonLifespan.Minimum > 0) || (nudZonLifespan.Maximum < 0))
			{
				nudZonLifespan.Value = nudZonLifespan.Minimum;
			}
			else
			{
				nudZonLifespan.Value = 0;
			}

			cboxZonResetMode.SelectedIndex = defaultZone.ResetMode;

			bZonRemove.Enabled = false;

			this.zoneEditorUnchanged();
		}

		private void miFileCloseArea_Click(object sender, System.EventArgs e)
		{
			bool myCancel = false;

			if(mobFileSaved == false || objFileSaved == false || wldFileSaved == false || shpFileSaved == false || zonFileSaved == false)
			{
				if(MessageBox.Show("File(s) May Not Have Been Saved; Close Anyway?", "File(s) May Not Have Been Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					myCancel = true;
				}
			}

			if(myCancel == false)
			{
				disableMobileEditor();
				clearMobileEditor();
				nudMobVNum.Minimum = defaultMobile.VNumMin;
				nudMobVNum.Maximum = defaultMobile.VNumMax;
				nudMobVNum.Value = nudMobVNum.Minimum;
				cboxMobQuickSelect.Items.Clear();
				disableObjectEditor();
				clearObjectEditor();
				nudObjVNum.Minimum = defaultObject.VNumMin;
				nudObjVNum.Maximum = defaultObject.VNumMax;
				nudObjVNum.Value = nudObjVNum.Minimum;
				cboxObjQuickSelect.Items.Clear();
				disableRoomEditor();
				clearRoomEditor();
				nudWldVNum.Minimum = defaultRoom.VNumMin;
				nudWldVNum.Maximum = defaultRoom.VNumMax;
				nudWldVNum.Value = nudWldVNum.Minimum;
				cboxWldQuickSelect.Items.Clear();
				disableShopEditor();
				clearShopEditor();
				nudShpVNum.Minimum = defaultShop.VNumMin;
				nudShpVNum.Maximum = defaultShop.VNumMax;
				nudShpVNum.Value = nudShpVNum.Minimum;
				cboxShpQuickSelect.Items.Clear();
				disableZoneEditor();
				clearZoneEditor();
				nudZonNumber.Minimum = defaultZone.NumberMin;
				nudZonNumber.Maximum = defaultZone.NumberMax;
				nudZonNumber.Value = nudZonNumber.Minimum;
				theMobiles.Clear();
				theObjects.Clear();
				theRooms.Clear();
				theShops.Clear();
				currentMobile = null;
				currentObject = null;
				currentRoom = null;
				currentShop = null;
				currentZone = null;
				mobChanged = false;
				objChanged = false;
				wldChanged = false;
				shpChanged = false;
				zonChanged = false;
				mobFileSaved = true;
				objFileSaved = true;
				wldFileSaved = true;
				shpFileSaved = true;
				zonFileSaved = true;
				this.mobileEditorUnchanged();
				this.objectEditorUnchanged();
				this.roomEditorUnchanged();
				this.shopEditorUnchanged();
				this.zoneEditorUnchanged();
				miFileNew.Enabled = true;
				miFileNewMobileFile.Enabled = true;
				miFileNewObjectFile.Enabled = true;
				miFileNewWorldFile.Enabled = true;
				miFileNewShopFile.Enabled = true;
				miFileNewZoneFile.Enabled = true;
				miFileOpen.Enabled = true;
				miFileOpenMobileFile.Enabled = true;
				miFileOpenObjectFile.Enabled = true;
				miFileOpenWorldFile.Enabled = true;
				miFileOpenShopFile.Enabled = true;
				miFileOpenZoneFile.Enabled = true;
				miFileClose.Enabled = false;
				miFileSave.Enabled = false;
				miToolsLoadMUDConfiguration.Enabled = true;

				tcEditors.SelectedTab = tpMobileEditor;
			}
		}

		private void miToolsLoadMUDConfiguration_Click(object sender, System.EventArgs e)
		{
			Stream myStream;
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "MUD Configuration Files (*.mudcfg)|*.mudcfg";
			openFileDialog.RestoreDirectory = true;

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if((myStream = openFileDialog.OpenFile()) != null)
				{
					if(this.loadConfig(myStream) == false)
					{
						disableMobileEditor();
						disableObjectEditor();
						disableRoomEditor();
						disableShopEditor();
						disableZoneEditor();

						sbMain.Text = "MUD Configuration File load failure.";
					}
				}
			}
		}

		private void miFileNewShopFile_Click(object sender, System.EventArgs e)
		{
			fInput inputForm = new fInput("Shops Belong to Zone Number:");
			
			if(inputForm.ShowDialog() == DialogResult.OK)
			{
				shpZone = decimal.ToInt32(inputResult);
				bShpNew.Enabled = true;
				miFileNewArea.Enabled = false;
				miFileNewShopFile.Enabled = false;
				miFileOpenArea.Enabled = false;
				miFileOpenShopFile.Enabled = false;
				miFileClose.Enabled = true;
				miFileCloseArea.Enabled = false;
				miFileCloseShopFile.Enabled = true;
				miFileSave.Enabled = true;
				miFileSaveShopFile.Enabled = true;
				miToolsLoadMUDConfiguration.Enabled = false;

				this.shopEditorUnchanged();

				tcEditors.SelectedTab = tpShopEditor;
			}
		}

		private void miFileNewZoneFile_Click(object sender, System.EventArgs e)
		{
			fNewArea newAreaForm = new fNewArea();

			if(newAreaForm.ShowDialog() == DialogResult.OK)
			{
				enableZoneEditor();
				nudZonNumber.Value = currentZoneNumber;
				tbZonZoneName.Text = currentZoneName;
				currentZone = new Zone(currentZoneNumber);

				miFileNewArea.Enabled = false;
				miFileNewZoneFile.Enabled = false;
				miFileOpenArea.Enabled = false;
				miFileOpenZoneFile.Enabled = false;
				miFileClose.Enabled = true;
				miFileCloseArea.Enabled = false;
				miFileCloseZoneFile.Enabled = true;
				miFileSave.Enabled = true;
				miFileSaveZoneFile.Enabled = false;
				miToolsLoadMUDConfiguration.Enabled = false;

				this.zoneEditorUnchanged();

				tcEditors.SelectedTab = tpMobileEditor;
			}
		}

		private void miFileCloseMobileFile_Click(object sender, System.EventArgs e)
		{
			bool myCancel = false;

			if(mobFileSaved == false)
			{
				if(MessageBox.Show("Mobile File Not Saved; Close Anyway?", "Mobile File Not Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					myCancel = true;
				}
			}

			if(myCancel == false)
			{
				disableMobileEditor();
				clearMobileEditor();
				nudMobVNum.Minimum = defaultMobile.VNumMin;
				nudMobVNum.Maximum = defaultMobile.VNumMax;
				nudMobVNum.Value = nudMobVNum.Minimum;
				cboxMobQuickSelect.Items.Clear();
				theMobiles.Clear();
				currentMobile = null;
				mobChanged = false;
				objFileSaved = true;
				this.mobileEditorUnchanged();
				miFileNewMobileFile.Enabled = true;
				miFileOpenMobileFile.Enabled = true;
				miFileCloseMobileFile.Enabled = false;
				miFileSaveMobileFile.Enabled = false;
				this.setMenus();
			}
		}

		private void miFileCloseObjectFile_Click(object sender, System.EventArgs e)
		{
			bool myCancel = false;

			if(objFileSaved == false)
			{
				if(MessageBox.Show("Object File Not Saved; Close Anyway?", "Object File Not Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					myCancel = true;
				}
			}

			if(myCancel == false)
			{
				disableObjectEditor();
				clearObjectEditor();
				nudObjVNum.Minimum = defaultObject.VNumMin;
				nudObjVNum.Maximum = defaultObject.VNumMax;
				nudObjVNum.Value = nudObjVNum.Minimum;
				cboxObjQuickSelect.Items.Clear();
				theObjects.Clear();
				currentObject = null;
				objChanged = false;
				objFileSaved = true;
				this.objectEditorUnchanged();
				miFileNewObjectFile.Enabled = true;
				miFileOpenObjectFile.Enabled = true;
				miFileCloseObjectFile.Enabled = false;
				miFileSaveObjectFile.Enabled = false;
				this.setMenus();
			}
		}

		private void miFileCloseWorldFile_Click(object sender, System.EventArgs e)
		{
			bool myCancel = false;

			if(wldFileSaved == false)
			{
				if(MessageBox.Show("World File Not Saved; Close Anyway?", "World File Not Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					myCancel = true;
				}
			}

			if(myCancel == false)
			{
				disableRoomEditor();
				clearRoomEditor();
				nudWldVNum.Minimum = defaultRoom.VNumMin;
				nudWldVNum.Maximum = defaultRoom.VNumMax;
				nudWldVNum.Value = nudWldVNum.Minimum;
				cboxWldQuickSelect.Items.Clear();
				theRooms.Clear();
				currentRoom = null;
				wldChanged = false;
				wldFileSaved = true;
				this.roomEditorUnchanged();
				miFileNewWorldFile.Enabled = true;
				miFileOpenWorldFile.Enabled = true;
				miFileCloseWorldFile.Enabled = false;
				miFileSaveWorldFile.Enabled = false;
				this.setMenus();
			}
		}

		private void miFileCloseShopFile_Click(object sender, System.EventArgs e)
		{
			bool myCancel = false;

			if(shpFileSaved == false)
			{
				if(MessageBox.Show("Shop File Not Saved; Close Anyway?", "Shop File Not Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					myCancel = true;
				}
			}

			if(myCancel == false)
			{
				disableShopEditor();
				clearShopEditor();
				nudShpVNum.Minimum = defaultShop.VNumMin;
				nudShpVNum.Maximum = defaultShop.VNumMax;
				nudShpVNum.Value = nudShpVNum.Minimum;
				cboxShpQuickSelect.Items.Clear();
				theShops.Clear();
				currentShop = null;
				shpChanged = false;
				shpFileSaved = true;
				this.shopEditorUnchanged();
				miFileNewShopFile.Enabled = true;
				miFileOpenShopFile.Enabled = true;
				miFileCloseShopFile.Enabled = false;
				miFileSaveShopFile.Enabled = false;
				this.setMenus();
			}
		}

		private void miFileCloseZoneFile_Click(object sender, System.EventArgs e)
		{
			bool myCancel = false;

			if(zonFileSaved == false)
			{
				if(MessageBox.Show("Zone File Not Saved; Close Anyway?", "Zone File Not Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					myCancel = true;
				}
			}

			if(myCancel == false)
			{
				disableZoneEditor();
				clearZoneEditor();
				nudZonNumber.Minimum = defaultZone.NumberMin;
				nudZonNumber.Maximum = defaultZone.NumberMax;
				nudZonNumber.Value = nudZonNumber.Minimum;
				currentZone = null;
				zonChanged = false;
				zonFileSaved = true;
				this.zoneEditorUnchanged();
				miFileNewZoneFile.Enabled = true;
				miFileOpenZoneFile.Enabled = true;
				miFileCloseZoneFile.Enabled = false;
				miFileSaveZoneFile.Enabled = false;
				this.setMenus();
			}
		}

		private void miHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(Application.ProductName + "\n\nVersion: " + Application.ProductVersion + "\n\nCopyright 1999-2004: " + Application.CompanyName, "About " + Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void nudWldDoorKey_ValueChanged(object sender, System.EventArgs e)
		{
			if(valueChanging == false)
			{
				valueChanging = true;
				cboxWldAreaDoorKey.SelectedIndex = theObjects.IndexOfKey(decimal.ToInt64(nudWldDoorKey.Value));

				if(loadingExit == false)
				{
					this.roomEditorChanged(null, null);
				}
				valueChanging = false;
			}
		}

		private void cboxWldAreaDoorKey_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(valueChanging == false)
			{
				valueChanging = true;
				nudWldDoorKey.Value = ((Object)theObjects.GetByIndex(cboxWldAreaDoorKey.SelectedIndex)).VNum;

				if(loadingExit == false)
				{
					this.roomEditorChanged(null, null);
				}
				valueChanging = false;
			}
		}

		private void setMenus()
		{
			if(miFileNewArea.Enabled == false && miFileNewMobileFile.Enabled == true && miFileNewObjectFile.Enabled == true && miFileNewWorldFile.Enabled == true && miFileNewShopFile.Enabled == true && miFileNewZoneFile.Enabled == true)
			{
				miFileNewArea.Enabled = true;
			}
			if(miFileOpenArea.Enabled == false && miFileOpenMobileFile.Enabled == true && miFileOpenObjectFile.Enabled == true && miFileOpenWorldFile.Enabled == true && miFileOpenShopFile.Enabled == true && miFileOpenZoneFile.Enabled == true)
			{
				miFileOpenArea.Enabled = true;
			}
			if(miFileCloseArea.Enabled == false && miFileCloseMobileFile.Enabled == false && miFileCloseObjectFile.Enabled == false && miFileCloseWorldFile.Enabled == false && miFileCloseShopFile.Enabled == false && miFileCloseZoneFile.Enabled == false)
			{
				miFileClose.Enabled = false;
			}
			if(miFileSaveArea.Enabled == false && miFileSaveMobileFile.Enabled == false && miFileSaveObjectFile.Enabled == false && miFileSaveWorldFile.Enabled == false && miFileSaveShopFile.Enabled == false && miFileSaveZoneFile.Enabled == false)
			{
				miFileSave.Enabled = false;
			}
			if(miFileNewArea.Enabled == true && miFileOpenArea.Enabled == true && miFileClose.Enabled == false && miFileSave.Enabled == false)
			{
				miToolsLoadMUDConfiguration.Enabled = true;
			}
		}

		private bool saveZone()
		{
			currentZone.Number = decimal.ToInt32(nudZonNumber.Value);
			currentZone.Name = tbZonZoneName.Text;
			currentZone.BottomRoom = decimal.ToInt64(nudZonBottomRoom.Value);
			currentZone.TopRoom = decimal.ToInt64(nudZonTopRoom.Value);
			currentZone.Lifespan = decimal.ToInt32(nudZonLifespan.Value);
			currentZone.ResetMode = int.Parse(zonResetModes[zonResetModes.IndexOf(cboxZonResetMode.SelectedItem.ToString()) - 1]);

			this.zoneEditorUnchanged();

			return true;
		}

		private void miToolsAutoGenerateComments_Click(object sender, System.EventArgs e)
		{
			if(miToolsAutoGenerateComments.Checked == true)
			{
				miToolsAutoGenerateComments.Checked = false;
				autoGenComment = false;
			}
			else
			{
				miToolsAutoGenerateComments.Checked = true;
				autoGenComment = true;
			}
		}

		private void mobileEditorChanged(object sender, System.EventArgs e)
		{
			if(currentMobile != null)
			{
				mobChanged = true;
				mobFileSaved = false;
				if(tpMobileEditor.Text.EndsWith("*") == false)
				{
					tpMobileEditor.Text += "*";
				}
			}
		}

		private void mobileEditorUnchanged()
		{
			if(currentMobile != null)
			{
				mobChanged = false;
			}
			if(tpMobileEditor.Text.EndsWith("*") == true)
			{
				tpMobileEditor.Text = tpMobileEditor.Text.Substring(0, (tpMobileEditor.Text.Length - 1));
			}
		}

		private void objectEditorChanged(object sender, System.EventArgs e)
		{
			if(currentObject != null)
			{
				objChanged = true;
				objFileSaved = false;
				if(tpObjectEditor.Text.EndsWith("*") == false)
				{
					tpObjectEditor.Text += "*";
				}
			}
		}

		private void objectEditorUnchanged()
		{
			if(currentObject != null)
			{
				objChanged = false;
			}
			if(tpObjectEditor.Text.EndsWith("*") == true)
			{
				tpObjectEditor.Text = tpObjectEditor.Text.Substring(0, (tpObjectEditor.Text.Length - 1));
			}
		}

		private void roomEditorChanged(object sender, System.EventArgs e)
		{
			if(currentRoom != null)
			{
				wldChanged = true;
				wldFileSaved = false;
				if(tpRoomEditor.Text.EndsWith("*") == false)
				{
					tpRoomEditor.Text += "*";
				}
			}
		}

		private void roomEditorUnchanged()
		{
			if(currentRoom != null)
			{
				wldChanged = false;
			}
			if(tpRoomEditor.Text.EndsWith("*") == true)
			{
				tpRoomEditor.Text = tpRoomEditor.Text.Substring(0, (tpRoomEditor.Text.Length - 1));
			}
		}

		private void shopEditorChanged(object sender, System.EventArgs e)
		{
			if(currentShop != null)
			{
				shpChanged = true;
				shpFileSaved = false;
				if(tpShopEditor.Text.EndsWith("*") == false)
				{
					tpShopEditor.Text += "*";
				}
			}
		}

		private void shopEditorUnchanged()
		{
			if(currentShop != null)
			{
				shpChanged = false;
			}
			if(tpShopEditor.Text.EndsWith("*") == true)
			{
				tpShopEditor.Text = tpShopEditor.Text.Substring(0, (tpShopEditor.Text.Length - 1));
			}
		}

		private void zoneEditorChanged(object sender, System.EventArgs e)
		{
			if(currentZone != null)
			{
				zonChanged = true;
				zonFileSaved = false;
				if(tpZoneEditor.Text.EndsWith("*") == false)
				{
					tpZoneEditor.Text += "*";
				}
			}
		}

		private void zoneEditorUnchanged()
		{
			if(currentZone != null)
			{
				zonChanged = false;
			}
			if(tpZoneEditor.Text.EndsWith("*") == true)
			{
				tpZoneEditor.Text = tpZoneEditor.Text.Substring(0, (tpZoneEditor.Text.Length - 1));
			}
		}

		private void bZonInsert_Click(object sender, System.EventArgs e)
		{
			this.zoneEditorChanged(null, null);
		}
	}
}
