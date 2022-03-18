using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vigoroth Species to store common natural stats of all Vigoroths
	#region SpeciesVigoroth
	public class SpeciesVigoroth : PokemonSpecies
	{
#nullable enable
		private static SpeciesVigoroth? _instance = null;
#nullable restore
        public static SpeciesVigoroth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVigoroth();
                }
                return _instance;
            }
        }

		#region SpeciesVigoroth Constructor
		public SpeciesVigoroth() : base(
			288,
			"Vigoroth",
			1.4,
			46.5,
			80, // HPs
			80, 80, // Attack & Defense
			55, 55, // Special Attack & Defense
			90		
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
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Sucker-Punch",
				"Focus-Blast",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"Low-Sweep",
				"After-You",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Vigoroth PokemonInstance Class
	#region Vigoroth
	public class VigorothInstance : PokemonInstance
	{
		#region Vigoroth Constructors
		/// <summary>
		/// Vigoroth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VigorothInstance(string nickname, int level)
		: base(
				SpeciesVigoroth.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vigoroth Builder only waiting for a Level
		/// </summary>
		public VigorothInstance(int level)
		: base(
				SpeciesVigoroth.Instance, // PokemonInstance Species
				"Vigoroth", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vigoroth Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VigorothInstance() : base(
			SpeciesVigoroth.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}