using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Trubbish Species to store common natural stats of all Trubbishs
	#region SpeciesTrubbish
	public class SpeciesTrubbish : PokemonSpecies
	{
#nullable enable
		private static SpeciesTrubbish? _instance = null;
#nullable restore
        public static SpeciesTrubbish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTrubbish();
                }
                return _instance;
            }
        }

		#region SpeciesTrubbish Constructor
		public SpeciesTrubbish() : base(
			568,
			"Trubbish",
			0.6,
			31.0,
			50, // HPs
			50, 62, // Attack & Defense
			40, 62, // Special Attack & Defense
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
				"Pound",
				"Double-Slap",
				"Sand-Attack",
				"Take-Down",
				"Toxic",
				"Double-Team",
				"Haze",
				"Self-Destruct",
				"Sludge",
				"Amnesia",
				"Poison-Gas",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Spikes",
				"Giga-Drain",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Stockpile",
				"Swallow",
				"Facade",
				"Recycle",
				"Secret-Power",
				"Mud-Sport",
				"Rock-Blast",
				"Payback",
				"Toxic-Spikes",
				"Dark-Pulse",
				"Seed-Bomb",
				"Drain-Punch",
				"Gunk-Shot",
				"Venoshock",
				"Autotomize",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Clear-Smog",
				"Belch",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Trubbish PokemonInstance Class
	#region Trubbish
	public class TrubbishInstance : PokemonInstance
	{
		#region Trubbish Constructors
		/// <summary>
		/// Trubbish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TrubbishInstance(string nickname, int level)
		: base(
				SpeciesTrubbish.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trubbish Builder only waiting for a Level
		/// </summary>
		public TrubbishInstance(int level)
		: base(
				SpeciesTrubbish.Instance, // PokemonInstance Species
				"Trubbish", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trubbish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TrubbishInstance() : base(
			SpeciesTrubbish.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}