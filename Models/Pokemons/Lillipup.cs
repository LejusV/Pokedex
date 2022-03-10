using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lillipup Species to store common natural stats of all Lillipups
	#region SpeciesLillipup
	public class SpeciesLillipup : PokemonSpecies
	{
#nullable enable
		private static SpeciesLillipup? _instance = null;
#nullable restore
        public static SpeciesLillipup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLillipup();
                }
                return _instance;
            }
        }

		#region SpeciesLillipup Constructor
		public SpeciesLillipup() : base(
			"Lillipup",
			0.4,
			4.1,
			45, // HPs
			60, 45, // Attack & Defense
			25, 45, // Special Attack & Defense
			55		
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
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Leer",
				"Bite",
				"Roar",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Rest",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Yawn",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Aerial-Ace",
				"Howl",
				"Covet",
				"Shock-Wave",
				"Last-Resort",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Play-Rough",
				"Confide",
				"Baby-Doll-Eyes",
				"Psychic-Fangs"
			};
		}
		#endregion
	}
	#endregion

	//Lillipup PokemonInstance Class
	#region Lillipup
	public class LillipupInstance : PokemonInstance
	{
		#region Lillipup Constructors
		/// <summary>
		/// Lillipup Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LillipupInstance(string nickname, int level)
		: base(
				506,
				SpeciesLillipup.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lillipup Builder only waiting for a Level
		/// </summary>
		public LillipupInstance(int level)
		: base(
				506,
				SpeciesLillipup.Instance, // PokemonInstance Species
				"Lillipup", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lillipup Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Lillipup() : base(
			506,
			SpeciesLillipup.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}