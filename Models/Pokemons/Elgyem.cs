using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Elgyem Species to store common natural stats of all Elgyems
	#region SpeciesElgyem
	public class SpeciesElgyem : PokemonSpecies
	{
#nullable enable
		private static SpeciesElgyem? _instance = null;
#nullable restore
        public static SpeciesElgyem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesElgyem();
                }
                return _instance;
            }
        }

		#region SpeciesElgyem Constructor
		public SpeciesElgyem() : base(
			605,
			"Elgyem",
			0.5,
			9.0,
			55, // HPs
			55, 55, // Attack & Defense
			85, 55, // Special Attack & Defense
			30		
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
				"Growl",
				"Disable",
				"Psybeam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Teleport",
				"Double-Team",
				"Recover",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Cosmic-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Miracle-Eye",
				"Embargo",
				"Heal-Block",
				"Power-Swap",
				"Guard-Swap",
				"Dark-Pulse",
				"Energy-Ball",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"Simple-Beam",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Ally-Switch",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Elgyem PokemonInstance Class
	#region Elgyem
	public class ElgyemInstance : PokemonInstance
	{
		#region Elgyem Constructors
		/// <summary>
		/// Elgyem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ElgyemInstance(string nickname, int level)
		: base(
				SpeciesElgyem.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elgyem Builder only waiting for a Level
		/// </summary>
		public ElgyemInstance(int level)
		: base(
				SpeciesElgyem.Instance, // PokemonInstance Species
				"Elgyem", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elgyem Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ElgyemInstance() : base(
			SpeciesElgyem.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}