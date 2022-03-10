using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Voltorb Species to store common natural stats of all Voltorbs
	#region SpeciesVoltorb
	public class SpeciesVoltorb : PokemonSpecies
	{
#nullable enable
		private static SpeciesVoltorb? _instance = null;
#nullable restore
        public static SpeciesVoltorb Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVoltorb();
                }
                return _instance;
            }
        }

		#region SpeciesVoltorb Constructor
		public SpeciesVoltorb() : base(
			"Voltorb",
			0.5,
			10.4,
			40, // HPs
			30, 50, // Attack & Defense
			55, 55, // Special Attack & Defense
			100		
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
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Sonic-Boom",
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
				"Self-Destruct",
				"Swift",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Torment",
				"Facade",
				"Charge",
				"Taunt",
				"Magic-Coat",
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Gyro-Ball",
				"Natural-Gift",
				"Sucker-Punch",
				"Magnet-Rise",
				"Discharge",
				"Charge-Beam",
				"Electro-Ball",
				"Foul-Play",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Confide",
				"Eerie-Impulse"
			};
		}
		#endregion
	}
	#endregion

	//Voltorb PokemonInstance Class
	#region Voltorb
	public class VoltorbInstance : PokemonInstance
	{
		#region Voltorb Constructors
		/// <summary>
		/// Voltorb Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VoltorbInstance(string nickname, int level)
		: base(
				100,
				SpeciesVoltorb.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Voltorb Builder only waiting for a Level
		/// </summary>
		public VoltorbInstance(int level)
		: base(
				100,
				SpeciesVoltorb.Instance, // PokemonInstance Species
				"Voltorb", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Voltorb Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Voltorb() : base(
			100,
			SpeciesVoltorb.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}