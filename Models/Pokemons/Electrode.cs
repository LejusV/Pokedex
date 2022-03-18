using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Electrode Species to store common natural stats of all Electrodes
	#region SpeciesElectrode
	public class SpeciesElectrode : PokemonSpecies
	{
#nullable enable
		private static SpeciesElectrode? _instance = null;
#nullable restore
        public static SpeciesElectrode Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesElectrode();
                }
                return _instance;
            }
        }

		#region SpeciesElectrode Constructor
		public SpeciesElectrode() : base(
			101,
			"Electrode",
			1.2,
			66.6,
			60, // HPs
			50, 70, // Attack & Defense
			80, 80, // Special Attack & Defense
			150		
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
				"Hyper-Beam",
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
				"Skull-Bash",
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
				"Giga-Impact",
				"Discharge",
				"Charge-Beam",
				"Electro-Ball",
				"Foul-Play",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Confide",
				"Eerie-Impulse",
				"Magnetic-Flux"
			};
		}
		#endregion
	}
	#endregion

	//Electrode PokemonInstance Class
	#region Electrode
	public class ElectrodeInstance : PokemonInstance
	{
		#region Electrode Constructors
		/// <summary>
		/// Electrode Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ElectrodeInstance(string nickname, int level)
		: base(
				SpeciesElectrode.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrode Builder only waiting for a Level
		/// </summary>
		public ElectrodeInstance(int level)
		: base(
				SpeciesElectrode.Instance, // PokemonInstance Species
				"Electrode", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrode Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ElectrodeInstance() : base(
			SpeciesElectrode.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}