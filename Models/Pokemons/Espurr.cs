using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Espurr Species to store common natural stats of all Espurrs
	#region SpeciesEspurr
	public class SpeciesEspurr : PokemonSpecies
	{
#nullable enable
		private static SpeciesEspurr? _instance = null;
#nullable restore
        public static SpeciesEspurr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEspurr();
                }
                return _instance;
            }
        }

		#region SpeciesEspurr Constructor
		public SpeciesEspurr() : base(
			677,
			"Espurr",
			0.3,
			3.5,
			62, // HPs
			48, 54, // Attack & Defense
			63, 60, // Special Attack & Defense
			68		
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
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Swagger",
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
				"Fake-Out",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Assist",
				"Magic-Coat",
				"Recycle",
				"Yawn",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Payback",
				"Dark-Pulse",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Disarming-Voice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Espurr PokemonInstance Class
	#region Espurr
	public class EspurrInstance : PokemonInstance
	{
		#region Espurr Constructors
		/// <summary>
		/// Espurr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EspurrInstance(string nickname, int level)
		: base(
				SpeciesEspurr.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espurr Builder only waiting for a Level
		/// </summary>
		public EspurrInstance(int level)
		: base(
				SpeciesEspurr.Instance, // PokemonInstance Species
				"Espurr", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espurr Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public EspurrInstance() : base(
			SpeciesEspurr.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}