using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lombre Species to store common natural stats of all Lombres
	#region SpeciesLombre
	public class SpeciesLombre : PokemonSpecies
	{
#nullable enable
		private static SpeciesLombre? _instance = null;
#nullable restore
        public static SpeciesLombre Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLombre();
                }
                return _instance;
            }
        }

		#region SpeciesLombre Constructor
		public SpeciesLombre() : base(
			271,
			"Lombre",
			1.2,
			32.5,
			60, // HPs
			50, 50, // Attack & Defense
			60, 70, // Special Attack & Defense
			50		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Strength",
				"Absorb",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Bubble",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Whirlpool",
				"Fake-Out",
				"Uproar",
				"Hail",
				"Facade",
				"Nature-Power",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Astonish",
				"Bullet-Seed",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Lombre PokemonInstance Class
	#region Lombre
	public class LombreInstance : PokemonInstance
	{
		#region Lombre Constructors
		/// <summary>
		/// Lombre Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LombreInstance(string nickname, int level)
		: base(
				SpeciesLombre.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lombre Builder only waiting for a Level
		/// </summary>
		public LombreInstance(int level)
		: base(
				SpeciesLombre.Instance, // PokemonInstance Species
				"Lombre", level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lombre Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LombreInstance() : base(
			SpeciesLombre.Instance, // PokemonInstance Species
			Water.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}