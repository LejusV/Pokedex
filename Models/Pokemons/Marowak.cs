using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Marowak Species to store common natural stats of all Marowaks
	#region SpeciesMarowak
	public class SpeciesMarowak : PokemonSpecies
	{
#nullable enable
		private static SpeciesMarowak? _instance = null;
#nullable restore
        public static SpeciesMarowak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMarowak();
                }
                return _instance;
            }
        }

		#region SpeciesMarowak Constructor
		public SpeciesMarowak() : base(
			"Marowak",
			1.0,
			45.0,
			60, // HPs
			80, 110, // Attack & Defense
			50, 80, // Special Attack & Defense
			45		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Growl",
				"Flamethrower",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Bone-Club",
				"Fire-Blast",
				"Skull-Bash",
				"Bonemerang",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Bone-Rush",
				"Outrage",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion

	//Marowak PokemonInstance Class
	#region Marowak
	public class MarowakInstance : PokemonInstance
	{
		#region Marowak Constructors
		/// <summary>
		/// Marowak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MarowakInstance(string nickname, int level)
		: base(
				105,
				SpeciesMarowak.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marowak Builder only waiting for a Level
		/// </summary>
		public MarowakInstance(int level)
		: base(
				105,
				SpeciesMarowak.Instance, // PokemonInstance Species
				"Marowak", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marowak Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Marowak() : base(
			105,
			SpeciesMarowak.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}