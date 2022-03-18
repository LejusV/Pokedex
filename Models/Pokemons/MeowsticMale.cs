using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Meowstic-Male Species to store common natural stats of all Meowstic-Males
	#region SpeciesMeowstic-Male
	public class SpeciesMeowsticMale : PokemonSpecies
	{
#nullable enable
		private static SpeciesMeowsticMale? _instance = null;
#nullable restore
        public static SpeciesMeowsticMale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMeowsticMale();
                }
                return _instance;
            }
        }

		#region SpeciesMeowstic-Male Constructor
		public SpeciesMeowsticMale() : base(
			678,
			"Meowstic-Male",
			0.6,
			8.5,
			74, // HPs
			48, 76, // Attack & Defense
			83, 81, // Special Attack & Defense
			104		
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
				"Scratch",
				"Cut",
				"Leer",
				"Psybeam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Charm",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Fake-Out",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Miracle-Eye",
				"Payback",
				"Sucker-Punch",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Work-Up",
				"Disarming-Voice",
				"Misty-Terrain",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Meowstic-Male PokemonInstance Class
	#region Meowstic-Male
	public class MeowsticMaleInstance : PokemonInstance
	{
		#region Meowstic-Male Constructors
		/// <summary>
		/// Meowstic-Male Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MeowsticMaleInstance(string nickname, int level)
		: base(
				SpeciesMeowsticMale.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowstic-Male Builder only waiting for a Level
		/// </summary>
		public MeowsticMaleInstance(int level)
		: base(
				SpeciesMeowsticMale.Instance, // PokemonInstance Species
				"Meowstic-Male", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowstic-Male Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MeowsticMaleInstance() : base(
			SpeciesMeowsticMale.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}