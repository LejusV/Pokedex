using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Beheeyem Species to store common natural stats of all Beheeyems
	#region SpeciesBeheeyem
	public class SpeciesBeheeyem : PokemonSpecies
	{
#nullable enable
		private static SpeciesBeheeyem? _instance = null;
#nullable restore
        public static SpeciesBeheeyem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBeheeyem();
                }
                return _instance;
            }
        }

		#region SpeciesBeheeyem Constructor
		public SpeciesBeheeyem() : base(
			"Beheeyem",
			1.0,
			34.5,
			75, // HPs
			75, 75, // Attack & Defense
			125, 95, // Special Attack & Defense
			40		
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
				"Psybeam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Recover",
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
				"Rock-Tomb",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Miracle-Eye",
				"Embargo",
				"Heal-Block",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
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
				"Confide",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Beheeyem PokemonInstance Class
	#region Beheeyem
	public class BeheeyemInstance : PokemonInstance
	{
		#region Beheeyem Constructors
		/// <summary>
		/// Beheeyem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BeheeyemInstance(string nickname, int level)
		: base(
				606,
				SpeciesBeheeyem.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beheeyem Builder only waiting for a Level
		/// </summary>
		public BeheeyemInstance(int level)
		: base(
				606,
				SpeciesBeheeyem.Instance, // PokemonInstance Species
				"Beheeyem", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beheeyem Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Beheeyem() : base(
			606,
			SpeciesBeheeyem.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}