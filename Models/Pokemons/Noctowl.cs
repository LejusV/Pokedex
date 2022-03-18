using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Noctowl Species to store common natural stats of all Noctowls
	#region SpeciesNoctowl
	public class SpeciesNoctowl : PokemonSpecies
	{
#nullable enable
		private static SpeciesNoctowl? _instance = null;
#nullable restore
        public static SpeciesNoctowl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNoctowl();
                }
                return _instance;
            }
        }

		#region SpeciesNoctowl Constructor
		public SpeciesNoctowl() : base(
			164,
			"Noctowl",
			1.6,
			40.8,
			100, // HPs
			50, 50, // Attack & Defense
			86, 96, // Special Attack & Defense
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
				"Fly",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Peck",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Silver-Wind",
				"Extrasensory",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Psycho-Shift",
				"Air-Slash",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Moonblast",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Noctowl PokemonInstance Class
	#region Noctowl
	public class NoctowlInstance : PokemonInstance
	{
		#region Noctowl Constructors
		/// <summary>
		/// Noctowl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NoctowlInstance(string nickname, int level)
		: base(
				SpeciesNoctowl.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noctowl Builder only waiting for a Level
		/// </summary>
		public NoctowlInstance(int level)
		: base(
				SpeciesNoctowl.Instance, // PokemonInstance Species
				"Noctowl", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noctowl Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NoctowlInstance() : base(
			SpeciesNoctowl.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}