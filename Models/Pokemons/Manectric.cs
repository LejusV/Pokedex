using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Manectric Species to store common natural stats of all Manectrics
	#region SpeciesManectric
	public class SpeciesManectric : PokemonSpecies
	{
#nullable enable
		private static SpeciesManectric? _instance = null;
#nullable restore
        public static SpeciesManectric Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesManectric();
                }
                return _instance;
            }
        }

		#region SpeciesManectric Constructor
		public SpeciesManectric() : base(
			"Manectric",
			1.5,
			40.2,
			70, // HPs
			75, 60, // Attack & Defense
			105, 60, // Special Attack & Defense
			105		
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
				"Hyper-Beam",
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
				"Uproar",
				"Facade",
				"Charge",
				"Secret-Power",
				"Overheat",
				"Odor-Sleuth",
				"Signal-Beam",
				"Howl",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Giga-Impact",
				"Thunder-Fang",
				"Fire-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Manectric PokemonInstance Class
	#region Manectric
	public class ManectricInstance : PokemonInstance
	{
		#region Manectric Constructors
		/// <summary>
		/// Manectric Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ManectricInstance(string nickname, int level)
		: base(
				310,
				SpeciesManectric.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manectric Builder only waiting for a Level
		/// </summary>
		public ManectricInstance(int level)
		: base(
				310,
				SpeciesManectric.Instance, // PokemonInstance Species
				"Manectric", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manectric Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Manectric() : base(
			310,
			SpeciesManectric.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}