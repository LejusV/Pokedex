using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Magnezone Species to store common natural stats of all Magnezones
	#region SpeciesMagnezone
	public class SpeciesMagnezone : PokemonSpecies
	{
#nullable enable
		private static SpeciesMagnezone? _instance = null;
#nullable restore
        public static SpeciesMagnezone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMagnezone();
                }
                return _instance;
            }
        }

		#region SpeciesMagnezone Constructor
		public SpeciesMagnezone() : base(
			"Magnezone",
			1.2,
			180.0,
			70, // HPs
			70, 115, // Attack & Defense
			130, 90, // Special Attack & Defense
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
				"Supersonic",
				"Sonic-Boom",
				"Hyper-Beam",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Screech",
				"Double-Team",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Flash",
				"Explosion",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Protect",
				"Zap-Cannon",
				"Lock-On",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Psych-Up",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Metal-Sound",
				"Signal-Beam",
				"Iron-Defense",
				"Shock-Wave",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Magnet-Rise",
				"Giga-Impact",
				"Mirror-Shot",
				"Flash-Cannon",
				"Discharge",
				"Iron-Head",
				"Magnet-Bomb",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide",
				"Magnetic-Flux",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Magnezone PokemonInstance Class
	#region Magnezone
	public class MagnezoneInstance : PokemonInstance
	{
		#region Magnezone Constructors
		/// <summary>
		/// Magnezone Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MagnezoneInstance(string nickname, int level)
		: base(
				462,
				SpeciesMagnezone.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnezone Builder only waiting for a Level
		/// </summary>
		public MagnezoneInstance(int level)
		: base(
				462,
				SpeciesMagnezone.Instance, // PokemonInstance Species
				"Magnezone", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnezone Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Magnezone() : base(
			462,
			SpeciesMagnezone.Instance, // PokemonInstance Species
			Electric.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}