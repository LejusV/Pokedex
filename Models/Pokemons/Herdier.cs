using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Herdier Species to store common natural stats of all Herdiers
	#region SpeciesHerdier
	public class SpeciesHerdier : PokemonSpecies
	{
#nullable enable
		private static SpeciesHerdier? _instance = null;
#nullable restore
        public static SpeciesHerdier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHerdier();
                }
                return _instance;
            }
        }

		#region SpeciesHerdier Constructor
		public SpeciesHerdier() : base(
			"Herdier",
			0.9,
			14.7,
			65, // HPs
			80, 65, // Attack & Defense
			35, 65, // Special Attack & Defense
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
				"Tackle",
				"Take-Down",
				"Leer",
				"Bite",
				"Roar",
				"Surf",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Payback",
				"Last-Resort",
				"Giga-Impact",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Herdier PokemonInstance Class
	#region Herdier
	public class HerdierInstance : PokemonInstance
	{
		#region Herdier Constructors
		/// <summary>
		/// Herdier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HerdierInstance(string nickname, int level)
		: base(
				507,
				SpeciesHerdier.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Herdier Builder only waiting for a Level
		/// </summary>
		public HerdierInstance(int level)
		: base(
				507,
				SpeciesHerdier.Instance, // PokemonInstance Species
				"Herdier", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Herdier Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Herdier() : base(
			507,
			SpeciesHerdier.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}