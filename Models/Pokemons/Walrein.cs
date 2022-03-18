using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Walrein Species to store common natural stats of all Walreins
	#region SpeciesWalrein
	public class SpeciesWalrein : PokemonSpecies
	{
#nullable enable
		private static SpeciesWalrein? _instance = null;
#nullable restore
        public static SpeciesWalrein Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWalrein();
                }
                return _instance;
            }
        }

		#region SpeciesWalrein Constructor
		public SpeciesWalrein() : base(
			365,
			"Walrein",
			1.4,
			150.6,
			110, // HPs
			80, 90, // Attack & Defense
			95, 90, // Special Attack & Defense
			65		
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Roar",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Ice-Ball",
				"Rock-Tomb",
				"Signal-Beam",
				"Sheer-Cold",
				"Block",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Tail",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Iron-Head",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Walrein PokemonInstance Class
	#region Walrein
	public class WalreinInstance : PokemonInstance
	{
		#region Walrein Constructors
		/// <summary>
		/// Walrein Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WalreinInstance(string nickname, int level)
		: base(
				SpeciesWalrein.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Walrein Builder only waiting for a Level
		/// </summary>
		public WalreinInstance(int level)
		: base(
				SpeciesWalrein.Instance, // PokemonInstance Species
				"Walrein", level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Walrein Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WalreinInstance() : base(
			SpeciesWalrein.Instance, // PokemonInstance Species
			Ice.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}