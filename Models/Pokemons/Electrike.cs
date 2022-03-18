using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Electrike Species to store common natural stats of all Electrikes
	#region SpeciesElectrike
	public class SpeciesElectrike : PokemonSpecies
	{
#nullable enable
		private static SpeciesElectrike? _instance = null;
#nullable restore
        public static SpeciesElectrike Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesElectrike();
                }
                return _instance;
            }
        }

		#region SpeciesElectrike Constructor
		public SpeciesElectrike() : base(
			309,
			"Electrike",
			0.6,
			15.2,
			40, // HPs
			45, 40, // Attack & Defense
			65, 40, // Special Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Uproar",
				"Facade",
				"Charge",
				"Secret-Power",
				"Odor-Sleuth",
				"Signal-Beam",
				"Howl",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Switcheroo",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Flame-Burst",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Eerie-Impulse"
			};
		}
		#endregion
	}
	#endregion

	//Electrike PokemonInstance Class
	#region Electrike
	public class ElectrikeInstance : PokemonInstance
	{
		#region Electrike Constructors
		/// <summary>
		/// Electrike Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ElectrikeInstance(string nickname, int level)
		: base(
				SpeciesElectrike.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrike Builder only waiting for a Level
		/// </summary>
		public ElectrikeInstance(int level)
		: base(
				SpeciesElectrike.Instance, // PokemonInstance Species
				"Electrike", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrike Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ElectrikeInstance() : base(
			SpeciesElectrike.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}