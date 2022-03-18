using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ferroseed Species to store common natural stats of all Ferroseeds
	#region SpeciesFerroseed
	public class SpeciesFerroseed : PokemonSpecies
	{
#nullable enable
		private static SpeciesFerroseed? _instance = null;
#nullable restore
        public static SpeciesFerroseed Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFerroseed();
                }
                return _instance;
            }
        }

		#region SpeciesFerroseed Constructor
		public SpeciesFerroseed() : base(
			597,
			"Ferroseed",
			0.6,
			18.8,
			44, // HPs
			50, 91, // Attack & Defense
			24, 86, // Special Attack & Defense
			10		
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
				"Pin-Missile",
				"Leech-Seed",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
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
				"Spikes",
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
				"Bullet-Seed",
				"Iron-Defense",
				"Gravity",
				"Gyro-Ball",
				"Payback",
				"Worry-Seed",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Mirror-Shot",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stealth-Rock",
				"Hone-Claws",
				"Acid-Spray",
				"Round",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Ferroseed PokemonInstance Class
	#region Ferroseed
	public class FerroseedInstance : PokemonInstance
	{
		#region Ferroseed Constructors
		/// <summary>
		/// Ferroseed Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FerroseedInstance(string nickname, int level)
		: base(
				SpeciesFerroseed.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferroseed Builder only waiting for a Level
		/// </summary>
		public FerroseedInstance(int level)
		: base(
				SpeciesFerroseed.Instance, // PokemonInstance Species
				"Ferroseed", level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferroseed Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public FerroseedInstance() : base(
			SpeciesFerroseed.Instance, // PokemonInstance Species
			Grass.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}