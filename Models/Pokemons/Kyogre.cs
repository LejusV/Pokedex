using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kyogre Species to store common natural stats of all Kyogres
	#region SpeciesKyogre
	public class SpeciesKyogre : PokemonSpecies
	{
#nullable enable
		private static SpeciesKyogre? _instance = null;
#nullable restore
        public static SpeciesKyogre Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKyogre();
                }
                return _instance;
            }
        }

		#region SpeciesKyogre Constructor
		public SpeciesKyogre() : base(
			382,
			"Kyogre",
			4.5,
			352.0,
			100, // HPs
			100, 90, // Attack & Defense
			150, 140, // Special Attack & Defense
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Waterfall",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Water-Spout",
				"Signal-Beam",
				"Sheer-Cold",
				"Muddy-Water",
				"Block",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
				"Aqua-Tail",
				"Giga-Impact",
				"Avalanche",
				"Iron-Head",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Origin-Pulse"
			};
		}
		#endregion
	}
	#endregion

	//Kyogre PokemonInstance Class
	#region Kyogre
	public class KyogreInstance : PokemonInstance
	{
		#region Kyogre Constructors
		/// <summary>
		/// Kyogre Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KyogreInstance(string nickname, int level)
		: base(
				SpeciesKyogre.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyogre Builder only waiting for a Level
		/// </summary>
		public KyogreInstance(int level)
		: base(
				SpeciesKyogre.Instance, // PokemonInstance Species
				"Kyogre", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyogre Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KyogreInstance() : base(
			SpeciesKyogre.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}