using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ferrothorn Species to store common natural stats of all Ferrothorns
	#region SpeciesFerrothorn
	public class SpeciesFerrothorn : PokemonSpecies
	{
#nullable enable
		private static SpeciesFerrothorn? _instance = null;
#nullable restore
        public static SpeciesFerrothorn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFerrothorn();
                }
                return _instance;
            }
        }

		#region SpeciesFerrothorn Constructor
		public SpeciesFerrothorn() : base(
			"Ferrothorn",
			1.0,
			110.0,
			74, // HPs
			94, 131, // Attack & Defense
			54, 116, // Special Attack & Defense
			20		
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
				"Tackle",
				"Pin-Missile",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Harden",
				"Self-Destruct",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sandstorm",
				"Giga-Drain",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Gravity",
				"Gyro-Ball",
				"Payback",
				"Worry-Seed",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Mirror-Shot",
				"Flash-Cannon",
				"Rock-Climb",
				"Power-Whip",
				"Iron-Head",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Ferrothorn PokemonInstance Class
	#region Ferrothorn
	public class FerrothornInstance : PokemonInstance
	{
		#region Ferrothorn Constructors
		/// <summary>
		/// Ferrothorn Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FerrothornInstance(string nickname, int level)
		: base(
				598,
				SpeciesFerrothorn.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferrothorn Builder only waiting for a Level
		/// </summary>
		public FerrothornInstance(int level)
		: base(
				598,
				SpeciesFerrothorn.Instance, // PokemonInstance Species
				"Ferrothorn", level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferrothorn Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Ferrothorn() : base(
			598,
			SpeciesFerrothorn.Instance, // PokemonInstance Species
			Grass.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}