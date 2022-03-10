using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Empoleon Species to store common natural stats of all Empoleons
	#region SpeciesEmpoleon
	public class SpeciesEmpoleon : PokemonSpecies
	{
#nullable enable
		private static SpeciesEmpoleon? _instance = null;
#nullable restore
        public static SpeciesEmpoleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEmpoleon();
                }
                return _instance;
            }
        }

		#region SpeciesEmpoleon Constructor
		public SpeciesEmpoleon() : base(
			"Empoleon",
			1.7,
			84.5,
			84, // HPs
			86, 88, // Attack & Defense
			111, 101, // Special Attack & Defense
			60		
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Fury-Attack",
				"Tackle",
				"Growl",
				"Roar",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Peck",
				"Drill-Peck",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Hydro-Cannon",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Covet",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Fling",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Flash-Cannon",
				"Rock-Climb",
				"Defog",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Aqua-Jet",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Quash",
				"Water-Pledge",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Empoleon PokemonInstance Class
	#region Empoleon
	public class EmpoleonInstance : PokemonInstance
	{
		#region Empoleon Constructors
		/// <summary>
		/// Empoleon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EmpoleonInstance(string nickname, int level)
		: base(
				395,
				SpeciesEmpoleon.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Empoleon Builder only waiting for a Level
		/// </summary>
		public EmpoleonInstance(int level)
		: base(
				395,
				SpeciesEmpoleon.Instance, // PokemonInstance Species
				"Empoleon", level,
				Water.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Empoleon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Empoleon() : base(
			395,
			SpeciesEmpoleon.Instance, // PokemonInstance Species
			Water.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}