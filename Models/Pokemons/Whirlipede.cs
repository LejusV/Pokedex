using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Whirlipede Species to store common natural stats of all Whirlipedes
	#region SpeciesWhirlipede
	public class SpeciesWhirlipede : PokemonSpecies
	{
#nullable enable
		private static SpeciesWhirlipede? _instance = null;
#nullable restore
        public static SpeciesWhirlipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWhirlipede();
                }
                return _instance;
            }
        }

		#region SpeciesWhirlipede Constructor
		public SpeciesWhirlipede() : base(
			"Whirlipede",
			1.2,
			58.5,
			40, // HPs
			55, 99, // Attack & Defense
			40, 79, // Special Attack & Defense
			47		
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
				"Double-Edge",
				"Poison-Sting",
				"Solar-Beam",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Signal-Beam",
				"Iron-Defense",
				"Poison-Tail",
				"Gyro-Ball",
				"Payback",
				"Poison-Jab",
				"Rock-Climb",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Steamroller",
				"Confide",
				"Venom-Drench",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Whirlipede PokemonInstance Class
	#region Whirlipede
	public class WhirlipedeInstance : PokemonInstance
	{
		#region Whirlipede Constructors
		/// <summary>
		/// Whirlipede Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WhirlipedeInstance(string nickname, int level)
		: base(
				544,
				SpeciesWhirlipede.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whirlipede Builder only waiting for a Level
		/// </summary>
		public WhirlipedeInstance(int level)
		: base(
				544,
				SpeciesWhirlipede.Instance, // PokemonInstance Species
				"Whirlipede", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whirlipede Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Whirlipede() : base(
			544,
			SpeciesWhirlipede.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}