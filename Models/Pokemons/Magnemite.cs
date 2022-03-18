using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Magnemite Species to store common natural stats of all Magnemites
	#region SpeciesMagnemite
	public class SpeciesMagnemite : PokemonSpecies
	{
#nullable enable
		private static SpeciesMagnemite? _instance = null;
#nullable restore
        public static SpeciesMagnemite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMagnemite();
                }
                return _instance;
            }
        }

		#region SpeciesMagnemite Constructor
		public SpeciesMagnemite() : base(
			81,
			"Magnemite",
			0.3,
			6.0,
			25, // HPs
			35, 70, // Attack & Defense
			95, 55, // Special Attack & Defense
			45		
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
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Magnemite PokemonInstance Class
	#region Magnemite
	public class MagnemiteInstance : PokemonInstance
	{
		#region Magnemite Constructors
		/// <summary>
		/// Magnemite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MagnemiteInstance(string nickname, int level)
		: base(
				SpeciesMagnemite.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnemite Builder only waiting for a Level
		/// </summary>
		public MagnemiteInstance(int level)
		: base(
				SpeciesMagnemite.Instance, // PokemonInstance Species
				"Magnemite", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnemite Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MagnemiteInstance() : base(
			SpeciesMagnemite.Instance, // PokemonInstance Species
			Electric.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}