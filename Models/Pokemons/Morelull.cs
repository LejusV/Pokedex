using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Morelull Species to store common natural stats of all Morelulls
	#region SpeciesMorelull
	public class SpeciesMorelull : PokemonSpecies
	{
#nullable enable
		private static SpeciesMorelull? _instance = null;
#nullable restore
        public static SpeciesMorelull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMorelull();
                }
                return _instance;
            }
        }

		#region SpeciesMorelull Constructor
		public SpeciesMorelull() : base(
			"Morelull",
			0.2,
			1.5,
			40, // HPs
			35, 55, // Attack & Defense
			65, 75, // Special Attack & Defense
			15		
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
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Amnesia",
				"Dream-Eater",
				"Spore",
				"Flash",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Nature-Power",
				"Ingrain",
				"Astonish",
				"Energy-Ball",
				"Grass-Knot",
				"Round",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Strength-Sap",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion

	//Morelull PokemonInstance Class
	#region Morelull
	public class MorelullInstance : PokemonInstance
	{
		#region Morelull Constructors
		/// <summary>
		/// Morelull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MorelullInstance(string nickname, int level)
		: base(
				755,
				SpeciesMorelull.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morelull Builder only waiting for a Level
		/// </summary>
		public MorelullInstance(int level)
		: base(
				755,
				SpeciesMorelull.Instance, // PokemonInstance Species
				"Morelull", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morelull Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Morelull() : base(
			755,
			SpeciesMorelull.Instance, // PokemonInstance Species
			Grass.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}