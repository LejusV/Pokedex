using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Scolipede Species to store common natural stats of all Scolipedes
	#region SpeciesScolipede
	public class SpeciesScolipede : PokemonSpecies
	{
#nullable enable
		private static SpeciesScolipede? _instance = null;
#nullable restore
        public static SpeciesScolipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesScolipede();
                }
                return _instance;
            }
        }

		#region SpeciesScolipede Constructor
		public SpeciesScolipede() : base(
			"Scolipede",
			2.5,
			200.5,
			60, // HPs
			100, 89, // Attack & Defense
			55, 69, // Special Attack & Defense
			112		
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
				"Double-Edge",
				"Poison-Sting",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
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
				"Megahorn",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Iron-Defense",
				"Poison-Tail",
				"Gyro-Ball",
				"Payback",
				"Poison-Jab",
				"Aqua-Tail",
				"X-Scissor",
				"Giga-Impact",
				"Rock-Climb",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Steamroller",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Scolipede PokemonInstance Class
	#region Scolipede
	public class ScolipedeInstance : PokemonInstance
	{
		#region Scolipede Constructors
		/// <summary>
		/// Scolipede Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ScolipedeInstance(string nickname, int level)
		: base(
				545,
				SpeciesScolipede.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scolipede Builder only waiting for a Level
		/// </summary>
		public ScolipedeInstance(int level)
		: base(
				545,
				SpeciesScolipede.Instance, // PokemonInstance Species
				"Scolipede", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scolipede Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Scolipede() : base(
			545,
			SpeciesScolipede.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}