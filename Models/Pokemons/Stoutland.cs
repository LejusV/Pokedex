using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Stoutland Species to store common natural stats of all Stoutlands
	#region SpeciesStoutland
	public class SpeciesStoutland : PokemonSpecies
	{
#nullable enable
		private static SpeciesStoutland? _instance = null;
#nullable restore
        public static SpeciesStoutland Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStoutland();
                }
                return _instance;
            }
        }

		#region SpeciesStoutland Constructor
		public SpeciesStoutland() : base(
			"Stoutland",
			1.2,
			61.0,
			85, // HPs
			110, 90, // Attack & Defense
			45, 90, // Special Attack & Defense
			80		
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
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
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
				"Superpower",
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
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Iron-Head",
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

	//Stoutland PokemonInstance Class
	#region Stoutland
	public class StoutlandInstance : PokemonInstance
	{
		#region Stoutland Constructors
		/// <summary>
		/// Stoutland Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StoutlandInstance(string nickname, int level)
		: base(
				508,
				SpeciesStoutland.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stoutland Builder only waiting for a Level
		/// </summary>
		public StoutlandInstance(int level)
		: base(
				508,
				SpeciesStoutland.Instance, // PokemonInstance Species
				"Stoutland", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stoutland Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Stoutland() : base(
			508,
			SpeciesStoutland.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}