using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Magneton Species to store common natural stats of all Magnetons
	#region SpeciesMagneton
	public class SpeciesMagneton : PokemonSpecies
	{
#nullable enable
		private static SpeciesMagneton? _instance = null;
#nullable restore
        public static SpeciesMagneton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMagneton();
                }
                return _instance;
            }
        }

		#region SpeciesMagneton Constructor
		public SpeciesMagneton() : base(
			"Magneton",
			1.0,
			60.0,
			50, // HPs
			60, 95, // Attack & Defense
			120, 70, // Special Attack & Defense
			70		
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
				"Double-Edge",
				"Supersonic",
				"Sonic-Boom",
				"Hyper-Beam",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Rage",
				"Teleport",
				"Mimic",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Flash",
				"Explosion",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Curse",
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
				"Magnet-Bomb",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Magneton PokemonInstance Class
	#region Magneton
	public class MagnetonInstance : PokemonInstance
	{
		#region Magneton Constructors
		/// <summary>
		/// Magneton Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MagnetonInstance(string nickname, int level)
		: base(
				82,
				SpeciesMagneton.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magneton Builder only waiting for a Level
		/// </summary>
		public MagnetonInstance(int level)
		: base(
				82,
				SpeciesMagneton.Instance, // PokemonInstance Species
				"Magneton", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magneton Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Magneton() : base(
			82,
			SpeciesMagneton.Instance, // PokemonInstance Species
			Electric.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}